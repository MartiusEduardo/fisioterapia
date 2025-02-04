<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_editar_custo_fixo
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
        Dim CodigoCFLabel As System.Windows.Forms.Label
        Dim ObservacaoLabel As System.Windows.Forms.Label
        Dim ValorLabel As System.Windows.Forms.Label
        Dim DataBaixaLabel As System.Windows.Forms.Label
        Dim DataEmissaoLabel As System.Windows.Forms.Label
        Dim DataCadastroLabel As System.Windows.Forms.Label
        Dim DataVencimentoLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_editar_custo_fixo))
        Me.Gerenciamento_CRAFIDataSet = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet()
        Me.CustoFixoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustoFixoTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.CustoFixoTableAdapter()
        Me.TableAdapterManager = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager()
        Me.CustoFixoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.CustoFixoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CodigoCFTextBox = New System.Windows.Forms.TextBox()
        Me.ObservacaoTextBox = New System.Windows.Forms.TextBox()
        Me.ValorTextBox = New System.Windows.Forms.TextBox()
        Me.DataBaixaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DataEmissaoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DataCadastroTextBox = New System.Windows.Forms.TextBox()
        Me.DataVencimentoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.LogControleTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.NumMesesAFrenteToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.NumMesesAFrenteToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ReplicarToolStripButton = New System.Windows.Forms.ToolStripButton()
        CodigoCFLabel = New System.Windows.Forms.Label()
        ObservacaoLabel = New System.Windows.Forms.Label()
        ValorLabel = New System.Windows.Forms.Label()
        DataBaixaLabel = New System.Windows.Forms.Label()
        DataEmissaoLabel = New System.Windows.Forms.Label()
        DataCadastroLabel = New System.Windows.Forms.Label()
        DataVencimentoLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustoFixoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustoFixoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustoFixoBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodigoCFLabel
        '
        CodigoCFLabel.AutoSize = True
        CodigoCFLabel.Location = New System.Drawing.Point(12, 41)
        CodigoCFLabel.Name = "CodigoCFLabel"
        CodigoCFLabel.Size = New System.Drawing.Size(110, 13)
        CodigoCFLabel.TabIndex = 1
        CodigoCFLabel.Text = "Código do Custo Fixo:"
        '
        'ObservacaoLabel
        '
        ObservacaoLabel.AutoSize = True
        ObservacaoLabel.Location = New System.Drawing.Point(54, 223)
        ObservacaoLabel.Name = "ObservacaoLabel"
        ObservacaoLabel.Size = New System.Drawing.Size(68, 13)
        ObservacaoLabel.TabIndex = 29
        ObservacaoLabel.Text = "Observação:"
        '
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.Location = New System.Drawing.Point(88, 197)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(34, 13)
        ValorLabel.TabIndex = 27
        ValorLabel.Text = "Valor:"
        '
        'DataBaixaLabel
        '
        DataBaixaLabel.AutoSize = True
        DataBaixaLabel.Location = New System.Drawing.Point(45, 172)
        DataBaixaLabel.Name = "DataBaixaLabel"
        DataBaixaLabel.Size = New System.Drawing.Size(77, 13)
        DataBaixaLabel.TabIndex = 25
        DataBaixaLabel.Text = "Data de Baixa:"
        '
        'DataEmissaoLabel
        '
        DataEmissaoLabel.AutoSize = True
        DataEmissaoLabel.Location = New System.Drawing.Point(32, 146)
        DataEmissaoLabel.Name = "DataEmissaoLabel"
        DataEmissaoLabel.Size = New System.Drawing.Size(90, 13)
        DataEmissaoLabel.TabIndex = 23
        DataEmissaoLabel.Text = "Data de Emissao:"
        '
        'DataCadastroLabel
        '
        DataCadastroLabel.AutoSize = True
        DataCadastroLabel.Location = New System.Drawing.Point(29, 119)
        DataCadastroLabel.Name = "DataCadastroLabel"
        DataCadastroLabel.Size = New System.Drawing.Size(93, 13)
        DataCadastroLabel.TabIndex = 21
        DataCadastroLabel.Text = "Data de Cadastro:"
        '
        'DataVencimentoLabel
        '
        DataVencimentoLabel.AutoSize = True
        DataVencimentoLabel.Location = New System.Drawing.Point(15, 94)
        DataVencimentoLabel.Name = "DataVencimentoLabel"
        DataVencimentoLabel.Size = New System.Drawing.Size(107, 13)
        DataVencimentoLabel.TabIndex = 19
        DataVencimentoLabel.Text = "Data de Vencimento:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(84, 67)
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
        'CustoFixoBindingSource
        '
        Me.CustoFixoBindingSource.DataMember = "CustoFixo"
        Me.CustoFixoBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'CustoFixoTableAdapter
        '
        Me.CustoFixoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnamneseTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CirurgiasTableAdapter = Nothing
        Me.TableAdapterManager.ConsultasTableAdapter = Nothing
        Me.TableAdapterManager.ConveniosTableAdapter = Nothing
        Me.TableAdapterManager.CustoFixoTableAdapter = Me.CustoFixoTableAdapter
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
        'CustoFixoBindingNavigator
        '
        Me.CustoFixoBindingNavigator.AddNewItem = Nothing
        Me.CustoFixoBindingNavigator.BindingSource = Me.CustoFixoBindingSource
        Me.CustoFixoBindingNavigator.CountItem = Nothing
        Me.CustoFixoBindingNavigator.DeleteItem = Nothing
        Me.CustoFixoBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.CustoFixoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustoFixoBindingNavigatorSaveItem, Me.ToolStripSeparator1, Me.NumMesesAFrenteToolStripLabel, Me.NumMesesAFrenteToolStripTextBox, Me.ReplicarToolStripButton})
        Me.CustoFixoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CustoFixoBindingNavigator.MoveFirstItem = Nothing
        Me.CustoFixoBindingNavigator.MoveLastItem = Nothing
        Me.CustoFixoBindingNavigator.MoveNextItem = Nothing
        Me.CustoFixoBindingNavigator.MovePreviousItem = Nothing
        Me.CustoFixoBindingNavigator.Name = "CustoFixoBindingNavigator"
        Me.CustoFixoBindingNavigator.PositionItem = Nothing
        Me.CustoFixoBindingNavigator.Size = New System.Drawing.Size(360, 25)
        Me.CustoFixoBindingNavigator.TabIndex = 0
        Me.CustoFixoBindingNavigator.Text = "BindingNavigator1"
        '
        'CustoFixoBindingNavigatorSaveItem
        '
        Me.CustoFixoBindingNavigatorSaveItem.Image = CType(resources.GetObject("CustoFixoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CustoFixoBindingNavigatorSaveItem.Name = "CustoFixoBindingNavigatorSaveItem"
        Me.CustoFixoBindingNavigatorSaveItem.Size = New System.Drawing.Size(58, 22)
        Me.CustoFixoBindingNavigatorSaveItem.Text = "Salvar"
        '
        'CodigoCFTextBox
        '
        Me.CodigoCFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustoFixoBindingSource, "CodigoCF", True))
        Me.CodigoCFTextBox.Enabled = False
        Me.CodigoCFTextBox.Location = New System.Drawing.Point(128, 38)
        Me.CodigoCFTextBox.Name = "CodigoCFTextBox"
        Me.CodigoCFTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodigoCFTextBox.TabIndex = 2
        '
        'ObservacaoTextBox
        '
        Me.ObservacaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustoFixoBindingSource, "Observacao", True))
        Me.ObservacaoTextBox.Location = New System.Drawing.Point(128, 220)
        Me.ObservacaoTextBox.Multiline = True
        Me.ObservacaoTextBox.Name = "ObservacaoTextBox"
        Me.ObservacaoTextBox.Size = New System.Drawing.Size(218, 100)
        Me.ObservacaoTextBox.TabIndex = 30
        '
        'ValorTextBox
        '
        Me.ValorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustoFixoBindingSource, "Valor", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.ValorTextBox.Location = New System.Drawing.Point(128, 194)
        Me.ValorTextBox.Name = "ValorTextBox"
        Me.ValorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ValorTextBox.TabIndex = 28
        '
        'DataBaixaDateTimePicker
        '
        Me.DataBaixaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustoFixoBindingSource, "DataBaixa", True))
        Me.DataBaixaDateTimePicker.Location = New System.Drawing.Point(128, 168)
        Me.DataBaixaDateTimePicker.Name = "DataBaixaDateTimePicker"
        Me.DataBaixaDateTimePicker.Size = New System.Drawing.Size(218, 20)
        Me.DataBaixaDateTimePicker.TabIndex = 26
        '
        'DataEmissaoDateTimePicker
        '
        Me.DataEmissaoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustoFixoBindingSource, "DataEmissao", True))
        Me.DataEmissaoDateTimePicker.Location = New System.Drawing.Point(128, 142)
        Me.DataEmissaoDateTimePicker.Name = "DataEmissaoDateTimePicker"
        Me.DataEmissaoDateTimePicker.Size = New System.Drawing.Size(218, 20)
        Me.DataEmissaoDateTimePicker.TabIndex = 24
        '
        'DataCadastroTextBox
        '
        Me.DataCadastroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustoFixoBindingSource, "DataCadastro", True))
        Me.DataCadastroTextBox.Enabled = False
        Me.DataCadastroTextBox.Location = New System.Drawing.Point(128, 116)
        Me.DataCadastroTextBox.Name = "DataCadastroTextBox"
        Me.DataCadastroTextBox.Size = New System.Drawing.Size(218, 20)
        Me.DataCadastroTextBox.TabIndex = 22
        '
        'DataVencimentoDateTimePicker
        '
        Me.DataVencimentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustoFixoBindingSource, "DataVencimento", True))
        Me.DataVencimentoDateTimePicker.Location = New System.Drawing.Point(128, 90)
        Me.DataVencimentoDateTimePicker.Name = "DataVencimentoDateTimePicker"
        Me.DataVencimentoDateTimePicker.Size = New System.Drawing.Size(218, 20)
        Me.DataVencimentoDateTimePicker.TabIndex = 20
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustoFixoBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(128, 64)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(218, 20)
        Me.NomeTextBox.TabIndex = 18
        '
        'LogControleTableAdapter
        '
        Me.LogControleTableAdapter.ClearBeforeFill = True
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'NumMesesAFrenteToolStripLabel
        '
        Me.NumMesesAFrenteToolStripLabel.Name = "NumMesesAFrenteToolStripLabel"
        Me.NumMesesAFrenteToolStripLabel.Size = New System.Drawing.Size(136, 22)
        Me.NumMesesAFrenteToolStripLabel.Text = "Quantos meses à frente?"
        '
        'NumMesesAFrenteToolStripTextBox
        '
        Me.NumMesesAFrenteToolStripTextBox.Name = "NumMesesAFrenteToolStripTextBox"
        Me.NumMesesAFrenteToolStripTextBox.Size = New System.Drawing.Size(50, 25)
        '
        'ReplicarToolStripButton
        '
        Me.ReplicarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ReplicarToolStripButton.Image = CType(resources.GetObject("ReplicarToolStripButton.Image"), System.Drawing.Image)
        Me.ReplicarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ReplicarToolStripButton.Name = "ReplicarToolStripButton"
        Me.ReplicarToolStripButton.Size = New System.Drawing.Size(53, 22)
        Me.ReplicarToolStripButton.Text = "Replicar"
        '
        'form_editar_custo_fixo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(360, 331)
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
        Me.Controls.Add(CodigoCFLabel)
        Me.Controls.Add(Me.CodigoCFTextBox)
        Me.Controls.Add(Me.CustoFixoBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_editar_custo_fixo"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Custo Fixo"
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustoFixoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustoFixoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustoFixoBindingNavigator.ResumeLayout(False)
        Me.CustoFixoBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Gerenciamento_CRAFIDataSet As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet
    Friend WithEvents CustoFixoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustoFixoTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.CustoFixoTableAdapter
    Friend WithEvents TableAdapterManager As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustoFixoBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents CustoFixoBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CodigoCFTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ObservacaoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ValorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataBaixaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataEmissaoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataCadastroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataVencimentoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LogControleTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NumMesesAFrenteToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents NumMesesAFrenteToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ReplicarToolStripButton As System.Windows.Forms.ToolStripButton
End Class
