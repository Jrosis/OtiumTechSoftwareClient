Public Class FrmConFun

    Dim objfun As New ClsFuncionario

    Private Sub FrmConFun_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub
    Private Sub FrmConFun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtCampo.Clear()
        Call TxtCampo_TextChanged(Nothing, Nothing)
    End Sub

    Private Sub TxtCampo_TextChanged(sender As Object, e As EventArgs) Handles TxtCampo.TextChanged
        DgdGrade.DataSource = objfun.localizarParaGrade(TxtCampo.Text)
        lblQTD.Text = "Qtd. de Clientes: " & DgdGrade.Rows.Count
    End Sub
    Private Sub DgdGrade_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        FrmDes.TxtFun.Text = DgdGrade.CurrentRow.Cells(0).Value
        FrmDes.LblFun.Text = DgdGrade.CurrentRow.Cells(1).Value
        Me.Close()


    End Sub

    Private Sub DgdGrade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellContentClick

    End Sub

    Private Sub DgdGrade_CellDoubleClick1(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellDoubleClick
        FrmDes.TxtFun.Text = DgdGrade.CurrentRow.Cells(0).Value
        FrmDes.LblFun.Text = DgdGrade.CurrentRow.Cells(1).Value
        Me.Close()
    End Sub
End Class