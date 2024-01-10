
Public Class ClsFuncionario
    Dim m_cod As Integer
    Dim m_nom As String
    Dim m_nas As Date
    Dim m_cep As String
    Dim m_end As String
    Dim m_bai As String
    Dim m_est As String
    Dim m_cid As String
    Dim m_civ As String
    Dim m_fil As String
    Dim m_pen As String
    Dim m_crt As String
    Dim m_ele As String
    Dim m_sal As Single
    Dim m_sen As String
    Dim m_ati As Boolean
    Dim m_adm As Date
    Dim m_ban As String
    Dim m_age As String
    Dim m_con As String
    Dim m_codcon As String


    Dim sql As String
    Dim objBanco As New ClsBanco
    Dim objDtLocal As New DataTable

    Public Property Codigo() As Integer
        Get
            Return m_cod
        End Get
        Set(ByVal value As Integer)
            m_cod = value
        End Set
    End Property
    Public Property Nome() As String
        Get
            Return m_nom
        End Get
        Set(ByVal value As String)

            m_nom = value
        End Set
    End Property
    Public Property Nascimento() As Date
        Get
            Return m_nas
        End Get
        Set(ByVal value As Date)

            m_nas = value
        End Set
    End Property
    Public Property Cep() As String
        Get
            Return m_cep
        End Get
        Set(ByVal value As String)

            m_cep = value
        End Set
    End Property
    Public Property Endereco() As String
        Get
            Return m_end
        End Get
        Set(ByVal value As String)

            m_end = value
        End Set
    End Property
    Public Property bairro() As String
        Get
            Return m_bai
        End Get
        Set(ByVal value As String)

            m_bai = value
        End Set
    End Property
    Public Property estado() As String
        Get
            Return m_est
        End Get
        Set(ByVal value As String)

            m_est = value
        End Set
    End Property
    Public Property Cidade() As String
        Get
            Return m_cid
        End Get
        Set(ByVal value As String)

            m_cid = value
        End Set
    End Property
    Public Property Civil() As String
        Get
            Return m_civ
        End Get
        Set(ByVal value As String)

            m_civ = value
        End Set
    End Property
    Public Property Filiacao() As String
        Get
            Return m_fil
        End Get
        Set(ByVal value As String)

            m_fil = value
        End Set
    End Property
    Public Property Pendentes() As String
        Get
            Return m_pen
        End Get
        Set(ByVal value As String)

            m_pen = value
        End Set
    End Property
    Public Property Carteira() As String
        Get
            Return m_crt
        End Get
        Set(ByVal value As String)

            m_crt = value
        End Set
    End Property
    Public Property Eleitor() As String
        Get
            Return m_ele
        End Get
        Set(ByVal value As String)

            m_ele = value
        End Set
    End Property
    Public Property Salario() As Single
        Get
            Return m_sal
        End Get
        Set(ByVal value As Single)

            m_sal = value
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
    Public Property Ativo() As Boolean
        Get
            Return m_ati
        End Get
        Set(ByVal value As Boolean)

            m_ati = value
        End Set
    End Property
    Public Property Admissao() As Date
        Get
            Return m_adm
        End Get
        Set(ByVal value As Date)

            m_adm = value
        End Set
    End Property
    Public Property Banco() As String
        Get
            Return m_ban
        End Get
        Set(ByVal value As String)

            m_ban = value
        End Set
    End Property
    Public Property Agencia() As String
        Get
            Return m_age
        End Get
        Set(ByVal value As String)

            m_age = value
        End Set
    End Property
    Public Property Conta() As String
        Get
            Return m_con
        End Get
        Set(ByVal value As String)

            m_con = value
        End Set
    End Property
    Public Property CodigoConta() As String
        Get
            Return m_codcon
        End Get
        Set(ByVal value As String)

            m_codcon = value
        End Set
    End Property
    Public Sub gravar_dados(novo As Boolean)
        If novo = True Then
            sql = "Insert into TabFuncionario " & _
            "(nomFun " & _
            ",nasFun " & _
            ",cepFun " & _
            ",endFun " & _
            ",baiFun " & _
            ",estFun " & _
            ",cidFun " & _
            ",civFun " & _
            ",filFun " & _
            ",penFun " & _
            ",crtFun " & _
            ",eleFun " & _
            ",salFun " & _
            ",senFun " & _
            ",atiFun " & _
            ",admfun " & _
            ",banFun " & _
            ",ageFun " & _
            ",confun " & _
            ",codconfun " & _
            ") values " & _
            "('" & m_nom & "'" & _
            ",'" & m_nas & "'" & _
            ",'" & m_cep & "'" & _
            ",'" & m_end & "'" & _
            ",'" & m_bai & "'" & _
            ",'" & m_est & "'" & _
            ",'" & m_cid & "'" & _
            ",'" & m_civ & "'" & _
            ",'" & m_fil & "'" & _
            ",'" & m_pen & "'" & _
            ",'" & m_crt & "'" & _
            ",'" & m_ele & "'" & _
            ",'" & m_sal & "'" & _
            ",'" & m_sen & "'" & _
            "," & m_ati & "" & _
            ",'" & m_adm & "'" & _
            ",'" & m_ban & "'" & _
            ",'" & m_age & "'" & _
            ",'" & m_con & "'" & _
            ",'" & m_codcon & "'" & _
           ")"
            objBanco.Executar_comando(sql)

            sql = "Select max(codfun) from tabfuncionario"
            m_cod = objBanco.Buscar_ultimoRegistro(sql)

        Else
            sql = "update TabFuncionario set " & _
            " nomFun='" & m_nom & "'" & _
            ",nasFun='" & m_nas & "'" & _
            ",cepFun='" & m_cep & "'" & _
            ",endFun='" & m_end & "'" & _
            ",baiFun='" & m_bai & "'" & _
            ",estFun='" & m_est & "'" & _
            ",cidFun='" & m_cid & "'" & _
            ",civFun='" & m_civ & "'" & _
            ",filFun='" & m_fil & "'" & _
            ",penFun='" & m_pen & "'" & _
            ",crtFun='" & m_crt & "'" & _
            ",eleFun='" & m_ele & "'" & _
            ",salFun='" & m_sal & "'" & _
            ",senFun='" & m_sen & "'" & _
            ",atifun=" & m_ati & "" & _
            ",admFun='" & m_adm & "'" & _
            ",banFun='" & m_ban & "'" & _
            ",ageFun='" & m_age & "'" & _
            ",conFun='" & m_con & "'" & _
            ",codconFun='" & m_codcon & "'" & _
            " where codFun=" & m_cod
            objBanco.Executar_comando(sql)
        End If

    End Sub

    Public Function localizar_Todos() As DataTable

        sql = "Select codfun, nomfun from tabfuncionario where atifun=true order by nomfun"

        objDtLocal = objBanco.Localizar_dados(sql)
        Return objDtLocal
    End Function

    Public Function localizarParaGrade(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "Select * from tabfuncionario where codfun=" & campo
        Else
            sql = "Select * from tabfuncionario where nomfun like '" & campo & "%' order by nomfun"
        End If
        objDtLocal = objbanco.Localizar_dados(sql)
        Return objDtLocal
    End Function
    Public Function localizar(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "Select * from tabfuncionario where codfun=" & campo
        Else
            sql = "Select * from tabfuncionario where nomfun='" & campo & "'"
        End If
        objDtLocal = objBanco.Localizar_dados(sql)
        If objDtLocal.Rows.Count = 0 Then
            MessageBox.Show("Registro " & campo & " não encontrado")
            Return False
        Else
            mostrar_dadosDaClasse()
            Return True
        End If
    End Function

    Public Sub mostrar_dadosDaClasse()
        m_cod = objDtLocal.Rows(0).Item(0)
        m_nom = objDtLocal.Rows(0).Item(1)
        m_nas = objDtLocal.Rows(0).Item(2)
        m_cep = objDtLocal.Rows(0).Item(3)
        m_end = objDtLocal.Rows(0).Item(4)
        m_bai = objDtLocal.Rows(0).Item(5)
        m_est = objDtLocal.Rows(0).Item(6)
        m_cid = objDtLocal.Rows(0).Item(7)
        m_civ = objDtLocal.Rows(0).Item(8)
        m_fil = objDtLocal.Rows(0).Item(9)
        m_pen = objDtLocal.Rows(0).Item(10)
        m_crt = objDtLocal.Rows(0).Item(11)
        m_ele = objDtLocal.Rows(0).Item(12)
        m_sal = objDtLocal.Rows(0).Item(13)
        m_sen = objDtLocal.Rows(0).Item(14)
        m_ati = objDtLocal.Rows(0).Item(15)
        m_adm = objDtLocal.Rows(0).Item(16)
        m_ban = objDtLocal.Rows(0).Item(17)
        m_age = objDtLocal.Rows(0).Item(18)
        m_con = objDtLocal.Rows(0).Item(19)
        m_codcon = objDtLocal.Rows(0).Item(20)
    End Sub

    Public Sub excluir(campo As Integer)
        sql = "Delete from tabfuncionario where codfun=" & campo
        objBanco.Executar_comando(sql)
    End Sub
End Class
