<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_editar_custo_variavel
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
        Dim CodigoCVLabel As System.Windows.Forms.Label
        Dim ObservacaoLabel As System.Windows.Forms.Label
        Dim ValorLabel As System.Windows.Forms.Label
        Dim DataBaixaLabel As System.Windows.Forms.Label
        Dim DataEmissaoLabel As System.Windows.Forms.Label
        Dim DataCadastroLabel As System.Windows.Forms.Label
        Dim DataVencimentoLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_editar_custo_variavel))
        Me.Gerenciamento_CRAFIDataSet = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet()
        Me.CustoVariavelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustoVariavelTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.CustoVariavelTableAdapter()
        Me.TableAdapterManager = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager()
        Me.CustoVariavelBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.CustoVariavelBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CodigoCVTextBox = New System.Windows.Forms.TextBox()
        Me.ObservacaoTextBox = New System.Windows.Forms.TextBox()
        Me.ValorTextBox = New System.Windows.Forms.TextBox()
        Me.DataBaixaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DataEmissaoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DataCadastroTextBox = New System.Windows.Forms.TextBox()
        Me.DataVencimentoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.LogControleTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter()
        CodigoCVLabel = New System.Windows.Forms.Label()
        ObservacaoLabel = New System.Windows.Forms.Label()
        ValorLabel = New System.Windows.Forms.Label()
        DataBaixaLabel = New System.Windows.Forms.Label()
        DataEmissaoLabel = New System.Windows.Forms.Label()
        DataCadastroLabel = New System.Windows.Forms.Label()
        DataVencimentoLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustoVariavelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustoVariavelBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustoVariavelBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodigoCVLabel
        '
        CodigoCVLabel.AutoSize = True
        CodigoCVLabel.Location = New System.Drawing.Point(12, 37)
        CodigoCVLabel.Name = "CodigoCVLabel"
        CodigoCVLabel.Size = New System.Drawing.Size(114, 13)
        CodigoCVLabel.TabIndex = 1
        CodigoCVLabel.Text = "Código Custo Variável:"
        '
        'ObservacaoLabel
        '
        ObservacaoLabel.AutoSize = True
        ObservacaoLabel.Location = New System.Drawing.Point(58, 219)
        ObservacaoLabel.Name = "ObservacaoLabel"
        ObservacaoLabel.Size = New System.Drawing.Size(68, 13)
        ObservacaoLabel.TabIndex = 29
        ObservacaoLabel.Text = "Observação:"
        '
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.Location = New System.Drawing.Point(92, 193)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(34, 13)
        ValorLabel.TabIndex = 27
        ValorLabel.Text = "Valor:"
        '
        'DataBaixaLabel
        '
        DataBaixaLabel.AutoSize = True
        DataBaixaLabel.Location = New System.Drawing.Point(49, 168)
        DataBaixaLabel.Name = "DataBaixaLabel"
        DataBaixaLabel.Size = New System.Drawing.Size(77, 13)
        DataBaixaLabel.TabIndex = 25
        DataBaixaLabel.Text = "Data de Baixa:"
        '
        'DataEmissaoLabel
        '
        DataEmissaoLabel.AutoSize = True
        DataEmissaoLabel.Location = New System.Drawing.Point(36, 142)
        DataEmissaoLabel.Name = "DataEmissaoLabel"
        DataEmissaoLabel.Size = New System.Drawing.Size(90, 13)
        DataEmissaoLabel.TabIndex = 23
        DataEmissaoLabel.Text = "Data de Emissão:"
        '
        'DataCadastroLabel
        '
        DataCadastroLabel.AutoSize = True
        DataCadastroLabel.Location = New System.Drawing.Point(33, 115)
        DataCadastroLabel.Name = "DataCadastroLabel"
        DataCadastroLabel.Size = New System.Drawing.Size(93, 13)
        DataCadastroLabel.TabIndex = 21
        DataCadastroLabel.Text = "Data de Cadastro:"
        '
        'DataVencimentoLabel
        '
        DataVencimentoLabel.AutoSize = True
        DataVencimentoLabel.Location = New System.Drawing.Point(19, 90)
        DataVencimentoLabel.Name = "DataVencimentoLabel"
        DataVencimentoLabel.Size = New System.Drawing.Size(107, 13)
        DataVencimentoLabel.TabIndex = 19
        DataVencimentoLabel.Text = "Data de Vencimento:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(88, 63)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 17
        NomeLabel.Text = "Nome:"
        '
        'Gerenciamento_CRAFIDataSet
        '
        Me.Gerenciamento_CRAFIDataSet.DataSetName = "Gerenciamento_CRAFIDataSet"
        Me.Gerenciamento_CRAFIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustoVariavelBindingSource
        '
        Me.CustoVariavelBindingSource.DataMember = "CustoVariavel"
        Me.CustoVariavelBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'CustoVariavelTableAdapter
        '
        Me.CustoVariavelTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnamneseTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CirurgiasTableAdapter = Nothing
        Me.TableAdapterManager.ConsultasTableAdapter = Nothing
        Me.TableAdapterManager.ConveniosTableAdapter = Nothing
        Me.TableAdapterManager.CustoFixoTableAdapter = Nothing
        Me.TableAdapterManager.CustoVariavelTableAdapter = Me.CustoVariavelTableAdapter
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
        'CustoVariavelBindingNavigator
        '
        Me.CustoVariavelBindingNavigator.AddNewItem = Nothing
        Me.CustoVariavelBindingNavigator.BindingSource = Me.CustoVariavelBindingSource
        Me.CustoVariavelBindingNavigator.CountItem = Nothing
        Me.CustoVariavelBindingNavigator.DeleteItem = Nothing
        Me.CustoVariavelBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.CustoVariavelBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustoVariavelBindingNavigatorSaveItem})
        Me.CustoVariavelBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CustoVariavelBindingNavigator.MoveFirstItem = Nothing
        Me.CustoVariavelBindingNavigator.MoveLastItem = Nothing
        Me.CustoVariavelBindingNavigator.MoveNextItem = Nothing
        Me.CustoVariavelBindingNavigator.MovePreviousItem = Nothing
        Me.CustoVariavelBindingNavigator.Name = "CustoVariavelBindingNavigator"
        Me.CustoVariavelBindingNavigator.PositionItem = Nothing
        Me.CustoVariavelBindingNavigator.Size = New System.Drawing.Size(360, 25)
        Me.CustoVariavelBindingNavigator.TabIndex = 0
        Me.CustoVariavelBindingNavigator.Text = "BindingNavigator1"
        '
        'CustoVariavelBindingNavigatorSaveItem
        '
        Me.CustoVariavelBindingNavigatorSaveItem.Image = CType(resources.GetObject("CustoVariavelBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CustoVariavelBindingNavigatorSaveItem.Name = "CustoVariavelBindingNavigatorSaveItem"
        Me.CustoVariavelBindingNavigatorSaveItem.Size = New System.Drawing.Size(58, 22)
        Me.CustoVariavelBindingNavigatorSaveItem.Text = "Salvar"
        '
        'CodigoCVTextBox
        '
        Me.CodigoCVTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustoVariavelBindingSource, "CodigoCV", True))
        Me.CodigoCVTextBox.Enabled = False
        Me.CodigoCVTextBox.Location = New System.Drawing.Point(132, 34)
        Me.CodigoCVTextBox.Name = "CodigoCVTextBox"
        Me.CodigoCVTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodigoCVTextBox.TabIndex = 2
        '
        'ObservacaoTextBox
        '
        Me.ObservacaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustoVariavelBindingSource, "Observacao", True))
        Me.ObservacaoTextBox.Location = New System.Drawing.Point(132, 216)
        Me.ObservacaoTextBox.Multiline = True
        Me.ObservacaoTextBox.Name = "ObservacaoTextBox"
        Me.ObservacaoTextBox.Size = New System.Drawing.Size(216, 100)
        Me.ObservacaoTextBox.TabIndex = 30
        '
        'ValorTextBox
        '
        Me.ValorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustoVariavelBindingSource, "Valor", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.ValorTextBox.Location = New System.Drawing.Point(132, 190)
        Me.ValorTextBox.Name = "ValorTextBox"
        Me.ValorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ValorTextBox.TabIndex = 28
        '
        'DataBaixaDateTimePicker
        '
        Me.DataBaixaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustoVariavelBindingSource, "DataBaixa", True))
        Me.DataBaixaDateTimePicker.Location = New System.Drawing.Point(132, 164)
        Me.DataBaixaDateTimePicker.Name = "DataBaixaDateTimePicker"
        Me.DataBaixaDateTimePicker.Size = New System.Drawing.Size(216, 20)
        Me.DataBaixaDateTimePicker.TabIndex = 26
        '
        'DataEmissaoDateTimePicker
        '
        Me.DataEmissaoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustoVariavelBindingSource, "DataEmissao", True))
        Me.DataEmissaoDateTimePicker.Location = New System.Drawing.Point(132, 138)
        Me.DataEmissaoDateTimePicker.Name = "DataEmissaoDateTimePicker"
        Me.DataEmissaoDateTimePicker.Size = New System.Drawing.Size(216, 20)
        Me.DataEmissaoDateTimePicker.TabIndex = 24
        '
        'DataCadastroTextBox
        '
        Me.DataCadastroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustoVariavelBindingSource, "DataCadastro", True))
        Me.DataCadastroTextBox.Enabled = False
        Me.DataCadastroTextBox.Location = New System.Drawing.Point(132, 112)
        Me.DataCadastroTextBox.Name = "DataCadastroTextBox"
        Me.DataCadastroTextBox.Size = New System.Drawing.Size(216, 20)
        Me.DataCadastroTextBox.TabIndex = 22
        '
        'DataVencimentoDateTimePicker
        '
        Me.DataVencimentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustoVariavelBindingSource, "DataVencimento", True))
        Me.DataVencimentoDateTimePicker.Location = New System.Drawing.Point(132, 86)
        Me.DataVencimentoDateTimePicker.Name = "DataVencimentoDateTimePicker"
        Me.DataVencimentoDateTimePicker.Size = New System.Drawing.Size(216, 20)
        Me.DataVencimentoDateTimePicker.TabIndex = 20
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustoVariavelBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(132, 60)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(216, 20)
        Me.NomeTextBox.TabIndex = 18
        '
        'LogControleTableAdapter
        '
        Me.LogControleTableAdapter.ClearBeforeFill = True
        '
        'form_editar_custo_variavel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(360, 327)
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
        Me.Controls.Add(CodigoCVLabel)
        Me.Controls.Add(Me.CodigoCVTextBox)
        Me.Controls.Add(Me.CustoVariavelBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_editar_custo_variavel"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Custo Variável"
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustoVariavelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustoVariavelBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustoVariavelBindingNavigator.ResumeLayout(False)
        Me.CustoVariavelBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Gerenciamento_CRAFIDataSet As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet
    Friend WithEvents CustoVariavelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustoVariavelTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.CustoVariavelTableAdapter
    Friend WithEvents TableAdapterManager As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustoVariavelBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents CustoVariavelBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CodigoCVTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ObservacaoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ValorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataBaixaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataEmissaoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataCadastroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataVencimentoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LogControleTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter
End Class
