<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConCam
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConCam))
        Me.BtnLoc = New System.Windows.Forms.Button()
        Me.txtcli = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DtpFim = New System.Windows.Forms.DateTimePicker()
        Me.Dtpini = New System.Windows.Forms.DateTimePicker()
        Me.txtGan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblQTD = New System.Windows.Forms.Label()
        Me.DgdGrade = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnLoc
        '
        Me.BtnLoc.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoc.Location = New System.Drawing.Point(276, 121)
        Me.BtnLoc.Name = "BtnLoc"
        Me.BtnLoc.Size = New System.Drawing.Size(85, 30)
        Me.BtnLoc.TabIndex = 129
        Me.BtnLoc.Text = "Localizar"
        Me.BtnLoc.UseVisualStyleBackColor = True
        '
        'txtcli
        '
        Me.txtcli.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcli.Location = New System.Drawing.Point(75, 73)
        Me.txtcli.Name = "txtcli"
        Me.txtcli.Size = New System.Drawing.Size(107, 29)
        Me.txtcli.TabIndex = 128
        Me.txtcli.Tag = "x"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 21)
        Me.Label3.TabIndex = 127
        Me.Label3.Text = "Cliente:"
        '
        'DtpFim
        '
        Me.DtpFim.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFim.Location = New System.Drawing.Point(144, 121)
        Me.DtpFim.Name = "DtpFim"
        Me.DtpFim.Size = New System.Drawing.Size(126, 29)
        Me.DtpFim.TabIndex = 126
        '
        'Dtpini
        '
        Me.Dtpini.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtpini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtpini.Location = New System.Drawing.Point(12, 121)
        Me.Dtpini.Name = "Dtpini"
        Me.Dtpini.Size = New System.Drawing.Size(126, 29)
        Me.Dtpini.TabIndex = 125
        '
        'txtGan
        '
        Me.txtGan.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGan.Location = New System.Drawing.Point(361, 21)
        Me.txtGan.Name = "txtGan"
        Me.txtGan.Size = New System.Drawing.Size(108, 29)
        Me.txtGan.TabIndex = 124
        Me.txtGan.Tag = "x"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(295, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 21)
        Me.Label2.TabIndex = 123
        Me.Label2.Text = "Ganhos:"
        '
        'lblQTD
        '
        Me.lblQTD.AutoSize = True
        Me.lblQTD.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQTD.Location = New System.Drawing.Point(295, 66)
        Me.lblQTD.Name = "lblQTD"
        Me.lblQTD.Size = New System.Drawing.Size(122, 21)
        Me.lblQTD.TabIndex = 122
        Me.lblQTD.Text = "Qtd. de Clientes:"
        '
        'DgdGrade
        '
        Me.DgdGrade.AllowUserToAddRows = False
        Me.DgdGrade.AllowUserToDeleteRows = False
        Me.DgdGrade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgdGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdGrade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DgdGrade.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgdGrade.Location = New System.Drawing.Point(12, 176)
        Me.DgdGrade.Name = "DgdGrade"
        Me.DgdGrade.ReadOnly = True
        Me.DgdGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdGrade.Size = New System.Drawing.Size(1124, 268)
        Me.DgdGrade.TabIndex = 121
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "codcam"
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 65
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "CliCam"
        Me.Column2.HeaderText = "Cliente Campanha"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 108
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Descam"
        Me.Column3.HeaderText = "Descrição Campanha"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 123
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "iniCam"
        Me.Column4.HeaderText = "Início Campanha"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 104
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "FinCam"
        Me.Column5.HeaderText = "Final Campanha"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 99
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "Nomcam"
        Me.Column6.HeaderText = "Nome Campanha"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 105
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "Valcam"
        Me.Column7.HeaderText = "Valor Campanha"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 101
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 21)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "Digite o Código do Cliente "
        '
        'FrmConCam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1214, 655)
        Me.Controls.Add(Me.BtnLoc)
        Me.Controls.Add(Me.txtcli)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DtpFim)
        Me.Controls.Add(Me.Dtpini)
        Me.Controls.Add(Me.txtGan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblQTD)
        Me.Controls.Add(Me.DgdGrade)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmConCam"
        Me.Text = "Consulta de campanhas"
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnLoc As System.Windows.Forms.Button
    Friend WithEvents txtcli As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DtpFim As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dtpini As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtGan As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblQTD As System.Windows.Forms.Label
    Friend WithEvents DgdGrade As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
