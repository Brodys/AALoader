<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtHWID = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.MephTheme1 = New Artificial_Aim.MephTheme()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New Artificial_Aim.MephButton()
        Me.Button1 = New Artificial_Aim.MephButton()
        Me.Button3 = New Artificial_Aim.MephButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MephTabcontrol1 = New Artificial_Aim.MephTabcontrol()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.ComboBox1 = New Artificial_Aim.MephComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MephTheme1.SuspendLayout()
        Me.MephTabcontrol1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 50
        '
        'txtHWID
        '
        Me.txtHWID.Location = New System.Drawing.Point(128, 441)
        Me.txtHWID.Name = "txtHWID"
        Me.txtHWID.Size = New System.Drawing.Size(100, 20)
        Me.txtHWID.TabIndex = 10
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 10000
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(829, 275)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(511, 421)
        Me.WebBrowser1.TabIndex = 17
        Me.WebBrowser1.Url = New System.Uri("http://artificialaim.net/loader/usercheck2.php", System.UriKind.Absolute)
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(829, 222)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 25
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 15000
        '
        'MephTheme1
        '
        Me.MephTheme1.AccentColor = System.Drawing.Color.Red
        Me.MephTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.MephTheme1.Controls.Add(Me.Label2)
        Me.MephTheme1.Controls.Add(Me.Button2)
        Me.MephTheme1.Controls.Add(Me.Button1)
        Me.MephTheme1.Controls.Add(Me.Button3)
        Me.MephTheme1.Controls.Add(Me.Label1)
        Me.MephTheme1.Controls.Add(Me.MephTabcontrol1)
        Me.MephTheme1.Controls.Add(Me.PictureBox1)
        Me.MephTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MephTheme1.Location = New System.Drawing.Point(0, 0)
        Me.MephTheme1.Name = "MephTheme1"
        Me.MephTheme1.Size = New System.Drawing.Size(616, 419)
        Me.MephTheme1.SubHeader = "Select Your Cheats In The Cheats Tab"
        Me.MephTheme1.TabIndex = 26
        Me.MephTheme1.Text = "Artificial Aim - Loader"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(492, 397)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Loader Version: 0.1.1.0"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(517, 75)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 39)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Restart"
        Me.Button2.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(8, 355)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 39)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Exit"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(522, 355)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 39)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Inject"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(9, 397)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "User Status: Fetching"
        '
        'MephTabcontrol1
        '
        Me.MephTabcontrol1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.MephTabcontrol1.Controls.Add(Me.TabPage1)
        Me.MephTabcontrol1.Controls.Add(Me.TabPage2)
        Me.MephTabcontrol1.ItemSize = New System.Drawing.Size(35, 85)
        Me.MephTabcontrol1.Location = New System.Drawing.Point(101, 141)
        Me.MephTabcontrol1.Multiline = True
        Me.MephTabcontrol1.Name = "MephTabcontrol1"
        Me.MephTabcontrol1.SelectedIndex = 0
        Me.MephTabcontrol1.Size = New System.Drawing.Size(415, 253)
        Me.MephTabcontrol1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.MephTabcontrol1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.RichTextBox1)
        Me.TabPage1.Location = New System.Drawing.Point(89, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(322, 245)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "News"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.Red
        Me.RichTextBox1.Location = New System.Drawing.Point(-2, -2)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(327, 258)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.RichTextBox2)
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Location = New System.Drawing.Point(89, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(322, 245)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Cheats"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.RichTextBox2.ForeColor = System.Drawing.Color.Red
        Me.RichTextBox2.Location = New System.Drawing.Point(-2, 74)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(328, 175)
        Me.RichTextBox2.TabIndex = 2
        Me.RichTextBox2.Text = ""
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteCustomSource.AddRange(New String() {"Radical Heights", "Custom Injector"})
        Me.ComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ComboBox1.ForeColor = System.Drawing.Color.Silver
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.ItemHeight = 16
        Me.ComboBox1.ItemHighlightColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ComboBox1.Items.AddRange(New Object() {"Radical Heights", "Custom Injector"})
        Me.ComboBox1.Location = New System.Drawing.Point(6, 23)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 22)
        Me.ComboBox1.StartIndex = 0
        Me.ComboBox1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(132, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(350, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(616, 419)
        Me.ControlBox = False
        Me.Controls.Add(Me.MephTheme1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.txtHWID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Artificial Aim - Logged In"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MephTheme1.ResumeLayout(False)
        Me.MephTheme1.PerformLayout()
        Me.MephTabcontrol1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtHWID As TextBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Button5 As Button
    Friend WithEvents Timer3 As Timer
    Friend WithEvents MephTheme1 As MephTheme
    Friend WithEvents MephTabcontrol1 As MephTabcontrol
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As MephButton
    Friend WithEvents Button1 As MephButton
    Friend WithEvents Button3 As MephButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As MephComboBox
    Friend WithEvents RichTextBox2 As RichTextBox
End Class
