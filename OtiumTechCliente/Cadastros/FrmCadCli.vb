Public Class FrmCadCli
    Dim objControle As New ClsControle
    Dim objCli As New ClsCliente
    Dim Novo As Boolean

    Private Sub BtnSai_Click(sender As Object, e As EventArgs) Handles BtnSai.Click
        Me.Close()
    End Sub

    Private Sub BtnNov_Click(sender As Object, e As EventArgs) Handles BtnNov.Click
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        TxtCod.Enabled = False
        TxtNomSoc.Focus()
        Novo = True
    End Sub

    Private Sub FrmCadCli_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 50
        Me.Left = 50
    End Sub

    Private Sub FrmCadCli_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 13 Then
            SendKeys.Send("{tab}")
        End If
    End Sub



    Private Sub FrmCadCli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, False)
        objControle.Habilitar_botoes(Me, True)

        GrpLoc.Visible = False
        BtnExc.Enabled = False
        BtnAlt.Enabled = False

    End Sub

    Private Sub BtnGra_Click(sender As Object, e As EventArgs) Handles BtnGra.Click


        If objControle.Testar_Vazio(Me) = True Then
            MessageBox.Show("Favor preencher todos os campos obrigatórios")
        Else




            objCli.Codigo = Val(TxtCod.Text)


            objCli.NomeSocial = TxtNomSoc.Text
            objCli.NomeFantasia = TxtNomFan.Text

            objCli.Telefone = MskTel.Text
            objCli.CNPJ = MskCNPJ.Text
            objCli.Ramo = TxtRam.Text
            objCli.faturamento = TxtFat.Text
            objCli.Senha = TxtSen.Text


            objCli.gravar_dados(Novo)

            TxtCod.Text = objCli.Codigo

            objControle.Habilitar_tela(Me, False)
            objControle.Habilitar_botoes(Me, True)
        End If


    End Sub

    Private Sub BtnCan_Click(sender As Object, e As EventArgs) Handles BtnCan.Click
        Call FrmCadCli_Load(Nothing, Nothing)

    End Sub

    Private Sub BtnAlt_Click(sender As Object, e As EventArgs) Handles BtnAlt.Click
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        TxtCod.Enabled = False
        TxtNomSoc.Focus()
        Novo = False
    End Sub

    Private Sub BtnExc_Click(sender As Object, e As EventArgs) Handles BtnExc.Click
        If MessageBox.Show("Deseja Excluir o Registro " & TxtCod.Text & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            objCli.excluir(TxtCod.Text)
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
        If objCli.localizar(TxtLoc.Text) = True Then
            Call Mostrar_dados_da_tela()
            GrpLoc.Visible = False
        Else
            TxtLoc.Clear()
            TxtLoc.Focus()
        End If
    End Sub

    Private Sub Mostrar_dados_da_tela()
        TxtCod.Text = objCli.Codigo
        TxtNomSoc.Text = objCli.NomeSocial
        TxtNomFan.Text = objCli.NomeFantasia
        MskTel.Text = objCli.Telefone
        MskCNPJ.Text = objCli.CNPJ
        TxtRam.Text = objCli.Ramo
        TxtFat.Text = objCli.faturamento
        TxtSen.Text = objCli.Senha
        objControle.Habilitar_botoes(Me, True)
    End Sub

    Private Sub MskCNPJ_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MskCNPJ.MaskInputRejected

    End Sub

    Private Sub MskCNPJ_Validated(sender As Object, e As EventArgs) Handles MskCNPJ.Validated

    End Sub

    Private Sub TxtSen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSen.KeyPress
        e.Handled = objControle.SoNumerosEVirgula(e.KeyChar)
    End Sub

    Private Sub TxtSen_TextChanged(sender As Object, e As EventArgs) Handles TxtSen.TextChanged

    End Sub

    Private Sub TxtSen_Validated(sender As Object, e As EventArgs) Handles TxtSen.Validated

    End Sub

    Private Sub TxtFat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFat.KeyPress
        e.Handled = objControle.SoNumerosEVirgula(e.KeyChar)
    End Sub

    Private Sub TxtFat_TextChanged(sender As Object, e As EventArgs) Handles TxtFat.TextChanged

    End Sub

    Private Sub BtnImp_Click(sender As Object, e As EventArgs)
    End Sub
End Class
