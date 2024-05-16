<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTelaInicial
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTelaInicial))
        Me.lblAmarelo = New System.Windows.Forms.Label()
        Me.lblVerde = New System.Windows.Forms.Label()
        Me.lblVermelho = New System.Windows.Forms.Label()
        Me.lblAzul = New System.Windows.Forms.Label()
        Me.lblPreto = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAmarelo
        '
        Me.lblAmarelo.AutoSize = True
        Me.lblAmarelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmarelo.ForeColor = System.Drawing.Color.Yellow
        Me.lblAmarelo.Location = New System.Drawing.Point(551, 110)
        Me.lblAmarelo.Name = "lblAmarelo"
        Me.lblAmarelo.Size = New System.Drawing.Size(91, 25)
        Me.lblAmarelo.TabIndex = 0
        Me.lblAmarelo.Text = "Amarelo"
        '
        'lblVerde
        '
        Me.lblVerde.AutoSize = True
        Me.lblVerde.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVerde.ForeColor = System.Drawing.Color.Green
        Me.lblVerde.Location = New System.Drawing.Point(551, 173)
        Me.lblVerde.Name = "lblVerde"
        Me.lblVerde.Size = New System.Drawing.Size(69, 25)
        Me.lblVerde.TabIndex = 1
        Me.lblVerde.Text = "Verde"
        '
        'lblVermelho
        '
        Me.lblVermelho.AutoSize = True
        Me.lblVermelho.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVermelho.ForeColor = System.Drawing.Color.Red
        Me.lblVermelho.Location = New System.Drawing.Point(551, 228)
        Me.lblVermelho.Name = "lblVermelho"
        Me.lblVermelho.Size = New System.Drawing.Size(103, 25)
        Me.lblVermelho.TabIndex = 2
        Me.lblVermelho.Text = "Vermelho"
        '
        'lblAzul
        '
        Me.lblAzul.AutoSize = True
        Me.lblAzul.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAzul.ForeColor = System.Drawing.Color.Blue
        Me.lblAzul.Location = New System.Drawing.Point(551, 294)
        Me.lblAzul.Name = "lblAzul"
        Me.lblAzul.Size = New System.Drawing.Size(54, 25)
        Me.lblAzul.TabIndex = 3
        Me.lblAzul.Text = "Azul"
        '
        'lblPreto
        '
        Me.lblPreto.AutoSize = True
        Me.lblPreto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreto.ForeColor = System.Drawing.Color.Black
        Me.lblPreto.Location = New System.Drawing.Point(551, 56)
        Me.lblPreto.Name = "lblPreto"
        Me.lblPreto.Size = New System.Drawing.Size(63, 25)
        Me.lblPreto.TabIndex = 4
        Me.lblPreto.Text = "Preto"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Black
        Me.lblTitulo.Location = New System.Drawing.Point(188, 195)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(71, 25)
        Me.lblTitulo.TabIndex = 5
        Me.lblTitulo.Text = "Título"
        '
        'frmTelaInicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lblPreto)
        Me.Controls.Add(Me.lblAzul)
        Me.Controls.Add(Me.lblVermelho)
        Me.Controls.Add(Me.lblVerde)
        Me.Controls.Add(Me.lblAmarelo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmTelaInicial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tela Inicial"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAmarelo As Label
    Friend WithEvents lblVerde As Label
    Friend WithEvents lblVermelho As Label
    Friend WithEvents lblAzul As Label
    Friend WithEvents lblPreto As Label
    Friend WithEvents lblTitulo As Label
End Class
