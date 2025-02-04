<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_despesa_fixa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_despesa_fixa))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Gerenciamento_CRAFIDataSet = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet()
        Me.DespesaFixaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DespesaFixaTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.DespesaFixaTableAdapter()
        Me.TableAdapterManager = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager()
        Me.DespesaFixaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.IncluirDFToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CodigoDFToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CodigoDFToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ExcluirToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.NomeCampoToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CamposToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.NomeToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.SomaToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.SomarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DespesaFixaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mc_despesa_fixa = New System.Windows.Forms.MonthCalendar()
        Me.GrupoDatasDF = New System.Windows.Forms.GroupBox()
        Me.rdo_data_baixa = New System.Windows.Forms.RadioButton()
        Me.rdo_data_emissao = New System.Windows.Forms.RadioButton()
        Me.rdo_data_cadastro = New System.Windows.Forms.RadioButton()
        Me.rdo_data_vencimento = New System.Windows.Forms.RadioButton()
        Me.QueriesTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.QueriesTableAdapter()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DespesaFixaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DespesaFixaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DespesaFixaBindingNavigator.SuspendLayout()
        CType(Me.DespesaFixaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrupoDatasDF.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gerenciamento_CRAFIDataSet
        '
        Me.Gerenciamento_CRAFIDataSet.DataSetName = "Gerenciamento_CRAFIDataSet"
        Me.Gerenciamento_CRAFIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DespesaFixaBindingSource
        '
        Me.DespesaFixaBindingSource.DataMember = "DespesaFixa"
        Me.DespesaFixaBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'DespesaFixaTableAdapter
        '
        Me.DespesaFixaTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.DespesaFixaTableAdapter = Me.DespesaFixaTableAdapter
        Me.TableAdapterManager.DespesaVariavelTableAdapter = Nothing
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
        'DespesaFixaBindingNavigator
        '
        Me.DespesaFixaBindingNavigator.AddNewItem = Nothing
        Me.DespesaFixaBindingNavigator.BindingSource = Me.DespesaFixaBindingSource
        Me.DespesaFixaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DespesaFixaBindingNavigator.DeleteItem = Nothing
        Me.DespesaFixaBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.DespesaFixaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.AtualizarToolStripButton, Me.ToolStripSeparator1, Me.IncluirDFToolStripButton, Me.ToolStripSeparator2, Me.CodigoDFToolStripLabel, Me.CodigoDFToolStripTextBox, Me.ExcluirToolStripButton, Me.ToolStripSeparator3, Me.NomeCampoToolStripLabel, Me.CamposToolStripComboBox, Me.NomeToolStripComboBox, Me.SomaToolStripTextBox, Me.SomarToolStripButton})
        Me.DespesaFixaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DespesaFixaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DespesaFixaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DespesaFixaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DespesaFixaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DespesaFixaBindingNavigator.Name = "DespesaFixaBindingNavigator"
        Me.DespesaFixaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DespesaFixaBindingNavigator.Size = New System.Drawing.Size(1128, 25)
        Me.DespesaFixaBindingNavigator.TabIndex = 0
        Me.DespesaFixaBindingNavigator.Text = "BindingNavigator1"
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
        'IncluirDFToolStripButton
        '
        Me.IncluirDFToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources._6141_32x32
        Me.IncluirDFToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.IncluirDFToolStripButton.Name = "IncluirDFToolStripButton"
        Me.IncluirDFToolStripButton.Size = New System.Drawing.Size(60, 22)
        Me.IncluirDFToolStripButton.Text = "Incluir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CodigoDFToolStripLabel
        '
        Me.CodigoDFToolStripLabel.Name = "CodigoDFToolStripLabel"
        Me.CodigoDFToolStripLabel.Size = New System.Drawing.Size(63, 22)
        Me.CodigoDFToolStripLabel.Text = "CódigoDF:"
        '
        'CodigoDFToolStripTextBox
        '
        Me.CodigoDFToolStripTextBox.Name = "CodigoDFToolStripTextBox"
        Me.CodigoDFToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'ExcluirToolStripButton
        '
        Me.ExcluirToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources.Button_White_Remove
        Me.ExcluirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExcluirToolStripButton.Name = "ExcluirToolStripButton"
        Me.ExcluirToolStripButton.Size = New System.Drawing.Size(61, 22)
        Me.ExcluirToolStripButton.Text = "Excluir"
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
        Me.CamposToolStripComboBox.Items.AddRange(New Object() {"Nome da Despesa Fixa", "Data de Vencimento", "Data de Cadastro", "Data de Emissão", "Data de Baixa"})
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
        'DespesaFixaDataGridView
        '
        Me.DespesaFixaDataGridView.AllowUserToAddRows = False
        Me.DespesaFixaDataGridView.AllowUserToDeleteRows = False
        Me.DespesaFixaDataGridView.AutoGenerateColumns = False
        Me.DespesaFixaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DespesaFixaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.DespesaFixaDataGridView.DataSource = Me.DespesaFixaBindingSource
        Me.DespesaFixaDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.DespesaFixaDataGridView.Name = "DespesaFixaDataGridView"
        Me.DespesaFixaDataGridView.ReadOnly = True
        Me.DespesaFixaDataGridView.RowHeadersVisible = False
        Me.DespesaFixaDataGridView.Size = New System.Drawing.Size(1116, 220)
        Me.DespesaFixaDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CodigoDF"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CódigoDF"
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
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DataVencimento"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Data de Vencimento"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DataCadastro"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Data de Cadastro"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 120
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "DataEmissao"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Data de Emissão"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 110
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "DataBaixa"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Data de Baixa"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Valor"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn3.HeaderText = "Valor"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Observacao"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Observação"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 300
        '
        'mc_despesa_fixa
        '
        Me.mc_despesa_fixa.CalendarDimensions = New System.Drawing.Size(4, 1)
        Me.mc_despesa_fixa.Location = New System.Drawing.Point(12, 260)
        Me.mc_despesa_fixa.Name = "mc_despesa_fixa"
        Me.mc_despesa_fixa.TabIndex = 2
        '
        'GrupoDatasDF
        '
        Me.GrupoDatasDF.Controls.Add(Me.rdo_data_baixa)
        Me.GrupoDatasDF.Controls.Add(Me.rdo_data_emissao)
        Me.GrupoDatasDF.Controls.Add(Me.rdo_data_cadastro)
        Me.GrupoDatasDF.Controls.Add(Me.rdo_data_vencimento)
        Me.GrupoDatasDF.Location = New System.Drawing.Point(944, 260)
        Me.GrupoDatasDF.Name = "GrupoDatasDF"
        Me.GrupoDatasDF.Size = New System.Drawing.Size(132, 124)
        Me.GrupoDatasDF.TabIndex = 3
        Me.GrupoDatasDF.TabStop = False
        Me.GrupoDatasDF.Text = "Datas"
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
        'form_despesa_fixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(823, 275)
        Me.Controls.Add(Me.GrupoDatasDF)
        Me.Controls.Add(Me.mc_despesa_fixa)
        Me.Controls.Add(Me.DespesaFixaDataGridView)
        Me.Controls.Add(Me.DespesaFixaBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_despesa_fixa"
        Me.ShowIcon = False
        Me.Text = "Despesa Fixa"
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DespesaFixaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DespesaFixaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DespesaFixaBindingNavigator.ResumeLayout(False)
        Me.DespesaFixaBindingNavigator.PerformLayout()
        CType(Me.DespesaFixaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrupoDatasDF.ResumeLayout(False)
        Me.GrupoDatasDF.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Gerenciamento_CRAFIDataSet As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet
    Friend WithEvents DespesaFixaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DespesaFixaTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.DespesaFixaTableAdapter
    Friend WithEvents TableAdapterManager As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DespesaFixaBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DespesaFixaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents AtualizarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents IncluirDFToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents mc_despesa_fixa As System.Windows.Forms.MonthCalendar
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CodigoDFToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CodigoDFToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ExcluirToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents GrupoDatasDF As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_data_baixa As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_data_emissao As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_data_cadastro As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_data_vencimento As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NomeCampoToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CamposToolStripComboBox As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents NomeToolStripComboBox As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents SomaToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents SomarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents QueriesTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.QueriesTableAdapter
End Class
