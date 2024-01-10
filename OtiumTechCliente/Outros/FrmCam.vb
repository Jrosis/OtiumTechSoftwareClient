Public Class FrmCam

    Dim objControle As New ClsControle
    Dim objcam As New ClsCampanha
    Dim objcli As New ClsCliente

    Dim Novo As Boolean

    Private Sub BtnSai_Click(sender As Object, e As EventArgs) Handles BtnSai.Click
        Me.Close()
    End Sub

    Private Sub BtnNov_Click(sender As Object, e As EventArgs) Handles BtnNov.Click
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        BtnLocCli.Enabled = True
        TxtCodcam.Enabled = False
        TxtVal.Enabled = False

        Txtcli.Focus()
        Novo = True
    End Sub

    Private Sub FrmCam_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 50
        Me.Left = 50
    End Sub

    Private Sub FrmCam_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 13 Then
            SendKeys.Send("{tab}")
        End If
    End Sub



    Private Sub FrmCam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, False)
        objControle.Habilitar_botoes(Me, True)
        BtnLocCli.Enabled = False
        GrpLoc.Visible = False
        BtnExc.Enabled = False

        BtnAlt.Enabled = False
        BtnLocCli.Enabled = False

    End Sub

    Private Sub BtnGra_Click(sender As Object, e As EventArgs) Handles BtnGra.Click
        If DtpFin.Text <= DtpIni.Text Then
            MessageBox.Show("A data inicial deve ser menor que a data final", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Question)
            DtpFin.Focus()
        Else

            If objControle.Testar_Vazio(Me) = True Then
                MessageBox.Show("Favor preencher todos os campos obrigatórios")
            Else




                objcam.Codigo = Val(TxtCodcam.Text)


                objcam.cliente = Txtcli.Text

                objcam.descricao = TxtDes.Text
                objcam.inicio = DtpIni.Text
                objcam.final = DtpFin.Text
                objcam.nome = TxtNom.Text
                objcam.valor = TxtVal.Text


                objcam.gravar_dados(Novo)

                TxtCodcam.Text = objcam.Codigo

                objControle.Habilitar_tela(Me, False)
                objControle.Habilitar_botoes(Me, True)
            End If
        End If

    End Sub

    Private Sub BtnCan_Click(sender As Object, e As EventArgs) Handles BtnCan.Click
        Call FrmCam_Load(Nothing, Nothing)

    End Sub

    Private Sub BtnAlt_Click(sender As Object, e As EventArgs) Handles BtnAlt.Click
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        TxtCodcam.Enabled = False
        TxtNom.Focus()
        Novo = False
    End Sub

    Private Sub BtnExc_Click(sender As Object, e As EventArgs) Handles BtnExc.Click
        If MessageBox.Show("Deseja Excluir o Registro " & TxtCodcam.Text & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            objcam.excluir(TxtCodcam.Text)
            objControle.Limpar_tela(Me)
            BtnExc.Enabled = False
            BtnAlt.Enabled = False

        End If
    End Sub

    Private Sub BtnLoc_Click(sender As Object, e As EventArgs) Handles BtnLoc.Click
        GrpLoc.Visible = True
        BtnOk.Enabled = False
        TxtLoc.Text = ""
        TxtLoc.Focus()
    End Sub
    Private Sub TxtLoc_TextChanged(sender As Object, e As EventArgs) Handles TxtLoc.TextChanged
        If TxtLoc.Text <> "" Then
            BtnOk.Enabled = True
        Else
            BtnOk.Enabled = False
        End If
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If objcam.localizar(TxtLoc.Text) = True Then
            Call Mostrar_dados_da_tela()
            GrpLoc.Visible = False
        Else
            TxtLoc.Clear()
            TxtLoc.Focus()
        End If
    End Sub

    Private Sub Mostrar_dados_da_tela()
        TxtCodcam.Text = objcam.Codigo
        Txtcli.Text = objcam.cliente
        LblCli.Text = objcli.NomeSocial
        TxtDes.Text = objcam.descricao
        DtpIni.Text = objcam.inicio
        DtpFin.Text = objcam.final
        TxtNom.Text = objcam.nome
        TxtVal.Text = objcam.valor
        objControle.Habilitar_botoes(Me, True)
    End Sub

    Private Sub BtnLocCli_Click(sender As Object, e As EventArgs) Handles BtnLocCli.Click
        FrmConCli.ShowDialog()
    End Sub

    Private Sub Txtcli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtcli.KeyPress
        e.Handled = objControle.SoNumerosEVirgula(e.KeyChar)
    End Sub

    Private Sub Txtcli_TextChanged(sender As Object, e As EventArgs) Handles Txtcli.TextChanged

    End Sub

    Private Sub Txtcli_Validated(sender As Object, e As EventArgs) Handles Txtcli.Validated
        If Txtcli.Text <> "" Then
            If objcli.localizar(Txtcli.Text) = True Then
                LblCli.Text = objcli.NomeSocial
            Else
                Txtcli.Clear()
                Txtcli.Focus()
                LblCli.Text = ""
            End If
        End If
    End Sub
    Private Sub DtpFin_Validated(sender As Object, e As EventArgs) Handles DtpFin.Validated
        'Dim ini, fim As Date
        '  ini = DtpIni.Text
        ' fim = DtpFin.Text
        ' Dim resposta As Integer
        ' resposta = DateDiff(DateInterval.Hour, ini, fim)
        '  If resposta <= 0 Then
        'MessageBox.Show("Coloque uma data que seja após o inicio")
        '  TxtVal.Clear()
        '  Else
        ' TxtVal.Text = resposta * 50
        ' End If

    End Sub

    Private Sub TxtVal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtVal.KeyPress
        e.Handled = objControle.SoNumerosEVirgula(e.KeyChar)
    End Sub

    Private Sub TxtVal_TextChanged(sender As Object, e As EventArgs) Handles TxtVal.TextChanged

    End Sub

    Private Sub DtpFin_ValueChanged(sender As Object, e As EventArgs) Handles DtpFin.ValueChanged

    End Sub

    Private Sub DtpIni_Validated(sender As Object, e As EventArgs) Handles DtpIni.Validated
        Dim ini, fim As Date
        ini = DtpIni.Text
        fim = Today
        Dim resposta As Integer
        resposta = DateDiff(DateInterval.Day, ini, fim)
        If resposta >= 0 Then
            MessageBox.Show("A data inicial nao pode ser em um dia anterior")
            DtpIni.Text = Today
            TxtVal.Clear()
        Else
            TxtVal.Text = resposta * 50
        End If
    End Sub

    Private Sub DtpIni_ValueChanged(sender As Object, e As EventArgs) Handles DtpIni.ValueChanged

    End Sub
End Class