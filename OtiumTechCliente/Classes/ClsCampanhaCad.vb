Public Class ClsCampanhaCad
    Dim m_cod As Integer
    Dim m_tip As String

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

    Public Property tipo() As String
        Get
            Return m_tip
        End Get
        Set(ByVal value As String)

            m_tip = value
        End Set
    End Property

    Public Sub gravar_dados(novo As Boolean)
        If novo = True Then

            sql = "insert into tabtipocampanha (nomtip) values ('" & m_tip & "')"
            objbanco.Executar_comando(sql)

            sql = "Select max(codtip) from tabtipocampanha"
            m_cod = objbanco.Buscar_ultimoRegistro(sql)
        Else
            sql = "update tabtipocampanha set nomtip='" & m_tip & "' where codtip=" & m_cod
            objbanco.Executar_comando(sql)
        End If


    End Sub
    Public Function localizarParaGrade(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "Select * from tabtipocampanha where codtip=" & campo
        Else
            sql = "Select * from tabtipocampanha where nomtip like '" & campo & "%' order by nomtip"
        End If
        objDtLocal = objbanco.Localizar_dados(sql)
        Return objDtLocal
    End Function
    Public Function localizar(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "Select * from tabtipocampanha where codtip=" & campo
        Else
            sql = "Select * from tabtipocampanha where nomtip='" & campo & "'"
        End If
        objDtLocal = objbanco.Localizar_dados(sql)
        If objdtLocal.Rows.Count = 0 Then
            MessageBox.Show("Registro " & campo & " não encontrado")
            Return False
        Else
            mostrar_dadosDaClasse()
            Return True
        End If
    End Function
    Public Function localizar_Todos() As DataTable

        sql = "Select codtip, nomtip from tabtipocampanha order by nomtip"

        objDtLocal = objBanco.Localizar_dados(sql)
        Return objDtLocal
    End Function
    Public Sub excluir(campo As Integer)
        sql = "Delete from tabtipocampanha where codtip=" & campo
        objbanco.Executar_comando(sql)
    End Sub

    Public Sub mostrar_dadosDaClasse()
        m_cod = objDtLocal.Rows(0).Item(0)
        m_tip = objDtLocal.Rows(0).Item(1)
    End Sub
End Class
