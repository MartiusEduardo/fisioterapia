<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_imprimir_evolucoes_clinicas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_imprimir_evolucoes_clinicas))
        Me.EvolucaoClinicaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gerenciamento_CRAFIDataSet = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet()
        Me.ImprimirECReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.EvolucaoClinicaTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.EvolucaoClinicaTableAdapter()
        Me.PesquisarECBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.NumEvolClinicaToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.NumEvolClinicaToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.NumRegsitroProfissionalToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.NumRegistroProfissioanlToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ProfissionalToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ProfissionalToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.CodigoPacienteToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CodigoPacienteToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.CPFToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CPFToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.NomeToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.NomeToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.DataToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.DataToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.QueixaPrincipalToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.QueixaPrincipalToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.HDAToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.HDAToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ExameFisicoToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ExameFisicoToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.CIFToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CIFToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.CIDToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CIDToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.TratamentoToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.TratamentoToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.AssinaturaToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.AssinaturaToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.BuscarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AtualizarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.TableAdapterManager = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager()
        CType(Me.EvolucaoClinicaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PesquisarECBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PesquisarECBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'EvolucaoClinicaBindingSource
        '
        Me.EvolucaoClinicaBindingSource.DataMember = "EvolucaoClinica"
        Me.EvolucaoClinicaBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'Gerenciamento_CRAFIDataSet
        '
        Me.Gerenciamento_CRAFIDataSet.DataSetName = "Gerenciamento_CRAFIDataSet"
        Me.Gerenciamento_CRAFIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ImprimirECReportViewer
        '
        Me.ImprimirECReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "ImprimirEvolucoesClinicasDataSet"
        ReportDataSource1.Value = Me.EvolucaoClinicaBindingSource
        Me.ImprimirECReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ImprimirECReportViewer.LocalReport.ReportEmbeddedResource = "Gerenciamento_CRAFI.ImprimirEvolucoesClinicasReport.rdlc"
        Me.ImprimirECReportViewer.Location = New System.Drawing.Point(151, 0)
        Me.ImprimirECReportViewer.Name = "ImprimirECReportViewer"
        Me.ImprimirECReportViewer.Size = New System.Drawing.Size(567, 314)
        Me.ImprimirECReportViewer.TabIndex = 0
        '
        'EvolucaoClinicaTableAdapter
        '
        Me.EvolucaoClinicaTableAdapter.ClearBeforeFill = True
        '
        'PesquisarECBindingNavigator
        '
        Me.PesquisarECBindingNavigator.AddNewItem = Nothing
        Me.PesquisarECBindingNavigator.CountItem = Nothing
        Me.PesquisarECBindingNavigator.DeleteItem = Nothing
        Me.PesquisarECBindingNavigator.Dock = System.Windows.Forms.DockStyle.Left
        Me.PesquisarECBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.PesquisarECBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NumEvolClinicaToolStripLabel, Me.NumEvolClinicaToolStripTextBox, Me.NumRegsitroProfissionalToolStripLabel, Me.NumRegistroProfissioanlToolStripTextBox, Me.ProfissionalToolStripLabel, Me.ProfissionalToolStripTextBox, Me.CodigoPacienteToolStripLabel, Me.CodigoPacienteToolStripTextBox, Me.CPFToolStripLabel, Me.CPFToolStripTextBox, Me.NomeToolStripLabel, Me.NomeToolStripTextBox, Me.DataToolStripLabel, Me.DataToolStripTextBox, Me.QueixaPrincipalToolStripLabel, Me.QueixaPrincipalToolStripTextBox, Me.HDAToolStripLabel, Me.HDAToolStripTextBox, Me.ExameFisicoToolStripLabel, Me.ExameFisicoToolStripTextBox, Me.CIFToolStripLabel, Me.CIFToolStripTextBox, Me.CIDToolStripLabel, Me.CIDToolStripTextBox, Me.TratamentoToolStripLabel, Me.TratamentoToolStripTextBox, Me.AssinaturaToolStripLabel, Me.AssinaturaToolStripTextBox, Me.BuscarToolStripButton, Me.ToolStripSeparator1, Me.AtualizarToolStripButton})
        Me.PesquisarECBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PesquisarECBindingNavigator.MoveFirstItem = Nothing
        Me.PesquisarECBindingNavigator.MoveLastItem = Nothing
        Me.PesquisarECBindingNavigator.MoveNextItem = Nothing
        Me.PesquisarECBindingNavigator.MovePreviousItem = Nothing
        Me.PesquisarECBindingNavigator.Name = "PesquisarECBindingNavigator"
        Me.PesquisarECBindingNavigator.PositionItem = Nothing
        Me.PesquisarECBindingNavigator.Size = New System.Drawing.Size(151, 314)
        Me.PesquisarECBindingNavigator.TabIndex = 3
        Me.PesquisarECBindingNavigator.Text = "BindingNavigator1"
        '
        'NumEvolClinicaToolStripLabel
        '
        Me.NumEvolClinicaToolStripLabel.Name = "NumEvolClinicaToolStripLabel"
        Me.NumEvolClinicaToolStripLabel.Size = New System.Drawing.Size(148, 15)
        Me.NumEvolClinicaToolStripLabel.Text = "Num. Evolução Clínica:"
        '
        'NumEvolClinicaToolStripTextBox
        '
        Me.NumEvolClinicaToolStripTextBox.Name = "NumEvolClinicaToolStripTextBox"
        Me.NumEvolClinicaToolStripTextBox.Size = New System.Drawing.Size(146, 23)
        '
        'NumRegsitroProfissionalToolStripLabel
        '
        Me.NumRegsitroProfissionalToolStripLabel.Name = "NumRegsitroProfissionalToolStripLabel"
        Me.NumRegsitroProfissionalToolStripLabel.Size = New System.Drawing.Size(148, 15)
        Me.NumRegsitroProfissionalToolStripLabel.Text = "Num. Registro Profissional:"
        '
        'NumRegistroProfissioanlToolStripTextBox
        '
        Me.NumRegistroProfissioanlToolStripTextBox.Name = "NumRegistroProfissioanlToolStripTextBox"
        Me.NumRegistroProfissioanlToolStripTextBox.Size = New System.Drawing.Size(146, 23)
        '
        'ProfissionalToolStripLabel
        '
        Me.ProfissionalToolStripLabel.Name = "ProfissionalToolStripLabel"
        Me.ProfissionalToolStripLabel.Size = New System.Drawing.Size(148, 15)
        Me.ProfissionalToolStripLabel.Text = "Profissional:"
        '
        'ProfissionalToolStripTextBox
        '
        Me.ProfissionalToolStripTextBox.Name = "ProfissionalToolStripTextBox"
        Me.ProfissionalToolStripTextBox.Size = New System.Drawing.Size(146, 23)
        '
        'CodigoPacienteToolStripLabel
        '
        Me.CodigoPacienteToolStripLabel.Name = "CodigoPacienteToolStripLabel"
        Me.CodigoPacienteToolStripLabel.Size = New System.Drawing.Size(148, 15)
        Me.CodigoPacienteToolStripLabel.Text = "Código Paciente:"
        '
        'CodigoPacienteToolStripTextBox
        '
        Me.CodigoPacienteToolStripTextBox.Name = "CodigoPacienteToolStripTextBox"
        Me.CodigoPacienteToolStripTextBox.Size = New System.Drawing.Size(146, 23)
        '
        'CPFToolStripLabel
        '
        Me.CPFToolStripLabel.Name = "CPFToolStripLabel"
        Me.CPFToolStripLabel.Size = New System.Drawing.Size(148, 15)
        Me.CPFToolStripLabel.Text = "CPF:"
        '
        'CPFToolStripTextBox
        '
        Me.CPFToolStripTextBox.Name = "CPFToolStripTextBox"
        Me.CPFToolStripTextBox.Size = New System.Drawing.Size(146, 23)
        '
        'NomeToolStripLabel
        '
        Me.NomeToolStripLabel.Name = "NomeToolStripLabel"
        Me.NomeToolStripLabel.Size = New System.Drawing.Size(148, 15)
        Me.NomeToolStripLabel.Text = "Nome:"
        '
        'NomeToolStripTextBox
        '
        Me.NomeToolStripTextBox.Name = "NomeToolStripTextBox"
        Me.NomeToolStripTextBox.Size = New System.Drawing.Size(146, 23)
        '
        'DataToolStripLabel
        '
        Me.DataToolStripLabel.Name = "DataToolStripLabel"
        Me.DataToolStripLabel.Size = New System.Drawing.Size(148, 15)
        Me.DataToolStripLabel.Text = "Data:"
        '
        'DataToolStripTextBox
        '
        Me.DataToolStripTextBox.Name = "DataToolStripTextBox"
        Me.DataToolStripTextBox.Size = New System.Drawing.Size(146, 23)
        '
        'QueixaPrincipalToolStripLabel
        '
        Me.QueixaPrincipalToolStripLabel.Name = "QueixaPrincipalToolStripLabel"
        Me.QueixaPrincipalToolStripLabel.Size = New System.Drawing.Size(95, 15)
        Me.QueixaPrincipalToolStripLabel.Text = "Queixa Principal:"
        '
        'QueixaPrincipalToolStripTextBox
        '
        Me.QueixaPrincipalToolStripTextBox.Name = "QueixaPrincipalToolStripTextBox"
        Me.QueixaPrincipalToolStripTextBox.Size = New System.Drawing.Size(146, 23)
        '
        'HDAToolStripLabel
        '
        Me.HDAToolStripLabel.Name = "HDAToolStripLabel"
        Me.HDAToolStripLabel.Size = New System.Drawing.Size(141, 15)
        Me.HDAToolStripLabel.Text = "História da Doença Atual:"
        '
        'HDAToolStripTextBox
        '
        Me.HDAToolStripTextBox.Name = "HDAToolStripTextBox"
        Me.HDAToolStripTextBox.Size = New System.Drawing.Size(146, 23)
        '
        'ExameFisicoToolStripLabel
        '
        Me.ExameFisicoToolStripLabel.Name = "ExameFisicoToolStripLabel"
        Me.ExameFisicoToolStripLabel.Size = New System.Drawing.Size(77, 15)
        Me.ExameFisicoToolStripLabel.Text = "Exame Físico:"
        '
        'ExameFisicoToolStripTextBox
        '
        Me.ExameFisicoToolStripTextBox.Name = "ExameFisicoToolStripTextBox"
        Me.ExameFisicoToolStripTextBox.Size = New System.Drawing.Size(146, 23)
        '
        'CIFToolStripLabel
        '
        Me.CIFToolStripLabel.Name = "CIFToolStripLabel"
        Me.CIFToolStripLabel.Size = New System.Drawing.Size(27, 15)
        Me.CIFToolStripLabel.Text = "CIF:"
        '
        'CIFToolStripTextBox
        '
        Me.CIFToolStripTextBox.Name = "CIFToolStripTextBox"
        Me.CIFToolStripTextBox.Size = New System.Drawing.Size(146, 23)
        '
        'CIDToolStripLabel
        '
        Me.CIDToolStripLabel.Name = "CIDToolStripLabel"
        Me.CIDToolStripLabel.Size = New System.Drawing.Size(29, 15)
        Me.CIDToolStripLabel.Text = "CID:"
        '
        'CIDToolStripTextBox
        '
        Me.CIDToolStripTextBox.Name = "CIDToolStripTextBox"
        Me.CIDToolStripTextBox.Size = New System.Drawing.Size(146, 23)
        '
        'TratamentoToolStripLabel
        '
        Me.TratamentoToolStripLabel.Name = "TratamentoToolStripLabel"
        Me.TratamentoToolStripLabel.Size = New System.Drawing.Size(72, 15)
        Me.TratamentoToolStripLabel.Text = "Tratamento:"
        '
        'TratamentoToolStripTextBox
        '
        Me.TratamentoToolStripTextBox.Name = "TratamentoToolStripTextBox"
        Me.TratamentoToolStripTextBox.Size = New System.Drawing.Size(146, 23)
        '
        'AssinaturaToolStripLabel
        '
        Me.AssinaturaToolStripLabel.Name = "AssinaturaToolStripLabel"
        Me.AssinaturaToolStripLabel.Size = New System.Drawing.Size(65, 15)
        Me.AssinaturaToolStripLabel.Text = "Assinatura:"
        '
        'AssinaturaToolStripTextBox
        '
        Me.AssinaturaToolStripTextBox.Name = "AssinaturaToolStripTextBox"
        Me.AssinaturaToolStripTextBox.Size = New System.Drawing.Size(146, 23)
        '
        'BuscarToolStripButton
        '
        Me.BuscarToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources._4998_32x32
        Me.BuscarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BuscarToolStripButton.Name = "BuscarToolStripButton"
        Me.BuscarToolStripButton.Size = New System.Drawing.Size(62, 20)
        Me.BuscarToolStripButton.Text = "Buscar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(148, 6)
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
        Me.TableAdapterManager.EvolucaoClinicaTableAdapter = Me.EvolucaoClinicaTableAdapter
        Me.TableAdapterManager.ExamesComplementaresTableAdapter = Nothing
        Me.TableAdapterManager.ImpostosSobreVendasTableAdapter = Nothing
        Me.TableAdapterManager.LogControleTableAdapter = Nothing
        Me.TableAdapterManager.LogEntradaTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.PacientesTableAdapter = Nothing
        Me.TableAdapterManager.ProfissionaisTableAdapter = Nothing
        Me.TableAdapterManager.ReceitaTableAdapter = Nothing
        Me.TableAdapterManager.ServicosConveniosTableAdapter = Nothing
        Me.TableAdapterManager.ServicosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'form_imprimir_evolucoes_clinicas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 314)
        Me.Controls.Add(Me.ImprimirECReportViewer)
        Me.Controls.Add(Me.PesquisarECBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_imprimir_evolucoes_clinicas"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir Evoluções Clínicas"
        CType(Me.EvolucaoClinicaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PesquisarECBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PesquisarECBindingNavigator.ResumeLayout(False)
        Me.PesquisarECBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImprimirECReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents EvolucaoClinicaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Gerenciamento_CRAFIDataSet As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet
    Friend WithEvents EvolucaoClinicaTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.EvolucaoClinicaTableAdapter
    Friend WithEvents PesquisarECBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents NumEvolClinicaToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents NumEvolClinicaToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents NumRegsitroProfissionalToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents NumRegistroProfissioanlToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ProfissionalToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ProfissionalToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents CodigoPacienteToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CodigoPacienteToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents CPFToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CPFToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents NomeToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents NomeToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents DataToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DataToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents QueixaPrincipalToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents QueixaPrincipalToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents HDAToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents HDAToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ExameFisicoToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ExameFisicoToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents CIFToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CIFToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents CIDToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CIDToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents TratamentoToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TratamentoToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents AssinaturaToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents AssinaturaToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BuscarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AtualizarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents TableAdapterManager As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager
End Class
