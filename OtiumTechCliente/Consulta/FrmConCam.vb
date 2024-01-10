Public Class FrmConCam

    Dim objcontrole As New ClsControle
    Dim objcam As New ClsCampanha
    Dim objcli As New ClsCliente

    Private Sub FrmConCam_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub

    Private Sub FrmConCam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtcli.Clear()
        Call txtcli_TextChanged(Nothing, Nothing)
        txtGan.Enabled = False
    End Sub

    Private Sub txtcli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcli.KeyPress
        e.Handled = objcontrole.SoNumerosEVirgula(e.KeyChar)
    End Sub


    Private Sub BtnLoc_Click(sender As Object, e As EventArgs) Handles BtnLoc.Click
        If objcontrole.Testar_Vazio(Me) = True Then
            MessageBox.Show("Favor preencher todos os campos obrigatórios")
        Else

            DgdGrade.DataSource = objcam.localizarcampanhaperiodo(Dtpini.Text, DtpFim.Text, txtcli.Text)
            txtGan.Text = objcam.localizarCampanhaTotalPeriodo(Dtpini.Text, DtpFim.Text, txtcli.Text)
            lblQTD.Text = "Qtd. de Campanhas: " & DgdGrade.Rows.Count

        End If
    End Sub

    Private Sub txtcli_TextChanged(sender As Object, e As EventArgs) Handles txtcli.TextChanged
        DgdGrade.DataSource = objcam.localizarParaGrade(txtcli.Text)
        lblQTD.Text = "Qtd. de Campanhas: " & DgdGrade.Rows.Count
    End Sub
End Class