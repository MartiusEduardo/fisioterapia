<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_receitas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_receitas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Gerenciamento_CRAFIDataSet = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet()
        Me.ReceitaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReceitaTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ReceitaTableAdapter()
        Me.TableAdapterManager = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager()
        Me.ReceitaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.IncluirToolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.IncluirReceitaToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CodigoReceitaToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CodigoReceitaToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ExcluirReceitaToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.NomeCampoToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CamposToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.NomeToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.SomaToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.SomarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ReceitaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeProfissional = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomePaciente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeServico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataVencimento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataCadastro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataEmissao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataBaixa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mc_receita = New System.Windows.Forms.MonthCalendar()
        Me.GrupoDatasReceita = New System.Windows.Forms.GroupBox()
        Me.rdo_data_baixa = New System.Windows.Forms.RadioButton()
        Me.rdo_data_emissao = New System.Windows.Forms.RadioButton()
        Me.rdo_data_cadastro = New System.Windows.Forms.RadioButton()
        Me.rdo_data_vencimento = New System.Windows.Forms.RadioButton()
        Me.GrupoFiltrarPor = New System.Windows.Forms.GroupBox()
        Me.rdo_ano = New System.Windows.Forms.RadioButton()
        Me.rdo_mes = New System.Windows.Forms.RadioButton()
        Me.rdo_dia = New System.Windows.Forms.RadioButton()
        Me.QueriesTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.QueriesTableAdapter()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceitaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceitaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ReceitaBindingNavigator.SuspendLayout()
        CType(Me.ReceitaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrupoDatasReceita.SuspendLayout()
        Me.GrupoFiltrarPor.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gerenciamento_CRAFIDataSet
        '
        Me.Gerenciamento_CRAFIDataSet.DataSetName = "Gerenciamento_CRAFIDataSet"
        Me.Gerenciamento_CRAFIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReceitaBindingSource
        '
        Me.ReceitaBindingSource.DataMember = "Receita"
        Me.ReceitaBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'ReceitaTableAdapter
        '
        Me.ReceitaTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.ProfissionaisTableAdapter = Nothing
        Me.TableAdapterManager.ReceitaTableAdapter = Me.ReceitaTableAdapter
        Me.TableAdapterManager.ServicosConveniosTableAdapter = Nothing
        Me.TableAdapterManager.ServicosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ReceitaBindingNavigator
        '
        Me.ReceitaBindingNavigator.AddNewItem = Nothing
        Me.ReceitaBindingNavigator.BindingSource = Me.ReceitaBindingSource
        Me.ReceitaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ReceitaBindingNavigator.DeleteItem = Nothing
        Me.ReceitaBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ReceitaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.AtualizarToolStripButton, Me.IncluirToolStripSeparator, Me.IncluirReceitaToolStripButton, Me.ToolStripSeparator1, Me.CodigoReceitaToolStripLabel, Me.CodigoReceitaToolStripTextBox, Me.ExcluirReceitaToolStripButton, Me.ToolStripSeparator2, Me.NomeCampoToolStripLabel, Me.CamposToolStripComboBox, Me.NomeToolStripComboBox, Me.SomaToolStripTextBox, Me.SomarToolStripButton})
        Me.ReceitaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ReceitaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ReceitaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ReceitaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ReceitaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ReceitaBindingNavigator.Name = "ReceitaBindingNavigator"
        Me.ReceitaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ReceitaBindingNavigator.Size = New System.Drawing.Size(1158, 25)
        Me.ReceitaBindingNavigator.TabIndex = 0
        Me.ReceitaBindingNavigator.Text = "BindingNavigator1"
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
        'IncluirToolStripSeparator
        '
        Me.IncluirToolStripSeparator.Name = "IncluirToolStripSeparator"
        Me.IncluirToolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'IncluirReceitaToolStripButton
        '
        Me.IncluirReceitaToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources._6141_32x32
        Me.IncluirReceitaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.IncluirReceitaToolStripButton.Name = "IncluirReceitaToolStripButton"
        Me.IncluirReceitaToolStripButton.Size = New System.Drawing.Size(60, 22)
        Me.IncluirReceitaToolStripButton.Text = "Incluir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'CodigoReceitaToolStripLabel
        '
        Me.CodigoReceitaToolStripLabel.Name = "CodigoReceitaToolStripLabel"
        Me.CodigoReceitaToolStripLabel.Size = New System.Drawing.Size(56, 22)
        Me.CodigoReceitaToolStripLabel.Text = "CódigoR:"
        '
        'CodigoReceitaToolStripTextBox
        '
        Me.CodigoReceitaToolStripTextBox.Name = "CodigoReceitaToolStripTextBox"
        Me.CodigoReceitaToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'ExcluirReceitaToolStripButton
        '
        Me.ExcluirReceitaToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources.Button_White_Remove
        Me.ExcluirReceitaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExcluirReceitaToolStripButton.Name = "ExcluirReceitaToolStripButton"
        Me.ExcluirReceitaToolStripButton.Size = New System.Drawing.Size(61, 22)
        Me.ExcluirReceitaToolStripButton.Text = "Excluir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'NomeCampoToolStripLabel
        '
        Me.NomeCampoToolStripLabel.Name = "NomeCampoToolStripLabel"
        Me.NomeCampoToolStripLabel.Size = New System.Drawing.Size(100, 22)
        Me.NomeCampoToolStripLabel.Text = "Nome do campo:"
        '
        'CamposToolStripComboBox
        '
        Me.CamposToolStripComboBox.Items.AddRange(New Object() {"Nome do Profissional", "Nome do Paciente", "Nome (Serviço / Produto)", "Data de Vencimento", "Data de Cadastro", "Data de Emissão", "Data de Baixa"})
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
        Me.SomarToolStripButton.Size = New System.Drawing.Size(86, 19)
        Me.SomarToolStripButton.Text = "Somar Receita"
        '
        'ReceitaDataGridView
        '
        Me.ReceitaDataGridView.AllowUserToAddRows = False
        Me.ReceitaDataGridView.AllowUserToDeleteRows = False
        Me.ReceitaDataGridView.AutoGenerateColumns = False
        Me.ReceitaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReceitaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.NomeProfissional, Me.NomePaciente, Me.NomeServico, Me.DataVencimento, Me.DataCadastro, Me.DataEmissao, Me.DataBaixa, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.ReceitaDataGridView.DataSource = Me.ReceitaBindingSource
        Me.ReceitaDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.ReceitaDataGridView.Name = "ReceitaDataGridView"
        Me.ReceitaDataGridView.ReadOnly = True
        Me.ReceitaDataGridView.RowHeadersVisible = False
        Me.ReceitaDataGridView.Size = New System.Drawing.Size(1146, 220)
        Me.ReceitaDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CodigoR"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CódigoR"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 70
        '
        'NomeProfissional
        '
        Me.NomeProfissional.DataPropertyName = "NomeProfissional"
        Me.NomeProfissional.HeaderText = "Nome do Profissional"
        Me.NomeProfissional.Name = "NomeProfissional"
        Me.NomeProfissional.ReadOnly = True
        Me.NomeProfissional.Width = 150
        '
        'NomePaciente
        '
        Me.NomePaciente.DataPropertyName = "NomePaciente"
        Me.NomePaciente.HeaderText = "Nome do Paciente"
        Me.NomePaciente.Name = "NomePaciente"
        Me.NomePaciente.ReadOnly = True
        Me.NomePaciente.Width = 150
        '
        'NomeServico
        '
        Me.NomeServico.DataPropertyName = "NomeServico"
        Me.NomeServico.HeaderText = "Nome (Serviço/Produto)"
        Me.NomeServico.Name = "NomeServico"
        Me.NomeServico.ReadOnly = True
        Me.NomeServico.Width = 150
        '
        'DataVencimento
        '
        Me.DataVencimento.DataPropertyName = "DataVencimento"
        Me.DataVencimento.HeaderText = "Data de Vencimento"
        Me.DataVencimento.Name = "DataVencimento"
        Me.DataVencimento.ReadOnly = True
        Me.DataVencimento.Width = 150
        '
        'DataCadastro
        '
        Me.DataCadastro.DataPropertyName = "DataCadastro"
        Me.DataCadastro.HeaderText = "Data de Cadastro"
        Me.DataCadastro.Name = "DataCadastro"
        Me.DataCadastro.ReadOnly = True
        Me.DataCadastro.Width = 120
        '
        'DataEmissao
        '
        Me.DataEmissao.DataPropertyName = "DataEmissao"
        Me.DataEmissao.HeaderText = "Data de Emissão"
        Me.DataEmissao.Name = "DataEmissao"
        Me.DataEmissao.ReadOnly = True
        Me.DataEmissao.Width = 120
        '
        'DataBaixa
        '
        Me.DataBaixa.DataPropertyName = "DataBaixa"
        Me.DataBaixa.HeaderText = "Data de Baixa"
        Me.DataBaixa.Name = "DataBaixa"
        Me.DataBaixa.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Valor"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn4.HeaderText = "Valor"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Observacao"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Observação"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 300
        '
        'mc_receita
        '
        Me.mc_receita.BackColor = System.Drawing.SystemColors.Window
        Me.mc_receita.CalendarDimensions = New System.Drawing.Size(4, 1)
        Me.mc_receita.ForeColor = System.Drawing.SystemColors.WindowText
        Me.mc_receita.Location = New System.Drawing.Point(12, 260)
        Me.mc_receita.Name = "mc_receita"
        Me.mc_receita.TabIndex = 2
        '
        'GrupoDatasReceita
        '
        Me.GrupoDatasReceita.Controls.Add(Me.rdo_data_baixa)
        Me.GrupoDatasReceita.Controls.Add(Me.rdo_data_emissao)
        Me.GrupoDatasReceita.Controls.Add(Me.rdo_data_cadastro)
        Me.GrupoDatasReceita.Controls.Add(Me.rdo_data_vencimento)
        Me.GrupoDatasReceita.Location = New System.Drawing.Point(944, 260)
        Me.GrupoDatasReceita.Name = "GrupoDatasReceita"
        Me.GrupoDatasReceita.Size = New System.Drawing.Size(141, 114)
        Me.GrupoDatasReceita.TabIndex = 3
        Me.GrupoDatasReceita.TabStop = False
        Me.GrupoDatasReceita.Text = "Datas"
        '
        'rdo_data_baixa
        '
        Me.rdo_data_baixa.AutoSize = True
        Me.rdo_data_baixa.Location = New System.Drawing.Point(6, 88)
        Me.rdo_data_baixa.Name = "rdo_data_baixa"
        Me.rdo_data_baixa.Size = New System.Drawing.Size(92, 17)
        Me.rdo_data_baixa.TabIndex = 3
        Me.rdo_data_baixa.TabStop = True
        Me.rdo_data_baixa.Text = "Data de Baixa"
        Me.rdo_data_baixa.UseVisualStyleBackColor = True
        '
        'rdo_data_emissao
        '
        Me.rdo_data_emissao.AutoSize = True
        Me.rdo_data_emissao.Location = New System.Drawing.Point(6, 65)
        Me.rdo_data_emissao.Name = "rdo_data_emissao"
        Me.rdo_data_emissao.Size = New System.Drawing.Size(105, 17)
        Me.rdo_data_emissao.TabIndex = 2
        Me.rdo_data_emissao.TabStop = True
        Me.rdo_data_emissao.Text = "Data de Emissão"
        Me.rdo_data_emissao.UseVisualStyleBackColor = True
        '
        'rdo_data_cadastro
        '
        Me.rdo_data_cadastro.AutoSize = True
        Me.rdo_data_cadastro.Location = New System.Drawing.Point(6, 42)
        Me.rdo_data_cadastro.Name = "rdo_data_cadastro"
        Me.rdo_data_cadastro.Size = New System.Drawing.Size(108, 17)
        Me.rdo_data_cadastro.TabIndex = 1
        Me.rdo_data_cadastro.TabStop = True
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
        'GrupoFiltrarPor
        '
        Me.GrupoFiltrarPor.Controls.Add(Me.rdo_ano)
        Me.GrupoFiltrarPor.Controls.Add(Me.rdo_mes)
        Me.GrupoFiltrarPor.Controls.Add(Me.rdo_dia)
        Me.GrupoFiltrarPor.Location = New System.Drawing.Point(1091, 260)
        Me.GrupoFiltrarPor.Name = "GrupoFiltrarPor"
        Me.GrupoFiltrarPor.Size = New System.Drawing.Size(67, 114)
        Me.GrupoFiltrarPor.TabIndex = 4
        Me.GrupoFiltrarPor.TabStop = False
        Me.GrupoFiltrarPor.Text = "Filtrar por"
        '
        'rdo_ano
        '
        Me.rdo_ano.AutoSize = True
        Me.rdo_ano.Location = New System.Drawing.Point(6, 66)
        Me.rdo_ano.Name = "rdo_ano"
        Me.rdo_ano.Size = New System.Drawing.Size(44, 17)
        Me.rdo_ano.TabIndex = 2
        Me.rdo_ano.Text = "Ano"
        Me.rdo_ano.UseVisualStyleBackColor = True
        '
        'rdo_mes
        '
        Me.rdo_mes.AutoSize = True
        Me.rdo_mes.Checked = True
        Me.rdo_mes.Location = New System.Drawing.Point(6, 42)
        Me.rdo_mes.Name = "rdo_mes"
        Me.rdo_mes.Size = New System.Drawing.Size(45, 17)
        Me.rdo_mes.TabIndex = 1
        Me.rdo_mes.TabStop = True
        Me.rdo_mes.Text = "Mês"
        Me.rdo_mes.UseVisualStyleBackColor = True
        '
        'rdo_dia
        '
        Me.rdo_dia.AutoSize = True
        Me.rdo_dia.Location = New System.Drawing.Point(6, 19)
        Me.rdo_dia.Name = "rdo_dia"
        Me.rdo_dia.Size = New System.Drawing.Size(41, 17)
        Me.rdo_dia.TabIndex = 0
        Me.rdo_dia.Text = "Dia"
        Me.rdo_dia.UseVisualStyleBackColor = True
        '
        'form_receitas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(960, 326)
        Me.Controls.Add(Me.GrupoFiltrarPor)
        Me.Controls.Add(Me.GrupoDatasReceita)
        Me.Controls.Add(Me.mc_receita)
        Me.Controls.Add(Me.ReceitaDataGridView)
        Me.Controls.Add(Me.ReceitaBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_receitas"
        Me.ShowIcon = False
        Me.Text = "Receitas"
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceitaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceitaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ReceitaBindingNavigator.ResumeLayout(False)
        Me.ReceitaBindingNavigator.PerformLayout()
        CType(Me.ReceitaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrupoDatasReceita.ResumeLayout(False)
        Me.GrupoDatasReceita.PerformLayout()
        Me.GrupoFiltrarPor.ResumeLayout(False)
        Me.GrupoFiltrarPor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Gerenciamento_CRAFIDataSet As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet
    Friend WithEvents ReceitaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReceitaTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ReceitaTableAdapter
    Friend WithEvents TableAdapterManager As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ReceitaBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents IncluirReceitaToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ReceitaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents mc_receita As System.Windows.Forms.MonthCalendar
    Friend WithEvents GrupoDatasReceita As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_data_baixa As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_data_emissao As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_data_cadastro As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_data_vencimento As System.Windows.Forms.RadioButton
    Friend WithEvents AtualizarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents IncluirToolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CodigoReceitaToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CodigoReceitaToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ExcluirReceitaToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeProfissional As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomePaciente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeServico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataVencimento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataCadastro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataEmissao As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataBaixa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CamposToolStripComboBox As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents SomaToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents SomarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents NomeToolStripComboBox As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents GrupoFiltrarPor As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_ano As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_mes As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_dia As System.Windows.Forms.RadioButton
    Friend WithEvents NomeCampoToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents QueriesTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.QueriesTableAdapter
End Class
