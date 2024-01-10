Public Class FrmCadDes

    Dim objcontrole As New ClsControle
    Dim objdescad As New ClsDespesaCad
    Dim novo As Boolean
    Private Sub BtnSai_Click(sender As Object, e As EventArgs) Handles BtnSai.Click
        Me.Close()
    End Sub

    Private Sub BtnNov_Click(sender As Object, e As EventArgs) Handles BtnNov.Click
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        TxtCod.Enabled = False
        TxtTipDes.Focus()
        Novo = True
    End Sub

    Private Sub FrmCadcam_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 50
        Me.Left = 50
    End Sub

    Private Sub FrmCadcam_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 13 Then
            SendKeys.Send("{tab}")
        End If
    End Sub



    Private Sub FrmCadcam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objcontrole.Limpar_tela(Me)
        objcontrole.Habilitar_tela(Me, False)
        objcontrole.Habilitar_botoes(Me, True)

        GrpLoc.Visible = False
        BtnExc.Enabled = False

        BtnAlt.Enabled = False

    End Sub

    Private Sub BtnGra_Click(sender As Object, e As EventArgs) Handles BtnGra.Click


        If objControle.Testar_Vazio(Me) = True Then
            MessageBox.Show("Favor preencher todos os campos obrigatórios")
        Else

            objdescad.Codigo = Val(TxtCod.Text)


            objdescad.despesa = TxtTipDes.Text
            '   objdescad.valor = TxtVal.Text


            objdescad.gravar_dados(Novo)

            TxtCod.Text = objdescad.Codigo

            objControle.Habilitar_tela(Me, False)
            objcontrole.Habilitar_botoes(Me, True)
            FrmDes.atualizar_combo()
        End If


    End Sub

    Private Sub BtnCan_Click(sender As Object, e As EventArgs) Handles BtnCan.Click
        Call FrmCadcam_Load(Nothing, Nothing)

    End Sub

    Private Sub BtnAlt_Click(sender As Object, e As EventArgs) Handles BtnAlt.Click
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        TxtCod.Enabled = False
        TxtTipDes.Focus()
        Novo = False
    End Sub

    Private Sub BtnExc_Click(sender As Object, e As EventArgs) Handles BtnExc.Click
        If MessageBox.Show("Deseja Excluir o Registro " & TxtCod.Text & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            objdescad.excluir(TxtCod.Text)
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
        If objdescad.localizar(TxtLoc.Text) = True Then
            Call Mostrar_dados_da_tela()
            GrpLoc.Visible = False
        Else
            TxtLoc.Clear()
            TxtLoc.Focus()
        End If
    End Sub

    Private Sub Mostrar_dados_da_tela()
        TxtCod.Text = objdescad.Codigo
        TxtTipDes.Text = objdescad.despesa
        objControle.Habilitar_botoes(Me, True)
    End Sub
End Class