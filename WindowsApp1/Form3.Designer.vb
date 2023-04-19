<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.firstnametextbox = New System.Windows.Forms.TextBox()
        Me.usernametextbox = New System.Windows.Forms.TextBox()
        Me.passwordtextbox = New System.Windows.Forms.TextBox()
        Me.lastnametextbox = New System.Windows.Forms.TextBox()
        Me.registerbtn = New System.Windows.Forms.Button()
        Me.cancelbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(261, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(261, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(261, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(261, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password"
        '
        'firstnametextbox
        '
        Me.firstnametextbox.Location = New System.Drawing.Point(362, 141)
        Me.firstnametextbox.Multiline = True
        Me.firstnametextbox.Name = "firstnametextbox"
        Me.firstnametextbox.Size = New System.Drawing.Size(225, 26)
        Me.firstnametextbox.TabIndex = 4
        '
        'usernametextbox
        '
        Me.usernametextbox.Location = New System.Drawing.Point(362, 217)
        Me.usernametextbox.Multiline = True
        Me.usernametextbox.Name = "usernametextbox"
        Me.usernametextbox.Size = New System.Drawing.Size(225, 26)
        Me.usernametextbox.TabIndex = 5
        '
        'passwordtextbox
        '
        Me.passwordtextbox.Location = New System.Drawing.Point(362, 256)
        Me.passwordtextbox.Multiline = True
        Me.passwordtextbox.Name = "passwordtextbox"
        Me.passwordtextbox.Size = New System.Drawing.Size(225, 26)
        Me.passwordtextbox.TabIndex = 6
        '
        'lastnametextbox
        '
        Me.lastnametextbox.Location = New System.Drawing.Point(362, 176)
        Me.lastnametextbox.Multiline = True
        Me.lastnametextbox.Name = "lastnametextbox"
        Me.lastnametextbox.Size = New System.Drawing.Size(225, 26)
        Me.lastnametextbox.TabIndex = 7
        '
        'registerbtn
        '
        Me.registerbtn.BackColor = System.Drawing.Color.Maroon
        Me.registerbtn.Location = New System.Drawing.Point(411, 299)
        Me.registerbtn.Name = "registerbtn"
        Me.registerbtn.Size = New System.Drawing.Size(96, 33)
        Me.registerbtn.TabIndex = 8
        Me.registerbtn.Text = "Register"
        Me.registerbtn.UseVisualStyleBackColor = False
        '
        'cancelbtn
        '
        Me.cancelbtn.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.cancelbtn.Location = New System.Drawing.Point(411, 338)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.Size = New System.Drawing.Size(96, 33)
        Me.cancelbtn.TabIndex = 9
        Me.cancelbtn.Text = "Cancel"
        Me.cancelbtn.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(960, 455)
        Me.Controls.Add(Me.cancelbtn)
        Me.Controls.Add(Me.registerbtn)
        Me.Controls.Add(Me.lastnametextbox)
        Me.Controls.Add(Me.passwordtextbox)
        Me.Controls.Add(Me.usernametextbox)
        Me.Controls.Add(Me.firstnametextbox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents firstnametextbox As TextBox
    Friend WithEvents usernametextbox As TextBox
    Friend WithEvents passwordtextbox As TextBox
    Friend WithEvents lastnametextbox As TextBox
    Friend WithEvents registerbtn As Button
    Friend WithEvents cancelbtn As Button
End Class
