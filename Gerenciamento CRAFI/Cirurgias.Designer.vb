<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_cirurgias
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
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim NumeroProntuarioLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim DescricaoLabel As System.Windows.Forms.Label
        Dim DataLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_cirurgias))
        Me.Gerenciamento_CRAFIDataSet = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet()
        Me.CirurgiasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CirurgiasTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.CirurgiasTableAdapter()
        Me.TableAdapterManager = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager()
        Me.CirurgiasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.AdicionarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CirurgiasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CancelarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.NumeroProntuarioTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.DescricaoTextBox = New System.Windows.Forms.TextBox()
        Me.DataDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CirurgiasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QueriesTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.QueriesTableAdapter()
        CodigoLabel = New System.Windows.Forms.Label()
        NumeroProntuarioLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        DescricaoLabel = New System.Windows.Forms.Label()
        DataLabel = New System.Windows.Forms.Label()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CirurgiasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CirurgiasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CirurgiasBindingNavigator.SuspendLayout()
        CType(Me.CirurgiasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(82, 47)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(43, 13)
        CodigoLabel.TabIndex = 1
        CodigoLabel.Text = "Código:"
        '
        'NumeroProntuarioLabel
        '
        NumeroProntuarioLabel.AutoSize = True
        NumeroProntuarioLabel.Location = New System.Drawing.Point(12, 73)
        NumeroProntuarioLabel.Name = "NumeroProntuarioLabel"
        NumeroProntuarioLabel.Size = New System.Drawing.Size(113, 13)
        NumeroProntuarioLabel.TabIndex = 3
        NumeroProntuarioLabel.Text = "Número do Prontuário:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(87, 99)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 5
        NomeLabel.Text = "Nome:"
        '
        'DescricaoLabel
        '
        DescricaoLabel.AutoSize = True
        DescricaoLabel.Location = New System.Drawing.Point(67, 151)
        DescricaoLabel.Name = "DescricaoLabel"
        DescricaoLabel.Size = New System.Drawing.Size(58, 13)
        DescricaoLabel.TabIndex = 7
        DescricaoLabel.Text = "Descrição:"
        '
        'DataLabel
        '
        DataLabel.AutoSize = True
        DataLabel.Location = New System.Drawing.Point(92, 128)
        DataLabel.Name = "DataLabel"
        DataLabel.Size = New System.Drawing.Size(33, 13)
        DataLabel.TabIndex = 9
        DataLabel.Text = "Data:"
        '
        'Gerenciamento_CRAFIDataSet
        '
        Me.Gerenciamento_CRAFIDataSet.DataSetName = "Gerenciamento_CRAFIDataSet"
        Me.Gerenciamento_CRAFIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CirurgiasBindingSource
        '
        Me.CirurgiasBindingSource.DataMember = "Cirurgias"
        Me.CirurgiasBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'CirurgiasTableAdapter
        '
        Me.CirurgiasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnamneseTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CirurgiasTableAdapter = Me.CirurgiasTableAdapter
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
        Me.TableAdapterManager.ReceitaTableAdapter = Nothing
        Me.TableAdapterManager.ServicosConveniosTableAdapter = Nothing
        Me.TableAdapterManager.ServicosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CirurgiasBindingNavigator
        '
        Me.CirurgiasBindingNavigator.AddNewItem = Nothing
        Me.CirurgiasBindingNavigator.BindingSource = Me.CirurgiasBindingSource
        Me.CirurgiasBindingNavigator.CountItem = Nothing
        Me.CirurgiasBindingNavigator.DeleteItem = Nothing
        Me.CirurgiasBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.CirurgiasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdicionarToolStripButton, Me.CirurgiasBindingNavigatorSaveItem, Me.CancelarToolStripButton})
        Me.CirurgiasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CirurgiasBindingNavigator.MoveFirstItem = Nothing
        Me.CirurgiasBindingNavigator.MoveLastItem = Nothing
        Me.CirurgiasBindingNavigator.MoveNextItem = Nothing
        Me.CirurgiasBindingNavigator.MovePreviousItem = Nothing
        Me.CirurgiasBindingNavigator.Name = "CirurgiasBindingNavigator"
        Me.CirurgiasBindingNavigator.PositionItem = Nothing
        Me.CirurgiasBindingNavigator.Size = New System.Drawing.Size(661, 25)
        Me.CirurgiasBindingNavigator.TabIndex = 0
        Me.CirurgiasBindingNavigator.Text = "BindingNavigator1"
        '
        'AdicionarToolStripButton
        '
        Me.AdicionarToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources.Button_White_Add
        Me.AdicionarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AdicionarToolStripButton.Name = "AdicionarToolStripButton"
        Me.AdicionarToolStripButton.Size = New System.Drawing.Size(78, 22)
        Me.AdicionarToolStripButton.Text = "Adicionar"
        '
        'CirurgiasBindingNavigatorSaveItem
        '
        Me.CirurgiasBindingNavigatorSaveItem.Image = CType(resources.GetObject("CirurgiasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CirurgiasBindingNavigatorSaveItem.Name = "CirurgiasBindingNavigatorSaveItem"
        Me.CirurgiasBindingNavigatorSaveItem.Size = New System.Drawing.Size(58, 22)
        Me.CirurgiasBindingNavigatorSaveItem.Text = "Salvar"
        '
        'CancelarToolStripButton
        '
        Me.CancelarToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources.Button_White_Stop
        Me.CancelarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CancelarToolStripButton.Name = "CancelarToolStripButton"
        Me.CancelarToolStripButton.Size = New System.Drawing.Size(73, 22)
        Me.CancelarToolStripButton.Text = "Cancelar"
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CirurgiasBindingSource, "Codigo", True))
        Me.CodigoTextBox.Location = New System.Drawing.Point(131, 44)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodigoTextBox.TabIndex = 2
        Me.CodigoTextBox.Tag = "N"
        '
        'NumeroProntuarioTextBox
        '
        Me.NumeroProntuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CirurgiasBindingSource, "NumeroProntuario", True))
        Me.NumeroProntuarioTextBox.Location = New System.Drawing.Point(131, 70)
        Me.NumeroProntuarioTextBox.Name = "NumeroProntuarioTextBox"
        Me.NumeroProntuarioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NumeroProntuarioTextBox.TabIndex = 4
        Me.NumeroProntuarioTextBox.Tag = "N"
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CirurgiasBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(131, 96)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(212, 20)
        Me.NomeTextBox.TabIndex = 6
        '
        'DescricaoTextBox
        '
        Me.DescricaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CirurgiasBindingSource, "Descricao", True))
        Me.DescricaoTextBox.Location = New System.Drawing.Point(131, 148)
        Me.DescricaoTextBox.Multiline = True
        Me.DescricaoTextBox.Name = "DescricaoTextBox"
        Me.DescricaoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.DescricaoTextBox.Size = New System.Drawing.Size(524, 106)
        Me.DescricaoTextBox.TabIndex = 8
        '
        'DataDateTimePicker
        '
        Me.DataDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CirurgiasBindingSource, "Data", True))
        Me.DataDateTimePicker.Location = New System.Drawing.Point(131, 122)
        Me.DataDateTimePicker.Name = "DataDateTimePicker"
        Me.DataDateTimePicker.Size = New System.Drawing.Size(212, 20)
        Me.DataDateTimePicker.TabIndex = 10
        '
        'CirurgiasDataGridView
        '
        Me.CirurgiasDataGridView.AllowUserToAddRows = False
        Me.CirurgiasDataGridView.AllowUserToDeleteRows = False
        Me.CirurgiasDataGridView.AutoGenerateColumns = False
        Me.CirurgiasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CirurgiasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.CirurgiasDataGridView.DataSource = Me.CirurgiasBindingSource
        Me.CirurgiasDataGridView.Location = New System.Drawing.Point(0, 260)
        Me.CirurgiasDataGridView.Name = "CirurgiasDataGridView"
        Me.CirurgiasDataGridView.ReadOnly = True
        Me.CirurgiasDataGridView.RowHeadersVisible = False
        Me.CirurgiasDataGridView.Size = New System.Drawing.Size(655, 220)
        Me.CirurgiasDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Codigo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NumeroProntuario"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Número do Prontuário"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 140
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
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Descricao"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Descrição"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 200
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Data"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Data"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'form_cirurgias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(661, 481)
        Me.Controls.Add(Me.CirurgiasDataGridView)
        Me.Controls.Add(CodigoLabel)
        Me.Controls.Add(Me.CodigoTextBox)
        Me.Controls.Add(NumeroProntuarioLabel)
        Me.Controls.Add(Me.NumeroProntuarioTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(DescricaoLabel)
        Me.Controls.Add(Me.DescricaoTextBox)
        Me.Controls.Add(DataLabel)
        Me.Controls.Add(Me.DataDateTimePicker)
        Me.Controls.Add(Me.CirurgiasBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_cirurgias"
        Me.ShowIcon = False
        Me.Text = "Cirurgias"
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CirurgiasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CirurgiasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CirurgiasBindingNavigator.ResumeLayout(False)
        Me.CirurgiasBindingNavigator.PerformLayout()
        CType(Me.CirurgiasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Gerenciamento_CRAFIDataSet As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet
    Friend WithEvents CirurgiasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CirurgiasTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.CirurgiasTableAdapter
    Friend WithEvents TableAdapterManager As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CirurgiasBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents CirurgiasBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CodigoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NumeroProntuarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescricaoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CirurgiasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdicionarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CancelarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents QueriesTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.QueriesTableAdapter
End Class
