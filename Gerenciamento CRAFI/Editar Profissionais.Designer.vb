<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_editar_profissionais
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_editar_profissionais))
        Me.Gerenciamento_CRAFIDataSet = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet()
        Me.ProfissionaisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProfissionaisTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ProfissionaisTableAdapter()
        Me.TableAdapterManager = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager()
        Me.ProfissionaisBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ProfissionaisDataGridView = New System.Windows.Forms.DataGridView()
        Me.CodigoPro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
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
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.RegOrgClasseToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.RegOrgClasseToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.NomeToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.NomeToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.DataNascimentoToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.DataNascimentoToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.EnderecoToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.EnderecoToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.BairroToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.BairroToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.CidadeToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CidadeToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.EstadoToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.EstadoToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.PaisToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.PaisToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.TelefoneToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.TelefoneToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.CelularToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CelularToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.RegistroToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.RegistroToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.BuscarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ProfissionaisToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfissionaisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfissionaisBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProfissionaisBindingNavigator.SuspendLayout()
        CType(Me.ProfissionaisDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gerenciamento_CRAFIDataSet
        '
        Me.Gerenciamento_CRAFIDataSet.DataSetName = "Gerenciamento_CRAFIDataSet"
        Me.Gerenciamento_CRAFIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProfissionaisBindingSource
        '
        Me.ProfissionaisBindingSource.DataMember = "Profissionais"
        Me.ProfissionaisBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'ProfissionaisTableAdapter
        '
        Me.ProfissionaisTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnamneseTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CirurgiasTableAdapter = Nothing
        Me.TableAdapterManager.ConsultasTableAdapter = Nothing
        Me.TableAdapterManager.ContatosTableAdapter = Nothing
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
        Me.TableAdapterManager.PacientesTableAdapter = Nothing
        Me.TableAdapterManager.ProfissionaisTableAdapter = Me.ProfissionaisTableAdapter
        Me.TableAdapterManager.ReceitaTableAdapter = Nothing
        Me.TableAdapterManager.ServicosConveniosTableAdapter = Nothing
        Me.TableAdapterManager.ServicosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProfissionaisBindingNavigator
        '
        Me.ProfissionaisBindingNavigator.AddNewItem = Nothing
        Me.ProfissionaisBindingNavigator.BindingSource = Me.ProfissionaisBindingSource
        Me.ProfissionaisBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProfissionaisBindingNavigator.DeleteItem = Nothing
        Me.ProfissionaisBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ProfissionaisBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.AtualizarToolStripButton, Me.ToolStripSeparator1, Me.ImprimirToolStripButton})
        Me.ProfissionaisBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProfissionaisBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProfissionaisBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProfissionaisBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProfissionaisBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProfissionaisBindingNavigator.Name = "ProfissionaisBindingNavigator"
        Me.ProfissionaisBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProfissionaisBindingNavigator.Size = New System.Drawing.Size(718, 25)
        Me.ProfissionaisBindingNavigator.TabIndex = 0
        Me.ProfissionaisBindingNavigator.Text = "BindingNavigator1"
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
        'ProfissionaisDataGridView
        '
        Me.ProfissionaisDataGridView.AllowUserToAddRows = False
        Me.ProfissionaisDataGridView.AllowUserToDeleteRows = False
        Me.ProfissionaisDataGridView.AutoGenerateColumns = False
        Me.ProfissionaisDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProfissionaisDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoPro, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.ProfissionaisDataGridView.DataSource = Me.ProfissionaisBindingSource
        Me.ProfissionaisDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProfissionaisDataGridView.Location = New System.Drawing.Point(162, 25)
        Me.ProfissionaisDataGridView.Name = "ProfissionaisDataGridView"
        Me.ProfissionaisDataGridView.ReadOnly = True
        Me.ProfissionaisDataGridView.RowHeadersVisible = False
        Me.ProfissionaisDataGridView.Size = New System.Drawing.Size(556, 289)
        Me.ProfissionaisDataGridView.TabIndex = 1
        '
        'CodigoPro
        '
        Me.CodigoPro.DataPropertyName = "CodigoPro"
        Me.CodigoPro.HeaderText = "Código do Profissional"
        Me.CodigoPro.Name = "CodigoPro"
        Me.CodigoPro.ReadOnly = True
        Me.CodigoPro.Width = 140
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NumRegistroOrgaoClasse"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Registro em Órgão de Classe"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 200
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nome"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DataNascimento"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DataNascimento"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "SexoM"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "SexoM"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Visible = False
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "SexoF"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "SexoF"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        Me.DataGridViewCheckBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Nacionalidade"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nacionalidade"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TituloDiplomaCertificado"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Título/Diploma/Certificado"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Instituicao"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Instituição"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Endereco"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Endereço"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 200
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Bairro"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Bairro"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Cidade"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Cidade"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Estado"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Pais"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Pais"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Telefone"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Telefone"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Celular"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Celular"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn14.HeaderText = "E-mail"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 150
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Especialidades"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Especialidades"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Observacoes"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Observacoes"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.CountItem = Nothing
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.Left
        Me.BindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegOrgClasseToolStripLabel, Me.RegOrgClasseToolStripTextBox, Me.NomeToolStripLabel, Me.NomeToolStripTextBox, Me.DataNascimentoToolStripLabel, Me.DataNascimentoToolStripTextBox, Me.EnderecoToolStripLabel, Me.EnderecoToolStripTextBox, Me.BairroToolStripLabel, Me.BairroToolStripTextBox, Me.CidadeToolStripLabel, Me.CidadeToolStripTextBox, Me.EstadoToolStripLabel, Me.EstadoToolStripTextBox, Me.PaisToolStripLabel, Me.PaisToolStripTextBox, Me.TelefoneToolStripLabel, Me.TelefoneToolStripTextBox, Me.CelularToolStripLabel, Me.CelularToolStripTextBox, Me.RegistroToolStripLabel, Me.RegistroToolStripComboBox, Me.BuscarToolStripButton})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 25)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Nothing
        Me.BindingNavigator1.MovePreviousItem = Nothing
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Nothing
        Me.BindingNavigator1.Size = New System.Drawing.Size(162, 289)
        Me.BindingNavigator1.TabIndex = 2
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'RegOrgClasseToolStripLabel
        '
        Me.RegOrgClasseToolStripLabel.Name = "RegOrgClasseToolStripLabel"
        Me.RegOrgClasseToolStripLabel.Size = New System.Drawing.Size(159, 15)
        Me.RegOrgClasseToolStripLabel.Text = "Registro em Órgão de Classe:"
        '
        'RegOrgClasseToolStripTextBox
        '
        Me.RegOrgClasseToolStripTextBox.Name = "RegOrgClasseToolStripTextBox"
        Me.RegOrgClasseToolStripTextBox.Size = New System.Drawing.Size(157, 23)
        '
        'NomeToolStripLabel
        '
        Me.NomeToolStripLabel.Name = "NomeToolStripLabel"
        Me.NomeToolStripLabel.Size = New System.Drawing.Size(159, 15)
        Me.NomeToolStripLabel.Text = "Nome:"
        '
        'NomeToolStripTextBox
        '
        Me.NomeToolStripTextBox.Name = "NomeToolStripTextBox"
        Me.NomeToolStripTextBox.Size = New System.Drawing.Size(157, 23)
        '
        'DataNascimentoToolStripLabel
        '
        Me.DataNascimentoToolStripLabel.Name = "DataNascimentoToolStripLabel"
        Me.DataNascimentoToolStripLabel.Size = New System.Drawing.Size(159, 15)
        Me.DataNascimentoToolStripLabel.Text = "Data de Nascimento:"
        '
        'DataNascimentoToolStripTextBox
        '
        Me.DataNascimentoToolStripTextBox.Name = "DataNascimentoToolStripTextBox"
        Me.DataNascimentoToolStripTextBox.Size = New System.Drawing.Size(157, 23)
        Me.DataNascimentoToolStripTextBox.ToolTipText = "Para buscar a data use o formato: yyyy-mm-dd" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Para buscar todas as pessoas que fa" & _
    "zem aniversário no mês de junho:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Digite: -06-"
        '
        'EnderecoToolStripLabel
        '
        Me.EnderecoToolStripLabel.Name = "EnderecoToolStripLabel"
        Me.EnderecoToolStripLabel.Size = New System.Drawing.Size(159, 15)
        Me.EnderecoToolStripLabel.Text = "Endereço:"
        '
        'EnderecoToolStripTextBox
        '
        Me.EnderecoToolStripTextBox.Name = "EnderecoToolStripTextBox"
        Me.EnderecoToolStripTextBox.Size = New System.Drawing.Size(157, 23)
        '
        'BairroToolStripLabel
        '
        Me.BairroToolStripLabel.Name = "BairroToolStripLabel"
        Me.BairroToolStripLabel.Size = New System.Drawing.Size(159, 15)
        Me.BairroToolStripLabel.Text = "Bairro:"
        '
        'BairroToolStripTextBox
        '
        Me.BairroToolStripTextBox.Name = "BairroToolStripTextBox"
        Me.BairroToolStripTextBox.Size = New System.Drawing.Size(157, 23)
        '
        'CidadeToolStripLabel
        '
        Me.CidadeToolStripLabel.Name = "CidadeToolStripLabel"
        Me.CidadeToolStripLabel.Size = New System.Drawing.Size(159, 15)
        Me.CidadeToolStripLabel.Text = "Cidade:"
        '
        'CidadeToolStripTextBox
        '
        Me.CidadeToolStripTextBox.Name = "CidadeToolStripTextBox"
        Me.CidadeToolStripTextBox.Size = New System.Drawing.Size(157, 23)
        '
        'EstadoToolStripLabel
        '
        Me.EstadoToolStripLabel.Name = "EstadoToolStripLabel"
        Me.EstadoToolStripLabel.Size = New System.Drawing.Size(159, 15)
        Me.EstadoToolStripLabel.Text = "Estado:"
        '
        'EstadoToolStripTextBox
        '
        Me.EstadoToolStripTextBox.Name = "EstadoToolStripTextBox"
        Me.EstadoToolStripTextBox.Size = New System.Drawing.Size(157, 23)
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
        Me.PaisToolStripTextBox.Size = New System.Drawing.Size(157, 23)
        '
        'TelefoneToolStripLabel
        '
        Me.TelefoneToolStripLabel.Name = "TelefoneToolStripLabel"
        Me.TelefoneToolStripLabel.Size = New System.Drawing.Size(56, 15)
        Me.TelefoneToolStripLabel.Text = "Telefone:"
        '
        'TelefoneToolStripTextBox
        '
        Me.TelefoneToolStripTextBox.Name = "TelefoneToolStripTextBox"
        Me.TelefoneToolStripTextBox.Size = New System.Drawing.Size(157, 23)
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
        Me.CelularToolStripTextBox.Size = New System.Drawing.Size(157, 23)
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
        Me.RegistroToolStripComboBox.Size = New System.Drawing.Size(121, 23)
        '
        'BuscarToolStripButton
        '
        Me.BuscarToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources._4998_32x32
        Me.BuscarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BuscarToolStripButton.Name = "BuscarToolStripButton"
        Me.BuscarToolStripButton.Size = New System.Drawing.Size(62, 20)
        Me.BuscarToolStripButton.Text = "Buscar"
        '
        'form_editar_profissionais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 314)
        Me.Controls.Add(Me.ProfissionaisDataGridView)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.ProfissionaisBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_editar_profissionais"
        Me.ShowIcon = False
        Me.Text = "Editar Profissionais"
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfissionaisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfissionaisBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProfissionaisBindingNavigator.ResumeLayout(False)
        Me.ProfissionaisBindingNavigator.PerformLayout()
        CType(Me.ProfissionaisDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Gerenciamento_CRAFIDataSet As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet
    Friend WithEvents ProfissionaisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProfissionaisTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ProfissionaisTableAdapter
    Friend WithEvents TableAdapterManager As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProfissionaisBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ProfissionaisDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents AtualizarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents RegOrgClasseToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents RegOrgClasseToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents NomeToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents NomeToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents DataNascimentoToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DataNascimentoToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents EnderecoToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents EnderecoToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BairroToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BairroToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents CidadeToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CidadeToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents EstadoToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents EstadoToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents PaisToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents PaisToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents TelefoneToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TelefoneToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents CelularToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CelularToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ProfissionaisToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents CodigoPro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
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
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImprimirToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents RegistroToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents RegistroToolStripComboBox As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents BuscarToolStripButton As System.Windows.Forms.ToolStripButton
End Class
