<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFin
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
        Me.LblDesfin = New System.Windows.Forms.Label()
        Me.BtnLocDes = New System.Windows.Forms.Button()
        Me.DtpDat = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GrpLoc = New System.Windows.Forms.GroupBox()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.TxtLoc = New System.Windows.Forms.TextBox()
        Me.BtnSai = New System.Windows.Forms.Button()
        Me.BtnImp = New System.Windows.Forms.Button()
        Me.BtnCan = New System.Windows.Forms.Button()
        Me.BtnLoc = New System.Windows.Forms.Button()
        Me.BtnExc = New System.Windows.Forms.Button()
        Me.BtnAlt = New System.Windows.Forms.Button()
        Me.BtnGra = New System.Windows.Forms.Button()
        Me.BtnNov = New System.Windows.Forms.Button()
        Me.Txtdesfin = New System.Windows.Forms.TextBox()
        Me.TxtCodFin = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcamfin = New System.Windows.Forms.TextBox()
        Me.BtnLocCam = New System.Windows.Forms.Button()
        Me.LblCamfin = New System.Windows.Forms.Label()
        Me.GrpLoc.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblDesfin
        '
        Me.LblDesfin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblDesfin.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDesfin.Location = New System.Drawing.Point(212, 105)
        Me.LblDesfin.Name = "LblDesfin"
        Me.LblDesfin.Size = New System.Drawing.Size(293, 29)
        Me.LblDesfin.TabIndex = 130
        Me.LblDesfin.Tag = "c"
        '
        'BtnLocDes
        '
        Me.BtnLocDes.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLocDes.Location = New System.Drawing.Point(141, 107)
        Me.BtnLocDes.Name = "BtnLocDes"
        Me.BtnLocDes.Size = New System.Drawing.Size(53, 29)
        Me.BtnLocDes.TabIndex = 129
        Me.BtnLocDes.Text = "..."
        Me.BtnLocDes.UseVisualStyleBackColor = True
        '
        'DtpDat
        '
        Me.DtpDat.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpDat.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDat.Location = New System.Drawing.Point(203, 248)
        Me.DtpDat.Name = "DtpDat"
        Me.DtpDat.Size = New System.Drawing.Size(126, 29)
        Me.DtpDat.TabIndex = 112
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(52, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 21)
        Me.Label6.TabIndex = 127
        Me.Label6.Text = "Data de Entrada"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GrpLoc
        '
        Me.GrpLoc.Controls.Add(Me.BtnOk)
        Me.GrpLoc.Controls.Add(Me.TxtLoc)
        Me.GrpLoc.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpLoc.Location = New System.Drawing.Point(43, 311)
        Me.GrpLoc.Name = "GrpLoc"
        Me.GrpLoc.Size = New System.Drawing.Size(462, 111)
        Me.GrpLoc.TabIndex = 126
        Me.GrpLoc.TabStop = False
        Me.GrpLoc.Text = "Localizar por Código ou Nome"
        '
        'BtnOk
        '
        Me.BtnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOk.Location = New System.Drawing.Point(313, 56)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(65, 29)
        Me.BtnOk.TabIndex = 15
        Me.BtnOk.Text = "&Ok"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'TxtLoc
        '
        Me.TxtLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLoc.Location = New System.Drawing.Point(20, 54)
        Me.TxtLoc.Name = "TxtLoc"
        Me.TxtLoc.Size = New System.Drawing.Size(287, 29)
        Me.TxtLoc.TabIndex = 15
        '
        'BtnSai
        '
        Me.BtnSai.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSai.Location = New System.Drawing.Point(519, 376)
        Me.BtnSai.Name = "BtnSai"
        Me.BtnSai.Size = New System.Drawing.Size(112, 46)
        Me.BtnSai.TabIndex = 125
        Me.BtnSai.Text = "Sai&r"
        Me.BtnSai.UseVisualStyleBackColor = True
        '
        'BtnImp
        '
        Me.BtnImp.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImp.Location = New System.Drawing.Point(519, 324)
        Me.BtnImp.Name = "BtnImp"
        Me.BtnImp.Size = New System.Drawing.Size(112, 46)
        Me.BtnImp.TabIndex = 124
        Me.BtnImp.Text = "&Imprimir"
        Me.BtnImp.UseVisualStyleBackColor = True
        '
        'BtnCan
        '
        Me.BtnCan.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCan.Location = New System.Drawing.Point(519, 272)
        Me.BtnCan.Name = "BtnCan"
        Me.BtnCan.Size = New System.Drawing.Size(112, 46)
        Me.BtnCan.TabIndex = 123
        Me.BtnCan.Text = "&Cancelar"
        Me.BtnCan.UseVisualStyleBackColor = True
        '
        'BtnLoc
        '
        Me.BtnLoc.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoc.Location = New System.Drawing.Point(519, 220)
        Me.BtnLoc.Name = "BtnLoc"
        Me.BtnLoc.Size = New System.Drawing.Size(112, 46)
        Me.BtnLoc.TabIndex = 122
        Me.BtnLoc.Text = "&Localizar"
        Me.BtnLoc.UseVisualStyleBackColor = True
        '
        'BtnExc
        '
        Me.BtnExc.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExc.Location = New System.Drawing.Point(519, 168)
        Me.BtnExc.Name = "BtnExc"
        Me.BtnExc.Size = New System.Drawing.Size(112, 46)
        Me.BtnExc.TabIndex = 121
        Me.BtnExc.Text = "&Excluir"
        Me.BtnExc.UseVisualStyleBackColor = True
        '
        'BtnAlt
        '
        Me.BtnAlt.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlt.Location = New System.Drawing.Point(519, 116)
        Me.BtnAlt.Name = "BtnAlt"
        Me.BtnAlt.Size = New System.Drawing.Size(112, 46)
        Me.BtnAlt.TabIndex = 120
        Me.BtnAlt.Text = "&Alterar"
        Me.BtnAlt.UseVisualStyleBackColor = True
        '
        'BtnGra
        '
        Me.BtnGra.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGra.Location = New System.Drawing.Point(519, 64)
        Me.BtnGra.Name = "BtnGra"
        Me.BtnGra.Size = New System.Drawing.Size(112, 46)
        Me.BtnGra.TabIndex = 114
        Me.BtnGra.Text = "&Gravar"
        Me.BtnGra.UseVisualStyleBackColor = True
        '
        'BtnNov
        '
        Me.BtnNov.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNov.Location = New System.Drawing.Point(519, 12)
        Me.BtnNov.Name = "BtnNov"
        Me.BtnNov.Size = New System.Drawing.Size(112, 46)
        Me.BtnNov.TabIndex = 119
        Me.BtnNov.Text = "&Novo"
        Me.BtnNov.UseVisualStyleBackColor = True
        '
        'Txtdesfin
        '
        Me.Txtdesfin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtdesfin.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtdesfin.Location = New System.Drawing.Point(50, 108)
        Me.Txtdesfin.Name = "Txtdesfin"
        Me.Txtdesfin.Size = New System.Drawing.Size(70, 29)
        Me.Txtdesfin.TabIndex = 110
        '
        'TxtCodFin
        '
        Me.TxtCodFin.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodFin.Location = New System.Drawing.Point(112, 34)
        Me.TxtCodFin.Name = "TxtCodFin"
        Me.TxtCodFin.Size = New System.Drawing.Size(77, 29)
        Me.TxtCodFin.TabIndex = 115
        Me.TxtCodFin.Tag = "x"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 21)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "Campanha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 21)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "Despesa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 21)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "Código"
        '
        'txtcamfin
        '
        Me.txtcamfin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcamfin.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcamfin.Location = New System.Drawing.Point(50, 168)
        Me.txtcamfin.Name = "txtcamfin"
        Me.txtcamfin.Size = New System.Drawing.Size(70, 29)
        Me.txtcamfin.TabIndex = 132
        '
        'BtnLocCam
        '
        Me.BtnLocCam.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLocCam.Location = New System.Drawing.Point(141, 170)
        Me.BtnLocCam.Name = "BtnLocCam"
        Me.BtnLocCam.Size = New System.Drawing.Size(53, 29)
        Me.BtnLocCam.TabIndex = 133
        Me.BtnLocCam.Text = "..."
        Me.BtnLocCam.UseVisualStyleBackColor = True
        '
        'LblCamfin
        '
        Me.LblCamfin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCamfin.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCamfin.Location = New System.Drawing.Point(212, 170)
        Me.LblCamfin.Name = "LblCamfin"
        Me.LblCamfin.Size = New System.Drawing.Size(293, 29)
        Me.LblCamfin.TabIndex = 134
        Me.LblCamfin.Tag = "c"
        '
        'FrmFin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 435)
        Me.Controls.Add(Me.LblCamfin)
        Me.Controls.Add(Me.BtnLocCam)
        Me.Controls.Add(Me.txtcamfin)
        Me.Controls.Add(Me.LblDesfin)
        Me.Controls.Add(Me.BtnLocDes)
        Me.Controls.Add(Me.DtpDat)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GrpLoc)
        Me.Controls.Add(Me.BtnSai)
        Me.Controls.Add(Me.BtnImp)
        Me.Controls.Add(Me.BtnCan)
        Me.Controls.Add(Me.BtnLoc)
        Me.Controls.Add(Me.BtnExc)
        Me.Controls.Add(Me.BtnAlt)
        Me.Controls.Add(Me.BtnGra)
        Me.Controls.Add(Me.BtnNov)
        Me.Controls.Add(Me.Txtdesfin)
        Me.Controls.Add(Me.TxtCodFin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmFin"
        Me.Text = "FrmFin"
        Me.GrpLoc.ResumeLayout(False)
        Me.GrpLoc.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblDesfin As System.Windows.Forms.Label
    Friend WithEvents BtnLocDes As System.Windows.Forms.Button
    Friend WithEvents DtpDat As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GrpLoc As System.Windows.Forms.GroupBox
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents TxtLoc As System.Windows.Forms.TextBox
    Friend WithEvents BtnSai As System.Windows.Forms.Button
    Friend WithEvents BtnImp As System.Windows.Forms.Button
    Friend WithEvents BtnCan As System.Windows.Forms.Button
    Friend WithEvents BtnLoc As System.Windows.Forms.Button
    Friend WithEvents BtnExc As System.Windows.Forms.Button
    Friend WithEvents BtnAlt As System.Windows.Forms.Button
    Friend WithEvents BtnGra As System.Windows.Forms.Button
    Friend WithEvents BtnNov As System.Windows.Forms.Button
    Friend WithEvents Txtdesfin As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodFin As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcamfin As System.Windows.Forms.TextBox
    Friend WithEvents BtnLocCam As System.Windows.Forms.Button
    Friend WithEvents LblCamfin As System.Windows.Forms.Label
End Class
