Public Class FrmInicialCliente

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        FrmCadCli.Show()
        FrmCadCli.MdiParent = Me
    End Sub

    Private Sub ProdutoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutoToolStripMenuItem.Click
        FrmCam.Show()
        FrmCam.MdiParent = Me
    End Sub
End Class