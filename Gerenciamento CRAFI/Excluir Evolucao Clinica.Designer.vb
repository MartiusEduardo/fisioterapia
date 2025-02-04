<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_excluir_evolucao_clinica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_excluir_evolucao_clinica))
        Me.Gerenciamento_CRAFIDataSet = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet()
        Me.EvolucaoClinicaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EvolucaoClinicaTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.EvolucaoClinicaTableAdapter()
        Me.TableAdapterManager = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager()
        Me.EvolucaoClinicaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.codigoEvolucaoClinicaToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.codigoEvolucaoClinicaToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ExcluirEvolucaoClinicaToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.EvolucaoClinicaDataGridView = New System.Windows.Forms.DataGridView()
        Me.LogControleTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter()
        Me.LoginTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LoginTableAdapter()
        Me.QueriesTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.QueriesTableAdapter()
        Me.codigoEvolucaoClinica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProfissionalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Assinatura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroProntuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumRegistroProfissionalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QueixaPrincipalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HistoriaDoencaAtualDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExameFisicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CIFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TratamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssinaturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EvolucaoClinicaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EvolucaoClinicaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EvolucaoClinicaBindingNavigator.SuspendLayout()
        CType(Me.EvolucaoClinicaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Gerenciamento_CRAFIDataSet
        '
        Me.Gerenciamento_CRAFIDataSet.DataSetName = "Gerenciamento_CRAFIDataSet"
        Me.Gerenciamento_CRAFIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EvolucaoClinicaBindingSource
        '
        Me.EvolucaoClinicaBindingSource.DataMember = "EvolucaoClinica"
        Me.EvolucaoClinicaBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'EvolucaoClinicaTableAdapter
        '
        Me.EvolucaoClinicaTableAdapter.ClearBeforeFill = True
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
        'EvolucaoClinicaBindingNavigator
        '
        Me.EvolucaoClinicaBindingNavigator.AddNewItem = Nothing
        Me.EvolucaoClinicaBindingNavigator.BindingSource = Me.EvolucaoClinicaBindingSource
        Me.EvolucaoClinicaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EvolucaoClinicaBindingNavigator.DeleteItem = Nothing
        Me.EvolucaoClinicaBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.EvolucaoClinicaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.codigoEvolucaoClinicaToolStripLabel, Me.codigoEvolucaoClinicaToolStripTextBox, Me.ExcluirEvolucaoClinicaToolStripButton})
        Me.EvolucaoClinicaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EvolucaoClinicaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EvolucaoClinicaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EvolucaoClinicaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EvolucaoClinicaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EvolucaoClinicaBindingNavigator.Name = "EvolucaoClinicaBindingNavigator"
        Me.EvolucaoClinicaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EvolucaoClinicaBindingNavigator.Size = New System.Drawing.Size(718, 25)
        Me.EvolucaoClinicaBindingNavigator.TabIndex = 0
        Me.EvolucaoClinicaBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'codigoEvolucaoClinicaToolStripLabel
        '
        Me.codigoEvolucaoClinicaToolStripLabel.Name = "codigoEvolucaoClinicaToolStripLabel"
        Me.codigoEvolucaoClinicaToolStripLabel.Size = New System.Drawing.Size(155, 22)
        Me.codigoEvolucaoClinicaToolStripLabel.Text = "Código da Evolução Clínica:"
        '
        'codigoEvolucaoClinicaToolStripTextBox
        '
        Me.codigoEvolucaoClinicaToolStripTextBox.Name = "codigoEvolucaoClinicaToolStripTextBox"
        Me.codigoEvolucaoClinicaToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'ExcluirEvolucaoClinicaToolStripButton
        '
        Me.ExcluirEvolucaoClinicaToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources.Button_White_Remove
        Me.ExcluirEvolucaoClinicaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExcluirEvolucaoClinicaToolStripButton.Name = "ExcluirEvolucaoClinicaToolStripButton"
        Me.ExcluirEvolucaoClinicaToolStripButton.Size = New System.Drawing.Size(61, 22)
        Me.ExcluirEvolucaoClinicaToolStripButton.Text = "Excluir"
        '
        'EvolucaoClinicaDataGridView
        '
        Me.EvolucaoClinicaDataGridView.AllowUserToAddRows = False
        Me.EvolucaoClinicaDataGridView.AllowUserToDeleteRows = False
        Me.EvolucaoClinicaDataGridView.AutoGenerateColumns = False
        Me.EvolucaoClinicaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EvolucaoClinicaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigoEvolucaoClinica, Me.ProfissionalDataGridViewTextBoxColumn, Me.Assinatura, Me.NumeroProntuarioDataGridViewTextBoxColumn, Me.NumRegistroProfissionalDataGridViewTextBoxColumn, Me.CPFDataGridViewTextBoxColumn, Me.NomeDataGridViewTextBoxColumn, Me.DataDataGridViewTextBoxColumn, Me.QueixaPrincipalDataGridViewTextBoxColumn, Me.HistoriaDoencaAtualDataGridViewTextBoxColumn, Me.ExameFisicoDataGridViewTextBoxColumn, Me.CIFDataGridViewTextBoxColumn, Me.CIDDataGridViewTextBoxColumn, Me.TratamentoDataGridViewTextBoxColumn, Me.AssinaturaDataGridViewTextBoxColumn})
        Me.EvolucaoClinicaDataGridView.DataSource = Me.EvolucaoClinicaBindingSource
        Me.EvolucaoClinicaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EvolucaoClinicaDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.EvolucaoClinicaDataGridView.Name = "EvolucaoClinicaDataGridView"
        Me.EvolucaoClinicaDataGridView.ReadOnly = True
        Me.EvolucaoClinicaDataGridView.RowHeadersVisible = False
        Me.EvolucaoClinicaDataGridView.Size = New System.Drawing.Size(718, 289)
        Me.EvolucaoClinicaDataGridView.TabIndex = 1
        '
        'LogControleTableAdapter
        '
        Me.LogControleTableAdapter.ClearBeforeFill = True
        '
        'LoginTableAdapter
        '
        Me.LoginTableAdapter.ClearBeforeFill = True
        '
        'codigoEvolucaoClinica
        '
        Me.codigoEvolucaoClinica.DataPropertyName = "codigoEvolucaoClinica"
        Me.codigoEvolucaoClinica.HeaderText = "Código"
        Me.codigoEvolucaoClinica.Name = "codigoEvolucaoClinica"
        Me.codigoEvolucaoClinica.ReadOnly = True
        '
        'ProfissionalDataGridViewTextBoxColumn
        '
        Me.ProfissionalDataGridViewTextBoxColumn.DataPropertyName = "Profissional"
        Me.ProfissionalDataGridViewTextBoxColumn.HeaderText = "Profissional"
        Me.ProfissionalDataGridViewTextBoxColumn.Name = "ProfissionalDataGridViewTextBoxColumn"
        Me.ProfissionalDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProfissionalDataGridViewTextBoxColumn.Width = 150
        '
        'Assinatura
        '
        Me.Assinatura.DataPropertyName = "Assinatura"
        Me.Assinatura.HeaderText = "Assinatura"
        Me.Assinatura.Name = "Assinatura"
        Me.Assinatura.ReadOnly = True
        '
        'NumeroProntuarioDataGridViewTextBoxColumn
        '
        Me.NumeroProntuarioDataGridViewTextBoxColumn.DataPropertyName = "NumeroProntuario"
        Me.NumeroProntuarioDataGridViewTextBoxColumn.HeaderText = "Número do Prontuário"
        Me.NumeroProntuarioDataGridViewTextBoxColumn.Name = "NumeroProntuarioDataGridViewTextBoxColumn"
        Me.NumeroProntuarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroProntuarioDataGridViewTextBoxColumn.Width = 140
        '
        'NumRegistroProfissionalDataGridViewTextBoxColumn
        '
        Me.NumRegistroProfissionalDataGridViewTextBoxColumn.DataPropertyName = "NumRegistroProfissional"
        Me.NumRegistroProfissionalDataGridViewTextBoxColumn.HeaderText = "Registro Profissional"
        Me.NumRegistroProfissionalDataGridViewTextBoxColumn.Name = "NumRegistroProfissionalDataGridViewTextBoxColumn"
        Me.NumRegistroProfissionalDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumRegistroProfissionalDataGridViewTextBoxColumn.Width = 130
        '
        'CPFDataGridViewTextBoxColumn
        '
        Me.CPFDataGridViewTextBoxColumn.DataPropertyName = "CPF"
        Me.CPFDataGridViewTextBoxColumn.HeaderText = "CPF"
        Me.CPFDataGridViewTextBoxColumn.Name = "CPFDataGridViewTextBoxColumn"
        Me.CPFDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomeDataGridViewTextBoxColumn
        '
        Me.NomeDataGridViewTextBoxColumn.DataPropertyName = "Nome"
        Me.NomeDataGridViewTextBoxColumn.HeaderText = "Nome"
        Me.NomeDataGridViewTextBoxColumn.Name = "NomeDataGridViewTextBoxColumn"
        Me.NomeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataDataGridViewTextBoxColumn
        '
        Me.DataDataGridViewTextBoxColumn.DataPropertyName = "Data"
        Me.DataDataGridViewTextBoxColumn.HeaderText = "Data"
        Me.DataDataGridViewTextBoxColumn.Name = "DataDataGridViewTextBoxColumn"
        Me.DataDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QueixaPrincipalDataGridViewTextBoxColumn
        '
        Me.QueixaPrincipalDataGridViewTextBoxColumn.DataPropertyName = "QueixaPrincipal"
        Me.QueixaPrincipalDataGridViewTextBoxColumn.HeaderText = "QueixaPrincipal"
        Me.QueixaPrincipalDataGridViewTextBoxColumn.Name = "QueixaPrincipalDataGridViewTextBoxColumn"
        Me.QueixaPrincipalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HistoriaDoencaAtualDataGridViewTextBoxColumn
        '
        Me.HistoriaDoencaAtualDataGridViewTextBoxColumn.DataPropertyName = "HistoriaDoencaAtual"
        Me.HistoriaDoencaAtualDataGridViewTextBoxColumn.HeaderText = "HistoriaDoencaAtual"
        Me.HistoriaDoencaAtualDataGridViewTextBoxColumn.Name = "HistoriaDoencaAtualDataGridViewTextBoxColumn"
        Me.HistoriaDoencaAtualDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ExameFisicoDataGridViewTextBoxColumn
        '
        Me.ExameFisicoDataGridViewTextBoxColumn.DataPropertyName = "ExameFisico"
        Me.ExameFisicoDataGridViewTextBoxColumn.HeaderText = "ExameFisico"
        Me.ExameFisicoDataGridViewTextBoxColumn.Name = "ExameFisicoDataGridViewTextBoxColumn"
        Me.ExameFisicoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CIFDataGridViewTextBoxColumn
        '
        Me.CIFDataGridViewTextBoxColumn.DataPropertyName = "CIF"
        Me.CIFDataGridViewTextBoxColumn.HeaderText = "CIF"
        Me.CIFDataGridViewTextBoxColumn.Name = "CIFDataGridViewTextBoxColumn"
        Me.CIFDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CIDDataGridViewTextBoxColumn
        '
        Me.CIDDataGridViewTextBoxColumn.DataPropertyName = "CID"
        Me.CIDDataGridViewTextBoxColumn.HeaderText = "CID"
        Me.CIDDataGridViewTextBoxColumn.Name = "CIDDataGridViewTextBoxColumn"
        Me.CIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TratamentoDataGridViewTextBoxColumn
        '
        Me.TratamentoDataGridViewTextBoxColumn.DataPropertyName = "Tratamento"
        Me.TratamentoDataGridViewTextBoxColumn.HeaderText = "Tratamento"
        Me.TratamentoDataGridViewTextBoxColumn.Name = "TratamentoDataGridViewTextBoxColumn"
        Me.TratamentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AssinaturaDataGridViewTextBoxColumn
        '
        Me.AssinaturaDataGridViewTextBoxColumn.DataPropertyName = "Assinatura"
        Me.AssinaturaDataGridViewTextBoxColumn.HeaderText = "Assinatura"
        Me.AssinaturaDataGridViewTextBoxColumn.Name = "AssinaturaDataGridViewTextBoxColumn"
        Me.AssinaturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'form_excluir_evolucao_clinica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 314)
        Me.Controls.Add(Me.EvolucaoClinicaDataGridView)
        Me.Controls.Add(Me.EvolucaoClinicaBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_excluir_evolucao_clinica"
        Me.ShowIcon = False
        Me.Text = "Excluir Evolução Clínica"
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EvolucaoClinicaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EvolucaoClinicaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EvolucaoClinicaBindingNavigator.ResumeLayout(False)
        Me.EvolucaoClinicaBindingNavigator.PerformLayout()
        CType(Me.EvolucaoClinicaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Gerenciamento_CRAFIDataSet As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet
    Friend WithEvents EvolucaoClinicaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EvolucaoClinicaTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.EvolucaoClinicaTableAdapter
    Friend WithEvents TableAdapterManager As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EvolucaoClinicaBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EvolucaoClinicaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codigoEvolucaoClinicaToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents codigoEvolucaoClinicaToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ExcluirEvolucaoClinicaToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents LogControleTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter
    Friend WithEvents LoginTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LoginTableAdapter
    Friend WithEvents QueriesTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.QueriesTableAdapter
    Friend WithEvents codigoEvolucaoClinica As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProfissionalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Assinatura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroProntuarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumRegistroProfissionalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPFDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QueixaPrincipalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HistoriaDoencaAtualDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExameFisicoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CIFDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TratamentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AssinaturaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
