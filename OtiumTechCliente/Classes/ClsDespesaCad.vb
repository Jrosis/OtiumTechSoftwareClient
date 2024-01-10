Public Class ClsDespesaCad
    Dim m_cod As Integer
    Dim m_des As String
    ' Dim m_val As Single

    Dim sql As String

    Dim objbanco As New ClsBanco
    Dim objDtLocal As New DataTable

    Public Property Codigo() As Integer
        Get
            Return m_cod
        End Get
        Set(ByVal value As Integer)
            m_cod = value
        End Set
    End Property

    Public Property despesa() As String
        Get
            Return m_des
        End Get
        Set(ByVal value As String)

            m_des = value
        End Set
    End Property
    Public Sub gravar_dados(novo As Boolean)
        If novo = True Then

            sql = "insert into tabtipodespesa (nomdes) values ('" & m_des & "')"
            objbanco.Executar_comando(sql)

            sql = "Select max(codtipdes) from tabtipodespesa"
            m_cod = objbanco.Buscar_ultimoRegistro(sql)
        Else
            sql = "update tabtipodespesa set nomdes='" & m_des & "' where codtipdes=" & m_cod
            objbanco.Executar_comando(sql)
        End If


    End Sub
    Public Function localizarParaGrade(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "Select * from tabtipodespesa where codtipdes=" & campo
        Else
            sql = "Select * from tabtipodespesa where nomdes like '" & campo & "%' order by nomdes"
        End If
        objDtLocal = objbanco.Localizar_dados(sql)
        Return objDtLocal
    End Function
    Public Function localizar(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "Select * from tabtipodespesa where codtipdes=" & campo
        Else
            sql = "Select * from tabtipodespesa where nomdes='" & campo & "'"
        End If
        objDtLocal = objbanco.Localizar_dados(sql)
        If objDtLocal.Rows.Count = 0 Then
            MessageBox.Show("Registro " & campo & " não encontrado")
            Return False
        Else
            mostrar_dadosDaClasse()
            Return True
        End If
    End Function
    Public Function localizar_Todos() As DataTable

        sql = "Select codtipdes, nomdes from tabtipodespesa order by nomdes"

        objDtLocal = objbanco.Localizar_dados(sql)
        Return objDtLocal
    End Function
    Public Sub excluir(campo As Integer)
        sql = "Delete from tabtipodespesa where codtipdes=" & campo
        objbanco.Executar_comando(sql)
    End Sub

    Public Sub mostrar_dadosDaClasse()
        m_cod = objDtLocal.Rows(0).Item(0)
        m_des = objDtLocal.Rows(0).Item(1)
    End Sub
End Class
