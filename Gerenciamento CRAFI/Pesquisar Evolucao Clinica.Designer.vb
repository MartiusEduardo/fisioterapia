<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_pesquisar_evolucao_clinica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_pesquisar_evolucao_clinica))
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
        Me.AtualizarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImprimirToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.EvolucaoClinicaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EvolucaoClinicaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EvolucaoClinicaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EvolucaoClinicaBindingNavigator.SuspendLayout()
        CType(Me.EvolucaoClinicaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PesquisarECBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PesquisarECBindingNavigator.SuspendLayout()
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
        Me.EvolucaoClinicaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.AtualizarToolStripButton, Me.ToolStripSeparator1, Me.ImprimirToolStripButton})
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
        'AtualizarToolStripButton
        '
        Me.AtualizarToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources._8437_32x32
        Me.AtualizarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AtualizarToolStripButton.Name = "AtualizarToolStripButton"
        Me.AtualizarToolStripButton.Size = New System.Drawing.Size(73, 22)
        Me.AtualizarToolStripButton.Text = "Atualizar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ImprimirToolStripButton
        '
        Me.ImprimirToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources._9854_32x32
        Me.ImprimirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImprimirToolStripButton.Name = "ImprimirToolStripButton"
        Me.ImprimirToolStripButton.Size = New System.Drawing.Size(73, 22)
        Me.ImprimirToolStripButton.Text = "Imprimir"
        '
        'EvolucaoClinicaDataGridView
        '
        Me.EvolucaoClinicaDataGridView.AllowUserToAddRows = False
        Me.EvolucaoClinicaDataGridView.AllowUserToDeleteRows = False
        Me.EvolucaoClinicaDataGridView.AutoGenerateColumns = False
        Me.EvolucaoClinicaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EvolucaoClinicaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.EvolucaoClinicaDataGridView.DataSource = Me.EvolucaoClinicaBindingSource
        Me.EvolucaoClinicaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EvolucaoClinicaDataGridView.Location = New System.Drawing.Point(151, 25)
        Me.EvolucaoClinicaDataGridView.Name = "EvolucaoClinicaDataGridView"
        Me.EvolucaoClinicaDataGridView.ReadOnly = True
        Me.EvolucaoClinicaDataGridView.RowHeadersVisible = False
        Me.EvolucaoClinicaDataGridView.Size = New System.Drawing.Size(567, 289)
        Me.EvolucaoClinicaDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NumeroProntuario"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Num. Evolução Clínica"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NumRegistroProfissional"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Num. Registro Profissional"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 160
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Profissional"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Profissional"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CodigoPaciente"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Código Paciente"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 120
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CPF"
        Me.DataGridViewTextBoxColumn5.HeaderText = "CPF"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Nome"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Data"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Data"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "QueixaPrincipal"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Queixa Principal"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 130
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "HistoriaDoencaAtual"
        Me.DataGridViewTextBoxColumn9.HeaderText = "História da Doença Atual"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 150
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ExameFisico"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Exame Físico"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 120
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "CIF"
        Me.DataGridViewTextBoxColumn11.HeaderText = "CIF"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "CID"
        Me.DataGridViewTextBoxColumn12.HeaderText = "CID"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Tratamento"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Tratamento"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Assinatura"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Assinatura"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'PesquisarECBindingNavigator
        '
        Me.PesquisarECBindingNavigator.AddNewItem = Nothing
        Me.PesquisarECBindingNavigator.CountItem = Nothing
        Me.PesquisarECBindingNavigator.DeleteItem = Nothing
        Me.PesquisarECBindingNavigator.Dock = System.Windows.Forms.DockStyle.Left
        Me.PesquisarECBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.PesquisarECBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NumEvolClinicaToolStripLabel, Me.NumEvolClinicaToolStripTextBox, Me.NumRegsitroProfissionalToolStripLabel, Me.NumRegistroProfissioanlToolStripTextBox, Me.ProfissionalToolStripLabel, Me.ProfissionalToolStripTextBox, Me.CodigoPacienteToolStripLabel, Me.CodigoPacienteToolStripTextBox, Me.CPFToolStripLabel, Me.CPFToolStripTextBox, Me.NomeToolStripLabel, Me.NomeToolStripTextBox, Me.DataToolStripLabel, Me.DataToolStripTextBox, Me.QueixaPrincipalToolStripLabel, Me.QueixaPrincipalToolStripTextBox, Me.HDAToolStripLabel, Me.HDAToolStripTextBox, Me.ExameFisicoToolStripLabel, Me.ExameFisicoToolStripTextBox, Me.CIFToolStripLabel, Me.CIFToolStripTextBox, Me.CIDToolStripLabel, Me.CIDToolStripTextBox, Me.TratamentoToolStripLabel, Me.TratamentoToolStripTextBox, Me.AssinaturaToolStripLabel, Me.AssinaturaToolStripTextBox, Me.BuscarToolStripButton})
        Me.PesquisarECBindingNavigator.Location = New System.Drawing.Point(0, 25)
        Me.PesquisarECBindingNavigator.MoveFirstItem = Nothing
        Me.PesquisarECBindingNavigator.MoveLastItem = Nothing
        Me.PesquisarECBindingNavigator.MoveNextItem = Nothing
        Me.PesquisarECBindingNavigator.MovePreviousItem = Nothing
        Me.PesquisarECBindingNavigator.Name = "PesquisarECBindingNavigator"
        Me.PesquisarECBindingNavigator.PositionItem = Nothing
        Me.PesquisarECBindingNavigator.Size = New System.Drawing.Size(151, 289)
        Me.PesquisarECBindingNavigator.TabIndex = 2
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
        'form_pesquisar_evolucao_clinica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 314)
        Me.Controls.Add(Me.EvolucaoClinicaDataGridView)
        Me.Controls.Add(Me.PesquisarECBindingNavigator)
        Me.Controls.Add(Me.EvolucaoClinicaBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_pesquisar_evolucao_clinica"
        Me.ShowIcon = False
        Me.Text = "Pesquisar Evolução Clínica"
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EvolucaoClinicaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EvolucaoClinicaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EvolucaoClinicaBindingNavigator.ResumeLayout(False)
        Me.EvolucaoClinicaBindingNavigator.PerformLayout()
        CType(Me.EvolucaoClinicaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PesquisarECBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PesquisarECBindingNavigator.ResumeLayout(False)
        Me.PesquisarECBindingNavigator.PerformLayout()
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
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents CIFToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CIFToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents CIDToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CIDToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents TratamentoToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TratamentoToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents AssinaturaToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents AssinaturaToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BuscarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents AtualizarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImprimirToolStripButton As System.Windows.Forms.ToolStripButton
End Class
