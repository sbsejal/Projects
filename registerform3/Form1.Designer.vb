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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(31, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(342, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(342, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Gender :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Email :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(342, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Phone :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(31, 229)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Username :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(342, 229)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 18)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Password :"
        '
        'txtFname
        '
        Me.txtFname.Location = New System.Drawing.Point(158, 42)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(140, 20)
        Me.txtFname.TabIndex = 8
        '
        'txtLname
        '
        Me.txtLname.Location = New System.Drawing.Point(452, 44)
        Me.txtLname.Multiline = True
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(154, 20)
        Me.txtLname.TabIndex = 9
        '
        'txtAdd
        '
        Me.txtAdd.Location = New System.Drawing.Point(158, 97)
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(140, 20)
        Me.txtAdd.TabIndex = 10
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(156, 168)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(142, 20)
        Me.txtEmail.TabIndex = 11
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(452, 168)
        Me.txtPhone.Multiline = True
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(154, 20)
        Me.txtPhone.TabIndex = 12
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(156, 229)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(142, 20)
        Me.txtUser.TabIndex = 13
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(452, 226)
        Me.txtPass.Multiline = True
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(154, 20)
        Me.txtPass.TabIndex = 14
        '
        'cmbGender
        '
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Female", "Male", "Other"})
        Me.cmbGender.Location = New System.Drawing.Point(452, 96)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(154, 21)
        Me.cmbGender.TabIndex = 15
        '
        'btnRegister
        '
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(191, 294)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(284, 41)
        Me.btnRegister.TabIndex = 16
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 369)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtAdd)
        Me.Controls.Add(Me.txtLname)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents txtLname As System.Windows.Forms.TextBox
    Friend WithEvents txtAdd As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents cmbGender As System.Windows.Forms.ComboBox
    Friend WithEvents btnRegister As System.Windows.Forms.Button

End Class
