<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnLoadEXE = New System.Windows.Forms.Button()
        Me.txtLoadedEXE = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkbxFullscreen = New System.Windows.Forms.CheckBox()
        Me.cbxAspectRatio = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtScreenHeight = New System.Windows.Forms.TextBox()
        Me.txtScreenWidth = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxPreset = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkbxDepthofField = New System.Windows.Forms.CheckBox()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.ofdBREXE = New System.Windows.Forms.OpenFileDialog()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLoadEXE
        '
        Me.btnLoadEXE.Location = New System.Drawing.Point(12, 12)
        Me.btnLoadEXE.Name = "btnLoadEXE"
        Me.btnLoadEXE.Size = New System.Drawing.Size(75, 24)
        Me.btnLoadEXE.TabIndex = 0
        Me.btnLoadEXE.Text = "Load EXE"
        Me.btnLoadEXE.UseVisualStyleBackColor = True
        '
        'txtLoadedEXE
        '
        Me.txtLoadedEXE.Location = New System.Drawing.Point(93, 13)
        Me.txtLoadedEXE.Name = "txtLoadedEXE"
        Me.txtLoadedEXE.ReadOnly = True
        Me.txtLoadedEXE.Size = New System.Drawing.Size(377, 23)
        Me.txtLoadedEXE.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkbxDepthofField)
        Me.GroupBox1.Controls.Add(Me.chkbxFullscreen)
        Me.GroupBox1.Controls.Add(Me.cbxAspectRatio)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtScreenHeight)
        Me.GroupBox1.Controls.Add(Me.txtScreenWidth)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbxPreset)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(458, 165)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resolution and Aspect Ratio"
        '
        'chkbxFullscreen
        '
        Me.chkbxFullscreen.AutoSize = True
        Me.chkbxFullscreen.Location = New System.Drawing.Point(239, 120)
        Me.chkbxFullscreen.Name = "chkbxFullscreen"
        Me.chkbxFullscreen.Size = New System.Drawing.Size(79, 19)
        Me.chkbxFullscreen.TabIndex = 8
        Me.chkbxFullscreen.Text = "Fullscreen"
        Me.chkbxFullscreen.UseVisualStyleBackColor = True
        '
        'cbxAspectRatio
        '
        Me.cbxAspectRatio.FormattingEnabled = True
        Me.cbxAspectRatio.Items.AddRange(New Object() {"5:4", "4:3", "3:2", "16:9", "16:10", "21:9", "32:9"})
        Me.cbxAspectRatio.Location = New System.Drawing.Point(92, 118)
        Me.cbxAspectRatio.Name = "cbxAspectRatio"
        Me.cbxAspectRatio.Size = New System.Drawing.Size(100, 23)
        Me.cbxAspectRatio.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Aspect Ratio:"
        '
        'txtScreenHeight
        '
        Me.txtScreenHeight.Location = New System.Drawing.Point(329, 80)
        Me.txtScreenHeight.Name = "txtScreenHeight"
        Me.txtScreenHeight.Size = New System.Drawing.Size(100, 23)
        Me.txtScreenHeight.TabIndex = 4
        '
        'txtScreenWidth
        '
        Me.txtScreenWidth.Location = New System.Drawing.Point(92, 80)
        Me.txtScreenWidth.Name = "txtScreenWidth"
        Me.txtScreenWidth.Size = New System.Drawing.Size(100, 23)
        Me.txtScreenWidth.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(239, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Screen Height:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Screen Width:"
        '
        'cbxPreset
        '
        Me.cbxPreset.FormattingEnabled = True
        Me.cbxPreset.Items.AddRange(New Object() {"1280x720 16:9", "1366x768 16:9", "1600x900 16:9", "1920x1080 16:9", "2560x1440 16:9", "3840x2160 16:9", "2560x1080 21:9", "3440x1440 21:9", "3840x1600 21:9", "5120x2160 21:9", "3840x1080 32:9", "5120x1440 32:9", "7680x2160 32:9"})
        Me.cbxPreset.Location = New System.Drawing.Point(150, 46)
        Me.cbxPreset.Name = "cbxPreset"
        Me.cbxPreset.Size = New System.Drawing.Size(156, 23)
        Me.cbxPreset.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(102, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Preset:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(409, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select a preset resolution below or set one via the screen width/height fields."
        '
        'chkbxDepthofField
        '
        Me.chkbxDepthofField.AutoSize = True
        Me.chkbxDepthofField.Location = New System.Drawing.Point(329, 120)
        Me.chkbxDepthofField.Name = "chkbxDepthofField"
        Me.chkbxDepthofField.Size = New System.Drawing.Size(100, 19)
        Me.chkbxDepthofField.TabIndex = 8
        Me.chkbxDepthofField.Text = "Depth of Field"
        Me.chkbxDepthofField.UseVisualStyleBackColor = True
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Location = New System.Drawing.Point(353, 213)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(117, 41)
        Me.btnSaveChanges.TabIndex = 3
        Me.btnSaveChanges.Text = "Save Changes"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'ofdBREXE
        '
        Me.ofdBREXE.FileName = "OpenFileDialog1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "V1.0 - Yuvi"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 266)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnSaveChanges)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtLoadedEXE)
        Me.Controls.Add(Me.btnLoadEXE)
        Me.Name = "Form1"
        Me.Text = "Blue Reflection Screen Configurator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLoadEXE As Button
    Friend WithEvents txtLoadedEXE As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkbxFullscreen As CheckBox
    Friend WithEvents cbxAspectRatio As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtScreenHeight As TextBox
    Friend WithEvents txtScreenWidth As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbxPreset As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents chkbxDepthofField As CheckBox
    Friend WithEvents btnSaveChanges As Button
    Friend WithEvents ofdBREXE As OpenFileDialog
    Friend WithEvents Label6 As Label
End Class
