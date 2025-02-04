<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_excluir_pacientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_excluir_pacientes))
        Me.PacientesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CodigoPacienteExcluirToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CodigoPacienteExcluirToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ExcluirToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Gerenciamento_CRAFIDataSet = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet()
        Me.AnamneseTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.AnamneseTableAdapter()
        Me.EvolucaoClinicaTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.EvolucaoClinicaTableAdapter()
        Me.LogControleTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter()
        Me.PacientesTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.PacientesTableAdapter()
        Me.PacientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager()
        Me.PacientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QueriesTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.QueriesTableAdapter()
        CType(Me.PacientesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PacientesBindingNavigator.SuspendLayout()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PacientesBindingNavigator
        '
        Me.PacientesBindingNavigator.AddNewItem = Nothing
        Me.PacientesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PacientesBindingNavigator.DeleteItem = Nothing
        Me.PacientesBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.PacientesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.CodigoPacienteExcluirToolStripLabel, Me.CodigoPacienteExcluirToolStripTextBox, Me.ExcluirToolStripButton})
        Me.PacientesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PacientesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PacientesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PacientesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PacientesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PacientesBindingNavigator.Name = "PacientesBindingNavigator"
        Me.PacientesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PacientesBindingNavigator.Size = New System.Drawing.Size(747, 25)
        Me.PacientesBindingNavigator.TabIndex = 0
        Me.PacientesBindingNavigator.Text = "BindingNavigator1"
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
        'CodigoPacienteExcluirToolStripLabel
        '
        Me.CodigoPacienteExcluirToolStripLabel.Name = "CodigoPacienteExcluirToolStripLabel"
        Me.CodigoPacienteExcluirToolStripLabel.Size = New System.Drawing.Size(114, 22)
        Me.CodigoPacienteExcluirToolStripLabel.Text = "Código do Paciente:"
        '
        'CodigoPacienteExcluirToolStripTextBox
        '
        Me.CodigoPacienteExcluirToolStripTextBox.Name = "CodigoPacienteExcluirToolStripTextBox"
        Me.CodigoPacienteExcluirToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'ExcluirToolStripButton
        '
        Me.ExcluirToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources.Button_White_Remove
        Me.ExcluirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExcluirToolStripButton.Name = "ExcluirToolStripButton"
        Me.ExcluirToolStripButton.Size = New System.Drawing.Size(61, 22)
        Me.ExcluirToolStripButton.Text = "Excluir"
        '
        'Gerenciamento_CRAFIDataSet
        '
        Me.Gerenciamento_CRAFIDataSet.DataSetName = "Gerenciamento_CRAFIDataSet"
        Me.Gerenciamento_CRAFIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AnamneseTableAdapter
        '
        Me.AnamneseTableAdapter.ClearBeforeFill = True
        '
        'EvolucaoClinicaTableAdapter
        '
        Me.EvolucaoClinicaTableAdapter.ClearBeforeFill = True
        '
        'LogControleTableAdapter
        '
        Me.LogControleTableAdapter.ClearBeforeFill = True
        '
        'PacientesTableAdapter
        '
        Me.PacientesTableAdapter.ClearBeforeFill = True
        '
        'PacientesBindingSource
        '
        Me.PacientesBindingSource.DataMember = "Pacientes"
        Me.PacientesBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnamneseTableAdapter = Me.AnamneseTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CirurgiasTableAdapter = Nothing
        Me.TableAdapterManager.ConsultasTableAdapter = Nothing
        Me.TableAdapterManager.ContatosTableAdapter = Nothing
        Me.TableAdapterManager.ConveniosTableAdapter = Nothing
        Me.TableAdapterManager.CustoFixoTableAdapter = Nothing
        Me.TableAdapterManager.CustoVariavelTableAdapter = Nothing
        Me.TableAdapterManager.DespesaFixaTableAdapter = Nothing
        Me.TableAdapterManager.DespesaVariavelTableAdapter = Nothing
        Me.TableAdapterManager.EvolucaoClinicaTableAdapter = Me.EvolucaoClinicaTableAdapter
        Me.TableAdapterManager.ExamesComplementaresTableAdapter = Nothing
        Me.TableAdapterManager.ImpostosSobreVendasTableAdapter = Nothing
        Me.TableAdapterManager.LogControleTableAdapter = Me.LogControleTableAdapter
        Me.TableAdapterManager.LogEntradaTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.PacientesTableAdapter = Me.PacientesTableAdapter
        Me.TableAdapterManager.ProfissionaisTableAdapter = Nothing
        Me.TableAdapterManager.ReceitaTableAdapter = Nothing
        Me.TableAdapterManager.ServicosConveniosTableAdapter = Nothing
        Me.TableAdapterManager.ServicosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PacientesDataGridView
        '
        Me.PacientesDataGridView.AllowUserToAddRows = False
        Me.PacientesDataGridView.AllowUserToDeleteRows = False
        Me.PacientesDataGridView.AutoGenerateColumns = False
        Me.PacientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PacientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn28, Me.DataGridViewCheckBoxColumn3, Me.DataGridViewCheckBoxColumn4, Me.DataGridViewCheckBoxColumn5, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34})
        Me.PacientesDataGridView.DataSource = Me.PacientesBindingSource
        Me.PacientesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PacientesDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.PacientesDataGridView.Name = "PacientesDataGridView"
        Me.PacientesDataGridView.ReadOnly = True
        Me.PacientesDataGridView.RowHeadersVisible = False
        Me.PacientesDataGridView.Size = New System.Drawing.Size(747, 252)
        Me.PacientesDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CodigoPaciente"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CodigoPaciente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CPF"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CPF"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Nome"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DataNascimento"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DataNascimento"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "SexoM"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "SexoM"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "SexoF"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "SexoF"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Etnia"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Etnia"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "EstadoCivil"
        Me.DataGridViewTextBoxColumn6.HeaderText = "EstadoCivil"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "TelefoneComercial"
        Me.DataGridViewTextBoxColumn7.HeaderText = "TelefoneComercial"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Celular"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Celular"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ProfissaoActual"
        Me.DataGridViewTextBoxColumn9.HeaderText = "ProfissaoActual"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ProfissaoAnterior"
        Me.DataGridViewTextBoxColumn10.HeaderText = "ProfissaoAnterior"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "LocalTrabalho"
        Me.DataGridViewTextBoxColumn11.HeaderText = "LocalTrabalho"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Naturalidade"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Naturalidade"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Nacionalidade"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Nacionalidade"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "TelefoneResidencial"
        Me.DataGridViewTextBoxColumn14.HeaderText = "TelefoneResidencial"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "CEP"
        Me.DataGridViewTextBoxColumn15.HeaderText = "CEP"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Endereco"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Endereco"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Bairro"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Bairro"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Cidade"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Cidade"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Estado"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Pais"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Pais"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "TelefoneResidencialAnterior"
        Me.DataGridViewTextBoxColumn21.HeaderText = "TelefoneResidencialAnterior"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "CEPAnterior"
        Me.DataGridViewTextBoxColumn22.HeaderText = "CEPAnterior"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "EnderecoAnterior"
        Me.DataGridViewTextBoxColumn23.HeaderText = "EnderecoAnterior"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "BairroAnterior"
        Me.DataGridViewTextBoxColumn24.HeaderText = "BairroAnterior"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "CidadeAnterior"
        Me.DataGridViewTextBoxColumn25.HeaderText = "CidadeAnterior"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "EstadoAnterior"
        Me.DataGridViewTextBoxColumn26.HeaderText = "EstadoAnterior"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "PaisAnterior"
        Me.DataGridViewTextBoxColumn28.HeaderText = "PaisAnterior"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "RegistroAtivo"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "RegistroAtivo"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        Me.DataGridViewCheckBoxColumn3.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn4
        '
        Me.DataGridViewCheckBoxColumn4.DataPropertyName = "RegistroInativo"
        Me.DataGridViewCheckBoxColumn4.HeaderText = "RegistroInativo"
        Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
        Me.DataGridViewCheckBoxColumn4.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn5
        '
        Me.DataGridViewCheckBoxColumn5.DataPropertyName = "StatusAlta"
        Me.DataGridViewCheckBoxColumn5.HeaderText = "StatusAlta"
        Me.DataGridViewCheckBoxColumn5.Name = "DataGridViewCheckBoxColumn5"
        Me.DataGridViewCheckBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "StatusAltaTipo"
        Me.DataGridViewTextBoxColumn29.HeaderText = "StatusAltaTipo"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "PlanosSaude"
        Me.DataGridViewTextBoxColumn30.HeaderText = "PlanosSaude"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "ReferenciadoPor"
        Me.DataGridViewTextBoxColumn31.HeaderText = "ReferenciadoPor"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.ReadOnly = True
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn32.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "Transporte"
        Me.DataGridViewTextBoxColumn33.HeaderText = "Transporte"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.ReadOnly = True
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "Observacao"
        Me.DataGridViewTextBoxColumn34.HeaderText = "Observacao"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.ReadOnly = True
        '
        'form_excluir_pacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 277)
        Me.Controls.Add(Me.PacientesDataGridView)
        Me.Controls.Add(Me.PacientesBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_excluir_pacientes"
        Me.ShowIcon = False
        Me.Text = "Excluir Pacientes"
        CType(Me.PacientesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PacientesBindingNavigator.ResumeLayout(False)
        Me.PacientesBindingNavigator.PerformLayout()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PacientesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CodigoPacienteExcluirToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CodigoPacienteExcluirToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ExcluirToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnamneseTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.AnamneseTableAdapter
    Friend WithEvents EvolucaoClinicaTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.EvolucaoClinicaTableAdapter
    Friend WithEvents LogControleTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter
    Friend WithEvents PacientesTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.PacientesTableAdapter
    Friend WithEvents Gerenciamento_CRAFIDataSet As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet
    Friend WithEvents PacientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PacientesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn4 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn5 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QueriesTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.QueriesTableAdapter
End Class
