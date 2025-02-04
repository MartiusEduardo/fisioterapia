<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_exames_complementares
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
        Dim DescricaoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_exames_complementares))
        Me.Gerenciamento_CRAFIDataSet = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet()
        Me.ExamesComplementaresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExamesComplementaresTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ExamesComplementaresTableAdapter()
        Me.TableAdapterManager = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager()
        Me.ExamesComplementaresBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.AdicionarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ExamesComplementaresBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CancelarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.NumeroProntuarioTextBox = New System.Windows.Forms.TextBox()
        Me.DescricaoTextBox = New System.Windows.Forms.TextBox()
        Me.ExamesComplementaresDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ExameComplementarPictureBox = New System.Windows.Forms.PictureBox()
        Me.btnInserirImagem = New System.Windows.Forms.Button()
        Me.OFDExamesComplementares = New System.Windows.Forms.OpenFileDialog()
        Me.QueriesTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.QueriesTableAdapter()
        CodigoLabel = New System.Windows.Forms.Label()
        NumeroProntuarioLabel = New System.Windows.Forms.Label()
        DescricaoLabel = New System.Windows.Forms.Label()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamesComplementaresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamesComplementaresBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ExamesComplementaresBindingNavigator.SuspendLayout()
        CType(Me.ExamesComplementaresDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExameComplementarPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(82, 48)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(43, 13)
        CodigoLabel.TabIndex = 1
        CodigoLabel.Text = "Código:"
        '
        'NumeroProntuarioLabel
        '
        NumeroProntuarioLabel.AutoSize = True
        NumeroProntuarioLabel.Location = New System.Drawing.Point(12, 74)
        NumeroProntuarioLabel.Name = "NumeroProntuarioLabel"
        NumeroProntuarioLabel.Size = New System.Drawing.Size(113, 13)
        NumeroProntuarioLabel.TabIndex = 3
        NumeroProntuarioLabel.Text = "Número do Prontuário:"
        '
        'DescricaoLabel
        '
        DescricaoLabel.AutoSize = True
        DescricaoLabel.Location = New System.Drawing.Point(67, 100)
        DescricaoLabel.Name = "DescricaoLabel"
        DescricaoLabel.Size = New System.Drawing.Size(58, 13)
        DescricaoLabel.TabIndex = 5
        DescricaoLabel.Text = "Descrição:"
        '
        'Gerenciamento_CRAFIDataSet
        '
        Me.Gerenciamento_CRAFIDataSet.DataSetName = "Gerenciamento_CRAFIDataSet"
        Me.Gerenciamento_CRAFIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ExamesComplementaresBindingSource
        '
        Me.ExamesComplementaresBindingSource.DataMember = "ExamesComplementares"
        Me.ExamesComplementaresBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'ExamesComplementaresTableAdapter
        '
        Me.ExamesComplementaresTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.ExamesComplementaresTableAdapter = Me.ExamesComplementaresTableAdapter
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
        'ExamesComplementaresBindingNavigator
        '
        Me.ExamesComplementaresBindingNavigator.AddNewItem = Nothing
        Me.ExamesComplementaresBindingNavigator.BindingSource = Me.ExamesComplementaresBindingSource
        Me.ExamesComplementaresBindingNavigator.CountItem = Nothing
        Me.ExamesComplementaresBindingNavigator.DeleteItem = Nothing
        Me.ExamesComplementaresBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ExamesComplementaresBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdicionarToolStripButton, Me.ExamesComplementaresBindingNavigatorSaveItem, Me.CancelarToolStripButton})
        Me.ExamesComplementaresBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ExamesComplementaresBindingNavigator.MoveFirstItem = Nothing
        Me.ExamesComplementaresBindingNavigator.MoveLastItem = Nothing
        Me.ExamesComplementaresBindingNavigator.MoveNextItem = Nothing
        Me.ExamesComplementaresBindingNavigator.MovePreviousItem = Nothing
        Me.ExamesComplementaresBindingNavigator.Name = "ExamesComplementaresBindingNavigator"
        Me.ExamesComplementaresBindingNavigator.PositionItem = Nothing
        Me.ExamesComplementaresBindingNavigator.Size = New System.Drawing.Size(1080, 25)
        Me.ExamesComplementaresBindingNavigator.TabIndex = 0
        Me.ExamesComplementaresBindingNavigator.Text = "BindingNavigator1"
        '
        'AdicionarToolStripButton
        '
        Me.AdicionarToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources.Button_White_Add
        Me.AdicionarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AdicionarToolStripButton.Name = "AdicionarToolStripButton"
        Me.AdicionarToolStripButton.Size = New System.Drawing.Size(78, 22)
        Me.AdicionarToolStripButton.Text = "Adicionar"
        '
        'ExamesComplementaresBindingNavigatorSaveItem
        '
        Me.ExamesComplementaresBindingNavigatorSaveItem.Enabled = False
        Me.ExamesComplementaresBindingNavigatorSaveItem.Image = CType(resources.GetObject("ExamesComplementaresBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ExamesComplementaresBindingNavigatorSaveItem.Name = "ExamesComplementaresBindingNavigatorSaveItem"
        Me.ExamesComplementaresBindingNavigatorSaveItem.Size = New System.Drawing.Size(58, 22)
        Me.ExamesComplementaresBindingNavigatorSaveItem.Text = "Salvar"
        '
        'CancelarToolStripButton
        '
        Me.CancelarToolStripButton.Enabled = False
        Me.CancelarToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources.Button_White_Stop
        Me.CancelarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CancelarToolStripButton.Name = "CancelarToolStripButton"
        Me.CancelarToolStripButton.Size = New System.Drawing.Size(73, 22)
        Me.CancelarToolStripButton.Text = "Cancelar"
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExamesComplementaresBindingSource, "Codigo", True))
        Me.CodigoTextBox.Location = New System.Drawing.Point(131, 45)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodigoTextBox.TabIndex = 2
        Me.CodigoTextBox.Tag = "N"
        '
        'NumeroProntuarioTextBox
        '
        Me.NumeroProntuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExamesComplementaresBindingSource, "NumeroProntuario", True))
        Me.NumeroProntuarioTextBox.Location = New System.Drawing.Point(131, 71)
        Me.NumeroProntuarioTextBox.Name = "NumeroProntuarioTextBox"
        Me.NumeroProntuarioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NumeroProntuarioTextBox.TabIndex = 4
        Me.NumeroProntuarioTextBox.Tag = "N"
        '
        'DescricaoTextBox
        '
        Me.DescricaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExamesComplementaresBindingSource, "Descricao", True))
        Me.DescricaoTextBox.Location = New System.Drawing.Point(131, 97)
        Me.DescricaoTextBox.Multiline = True
        Me.DescricaoTextBox.Name = "DescricaoTextBox"
        Me.DescricaoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.DescricaoTextBox.Size = New System.Drawing.Size(524, 106)
        Me.DescricaoTextBox.TabIndex = 6
        '
        'ExamesComplementaresDataGridView
        '
        Me.ExamesComplementaresDataGridView.AllowUserToAddRows = False
        Me.ExamesComplementaresDataGridView.AllowUserToDeleteRows = False
        Me.ExamesComplementaresDataGridView.AutoGenerateColumns = False
        Me.ExamesComplementaresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ExamesComplementaresDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewImageColumn1})
        Me.ExamesComplementaresDataGridView.DataSource = Me.ExamesComplementaresBindingSource
        Me.ExamesComplementaresDataGridView.Location = New System.Drawing.Point(0, 209)
        Me.ExamesComplementaresDataGridView.Name = "ExamesComplementaresDataGridView"
        Me.ExamesComplementaresDataGridView.ReadOnly = True
        Me.ExamesComplementaresDataGridView.RowHeadersVisible = False
        Me.ExamesComplementaresDataGridView.Size = New System.Drawing.Size(655, 206)
        Me.ExamesComplementaresDataGridView.TabIndex = 7
        Me.ExamesComplementaresDataGridView.Tag = ""
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Descricao"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Descrição"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "Imagem"
        Me.DataGridViewImageColumn1.HeaderText = "Imagem"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        '
        'ExameComplementarPictureBox
        '
        Me.ExameComplementarPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ExamesComplementaresBindingSource, "Imagem", True))
        Me.ExameComplementarPictureBox.Location = New System.Drawing.Point(661, 45)
        Me.ExameComplementarPictureBox.Name = "ExameComplementarPictureBox"
        Me.ExameComplementarPictureBox.Size = New System.Drawing.Size(419, 370)
        Me.ExameComplementarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ExameComplementarPictureBox.TabIndex = 8
        Me.ExameComplementarPictureBox.TabStop = False
        '
        'btnInserirImagem
        '
        Me.btnInserirImagem.Location = New System.Drawing.Point(572, 69)
        Me.btnInserirImagem.Name = "btnInserirImagem"
        Me.btnInserirImagem.Size = New System.Drawing.Size(83, 23)
        Me.btnInserirImagem.TabIndex = 9
        Me.btnInserirImagem.Text = "Inserir Imagem"
        Me.btnInserirImagem.UseVisualStyleBackColor = True
        '
        'OFDExamesComplementares
        '
        Me.OFDExamesComplementares.FileName = "OFDExamesComplementares"
        '
        'form_exames_complementares
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(769, 273)
        Me.Controls.Add(Me.btnInserirImagem)
        Me.Controls.Add(Me.ExameComplementarPictureBox)
        Me.Controls.Add(Me.ExamesComplementaresDataGridView)
        Me.Controls.Add(CodigoLabel)
        Me.Controls.Add(Me.CodigoTextBox)
        Me.Controls.Add(NumeroProntuarioLabel)
        Me.Controls.Add(Me.NumeroProntuarioTextBox)
        Me.Controls.Add(DescricaoLabel)
        Me.Controls.Add(Me.DescricaoTextBox)
        Me.Controls.Add(Me.ExamesComplementaresBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_exames_complementares"
        Me.ShowIcon = False
        Me.Text = "Exames Complementares"
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamesComplementaresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamesComplementaresBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ExamesComplementaresBindingNavigator.ResumeLayout(False)
        Me.ExamesComplementaresBindingNavigator.PerformLayout()
        CType(Me.ExamesComplementaresDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExameComplementarPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Gerenciamento_CRAFIDataSet As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet
    Friend WithEvents ExamesComplementaresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ExamesComplementaresTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ExamesComplementaresTableAdapter
    Friend WithEvents TableAdapterManager As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ExamesComplementaresBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents ExamesComplementaresBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CodigoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NumeroProntuarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescricaoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExamesComplementaresDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents ExameComplementarPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents AdicionarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CancelarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnInserirImagem As System.Windows.Forms.Button
    Friend WithEvents OFDExamesComplementares As System.Windows.Forms.OpenFileDialog
    Friend WithEvents QueriesTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.QueriesTableAdapter
End Class
