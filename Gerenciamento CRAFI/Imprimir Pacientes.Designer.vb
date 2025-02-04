<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_imprimir_pacientes
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_imprimir_pacientes))
        Me.PacientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gerenciamento_CRAFIDataSet = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet()
        Me.ImprimirPacientesReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PacientesTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.PacientesTableAdapter()
        Me.FillByPesquisaPacientesSemAIToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CodigoPacienteToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CodigoPacienteToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.NomeToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.NomeToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.CEPToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CEPToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.EndereçoToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.EndereçoToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.BairroToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.BairroToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.CidadeToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CidadeToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.EstadoToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.EstadoToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.PaisToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.PaisToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.PlanoSaudeToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.PlanoSaudeToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.CelularToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CelularToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.TelefoneToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.TelefoneToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.RegistroToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.RegistroToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.FillByPesquisaPacientesSemAIToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AtualizarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.TableAdapterManager = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByPesquisaPacientesSemAIToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'PacientesBindingSource
        '
        Me.PacientesBindingSource.DataMember = "Pacientes"
        Me.PacientesBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'Gerenciamento_CRAFIDataSet
        '
        Me.Gerenciamento_CRAFIDataSet.DataSetName = "Gerenciamento_CRAFIDataSet"
        Me.Gerenciamento_CRAFIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ImprimirPacientesReportViewer
        '
        Me.ImprimirPacientesReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "ImprimirPacientesDataSet"
        ReportDataSource1.Value = Me.PacientesBindingSource
        Me.ImprimirPacientesReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ImprimirPacientesReportViewer.LocalReport.ReportEmbeddedResource = "Gerenciamento_CRAFI.ImprimirPacientesReport.rdlc"
        Me.ImprimirPacientesReportViewer.Location = New System.Drawing.Point(115, 0)
        Me.ImprimirPacientesReportViewer.Name = "ImprimirPacientesReportViewer"
        Me.ImprimirPacientesReportViewer.Size = New System.Drawing.Size(657, 314)
        Me.ImprimirPacientesReportViewer.TabIndex = 0
        '
        'PacientesTableAdapter
        '
        Me.PacientesTableAdapter.ClearBeforeFill = True
        '
        'FillByPesquisaPacientesSemAIToolStrip
        '
        Me.FillByPesquisaPacientesSemAIToolStrip.Dock = System.Windows.Forms.DockStyle.Left
        Me.FillByPesquisaPacientesSemAIToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.FillByPesquisaPacientesSemAIToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CodigoPacienteToolStripLabel, Me.CodigoPacienteToolStripTextBox, Me.NomeToolStripLabel, Me.NomeToolStripTextBox, Me.CEPToolStripLabel, Me.CEPToolStripTextBox, Me.EndereçoToolStripLabel, Me.EndereçoToolStripTextBox, Me.BairroToolStripLabel, Me.BairroToolStripTextBox, Me.CidadeToolStripLabel, Me.CidadeToolStripTextBox, Me.EstadoToolStripLabel, Me.EstadoToolStripTextBox, Me.PaisToolStripLabel, Me.PaisToolStripTextBox, Me.PlanoSaudeToolStripLabel, Me.PlanoSaudeToolStripTextBox, Me.CelularToolStripLabel, Me.CelularToolStripTextBox, Me.TelefoneToolStripLabel, Me.TelefoneToolStripTextBox, Me.RegistroToolStripLabel, Me.RegistroToolStripComboBox, Me.FillByPesquisaPacientesSemAIToolStripButton, Me.ToolStripSeparator1, Me.AtualizarToolStripButton})
        Me.FillByPesquisaPacientesSemAIToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByPesquisaPacientesSemAIToolStrip.Name = "FillByPesquisaPacientesSemAIToolStrip"
        Me.FillByPesquisaPacientesSemAIToolStrip.Size = New System.Drawing.Size(115, 314)
        Me.FillByPesquisaPacientesSemAIToolStrip.TabIndex = 3
        Me.FillByPesquisaPacientesSemAIToolStrip.Text = "FillByPesquisaPacientesSemAIToolStrip"
        '
        'CodigoPacienteToolStripLabel
        '
        Me.CodigoPacienteToolStripLabel.Name = "CodigoPacienteToolStripLabel"
        Me.CodigoPacienteToolStripLabel.Size = New System.Drawing.Size(112, 15)
        Me.CodigoPacienteToolStripLabel.Text = "Código do Paciente:"
        '
        'CodigoPacienteToolStripTextBox
        '
        Me.CodigoPacienteToolStripTextBox.Name = "CodigoPacienteToolStripTextBox"
        Me.CodigoPacienteToolStripTextBox.Size = New System.Drawing.Size(110, 23)
        '
        'NomeToolStripLabel
        '
        Me.NomeToolStripLabel.Name = "NomeToolStripLabel"
        Me.NomeToolStripLabel.Size = New System.Drawing.Size(112, 15)
        Me.NomeToolStripLabel.Text = "Nome:"
        '
        'NomeToolStripTextBox
        '
        Me.NomeToolStripTextBox.Name = "NomeToolStripTextBox"
        Me.NomeToolStripTextBox.Size = New System.Drawing.Size(110, 23)
        '
        'CEPToolStripLabel
        '
        Me.CEPToolStripLabel.Name = "CEPToolStripLabel"
        Me.CEPToolStripLabel.Size = New System.Drawing.Size(112, 15)
        Me.CEPToolStripLabel.Text = "CEP:"
        '
        'CEPToolStripTextBox
        '
        Me.CEPToolStripTextBox.Name = "CEPToolStripTextBox"
        Me.CEPToolStripTextBox.Size = New System.Drawing.Size(110, 23)
        '
        'EndereçoToolStripLabel
        '
        Me.EndereçoToolStripLabel.Name = "EndereçoToolStripLabel"
        Me.EndereçoToolStripLabel.Size = New System.Drawing.Size(112, 15)
        Me.EndereçoToolStripLabel.Text = "Endereço:"
        '
        'EndereçoToolStripTextBox
        '
        Me.EndereçoToolStripTextBox.Name = "EndereçoToolStripTextBox"
        Me.EndereçoToolStripTextBox.Size = New System.Drawing.Size(110, 23)
        '
        'BairroToolStripLabel
        '
        Me.BairroToolStripLabel.Name = "BairroToolStripLabel"
        Me.BairroToolStripLabel.Size = New System.Drawing.Size(112, 15)
        Me.BairroToolStripLabel.Text = "Bairro:"
        '
        'BairroToolStripTextBox
        '
        Me.BairroToolStripTextBox.Name = "BairroToolStripTextBox"
        Me.BairroToolStripTextBox.Size = New System.Drawing.Size(110, 23)
        '
        'CidadeToolStripLabel
        '
        Me.CidadeToolStripLabel.Name = "CidadeToolStripLabel"
        Me.CidadeToolStripLabel.Size = New System.Drawing.Size(112, 15)
        Me.CidadeToolStripLabel.Text = "Cidade:"
        '
        'CidadeToolStripTextBox
        '
        Me.CidadeToolStripTextBox.Name = "CidadeToolStripTextBox"
        Me.CidadeToolStripTextBox.Size = New System.Drawing.Size(110, 23)
        '
        'EstadoToolStripLabel
        '
        Me.EstadoToolStripLabel.Name = "EstadoToolStripLabel"
        Me.EstadoToolStripLabel.Size = New System.Drawing.Size(112, 15)
        Me.EstadoToolStripLabel.Text = "Estado:"
        '
        'EstadoToolStripTextBox
        '
        Me.EstadoToolStripTextBox.Name = "EstadoToolStripTextBox"
        Me.EstadoToolStripTextBox.Size = New System.Drawing.Size(110, 23)
        '
        'PaisToolStripLabel
        '
        Me.PaisToolStripLabel.Name = "PaisToolStripLabel"
        Me.PaisToolStripLabel.Size = New System.Drawing.Size(31, 15)
        Me.PaisToolStripLabel.Text = "País:"
        '
        'PaisToolStripTextBox
        '
        Me.PaisToolStripTextBox.Name = "PaisToolStripTextBox"
        Me.PaisToolStripTextBox.Size = New System.Drawing.Size(110, 23)
        '
        'PlanoSaudeToolStripLabel
        '
        Me.PlanoSaudeToolStripLabel.Name = "PlanoSaudeToolStripLabel"
        Me.PlanoSaudeToolStripLabel.Size = New System.Drawing.Size(91, 15)
        Me.PlanoSaudeToolStripLabel.Text = "Plano de Saúde:"
        '
        'PlanoSaudeToolStripTextBox
        '
        Me.PlanoSaudeToolStripTextBox.Name = "PlanoSaudeToolStripTextBox"
        Me.PlanoSaudeToolStripTextBox.Size = New System.Drawing.Size(110, 23)
        '
        'CelularToolStripLabel
        '
        Me.CelularToolStripLabel.Name = "CelularToolStripLabel"
        Me.CelularToolStripLabel.Size = New System.Drawing.Size(47, 15)
        Me.CelularToolStripLabel.Text = "Celular:"
        '
        'CelularToolStripTextBox
        '
        Me.CelularToolStripTextBox.Name = "CelularToolStripTextBox"
        Me.CelularToolStripTextBox.Size = New System.Drawing.Size(110, 23)
        '
        'TelefoneToolStripLabel
        '
        Me.TelefoneToolStripLabel.Name = "TelefoneToolStripLabel"
        Me.TelefoneToolStripLabel.Size = New System.Drawing.Size(113, 15)
        Me.TelefoneToolStripLabel.Text = "Telefone Comercial:"
        '
        'TelefoneToolStripTextBox
        '
        Me.TelefoneToolStripTextBox.Name = "TelefoneToolStripTextBox"
        Me.TelefoneToolStripTextBox.Size = New System.Drawing.Size(110, 23)
        '
        'RegistroToolStripLabel
        '
        Me.RegistroToolStripLabel.Name = "RegistroToolStripLabel"
        Me.RegistroToolStripLabel.Size = New System.Drawing.Size(53, 15)
        Me.RegistroToolStripLabel.Text = "Registro:"
        '
        'RegistroToolStripComboBox
        '
        Me.RegistroToolStripComboBox.Items.AddRange(New Object() {"Ativo", "Inativo"})
        Me.RegistroToolStripComboBox.Name = "RegistroToolStripComboBox"
        Me.RegistroToolStripComboBox.Size = New System.Drawing.Size(110, 23)
        '
        'FillByPesquisaPacientesSemAIToolStripButton
        '
        Me.FillByPesquisaPacientesSemAIToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources._4998_32x32
        Me.FillByPesquisaPacientesSemAIToolStripButton.Name = "FillByPesquisaPacientesSemAIToolStripButton"
        Me.FillByPesquisaPacientesSemAIToolStripButton.Size = New System.Drawing.Size(62, 20)
        Me.FillByPesquisaPacientesSemAIToolStripButton.Text = "Buscar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(112, 6)
        '
        'AtualizarToolStripButton
        '
        Me.AtualizarToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources._8437_32x32
        Me.AtualizarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AtualizarToolStripButton.Name = "AtualizarToolStripButton"
        Me.AtualizarToolStripButton.Size = New System.Drawing.Size(73, 20)
        Me.AtualizarToolStripButton.Text = "Atualizar"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnamneseTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CirurgiasTableAdapter = Nothing
        Me.TableAdapterManager.ConsultasTableAdapter = Nothing
        Me.TableAdapterManager.ConveniosTableAdapter = Nothing
        Me.TableAdapterManager.CustoFixoTableAdapter = Nothing
        Me.TableAdapterManager.CustoVariavelTableAdapter = Nothing
        Me.TableAdapterManager.DespesaFixaTableAdapter = Nothing
        Me.TableAdapterManager.DespesaVariavelTableAdapter = Nothing
        Me.TableAdapterManager.EvolucaoClinicaTableAdapter = Nothing
        Me.TableAdapterManager.ExamesComplementaresTableAdapter = Nothing
        Me.TableAdapterManager.ImpostosSobreVendasTableAdapter = Nothing
        Me.TableAdapterManager.LogControleTableAdapter = Nothing
        Me.TableAdapterManager.LogEntradaTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.PacientesTableAdapter = Me.PacientesTableAdapter
        Me.TableAdapterManager.ProfissionaisTableAdapter = Nothing
        Me.TableAdapterManager.ReceitaTableAdapter = Nothing
        Me.TableAdapterManager.ServicosConveniosTableAdapter = Nothing
        Me.TableAdapterManager.ServicosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'form_imprimir_pacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 314)
        Me.Controls.Add(Me.ImprimirPacientesReportViewer)
        Me.Controls.Add(Me.FillByPesquisaPacientesSemAIToolStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_imprimir_pacientes"
        Me.ShowIcon = False
        Me.Text = "Imprimir Pacientes"
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByPesquisaPacientesSemAIToolStrip.ResumeLayout(False)
        Me.FillByPesquisaPacientesSemAIToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImprimirPacientesReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PacientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Gerenciamento_CRAFIDataSet As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet
    Friend WithEvents PacientesTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.PacientesTableAdapter
    Friend WithEvents FillByPesquisaPacientesSemAIToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents CodigoPacienteToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CodigoPacienteToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents NomeToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents NomeToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents CEPToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CEPToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents EndereçoToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents EndereçoToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BairroToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BairroToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents CidadeToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CidadeToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents EstadoToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents EstadoToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents PaisToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents PaisToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents PlanoSaudeToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents PlanoSaudeToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents CelularToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CelularToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents TelefoneToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TelefoneToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents RegistroToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents RegistroToolStripComboBox As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents FillByPesquisaPacientesSemAIToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AtualizarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents TableAdapterManager As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager
End Class
