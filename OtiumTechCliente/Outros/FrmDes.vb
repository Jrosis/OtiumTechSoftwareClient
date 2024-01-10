Public Class FrmDes

    Dim objControle As New ClsControle
    Dim objdes As New ClsDespesa
    Dim objfun As New ClsFuncionario
    Dim objdescad As New ClsDespesaCad

    Dim Novo As Boolean

    Private Sub BtnSai_Click_1(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub BtnNov_Click(sender As Object, e As EventArgs)
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        BtnLocFun.Enabled = True
        btnCadDes.Enabled = True
        TxtCodDes.Enabled = False

        TxtFun.Focus()
        Novo = True
    End Sub

    Private Sub FrmDes_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 50
        Me.Left = 50

  
    End Sub

    Private Sub FrmDes_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 13 Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Public Sub atualizar_combo()
        CboDes.DisplayMember = "nomdes"
        CboDes.ValueMember = "codtipdes"
        CboDes.DataSource = objdescad.localizar_Todos()
    End Sub

    Private Sub FrmDes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, False)
        objControle.Habilitar_botoes(Me, True)

        GrpLoc.Visible = False
        BtnExc.Enabled = False
        BtnAlt.Enabled = False

        BtnLocFun.Enabled = False
        BtnCadDes.Enabled = False
        atualizar_combo()

    End Sub

    Private Sub BtnGra_Click_1(sender As Object, e As EventArgs)


        If objControle.Testar_Vazio(Me) = True Then
            MessageBox.Show("Favor preencher todos os campos obrigatórios")
        Else




            objdes.Codigo = Val(TxtCodDes.Text)


            objdes.funcionario = TxtFun.Text

            objdes.despesa = CboDes.SelectedValue

            objdes.data = DtpDat.Text
            objdes.valor = Txtval.Text



            objdes.gravar_dados(Novo)

            TxtCodDes.Text = objdes.Codigo

            objControle.Habilitar_tela(Me, False)
            objControle.Habilitar_botoes(Me, True)
        End If


    End Sub

    Private Sub BtnCan_Click(sender As Object, e As EventArgs) Handles BtnCan.Click
        Call FrmDes_Load(Nothing, Nothing)

    End Sub

    Private Sub BtnAlt_Click(sender As Object, e As EventArgs) Handles BtnAlt.Click
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        TxtCodDes.Enabled = False
        CboDes.Focus()
        Novo = False
    End Sub

    Private Sub BtnExc_Click(sender As Object, e As EventArgs) Handles BtnExc.Click
        If MessageBox.Show("Deseja Excluir o Registro " & TxtCodDes.Text & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            objdes.excluir(TxtCodDes.Text)
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

    Private Sub TxtLoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtLoc.KeyPress
        e.Handled = objControle.SoNumerosEVirgula(e.KeyChar)
    End Sub
    Private Sub TxtLoc_TextChanged(sender As Object, e As EventArgs) Handles TxtLoc.TextChanged
        If TxtLoc.Text <> "" Then
            BtnOk.Enabled = True
        Else
            BtnOk.Enabled = False
        End If
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If objdes.localizar(TxtLoc.Text) = True Then
            Call Mostrar_dados_da_tela()
            GrpLoc.Visible = False
        Else
            TxtLoc.Clear()
            TxtLoc.Focus()
        End If
    End Sub



    Private Sub Mostrar_dados_da_tela()
        TxtCodDes.Text = objdes.Codigo
        txtfun.Text = objdes.funcionario
        CboDes.SelectedValue = objdes.despesa
        DtpDat.Text = objdes.data
        TxtVal.Text = objdes.valor
        objControle.Habilitar_botoes(Me, True)
    End Sub

    Private Sub BtnLocFun_Click(sender As Object, e As EventArgs) Handles BtnLocFun.Click
        FrmConFun.ShowDialog()
    End Sub

    Private Sub TxtFun_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFun.KeyPress
        e.Handled = objControle.SoNumerosEVirgula(e.KeyChar)
    End Sub

    Private Sub txtfun_TextChanged(sender As Object, e As EventArgs) Handles TxtFun.TextChanged

    End Sub

    Private Sub txtfun_Validated(sender As Object, e As EventArgs) Handles TxtFun.Validated
        If txtfun.Text <> "" Then
            If objfun.localizar(TxtFun.Text) = True Then
                LblFun.Text = objfun.Nome
            Else
                TxtFun.Clear()
                TxtFun.Focus()
                LblFun.Text = ""
            End If
        End If
    End Sub

    Private Sub BtnCadDes_Click(sender As Object, e As EventArgs) Handles btnCadDes.Click
        FrmCadDes.Show()
    End Sub

    Private Sub BtnNov_Click_1(sender As Object, e As EventArgs) Handles BtnNov.Click
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        DtpDat.Enabled = False
        BtnLocFun.Enabled = True
        btnCadDes.Enabled = True
        TxtCodDes.Enabled = False

        TxtFun.Focus()
        Novo = True
    End Sub

    Private Sub BtnGra_Click(sender As Object, e As EventArgs) Handles BtnGra.Click


        If objControle.Testar_Vazio(Me) = True Then
            MessageBox.Show("Favor preencher todos os campos obrigatórios")
        Else




            objdes.Codigo = Val(TxtCodDes.Text)


            objdes.funcionario = TxtFun.Text

            objdes.despesa = CboDes.SelectedValue

            objdes.data = DtpDat.Text
            objdes.valor = Txtval.Text



            objdes.gravar_dados(Novo)

            TxtCodDes.Text = objdes.Codigo

            objControle.Habilitar_tela(Me, False)
            objControle.Habilitar_botoes(Me, True)
            BtnLocFun.Enabled = False
            btnCadDes.Enabled = False
        End If

    End Sub

    Private Sub BtnSai_Click(sender As Object, e As EventArgs) Handles BtnSai.Click
        Me.Close()
    End Sub

    Private Sub Txtval_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtval.KeyPress
        e.Handled = objControle.SoNumerosEVirgula(e.KeyChar)
    End Sub

    Private Sub Txtval_TextChanged(sender As Object, e As EventArgs) Handles Txtval.TextChanged

    End Sub

    Private Sub CboDes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboDes.SelectedIndexChanged

    End Sub

    Private Sub CboDes_Validated(sender As Object, e As EventArgs) Handles CboDes.Validated
        '  If CboDes.Text = "SALÁRIO" Then
        '          Txtval.Text = 
        '   End If
    End Sub
End Class