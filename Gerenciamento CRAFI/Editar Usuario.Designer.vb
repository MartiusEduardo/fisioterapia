<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_editar_usuario
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
        Dim UsuarioLabel As System.Windows.Forms.Label
        Dim SenhaLabel As System.Windows.Forms.Label
        Dim TipoLabel As System.Windows.Forms.Label
        Dim AssinaturaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_editar_usuario))
        Me.Gerenciamento_CRAFIDataSet = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet()
        Me.LoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoginTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LoginTableAdapter()
        Me.TableAdapterManager = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager()
        Me.LoginBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.LoginBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.SenhaTextBox = New System.Windows.Forms.TextBox()
        Me.TipoComboBox = New System.Windows.Forms.ComboBox()
        Me.LogControleTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter()
        Me.AssinaturaTextBox = New System.Windows.Forms.TextBox()
        UsuarioLabel = New System.Windows.Forms.Label()
        SenhaLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        AssinaturaLabel = New System.Windows.Forms.Label()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LoginBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'UsuarioLabel
        '
        UsuarioLabel.AutoSize = True
        UsuarioLabel.Location = New System.Drawing.Point(25, 32)
        UsuarioLabel.Name = "UsuarioLabel"
        UsuarioLabel.Size = New System.Drawing.Size(46, 13)
        UsuarioLabel.TabIndex = 1
        UsuarioLabel.Text = "Usuário:"
        '
        'SenhaLabel
        '
        SenhaLabel.AutoSize = True
        SenhaLabel.Location = New System.Drawing.Point(30, 58)
        SenhaLabel.Name = "SenhaLabel"
        SenhaLabel.Size = New System.Drawing.Size(41, 13)
        SenhaLabel.TabIndex = 3
        SenhaLabel.Text = "Senha:"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Location = New System.Drawing.Point(40, 84)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(31, 13)
        TipoLabel.TabIndex = 5
        TipoLabel.Text = "Tipo:"
        '
        'AssinaturaLabel
        '
        AssinaturaLabel.AutoSize = True
        AssinaturaLabel.Location = New System.Drawing.Point(12, 111)
        AssinaturaLabel.Name = "AssinaturaLabel"
        AssinaturaLabel.Size = New System.Drawing.Size(59, 13)
        AssinaturaLabel.TabIndex = 7
        AssinaturaLabel.Text = "Assinatura:"
        '
        'Gerenciamento_CRAFIDataSet
        '
        Me.Gerenciamento_CRAFIDataSet.DataSetName = "Gerenciamento_CRAFIDataSet"
        Me.Gerenciamento_CRAFIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LoginBindingSource
        '
        Me.LoginBindingSource.DataMember = "Login"
        Me.LoginBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'LoginTableAdapter
        '
        Me.LoginTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.LoginTableAdapter = Me.LoginTableAdapter
        Me.TableAdapterManager.PacientesTableAdapter = Nothing
        Me.TableAdapterManager.ProfissionaisTableAdapter = Nothing
        Me.TableAdapterManager.ReceitaTableAdapter = Nothing
        Me.TableAdapterManager.ServicosConveniosTableAdapter = Nothing
        Me.TableAdapterManager.ServicosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LoginBindingNavigator
        '
        Me.LoginBindingNavigator.AddNewItem = Nothing
        Me.LoginBindingNavigator.BindingSource = Me.LoginBindingSource
        Me.LoginBindingNavigator.CountItem = Nothing
        Me.LoginBindingNavigator.DeleteItem = Nothing
        Me.LoginBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.LoginBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginBindingNavigatorSaveItem})
        Me.LoginBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.LoginBindingNavigator.MoveFirstItem = Nothing
        Me.LoginBindingNavigator.MoveLastItem = Nothing
        Me.LoginBindingNavigator.MoveNextItem = Nothing
        Me.LoginBindingNavigator.MovePreviousItem = Nothing
        Me.LoginBindingNavigator.Name = "LoginBindingNavigator"
        Me.LoginBindingNavigator.PositionItem = Nothing
        Me.LoginBindingNavigator.Size = New System.Drawing.Size(286, 25)
        Me.LoginBindingNavigator.TabIndex = 0
        Me.LoginBindingNavigator.Text = "BindingNavigator1"
        '
        'LoginBindingNavigatorSaveItem
        '
        Me.LoginBindingNavigatorSaveItem.Image = CType(resources.GetObject("LoginBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.LoginBindingNavigatorSaveItem.Name = "LoginBindingNavigatorSaveItem"
        Me.LoginBindingNavigatorSaveItem.Size = New System.Drawing.Size(58, 22)
        Me.LoginBindingNavigatorSaveItem.Text = "Salvar"
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoginBindingSource, "Usuario", True))
        Me.UsuarioTextBox.Location = New System.Drawing.Point(77, 29)
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.Size = New System.Drawing.Size(200, 20)
        Me.UsuarioTextBox.TabIndex = 2
        '
        'SenhaTextBox
        '
        Me.SenhaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoginBindingSource, "Senha", True))
        Me.SenhaTextBox.Location = New System.Drawing.Point(77, 55)
        Me.SenhaTextBox.Name = "SenhaTextBox"
        Me.SenhaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SenhaTextBox.TabIndex = 4
        '
        'TipoComboBox
        '
        Me.TipoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoginBindingSource, "Tipo", True))
        Me.TipoComboBox.FormattingEnabled = True
        Me.TipoComboBox.Location = New System.Drawing.Point(77, 81)
        Me.TipoComboBox.Name = "TipoComboBox"
        Me.TipoComboBox.Size = New System.Drawing.Size(200, 21)
        Me.TipoComboBox.TabIndex = 6
        '
        'LogControleTableAdapter
        '
        Me.LogControleTableAdapter.ClearBeforeFill = True
        '
        'AssinaturaTextBox
        '
        Me.AssinaturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoginBindingSource, "Assinatura", True))
        Me.AssinaturaTextBox.Location = New System.Drawing.Point(77, 108)
        Me.AssinaturaTextBox.Name = "AssinaturaTextBox"
        Me.AssinaturaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AssinaturaTextBox.TabIndex = 8
        '
        'form_editar_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(286, 137)
        Me.Controls.Add(AssinaturaLabel)
        Me.Controls.Add(Me.AssinaturaTextBox)
        Me.Controls.Add(TipoLabel)
        Me.Controls.Add(Me.TipoComboBox)
        Me.Controls.Add(SenhaLabel)
        Me.Controls.Add(Me.SenhaTextBox)
        Me.Controls.Add(UsuarioLabel)
        Me.Controls.Add(Me.UsuarioTextBox)
        Me.Controls.Add(Me.LoginBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_editar_usuario"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Usuário"
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LoginBindingNavigator.ResumeLayout(False)
        Me.LoginBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Gerenciamento_CRAFIDataSet As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet
    Friend WithEvents LoginBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LoginTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LoginTableAdapter
    Friend WithEvents TableAdapterManager As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LoginBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents LoginBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents UsuarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SenhaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TipoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents LogControleTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter
    Friend WithEvents AssinaturaTextBox As System.Windows.Forms.TextBox
End Class
