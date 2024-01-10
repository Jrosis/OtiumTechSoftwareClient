Public Class FrmInicialFuncionario

  
    Private Sub FrmInicialFuncionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        FrmCadCli.Show()
        FrmCadCli.MdiParent = Me
    End Sub

    Private Sub FuncionárioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuncionárioToolStripMenuItem.Click
        FrmCadFun.Show()
        FrmCadFun.MdiParent = Me
    End Sub

    Private Sub ProdutoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutoToolStripMenuItem.Click
        FrmCam.Show()
        FrmCam.MdiParent = Me
    End Sub

    Private Sub DespesaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DespesaToolStripMenuItem.Click
        FrmDes.Show()
        FrmDes.MdiParent = Me
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        If MessageBox.Show("Deseja sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            FrmLogin.Show()
            Me.Close()
        End If
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        FrmConCli.Show()
        FrmConCli.MdiParent = Me
    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem1.Click
        Dim rpt As New CrpCliente
        rpt.Refresh()
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Sli TechWorld"
        rpt.SummaryInfo.ReportComments = "Relatório de Cliente"
        FrmImp.ShowDialog()
    End Sub

    Private Sub CampanhasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CampanhasToolStripMenuItem.Click
        Dim rpt As New CrpDespesa
        rpt.Refresh()
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Sli TechWorld"
        rpt.SummaryInfo.ReportComments = "Relatório de Campanhas"
        FrmImp.ShowDialog()
    End Sub

    Private Sub ClientesToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem2.Click
        Dim rpt As New CrpClienteAvancado
        rpt.Refresh()
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Sli TechWorld"
        rpt.SummaryInfo.ReportComments = "Relatório de Cliente Avançado"
        FrmImp.ShowDialog()
    End Sub

    Private Sub ArquivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArquivoToolStripMenuItem.Click

    End Sub
End Class