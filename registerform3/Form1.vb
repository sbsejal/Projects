Imports System.Data
Imports System.Data.SqlClient
Public Class Form1

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=userregcs;Integrated Security=True") '" + cmbGender.SelectedItem.ToString() + "'
        Dim cmd As SqlCommand = New SqlCommand("INSERT INTO [userregcs].[dbo].[register] ([firstname] ,[lastname] ,[address],[gender],[email],[phone] ,[username] ,[password])VALUES ('" + txtFname.Text + "','" + txtLname.Text + "','" + txtAdd.Text + "','" + txtEmail.Text + "','" + txtPhone.Text + "','" + txtUser.Text + "','" + txtPass.Text + "',)", con)
        con.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show("you have register successfully", " Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        con.Close()




    End Sub

    Private Sub txtEmail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmail.TextChanged

    End Sub
End Class
