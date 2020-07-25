<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.lblResult = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonButton1 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonGroupBox3 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.cmbLN = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.txtLN = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtC = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtFT = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.chkInverse = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.radGS = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.radAS = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.lblSeries = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonManager1 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroupBox3.Panel.SuspendLayout()
        Me.KryptonGroupBox3.SuspendLayout()
        CType(Me.cmbLN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroupBox1.Panel.SuspendLayout()
        Me.KryptonGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.lblResult)
        Me.KryptonPanel.Controls.Add(Me.KryptonButton1)
        Me.KryptonPanel.Controls.Add(Me.KryptonGroupBox3)
        Me.KryptonPanel.Controls.Add(Me.KryptonGroupBox1)
        Me.KryptonPanel.Controls.Add(Me.lblSeries)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(648, 288)
        Me.KryptonPanel.TabIndex = 0
        '
        'lblResult
        '
        Me.lblResult.AutoSize = False
        Me.lblResult.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblResult.Location = New System.Drawing.Point(0, 35)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(648, 39)
        Me.lblResult.StateNormal.LongText.Color1 = System.Drawing.Color.WhiteSmoke
        Me.lblResult.StateNormal.LongText.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.StateNormal.ShortText.Color1 = System.Drawing.Color.LavenderBlush
        Me.lblResult.StateNormal.ShortText.Font = New System.Drawing.Font("Consolas", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.StateNormal.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.lblResult.StateNormal.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.lblResult.TabIndex = 9
        Me.lblResult.Values.Text = "123467890"
        '
        'KryptonButton1
        '
        Me.KryptonButton1.Location = New System.Drawing.Point(261, 260)
        Me.KryptonButton1.Name = "KryptonButton1"
        Me.KryptonButton1.Size = New System.Drawing.Size(90, 25)
        Me.KryptonButton1.TabIndex = 8
        Me.KryptonButton1.Values.Text = "Calculate"
        '
        'KryptonGroupBox3
        '
        Me.KryptonGroupBox3.CaptionOverlap = 1.0R
        Me.KryptonGroupBox3.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl
        Me.KryptonGroupBox3.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlToolTip
        Me.KryptonGroupBox3.Location = New System.Drawing.Point(311, 92)
        Me.KryptonGroupBox3.Name = "KryptonGroupBox3"
        '
        'KryptonGroupBox3.Panel
        '
        Me.KryptonGroupBox3.Panel.Controls.Add(Me.cmbLN)
        Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtLN)
        Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtC)
        Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtFT)
        Me.KryptonGroupBox3.Size = New System.Drawing.Size(330, 145)
        Me.KryptonGroupBox3.TabIndex = 7
        Me.KryptonGroupBox3.Text = "Data"
        Me.KryptonGroupBox3.Values.Heading = "Data"
        '
        'cmbLN
        '
        Me.cmbLN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLN.DropDownWidth = 121
        Me.cmbLN.Items.AddRange(New Object() {"Last Term", "Total Term Number"})
        Me.cmbLN.Location = New System.Drawing.Point(11, 48)
        Me.cmbLN.Name = "cmbLN"
        Me.cmbLN.Size = New System.Drawing.Size(121, 23)
        Me.cmbLN.TabIndex = 5
        '
        'txtLN
        '
        Me.txtLN.Location = New System.Drawing.Point(174, 49)
        Me.txtLN.Name = "txtLN"
        Me.txtLN.Size = New System.Drawing.Size(146, 22)
        Me.txtLN.TabIndex = 6
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(11, 16)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(68, 16)
        Me.KryptonLabel2.StateNormal.ShortText.Color1 = System.Drawing.Color.Snow
        Me.KryptonLabel2.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 2
        Me.KryptonLabel2.Values.Text = "First Term :"
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(174, 82)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(146, 22)
        Me.txtC.TabIndex = 7
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(11, 81)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(160, 16)
        Me.KryptonLabel3.StateNormal.ShortText.Color1 = System.Drawing.Color.Snow
        Me.KryptonLabel3.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.TabIndex = 3
        Me.KryptonLabel3.Values.Text = "Common Difference or Ratio :"
        '
        'txtFT
        '
        Me.txtFT.Location = New System.Drawing.Point(174, 16)
        Me.txtFT.Name = "txtFT"
        Me.txtFT.Size = New System.Drawing.Size(146, 22)
        Me.txtFT.TabIndex = 4
        '
        'KryptonGroupBox1
        '
        Me.KryptonGroupBox1.CaptionOverlap = 1.0R
        Me.KryptonGroupBox1.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl
        Me.KryptonGroupBox1.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlToolTip
        Me.KryptonGroupBox1.Location = New System.Drawing.Point(8, 92)
        Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
        '
        'KryptonGroupBox1.Panel
        '
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.chkInverse)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.radGS)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.radAS)
        Me.KryptonGroupBox1.Size = New System.Drawing.Size(286, 145)
        Me.KryptonGroupBox1.TabIndex = 1
        Me.KryptonGroupBox1.Text = "Sequence Type"
        Me.KryptonGroupBox1.Values.Heading = "Sequence Type"
        '
        'chkInverse
        '
        Me.chkInverse.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.chkInverse.Location = New System.Drawing.Point(206, 49)
        Me.chkInverse.Name = "chkInverse"
        Me.chkInverse.Size = New System.Drawing.Size(66, 21)
        Me.chkInverse.StateNormal.ShortText.Color1 = System.Drawing.Color.White
        Me.chkInverse.StateNormal.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.chkInverse.StateNormal.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.chkInverse.TabIndex = 2
        Me.chkInverse.Text = "Inverse"
        Me.chkInverse.Values.Text = "Inverse"
        '
        'radGS
        '
        Me.radGS.Location = New System.Drawing.Point(23, 71)
        Me.radGS.Name = "radGS"
        Me.radGS.Size = New System.Drawing.Size(156, 18)
        Me.radGS.StateNormal.ShortText.Color1 = System.Drawing.Color.White
        Me.radGS.StateNormal.ShortText.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radGS.TabIndex = 1
        Me.radGS.Values.Text = "Geometrical Series"
        '
        'radAS
        '
        Me.radAS.Location = New System.Drawing.Point(23, 30)
        Me.radAS.Name = "radAS"
        Me.radAS.Size = New System.Drawing.Size(149, 18)
        Me.radAS.StateNormal.ShortText.Color1 = System.Drawing.Color.White
        Me.radAS.StateNormal.ShortText.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radAS.TabIndex = 0
        Me.radAS.Values.Text = "Arithmetic Series"
        '
        'lblSeries
        '
        Me.lblSeries.AutoSize = False
        Me.lblSeries.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblSeries.Location = New System.Drawing.Point(0, 0)
        Me.lblSeries.Name = "lblSeries"
        Me.lblSeries.Size = New System.Drawing.Size(648, 35)
        Me.lblSeries.StateNormal.LongText.Color1 = System.Drawing.Color.WhiteSmoke
        Me.lblSeries.StateNormal.LongText.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeries.StateNormal.ShortText.Color1 = System.Drawing.Color.White
        Me.lblSeries.StateNormal.ShortText.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeries.StateNormal.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.lblSeries.StateNormal.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.lblSeries.TabIndex = 0
        Me.lblSeries.Values.Text = "123467890"
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Black
        '
        'KryptonManager1
        '
        Me.KryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Black
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(648, 288)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Neutrino Sequence Calculator"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox3.Panel.ResumeLayout(False)
        Me.KryptonGroupBox3.Panel.PerformLayout()
        CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox3.ResumeLayout(False)
        CType(Me.cmbLN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox1.Panel.ResumeLayout(False)
        Me.KryptonGroupBox1.Panel.PerformLayout()
        CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents KryptonManager1 As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents KryptonButton1 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonGroupBox3 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtC As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtFT As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents chkInverse As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents radGS As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radAS As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents lblSeries As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtLN As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblResult As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbLN As ComponentFactory.Krypton.Toolkit.KryptonComboBox
End Class
