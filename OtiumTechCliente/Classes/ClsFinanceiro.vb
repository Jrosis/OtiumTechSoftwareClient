Public Class ClsFinanceiro

    Dim m_cod As Integer
    Dim m_des As String
    Dim m_cam As String
    Dim m_dat As Date

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
    Public Property campanha() As String
        Get
            Return m_cam
        End Get
        Set(ByVal value As String)

            m_cam = value
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

    Public Sub gravar_dados(novo As Boolean)
        If novo = True Then

            sql = "Insert into tabfinanceiro " & _
           "(coddesfin " & _
           ",codcamfin " & _
           ",datfin " & _
           ") values " & _
           "('" & m_des & "'" & _
           ",'" & m_cam & "'" & _
           ",'" & m_dat & "'" & _
           ")"
            objbanco.Executar_comando(Sql)

            Sql = "Select max(codfin) from tabfinanceiro"
            m_cod = objbanco.Buscar_ultimoRegistro(Sql)
        Else
            sql = "update tabfinanceiro set " & _
            " coddesfin='" & m_des & "'" & _
            ",codcamfin='" & m_cam & "'" & _
            ",datfin='" & m_dat & "'" & _
            " where codfin=" & m_cod
            objbanco.Executar_comando(Sql)
        End If


    End Sub
    Public Function localizarParaGrade(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "Select * from tabfinanceiro where codfin=" & campo
        Else
            sql = "Select * from tabfinanceiro where nomcam like '" & campo & "%' order by nomcam"
        End If
        objDtLocal = objbanco.Localizar_dados(sql)
        Return objDtLocal
    End Function
    Public Function localizar(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "Select * from tabfinanceiro where codfin=" & campo
        Else
            sql = "Select * from tabfinanceiro where nomcam='" & campo & "'"
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
        sql = "Delete from tabfinanceiro where codfin=" & campo
        objbanco.Executar_comando(sql)
    End Sub

    Public Sub mostrar_dadosDaClasse()
        m_cod = objDtLocal.Rows(0).Item(0)
        m_des = objDtLocal.Rows(0).Item(1)
        m_cam = objDtLocal.Rows(0).Item(2)
        m_dat = objDtLocal.Rows(0).Item(3)
    End Sub
End Class
