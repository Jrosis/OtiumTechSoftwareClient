Public Class FrmConCli

    Dim objcli As New ClsCliente

    Private Sub FrmConCli_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub
    Private Sub FrmConCli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtCampo.Clear()
        Call TxtCampo_TextChanged(Nothing, Nothing)
    End Sub

    Private Sub TxtCampo_TextChanged(sender As Object, e As EventArgs) Handles TxtCampo.TextChanged
        DgdGrade.DataSource = objcli.localizarParaGrade(TxtCampo.Text)
        lblQTD.Text = "Qtd. de Clientes: " & DgdGrade.Rows.Count
    End Sub
    Private Sub DgdGrade_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        FrmCam.Txtcli.Text = DgdGrade.CurrentRow.Cells(0).Value
        FrmCam.LblCli.Text = DgdGrade.CurrentRow.Cells(1).Value
        Me.Close()


    End Sub


    Private Sub DgdGrade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DgdGrade_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellContentClick

    End Sub

    Private Sub DgdGrade_CellDoubleClick1(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellDoubleClick
        FrmCam.Txtcli.Text = DgdGrade.CurrentRow.Cells(0).Value
        FrmCam.LblCli.Text = DgdGrade.CurrentRow.Cells(1).Value
        Me.Close()
    End Sub
End Class