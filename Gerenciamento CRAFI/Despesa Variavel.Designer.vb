<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_despesa_variavel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_despesa_variavel))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Gerenciamento_CRAFIDataSet = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet()
        Me.DespesaVariavelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DespesaVariavelTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.DespesaVariavelTableAdapter()
        Me.TableAdapterManager = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager()
        Me.DespesaVariavelBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.IncluirDVToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CodigoDVToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CodigoDVToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ExcluirDVToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.NomeCampoToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CamposToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.NomeToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.SomaToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.SomarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DespesaVariavelDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mc_despesa_variavel = New System.Windows.Forms.MonthCalendar()
        Me.GrupoDatasCV = New System.Windows.Forms.GroupBox()
        Me.rdo_data_baixa = New System.Windows.Forms.RadioButton()
        Me.rdo_data_emissao = New System.Windows.Forms.RadioButton()
        Me.rdo_data_cadastro = New System.Windows.Forms.RadioButton()
        Me.rdo_data_vencimento = New System.Windows.Forms.RadioButton()
        Me.QueriesTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.QueriesTableAdapter()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DespesaVariavelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DespesaVariavelBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DespesaVariavelBindingNavigator.SuspendLayout()
        CType(Me.DespesaVariavelDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrupoDatasCV.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gerenciamento_CRAFIDataSet
        '
        Me.Gerenciamento_CRAFIDataSet.DataSetName = "Gerenciamento_CRAFIDataSet"
        Me.Gerenciamento_CRAFIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DespesaVariavelBindingSource
        '
        Me.DespesaVariavelBindingSource.DataMember = "DespesaVariavel"
        Me.DespesaVariavelBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'DespesaVariavelTableAdapter
        '
        Me.DespesaVariavelTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.DespesaVariavelTableAdapter = Me.DespesaVariavelTableAdapter
        Me.TableAdapterManager.EvolucaoClinicaTableAdapter = Nothing
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
        'DespesaVariavelBindingNavigator
        '
        Me.DespesaVariavelBindingNavigator.AddNewItem = Nothing
        Me.DespesaVariavelBindingNavigator.BindingSource = Me.DespesaVariavelBindingSource
        Me.DespesaVariavelBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DespesaVariavelBindingNavigator.DeleteItem = Nothing
        Me.DespesaVariavelBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.DespesaVariavelBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.AtualizarToolStripButton, Me.ToolStripSeparator1, Me.IncluirDVToolStripButton, Me.ToolStripSeparator2, Me.CodigoDVToolStripLabel, Me.CodigoDVToolStripTextBox, Me.ExcluirDVToolStripButton, Me.ToolStripSeparator3, Me.NomeCampoToolStripLabel, Me.CamposToolStripComboBox, Me.NomeToolStripComboBox, Me.SomaToolStripTextBox, Me.SomarToolStripButton})
        Me.DespesaVariavelBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DespesaVariavelBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DespesaVariavelBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DespesaVariavelBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DespesaVariavelBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DespesaVariavelBindingNavigator.Name = "DespesaVariavelBindingNavigator"
        Me.DespesaVariavelBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DespesaVariavelBindingNavigator.Size = New System.Drawing.Size(1130, 25)
        Me.DespesaVariavelBindingNavigator.TabIndex = 0
        Me.DespesaVariavelBindingNavigator.Text = "BindingNavigator1"
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
        'IncluirDVToolStripButton
        '
        Me.IncluirDVToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources._6141_32x32
        Me.IncluirDVToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.IncluirDVToolStripButton.Name = "IncluirDVToolStripButton"
        Me.IncluirDVToolStripButton.Size = New System.Drawing.Size(60, 22)
        Me.IncluirDVToolStripButton.Text = "Incluir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CodigoDVToolStripLabel
        '
        Me.CodigoDVToolStripLabel.Name = "CodigoDVToolStripLabel"
        Me.CodigoDVToolStripLabel.Size = New System.Drawing.Size(64, 22)
        Me.CodigoDVToolStripLabel.Text = "CódigoDV:"
        '
        'CodigoDVToolStripTextBox
        '
        Me.CodigoDVToolStripTextBox.Name = "CodigoDVToolStripTextBox"
        Me.CodigoDVToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'ExcluirDVToolStripButton
        '
        Me.ExcluirDVToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources.Button_White_Remove
        Me.ExcluirDVToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExcluirDVToolStripButton.Name = "ExcluirDVToolStripButton"
        Me.ExcluirDVToolStripButton.Size = New System.Drawing.Size(61, 22)
        Me.ExcluirDVToolStripButton.Text = "Excluir"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'NomeCampoToolStripLabel
        '
        Me.NomeCampoToolStripLabel.Name = "NomeCampoToolStripLabel"
        Me.NomeCampoToolStripLabel.Size = New System.Drawing.Size(100, 22)
        Me.NomeCampoToolStripLabel.Text = "Nome do campo:"
        '
        'CamposToolStripComboBox
        '
        Me.CamposToolStripComboBox.Items.AddRange(New Object() {"Nome da Despesa Variável", "Data de Vencimento", "Data de Cadastro", "Data de Emissão", "Data de Baixa"})
        Me.CamposToolStripComboBox.Name = "CamposToolStripComboBox"
        Me.CamposToolStripComboBox.Size = New System.Drawing.Size(150, 25)
        '
        'NomeToolStripComboBox
        '
        Me.NomeToolStripComboBox.Name = "NomeToolStripComboBox"
        Me.NomeToolStripComboBox.Size = New System.Drawing.Size(150, 25)
        '
        'SomaToolStripTextBox
        '
        Me.SomaToolStripTextBox.Name = "SomaToolStripTextBox"
        Me.SomaToolStripTextBox.ReadOnly = True
        Me.SomaToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'SomarToolStripButton
        '
        Me.SomarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SomarToolStripButton.Image = CType(resources.GetObject("SomarToolStripButton.Image"), System.Drawing.Image)
        Me.SomarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SomarToolStripButton.Name = "SomarToolStripButton"
        Me.SomarToolStripButton.Size = New System.Drawing.Size(45, 22)
        Me.SomarToolStripButton.Text = "Somar"
        '
        'DespesaVariavelDataGridView
        '
        Me.DespesaVariavelDataGridView.AllowUserToAddRows = False
        Me.DespesaVariavelDataGridView.AllowUserToDeleteRows = False
        Me.DespesaVariavelDataGridView.AutoGenerateColumns = False
        Me.DespesaVariavelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DespesaVariavelDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.DespesaVariavelDataGridView.DataSource = Me.DespesaVariavelBindingSource
        Me.DespesaVariavelDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.DespesaVariavelDataGridView.Name = "DespesaVariavelDataGridView"
        Me.DespesaVariavelDataGridView.ReadOnly = True
        Me.DespesaVariavelDataGridView.RowHeadersVisible = False
        Me.DespesaVariavelDataGridView.Size = New System.Drawing.Size(1118, 220)
        Me.DespesaVariavelDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CodigoDV"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CódigoDV"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nome"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DataVencimento"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Data de Vencimento"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DataCadastro"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Data de Cadastro"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 120
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DataEmissao"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Data de Emissão"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 110
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DataBaixa"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Data de Baixa"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Valor"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn7.HeaderText = "Valor"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Observacao"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Observação"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 300
        '
        'mc_despesa_variavel
        '
        Me.mc_despesa_variavel.CalendarDimensions = New System.Drawing.Size(4, 1)
        Me.mc_despesa_variavel.Location = New System.Drawing.Point(12, 260)
        Me.mc_despesa_variavel.Name = "mc_despesa_variavel"
        Me.mc_despesa_variavel.TabIndex = 2
        '
        'GrupoDatasCV
        '
        Me.GrupoDatasCV.Controls.Add(Me.rdo_data_baixa)
        Me.GrupoDatasCV.Controls.Add(Me.rdo_data_emissao)
        Me.GrupoDatasCV.Controls.Add(Me.rdo_data_cadastro)
        Me.GrupoDatasCV.Controls.Add(Me.rdo_data_vencimento)
        Me.GrupoDatasCV.Location = New System.Drawing.Point(944, 260)
        Me.GrupoDatasCV.Name = "GrupoDatasCV"
        Me.GrupoDatasCV.Size = New System.Drawing.Size(132, 119)
        Me.GrupoDatasCV.TabIndex = 3
        Me.GrupoDatasCV.TabStop = False
        Me.GrupoDatasCV.Text = "Datas"
        '
        'rdo_data_baixa
        '
        Me.rdo_data_baixa.AutoSize = True
        Me.rdo_data_baixa.Location = New System.Drawing.Point(6, 91)
        Me.rdo_data_baixa.Name = "rdo_data_baixa"
        Me.rdo_data_baixa.Size = New System.Drawing.Size(92, 17)
        Me.rdo_data_baixa.TabIndex = 3
        Me.rdo_data_baixa.Text = "Data de Baixa"
        Me.rdo_data_baixa.UseVisualStyleBackColor = True
        '
        'rdo_data_emissao
        '
        Me.rdo_data_emissao.AutoSize = True
        Me.rdo_data_emissao.Location = New System.Drawing.Point(6, 67)
        Me.rdo_data_emissao.Name = "rdo_data_emissao"
        Me.rdo_data_emissao.Size = New System.Drawing.Size(105, 17)
        Me.rdo_data_emissao.TabIndex = 2
        Me.rdo_data_emissao.Text = "Data de Emissão"
        Me.rdo_data_emissao.UseVisualStyleBackColor = True
        '
        'rdo_data_cadastro
        '
        Me.rdo_data_cadastro.AutoSize = True
        Me.rdo_data_cadastro.Location = New System.Drawing.Point(6, 43)
        Me.rdo_data_cadastro.Name = "rdo_data_cadastro"
        Me.rdo_data_cadastro.Size = New System.Drawing.Size(108, 17)
        Me.rdo_data_cadastro.TabIndex = 1
        Me.rdo_data_cadastro.Text = "Data de Cadastro"
        Me.rdo_data_cadastro.UseVisualStyleBackColor = True
        '
        'rdo_data_vencimento
        '
        Me.rdo_data_vencimento.AutoSize = True
        Me.rdo_data_vencimento.Checked = True
        Me.rdo_data_vencimento.Location = New System.Drawing.Point(6, 19)
        Me.rdo_data_vencimento.Name = "rdo_data_vencimento"
        Me.rdo_data_vencimento.Size = New System.Drawing.Size(122, 17)
        Me.rdo_data_vencimento.TabIndex = 0
        Me.rdo_data_vencimento.TabStop = True
        Me.rdo_data_vencimento.Text = "Data de Vencimento"
        Me.rdo_data_vencimento.UseVisualStyleBackColor = True
        '
        'form_despesa_variavel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(889, 291)
        Me.Controls.Add(Me.GrupoDatasCV)
        Me.Controls.Add(Me.mc_despesa_variavel)
        Me.Controls.Add(Me.DespesaVariavelDataGridView)
        Me.Controls.Add(Me.DespesaVariavelBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_despesa_variavel"
        Me.ShowIcon = False
        Me.Text = "Despesa Variável"
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DespesaVariavelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DespesaVariavelBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DespesaVariavelBindingNavigator.ResumeLayout(False)
        Me.DespesaVariavelBindingNavigator.PerformLayout()
        CType(Me.DespesaVariavelDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrupoDatasCV.ResumeLayout(False)
        Me.GrupoDatasCV.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Gerenciamento_CRAFIDataSet As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet
    Friend WithEvents DespesaVariavelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DespesaVariavelTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.DespesaVariavelTableAdapter
    Friend WithEvents TableAdapterManager As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DespesaVariavelBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AtualizarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents IncluirDVToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CodigoDVToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CodigoDVToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ExcluirDVToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents DespesaVariavelDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents mc_despesa_variavel As System.Windows.Forms.MonthCalendar
    Friend WithEvents GrupoDatasCV As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_data_baixa As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_data_emissao As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_data_cadastro As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_data_vencimento As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NomeCampoToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CamposToolStripComboBox As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents NomeToolStripComboBox As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents SomaToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents SomarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents QueriesTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.QueriesTableAdapter
End Class
