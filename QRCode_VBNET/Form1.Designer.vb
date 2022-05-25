<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.picImagem = New System.Windows.Forms.PictureBox()
        Me.txtTexto = New System.Windows.Forms.TextBox()
        Me.btnGerarQRCode = New System.Windows.Forms.Button()
        Me.btnSalvarQRCode = New System.Windows.Forms.Button()
        Me.btnCarregarQRCode = New System.Windows.Forms.Button()
        Me.btnLerQRCode = New System.Windows.Forms.Button()
        CType(Me.picImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picImagem
        '
        Me.picImagem.Location = New System.Drawing.Point(32, 12)
        Me.picImagem.Name = "picImagem"
        Me.picImagem.Size = New System.Drawing.Size(167, 134)
        Me.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picImagem.TabIndex = 0
        Me.picImagem.TabStop = False
        '
        'txtTexto
        '
        Me.txtTexto.Location = New System.Drawing.Point(32, 152)
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(167, 23)
        Me.txtTexto.TabIndex = 1
        '
        'btnGerarQRCode
        '
        Me.btnGerarQRCode.Location = New System.Drawing.Point(32, 181)
        Me.btnGerarQRCode.Name = "btnGerarQRCode"
        Me.btnGerarQRCode.Size = New System.Drawing.Size(168, 44)
        Me.btnGerarQRCode.TabIndex = 2
        Me.btnGerarQRCode.Text = "Gerar QRCode"
        Me.btnGerarQRCode.UseVisualStyleBackColor = True
        '
        'btnSalvarQRCode
        '
        Me.btnSalvarQRCode.Location = New System.Drawing.Point(33, 231)
        Me.btnSalvarQRCode.Name = "btnSalvarQRCode"
        Me.btnSalvarQRCode.Size = New System.Drawing.Size(167, 44)
        Me.btnSalvarQRCode.TabIndex = 3
        Me.btnSalvarQRCode.Text = "Salvar QRCode"
        Me.btnSalvarQRCode.UseVisualStyleBackColor = True
        '
        'btnCarregarQRCode
        '
        Me.btnCarregarQRCode.Location = New System.Drawing.Point(33, 281)
        Me.btnCarregarQRCode.Name = "btnCarregarQRCode"
        Me.btnCarregarQRCode.Size = New System.Drawing.Size(166, 47)
        Me.btnCarregarQRCode.TabIndex = 4
        Me.btnCarregarQRCode.Text = "Carregar QRCode"
        Me.btnCarregarQRCode.UseVisualStyleBackColor = True
        '
        'btnLerQRCode
        '
        Me.btnLerQRCode.Location = New System.Drawing.Point(34, 334)
        Me.btnLerQRCode.Name = "btnLerQRCode"
        Me.btnLerQRCode.Size = New System.Drawing.Size(165, 42)
        Me.btnLerQRCode.TabIndex = 5
        Me.btnLerQRCode.Text = "Ler QRCode"
        Me.btnLerQRCode.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(231, 384)
        Me.Controls.Add(Me.btnLerQRCode)
        Me.Controls.Add(Me.btnCarregarQRCode)
        Me.Controls.Add(Me.btnSalvarQRCode)
        Me.Controls.Add(Me.btnGerarQRCode)
        Me.Controls.Add(Me.txtTexto)
        Me.Controls.Add(Me.picImagem)
        Me.Name = "Form1"
        Me.Text = "Gerador de QRCode"
        CType(Me.picImagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picImagem As PictureBox
    Friend WithEvents txtTexto As TextBox
    Friend WithEvents btnGerarQRCode As Button
    Friend WithEvents btnSalvarQRCode As Button
    Friend WithEvents btnCarregarQRCode As Button
    Friend WithEvents btnLerQRCode As Button
End Class
