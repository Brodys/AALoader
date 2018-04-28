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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtHWID = New System.Windows.Forms.TextBox()
        Me.WebBrowser3 = New System.Windows.Forms.WebBrowser()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.MephTheme1 = New Artificial_Aim.MephTheme()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New Artificial_Aim.MephCheckBox()
        Me.Button2 = New Artificial_Aim.MephButton()
        Me.Button1 = New Artificial_Aim.MephButton()
        Me.TextBox2 = New Artificial_Aim.MephTextBox()
        Me.TextBox1 = New Artificial_Aim.MephTextBox()
        Me.MephTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(555, 12)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(435, 227)
        Me.WebBrowser1.TabIndex = 4
        Me.WebBrowser1.Url = New System.Uri("http://artificialaim.net/forums/member.php?action=login", System.UriKind.Absolute)
        '
        'WebBrowser2
        '
        Me.WebBrowser2.Location = New System.Drawing.Point(555, 245)
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.ScriptErrorsSuppressed = True
        Me.WebBrowser2.Size = New System.Drawing.Size(435, 227)
        Me.WebBrowser2.TabIndex = 7
        Me.WebBrowser2.Url = New System.Uri("http://artificialaim.net/loader/usercheck.php", System.UriKind.Absolute)
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'txtHWID
        '
        Me.txtHWID.Location = New System.Drawing.Point(272, 261)
        Me.txtHWID.Name = "txtHWID"
        Me.txtHWID.ReadOnly = True
        Me.txtHWID.Size = New System.Drawing.Size(227, 20)
        Me.txtHWID.TabIndex = 11
        '
        'WebBrowser3
        '
        Me.WebBrowser3.Location = New System.Drawing.Point(12, 304)
        Me.WebBrowser3.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser3.Name = "WebBrowser3"
        Me.WebBrowser3.ScriptErrorsSuppressed = True
        Me.WebBrowser3.Size = New System.Drawing.Size(537, 169)
        Me.WebBrowser3.TabIndex = 12
        Me.WebBrowser3.Url = New System.Uri("http://artificialaim.net/loader/hwid.php", System.UriKind.Absolute)
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 2000
        '
        'MephTheme1
        '
        Me.MephTheme1.AccentColor = System.Drawing.Color.Red
        Me.MephTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.MephTheme1.Controls.Add(Me.Label2)
        Me.MephTheme1.Controls.Add(Me.Label6)
        Me.MephTheme1.Controls.Add(Me.Label4)
        Me.MephTheme1.Controls.Add(Me.CheckBox1)
        Me.MephTheme1.Controls.Add(Me.Button2)
        Me.MephTheme1.Controls.Add(Me.Button1)
        Me.MephTheme1.Controls.Add(Me.TextBox2)
        Me.MephTheme1.Controls.Add(Me.TextBox1)
        Me.MephTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MephTheme1.Location = New System.Drawing.Point(0, 0)
        Me.MephTheme1.Name = "MephTheme1"
        Me.MephTheme1.Size = New System.Drawing.Size(264, 245)
        Me.MephTheme1.SubHeader = "Welcome to Artificial Aim"
        Me.MephTheme1.TabIndex = 13
        Me.MephTheme1.Text = "Artificial Aim - Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(26, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Click Me If You're Having Issues Logging In"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(54, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Current Status: Waiting for input"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AccentColor = System.Drawing.Color.Maroon
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Checked = False
        Me.CheckBox1.ForeColor = System.Drawing.Color.Black
        Me.CheckBox1.Location = New System.Drawing.Point(70, 177)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(124, 24)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "Remember Me"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(65, 141)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(55, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Exit"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(139, 141)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Login"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TextBox2.ForeColor = System.Drawing.Color.Silver
        Me.TextBox2.Location = New System.Drawing.Point(65, 107)
        Me.TextBox2.MaxLength = 32767
        Me.TextBox2.MultiLine = False
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(135, 24)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "Password"
        Me.TextBox2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextBox2.UseSystemPasswordChar = True
        Me.TextBox2.WordWrap = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TextBox1.ForeColor = System.Drawing.Color.Silver
        Me.TextBox1.Location = New System.Drawing.Point(65, 70)
        Me.TextBox1.MaxLength = 32767
        Me.TextBox1.MultiLine = False
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(135, 24)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Username"
        Me.TextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextBox1.UseSystemPasswordChar = False
        Me.TextBox1.WordWrap = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(264, 245)
        Me.ControlBox = False
        Me.Controls.Add(Me.MephTheme1)
        Me.Controls.Add(Me.WebBrowser3)
        Me.Controls.Add(Me.txtHWID)
        Me.Controls.Add(Me.WebBrowser2)
        Me.Controls.Add(Me.WebBrowser1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Artificial Aim - Login"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MephTheme1.ResumeLayout(False)
        Me.MephTheme1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents WebBrowser2 As WebBrowser
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtHWID As TextBox
    Friend WithEvents WebBrowser3 As WebBrowser
    Friend WithEvents Timer2 As Timer
    Friend WithEvents MephTheme1 As MephTheme
    Friend WithEvents Button2 As MephButton
    Friend WithEvents Button1 As MephButton
    Friend WithEvents TextBox2 As MephTextBox
    Friend WithEvents TextBox1 As MephTextBox
    Friend WithEvents CheckBox1 As MephCheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
End Class
