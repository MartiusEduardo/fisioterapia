<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_incluir_despesa_fixa
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
        Dim CodigoDFLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim DataVencimentoLabel As System.Windows.Forms.Label
        Dim DataCadastroLabel As System.Windows.Forms.Label
        Dim DataEmissaoLabel As System.Windows.Forms.Label
        Dim DataBaixaLabel As System.Windows.Forms.Label
        Dim ValorLabel As System.Windows.Forms.Label
        Dim ObservacaoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_incluir_despesa_fixa))
        Me.Gerenciamento_CRAFIDataSet = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet()
        Me.DespesaFixaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DespesaFixaTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.DespesaFixaTableAdapter()
        Me.TableAdapterManager = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager()
        Me.DespesaFixaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.AdicionarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DespesaFixaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CancelarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.NumMesesAFrenteToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.NumMesesAFrenteToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ReplicarDFToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CodigoDFTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.DataVencimentoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DataCadastroTextBox = New System.Windows.Forms.TextBox()
        Me.DataEmissaoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DataBaixaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ValorTextBox = New System.Windows.Forms.TextBox()
        Me.ObservacaoTextBox = New System.Windows.Forms.TextBox()
        Me.LogControleTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter()
        CodigoDFLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        DataVencimentoLabel = New System.Windows.Forms.Label()
        DataCadastroLabel = New System.Windows.Forms.Label()
        DataEmissaoLabel = New System.Windows.Forms.Label()
        DataBaixaLabel = New System.Windows.Forms.Label()
        ValorLabel = New System.Windows.Forms.Label()
        ObservacaoLabel = New System.Windows.Forms.Label()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DespesaFixaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DespesaFixaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DespesaFixaBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodigoDFLabel
        '
        CodigoDFLabel.AutoSize = True
        CodigoDFLabel.Location = New System.Drawing.Point(12, 35)
        CodigoDFLabel.Name = "CodigoDFLabel"
        CodigoDFLabel.Size = New System.Drawing.Size(110, 13)
        CodigoDFLabel.TabIndex = 1
        CodigoDFLabel.Text = "Código Despesa Fixa:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(84, 61)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 3
        NomeLabel.Text = "Nome:"
        '
        'DataVencimentoLabel
        '
        DataVencimentoLabel.AutoSize = True
        DataVencimentoLabel.Location = New System.Drawing.Point(15, 88)
        DataVencimentoLabel.Name = "DataVencimentoLabel"
        DataVencimentoLabel.Size = New System.Drawing.Size(107, 13)
        DataVencimentoLabel.TabIndex = 5
        DataVencimentoLabel.Text = "Data de Vencimento:"
        '
        'DataCadastroLabel
        '
        DataCadastroLabel.AutoSize = True
        DataCadastroLabel.Location = New System.Drawing.Point(29, 113)
        DataCadastroLabel.Name = "DataCadastroLabel"
        DataCadastroLabel.Size = New System.Drawing.Size(93, 13)
        DataCadastroLabel.TabIndex = 7
        DataCadastroLabel.Text = "Data de Cadastro:"
        '
        'DataEmissaoLabel
        '
        DataEmissaoLabel.AutoSize = True
        DataEmissaoLabel.Location = New System.Drawing.Point(32, 140)
        DataEmissaoLabel.Name = "DataEmissaoLabel"
        DataEmissaoLabel.Size = New System.Drawing.Size(90, 13)
        DataEmissaoLabel.TabIndex = 9
        DataEmissaoLabel.Text = "Data de Emissão:"
        '
        'DataBaixaLabel
        '
        DataBaixaLabel.AutoSize = True
        DataBaixaLabel.Location = New System.Drawing.Point(45, 166)
        DataBaixaLabel.Name = "DataBaixaLabel"
        DataBaixaLabel.Size = New System.Drawing.Size(77, 13)
        DataBaixaLabel.TabIndex = 11
        DataBaixaLabel.Text = "Data de Baixa:"
        '
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.Location = New System.Drawing.Point(88, 191)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(34, 13)
        ValorLabel.TabIndex = 13
        ValorLabel.Text = "Valor:"
        '
        'ObservacaoLabel
        '
        ObservacaoLabel.AutoSize = True
        ObservacaoLabel.Location = New System.Drawing.Point(54, 217)
        ObservacaoLabel.Name = "ObservacaoLabel"
        ObservacaoLabel.Size = New System.Drawing.Size(68, 13)
        ObservacaoLabel.TabIndex = 15
        ObservacaoLabel.Text = "Observação:"
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
        Me.DespesaFixaBindingNavigator.CountItem = Nothing
        Me.DespesaFixaBindingNavigator.DeleteItem = Nothing
        Me.DespesaFixaBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.DespesaFixaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdicionarToolStripButton, Me.DespesaFixaBindingNavigatorSaveItem, Me.CancelarToolStripButton, Me.ToolStripSeparator1, Me.NumMesesAFrenteToolStripLabel, Me.NumMesesAFrenteToolStripTextBox, Me.ReplicarDFToolStripButton})
        Me.DespesaFixaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DespesaFixaBindingNavigator.MoveFirstItem = Nothing
        Me.DespesaFixaBindingNavigator.MoveLastItem = Nothing
        Me.DespesaFixaBindingNavigator.MoveNextItem = Nothing
        Me.DespesaFixaBindingNavigator.MovePreviousItem = Nothing
        Me.DespesaFixaBindingNavigator.Name = "DespesaFixaBindingNavigator"
        Me.DespesaFixaBindingNavigator.PositionItem = Nothing
        Me.DespesaFixaBindingNavigator.Size = New System.Drawing.Size(362, 25)
        Me.DespesaFixaBindingNavigator.TabIndex = 0
        Me.DespesaFixaBindingNavigator.Text = "BindingNavigator1"
        '
        'AdicionarToolStripButton
        '
        Me.AdicionarToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources.Button_White_Add
        Me.AdicionarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AdicionarToolStripButton.Name = "AdicionarToolStripButton"
        Me.AdicionarToolStripButton.Size = New System.Drawing.Size(78, 22)
        Me.AdicionarToolStripButton.Text = "Adicionar"
        '
        'DespesaFixaBindingNavigatorSaveItem
        '
        Me.DespesaFixaBindingNavigatorSaveItem.Enabled = False
        Me.DespesaFixaBindingNavigatorSaveItem.Image = CType(resources.GetObject("DespesaFixaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DespesaFixaBindingNavigatorSaveItem.Name = "DespesaFixaBindingNavigatorSaveItem"
        Me.DespesaFixaBindingNavigatorSaveItem.Size = New System.Drawing.Size(58, 22)
        Me.DespesaFixaBindingNavigatorSaveItem.Text = "Salvar"
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'NumMesesAFrenteToolStripLabel
        '
        Me.NumMesesAFrenteToolStripLabel.Name = "NumMesesAFrenteToolStripLabel"
        Me.NumMesesAFrenteToolStripLabel.Size = New System.Drawing.Size(136, 15)
        Me.NumMesesAFrenteToolStripLabel.Text = "Quantos meses à frente?"
        Me.NumMesesAFrenteToolStripLabel.Visible = False
        '
        'NumMesesAFrenteToolStripTextBox
        '
        Me.NumMesesAFrenteToolStripTextBox.Name = "NumMesesAFrenteToolStripTextBox"
        Me.NumMesesAFrenteToolStripTextBox.Size = New System.Drawing.Size(50, 25)
        Me.NumMesesAFrenteToolStripTextBox.Visible = False
        '
        'ReplicarDFToolStripButton
        '
        Me.ReplicarDFToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ReplicarDFToolStripButton.Image = CType(resources.GetObject("ReplicarDFToolStripButton.Image"), System.Drawing.Image)
        Me.ReplicarDFToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ReplicarDFToolStripButton.Name = "ReplicarDFToolStripButton"
        Me.ReplicarDFToolStripButton.Size = New System.Drawing.Size(53, 22)
        Me.ReplicarDFToolStripButton.Text = "Replicar"
        Me.ReplicarDFToolStripButton.Visible = False
        '
        'CodigoDFTextBox
        '
        Me.CodigoDFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DespesaFixaBindingSource, "CodigoDF", True))
        Me.CodigoDFTextBox.Enabled = False
        Me.CodigoDFTextBox.Location = New System.Drawing.Point(128, 32)
        Me.CodigoDFTextBox.Name = "CodigoDFTextBox"
        Me.CodigoDFTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodigoDFTextBox.TabIndex = 2
        Me.CodigoDFTextBox.Tag = "N"
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DespesaFixaBindingSource, "Nome", True))
        Me.NomeTextBox.Enabled = False
        Me.NomeTextBox.Location = New System.Drawing.Point(128, 58)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(224, 20)
        Me.NomeTextBox.TabIndex = 4
        '
        'DataVencimentoDateTimePicker
        '
        Me.DataVencimentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DespesaFixaBindingSource, "DataVencimento", True))
        Me.DataVencimentoDateTimePicker.Enabled = False
        Me.DataVencimentoDateTimePicker.Location = New System.Drawing.Point(128, 84)
        Me.DataVencimentoDateTimePicker.Name = "DataVencimentoDateTimePicker"
        Me.DataVencimentoDateTimePicker.Size = New System.Drawing.Size(224, 20)
        Me.DataVencimentoDateTimePicker.TabIndex = 6
        '
        'DataCadastroTextBox
        '
        Me.DataCadastroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DespesaFixaBindingSource, "DataCadastro", True))
        Me.DataCadastroTextBox.Enabled = False
        Me.DataCadastroTextBox.Location = New System.Drawing.Point(128, 110)
        Me.DataCadastroTextBox.Name = "DataCadastroTextBox"
        Me.DataCadastroTextBox.Size = New System.Drawing.Size(224, 20)
        Me.DataCadastroTextBox.TabIndex = 8
        Me.DataCadastroTextBox.Tag = "N"
        '
        'DataEmissaoDateTimePicker
        '
        Me.DataEmissaoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DespesaFixaBindingSource, "DataEmissao", True))
        Me.DataEmissaoDateTimePicker.Enabled = False
        Me.DataEmissaoDateTimePicker.Location = New System.Drawing.Point(128, 136)
        Me.DataEmissaoDateTimePicker.Name = "DataEmissaoDateTimePicker"
        Me.DataEmissaoDateTimePicker.Size = New System.Drawing.Size(224, 20)
        Me.DataEmissaoDateTimePicker.TabIndex = 10
        '
        'DataBaixaDateTimePicker
        '
        Me.DataBaixaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DespesaFixaBindingSource, "DataBaixa", True))
        Me.DataBaixaDateTimePicker.Enabled = False
        Me.DataBaixaDateTimePicker.Location = New System.Drawing.Point(128, 162)
        Me.DataBaixaDateTimePicker.Name = "DataBaixaDateTimePicker"
        Me.DataBaixaDateTimePicker.Size = New System.Drawing.Size(224, 20)
        Me.DataBaixaDateTimePicker.TabIndex = 12
        '
        'ValorTextBox
        '
        Me.ValorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DespesaFixaBindingSource, "Valor", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.ValorTextBox.Enabled = False
        Me.ValorTextBox.Location = New System.Drawing.Point(128, 188)
        Me.ValorTextBox.Name = "ValorTextBox"
        Me.ValorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ValorTextBox.TabIndex = 14
        '
        'ObservacaoTextBox
        '
        Me.ObservacaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DespesaFixaBindingSource, "Observacao", True))
        Me.ObservacaoTextBox.Enabled = False
        Me.ObservacaoTextBox.Location = New System.Drawing.Point(128, 214)
        Me.ObservacaoTextBox.Multiline = True
        Me.ObservacaoTextBox.Name = "ObservacaoTextBox"
        Me.ObservacaoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ObservacaoTextBox.Size = New System.Drawing.Size(224, 100)
        Me.ObservacaoTextBox.TabIndex = 16
        '
        'LogControleTableAdapter
        '
        Me.LogControleTableAdapter.ClearBeforeFill = True
        '
        'form_incluir_despesa_fixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(362, 326)
        Me.Controls.Add(ObservacaoLabel)
        Me.Controls.Add(Me.ObservacaoTextBox)
        Me.Controls.Add(ValorLabel)
        Me.Controls.Add(Me.ValorTextBox)
        Me.Controls.Add(DataBaixaLabel)
        Me.Controls.Add(Me.DataBaixaDateTimePicker)
        Me.Controls.Add(DataEmissaoLabel)
        Me.Controls.Add(Me.DataEmissaoDateTimePicker)
        Me.Controls.Add(DataCadastroLabel)
        Me.Controls.Add(Me.DataCadastroTextBox)
        Me.Controls.Add(DataVencimentoLabel)
        Me.Controls.Add(Me.DataVencimentoDateTimePicker)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(CodigoDFLabel)
        Me.Controls.Add(Me.CodigoDFTextBox)
        Me.Controls.Add(Me.DespesaFixaBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_incluir_despesa_fixa"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Despesa Fixa"
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DespesaFixaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DespesaFixaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DespesaFixaBindingNavigator.ResumeLayout(False)
        Me.DespesaFixaBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Gerenciamento_CRAFIDataSet As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet
    Friend WithEvents DespesaFixaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DespesaFixaTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.DespesaFixaTableAdapter
    Friend WithEvents TableAdapterManager As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DespesaFixaBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents DespesaFixaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AdicionarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CancelarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CodigoDFTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataVencimentoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataCadastroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataEmissaoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataBaixaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ValorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ObservacaoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LogControleTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NumMesesAFrenteToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents NumMesesAFrenteToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ReplicarDFToolStripButton As System.Windows.Forms.ToolStripButton
End Class
