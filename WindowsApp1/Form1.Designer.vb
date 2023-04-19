<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.usernamebtn = New System.Windows.Forms.TextBox()
        Me.Loginbtn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.passwordbtn = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(456, 232)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'usernamebtn
        '
        Me.usernamebtn.Location = New System.Drawing.Point(577, 231)
        Me.usernamebtn.Multiline = True
        Me.usernamebtn.Name = "usernamebtn"
        Me.usernamebtn.Size = New System.Drawing.Size(225, 26)
        Me.usernamebtn.TabIndex = 1
        '
        'Loginbtn
        '
        Me.Loginbtn.BackColor = System.Drawing.Color.Maroon
        Me.Loginbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loginbtn.Location = New System.Drawing.Point(629, 308)
        Me.Loginbtn.Name = "Loginbtn"
        Me.Loginbtn.Size = New System.Drawing.Size(126, 52)
        Me.Loginbtn.TabIndex = 2
        Me.Loginbtn.Text = "Login"
        Me.Loginbtn.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.GrayText
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(629, 366)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 56)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Sign up"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'passwordbtn
        '
        Me.passwordbtn.Location = New System.Drawing.Point(577, 263)
        Me.passwordbtn.Multiline = True
        Me.passwordbtn.Name = "passwordbtn"
        Me.passwordbtn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordbtn.Size = New System.Drawing.Size(225, 26)
        Me.passwordbtn.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(456, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1135, 597)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.passwordbtn)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Loginbtn)
        Me.Controls.Add(Me.usernamebtn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents usernamebtn As TextBox
    Friend WithEvents Loginbtn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents passwordbtn As TextBox
    Friend WithEvents Label2 As Label
End Class
