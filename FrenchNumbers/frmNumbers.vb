Public Class frmNumbers
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        lblFrench.Text = "Un"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        lblFrench.Text = "Deux"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        lblFrench.Text = "Troix"

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        lblFrench.Text = "Quatre"

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        lblFrench.Text = "Cinq"

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles lblFrench.TextChanged
        If lblFrench.TextLength > 0 Then
            lblFrench.Visible = True
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblInstructions.Click

    End Sub

    Private Sub frmNumbers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFrench.Visible = False
    End Sub
End Class
