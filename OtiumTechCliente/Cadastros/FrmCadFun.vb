Public Class FrmCadFun

    Dim objControle As New ClsControle
    Dim novo As String
    Dim objFun As New ClsFuncionario

    Private Sub FrmCadFun_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 50
        Me.Left = 50
    End Sub

    Private Sub FrmCadFun_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 13 Then
            SendKeys.Send("{tab}")
        End If
    End Sub
    Private Sub FrmCadFun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, False)
        objControle.Habilitar_botoes(Me, True)

        GrpLoc.Visible = False
        BtnExc.Enabled = False

        BtnAlt.Enabled = False
        TxtBan.Enabled = False
        TxtCon.Enabled = False
        TxtCodCon.Enabled = False
        TxtAge.Enabled = False
    End Sub
    Private Sub BtnNov_Click(sender As Object, e As EventArgs) Handles BtnNov.Click
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        TxtCod.Enabled = False
        txtEnd.Enabled = False
        txtbai.Enabled = False
        txtEst.Enabled = False
        txtCid.Enabled = False
        TxtBan.Enabled = True
        TxtCon.Enabled = True
        TxtCodCon.Enabled = True
        TxtAge.Enabled = True
        TxtNom.Focus()
        Novo = True
    End Sub

    Private Sub BtnGra_Click(sender As Object, e As EventArgs) Handles BtnGra.Click
        If objControle.Testar_Vazio(Me) = True Then
            MessageBox.Show("Favor preencher todos os campos obrigatórios")
        Else




            objFun.Codigo = Val(TxtCod.Text)


            objFun.Nome = TxtNom.Text
            objFun.Nascimento = DtpNas.Text
            objFun.Cep = mskCep.Text
            objFun.Endereco = txtEnd.Text
            objFun.bairro = txtbai.Text
            objFun.estado = txtEst.Text
            objFun.Cidade = txtCid.Text
            objFun.Civil = CboCiv.Text
            objFun.Filiacao = TxtFil.Text
            objFun.Pendentes = TxtPen.Text
            objFun.Carteira = MskCrt.Text
            objFun.Eleitor = MskEle.Text
            objFun.Salario = TxtSal.Text
            objFun.Senha = TxtSen.Text
            objFun.Ativo = ChkAti.Checked
            objFun.Admissao = DtpAdm.Text
            objFun.Banco = txtban.Text
            objFun.Agencia = txtage.Text
            objFun.Conta = TxtCon.Text
            objFun.CodigoConta = TxtCodCon.Text







            objFun.gravar_dados(novo)

            TxtCod.Text = objFun.Codigo

            objControle.Habilitar_tela(Me, False)
            objControle.Habilitar_botoes(Me, True)
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
        If objFun.localizar(TxtLoc.Text) = True Then
            Call Mostrar_dados_da_tela()
            GrpLoc.Visible = False
        Else
            TxtLoc.Clear()
            TxtLoc.Focus()
        End If
    End Sub
    Private Sub Mostrar_dados_da_tela()


        TxtNom.Text = objFun.Nome
        DtpNas.Text = objFun.Nascimento
        mskCep.Text = objFun.Cep
        txtEnd.Text = objFun.Endereco
        txtbai.Text = objFun.bairro
        txtEst.Text = objFun.estado
        txtCid.Text = objFun.Cidade
        CboCiv.Text = objFun.Civil
        TxtFil.Text = objFun.Filiacao
        TxtPen.Text = objFun.Pendentes
        MskCrt.Text = objFun.Carteira
        MskEle.Text = objFun.Eleitor
        TxtSal.Text = objFun.Salario
        TxtSen.Text = objFun.Senha
        ChkAti.Checked = objFun.Ativo
        DtpAdm.Text = objFun.Admissao
        txtban.Text = objFun.Banco
        txtage.Text = objFun.Agencia
        TxtCon.Text = objFun.Conta
        TxtCodCon.Text = objFun.CodigoConta


        objControle.Habilitar_botoes(Me, True)
    End Sub

    Private Sub BtnAlt_Click(sender As Object, e As EventArgs) Handles BtnAlt.Click
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        TxtCod.Enabled = False
        TxtNom.Focus()
        novo = False
    End Sub

    Private Sub BtnExc_Click(sender As Object, e As EventArgs) Handles BtnExc.Click
        If MessageBox.Show("Deseja Excluir o Registro " & TxtCod.Text & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            objFun.excluir(TxtCod.Text)
            objControle.Limpar_tela(Me)
            BtnExc.Enabled = False
            BtnAlt.Enabled = False

        End If
    End Sub

    Private Sub BtnCan_Click(sender As Object, e As EventArgs) Handles BtnCan.Click
        Call FrmCadFun_Load(Nothing, Nothing)

    End Sub

    Private Sub BtnSai_Click(sender As Object, e As EventArgs) Handles BtnSai.Click
        Me.Close()
    End Sub


    Private Sub TxtSal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSal.KeyPress
        e.Handled = objControle.SoNumerosEVirgula(e.KeyChar)
    End Sub

    Private Sub mskCEP_Validated(sender As Object, e As EventArgs) Handles mskCep.Validated
        If mskCep.Text.Length = 0 Then
            MessageBox.Show("CEP está vazio", "Aviso", MessageBoxButtons.OK)

            mskCep.Clear()
            txtbai.Clear()
            txtcid.Clear()
            txtEst.Clear()
            txtEnd.Clear()
        Else
            Dim xml As String = String.Format("http://cep.republicavirtual.com.br/web_cep.php?cep={0}&formato=xml", mskCep.Text)



            Dim ds As New DataSet()
            ds.ReadXml(xml)



            If ds.Tables(0).Rows(0)(2).ToString() = "sucesso - cep não encontrado" Or ds.Tables(0).Rows(0)(2).ToString() = "sucesso - cep completo" Then
                MessageBox.Show("CEP incorreto", "Aviso", MessageBoxButtons.OK)
                mskCep.Clear()
                txtbai.Clear()
                txtCid.Clear()
                txtEst.Clear()
                txtEnd.Clear()

            Else




                txtEnd.Text = ds.Tables(0).Rows(0)(6).ToString()
                txtbai.Text = ds.Tables(0).Rows(0)(4).ToString()
                txtCid.Text = ds.Tables(0).Rows(0)(3).ToString()
                txtEst.Text = ds.Tables(0).Rows(0)(2).ToString()

            End If
        End If
    End Sub

    Private Sub TxtSal_TextChanged(sender As Object, e As EventArgs) Handles TxtSal.TextChanged

    End Sub

    Private Sub TxtSen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSen.KeyPress
        e.Handled = objControle.SoNumerosEVirgula(e.KeyChar)
    End Sub

    Private Sub TxtSen_TextChanged(sender As Object, e As EventArgs) Handles TxtSen.TextChanged

    End Sub

    Private Sub DtpNas_Validated(sender As Object, e As EventArgs) Handles DtpNas.Validated

    End Sub

    Private Sub DtpNas_ValueChanged(sender As Object, e As EventArgs) Handles DtpNas.ValueChanged

    End Sub

    Private Sub mskCep_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mskCep.MaskInputRejected

    End Sub
End Class