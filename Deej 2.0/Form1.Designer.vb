<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cbProgramSelector = New System.Windows.Forms.ComboBox()
        Me.cbProgramSelector2 = New System.Windows.Forms.ComboBox()
        Me.cbProgramSelector3 = New System.Windows.Forms.ComboBox()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.pbAudioLevel = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CircularProgressBar = New CircularProgressBar.CircularProgressBar()
        Me.CircularProgressBar1 = New CircularProgressBar.CircularProgressBar()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CircularProgressBar2 = New CircularProgressBar.CircularProgressBar()
        Me.CircularProgressBar3 = New CircularProgressBar.CircularProgressBar()
        Me.cmbPortSelector = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CircularProgressBar4 = New CircularProgressBar.CircularProgressBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarFondoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnChangeBackground = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnRemoveBackground = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorDeTextoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnChangeTextColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSelectColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.chkApp1 = New System.Windows.Forms.CheckBox()
        Me.chkApp2 = New System.Windows.Forms.CheckBox()
        Me.chkApp3 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.lblAppVolume3 = New System.Windows.Forms.TrackBar()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.lblAppVolume2 = New System.Windows.Forms.TrackBar()
        Me.lblAppVolume = New System.Windows.Forms.TrackBar()
        Me.lblVolume = New System.Windows.Forms.TrackBar()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAppVolume3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAppVolume2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAppVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbProgramSelector
        '
        Me.cbProgramSelector.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.cbProgramSelector.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbProgramSelector.Font = New System.Drawing.Font("New Super Mario Font U", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProgramSelector.FormattingEnabled = True
        Me.cbProgramSelector.Location = New System.Drawing.Point(608, 349)
        Me.cbProgramSelector.Name = "cbProgramSelector"
        Me.cbProgramSelector.Size = New System.Drawing.Size(170, 20)
        Me.cbProgramSelector.TabIndex = 5
        '
        'cbProgramSelector2
        '
        Me.cbProgramSelector2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProgramSelector2.Font = New System.Drawing.Font("New Super Mario Font U", 9.0!)
        Me.cbProgramSelector2.FormattingEnabled = True
        Me.cbProgramSelector2.Location = New System.Drawing.Point(445, 350)
        Me.cbProgramSelector2.Name = "cbProgramSelector2"
        Me.cbProgramSelector2.Size = New System.Drawing.Size(140, 20)
        Me.cbProgramSelector2.TabIndex = 6
        '
        'cbProgramSelector3
        '
        Me.cbProgramSelector3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProgramSelector3.Font = New System.Drawing.Font("New Super Mario Font U", 9.0!)
        Me.cbProgramSelector3.FormattingEnabled = True
        Me.cbProgramSelector3.Location = New System.Drawing.Point(241, 349)
        Me.cbProgramSelector3.Name = "cbProgramSelector3"
        Me.cbProgramSelector3.Size = New System.Drawing.Size(170, 20)
        Me.cbProgramSelector3.TabIndex = 7
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(754, 575)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 8
        Me.btnApply.Text = "Reset"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.BackgroundImage = CType(resources.GetObject("btnStart.BackgroundImage"), System.Drawing.Image)
        Me.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStart.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnStart.Location = New System.Drawing.Point(877, 505)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnStart.Size = New System.Drawing.Size(100, 93)
        Me.btnStart.TabIndex = 9
        Me.btnStart.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'pbAudioLevel
        '
        Me.pbAudioLevel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pbAudioLevel.Location = New System.Drawing.Point(796, 349)
        Me.pbAudioLevel.Name = "pbAudioLevel"
        Me.pbAudioLevel.Size = New System.Drawing.Size(137, 19)
        Me.pbAudioLevel.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("New Super Mario Font U", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(12, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 22)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Virtual Consola V2,1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label2.Location = New System.Drawing.Point(791, 381)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 19)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Volumen Master Pc"
        '
        'CircularProgressBar
        '
        Me.CircularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CircularProgressBar.AnimationSpeed = 500
        Me.CircularProgressBar.BackColor = System.Drawing.Color.Transparent
        Me.CircularProgressBar.Font = New System.Drawing.Font("New Super Mario Font U", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CircularProgressBar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CircularProgressBar.InnerColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CircularProgressBar.InnerMargin = 2
        Me.CircularProgressBar.InnerWidth = -1
        Me.CircularProgressBar.Location = New System.Drawing.Point(677, 254)
        Me.CircularProgressBar.MarqueeAnimationSpeed = 2000
        Me.CircularProgressBar.Name = "CircularProgressBar"
        Me.CircularProgressBar.OuterColor = System.Drawing.Color.White
        Me.CircularProgressBar.OuterMargin = -25
        Me.CircularProgressBar.OuterWidth = 26
        Me.CircularProgressBar.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.CircularProgressBar.ProgressWidth = 25
        Me.CircularProgressBar.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.CircularProgressBar.Size = New System.Drawing.Size(87, 86)
        Me.CircularProgressBar.StartAngle = 270
        Me.CircularProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBar.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CircularProgressBar.SubscriptText = ""
        Me.CircularProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBar.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CircularProgressBar.SuperscriptText = ""
        Me.CircularProgressBar.TabIndex = 15
        Me.CircularProgressBar.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.CircularProgressBar.Value = 68
        '
        'CircularProgressBar1
        '
        Me.CircularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CircularProgressBar1.AnimationSpeed = 500
        Me.CircularProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.CircularProgressBar1.Font = New System.Drawing.Font("New Super Mario Font U", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CircularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CircularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CircularProgressBar1.InnerMargin = 2
        Me.CircularProgressBar1.InnerWidth = -1
        Me.CircularProgressBar1.Location = New System.Drawing.Point(846, 254)
        Me.CircularProgressBar1.MarqueeAnimationSpeed = 2000
        Me.CircularProgressBar1.Name = "CircularProgressBar1"
        Me.CircularProgressBar1.OuterColor = System.Drawing.Color.White
        Me.CircularProgressBar1.OuterMargin = -25
        Me.CircularProgressBar1.OuterWidth = 26
        Me.CircularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CircularProgressBar1.ProgressWidth = 25
        Me.CircularProgressBar1.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.CircularProgressBar1.Size = New System.Drawing.Size(87, 86)
        Me.CircularProgressBar1.StartAngle = 270
        Me.CircularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBar1.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CircularProgressBar1.SubscriptText = ""
        Me.CircularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBar1.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CircularProgressBar1.SuperscriptText = ""
        Me.CircularProgressBar1.TabIndex = 16
        Me.CircularProgressBar1.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.CircularProgressBar1.Value = 68
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("New Super Mario Font U", 9.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(65, 348)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(170, 20)
        Me.ComboBox1.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("New Super Mario Font U", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label3.Location = New System.Drawing.Point(656, 377)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 22)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Canal 1"
        '
        'CircularProgressBar2
        '
        Me.CircularProgressBar2.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CircularProgressBar2.AnimationSpeed = 500
        Me.CircularProgressBar2.BackColor = System.Drawing.Color.Transparent
        Me.CircularProgressBar2.Font = New System.Drawing.Font("New Super Mario Font U", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CircularProgressBar2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CircularProgressBar2.InnerColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CircularProgressBar2.InnerMargin = 2
        Me.CircularProgressBar2.InnerWidth = -1
        Me.CircularProgressBar2.Location = New System.Drawing.Point(498, 258)
        Me.CircularProgressBar2.MarqueeAnimationSpeed = 2000
        Me.CircularProgressBar2.Name = "CircularProgressBar2"
        Me.CircularProgressBar2.OuterColor = System.Drawing.Color.White
        Me.CircularProgressBar2.OuterMargin = -25
        Me.CircularProgressBar2.OuterWidth = 26
        Me.CircularProgressBar2.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.CircularProgressBar2.ProgressWidth = 25
        Me.CircularProgressBar2.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.CircularProgressBar2.Size = New System.Drawing.Size(87, 86)
        Me.CircularProgressBar2.StartAngle = 270
        Me.CircularProgressBar2.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBar2.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CircularProgressBar2.SubscriptText = ""
        Me.CircularProgressBar2.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBar2.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CircularProgressBar2.SuperscriptText = ""
        Me.CircularProgressBar2.TabIndex = 23
        Me.CircularProgressBar2.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.CircularProgressBar2.Value = 68
        '
        'CircularProgressBar3
        '
        Me.CircularProgressBar3.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CircularProgressBar3.AnimationSpeed = 500
        Me.CircularProgressBar3.BackColor = System.Drawing.Color.Transparent
        Me.CircularProgressBar3.Font = New System.Drawing.Font("New Super Mario Font U", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CircularProgressBar3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CircularProgressBar3.InnerColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CircularProgressBar3.InnerMargin = 2
        Me.CircularProgressBar3.InnerWidth = -1
        Me.CircularProgressBar3.Location = New System.Drawing.Point(292, 254)
        Me.CircularProgressBar3.MarqueeAnimationSpeed = 2000
        Me.CircularProgressBar3.Name = "CircularProgressBar3"
        Me.CircularProgressBar3.OuterColor = System.Drawing.Color.White
        Me.CircularProgressBar3.OuterMargin = -25
        Me.CircularProgressBar3.OuterWidth = 26
        Me.CircularProgressBar3.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.CircularProgressBar3.ProgressWidth = 25
        Me.CircularProgressBar3.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.CircularProgressBar3.Size = New System.Drawing.Size(87, 86)
        Me.CircularProgressBar3.StartAngle = 270
        Me.CircularProgressBar3.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBar3.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CircularProgressBar3.SubscriptText = ""
        Me.CircularProgressBar3.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBar3.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CircularProgressBar3.SuperscriptText = ""
        Me.CircularProgressBar3.TabIndex = 24
        Me.CircularProgressBar3.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.CircularProgressBar3.Value = 68
        '
        'cmbPortSelector
        '
        Me.cmbPortSelector.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.cmbPortSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPortSelector.Font = New System.Drawing.Font("New Super Mario Font U", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPortSelector.FormattingEnabled = True
        Me.cmbPortSelector.Location = New System.Drawing.Point(888, 4)
        Me.cmbPortSelector.Name = "cmbPortSelector"
        Me.cmbPortSelector.Size = New System.Drawing.Size(89, 20)
        Me.cmbPortSelector.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("New Super Mario Font U", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label7.Location = New System.Drawing.Point(483, 377)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 22)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Canal 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("New Super Mario Font U", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(288, 377)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 22)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Canal 3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("New Super Mario Font U", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label5.Location = New System.Drawing.Point(108, 377)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 22)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Canal 4"
        '
        'CircularProgressBar4
        '
        Me.CircularProgressBar4.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CircularProgressBar4.AnimationSpeed = 500
        Me.CircularProgressBar4.BackColor = System.Drawing.Color.Transparent
        Me.CircularProgressBar4.Font = New System.Drawing.Font("New Super Mario Font U", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CircularProgressBar4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CircularProgressBar4.InnerColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CircularProgressBar4.InnerMargin = 2
        Me.CircularProgressBar4.InnerWidth = -1
        Me.CircularProgressBar4.Location = New System.Drawing.Point(116, 254)
        Me.CircularProgressBar4.MarqueeAnimationSpeed = 2000
        Me.CircularProgressBar4.Name = "CircularProgressBar4"
        Me.CircularProgressBar4.OuterColor = System.Drawing.Color.White
        Me.CircularProgressBar4.OuterMargin = -25
        Me.CircularProgressBar4.OuterWidth = 26
        Me.CircularProgressBar4.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.CircularProgressBar4.ProgressWidth = 25
        Me.CircularProgressBar4.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.CircularProgressBar4.Size = New System.Drawing.Size(87, 86)
        Me.CircularProgressBar4.StartAngle = 270
        Me.CircularProgressBar4.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBar4.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CircularProgressBar4.SubscriptText = ""
        Me.CircularProgressBar4.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBar4.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CircularProgressBar4.SuperscriptText = ""
        Me.CircularProgressBar4.TabIndex = 29
        Me.CircularProgressBar4.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.CircularProgressBar4.Value = 68
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(941, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 36)
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("New Super Mario Font U", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(661, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(221, 22)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Selecciona el Puerto"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(998, 24)
        Me.MenuStrip1.TabIndex = 32
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.ModificarToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Image = CType(resources.GetObject("OpcionesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Image = CType(resources.GetObject("EditarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambiarFondoToolStripMenuItem, Me.ColorDeTextoToolStripMenuItem})
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'CambiarFondoToolStripMenuItem
        '
        Me.CambiarFondoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnChangeBackground, Me.btnRemoveBackground})
        Me.CambiarFondoToolStripMenuItem.Name = "CambiarFondoToolStripMenuItem"
        Me.CambiarFondoToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.CambiarFondoToolStripMenuItem.Text = "Cambiar fondo"
        '
        'btnChangeBackground
        '
        Me.btnChangeBackground.Name = "btnChangeBackground"
        Me.btnChangeBackground.Size = New System.Drawing.Size(154, 22)
        Me.btnChangeBackground.Text = "Cargar "
        '
        'btnRemoveBackground
        '
        Me.btnRemoveBackground.Name = "btnRemoveBackground"
        Me.btnRemoveBackground.Size = New System.Drawing.Size(154, 22)
        Me.btnRemoveBackground.Text = "Eliminar Fondo"
        '
        'ColorDeTextoToolStripMenuItem
        '
        Me.ColorDeTextoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnChangeTextColor, Me.btnSelectColor})
        Me.ColorDeTextoToolStripMenuItem.Name = "ColorDeTextoToolStripMenuItem"
        Me.ColorDeTextoToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ColorDeTextoToolStripMenuItem.Text = "Color de Texto"
        '
        'btnChangeTextColor
        '
        Me.btnChangeTextColor.Name = "btnChangeTextColor"
        Me.btnChangeTextColor.Size = New System.Drawing.Size(167, 22)
        Me.btnChangeTextColor.Text = "Automatico"
        '
        'btnSelectColor
        '
        Me.btnSelectColor.Name = "btnSelectColor"
        Me.btnSelectColor.Size = New System.Drawing.Size(167, 22)
        Me.btnSelectColor.Text = "Seleccionar color "
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(754, 528)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 34
        Me.btnStop.Text = "Button1"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'chkApp1
        '
        Me.chkApp1.AutoSize = True
        Me.chkApp1.BackColor = System.Drawing.Color.Transparent
        Me.chkApp1.Location = New System.Drawing.Point(635, 381)
        Me.chkApp1.Name = "chkApp1"
        Me.chkApp1.Size = New System.Drawing.Size(15, 14)
        Me.chkApp1.TabIndex = 36
        Me.chkApp1.UseVisualStyleBackColor = False
        '
        'chkApp2
        '
        Me.chkApp2.AutoSize = True
        Me.chkApp2.BackColor = System.Drawing.Color.Transparent
        Me.chkApp2.Location = New System.Drawing.Point(462, 381)
        Me.chkApp2.Name = "chkApp2"
        Me.chkApp2.Size = New System.Drawing.Size(15, 14)
        Me.chkApp2.TabIndex = 37
        Me.chkApp2.UseVisualStyleBackColor = False
        '
        'chkApp3
        '
        Me.chkApp3.AutoSize = True
        Me.chkApp3.BackColor = System.Drawing.Color.Transparent
        Me.chkApp3.Location = New System.Drawing.Point(271, 381)
        Me.chkApp3.Name = "chkApp3"
        Me.chkApp3.Size = New System.Drawing.Size(15, 14)
        Me.chkApp3.TabIndex = 38
        Me.chkApp3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(651, 575)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TrackBar1
        '
        Me.TrackBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TrackBar1.Location = New System.Drawing.Point(65, 159)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar1.Size = New System.Drawing.Size(45, 181)
        Me.TrackBar1.TabIndex = 18
        '
        'lblAppVolume3
        '
        Me.lblAppVolume3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.lblAppVolume3.Location = New System.Drawing.Point(241, 159)
        Me.lblAppVolume3.Maximum = 100
        Me.lblAppVolume3.Name = "lblAppVolume3"
        Me.lblAppVolume3.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.lblAppVolume3.Size = New System.Drawing.Size(45, 181)
        Me.lblAppVolume3.TabIndex = 3
        '
        'lblAppVolume2
        '
        Me.lblAppVolume2.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.lblAppVolume2.Location = New System.Drawing.Point(432, 162)
        Me.lblAppVolume2.Maximum = 100
        Me.lblAppVolume2.Name = "lblAppVolume2"
        Me.lblAppVolume2.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.lblAppVolume2.Size = New System.Drawing.Size(45, 181)
        Me.lblAppVolume2.TabIndex = 2
        '
        'lblAppVolume
        '
        Me.lblAppVolume.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.lblAppVolume.Location = New System.Drawing.Point(626, 159)
        Me.lblAppVolume.Maximum = 100
        Me.lblAppVolume.Name = "lblAppVolume"
        Me.lblAppVolume.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.lblAppVolume.Size = New System.Drawing.Size(45, 181)
        Me.lblAppVolume.TabIndex = 1
        '
        'lblVolume
        '
        Me.lblVolume.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblVolume.Location = New System.Drawing.Point(795, 159)
        Me.lblVolume.Maximum = 100
        Me.lblVolume.Name = "lblVolume"
        Me.lblVolume.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.lblVolume.Size = New System.Drawing.Size(45, 181)
        Me.lblVolume.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(998, 610)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chkApp3)
        Me.Controls.Add(Me.chkApp2)
        Me.Controls.Add(Me.chkApp1)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CircularProgressBar4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbPortSelector)
        Me.Controls.Add(Me.CircularProgressBar3)
        Me.Controls.Add(Me.CircularProgressBar2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.CircularProgressBar1)
        Me.Controls.Add(Me.CircularProgressBar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbAudioLevel)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.cbProgramSelector3)
        Me.Controls.Add(Me.cbProgramSelector2)
        Me.Controls.Add(Me.cbProgramSelector)
        Me.Controls.Add(Me.lblAppVolume3)
        Me.Controls.Add(Me.lblAppVolume2)
        Me.Controls.Add(Me.lblAppVolume)
        Me.Controls.Add(Me.lblVolume)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Virtual Arduino Dj"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAppVolume3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAppVolume2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAppVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblVolume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbProgramSelector As ComboBox
    Friend WithEvents cbProgramSelector2 As ComboBox
    Friend WithEvents cbProgramSelector3 As ComboBox
    Friend WithEvents btnApply As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents pbAudioLevel As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CircularProgressBar As CircularProgressBar.CircularProgressBar
    Friend WithEvents CircularProgressBar1 As CircularProgressBar.CircularProgressBar
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CircularProgressBar2 As CircularProgressBar.CircularProgressBar
    Friend WithEvents CircularProgressBar3 As CircularProgressBar.CircularProgressBar
    Friend WithEvents cmbPortSelector As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CircularProgressBar4 As CircularProgressBar.CircularProgressBar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnStop As Button
    Friend WithEvents chkApp1 As CheckBox
    Friend WithEvents chkApp2 As CheckBox
    Friend WithEvents chkApp3 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents lblAppVolume3 As TrackBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblAppVolume2 As TrackBar
    Friend WithEvents lblAppVolume As TrackBar
    Friend WithEvents lblVolume As TrackBar
    Friend WithEvents CambiarFondoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnChangeBackground As ToolStripMenuItem
    Friend WithEvents btnRemoveBackground As ToolStripMenuItem
    Friend WithEvents ColorDeTextoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnChangeTextColor As ToolStripMenuItem
    Friend WithEvents btnSelectColor As ToolStripMenuItem
End Class
