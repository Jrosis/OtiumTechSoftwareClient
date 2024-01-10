Public Class FrmFin

    Dim objControle As New ClsControle
    Dim objcam As New ClsCampanha
    Dim objdes As New ClsDespesa
    Dim objfin As New ClsFinanceiro

    Dim Novo As Boolean

    Private Sub BtnSai_Click(sender As Object, e As EventArgs) Handles BtnSai.Click
        Me.Close()
    End Sub

    Private Sub BtnNov_Click(sender As Object, e As EventArgs) Handles BtnNov.Click
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        BtnLocDes.Enabled = True
        BtnLocCam.Enabled = True
        TxtCodFin.Enabled = False

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
        BtnLocDes.Enabled = False
        BtnLocCam.Enabled = False
        GrpLoc.Visible = False
        BtnExc.Enabled = False
        BtnImp.Enabled = False
        BtnAlt.Enabled = False


    End Sub

    Private Sub BtnGra_Click(sender As Object, e As EventArgs) Handles BtnGra.Click


        If objControle.Testar_Vazio(Me) = True Then
            MessageBox.Show("Favor preencher todos os campos obrigatórios")
        Else




            objfin.Codigo = Val(TxtCodFin.Text)


            objfin.despesa = Txtdesfin.Text

            objfin.campanha = txtcamfin.Text

            objfin.data = Dtpdat.Text



            objfin.gravar_dados(Novo)

            TxtCodFin.Text = objfin.Codigo

            objControle.Habilitar_tela(Me, False)
            objControle.Habilitar_botoes(Me, True)
        End If


    End Sub

    Private Sub BtnCan_Click(sender As Object, e As EventArgs) Handles BtnCan.Click
        Call FrmCam_Load(Nothing, Nothing)

    End Sub

    Private Sub BtnAlt_Click(sender As Object, e As EventArgs) Handles BtnAlt.Click
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        TxtCodFin.Enabled = False
        Txtdesfin.Focus()
        Novo = False
    End Sub

    Private Sub BtnExc_Click(sender As Object, e As EventArgs) Handles BtnExc.Click
        If MessageBox.Show("Deseja Excluir o Registro " & TxtCodFin.Text & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            objfin.excluir(TxtCodFin.Text)
            objControle.Limpar_tela(Me)
            BtnExc.Enabled = False
            BtnAlt.Enabled = False
            BtnImp.Enabled = False
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
        If objfin.localizar(TxtLoc.Text) = True Then
            Call Mostrar_dados_da_tela()
            GrpLoc.Visible = False
        Else
            TxtLoc.Clear()
            TxtLoc.Focus()
        End If
    End Sub

    Private Sub Mostrar_dados_da_tela()
        TxtCodFin.Text = objfin.Codigo
        Txtdesfin.Text = objfin.despesa
        txtcamfin.Text = objfin.campanha
        DtpDat.Text = objfin.data
        objControle.Habilitar_botoes(Me, True)
    End Sub
    Private Sub TxtDesFin_Validated(sender As Object, e As EventArgs) Handles Txtdesfin.Validated
        If Txtdesfin.Text <> "" Then
            If objdes.localizar(Txtdesfin.Text) = True Then
                LblDesfin.Text = objdes.valor
            Else
                Txtdesfin.Clear()
                Txtdesfin.Focus()
                LblDesfin.Text = ""
            End If
        End If
    End Sub
    Private Sub txtcamfin_Validated(sender As Object, e As EventArgs) Handles txtcamfin.Validated
        If txtcamfin.Text <> "" Then
            If objcam.localizar(txtcamfin.Text) = True Then
                LblCamfin.Text = objcam.nome
            Else
                txtcamfin.Clear()
                txtcamfin.Focus()
                LblCamfin.Text = ""
            End If
        End If
    End Sub

    Private Sub BtnLocDes_Click(sender As Object, e As EventArgs) Handles BtnLocDes.Click
        FrmConDes.ShowDialog()
    End Sub

    Private Sub Txtdesfin_TextChanged(sender As Object, e As EventArgs) Handles Txtdesfin.TextChanged

    End Sub

    Private Sub BtnLocCam_Click(sender As Object, e As EventArgs) Handles BtnLocCam.Click
        '      FrmConCam.ShowDialog()
    End Sub

    Private Sub txtcamfin_TextChanged(sender As Object, e As EventArgs) Handles txtcamfin.TextChanged

    End Sub
End Class