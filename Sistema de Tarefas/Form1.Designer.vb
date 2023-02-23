<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgAgendadas = New System.Windows.Forms.DataGridView()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnConcluir = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgConcluidas = New System.Windows.Forms.DataGridView()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.btnEditar = New System.Windows.Forms.Button()
        CType(Me.dgAgendadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgConcluidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgAgendadas
        '
        Me.dgAgendadas.AllowUserToAddRows = False
        Me.dgAgendadas.AllowUserToDeleteRows = False
        Me.dgAgendadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAgendadas.Location = New System.Drawing.Point(12, 45)
        Me.dgAgendadas.MultiSelect = False
        Me.dgAgendadas.Name = "dgAgendadas"
        Me.dgAgendadas.ReadOnly = True
        Me.dgAgendadas.RowHeadersVisible = False
        Me.dgAgendadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgAgendadas.Size = New System.Drawing.Size(304, 150)
        Me.dgAgendadas.TabIndex = 0
        '
        'btnNovo
        '
        Me.btnNovo.BackColor = System.Drawing.Color.Honeydew
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovo.Location = New System.Drawing.Point(46, 223)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(132, 42)
        Me.btnNovo.TabIndex = 1
        Me.btnNovo.Text = "Nova"
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'btnConcluir
        '
        Me.btnConcluir.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnConcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConcluir.Location = New System.Drawing.Point(322, 223)
        Me.btnConcluir.Name = "btnConcluir"
        Me.btnConcluir.Size = New System.Drawing.Size(132, 42)
        Me.btnConcluir.TabIndex = 2
        Me.btnConcluir.Text = "Concluir"
        Me.btnConcluir.UseVisualStyleBackColor = False
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.IndianRed
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.Location = New System.Drawing.Point(460, 223)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(132, 42)
        Me.btnExcluir.TabIndex = 3
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Agendadas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(317, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Concluídas"
        '
        'dgConcluidas
        '
        Me.dgConcluidas.AllowUserToAddRows = False
        Me.dgConcluidas.AllowUserToDeleteRows = False
        Me.dgConcluidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgConcluidas.Location = New System.Drawing.Point(322, 45)
        Me.dgConcluidas.MultiSelect = False
        Me.dgConcluidas.Name = "dgConcluidas"
        Me.dgConcluidas.ReadOnly = True
        Me.dgConcluidas.RowHeadersVisible = False
        Me.dgConcluidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgConcluidas.Size = New System.Drawing.Size(304, 150)
        Me.dgConcluidas.TabIndex = 6
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(574, 12)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(51, 20)
        Me.txtId.TabIndex = 9
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Location = New System.Drawing.Point(184, 223)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(132, 42)
        Me.btnEditar.TabIndex = 8
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(637, 290)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgConcluidas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnConcluir)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.dgAgendadas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Tarefas"
        CType(Me.dgAgendadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgConcluidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgAgendadas As DataGridView
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnConcluir As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgConcluidas As DataGridView
    Friend WithEvents txtId As TextBox
    Friend WithEvents btnEditar As Button
End Class
