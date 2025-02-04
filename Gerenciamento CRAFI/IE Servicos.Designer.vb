<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_incluir_servicos
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
        Dim NomeLabel As System.Windows.Forms.Label
        Dim ProfissionaisHabilitadosLabel As System.Windows.Forms.Label
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim ValorUnitarioLabel As System.Windows.Forms.Label
        Dim ObservacoesLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_incluir_servicos))
        Me.Gerenciamento_CRAFIDataSet = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet()
        Me.ServicosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServicosTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ServicosTableAdapter()
        Me.TableAdapterManager = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager()
        Me.ServicosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.AdicionarServicosToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ServicosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CancelarServicosToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImprimirToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.ProfissionaisHabilitadosTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.ValorUnitarioTextBox = New System.Windows.Forms.TextBox()
        Me.ObservacoesTextBox = New System.Windows.Forms.TextBox()
        Me.LogControleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LogControleTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter()
        NomeLabel = New System.Windows.Forms.Label()
        ProfissionaisHabilitadosLabel = New System.Windows.Forms.Label()
        CodigoLabel = New System.Windows.Forms.Label()
        ValorUnitarioLabel = New System.Windows.Forms.Label()
        ObservacoesLabel = New System.Windows.Forms.Label()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServicosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServicosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ServicosBindingNavigator.SuspendLayout()
        CType(Me.LogControleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(97, 40)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 1
        NomeLabel.Text = "Nome:"
        '
        'ProfissionaisHabilitadosLabel
        '
        ProfissionaisHabilitadosLabel.AutoSize = True
        ProfissionaisHabilitadosLabel.Location = New System.Drawing.Point(12, 66)
        ProfissionaisHabilitadosLabel.Name = "ProfissionaisHabilitadosLabel"
        ProfissionaisHabilitadosLabel.Size = New System.Drawing.Size(123, 13)
        ProfissionaisHabilitadosLabel.TabIndex = 3
        ProfissionaisHabilitadosLabel.Text = "Profissionais Habilitados:"
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(92, 172)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(43, 13)
        CodigoLabel.TabIndex = 5
        CodigoLabel.Text = "Código:"
        '
        'ValorUnitarioLabel
        '
        ValorUnitarioLabel.AutoSize = True
        ValorUnitarioLabel.Location = New System.Drawing.Point(62, 198)
        ValorUnitarioLabel.Name = "ValorUnitarioLabel"
        ValorUnitarioLabel.Size = New System.Drawing.Size(73, 13)
        ValorUnitarioLabel.TabIndex = 7
        ValorUnitarioLabel.Text = "Valor Unitário:"
        '
        'ObservacoesLabel
        '
        ObservacoesLabel.AutoSize = True
        ObservacoesLabel.Location = New System.Drawing.Point(62, 224)
        ObservacoesLabel.Name = "ObservacoesLabel"
        ObservacoesLabel.Size = New System.Drawing.Size(73, 13)
        ObservacoesLabel.TabIndex = 9
        ObservacoesLabel.Text = "Observações:"
        '
        'Gerenciamento_CRAFIDataSet
        '
        Me.Gerenciamento_CRAFIDataSet.DataSetName = "Gerenciamento_CRAFIDataSet"
        Me.Gerenciamento_CRAFIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ServicosBindingSource
        '
        Me.ServicosBindingSource.DataMember = "Servicos"
        Me.ServicosBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'ServicosTableAdapter
        '
        Me.ServicosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.ReceitaTableAdapter = Nothing
        Me.TableAdapterManager.ServicosConveniosTableAdapter = Nothing
        Me.TableAdapterManager.ServicosTableAdapter = Me.ServicosTableAdapter
        Me.TableAdapterManager.UpdateOrder = Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ServicosBindingNavigator
        '
        Me.ServicosBindingNavigator.AddNewItem = Nothing
        Me.ServicosBindingNavigator.BindingSource = Me.ServicosBindingSource
        Me.ServicosBindingNavigator.CountItem = Nothing
        Me.ServicosBindingNavigator.DeleteItem = Nothing
        Me.ServicosBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ServicosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdicionarServicosToolStripButton, Me.ServicosBindingNavigatorSaveItem, Me.CancelarServicosToolStripButton, Me.ToolStripSeparator1, Me.ImprimirToolStripButton})
        Me.ServicosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ServicosBindingNavigator.MoveFirstItem = Nothing
        Me.ServicosBindingNavigator.MoveLastItem = Nothing
        Me.ServicosBindingNavigator.MoveNextItem = Nothing
        Me.ServicosBindingNavigator.MovePreviousItem = Nothing
        Me.ServicosBindingNavigator.Name = "ServicosBindingNavigator"
        Me.ServicosBindingNavigator.PositionItem = Nothing
        Me.ServicosBindingNavigator.Size = New System.Drawing.Size(411, 25)
        Me.ServicosBindingNavigator.TabIndex = 0
        Me.ServicosBindingNavigator.Text = "BindingNavigator1"
        '
        'AdicionarServicosToolStripButton
        '
        Me.AdicionarServicosToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources.Button_White_Add
        Me.AdicionarServicosToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AdicionarServicosToolStripButton.Name = "AdicionarServicosToolStripButton"
        Me.AdicionarServicosToolStripButton.Size = New System.Drawing.Size(78, 22)
        Me.AdicionarServicosToolStripButton.Text = "Adicionar"
        '
        'ServicosBindingNavigatorSaveItem
        '
        Me.ServicosBindingNavigatorSaveItem.Enabled = False
        Me.ServicosBindingNavigatorSaveItem.Image = CType(resources.GetObject("ServicosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ServicosBindingNavigatorSaveItem.Name = "ServicosBindingNavigatorSaveItem"
        Me.ServicosBindingNavigatorSaveItem.Size = New System.Drawing.Size(58, 22)
        Me.ServicosBindingNavigatorSaveItem.Text = "Salvar"
        '
        'CancelarServicosToolStripButton
        '
        Me.CancelarServicosToolStripButton.Enabled = False
        Me.CancelarServicosToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources.Button_White_Stop
        Me.CancelarServicosToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CancelarServicosToolStripButton.Name = "CancelarServicosToolStripButton"
        Me.CancelarServicosToolStripButton.Size = New System.Drawing.Size(73, 22)
        Me.CancelarServicosToolStripButton.Text = "Cancelar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ImprimirToolStripButton
        '
        Me.ImprimirToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources._9854_32x32
        Me.ImprimirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImprimirToolStripButton.Name = "ImprimirToolStripButton"
        Me.ImprimirToolStripButton.Size = New System.Drawing.Size(73, 22)
        Me.ImprimirToolStripButton.Text = "Imprimir"
        Me.ImprimirToolStripButton.Visible = False
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServicosBindingSource, "Nome", True))
        Me.NomeTextBox.Enabled = False
        Me.NomeTextBox.Location = New System.Drawing.Point(141, 37)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(250, 20)
        Me.NomeTextBox.TabIndex = 2
        '
        'ProfissionaisHabilitadosTextBox
        '
        Me.ProfissionaisHabilitadosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServicosBindingSource, "ProfissionaisHabilitados", True))
        Me.ProfissionaisHabilitadosTextBox.Enabled = False
        Me.ProfissionaisHabilitadosTextBox.Location = New System.Drawing.Point(141, 63)
        Me.ProfissionaisHabilitadosTextBox.Multiline = True
        Me.ProfissionaisHabilitadosTextBox.Name = "ProfissionaisHabilitadosTextBox"
        Me.ProfissionaisHabilitadosTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ProfissionaisHabilitadosTextBox.Size = New System.Drawing.Size(250, 100)
        Me.ProfissionaisHabilitadosTextBox.TabIndex = 4
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServicosBindingSource, "Codigo", True))
        Me.CodigoTextBox.Enabled = False
        Me.CodigoTextBox.Location = New System.Drawing.Point(141, 169)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(250, 20)
        Me.CodigoTextBox.TabIndex = 6
        '
        'ValorUnitarioTextBox
        '
        Me.ValorUnitarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServicosBindingSource, "ValorUnitario", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.ValorUnitarioTextBox.Enabled = False
        Me.ValorUnitarioTextBox.Location = New System.Drawing.Point(141, 195)
        Me.ValorUnitarioTextBox.Name = "ValorUnitarioTextBox"
        Me.ValorUnitarioTextBox.Size = New System.Drawing.Size(250, 20)
        Me.ValorUnitarioTextBox.TabIndex = 8
        '
        'ObservacoesTextBox
        '
        Me.ObservacoesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServicosBindingSource, "Observacoes", True))
        Me.ObservacoesTextBox.Enabled = False
        Me.ObservacoesTextBox.Location = New System.Drawing.Point(141, 221)
        Me.ObservacoesTextBox.Multiline = True
        Me.ObservacoesTextBox.Name = "ObservacoesTextBox"
        Me.ObservacoesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ObservacoesTextBox.Size = New System.Drawing.Size(250, 100)
        Me.ObservacoesTextBox.TabIndex = 10
        '
        'LogControleBindingSource
        '
        Me.LogControleBindingSource.DataMember = "LogControle"
        Me.LogControleBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'LogControleTableAdapter
        '
        Me.LogControleTableAdapter.ClearBeforeFill = True
        '
        'form_incluir_servicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(411, 335)
        Me.Controls.Add(ObservacoesLabel)
        Me.Controls.Add(Me.ObservacoesTextBox)
        Me.Controls.Add(ValorUnitarioLabel)
        Me.Controls.Add(Me.ValorUnitarioTextBox)
        Me.Controls.Add(CodigoLabel)
        Me.Controls.Add(Me.CodigoTextBox)
        Me.Controls.Add(ProfissionaisHabilitadosLabel)
        Me.Controls.Add(Me.ProfissionaisHabilitadosTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(Me.ServicosBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_incluir_servicos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Serviços"
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServicosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServicosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ServicosBindingNavigator.ResumeLayout(False)
        Me.ServicosBindingNavigator.PerformLayout()
        CType(Me.LogControleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Gerenciamento_CRAFIDataSet As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet
    Friend WithEvents ServicosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ServicosTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ServicosTableAdapter
    Friend WithEvents TableAdapterManager As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ServicosBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents ServicosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProfissionaisHabilitadosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodigoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ValorUnitarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AdicionarServicosToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CancelarServicosToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ObservacoesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LogControleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LogControleTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImprimirToolStripButton As System.Windows.Forms.ToolStripButton
End Class
