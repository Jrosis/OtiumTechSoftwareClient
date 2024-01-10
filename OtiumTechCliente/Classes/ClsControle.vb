Public Class ClsControle

    Public Function SoNumerosEVirgula(caracter As String) As Boolean
        If Asc(caracter) = 8 Or Asc(caracter) = 13 Or Asc(caracter) = 44 Then
            Return False 'Libera teclado
        Else
            If Asc(caracter) < 48 Or Asc(caracter) > 57 Then
                Return True ' Trava teclado
            End If
        End If
    End Function
    Public Function SoNumeros(caracter As String) As Boolean
        If Asc(caracter) = 8 Or Asc(caracter) = 13 Then
            Return False 'Libera teclado
        Else
            If Asc(caracter) < 48 Or Asc(caracter) > 57 Then
                Return True ' Trava teclado
            End If
        End If
    End Function

    Public Function Testar_Vazio(ByVal tela As Control) As Boolean
        Dim controle As Control
        For Each controle In tela.Controls
            If TypeOf controle Is TextBox Then
                If controle.Text = "" And controle.Tag <> "x" Then
                    controle.Focus()
                    Return True
                End If
            ElseIf TypeOf controle Is MaskedTextBox Then
                If controle.Text = "(  )      -" Then
                    controle.Focus()
                    Return True
                End If
            End If


        Next


    End Function

    Public Sub Limpar_tela(ByVal tela As Object)
        Dim controle As Object
        For Each controle In tela.Controls
            If TypeOf controle Is TextBox Or
                TypeOf controle Is MaskedTextBox Then
                controle.Text = ""
            ElseIf TypeOf controle Is Label And controle.Tag = "c" Then
                controle.Text = "" 'ideia do Nava 2022
            ElseIf TypeOf controle Is DataGridView Then
                controle.rows.clear()
            ElseIf TypeOf controle Is CheckBox Then
                controle.checked = False
            End If
        Next
    End Sub

    Public Sub Habilitar_tela(ByVal tela As Control, ByVal tipo As Boolean)
        Dim controle As Control
        For Each controle In tela.Controls
            'If controle.Tag = "h" Then
            If TypeOf controle Is TextBox Or
                TypeOf controle Is MaskedTextBox Or
                TypeOf controle Is ComboBox Or
                TypeOf controle Is DateTimePicker Or
                TypeOf controle Is DataGridView Or
                TypeOf controle Is CheckBox Then
                controle.Enabled = tipo
            End If
            ' End If
        Next
    End Sub

    Public Sub Habilitar_botoes(ByVal tela As Control, ByVal tipo As Boolean)
        Dim controle As Control
        For Each controle In tela.Controls
            If TypeOf controle Is Button Then
                controle.Enabled = tipo
                If controle.Name.ToUpper = "BTNGRA" Then
                    controle.Enabled = Not tipo
                ElseIf controle.Name.ToUpper = "BTNSAI" Or
                    controle.Name.ToUpper = "BTNCAN" Then
                    controle.Enabled = True
                End If
            End If
        Next
    End Sub
End Class
