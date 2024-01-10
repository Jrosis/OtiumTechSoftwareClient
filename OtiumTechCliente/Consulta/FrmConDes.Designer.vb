<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConDes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConDes))
        Me.lblQTD = New System.Windows.Forms.Label()
        Me.DgdGrade = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdesfim = New System.Windows.Forms.TextBox()
        Me.Dtpini = New System.Windows.Forms.DateTimePicker()
        Me.DtpFim = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGas = New System.Windows.Forms.TextBox()
        Me.BtnLoc = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdesini = New System.Windows.Forms.TextBox()
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblQTD
        '
        Me.lblQTD.AutoSize = True
        Me.lblQTD.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQTD.Location = New System.Drawing.Point(266, 81)
        Me.lblQTD.Name = "lblQTD"
        Me.lblQTD.Size = New System.Drawing.Size(132, 21)
        Me.lblQTD.TabIndex = 91
        Me.lblQTD.Text = "Qtd. de Despesas:"
        '
        'DgdGrade
        '
        Me.DgdGrade.AllowUserToAddRows = False
        Me.DgdGrade.AllowUserToDeleteRows = False
        Me.DgdGrade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgdGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdGrade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DgdGrade.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgdGrade.Location = New System.Drawing.Point(17, 153)
        Me.DgdGrade.Name = "DgdGrade"
        Me.DgdGrade.ReadOnly = True
        Me.DgdGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdGrade.Size = New System.Drawing.Size(925, 296)
        Me.DgdGrade.TabIndex = 90
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "coddes"
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 65
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "nomdes"
        Me.Column2.HeaderText = "Tipo Despesa"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 90
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "nomfun"
        Me.Column3.HeaderText = "Funcionário Despesa"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 121
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "datDes"
        Me.Column4.HeaderText = "Data da Despesa"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 105
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "ValDes"
        Me.Column5.HeaderText = "Valor da Despesa"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 106
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 21)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Digite o Código da Despesa"
        '
        'txtdesfim
        '
        Me.txtdesfim.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesfim.Location = New System.Drawing.Point(134, 78)
        Me.txtdesfim.Name = "txtdesfim"
        Me.txtdesfim.Size = New System.Drawing.Size(107, 29)
        Me.txtdesfim.TabIndex = 95
        Me.txtdesfim.Tag = "x"
        '
        'Dtpini
        '
        Me.Dtpini.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtpini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtpini.Location = New System.Drawing.Point(17, 118)
        Me.Dtpini.Name = "Dtpini"
        Me.Dtpini.Size = New System.Drawing.Size(126, 29)
        Me.Dtpini.TabIndex = 96
        '
        'DtpFim
        '
        Me.DtpFim.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFim.Location = New System.Drawing.Point(149, 118)
        Me.DtpFim.Name = "DtpFim"
        Me.DtpFim.Size = New System.Drawing.Size(126, 29)
        Me.DtpFim.TabIndex = 97
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(266, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 21)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Gastos:"
        '
        'txtGas
        '
        Me.txtGas.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGas.Location = New System.Drawing.Point(332, 43)
        Me.txtGas.Name = "txtGas"
        Me.txtGas.Size = New System.Drawing.Size(103, 29)
        Me.txtGas.TabIndex = 99
        Me.txtGas.Tag = "x"
        '
        'BtnLoc
        '
        Me.BtnLoc.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoc.Location = New System.Drawing.Point(281, 118)
        Me.BtnLoc.Name = "BtnLoc"
        Me.BtnLoc.Size = New System.Drawing.Size(85, 27)
        Me.BtnLoc.TabIndex = 100
        Me.BtnLoc.Text = "Localizar"
        Me.BtnLoc.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 21)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "Despesa Inicial:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 21)
        Me.Label4.TabIndex = 102
        Me.Label4.Text = "Despesa Final:"
        '
        'txtdesini
        '
        Me.txtdesini.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesini.Location = New System.Drawing.Point(134, 43)
        Me.txtdesini.Name = "txtdesini"
        Me.txtdesini.Size = New System.Drawing.Size(107, 29)
        Me.txtdesini.TabIndex = 103
        Me.txtdesini.Tag = "x"
        '
        'FrmConDes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 723)
        Me.Controls.Add(Me.txtdesini)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnLoc)
        Me.Controls.Add(Me.txtGas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DtpFim)
        Me.Controls.Add(Me.Dtpini)
        Me.Controls.Add(Me.txtdesfim)
        Me.Controls.Add(Me.lblQTD)
        Me.Controls.Add(Me.DgdGrade)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmConDes"
        Me.Text = "Consulta de despesas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblQTD As System.Windows.Forms.Label
    Friend WithEvents DgdGrade As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtdesfim As System.Windows.Forms.TextBox
    Friend WithEvents Dtpini As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpFim As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtGas As System.Windows.Forms.TextBox
    Friend WithEvents BtnLoc As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtdesini As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
