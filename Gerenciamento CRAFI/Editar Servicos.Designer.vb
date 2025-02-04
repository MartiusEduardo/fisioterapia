<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_editar_servicos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_editar_servicos))
        Me.Gerenciamento_CRAFIDataSet = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet()
        Me.ServicosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServicosTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ServicosTableAdapter()
        Me.TableAdapterManager = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager()
        Me.ServicosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.BuscaToolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.ImprimirToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.NomeToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.NomeToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.CodigoToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CodigoToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ValorUnitarioToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ValorUnitarioToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.BuscarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ServicosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServicosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServicosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ServicosBindingNavigator.SuspendLayout()
        CType(Me.ServicosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.ServicosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ServicosBindingNavigator.DeleteItem = Nothing
        Me.ServicosBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ServicosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.AtualizarToolStripButton, Me.BuscaToolStripSeparator, Me.ImprimirToolStripButton, Me.ToolStripSeparator1, Me.NomeToolStripLabel, Me.NomeToolStripTextBox, Me.CodigoToolStripLabel, Me.CodigoToolStripTextBox, Me.ValorUnitarioToolStripLabel, Me.ValorUnitarioToolStripTextBox, Me.BuscarToolStripButton})
        Me.ServicosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ServicosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ServicosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ServicosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ServicosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ServicosBindingNavigator.Name = "ServicosBindingNavigator"
        Me.ServicosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ServicosBindingNavigator.Size = New System.Drawing.Size(718, 25)
        Me.ServicosBindingNavigator.TabIndex = 0
        Me.ServicosBindingNavigator.Text = "BindingNavigator1"
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
        'BuscaToolStripSeparator
        '
        Me.BuscaToolStripSeparator.Name = "BuscaToolStripSeparator"
        Me.BuscaToolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'ImprimirToolStripButton
        '
        Me.ImprimirToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources._9854_32x32
        Me.ImprimirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImprimirToolStripButton.Name = "ImprimirToolStripButton"
        Me.ImprimirToolStripButton.Size = New System.Drawing.Size(73, 22)
        Me.ImprimirToolStripButton.Text = "Imprimir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'NomeToolStripLabel
        '
        Me.NomeToolStripLabel.Name = "NomeToolStripLabel"
        Me.NomeToolStripLabel.Size = New System.Drawing.Size(43, 22)
        Me.NomeToolStripLabel.Text = "Nome:"
        '
        'NomeToolStripTextBox
        '
        Me.NomeToolStripTextBox.Name = "NomeToolStripTextBox"
        Me.NomeToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'CodigoToolStripLabel
        '
        Me.CodigoToolStripLabel.Name = "CodigoToolStripLabel"
        Me.CodigoToolStripLabel.Size = New System.Drawing.Size(49, 22)
        Me.CodigoToolStripLabel.Text = "Código:"
        '
        'CodigoToolStripTextBox
        '
        Me.CodigoToolStripTextBox.Name = "CodigoToolStripTextBox"
        Me.CodigoToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'ValorUnitarioToolStripLabel
        '
        Me.ValorUnitarioToolStripLabel.Name = "ValorUnitarioToolStripLabel"
        Me.ValorUnitarioToolStripLabel.Size = New System.Drawing.Size(82, 15)
        Me.ValorUnitarioToolStripLabel.Text = "Valor Unitário:"
        '
        'ValorUnitarioToolStripTextBox
        '
        Me.ValorUnitarioToolStripTextBox.Name = "ValorUnitarioToolStripTextBox"
        Me.ValorUnitarioToolStripTextBox.Size = New System.Drawing.Size(100, 23)
        '
        'BuscarToolStripButton
        '
        Me.BuscarToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources._4998_32x32
        Me.BuscarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BuscarToolStripButton.Name = "BuscarToolStripButton"
        Me.BuscarToolStripButton.Size = New System.Drawing.Size(62, 20)
        Me.BuscarToolStripButton.Text = "Buscar"
        '
        'ServicosDataGridView
        '
        Me.ServicosDataGridView.AllowUserToAddRows = False
        Me.ServicosDataGridView.AllowUserToDeleteRows = False
        Me.ServicosDataGridView.AutoGenerateColumns = False
        Me.ServicosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ServicosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.ServicosDataGridView.DataSource = Me.ServicosBindingSource
        Me.ServicosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ServicosDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.ServicosDataGridView.Name = "ServicosDataGridView"
        Me.ServicosDataGridView.ReadOnly = True
        Me.ServicosDataGridView.RowHeadersVisible = False
        Me.ServicosDataGridView.Size = New System.Drawing.Size(718, 289)
        Me.ServicosDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Nome"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 200
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ProfissionaisHabilitados"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Profissionais Habilitados"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Codigo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ValorUnitario"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Valor Unitário"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Observacoes"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Observações"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 200
        '
        'form_editar_servicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 314)
        Me.Controls.Add(Me.ServicosDataGridView)
        Me.Controls.Add(Me.ServicosBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_editar_servicos"
        Me.ShowIcon = False
        Me.Text = "Editar Serviços"
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServicosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServicosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ServicosBindingNavigator.ResumeLayout(False)
        Me.ServicosBindingNavigator.PerformLayout()
        CType(Me.ServicosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Gerenciamento_CRAFIDataSet As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet
    Friend WithEvents ServicosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ServicosTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ServicosTableAdapter
    Friend WithEvents TableAdapterManager As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ServicosBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ServicosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents AtualizarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BuscaToolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NomeToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents NomeToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents CodigoToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CodigoToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ValorUnitarioToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ValorUnitarioToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BuscarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ImprimirToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
