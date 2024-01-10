Public Class FrmConDes

    Dim objcontrole As New ClsControle
    Dim objdes As New ClsDespesa

    Private Sub FrmConDes_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub

    Private Sub FrmConDes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtdesini.Clear()
        txtdesfim.Clear()
        txtGas.Enabled = False
    End Sub



    Private Sub DgdGrade_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellDoubleClick
        FrmFin.Txtdesfin.Text = DgdGrade.CurrentRow.Cells(0).Value
        FrmFin.LblDesfin.Text = DgdGrade.CurrentRow.Cells(1).Value
        Me.Close()


    End Sub
    Private Sub txtcampofun_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdesfim.KeyPress
        e.Handled = objcontrole.SoNumerosEVirgula(e.KeyChar)
    End Sub

    Private Sub txtcampofun_TextChanged(sender As Object, e As EventArgs) Handles txtdesfim.TextChanged


    End Sub

    Private Sub BtnLoc_Click(sender As Object, e As EventArgs) Handles BtnLoc.Click
        If objcontrole.Testar_Vazio(Me) = True Then
            MessageBox.Show("Favor preencher todos os campos obrigatórios")
        Else

            DgdGrade.DataSource = objdes.localizarFunDesDat(Dtpini.Text, DtpFim.Text, txtdesini.Text, txtdesfim.Text)
            txtGas.Text = objdes.localizarDespesaTotalPeriodo(Dtpini.Text, DtpFim.Text)
            lblQTD.Text = "Qtd. de Despesas: " & DgdGrade.Rows.Count

        End If
    End Sub

    Private Sub txtdesini_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdesini.KeyPress
        e.Handled = objcontrole.SoNumerosEVirgula(e.KeyChar)
    End Sub

    Private Sub txtGas_TextChanged(sender As Object, e As EventArgs) Handles txtGas.TextChanged

    End Sub

    Private Sub DgdGrade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellContentClick

    End Sub
End Class