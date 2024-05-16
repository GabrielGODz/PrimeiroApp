Public Class frmTelaInicial
    Private Sub lblPreto_Click(sender As Object, e As EventArgs) Handles lblPreto.Click
        lblTitulo.ForeColor = Color.Black
    End Sub

    Private Sub lblAmarelo_Click(sender As Object, e As EventArgs) Handles lblAmarelo.Click
        lblTitulo.ForeColor = Color.Yellow
    End Sub

    Private Sub lblVerde_Click(sender As Object, e As EventArgs) Handles lblVerde.Click
        lblTitulo.ForeColor = Color.Green
    End Sub

    Private Sub lblVermelho_Click(sender As Object, e As EventArgs) Handles lblVermelho.Click
        lblTitulo.ForeColor = Color.Red
    End Sub

    Private Sub lblAzul_Click(sender As Object, e As EventArgs) Handles lblAzul.Click
        lblTitulo.ForeColor = Color.Blue
    End Sub
End Class
