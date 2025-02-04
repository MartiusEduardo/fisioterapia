<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_incluir_despesa_variavel
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
        Dim CodigoDVLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim DataVencimentoLabel As System.Windows.Forms.Label
        Dim DataCadastroLabel As System.Windows.Forms.Label
        Dim DataEmissaoLabel As System.Windows.Forms.Label
        Dim DataBaixaLabel As System.Windows.Forms.Label
        Dim ValorLabel As System.Windows.Forms.Label
        Dim ObservacaoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_incluir_despesa_variavel))
        Me.Gerenciamento_CRAFIDataSet = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet()
        Me.DespesaVariavelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DespesaVariavelTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.DespesaVariavelTableAdapter()
        Me.TableAdapterManager = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager()
        Me.DespesaVariavelBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.AdicionarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DespesaVariavelBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CancelarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CodigoDVTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.DataVencimentoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DataCadastroTextBox = New System.Windows.Forms.TextBox()
        Me.DataEmissaoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DataBaixaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ValorTextBox = New System.Windows.Forms.TextBox()
        Me.ObservacaoTextBox = New System.Windows.Forms.TextBox()
        Me.LogControleTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter()
        CodigoDVLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        DataVencimentoLabel = New System.Windows.Forms.Label()
        DataCadastroLabel = New System.Windows.Forms.Label()
        DataEmissaoLabel = New System.Windows.Forms.Label()
        DataBaixaLabel = New System.Windows.Forms.Label()
        ValorLabel = New System.Windows.Forms.Label()
        ObservacaoLabel = New System.Windows.Forms.Label()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DespesaVariavelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DespesaVariavelBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DespesaVariavelBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodigoDVLabel
        '
        CodigoDVLabel.AutoSize = True
        CodigoDVLabel.Location = New System.Drawing.Point(12, 35)
        CodigoDVLabel.Name = "CodigoDVLabel"
        CodigoDVLabel.Size = New System.Drawing.Size(129, 13)
        CodigoDVLabel.TabIndex = 1
        CodigoDVLabel.Text = "Código Despesa Variável:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(103, 61)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 3
        NomeLabel.Text = "Nome:"
        '
        'DataVencimentoLabel
        '
        DataVencimentoLabel.AutoSize = True
        DataVencimentoLabel.Location = New System.Drawing.Point(34, 88)
        DataVencimentoLabel.Name = "DataVencimentoLabel"
        DataVencimentoLabel.Size = New System.Drawing.Size(107, 13)
        DataVencimentoLabel.TabIndex = 5
        DataVencimentoLabel.Text = "Data de Vencimento:"
        '
        'DataCadastroLabel
        '
        DataCadastroLabel.AutoSize = True
        DataCadastroLabel.Location = New System.Drawing.Point(48, 113)
        DataCadastroLabel.Name = "DataCadastroLabel"
        DataCadastroLabel.Size = New System.Drawing.Size(93, 13)
        DataCadastroLabel.TabIndex = 7
        DataCadastroLabel.Text = "Data de Cadastro:"
        '
        'DataEmissaoLabel
        '
        DataEmissaoLabel.AutoSize = True
        DataEmissaoLabel.Location = New System.Drawing.Point(51, 140)
        DataEmissaoLabel.Name = "DataEmissaoLabel"
        DataEmissaoLabel.Size = New System.Drawing.Size(90, 13)
        DataEmissaoLabel.TabIndex = 9
        DataEmissaoLabel.Text = "Data de Emissão:"
        '
        'DataBaixaLabel
        '
        DataBaixaLabel.AutoSize = True
        DataBaixaLabel.Location = New System.Drawing.Point(64, 166)
        DataBaixaLabel.Name = "DataBaixaLabel"
        DataBaixaLabel.Size = New System.Drawing.Size(77, 13)
        DataBaixaLabel.TabIndex = 11
        DataBaixaLabel.Text = "Data de Baixa:"
        '
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.Location = New System.Drawing.Point(107, 191)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(34, 13)
        ValorLabel.TabIndex = 13
        ValorLabel.Text = "Valor:"
        '
        'ObservacaoLabel
        '
        ObservacaoLabel.AutoSize = True
        ObservacaoLabel.Location = New System.Drawing.Point(73, 217)
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
        Me.DespesaVariavelBindingNavigator.CountItem = Nothing
        Me.DespesaVariavelBindingNavigator.DeleteItem = Nothing
        Me.DespesaVariavelBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.DespesaVariavelBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdicionarToolStripButton, Me.DespesaVariavelBindingNavigatorSaveItem, Me.CancelarToolStripButton})
        Me.DespesaVariavelBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DespesaVariavelBindingNavigator.MoveFirstItem = Nothing
        Me.DespesaVariavelBindingNavigator.MoveLastItem = Nothing
        Me.DespesaVariavelBindingNavigator.MoveNextItem = Nothing
        Me.DespesaVariavelBindingNavigator.MovePreviousItem = Nothing
        Me.DespesaVariavelBindingNavigator.Name = "DespesaVariavelBindingNavigator"
        Me.DespesaVariavelBindingNavigator.PositionItem = Nothing
        Me.DespesaVariavelBindingNavigator.Size = New System.Drawing.Size(380, 25)
        Me.DespesaVariavelBindingNavigator.TabIndex = 0
        Me.DespesaVariavelBindingNavigator.Text = "BindingNavigator1"
        '
        'AdicionarToolStripButton
        '
        Me.AdicionarToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources.Button_White_Add
        Me.AdicionarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AdicionarToolStripButton.Name = "AdicionarToolStripButton"
        Me.AdicionarToolStripButton.Size = New System.Drawing.Size(78, 22)
        Me.AdicionarToolStripButton.Text = "Adicionar"
        '
        'DespesaVariavelBindingNavigatorSaveItem
        '
        Me.DespesaVariavelBindingNavigatorSaveItem.Enabled = False
        Me.DespesaVariavelBindingNavigatorSaveItem.Image = CType(resources.GetObject("DespesaVariavelBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DespesaVariavelBindingNavigatorSaveItem.Name = "DespesaVariavelBindingNavigatorSaveItem"
        Me.DespesaVariavelBindingNavigatorSaveItem.Size = New System.Drawing.Size(58, 22)
        Me.DespesaVariavelBindingNavigatorSaveItem.Text = "Salvar"
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
        'CodigoDVTextBox
        '
        Me.CodigoDVTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DespesaVariavelBindingSource, "CodigoDV", True))
        Me.CodigoDVTextBox.Enabled = False
        Me.CodigoDVTextBox.Location = New System.Drawing.Point(147, 32)
        Me.CodigoDVTextBox.Name = "CodigoDVTextBox"
        Me.CodigoDVTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodigoDVTextBox.TabIndex = 2
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DespesaVariavelBindingSource, "Nome", True))
        Me.NomeTextBox.Enabled = False
        Me.NomeTextBox.Location = New System.Drawing.Point(147, 58)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(215, 20)
        Me.NomeTextBox.TabIndex = 4
        '
        'DataVencimentoDateTimePicker
        '
        Me.DataVencimentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DespesaVariavelBindingSource, "DataVencimento", True))
        Me.DataVencimentoDateTimePicker.Enabled = False
        Me.DataVencimentoDateTimePicker.Location = New System.Drawing.Point(147, 84)
        Me.DataVencimentoDateTimePicker.Name = "DataVencimentoDateTimePicker"
        Me.DataVencimentoDateTimePicker.Size = New System.Drawing.Size(215, 20)
        Me.DataVencimentoDateTimePicker.TabIndex = 6
        '
        'DataCadastroTextBox
        '
        Me.DataCadastroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DespesaVariavelBindingSource, "DataCadastro", True))
        Me.DataCadastroTextBox.Enabled = False
        Me.DataCadastroTextBox.Location = New System.Drawing.Point(147, 110)
        Me.DataCadastroTextBox.Name = "DataCadastroTextBox"
        Me.DataCadastroTextBox.Size = New System.Drawing.Size(215, 20)
        Me.DataCadastroTextBox.TabIndex = 8
        '
        'DataEmissaoDateTimePicker
        '
        Me.DataEmissaoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DespesaVariavelBindingSource, "DataEmissao", True))
        Me.DataEmissaoDateTimePicker.Enabled = False
        Me.DataEmissaoDateTimePicker.Location = New System.Drawing.Point(147, 136)
        Me.DataEmissaoDateTimePicker.Name = "DataEmissaoDateTimePicker"
        Me.DataEmissaoDateTimePicker.Size = New System.Drawing.Size(215, 20)
        Me.DataEmissaoDateTimePicker.TabIndex = 10
        '
        'DataBaixaDateTimePicker
        '
        Me.DataBaixaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DespesaVariavelBindingSource, "DataBaixa", True))
        Me.DataBaixaDateTimePicker.Enabled = False
        Me.DataBaixaDateTimePicker.Location = New System.Drawing.Point(147, 162)
        Me.DataBaixaDateTimePicker.Name = "DataBaixaDateTimePicker"
        Me.DataBaixaDateTimePicker.Size = New System.Drawing.Size(215, 20)
        Me.DataBaixaDateTimePicker.TabIndex = 12
        '
        'ValorTextBox
        '
        Me.ValorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DespesaVariavelBindingSource, "Valor", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.ValorTextBox.Enabled = False
        Me.ValorTextBox.Location = New System.Drawing.Point(147, 188)
        Me.ValorTextBox.Name = "ValorTextBox"
        Me.ValorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ValorTextBox.TabIndex = 14
        '
        'ObservacaoTextBox
        '
        Me.ObservacaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DespesaVariavelBindingSource, "Observacao", True))
        Me.ObservacaoTextBox.Enabled = False
        Me.ObservacaoTextBox.Location = New System.Drawing.Point(147, 214)
        Me.ObservacaoTextBox.Multiline = True
        Me.ObservacaoTextBox.Name = "ObservacaoTextBox"
        Me.ObservacaoTextBox.Size = New System.Drawing.Size(215, 100)
        Me.ObservacaoTextBox.TabIndex = 16
        '
        'LogControleTableAdapter
        '
        Me.LogControleTableAdapter.ClearBeforeFill = True
        '
        'form_incluir_despesa_variavel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(380, 331)
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
        Me.Controls.Add(CodigoDVLabel)
        Me.Controls.Add(Me.CodigoDVTextBox)
        Me.Controls.Add(Me.DespesaVariavelBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_incluir_despesa_variavel"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Incluir Despesa Variável"
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DespesaVariavelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DespesaVariavelBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DespesaVariavelBindingNavigator.ResumeLayout(False)
        Me.DespesaVariavelBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Gerenciamento_CRAFIDataSet As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet
    Friend WithEvents DespesaVariavelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DespesaVariavelTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.DespesaVariavelTableAdapter
    Friend WithEvents TableAdapterManager As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DespesaVariavelBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents DespesaVariavelBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CodigoDVTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataVencimentoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataCadastroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataEmissaoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataBaixaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ValorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ObservacaoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AdicionarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CancelarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents LogControleTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter
End Class
