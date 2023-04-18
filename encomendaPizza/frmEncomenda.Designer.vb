<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEncomenda
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cbxPizza = New System.Windows.Forms.ComboBox()
        Me.chkAzeitona = New System.Windows.Forms.CheckBox()
        Me.chkQueijo = New System.Windows.Forms.CheckBox()
        Me.chkPimentos = New System.Windows.Forms.CheckBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.lblDesconto = New System.Windows.Forms.Label()
        Me.rdbSim = New System.Windows.Forms.RadioButton()
        Me.rdbNao = New System.Windows.Forms.RadioButton()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.lblPrecos = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbxPizza
        '
        Me.cbxPizza.FormattingEnabled = True
        Me.cbxPizza.Items.AddRange(New Object() {"Margarida", "Napolitana", "Anchova"})
        Me.cbxPizza.Location = New System.Drawing.Point(51, 39)
        Me.cbxPizza.Name = "cbxPizza"
        Me.cbxPizza.Size = New System.Drawing.Size(121, 23)
        Me.cbxPizza.TabIndex = 0
        '
        'chkAzeitona
        '
        Me.chkAzeitona.AutoSize = True
        Me.chkAzeitona.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.chkAzeitona.Location = New System.Drawing.Point(243, 39)
        Me.chkAzeitona.Name = "chkAzeitona"
        Me.chkAzeitona.Size = New System.Drawing.Size(73, 19)
        Me.chkAzeitona.TabIndex = 1
        Me.chkAzeitona.Text = "Azeitona"
        Me.chkAzeitona.UseVisualStyleBackColor = True
        '
        'chkQueijo
        '
        Me.chkQueijo.AutoSize = True
        Me.chkQueijo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.chkQueijo.Location = New System.Drawing.Point(243, 65)
        Me.chkQueijo.Name = "chkQueijo"
        Me.chkQueijo.Size = New System.Drawing.Size(90, 19)
        Me.chkQueijo.TabIndex = 2
        Me.chkQueijo.Text = "Queijo extra"
        Me.chkQueijo.UseVisualStyleBackColor = True
        '
        'chkPimentos
        '
        Me.chkPimentos.AutoSize = True
        Me.chkPimentos.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.chkPimentos.Location = New System.Drawing.Point(243, 90)
        Me.chkPimentos.Name = "chkPimentos"
        Me.chkPimentos.Size = New System.Drawing.Size(76, 19)
        Me.chkPimentos.TabIndex = 3
        Me.chkPimentos.Text = "Pimentos"
        Me.chkPimentos.UseVisualStyleBackColor = True
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblQuantidade.Location = New System.Drawing.Point(42, 134)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(69, 15)
        Me.lblQuantidade.TabIndex = 4
        Me.lblQuantidade.Text = "Quantidade"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Location = New System.Drawing.Point(117, 131)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(67, 23)
        Me.txtQuantidade.TabIndex = 5
        '
        'lblDesconto
        '
        Me.lblDesconto.AutoSize = True
        Me.lblDesconto.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDesconto.Location = New System.Drawing.Point(42, 211)
        Me.lblDesconto.Name = "lblDesconto"
        Me.lblDesconto.Size = New System.Drawing.Size(87, 15)
        Me.lblDesconto.TabIndex = 6
        Me.lblDesconto.Text = "Tem desconto?"
        '
        'rdbSim
        '
        Me.rdbSim.AutoSize = True
        Me.rdbSim.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rdbSim.Location = New System.Drawing.Point(42, 245)
        Me.rdbSim.Name = "rdbSim"
        Me.rdbSim.Size = New System.Drawing.Size(46, 19)
        Me.rdbSim.TabIndex = 7
        Me.rdbSim.TabStop = True
        Me.rdbSim.Text = "Sim"
        Me.rdbSim.UseVisualStyleBackColor = True
        '
        'rdbNao
        '
        Me.rdbNao.AutoSize = True
        Me.rdbNao.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rdbNao.Location = New System.Drawing.Point(93, 245)
        Me.rdbNao.Name = "rdbNao"
        Me.rdbNao.Size = New System.Drawing.Size(47, 19)
        Me.rdbNao.TabIndex = 8
        Me.rdbNao.TabStop = True
        Me.rdbNao.Text = "Não"
        Me.rdbNao.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCalcular.Location = New System.Drawing.Point(42, 316)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 9
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(145, 316)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(64, 23)
        Me.txtValor.TabIndex = 10
        '
        'lblPrecos
        '
        Me.lblPrecos.AutoSize = True
        Me.lblPrecos.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblPrecos.Location = New System.Drawing.Point(42, 385)
        Me.lblPrecos.Name = "lblPrecos"
        Me.lblPrecos.Size = New System.Drawing.Size(255, 75)
        Me.lblPrecos.TabIndex = 11
        Me.lblPrecos.Text = "PREÇOS:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Margarida, 6€; Napolitana, 7€; Anchova, 8€;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Cada extra: 1€; Pimen" &
    "tos, 2€;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Desconto: 10%;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'frmEncomenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 544)
        Me.Controls.Add(Me.lblPrecos)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.rdbNao)
        Me.Controls.Add(Me.rdbSim)
        Me.Controls.Add(Me.lblDesconto)
        Me.Controls.Add(Me.txtQuantidade)
        Me.Controls.Add(Me.lblQuantidade)
        Me.Controls.Add(Me.chkPimentos)
        Me.Controls.Add(Me.chkQueijo)
        Me.Controls.Add(Me.chkAzeitona)
        Me.Controls.Add(Me.cbxPizza)
        Me.Name = "frmEncomenda"
        Me.Text = "Encomenda"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxPizza As ComboBox
    Friend WithEvents chkAzeitona As CheckBox
    Friend WithEvents chkQueijo As CheckBox
    Friend WithEvents chkPimentos As CheckBox
    Friend WithEvents lblQuantidade As Label
    Friend WithEvents txtQuantidade As TextBox
    Friend WithEvents lblDesconto As Label
    Friend WithEvents rdbSim As RadioButton
    Friend WithEvents rdbNao As RadioButton
    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtValor As TextBox
    Friend WithEvents lblPrecos As Label
End Class
