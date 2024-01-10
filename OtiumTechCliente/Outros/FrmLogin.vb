Public Class FrmLogin
    Dim conexao As New OleDb.OleDbConnection
    Dim verificachaveGestor, verificachaveFuncionario As New OleDb.OleDbCommand()
    Dim read As OleDb.OleDbDataReader
  

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexao.ConnectionString = "Provider=microsoft.ace.oledb.12.0;data source=BancoPti.accdb"


        verificachaveGestor.Connection = conexao

        verificachaveGestor.CommandType = CommandType.Text

        verificachaveGestor.CommandText = "Select * From tabGestor Where codges=? and senges=?"


        verificachaveFuncionario.Connection = conexao

        verificachaveFuncionario.CommandType = CommandType.Text

        verificachaveFuncionario.CommandText = "Select * From tabfuncionario Where codfun=? and senfun=?"

    End Sub


    Private Sub verificaLogin()




        With read

            If .Read Then

                MessageBox.Show("Acesso permitido ! Bem Vindo """ & txtcod.Text & """", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)

                If cbocar.SelectedIndex = 0 Then

                    Me.Hide()
                    FrmInicial.Show()
                    read.Close()

                ElseIf cbocar.SelectedIndex = 1 Then
                    Me.Hide()
                    FrmInicialFuncionario.Show()
                    read.Close()

                End If
            Else
                MessageBox.Show("Chave ou senha inválida !", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                read.Close()
            End If

        End With
    End Sub

    Private Sub BtnFun_Click(sender As Object, e As EventArgs)
        FrmInicialFuncionario.Show()
        Me.Close()
    End Sub

    Private Sub BtnGes_Click(sender As Object, e As EventArgs)
        FrmInicial.Show()
        Me.Close()
    End Sub

    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        If MessageBox.Show("Deseja fechar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub BtnEntrar_Click(sender As Object, e As EventArgs) Handles BtnEntrar.Click
        Try

            If cbocar.SelectedIndex = 0 Then
                verificachaveGestor.Parameters.Add("usuario", Data.OleDb.OleDbType.Variant)

                verificachaveGestor.Parameters.Add("senha", Data.OleDb.OleDbType.Variant)


                verificachaveGestor.Parameters("usuario").Value = txtcod.Text

                verificachaveGestor.Parameters("senha").Value = txtsen.Text




                'Abre conexao com banco de dados

                conexao.Open()


                ' Le a informação do banco de dados

                read = verificachaveGestor.ExecuteReader


                verificaLogin()

                ' fecha a conexao com o banco de dados

                conexao.Close()

            ElseIf CboCar.SelectedIndex = 1 Then
                verificachaveFuncionario.Parameters.Add("usuario", Data.OleDb.OleDbType.Variant)

                verificachaveFuncionario.Parameters.Add("senha", Data.OleDb.OleDbType.Variant)



                verificachaveFuncionario.Parameters("usuario").Value = TxtCod.Text

                verificachaveFuncionario.Parameters("senha").Value = txtsen.Text



                'Abre conexao com banco de dados

                conexao.Open()


                ' Le a informação do banco de dados

                read = verificachaveFuncionario.ExecuteReader


                verificaLogin()

                ' fecha a conexao com o banco de dados

                conexao.Close()


            End If





        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class