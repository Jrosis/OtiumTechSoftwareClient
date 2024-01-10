Public Class ClsCampanha
    Dim m_cod As Integer
    Dim m_cli As Integer
    Dim m_des As String
    Dim m_ini As Date
    Dim m_fin As Date
    Dim m_nom As String
    Dim m_val As Single

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

    Public Property cliente() As Integer
        Get
            Return m_cli
        End Get
        Set(ByVal value As Integer)

            m_cli = value
        End Set
    End Property
    Public Property descricao() As String
        Get
            Return m_des
        End Get
        Set(ByVal value As String)

            m_des = value
        End Set
    End Property
    Public Property inicio() As Date
        Get
            Return m_ini
        End Get
        Set(ByVal value As Date)

            m_ini = value
        End Set
    End Property
    Public Property final() As Date
        Get
            Return m_fin
        End Get
        Set(ByVal value As Date)

            m_fin = value
        End Set
    End Property
    Public Property nome() As String
        Get
            Return m_nom
        End Get
        Set(ByVal value As String)

            m_nom = value
        End Set
    End Property
    Public Property valor() As Single
        Get
            Return m_val
        End Get
        Set(ByVal value As Single)

            m_val = value
        End Set
    End Property

    Public Sub gravar_dados(novo As Boolean)
        If novo = True Then

            sql = "Insert into tabcampanha " & _
           "(clicam " & _
           ",descam " & _
           ",inicam " & _
           ",fincam " & _
           ",nomcam " & _
           ",valcam " & _
           ") values " & _
           "('" & m_cli & "'" & _
           ",'" & m_des & "'" & _
           ",'" & m_ini & "'" & _
           ",'" & m_fin & "'" & _
           ",'" & m_nom & "'" & _
           ",'" & m_val & "'" & _
           ")"
            objbanco.Executar_comando(sql)

            sql = "Select max(codcam) from tabcampanha"
            m_cod = objbanco.Buscar_ultimoRegistro(sql)
        Else
            sql = "update tabcampanha set " & _
            " clicam='" & m_cli & "'" & _
            ",descam='" & m_des & "'" & _
            ",inicam='" & m_ini & "'" & _
            ",fincam='" & m_fin & "'" & _
            ",nomcam='" & m_nom & "'" & _
            ",valcam='" & m_val & "'" & _
            " where codcam=" & m_cod
            objbanco.Executar_comando(sql)
        End If


    End Sub
    Public Function localizarParaGrade(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "Select * from tabcampanha where clicam=" & campo
        Else
            sql = "Select * from tabcampanha where nomcam like '" & campo & "%' order by nomcam"
        End If
        objDtLocal = objbanco.Localizar_dados(sql)
        Return objDtLocal
    End Function
    Public Function localizar(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "Select * from tabcampanha where codcam=" & campo
        Else
            sql = "Select * from tabcampanha where nomcam='" & campo & "'"
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
    Public Function localizarcampanhaperiodo(dtaIni As Date, dtaFim As Date, cli As Integer) As DataTable
        Dim objdt As New DataTable

        Dim objda = (New OleDb.OleDbDataAdapter("StrCampanhaPorPeriodo", objbanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure

        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo3", OleDb.OleDbType.Integer))

        objda.SelectCommand.Parameters("campo1").Value = dtaIni
        objda.SelectCommand.Parameters("campo2").Value = dtaFim
        objda.SelectCommand.Parameters("campo3").Value = cli

        'objds.Tables.Clear()
        ' objda.Fill(objds)
        objda.Fill(objdt)
        'Return objds.Tables(0)
        Return objdt


    End Function

    Public Function localizarCampanhaTotalPeriodo(dtaIni As Date, dtaFim As Date, cli As Integer) As Single
        'Dim objds As New DataSet
        Dim objdt As New DataTable

        Dim objda = (New OleDb.OleDbDataAdapter("StrGanhoCampanha", objbanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure

        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo3", OleDb.OleDbType.Integer))

        objda.SelectCommand.Parameters("campo1").Value = dtaIni
        objda.SelectCommand.Parameters("campo2").Value = dtaFim
        objda.SelectCommand.Parameters("campo3").Value = cli

        'objds.Tables.Clear()
        ' objda.Fill(objds)
        objda.Fill(objdt)
        'Return objds.Tables(0)
        If IsDBNull(objdt.Rows(0).Item(0)) Then
            Return 0
        Else
            Return objdt.Rows(0).Item(0)
        End If




        'funcion os itens em verde com ds ou os itens ativos com dt
    End Function

    Public Sub excluir(campo As Integer)
        sql = "Delete from tabcampanha where codcam=" & campo
        objbanco.Executar_comando(sql)
    End Sub

    Public Sub mostrar_dadosDaClasse()
        m_cod = objDtLocal.Rows(0).Item(0)
        m_cli = objDtLocal.Rows(0).Item(1)
        m_des = objDtLocal.Rows(0).Item(2)
        m_ini = objDtLocal.Rows(0).Item(3)
        m_fin = objDtLocal.Rows(0).Item(4)
        m_nom = objDtLocal.Rows(0).Item(5)
        m_val = objDtLocal.Rows(0).Item(6)
    End Sub
End Class
