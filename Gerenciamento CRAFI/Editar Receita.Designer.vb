<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_editar_receita
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
        Dim ObservacaoLabel As System.Windows.Forms.Label
        Dim ValorLabel As System.Windows.Forms.Label
        Dim DataBaixaLabel As System.Windows.Forms.Label
        Dim DataEmissaoLabel As System.Windows.Forms.Label
        Dim DataCadastroLabel As System.Windows.Forms.Label
        Dim DataVencimentoLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim CodigoRLabel As System.Windows.Forms.Label
        Dim NomePacienteLabel As System.Windows.Forms.Label
        Dim NomeProfissionalLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_editar_receita))
        Me.DataCadastroTextBox = New System.Windows.Forms.TextBox()
        Me.ReceitaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gerenciamento_CRAFIDataSet = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet()
        Me.ObservacaoTextBox = New System.Windows.Forms.TextBox()
        Me.ValorTextBox = New System.Windows.Forms.TextBox()
        Me.DataBaixaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DataEmissaoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DataVencimentoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.ReceitaTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ReceitaTableAdapter()
        Me.TableAdapterManager = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager()
        Me.ReceitaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ReceitaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.LogControleTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter()
        Me.NomePacienteTextBox = New System.Windows.Forms.TextBox()
        Me.NomeProfissionalTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoRTextBox = New System.Windows.Forms.TextBox()
        ObservacaoLabel = New System.Windows.Forms.Label()
        ValorLabel = New System.Windows.Forms.Label()
        DataBaixaLabel = New System.Windows.Forms.Label()
        DataEmissaoLabel = New System.Windows.Forms.Label()
        DataCadastroLabel = New System.Windows.Forms.Label()
        DataVencimentoLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        CodigoRLabel = New System.Windows.Forms.Label()
        NomePacienteLabel = New System.Windows.Forms.Label()
        NomeProfissionalLabel = New System.Windows.Forms.Label()
        CType(Me.ReceitaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceitaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ReceitaBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ObservacaoLabel
        '
        ObservacaoLabel.AutoSize = True
        ObservacaoLabel.Location = New System.Drawing.Point(91, 277)
        ObservacaoLabel.Name = "ObservacaoLabel"
        ObservacaoLabel.Size = New System.Drawing.Size(68, 13)
        ObservacaoLabel.TabIndex = 31
        ObservacaoLabel.Text = "Observação:"
        '
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.Location = New System.Drawing.Point(125, 251)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(34, 13)
        ValorLabel.TabIndex = 29
        ValorLabel.Text = "Valor:"
        '
        'DataBaixaLabel
        '
        DataBaixaLabel.AutoSize = True
        DataBaixaLabel.Location = New System.Drawing.Point(82, 222)
        DataBaixaLabel.Name = "DataBaixaLabel"
        DataBaixaLabel.Size = New System.Drawing.Size(77, 13)
        DataBaixaLabel.TabIndex = 27
        DataBaixaLabel.Text = "Data de Baixa:"
        '
        'DataEmissaoLabel
        '
        DataEmissaoLabel.AutoSize = True
        DataEmissaoLabel.Location = New System.Drawing.Point(69, 196)
        DataEmissaoLabel.Name = "DataEmissaoLabel"
        DataEmissaoLabel.Size = New System.Drawing.Size(90, 13)
        DataEmissaoLabel.TabIndex = 25
        DataEmissaoLabel.Text = "Data de Emissão:"
        '
        'DataCadastroLabel
        '
        DataCadastroLabel.AutoSize = True
        DataCadastroLabel.Location = New System.Drawing.Point(66, 170)
        DataCadastroLabel.Name = "DataCadastroLabel"
        DataCadastroLabel.Size = New System.Drawing.Size(93, 13)
        DataCadastroLabel.TabIndex = 24
        DataCadastroLabel.Text = "Data de Cadastro:"
        '
        'DataVencimentoLabel
        '
        DataVencimentoLabel.AutoSize = True
        DataVencimentoLabel.Location = New System.Drawing.Point(52, 144)
        DataVencimentoLabel.Name = "DataVencimentoLabel"
        DataVencimentoLabel.Size = New System.Drawing.Size(107, 13)
        DataVencimentoLabel.TabIndex = 22
        DataVencimentoLabel.Text = "Data de Vencimento:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(12, 121)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(147, 13)
        NomeLabel.TabIndex = 20
        NomeLabel.Text = "Nome de Serviço ou Produto:"
        '
        'CodigoRLabel
        '
        CodigoRLabel.AutoSize = True
        CodigoRLabel.Location = New System.Drawing.Point(58, 43)
        CodigoRLabel.Name = "CodigoRLabel"
        CodigoRLabel.Size = New System.Drawing.Size(101, 13)
        CodigoRLabel.TabIndex = 34
        CodigoRLabel.Text = "Código de  Receita:"
        '
        'NomePacienteLabel
        '
        NomePacienteLabel.AutoSize = True
        NomePacienteLabel.Location = New System.Drawing.Point(61, 95)
        NomePacienteLabel.Name = "NomePacienteLabel"
        NomePacienteLabel.Size = New System.Drawing.Size(98, 13)
        NomePacienteLabel.TabIndex = 35
        NomePacienteLabel.Text = "Nome do Paciente:"
        '
        'NomeProfissionalLabel
        '
        NomeProfissionalLabel.AutoSize = True
        NomeProfissionalLabel.Location = New System.Drawing.Point(50, 69)
        NomeProfissionalLabel.Name = "NomeProfissionalLabel"
        NomeProfissionalLabel.Size = New System.Drawing.Size(109, 13)
        NomeProfissionalLabel.TabIndex = 36
        NomeProfissionalLabel.Text = "Nome do Profissional:"
        '
        'DataCadastroTextBox
        '
        Me.DataCadastroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceitaBindingSource, "DataCadastro", True))
        Me.DataCadastroTextBox.Enabled = False
        Me.DataCadastroTextBox.Location = New System.Drawing.Point(165, 170)
        Me.DataCadastroTextBox.Name = "DataCadastroTextBox"
        Me.DataCadastroTextBox.Size = New System.Drawing.Size(217, 20)
        Me.DataCadastroTextBox.TabIndex = 33
        '
        'ReceitaBindingSource
        '
        Me.ReceitaBindingSource.DataMember = "Receita"
        Me.ReceitaBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'Gerenciamento_CRAFIDataSet
        '
        Me.Gerenciamento_CRAFIDataSet.DataSetName = "Gerenciamento_CRAFIDataSet"
        Me.Gerenciamento_CRAFIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ObservacaoTextBox
        '
        Me.ObservacaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceitaBindingSource, "Observacao", True))
        Me.ObservacaoTextBox.Location = New System.Drawing.Point(165, 274)
        Me.ObservacaoTextBox.Multiline = True
        Me.ObservacaoTextBox.Name = "ObservacaoTextBox"
        Me.ObservacaoTextBox.Size = New System.Drawing.Size(217, 100)
        Me.ObservacaoTextBox.TabIndex = 32
        '
        'ValorTextBox
        '
        Me.ValorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceitaBindingSource, "Valor", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.ValorTextBox.Location = New System.Drawing.Point(165, 248)
        Me.ValorTextBox.Name = "ValorTextBox"
        Me.ValorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ValorTextBox.TabIndex = 30
        '
        'DataBaixaDateTimePicker
        '
        Me.DataBaixaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ReceitaBindingSource, "DataBaixa", True))
        Me.DataBaixaDateTimePicker.Location = New System.Drawing.Point(165, 222)
        Me.DataBaixaDateTimePicker.Name = "DataBaixaDateTimePicker"
        Me.DataBaixaDateTimePicker.Size = New System.Drawing.Size(217, 20)
        Me.DataBaixaDateTimePicker.TabIndex = 28
        '
        'DataEmissaoDateTimePicker
        '
        Me.DataEmissaoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ReceitaBindingSource, "DataEmissao", True))
        Me.DataEmissaoDateTimePicker.Location = New System.Drawing.Point(165, 196)
        Me.DataEmissaoDateTimePicker.Name = "DataEmissaoDateTimePicker"
        Me.DataEmissaoDateTimePicker.Size = New System.Drawing.Size(217, 20)
        Me.DataEmissaoDateTimePicker.TabIndex = 26
        '
        'DataVencimentoDateTimePicker
        '
        Me.DataVencimentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ReceitaBindingSource, "DataVencimento", True))
        Me.DataVencimentoDateTimePicker.Location = New System.Drawing.Point(165, 144)
        Me.DataVencimentoDateTimePicker.Name = "DataVencimentoDateTimePicker"
        Me.DataVencimentoDateTimePicker.Size = New System.Drawing.Size(217, 20)
        Me.DataVencimentoDateTimePicker.TabIndex = 23
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceitaBindingSource, "NomeServico", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(165, 118)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(217, 20)
        Me.NomeTextBox.TabIndex = 21
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
        Me.ReceitaBindingNavigator.CountItem = Nothing
        Me.ReceitaBindingNavigator.DeleteItem = Nothing
        Me.ReceitaBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ReceitaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReceitaBindingNavigatorSaveItem})
        Me.ReceitaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ReceitaBindingNavigator.MoveFirstItem = Nothing
        Me.ReceitaBindingNavigator.MoveLastItem = Nothing
        Me.ReceitaBindingNavigator.MoveNextItem = Nothing
        Me.ReceitaBindingNavigator.MovePreviousItem = Nothing
        Me.ReceitaBindingNavigator.Name = "ReceitaBindingNavigator"
        Me.ReceitaBindingNavigator.PositionItem = Nothing
        Me.ReceitaBindingNavigator.Size = New System.Drawing.Size(402, 25)
        Me.ReceitaBindingNavigator.TabIndex = 34
        Me.ReceitaBindingNavigator.Text = "BindingNavigator1"
        '
        'ReceitaBindingNavigatorSaveItem
        '
        Me.ReceitaBindingNavigatorSaveItem.Image = CType(resources.GetObject("ReceitaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ReceitaBindingNavigatorSaveItem.Name = "ReceitaBindingNavigatorSaveItem"
        Me.ReceitaBindingNavigatorSaveItem.Size = New System.Drawing.Size(58, 22)
        Me.ReceitaBindingNavigatorSaveItem.Text = "Salvar"
        '
        'LogControleTableAdapter
        '
        Me.LogControleTableAdapter.ClearBeforeFill = True
        '
        'NomePacienteTextBox
        '
        Me.NomePacienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceitaBindingSource, "NomePaciente", True))
        Me.NomePacienteTextBox.Location = New System.Drawing.Point(165, 92)
        Me.NomePacienteTextBox.Name = "NomePacienteTextBox"
        Me.NomePacienteTextBox.Size = New System.Drawing.Size(217, 20)
        Me.NomePacienteTextBox.TabIndex = 36
        '
        'NomeProfissionalTextBox
        '
        Me.NomeProfissionalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceitaBindingSource, "NomeProfissional", True))
        Me.NomeProfissionalTextBox.Location = New System.Drawing.Point(165, 66)
        Me.NomeProfissionalTextBox.Name = "NomeProfissionalTextBox"
        Me.NomeProfissionalTextBox.Size = New System.Drawing.Size(217, 20)
        Me.NomeProfissionalTextBox.TabIndex = 37
        '
        'CodigoRTextBox
        '
        Me.CodigoRTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceitaBindingSource, "CodigoR", True))
        Me.CodigoRTextBox.Enabled = False
        Me.CodigoRTextBox.Location = New System.Drawing.Point(165, 40)
        Me.CodigoRTextBox.Name = "CodigoRTextBox"
        Me.CodigoRTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodigoRTextBox.TabIndex = 38
        '
        'form_editar_receita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(402, 383)
        Me.Controls.Add(Me.CodigoRTextBox)
        Me.Controls.Add(NomeProfissionalLabel)
        Me.Controls.Add(Me.NomeProfissionalTextBox)
        Me.Controls.Add(NomePacienteLabel)
        Me.Controls.Add(Me.NomePacienteTextBox)
        Me.Controls.Add(CodigoRLabel)
        Me.Controls.Add(Me.ReceitaBindingNavigator)
        Me.Controls.Add(Me.DataCadastroTextBox)
        Me.Controls.Add(ObservacaoLabel)
        Me.Controls.Add(Me.ObservacaoTextBox)
        Me.Controls.Add(ValorLabel)
        Me.Controls.Add(Me.ValorTextBox)
        Me.Controls.Add(DataBaixaLabel)
        Me.Controls.Add(Me.DataBaixaDateTimePicker)
        Me.Controls.Add(DataEmissaoLabel)
        Me.Controls.Add(Me.DataEmissaoDateTimePicker)
        Me.Controls.Add(DataCadastroLabel)
        Me.Controls.Add(DataVencimentoLabel)
        Me.Controls.Add(Me.DataVencimentoDateTimePicker)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_editar_receita"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Receita"
        CType(Me.ReceitaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceitaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ReceitaBindingNavigator.ResumeLayout(False)
        Me.ReceitaBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataCadastroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ObservacaoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ValorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataBaixaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataEmissaoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataVencimentoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Gerenciamento_CRAFIDataSet As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet
    Friend WithEvents ReceitaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReceitaTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ReceitaTableAdapter
    Friend WithEvents TableAdapterManager As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ReceitaBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents ReceitaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents LogControleTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter
    Friend WithEvents NomePacienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeProfissionalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodigoRTextBox As System.Windows.Forms.TextBox
End Class
