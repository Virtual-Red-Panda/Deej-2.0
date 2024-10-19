Imports System.ComponentModel
Imports System.Drawing.Text
Imports System.IO
Imports System.IO.Ports
Imports System.Runtime.InteropServices
Imports NAudio.CoreAudioApi
Public Class Form1
    Dim WithEvents SerialPort As New SerialPort
    Private deviceEnumerator As MMDeviceEnumerator
    Private device As MMDevice
    Private sessions As AudioSessionManager
    Private splash As SplashForm
    Private Const FolderPath As String = "Fondos"
    Private WithEvents bgWorker As New BackgroundWorker()
    Private appNames As New List(Of String)()
    Private logFilePath As String = "error_logs/logs.txt" ' Ruta para el archivo de log
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function PostMessage(hWnd As IntPtr, msg As Integer, wParam As IntPtr, lParam As IntPtr) As Boolean
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim savedColor As Color = My.Settings.TextColor
        ChangeTextColor(savedColor)
        Dim backgroundFile As String = Path.Combine(FolderPath, "background.png")
        If File.Exists(backgroundFile) Then
            Me.BackgroundImage = Image.FromFile(backgroundFile)
            Me.BackgroundImageLayout = ImageLayout.Stretch
        End If
        ' Cargar la fuente guardada en los Settings
        If My.Settings.FuenteTexto IsNot Nothing Then
            Me.Font = My.Settings.FuenteTexto
        End If
        Try
            ' Crear el archivo de log al iniciar la aplicación
            File.AppendAllText(logFilePath, "Aplicación iniciada: " & DateTime.Now.ToString() & Environment.NewLine)

            ' Inicializar el dispositivo de audio
            deviceEnumerator = New MMDeviceEnumerator()
            device = deviceEnumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia)
            sessions = device.AudioSessionManager

            ' Cargar los puertos COM disponibles en el ComboBox
            LoadAvailablePorts()

            ' Mostrar pantalla de carga
            splash = New SplashForm()
            splash.Show()

            ' Simular el proceso de carga
            For i As Integer = 0 To 100
                splash.UpdateProgress(i)
                Threading.Thread.Sleep(10)
                Application.DoEvents()
            Next
            splash.Close()
            Me.Show()
        Catch ex As Exception
            LogError("Error al iniciar la aplicación: " & ex.Message)
            MessageBox.Show("Error al iniciar la aplicación: " & ex.Message)
        End Try
    End Sub
    Private Sub ChangeTextColor(color As Color)
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Label Then
                CType(ctrl, Label).ForeColor = color
            ElseIf TypeOf ctrl Is Button Then
                CType(ctrl, Button).ForeColor = color
            ElseIf TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).ForeColor = color
            End If
            ' Agrega más tipos de control si es necesario
        Next
    End Sub
    Private Sub btnSelectColor_Click(sender As Object, e As EventArgs) Handles btnSelectColor.Click
        Using colorDialog As New ColorDialog()
            colorDialog.FullOpen = True
            colorDialog.AllowFullOpen = True

            If colorDialog.ShowDialog() = DialogResult.OK Then
                ' Cambiar el color de todos los textos del formulario
                ChangeTextColor(colorDialog.Color)

                ' Guardar el color seleccionado en las configuraciones
                My.Settings.TextColor = colorDialog.Color
                My.Settings.Save() ' Guardar los cambios
            End If
        End Using
    End Sub
    Private Sub btnChangeBackground_Click(sender As Object, e As EventArgs) Handles btnChangeBackground.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Archivos PNG (*.png)|*.png|Todos los archivos (*.*)|*.*"
            openFileDialog.Title = "Seleccionar imagen de fondo"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Try
                    ' Crear la carpeta si no existe
                    If Not Directory.Exists(FolderPath) Then
                        Directory.CreateDirectory(FolderPath)
                    End If

                    ' Eliminar la imagen anterior si existe
                    Dim previousBackground As String = Path.Combine(FolderPath, "background.png")
                    If File.Exists(previousBackground) Then
                        ' Liberar el objeto de la imagen si está en uso
                        Me.BackgroundImage.Dispose()
                        File.Delete(previousBackground)
                    End If
                    ' Guarzar la nueva imagen
                    File.Copy(openFileDialog.FileName, previousBackground)

                    ' Cargar la nueva imagen como fondo
                    Me.BackgroundImage = Image.FromFile(previousBackground)
                    Me.BackgroundImageLayout = ImageLayout.Stretch
                Catch ex As Exception
                    MessageBox.Show("Error al cargar la imagen: " & ex.Message)
                End Try
            End If
        End Using
    End Sub
    Private Sub btnRemoveBackground_Click(sender As Object, e As EventArgs) Handles btnRemoveBackground.Click
        ' Liberar la imagen de fondo actual si está en uso
        If Me.BackgroundImage IsNot Nothing Then
            Me.BackgroundImage.Dispose() ' Liberar el recurso
        End If
        ' Eliminar la imagen de fondo
        Me.BackgroundImage = Nothing
        ' Restablecer el fondo a la imagen predeterminada configurada en el diseñador
        Me.BackgroundImage = My.Resources.DefaultBackground ' Cambia DefaultBackground por el nombre de tu recurso
        ' Opcional: eliminar la imagen de la carpeta "Fondos"
        Dim backgroundPath As String = Path.Combine("Fondos", "background.png") ' Asegúrate de que el nombre del archivo sea correcto

        If File.Exists(backgroundPath) Then
            Try
                File.Delete(backgroundPath)
                MessageBox.Show("Fondo eliminado y archivo de imagen borrado.")
            Catch ex As Exception
                MessageBox.Show("Error al eliminar el archivo de imagen: " & ex.Message)
            End Try
        Else
            MessageBox.Show("No se encontró el archivo de fondo para eliminar.")
        End If
    End Sub

    Private Sub btnChangeTextColor_Click(sender As Object, e As EventArgs) Handles btnChangeTextColor.Click
        If Me.BackgroundImage IsNot Nothing Then
            ' Crear un bitmap de la imagen de fondo
            Dim bmp As New Bitmap(Me.BackgroundImage)

            ' Obtener el color promedio de la imagen
            Dim averageColor As Color = GetAverageColor(bmp)

            ' Determinar un color de texto que contraste
            Dim textColor As Color = GetContrastingColor(averageColor)

            ' Cambiar el color de todos los controles de texto en el formulario
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Label Or TypeOf ctrl Is TextBox Or TypeOf ctrl Is Button Then
                    ctrl.ForeColor = textColor
                End If
            Next

            bmp.Dispose()
        Else
            MessageBox.Show("No hay imagen de fondo para analizar.")
        End If
    End Sub
    Private Function GetAverageColor(bitmap As Bitmap) As Color
        Dim totalR As Long = 0
        Dim totalG As Long = 0
        Dim totalB As Long = 0
        Dim pixelCount As Long = 0

        Dim rect As New Rectangle(0, 0, bitmap.Width, bitmap.Height)
        Dim bmpData As System.Drawing.Imaging.BitmapData = bitmap.LockBits(rect, Imaging.ImageLockMode.ReadOnly, bitmap.PixelFormat)

        Dim bytesPerPixel As Integer = 4 ' Asumiendo formato ARGB
        Dim byteCount As Integer = bmpData.Stride * bmpData.Height
        Dim pixels As Byte() = New Byte(byteCount - 1) {}

        System.Runtime.InteropServices.Marshal.Copy(bmpData.Scan0, pixels, 0, byteCount)
        bitmap.UnlockBits(bmpData)

        For y As Integer = 0 To bmpData.Height - 1
            For x As Integer = 0 To bmpData.Width - 1
                Dim index As Integer = (y * bmpData.Stride) + (x * bytesPerPixel)
                Dim b As Byte = pixels(index)
                Dim g As Byte = pixels(index + 1)
                Dim r As Byte = pixels(index + 2)

                totalB += b
                totalG += g
                totalR += r
                pixelCount += 1
            Next
        Next

        If pixelCount > 0 Then
            Return Color.FromArgb(CInt(totalR / pixelCount), CInt(totalG / pixelCount), CInt(totalB / pixelCount))
        Else
            Return Color.Empty
        End If
    End Function
    Private Function GetContrastingColor(color As Color) As Color
        ' Calcular el brillo del color
        Dim brightness As Double = (0.299 * color.R + 0.587 * color.G + 0.114 * color.B)
        ' Si el brillo es menor que 128, usar blanco, de lo contrario usar negro
        If brightness < 128 Then
            Return Color.White
        Else
            Return Color.Black
        End If
    End Function
    Private Sub LoadAvailablePorts()
        Try
            cmbPortSelector.Items.Clear()
            Dim ports As String() = SerialPort.GetPortNames()
            cmbPortSelector.Items.AddRange(ports)

            If cmbPortSelector.Items.Count > 0 Then
                cmbPortSelector.SelectedIndex = 0
            End If
        Catch ex As Exception
            LogError("Error al cargar los puertos COM: " & ex.Message)
            MessageBox.Show("Error al cargar los puertos COM: " & ex.Message)
        End Try
    End Sub

    Private Sub cbProgramSelector_DropDown(sender As Object, e As EventArgs) Handles cbProgramSelector.DropDown
        Try
            UpdateAudioSessions()
            LoadRunningApplicationsForComboBox(cbProgramSelector)
        Catch ex As Exception
            LogError("Error al actualizar las aplicaciones: " & ex.Message)
            MessageBox.Show("Error al actualizar las aplicaciones: " & ex.Message)
        End Try
    End Sub

    Private Sub cbProgramSelector2_DropDown(sender As Object, e As EventArgs) Handles cbProgramSelector2.DropDown
        Try
            UpdateAudioSessions()
            LoadRunningApplicationsForComboBox(cbProgramSelector2)
        Catch ex As Exception
            LogError("Error al actualizar las aplicaciones: " & ex.Message)
            MessageBox.Show("Error al actualizar las aplicaciones: " & ex.Message)
        End Try
    End Sub

    Private Sub cbProgramSelector3_DropDown(sender As Object, e As EventArgs) Handles cbProgramSelector3.DropDown
        Try
            UpdateAudioSessions()
            LoadRunningApplicationsForComboBox(cbProgramSelector3)
        Catch ex As Exception
            LogError("Error al actualizar las aplicaciones: " & ex.Message)
            MessageBox.Show("Error al actualizar las aplicaciones: " & ex.Message)
        End Try
    End Sub
    Private Sub UpdateAudioSessions()
        Try
            deviceEnumerator = New MMDeviceEnumerator()
            device = deviceEnumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia)
            sessions = device.AudioSessionManager
        Catch ex As Exception
            LogError("Error al actualizar las sesiones de audio: " & ex.Message)
            MessageBox.Show("Error al actualizar las sesiones de audio: " & ex.Message)
        End Try
    End Sub
    ' Crear una lista para almacenar las aplicaciones en uso
    Dim applicationsInUse As New List(Of String)
    Private Sub cbProgramSelector1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProgramSelector.SelectedIndexChanged
        If cbProgramSelector.SelectedItem IsNot Nothing Then
            Dim selectedApp As String = cbProgramSelector.SelectedItem.ToString()

            ' Verificar si la aplicación ya está en uso
            If applicationsInUse.Contains(selectedApp) Then
                MessageBox.Show("La aplicación ya está en uso en otro control.")
                cbProgramSelector.SelectedItem = Nothing ' Restablecer la selección
                Return
            End If

            ' Agregar la aplicación seleccionada a la lista de uso
            applicationsInUse.Add(selectedApp)
        End If
    End Sub
    Private Sub cbProgramSelector2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProgramSelector2.SelectedIndexChanged
        If cbProgramSelector2.SelectedItem IsNot Nothing Then
            Dim selectedApp As String = cbProgramSelector2.SelectedItem.ToString()

            ' Verificar si la aplicación ya está en uso
            If applicationsInUse.Contains(selectedApp) Then
                MessageBox.Show("La aplicación ya está en uso en otro control.")
                cbProgramSelector2.SelectedItem = Nothing ' Restablecer la selección
                Return
            End If
            ' Agregar la aplicación seleccionada a la lista de uso
            applicationsInUse.Add(selectedApp)
        End If
    End Sub
    ' Evento para manejar la deselección de aplicaciones al cerrar un programa
    Private Sub ClearApplication(selectedApp As String)
        If applicationsInUse.Contains(selectedApp) Then
            applicationsInUse.Remove(selectedApp)
        End If
    End Sub
    Private Sub LoadRunningApplicationsForComboBox(comboBox As ComboBox)
        Try
            comboBox.Items.Clear()
            appNames.Clear()

            For i As Integer = 0 To sessions.Sessions.Count - 1
                Dim session = sessions.Sessions(i)
                Dim displayName As String = session.DisplayName

                If Not String.IsNullOrEmpty(displayName) Then
                    ' Verificar si el nombre es el del sonido del sistema
                    If displayName.Contains("AudioSrv") Then
                        appNames.Add("Sonido del Sistema")
                    Else
                        appNames.Add(displayName)
                    End If
                Else
                    Dim processID As Integer = session.GetProcessID()
                    Dim processName As String = GetProcessNameByPID(processID)
                    appNames.Add(If(String.IsNullOrEmpty(processName), "Aplicación desconocida (PID: " & processID.ToString() & ")", processName))
                End If
            Next
            ' Mostrar todas las sesiones, incluidas las duplicadas
            For Each appName In appNames
                comboBox.Items.Add(appName)
            Next
        Catch ex As Exception
            LogError("Error al cargar aplicaciones en ejecución: " & ex.Message)
            MessageBox.Show("Error al cargar aplicaciones en ejecución: " & ex.Message)
        End Try
    End Sub
    Private Function GetProcessNameByPID(processID As Integer) As String
        Try
            Dim process As Process = Process.GetProcessById(processID)
            Return process.ProcessName
        Catch ex As Exception
            LogError("Error al obtener el nombre del proceso por PID: " & ex.Message)
            Return String.Empty
        End Try
    End Function
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If cmbPortSelector.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, selecciona un puerto COM.")
            Return
        End If
        Dim portName As String = cmbPortSelector.SelectedItem.ToString()
        Dim baudRate As Integer = 115200
        Try
            ' Cerrar el puerto si ya está abierto
            If SerialPort.IsOpen Then
                SerialPort.Close()
                ' Esperar un momento para liberar el puerto completamente
                System.Threading.Thread.Sleep(100)
            End If
            ' Configurar el puerto serie con el puerto y baudios seleccionados
            SerialPort.PortName = portName
            SerialPort.BaudRate = baudRate
            SerialPort.DtrEnable = True ' Habilitar DTR para reiniciar el Arduino
            ' Abrir el puerto serial
            SerialPort.Open()
            ' Reiniciar Arduino al cambiar el estado de DTR
            SerialPort.DtrEnable = False
            System.Threading.Thread.Sleep(100)
            SerialPort.DtrEnable = True
            ' Limpiar buffers para asegurarse de que no haya datos antiguos
            SerialPort.DiscardInBuffer()
            SerialPort.DiscardOutBuffer()
            ' Esperar para asegurarse de que Arduino se reinicia completamente
            System.Threading.Thread.Sleep(2000) ' 2 segundos de espera
            ' Comprobar si el puerto se abrió correctamente
            If SerialPort.IsOpen Then
                LogMessage("Conexión con Arduino establecida en " & portName & " a " & baudRate.ToString() & " baudios.")
                MessageBox.Show("Conexión con Arduino establecida en " & portName & " a " & baudRate.ToString() & " baudios.")
            Else
                LogError("No se pudo abrir el puerto " & portName)
                MessageBox.Show("No se pudo abrir el puerto " & portName & ".")
            End If
        Catch ex As UnauthorizedAccessException
            LogError("Acceso denegado al puerto COM: " & ex.Message)
            MessageBox.Show("Acceso denegado al puerto COM. Asegúrate de que ningún otro programa esté usando el puerto.")
        Catch ex As IOException
            LogError("Error de entrada/salida: " & ex.Message)
            MessageBox.Show("Error de entrada/salida. Puede que el puerto no esté disponible.")
        Catch ex As Exception
            LogError("Error al abrir el puerto serie: " & ex.Message)
            MessageBox.Show("Error al abrir el puerto serie: " & ex.Message)
        End Try
    End Sub
    Private Sub SerialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        Try
            ' Leer datos disponibles en el buffer
            If SerialPort.BytesToRead > 0 Then
                Dim data As String = SerialPort.ReadLine().Trim()
                Me.Invoke(Sub() ProcessArduinoData(data))
            End If
        Catch ex As Exception
            LogError("Error al recibir datos del Arduino: " & ex.Message)
            MessageBox.Show("Error al recibir datos del Arduino: " & ex.Message)
        End Try
    End Sub
    Private Sub ProcessArduinoData(data As String)
        Try
            Dim values As String() = data.Split(","c)
            If values.Length = 4 Then
                Dim masterVolume As Integer = Convert.ToInt32(values(0).Trim())
                Dim appVolume As Integer = Convert.ToInt32(values(1).Trim())
                Dim appVolume2 As Integer = Convert.ToInt32(values(2).Trim())
                Dim anotherValue As Integer = Convert.ToInt32(values(3).Trim())
                ' Actualizar el volumen maestro
                If masterVolume >= 0 And masterVolume <= 100 Then
                    Dim normalizedMasterVolume As Single = masterVolume / 100.0F
                    device.AudioEndpointVolume.MasterVolumeLevelScalar = normalizedMasterVolume
                    lblVolume.Text = "Volumen Aplicación: " & masterVolume.ToString() & "%"
                    lblVolume.Value = masterVolume
                    pbAudioLevel.Value = masterVolume
                    CircularProgressBar1.Value = masterVolume
                    CircularProgressBar1.Text = masterVolume.ToString() & "%"
                End If
                ' Verificar que el CheckBox esté seleccionado antes de actualizar el volumen de las aplicaciones
                If chkApp1.Checked AndAlso appVolume >= 0 And appVolume <= 100 AndAlso cbProgramSelector.SelectedIndex <> -1 Then
                    Dim session = sessions.Sessions(cbProgramSelector.SelectedIndex)
                    Dim newAppVolume As Single = appVolume / 100.0F
                    session.SimpleAudioVolume.Volume = newAppVolume

                    lblAppVolume.Text = "Volumen Aplicación: " & appVolume.ToString() & "%"
                    CircularProgressBar.Value = appVolume
                    CircularProgressBar.Text = appVolume.ToString() & "%"

                    SerialPort.WriteLine(cbProgramSelector.SelectedItem.ToString())
                End If

                If chkApp2.Checked AndAlso appVolume2 >= 0 And appVolume2 <= 100 AndAlso cbProgramSelector2.SelectedIndex <> -1 Then
                    Dim session = sessions.Sessions(cbProgramSelector2.SelectedIndex)
                    Dim newAppVolume2 As Single = appVolume2 / 100.0F
                    session.SimpleAudioVolume.Volume = newAppVolume2

                    lblAppVolume2.Text = "Volumen Aplicación 2: " & appVolume2.ToString() & "%"
                    CircularProgressBar2.Value = appVolume2
                    CircularProgressBar2.Text = appVolume2.ToString() & "%"

                    SerialPort.WriteLine(cbProgramSelector2.SelectedItem.ToString())
                End If

                If chkApp3.Checked AndAlso anotherValue >= 0 And anotherValue <= 100 AndAlso cbProgramSelector3.SelectedIndex <> -1 Then
                    Dim session = sessions.Sessions(cbProgramSelector3.SelectedIndex)
                    Dim newAppVolume3 As Single = anotherValue / 100.0F
                    session.SimpleAudioVolume.Volume = newAppVolume3

                    lblAppVolume3.Text = "Volumen Aplicación 3: " & anotherValue.ToString() & "%"
                    CircularProgressBar3.Value = anotherValue
                    CircularProgressBar3.Text = anotherValue.ToString() & "%"

                    SerialPort.WriteLine(cbProgramSelector3.SelectedItem.ToString())
                End If
            End If
        Catch ex As Exception
            LogError("Error al procesar los datos del Arduino: " & ex.Message)
            MessageBox.Show("Error al procesar los datos del Arduino: " & ex.Message)
        End Try
    End Sub
    Private Sub chkApp1_CheckedChanged(sender As Object, e As EventArgs) Handles chkApp1.CheckedChanged
        cbProgramSelector.Enabled = Not chkApp1.Checked
    End Sub
    Private Sub chkApp2_CheckedChanged(sender As Object, e As EventArgs) Handles chkApp2.CheckedChanged
        cbProgramSelector2.Enabled = Not chkApp2.Checked
    End Sub
    Private Sub chkApp3_CheckedChanged(sender As Object, e As EventArgs) Handles chkApp3.CheckedChanged
        cbProgramSelector3.Enabled = Not chkApp3.Checked
    End Sub
    Private Sub cmbProgramSelector_Click(sender As Object, e As EventArgs) Handles cbProgramSelector.Click, cbProgramSelector2.Click, cbProgramSelector3.Click
        Dim selectedComboBox As ComboBox = CType(sender, ComboBox)
        LoadRunningApplicationsForComboBox(selectedComboBox)
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Reproducir el sonido desde los recursos
        Try
            Dim player As New System.Media.SoundPlayer(My.Resources.error_8)
            player.Play()
        Catch ex As Exception
            MessageBox.Show("Error al reproducir el sonido: " & ex.Message)
        End Try
        ' Preguntar al usuario si realmente desea cerrar la aplicación
        Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea cerrar la aplicación?", "Confirmación de cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.No Then
            ' Cancelar el cierre de la aplicación
            e.Cancel = True
            Return
        End If
        ' Intentar cerrar el puerto serie si está abierto
        If SerialPort.IsOpen Then
            Try
                ' Limpiar los buffers de entrada y salida antes de cerrar
                SerialPort.DiscardInBuffer()
                SerialPort.DiscardOutBuffer()

                ' Cerrar el puerto
                SerialPort.Close()

                ' Esperar un poco para asegurarse de que el puerto se cierra correctamente
                System.Threading.Thread.Sleep(500)
            Catch ex As Exception
                MessageBox.Show("Error al cerrar el puerto: " & ex.Message)
            End Try
        End If
        ' Forzar el cierre inmediato de la aplicación
        Environment.Exit(0)
    End Sub
    Private Sub LogError(message As String)
        File.AppendAllText(logFilePath, "ERROR: " & DateTime.Now.ToString() & " - " & message & Environment.NewLine)
    End Sub
    Private Sub LogMessage(message As String)
        File.AppendAllText(logFilePath, "INFO: " & DateTime.Now.ToString() & " - " & message & Environment.NewLine)
    End Sub
End Class





