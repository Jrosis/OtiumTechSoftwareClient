Public Class ClsDespesa
    Dim m_cod As Integer
    Dim m_fun As Integer
    Dim m_des As Integer
    Dim m_dat As Date
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

    Public Property funcionario() As Integer
        Get
            Return m_fun
        End Get
        Set(ByVal value As Integer)

            m_fun = value
        End Set
    End Property
    Public Property despesa() As Integer
        Get
            Return m_des
        End Get
        Set(ByVal value As Integer)

            m_des = value
        End Set
    End Property
    Public Property data() As Date
        Get
            Return m_dat
        End Get
        Set(ByVal value As Date)

            m_dat = value
        End Set
    End Property
    Public Property valor() As String
        Get
            Return m_val
        End Get
        Set(ByVal value As String)

            m_val = value
        End Set
    End Property

    Public Sub gravar_dados(novo As Boolean)
        If novo = True Then

            sql = "Insert into tabdespesa " & _
           "(fundes " & _
           ",tipdes " & _
           ",datdes " & _
           ",valdes " & _
           ") values " & _
           "('" & m_fun & "'" & _
           ",'" & m_des & "'" & _
           ",'" & m_dat & "'" & _
           ",'" & m_val & "'" & _
           ")"
            objbanco.Executar_comando(sql)

            sql = "Select max(codDes) from tabdespesa"
            m_cod = objbanco.Buscar_ultimoRegistro(sql)
        Else
            sql = "update tabdespesa set " & _
            " fundes='" & m_fun & "'" & _
            ",tipdes='" & m_des & "'" & _
            ",datdes='" & m_dat & "'" & _
            ",valdes='" & m_val & "'" & _
            " where codDes=" & m_cod
            objbanco.Executar_comando(sql)
        End If


    End Sub
    Public Function localizarParaGrade(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "Select * from tabdespesa where coddes=" & campo
        Else
            sql = "select * from tabdespesa"
        End If
        objDtLocal = objbanco.Localizar_dados(sql)
        Return objDtLocal
    End Function
    Public Function localizarParaGradeFuncionario(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "Select * from tabdespesa where fundes=" & campo
        Else
            sql = "select * from tabdespesa"
        End If
        objDtLocal = objbanco.Localizar_dados(sql)
        Return objDtLocal
    End Function
    Public Function localizar(campo As String) As Boolean
            sql = "Select * from tabdespesa where codDes=" & campo
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
        sql = "Delete from tabdespesa where codDes=" & campo
        objbanco.Executar_comando(sql)
    End Sub

    Public Sub mostrar_dadosDaClasse()
        m_cod = objDtLocal.Rows(0).Item(0)
        m_fun = objDtLocal.Rows(0).Item(1)
        m_des = objDtLocal.Rows(0).Item(2)
        m_dat = objDtLocal.Rows(0).Item(3)
        m_val = objDtLocal.Rows(0).Item(4)
    End Sub

    Public Function localizarFunDesDat(dtaIni As Date, dtaFim As Date, cini As Integer, cfim As Integer) As DataTable
        Dim objdt As New DataTable

        Dim objda = (New OleDb.OleDbDataAdapter("StrFuncionarioDespesa", objbanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure

        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo3", OleDb.OleDbType.Integer))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo4", OleDb.OleDbType.Integer))

        objda.SelectCommand.Parameters("campo1").Value = dtaIni
        objda.SelectCommand.Parameters("campo2").Value = dtaFim
        objda.SelectCommand.Parameters("campo3").Value = cini
        objda.SelectCommand.Parameters("campo4").Value = cfim

        'objds.Tables.Clear()
        ' objda.Fill(objds)
        objda.Fill(objdt)
        'Return objds.Tables(0)
        Return objdt


    End Function
    Public Function localizarVendasPorPeriodo(dtaIni As Date, dtaFim As Date) As DataTable
        'Dim objds As New DataSet
        Dim objdt As New DataTable

        Dim objda = (New OleDb.OleDbDataAdapter("StrDespesaPorPeriodo", objbanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure

        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))

        objda.SelectCommand.Parameters("campo1").Value = dtaIni
        objda.SelectCommand.Parameters("campo2").Value = dtaFim

        'objds.Tables.Clear()
        ' objda.Fill(objds)
        objda.Fill(objdt)
        'Return objds.Tables(0)
        Return objdt

        'funcion os itens em verde com ds ou os itens ativos com dt
    End Function
    Public Function localizarDespesaTotalPeriodo(dtaIni As Date, dtaFim As Date) As Single
        'Dim objds As New DataSet
        Dim objdt As New DataTable

        Dim objda = (New OleDb.OleDbDataAdapter("StrValorDespesaTotal", objbanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure

        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))

        objda.SelectCommand.Parameters("campo1").Value = dtaIni
        objda.SelectCommand.Parameters("campo2").Value = dtaFim

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
End Class
