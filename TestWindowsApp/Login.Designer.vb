<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(313, 128)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(175, 38)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.White
        Me.MetroButton1.TabIndex = 5
        Me.MetroButton1.Text = "Login"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroTextBox1
        '
        Me.MetroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox1.Location = New System.Drawing.Point(12, 36)
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.Size = New System.Drawing.Size(776, 23)
        Me.MetroTextBox1.Style = MetroFramework.MetroColorStyle.White
        Me.MetroTextBox1.TabIndex = 6
        Me.MetroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTextBox1.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(12, 8)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(57, 25)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.White
        Me.MetroLabel1.TabIndex = 7
        Me.MetroLabel1.Text = "Email:"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel1.UseStyleColors = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.BackColor = System.Drawing.SystemColors.Control
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(12, 62)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(86, 25)
        Me.MetroLabel2.Style = MetroFramework.MetroColorStyle.White
        Me.MetroLabel2.TabIndex = 9
        Me.MetroLabel2.Text = "Password:"
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel2.UseStyleColors = True
        '
        'MetroTextBox2
        '
        Me.MetroTextBox2.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox2.Location = New System.Drawing.Point(12, 90)
        Me.MetroTextBox2.Name = "MetroTextBox2"
        Me.MetroTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.MetroTextBox2.Size = New System.Drawing.Size(776, 23)
        Me.MetroTextBox2.Style = MetroFramework.MetroColorStyle.White
        Me.MetroTextBox2.TabIndex = 8
        Me.MetroTextBox2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTextBox2.UseStyleColors = True
        Me.MetroTextBox2.UseSystemPasswordChar = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(713, 149)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton2.TabIndex = 10
        Me.MetroButton2.Text = "Close"
        Me.MetroButton2.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'Login
        '
        Me.AcceptButton = Me.MetroButton1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 184)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroTextBox2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroTextBox1)
        Me.Controls.Add(Me.MetroButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
End Class
