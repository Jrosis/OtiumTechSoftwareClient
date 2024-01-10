Public Class FrmInicial
    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        FrmCadCli.Show()
        FrmCadCli.MdiParent = Me
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        If MessageBox.Show("Deseja sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            FrmLogin.Show()
            Me.Close()
        End If
    End Sub

    Private Sub FuncionárioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuncionárioToolStripMenuItem.Click
        FrmCadFun.Show()
        FrmCadFun.MdiParent = Me
    End Sub



    


    Private Sub CadastroDeEntradaDeProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub VendasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmFin.Show()
        FrmFin.MdiParent = Me
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        FrmConCli.Show()
        FrmConCli.MdiParent = Me
    End Sub

    Private Sub ProdutoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProdutoToolStripMenuItem1.Click
        FrmConDes.Show()
        FrmConDes.MdiParent = Me
    End Sub
    
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub ProdutoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutoToolStripMenuItem.Click
        FrmCam.Show()
        FrmCam.MdiParent = Me
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmCadDes.Show()
        FrmCadDes.MdiParent = Me
    End Sub

    Private Sub FerramentaToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DespesaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DespesaToolStripMenuItem.Click
        FrmDes.Show()
        FrmDes.MdiParent = Me
    End Sub

    Private Sub ClienteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem1.Click

    End Sub

    Private Sub LogToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem1.Click
        Dim rpt As New CrpCliente
        rpt.Refresh()
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Sli TechWorld"
        rpt.SummaryInfo.ReportComments = "Relatório de Cliente"
        FrmImp.ShowDialog()
    End Sub

    Private Sub FuncionarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuncionarioToolStripMenuItem.Click
        Dim rpt As New Crpfuncionarios
        rpt.Refresh()
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Sli TechWorld"
        rpt.SummaryInfo.ReportComments = "Relatório de Funcionários"
        FrmImp.ShowDialog()
    End Sub

    Private Sub DespesaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DespesaToolStripMenuItem1.Click
        Dim rpt As New CrpDespesa
        rpt.Refresh()
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Sli TechWorld"
        rpt.SummaryInfo.ReportComments = "Relatório de Despesas"
        FrmImp.ShowDialog()
    End Sub

    Private Sub CampanhasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CampanhasToolStripMenuItem.Click
        Dim rpt As New CrpCampanha
        rpt.Refresh()
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Sli TechWorld"
        rpt.SummaryInfo.ReportComments = "Relatório de Campanhas"
        FrmImp.ShowDialog()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmLogin.Show()
        FrmLogin.MdiParent = Me
    End Sub

    Private Sub FrmInicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FuncionárioToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FuncionárioToolStripMenuItem1.Click
        FrmConFun.Show()
        FrmConFun.MdiParent = Me
    End Sub

    Private Sub CampanhaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CampanhaToolStripMenuItem1.Click
        FrmConCam.Show()
        FrmConCam.MdiParent = Me
    End Sub

    Private Sub ClientesToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem2.Click
        Dim rpt As New CrpClienteAvancado
        rpt.Refresh()
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Sli TechWorld"
        rpt.SummaryInfo.ReportComments = "Relatório de Clientes Avançado"
        FrmImp.ShowDialog()
    End Sub

    Private Sub CampanhaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CampanhaToolStripMenuItem.Click
        Dim rpt As New CrpDespesaAvancado
        rpt.Refresh()
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Sli TechWorld"
        rpt.SummaryInfo.ReportComments = "Relatório de Despesa Avançado"
        FrmImp.ShowDialog()
    End Sub
End Class