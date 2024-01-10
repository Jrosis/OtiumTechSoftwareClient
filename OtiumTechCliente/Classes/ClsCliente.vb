Public Class ClsCliente
    Dim m_cod As Integer
    Dim m_nomSoc As String
    Dim m_nomFan As String
    Dim m_tel As String
    Dim m_CNPJ As String
    Dim m_ram As String
    Dim m_fat As Single

    Dim m_sen As String

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

    Public Property NomeSocial() As String
        Get
            Return m_nomSoc
        End Get
        Set(ByVal value As String)

            m_nomSoc = value
        End Set
    End Property

    Public Property NomeFantasia() As String
        Get
            Return m_nomFan
        End Get
        Set(ByVal value As String)
            m_nomFan = value
        End Set
    End Property
    Public Property Telefone() As String
        Get
            Return m_tel
        End Get
        Set(ByVal value As String)
            m_tel = value
        End Set
    End Property
    Public Property CNPJ() As String
        Get
            Return m_CNPJ
        End Get
        Set(ByVal value As String)
            m_CNPJ = value
        End Set
    End Property

    Public Property Ramo() As String
        Get
            Return m_ram
        End Get
        Set(ByVal value As String)

            m_ram = value
        End Set
    End Property

    Public Property faturamento() As Single
        Get
            Return m_fat
        End Get
        Set(ByVal value As Single)
            m_fat = value
        End Set
    End Property
 

    Public Property Senha() As String
        Get
            Return m_sen
        End Get
        Set(ByVal value As String)

            m_sen = value
        End Set
    End Property

    Public Sub gravar_dados(novo As Boolean)
        If novo = True Then

            sql = "Insert into tabcliente " & _
           "(nomsoccli " & _
           ",nomfancli " & _
           ",telcli " & _
           ",CNPJcli " & _
           ",ramcli " & _
           ",fatcli " & _
           ",sencli " & _
           ") values " & _
           "('" & m_nomSoc & "'" & _
           ",'" & m_nomFan & "'" & _
           ",'" & m_tel & "'" & _
           ",'" & m_CNPJ & "'" & _
           ",'" & m_ram & "'" & _
           ",'" & m_fat & "'" & _
           ",'" & m_sen & "'" & _
           ")"
            objbanco.Executar_comando(sql)

            sql = "Select max(codcli) from tabcliente"
            m_cod = objbanco.Buscar_ultimoRegistro(sql)
        Else
            sql = "update tabcliente set " & _
            " nomsoccli='" & m_nomSoc & "'" & _
            ",nomfancli='" & m_nomFan & "'" & _
            ",telcli='" & m_tel & "'" & _
            ",CNPJcli='" & m_CNPJ & "'" & _
            ",ramcli='" & m_ram & "'" & _
            ",fatcli='" & m_fat & "'" & _
            ",sencli='" & m_sen & "'" & _
            " where codcli=" & m_cod
            objbanco.Executar_comando(sql)
        End If


    End Sub
    Public Function localizarParaGrade(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "Select * from tabcliente where codcli=" & campo
        Else
            sql = "Select * from tabcliente where nomsoccli like '" & campo & "%' order by nomsoccli"
        End If
        objDtLocal = objbanco.Localizar_dados(sql)
        Return objDtLocal
    End Function
    Public Function localizar(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "Select * from tabcliente where codcli=" & campo
        Else
            sql = "Select * from tabcliente where nomsoccli='" & campo & "'"
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
    Public Sub excluir(campo As Integer)
        sql = "Delete from tabcliente where codcli=" & campo
        objbanco.Executar_comando(sql)
    End Sub

    Public Sub mostrar_dadosDaClasse()
        m_cod = objDtLocal.Rows(0).Item(0)
        m_nomSoc = objDtLocal.Rows(0).Item(1)
        m_nomFan = objDtLocal.Rows(0).Item(2)
        m_tel = objDtLocal.Rows(0).Item(3)
        m_CNPJ = objDtLocal.Rows(0).Item(4)
        m_ram = objDtLocal.Rows(0).Item(5)
        m_fat = objDtLocal.Rows(0).Item(6)
        m_sen = objDtLocal.Rows(0).Item(7)
    End Sub
End Class
