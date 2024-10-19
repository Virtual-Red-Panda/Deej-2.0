Imports System.Media
Imports System.ComponentModel

Imports System.Drawing.Text
Imports System.IO

Public Class SplashForm
    Private WithEvents bgWorker As New BackgroundWorker()

    ' Constructor
    Public Sub New()
        InitializeComponent()
        InitializeBackgroundWorker()
    End Sub

    ' Inicializa el BackgroundWorker
    Private Sub InitializeBackgroundWorker()
        bgWorker.WorkerReportsProgress = True
        AddHandler bgWorker.DoWork, AddressOf bgWorker_DoWork
        AddHandler bgWorker.ProgressChanged, AddressOf bgWorker_ProgressChanged
    End Sub

    ' Método para iniciar la carga
    Public Sub StartLoading()
        bgWorker.RunWorkerAsync()
    End Sub

    ' Método que se ejecuta en el hilo del BackgroundWorker
    Private Sub bgWorker_DoWork(sender As Object, e As DoWorkEventArgs)
        For i As Integer = 0 To 100
            ' Reporta el progreso al hilo principal
            bgWorker.ReportProgress(i)
            Threading.Thread.Sleep(50) ' Simula un proceso con tiempo de espera
        Next
    End Sub

    ' Método que actualiza la barra circular y controla el desvanecimiento
    Private Sub bgWorker_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        UpdateProgress(e.ProgressPercentage)
    End Sub

    ' Método para actualizar el valor de la barra circular
    Public Sub UpdateProgress(value As Integer)
        CircularProgressBar1.Value = value
        CircularProgressBar1.Text = value.ToString() & "%"

        If value >= 100 Then
            ' Reproduce el sonido de bienvenida
            Dim player As New SoundPlayer(My.Resources.alert) ' Asegúrate de que el archivo esté en los recursos del proyecto
            player.Play()

            ' Inicia el efecto de desvanecimiento
            StartFadeOut()
        End If
    End Sub

    ' Método para realizar el efecto de desvanecimiento
    Private Sub StartFadeOut()
        Dim fadeDuration As Integer = 500 ' Duración del desvanecimiento en milisegundos
        Dim fadeStep As Integer = 5 ' Cada cuánto reducir la opacidad
        Dim timer As New Timer()
        AddHandler timer.Tick, AddressOf FadeOutTick
        timer.Interval = fadeStep
        timer.Start()
    End Sub

    Private Sub FadeOutTick(sender As Object, e As EventArgs)
        ' Reduce la opacidad del formulario
        If Me.Opacity > 0 Then
            Me.Opacity -= 0.05 ' Ajusta el paso de desvanecimiento
        Else
            Me.Close() ' Cierra el formulario cuando la opacidad llega a 0
            CType(sender, Timer).Stop()
        End If
    End Sub


End Class
