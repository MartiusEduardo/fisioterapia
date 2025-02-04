<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_incluir_usuario
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
        Dim AssinaturaLabel As System.Windows.Forms.Label
        Dim TipoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_incluir_usuario))
        Me.Gerenciamento_CRAFIDataSet = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet()
        Me.LoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoginTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LoginTableAdapter()
        Me.TableAdapterManager = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager()
        Me.LoginBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.AdicionarUsuarioToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.LoginBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CancelarUsuarioToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.SenhaTextBox = New System.Windows.Forms.TextBox()
        Me.LogControleTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter()
        Me.AssinaturaTextBox = New System.Windows.Forms.TextBox()
        Me.GrupoUsuario = New System.Windows.Forms.GroupBox()
        Me.UsuarioExcluirCheckBox = New System.Windows.Forms.CheckBox()
        Me.UsuarioEditarCheckBox = New System.Windows.Forms.CheckBox()
        Me.UsuarioNovoCheckBox = New System.Windows.Forms.CheckBox()
        Me.GrupoServicos = New System.Windows.Forms.GroupBox()
        Me.ServicosExcluirCheckBox = New System.Windows.Forms.CheckBox()
        Me.ServicosIncluirCheckBox = New System.Windows.Forms.CheckBox()
        Me.ServicosEditarCheckBox = New System.Windows.Forms.CheckBox()
        Me.ConvenioIncluirCheckBox = New System.Windows.Forms.CheckBox()
        Me.ConvenioEditarCheckBox = New System.Windows.Forms.CheckBox()
        Me.ConvenioExcluirCheckBox = New System.Windows.Forms.CheckBox()
        Me.GrupoConvenio = New System.Windows.Forms.GroupBox()
        Me.ProfissionalIncluirCheckBox = New System.Windows.Forms.CheckBox()
        Me.ProfissionalEditarCheckBox = New System.Windows.Forms.CheckBox()
        Me.ProfissionalExcluirCheckBox = New System.Windows.Forms.CheckBox()
        Me.GrupoProfissional = New System.Windows.Forms.GroupBox()
        Me.PacienteIncluirCheckBox = New System.Windows.Forms.CheckBox()
        Me.PacienteEditarCheckBox = New System.Windows.Forms.CheckBox()
        Me.PacienteExcluirCheckBox = New System.Windows.Forms.CheckBox()
        Me.GrupoPaciente = New System.Windows.Forms.GroupBox()
        Me.ConsultaAgendaCheckBox = New System.Windows.Forms.CheckBox()
        Me.AnamneseCheckBox = New System.Windows.Forms.CheckBox()
        Me.GrupoEvolucaoClinica = New System.Windows.Forms.GroupBox()
        Me.ECEvolucaoClinicaPacientesCheckBox = New System.Windows.Forms.CheckBox()
        Me.ECPesquisarCheckBox = New System.Windows.Forms.CheckBox()
        Me.FinancasReceitaCheckBox = New System.Windows.Forms.CheckBox()
        Me.GrupoFinancas = New System.Windows.Forms.GroupBox()
        Me.FinancasDRECheckBox = New System.Windows.Forms.CheckBox()
        Me.FinancasImpostosCheckBox = New System.Windows.Forms.CheckBox()
        Me.FinancasCustoFixoCheckBox = New System.Windows.Forms.CheckBox()
        Me.FinancasDespesaVariavelCheckBox = New System.Windows.Forms.CheckBox()
        Me.FinancasCustoVariavelCheckBox = New System.Windows.Forms.CheckBox()
        Me.FinancasDespesaFixaCheckBox = New System.Windows.Forms.CheckBox()
        Me.RelatoriosAniversariantesCheckBox = New System.Windows.Forms.CheckBox()
        Me.RelatoriosConsultasCheckBox = New System.Windows.Forms.CheckBox()
        Me.RelatoriosDRECheckBox = New System.Windows.Forms.CheckBox()
        Me.RelatoriosISACLICheckBox = New System.Windows.Forms.CheckBox()
        Me.RelatoriosLogEntradaCheckBox = New System.Windows.Forms.CheckBox()
        Me.RelatoriosLogControleCheckBox = New System.Windows.Forms.CheckBox()
        Me.GrupoRelatorios = New System.Windows.Forms.GroupBox()
        Me.TipoComboBox = New System.Windows.Forms.ComboBox()
        Me.ContatoIncluirCheckBox = New System.Windows.Forms.CheckBox()
        Me.ContatoEditarCheckBox = New System.Windows.Forms.CheckBox()
        Me.ContatoExcluirCheckBox = New System.Windows.Forms.CheckBox()
        Me.GrupoContato = New System.Windows.Forms.GroupBox()
        UsuarioLabel = New System.Windows.Forms.Label()
        SenhaLabel = New System.Windows.Forms.Label()
        AssinaturaLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LoginBindingNavigator.SuspendLayout()
        Me.GrupoUsuario.SuspendLayout()
        Me.GrupoServicos.SuspendLayout()
        Me.GrupoConvenio.SuspendLayout()
        Me.GrupoProfissional.SuspendLayout()
        Me.GrupoPaciente.SuspendLayout()
        Me.GrupoEvolucaoClinica.SuspendLayout()
        Me.GrupoFinancas.SuspendLayout()
        Me.GrupoRelatorios.SuspendLayout()
        Me.GrupoContato.SuspendLayout()
        Me.SuspendLayout()
        '
        'UsuarioLabel
        '
        UsuarioLabel.AutoSize = True
        UsuarioLabel.Location = New System.Drawing.Point(25, 33)
        UsuarioLabel.Name = "UsuarioLabel"
        UsuarioLabel.Size = New System.Drawing.Size(46, 13)
        UsuarioLabel.TabIndex = 1
        UsuarioLabel.Text = "Usuário:"
        '
        'SenhaLabel
        '
        SenhaLabel.AutoSize = True
        SenhaLabel.Location = New System.Drawing.Point(30, 59)
        SenhaLabel.Name = "SenhaLabel"
        SenhaLabel.Size = New System.Drawing.Size(41, 13)
        SenhaLabel.TabIndex = 3
        SenhaLabel.Text = "Senha:"
        '
        'AssinaturaLabel
        '
        AssinaturaLabel.AutoSize = True
        AssinaturaLabel.Location = New System.Drawing.Point(12, 112)
        AssinaturaLabel.Name = "AssinaturaLabel"
        AssinaturaLabel.Size = New System.Drawing.Size(59, 13)
        AssinaturaLabel.TabIndex = 7
        AssinaturaLabel.Text = "Assinatura:"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Location = New System.Drawing.Point(40, 85)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(31, 13)
        TipoLabel.TabIndex = 35
        TipoLabel.Text = "Tipo:"
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
        Me.LoginBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdicionarUsuarioToolStripButton, Me.LoginBindingNavigatorSaveItem, Me.CancelarUsuarioToolStripButton})
        Me.LoginBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.LoginBindingNavigator.MoveFirstItem = Nothing
        Me.LoginBindingNavigator.MoveLastItem = Nothing
        Me.LoginBindingNavigator.MoveNextItem = Nothing
        Me.LoginBindingNavigator.MovePreviousItem = Nothing
        Me.LoginBindingNavigator.Name = "LoginBindingNavigator"
        Me.LoginBindingNavigator.PositionItem = Nothing
        Me.LoginBindingNavigator.Size = New System.Drawing.Size(552, 25)
        Me.LoginBindingNavigator.TabIndex = 0
        Me.LoginBindingNavigator.Text = "BindingNavigator1"
        '
        'AdicionarUsuarioToolStripButton
        '
        Me.AdicionarUsuarioToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources.Button_White_Add
        Me.AdicionarUsuarioToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AdicionarUsuarioToolStripButton.Name = "AdicionarUsuarioToolStripButton"
        Me.AdicionarUsuarioToolStripButton.Size = New System.Drawing.Size(78, 22)
        Me.AdicionarUsuarioToolStripButton.Text = "Adicionar"
        '
        'LoginBindingNavigatorSaveItem
        '
        Me.LoginBindingNavigatorSaveItem.Enabled = False
        Me.LoginBindingNavigatorSaveItem.Image = CType(resources.GetObject("LoginBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.LoginBindingNavigatorSaveItem.Name = "LoginBindingNavigatorSaveItem"
        Me.LoginBindingNavigatorSaveItem.Size = New System.Drawing.Size(58, 22)
        Me.LoginBindingNavigatorSaveItem.Text = "Salvar"
        '
        'CancelarUsuarioToolStripButton
        '
        Me.CancelarUsuarioToolStripButton.Enabled = False
        Me.CancelarUsuarioToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources.Button_White_Stop
        Me.CancelarUsuarioToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CancelarUsuarioToolStripButton.Name = "CancelarUsuarioToolStripButton"
        Me.CancelarUsuarioToolStripButton.Size = New System.Drawing.Size(73, 22)
        Me.CancelarUsuarioToolStripButton.Text = "Cancelar"
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoginBindingSource, "Usuario", True))
        Me.UsuarioTextBox.Location = New System.Drawing.Point(77, 30)
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.Size = New System.Drawing.Size(200, 20)
        Me.UsuarioTextBox.TabIndex = 2
        '
        'SenhaTextBox
        '
        Me.SenhaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoginBindingSource, "Senha", True))
        Me.SenhaTextBox.Location = New System.Drawing.Point(77, 56)
        Me.SenhaTextBox.Name = "SenhaTextBox"
        Me.SenhaTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.SenhaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SenhaTextBox.TabIndex = 4
        '
        'LogControleTableAdapter
        '
        Me.LogControleTableAdapter.ClearBeforeFill = True
        '
        'AssinaturaTextBox
        '
        Me.AssinaturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoginBindingSource, "Assinatura", True))
        Me.AssinaturaTextBox.Location = New System.Drawing.Point(77, 109)
        Me.AssinaturaTextBox.Name = "AssinaturaTextBox"
        Me.AssinaturaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AssinaturaTextBox.TabIndex = 8
        '
        'GrupoUsuario
        '
        Me.GrupoUsuario.Controls.Add(Me.UsuarioExcluirCheckBox)
        Me.GrupoUsuario.Controls.Add(Me.UsuarioEditarCheckBox)
        Me.GrupoUsuario.Controls.Add(Me.UsuarioNovoCheckBox)
        Me.GrupoUsuario.Location = New System.Drawing.Point(15, 135)
        Me.GrupoUsuario.Name = "GrupoUsuario"
        Me.GrupoUsuario.Size = New System.Drawing.Size(262, 56)
        Me.GrupoUsuario.TabIndex = 9
        Me.GrupoUsuario.TabStop = False
        Me.GrupoUsuario.Tag = ""
        Me.GrupoUsuario.Text = "Usuário"
        '
        'UsuarioExcluirCheckBox
        '
        Me.UsuarioExcluirCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LoginBindingSource, "UsuarioExcluir", True))
        Me.UsuarioExcluirCheckBox.Location = New System.Drawing.Point(134, 19)
        Me.UsuarioExcluirCheckBox.Name = "UsuarioExcluirCheckBox"
        Me.UsuarioExcluirCheckBox.Size = New System.Drawing.Size(61, 24)
        Me.UsuarioExcluirCheckBox.TabIndex = 5
        Me.UsuarioExcluirCheckBox.Text = "Excluir"
        Me.UsuarioExcluirCheckBox.UseVisualStyleBackColor = True
        '
        'UsuarioEditarCheckBox
        '
        Me.UsuarioEditarCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LoginBindingSource, "UsuarioEditar", True))
        Me.UsuarioEditarCheckBox.Location = New System.Drawing.Point(70, 19)
        Me.UsuarioEditarCheckBox.Name = "UsuarioEditarCheckBox"
        Me.UsuarioEditarCheckBox.Size = New System.Drawing.Size(58, 24)
        Me.UsuarioEditarCheckBox.TabIndex = 3
        Me.UsuarioEditarCheckBox.Text = "Editar"
        Me.UsuarioEditarCheckBox.UseVisualStyleBackColor = True
        '
        'UsuarioNovoCheckBox
        '
        Me.UsuarioNovoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LoginBindingSource, "UsuarioNovo", True))
        Me.UsuarioNovoCheckBox.Location = New System.Drawing.Point(6, 19)
        Me.UsuarioNovoCheckBox.Name = "UsuarioNovoCheckBox"
        Me.UsuarioNovoCheckBox.Size = New System.Drawing.Size(58, 24)
        Me.UsuarioNovoCheckBox.TabIndex = 1
        Me.UsuarioNovoCheckBox.Text = "Novo"
        Me.UsuarioNovoCheckBox.UseVisualStyleBackColor = True
        '
        'GrupoServicos
        '
        Me.GrupoServicos.Controls.Add(Me.ServicosExcluirCheckBox)
        Me.GrupoServicos.Controls.Add(Me.ServicosIncluirCheckBox)
        Me.GrupoServicos.Controls.Add(Me.ServicosEditarCheckBox)
        Me.GrupoServicos.Location = New System.Drawing.Point(15, 197)
        Me.GrupoServicos.Name = "GrupoServicos"
        Me.GrupoServicos.Size = New System.Drawing.Size(262, 56)
        Me.GrupoServicos.TabIndex = 10
        Me.GrupoServicos.TabStop = False
        Me.GrupoServicos.Text = "Serviços"
        '
        'ServicosExcluirCheckBox
        '
        Me.ServicosExcluirCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LoginBindingSource, "ServicosExcluir", True))
        Me.ServicosExcluirCheckBox.Location = New System.Drawing.Point(134, 19)
        Me.ServicosExcluirCheckBox.Name = "ServicosExcluirCheckBox"
        Me.ServicosExcluirCheckBox.Size = New System.Drawing.Size(61, 24)
        Me.ServicosExcluirCheckBox.TabIndex = 14
        Me.ServicosExcluirCheckBox.Text = "Excluir"
        Me.ServicosExcluirCheckBox.UseVisualStyleBackColor = True
        '
        'ServicosIncluirCheckBox
        '
        Me.ServicosIncluirCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LoginBindingSource, "ServicosIncluir", True))
        Me.ServicosIncluirCheckBox.Location = New System.Drawing.Point(6, 19)
        Me.ServicosIncluirCheckBox.Name = "ServicosIncluirCheckBox"
        Me.ServicosIncluirCheckBox.Size = New System.Drawing.Size(58, 24)
        Me.ServicosIncluirCheckBox.TabIndex = 11
        Me.ServicosIncluirCheckBox.Text = "Incluir"
        Me.ServicosIncluirCheckBox.UseVisualStyleBackColor = True
        '
        'ServicosEditarCheckBox
        '
        Me.ServicosEditarCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LoginBindingSource, "ServicosEditar", True))
        Me.ServicosEditarCheckBox.Location = New System.Drawing.Point(70, 19)
        Me.ServicosEditarCheckBox.Name = "ServicosEditarCheckBox"
        Me.ServicosEditarCheckBox.Size = New System.Drawing.Size(58, 24)
        Me.ServicosEditarCheckBox.TabIndex = 12
        Me.ServicosEditarCheckBox.Text = "Editar"
        Me.ServicosEditarCheckBox.UseVisualStyleBackColor = True
        '
        'ConvenioIncluirCheckBox
        '
        Me.ConvenioIncluirCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LoginBindingSource, "ConvenioIncluir", True))
        Me.ConvenioIncluirCheckBox.Location = New System.Drawing.Point(6, 19)
        Me.ConvenioIncluirCheckBox.Name = "ConvenioIncluirCheckBox"
        Me.ConvenioIncluirCheckBox.Size = New System.Drawing.Size(58, 24)
        Me.ConvenioIncluirCheckBox.TabIndex = 11
        Me.ConvenioIncluirCheckBox.Text = "Incluir"
        Me.ConvenioIncluirCheckBox.UseVisualStyleBackColor = True
        '
        'ConvenioEditarCheckBox
        '
        Me.ConvenioEditarCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LoginBindingSource, "ConvenioEditar", True))
        Me.ConvenioEditarCheckBox.Location = New System.Drawing.Point(70, 19)
        Me.ConvenioEditarCheckBox.Name = "ConvenioEditarCheckBox"
        Me.ConvenioEditarCheckBox.Size = New System.Drawing.Size(58, 24)
        Me.ConvenioEditarCheckBox.TabIndex = 12
        Me.ConvenioEditarCheckBox.Text = "Editar"
        Me.ConvenioEditarCheckBox.UseVisualStyleBackColor = True
        '
        'ConvenioExcluirCheckBox
        '
        Me.ConvenioExcluirCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LoginBindingSource, "ConvenioExcluir", True))
        Me.ConvenioExcluirCheckBox.Location = New System.Drawing.Point(134, 19)
        Me.ConvenioExcluirCheckBox.Name = "ConvenioExcluirCheckBox"
        Me.ConvenioExcluirCheckBox.Size = New System.Drawing.Size(61, 24)
        Me.ConvenioExcluirCheckBox.TabIndex = 14
        Me.ConvenioExcluirCheckBox.Text = "Excluir"
        Me.ConvenioExcluirCheckBox.UseVisualStyleBackColor = True
        '
        'GrupoConvenio
        '
        Me.GrupoConvenio.Controls.Add(Me.ConvenioIncluirCheckBox)
        Me.GrupoConvenio.Controls.Add(Me.ConvenioEditarCheckBox)
        Me.GrupoConvenio.Controls.Add(Me.ConvenioExcluirCheckBox)
        Me.GrupoConvenio.Location = New System.Drawing.Point(15, 259)
        Me.GrupoConvenio.Name = "GrupoConvenio"
        Me.GrupoConvenio.Size = New System.Drawing.Size(262, 54)
        Me.GrupoConvenio.TabIndex = 15
        Me.GrupoConvenio.TabStop = False
        Me.GrupoConvenio.Text = "Convênio"
        '
        'ProfissionalIncluirCheckBox
        '
        Me.ProfissionalIncluirCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LoginBindingSource, "ProfissionalIncluir", True))
        Me.ProfissionalIncluirCheckBox.Location = New System.Drawing.Point(6, 19)
        Me.ProfissionalIncluirCheckBox.Name = "ProfissionalIncluirCheckBox"
        Me.ProfissionalIncluirCheckBox.Size = New System.Drawing.Size(58, 24)
        Me.ProfissionalIncluirCheckBox.TabIndex = 16
        Me.ProfissionalIncluirCheckBox.Text = "Incluir"
        Me.ProfissionalIncluirCheckBox.UseVisualStyleBackColor = True
        '
        'ProfissionalEditarCheckBox
        '
        Me.ProfissionalEditarCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LoginBindingSource, "ProfissionalEditar", True))
        Me.ProfissionalEditarCheckBox.Location = New System.Drawing.Point(70, 19)
        Me.ProfissionalEditarCheckBox.Name = "ProfissionalEditarCheckBox"
        Me.ProfissionalEditarCheckBox.Size = New System.Drawing.Size(58, 24)
        Me.ProfissionalEditarCheckBox.TabIndex = 17
        Me.ProfissionalEditarCheckBox.Text = "Editar"
        Me.ProfissionalEditarCheckBox.UseVisualStyleBackColor = True
        '
        'ProfissionalExcluirCheckBox
        '
        Me.ProfissionalExcluirCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LoginBindingSource, "ProfissionalExcluir", True))
        Me.ProfissionalExcluirCheckBox.Location = New System.Drawing.Point(134, 19)
        Me.ProfissionalExcluirCheckBox.Name = "ProfissionalExcluirCheckBox"
        Me.ProfissionalExcluirCheckBox.Size = New System.Drawing.Size(61, 24)
        Me.ProfissionalExcluirCheckBox.TabIndex = 18
        Me.ProfissionalExcluirCheckBox.Text = "Excluir"
        Me.ProfissionalExcluirCheckBox.UseVisualStyleBackColor = True
        '
        'GrupoProfissional
        '
        Me.GrupoProfissional.Controls.Add(Me.ProfissionalIncluirCheckBox)
        Me.GrupoProfissional.Controls.Add(Me.ProfissionalEditarCheckBox)
        Me.GrupoProfissional.Controls.Add(Me.ProfissionalExcluirCheckBox)
        Me.GrupoProfissional.Location = New System.Drawing.Point(15, 319)
        Me.GrupoProfissional.Name = "GrupoProfissional"
        Me.GrupoProfissional.Size = New System.Drawing.Size(262, 57)
        Me.GrupoProfissional.TabIndex = 19
        Me.GrupoProfissional.TabStop = False
        Me.GrupoProfissional.Text = "Profissional"
        '
        'PacienteIncluirCheckBox
        '
        Me.PacienteIncluirCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LoginBindingSource, "PacienteIncluir", True))
        Me.PacienteIncluirCheckBox.Location = New System.Drawing.Point(6, 19)
        Me.PacienteIncluirCheckBox.Name = "PacienteIncluirCheckBox"
        Me.PacienteIncluirCheckBox.Size = New System.Drawing.Size(58, 24)
        Me.PacienteIncluirCheckBox.TabIndex = 20
        Me.PacienteIncluirCheckBox.Text = "Incluir"
        Me.PacienteIncluirCheckBox.UseVisualStyleBackColor = True
        '
        'PacienteEditarCheckBox
        '
        Me.PacienteEditarCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LoginBindingSource, "PacienteEditar", True))
        Me.PacienteEditarCheckBox.Location = New System.Drawing.Point(70, 19)
        Me.PacienteEditarCheckBox.Name = "PacienteEditarCheckBox"
        Me.PacienteEditarCheckBox.Size = New System.Drawing.Size(58, 24)
        Me.PacienteEditarCheckBox.TabIndex = 21
        Me.PacienteEditarCheckBox.Text = "Editar"
        Me.PacienteEditarCheckBox.UseVisualStyleBackColor = True
        '
        'PacienteExcluirCheckBox
        '
        Me.PacienteExcluirCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LoginBindingSource, "PacienteExcluir", True))
        Me.PacienteExcluirCheckBox.Location = New System.Drawing.Point(134, 19)
        Me.PacienteExcluirCheckBox.Name = "PacienteExcluirCheckBox"
        Me.PacienteExcluirCheckBox.Size = New System.Drawing.Size(61, 24)
        Me.PacienteExcluirCheckBox.TabIndex = 22
        Me.PacienteExcluirCheckBox.Text = "Excluir"
        Me.PacienteExcluirCheckBox.UseVisualStyleBackColor = True
        '
        'GrupoPaciente
        '
        Me.GrupoPaciente.Controls.Add(Me.PacienteIncluirCheckBox)
        Me.GrupoPaciente.Controls.Add(Me.PacienteEditarCheckBox)
        Me.GrupoPaciente.Controls.Add(Me.PacienteExcluirCheckBox)
        Me.GrupoPaciente.Location = New System.Drawing.Point(15, 382)
        Me.GrupoPaciente.Name = "GrupoPaciente"
        Me.GrupoPaciente.Size = New System.Drawing.Size(262, 54)
        Me.GrupoPaciente.TabIndex = 23
        Me.GrupoPaciente.TabStop = False
        Me.GrupoPaciente.Text = "Paciente"
        '
        'ConsultaAgendaCheckBox
        '
        Me.ConsultaAgendaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LoginBindingSource, "ConsultaAgenda", True))
        Me.ConsultaAgendaCheckBox.Location = New System.Drawing.Point(15, 442)
        Me.ConsultaAgendaCheckBox.Name = "ConsultaAgendaCheckBox"
        Me.ConsultaAgendaCheckBox.Size = New System.Drawing.Size(67, 24)
        Me.ConsultaAgendaCheckBox.TabIndex = 24
        Me.ConsultaAgendaCheckBox.Text = "Agenda"
        Me.ConsultaAgendaCheckBox.UseVisualStyleBackColor = True
        '
        'AnamneseCheckBox
        '
        Me.AnamneseCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LoginBindingSource, "Anamnese", True))
        Me.AnamneseCheckBox.Location = New System.Drawing.Point(88, 442)
        Me.AnamneseCheckBox.Name = "AnamneseCheckBox"
        Me.AnamneseCheckBox.Size = New System.Drawing.Size(78, 24)
        Me.AnamneseCheckBox.TabIndex = 25
        Me.AnamneseCheckBox.Text = "Anamnese"
        Me.AnamneseCheckBox.UseVisualStyleBackColor = True
        '
        'GrupoEvolucaoClinica
        '
        Me.GrupoEvolucaoClinica.Controls.Add(Me.ECEvolucaoClinicaPacientesCheckBox)
        Me.GrupoEvolucaoClinica.Controls.Add(Me.ECPesquisarCheckBox)
        Me.GrupoEvolucaoClinica.Location = New System.Drawing.Point(283, 30)
        Me.GrupoEvolucaoClinica.Name = "GrupoEvolucaoClinica"
        Me.GrupoEvolucaoClinica.Size = New System.Drawing.Size(256, 85)
        Me.GrupoEvolucaoClinica.TabIndex = 26
        Me.GrupoEvolucaoClinica.TabStop = False
        Me.GrupoEvolucaoClinica.Text = "Evolução Clínica"
        '
        'ECEvolucaoClinicaPacientesCheckBox
        '
        Me.ECEvolucaoClinicaPacientesCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LoginBindingSource, "ECEvolucaoClinicaPacientes", True))
        Me.ECEvolucaoClinicaPacientesCheckBox.Location = New System.Drawing.Point(6, 19)
        Me.ECEvolucaoClinicaPacientesCheckBox.Name = "ECEvolucaoClinicaPacientesCheckBox"
        Me.ECEvolucaoClinicaPacientesCheckBox.Size = New System.Drawing.Size(178, 24)
        Me.ECEvolucaoClinicaPacientesCheckBox.TabIndex = 27
        Me.ECEvolucaoClinicaPacientesCheckBox.Text = "Evolução Clínica dos Pacientes"
        Me.ECEvolucaoClinicaPacientesCheckBox.UseVisualStyleBackColor = True
        '
        'ECPesquisarCheckBox
        '
        Me.ECPesquisarCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LoginBindingSource, "ECPesquisar", True))
        Me.ECPesquisarCheckBox.Location = New System.Drawing.Point(6, 49)
        Me.ECPesquisarCheckBox.Name = "ECPesquisarCheckBox"
        Me.ECPesquisarCheckBox.Size = New System.Drawing.Size(79, 24)
        Me.ECPesquisarCheckBox.TabIndex = 28
        Me.ECPesquisarCheckBox.Text = "Pesquisar"
        Me.ECPesquisarCheckBox.UseVisualStyleBackColor = True
        '
        'FinancasReceitaCheckBox
        '
        Me.FinancasReceitaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LoginBindingSource, "FinancasReceita", True))
        Me.FinancasReceitaCheckBox.Location = New System.Drawing.Point(6, 19)
        Me.FinancasReceitaCheckBox.Name = "FinancasReceitaCheckBox"
        Me.FinancasReceitaCheckBox.Size = New System.Drawing.Size(65, 24)
        Me.FinancasReceitaCheckBox.TabIndex = 27
        Me.FinancasReceitaCheckBox.Text = "Receita"
        Me.FinancasReceitaCheckBox.UseVisualStyleBackColor = True
        '
        'GrupoFinancas
        '
        Me.GrupoFinancas.Controls.Add(Me.FinancasReceitaCheckBox)
        Me.GrupoFinancas.Controls.Add(Me.FinancasDRECheckBox)
        Me.GrupoFinancas.Controls.Add(Me.FinancasImpostosCheckBox)
        Me.GrupoFinancas.Controls.Add(Me.FinancasCustoFixoCheckBox)
        Me.GrupoFinancas.Controls.Add(Me.FinancasDespesaVariavelCheckBox)
        Me.GrupoFinancas.Controls.Add(Me.FinancasCustoVariavelCheckBox)
        Me.GrupoFinancas.Controls.Add(Me.FinancasDespesaFixaCheckBox)
        Me.GrupoFinancas.Location = New System.Drawing.Point(283, 121)
        Me.GrupoFinancas.Name = "GrupoFinancas"
        Me.GrupoFinancas.Size = New System.Drawing.Size(256, 134)
        Me.GrupoFinancas.TabIndex = 28
        Me.GrupoFinancas.TabStop = False
        Me.GrupoFinancas.Text = "Finanças"
        '
        'FinancasDRECheckBox
        '
        Me.FinancasDRECheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LoginBindingSource, "FinancasDRE", True))
        Me.FinancasDRECheckBox.Location = New System.Drawing.Point(121, 78)
        Me.FinancasDRECheckBox.Name = "FinancasDRECheckBox"
        Me.FinancasDRECheckBox.Size = New System.Drawing.Size(71, 24)
        Me.FinancasDRECheckBox.TabIndex = 34
        Me.FinancasDRECheckBox.Text = "DRE"
        Me.FinancasDRECheckBox.UseVisualStyleBackColor = True
        '
        'FinancasImpostosCheckBox
        '
        Me.FinancasImpostosCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LoginBindingSource, "FinancasImpostos", True))
        Me.FinancasImpostosCheckBox.Location = New System.Drawing.Point(77, 19)
        Me.FinancasImpostosCheckBox.Name = "FinancasImpostosCheckBox"
        Me.FinancasImpostosCheckBox.Size = New System.Drawing.Size(73, 24)
        Me.FinancasImpostosCheckBox.TabIndex = 29
        Me.FinancasImpostosCheckBox.Text = "Impostos"
        Me.FinancasImpostosCheckBox.UseVisualStyleBackColor = True
        '
        'FinancasCustoFixoCheckBox
        '
        Me.FinancasCustoFixoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LoginBindingSource, "FinancasCustoFixo", True))
        Me.FinancasCustoFixoCheckBox.Location = New System.Drawing.Point(156, 19)
        Me.FinancasCustoFixoCheckBox.Name = "FinancasCustoFixoCheckBox"
        Me.FinancasCustoFixoCheckBox.Size = New System.Drawing.Size(78, 24)
        Me.FinancasCustoFixoCheckBox.TabIndex = 30
        Me.FinancasCustoFixoCheckBox.Text = "Custo Fixo"
        Me.FinancasCustoFixoCheckBox.UseVisualStyleBackColor = True
        '
        'FinancasDespesaVariavelCheckBox
        '
        Me.FinancasDespesaVariavelCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LoginBindingSource, "FinancasDespesaVariavel", True))
        Me.FinancasDespesaVariavelCheckBox.Location = New System.Drawing.Point(6, 79)
        Me.FinancasDespesaVariavelCheckBox.Name = "FinancasDespesaVariavelCheckBox"
        Me.FinancasDespesaVariavelCheckBox.Size = New System.Drawing.Size(109, 24)
        Me.FinancasDespesaVariavelCheckBox.TabIndex = 33
        Me.FinancasDespesaVariavelCheckBox.Text = "Despesa Variável"
        Me.FinancasDespesaVariavelCheckBox.UseVisualStyleBackColor = True
        '
        'FinancasCustoVariavelCheckBox
        '
        Me.FinancasCustoVariavelCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LoginBindingSource, "FinancasCustoVariavel", True))
        Me.FinancasCustoVariavelCheckBox.Location = New System.Drawing.Point(6, 49)
        Me.FinancasCustoVariavelCheckBox.Name = "FinancasCustoVariavelCheckBox"
        Me.FinancasCustoVariavelCheckBox.Size = New System.Drawing.Size(97, 24)
        Me.FinancasCustoVariavelCheckBox.TabIndex = 31
        Me.FinancasCustoVariavelCheckBox.Text = "Custo Variável"
        Me.FinancasCustoVariavelCheckBox.UseVisualStyleBackColor = True
        '
        'FinancasDespesaFixaCheckBox
        '
        Me.FinancasDespesaFixaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LoginBindingSource, "FinancasDespesaFixa", True))
        Me.FinancasDespesaFixaCheckBox.Location = New System.Drawing.Point(109, 49)
        Me.FinancasDespesaFixaCheckBox.Name = "FinancasDespesaFixaCheckBox"
        Me.FinancasDespesaFixaCheckBox.Size = New System.Drawing.Size(94, 24)
        Me.FinancasDespesaFixaCheckBox.TabIndex = 32
        Me.FinancasDespesaFixaCheckBox.Text = "Despesa Fixa"
        Me.FinancasDespesaFixaCheckBox.UseVisualStyleBackColor = True
        '
        'RelatoriosAniversariantesCheckBox
        '
        Me.RelatoriosAniversariantesCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LoginBindingSource, "RelatoriosAniversariantes", True))
        Me.RelatoriosAniversariantesCheckBox.Location = New System.Drawing.Point(6, 19)
        Me.RelatoriosAniversariantesCheckBox.Name = "RelatoriosAniversariantesCheckBox"
        Me.RelatoriosAniversariantesCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.RelatoriosAniversariantesCheckBox.TabIndex = 29
        Me.RelatoriosAniversariantesCheckBox.Text = "Aniversariantes"
        Me.RelatoriosAniversariantesCheckBox.UseVisualStyleBackColor = True
        '
        'RelatoriosConsultasCheckBox
        '
        Me.RelatoriosConsultasCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LoginBindingSource, "RelatoriosConsultas", True))
        Me.RelatoriosConsultasCheckBox.Location = New System.Drawing.Point(116, 19)
        Me.RelatoriosConsultasCheckBox.Name = "RelatoriosConsultasCheckBox"
        Me.RelatoriosConsultasCheckBox.Size = New System.Drawing.Size(77, 24)
        Me.RelatoriosConsultasCheckBox.TabIndex = 30
        Me.RelatoriosConsultasCheckBox.Text = "Consultas"
        Me.RelatoriosConsultasCheckBox.UseVisualStyleBackColor = True
        '
        'RelatoriosDRECheckBox
        '
        Me.RelatoriosDRECheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LoginBindingSource, "RelatoriosDRE", True))
        Me.RelatoriosDRECheckBox.Location = New System.Drawing.Point(6, 49)
        Me.RelatoriosDRECheckBox.Name = "RelatoriosDRECheckBox"
        Me.RelatoriosDRECheckBox.Size = New System.Drawing.Size(54, 24)
        Me.RelatoriosDRECheckBox.TabIndex = 31
        Me.RelatoriosDRECheckBox.Text = "DRE"
        Me.RelatoriosDRECheckBox.UseVisualStyleBackColor = True
        '
        'RelatoriosISACLICheckBox
        '
        Me.RelatoriosISACLICheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LoginBindingSource, "RelatoriosISACLI", True))
        Me.RelatoriosISACLICheckBox.Location = New System.Drawing.Point(66, 49)
        Me.RelatoriosISACLICheckBox.Name = "RelatoriosISACLICheckBox"
        Me.RelatoriosISACLICheckBox.Size = New System.Drawing.Size(67, 24)
        Me.RelatoriosISACLICheckBox.TabIndex = 32
        Me.RelatoriosISACLICheckBox.Text = "ISACLI"
        Me.RelatoriosISACLICheckBox.UseVisualStyleBackColor = True
        '
        'RelatoriosLogEntradaCheckBox
        '
        Me.RelatoriosLogEntradaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LoginBindingSource, "RelatoriosLogEntrada", True))
        Me.RelatoriosLogEntradaCheckBox.Location = New System.Drawing.Point(139, 49)
        Me.RelatoriosLogEntradaCheckBox.Name = "RelatoriosLogEntradaCheckBox"
        Me.RelatoriosLogEntradaCheckBox.Size = New System.Drawing.Size(101, 24)
        Me.RelatoriosLogEntradaCheckBox.TabIndex = 33
        Me.RelatoriosLogEntradaCheckBox.Text = "Log de Entrada"
        Me.RelatoriosLogEntradaCheckBox.UseVisualStyleBackColor = True
        '
        'RelatoriosLogControleCheckBox
        '
        Me.RelatoriosLogControleCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LoginBindingSource, "RelatoriosLogControle", True))
        Me.RelatoriosLogControleCheckBox.Location = New System.Drawing.Point(6, 79)
        Me.RelatoriosLogControleCheckBox.Name = "RelatoriosLogControleCheckBox"
        Me.RelatoriosLogControleCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.RelatoriosLogControleCheckBox.TabIndex = 34
        Me.RelatoriosLogControleCheckBox.Text = "Log de Controle"
        Me.RelatoriosLogControleCheckBox.UseVisualStyleBackColor = True
        '
        'GrupoRelatorios
        '
        Me.GrupoRelatorios.Controls.Add(Me.RelatoriosAniversariantesCheckBox)
        Me.GrupoRelatorios.Controls.Add(Me.RelatoriosLogControleCheckBox)
        Me.GrupoRelatorios.Controls.Add(Me.RelatoriosConsultasCheckBox)
        Me.GrupoRelatorios.Controls.Add(Me.RelatoriosLogEntradaCheckBox)
        Me.GrupoRelatorios.Controls.Add(Me.RelatoriosDRECheckBox)
        Me.GrupoRelatorios.Controls.Add(Me.RelatoriosISACLICheckBox)
        Me.GrupoRelatorios.Location = New System.Drawing.Point(283, 261)
        Me.GrupoRelatorios.Name = "GrupoRelatorios"
        Me.GrupoRelatorios.Size = New System.Drawing.Size(256, 116)
        Me.GrupoRelatorios.TabIndex = 35
        Me.GrupoRelatorios.TabStop = False
        Me.GrupoRelatorios.Text = "Relatórios"
        '
        'TipoComboBox
        '
        Me.TipoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoginBindingSource, "Tipo", True))
        Me.TipoComboBox.FormattingEnabled = True
        Me.TipoComboBox.Items.AddRange(New Object() {"Administrador 1", "Administrador 2", "Profissional"})
        Me.TipoComboBox.Location = New System.Drawing.Point(77, 82)
        Me.TipoComboBox.Name = "TipoComboBox"
        Me.TipoComboBox.Size = New System.Drawing.Size(200, 21)
        Me.TipoComboBox.TabIndex = 36
        '
        'ContatoIncluirCheckBox
        '
        Me.ContatoIncluirCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LoginBindingSource, "ContatoIncluir", True))
        Me.ContatoIncluirCheckBox.Location = New System.Drawing.Point(6, 19)
        Me.ContatoIncluirCheckBox.Name = "ContatoIncluirCheckBox"
        Me.ContatoIncluirCheckBox.Size = New System.Drawing.Size(58, 24)
        Me.ContatoIncluirCheckBox.TabIndex = 37
        Me.ContatoIncluirCheckBox.Text = "Incluir"
        Me.ContatoIncluirCheckBox.UseVisualStyleBackColor = True
        '
        'ContatoEditarCheckBox
        '
        Me.ContatoEditarCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LoginBindingSource, "ContatoEditar", True))
        Me.ContatoEditarCheckBox.Location = New System.Drawing.Point(70, 19)
        Me.ContatoEditarCheckBox.Name = "ContatoEditarCheckBox"
        Me.ContatoEditarCheckBox.Size = New System.Drawing.Size(58, 24)
        Me.ContatoEditarCheckBox.TabIndex = 38
        Me.ContatoEditarCheckBox.Text = "Editar"
        Me.ContatoEditarCheckBox.UseVisualStyleBackColor = True
        '
        'ContatoExcluirCheckBox
        '
        Me.ContatoExcluirCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LoginBindingSource, "ContatoExcluir", True))
        Me.ContatoExcluirCheckBox.Location = New System.Drawing.Point(134, 19)
        Me.ContatoExcluirCheckBox.Name = "ContatoExcluirCheckBox"
        Me.ContatoExcluirCheckBox.Size = New System.Drawing.Size(58, 24)
        Me.ContatoExcluirCheckBox.TabIndex = 39
        Me.ContatoExcluirCheckBox.Text = "Excluir"
        Me.ContatoExcluirCheckBox.UseVisualStyleBackColor = True
        '
        'GrupoContato
        '
        Me.GrupoContato.Controls.Add(Me.ContatoIncluirCheckBox)
        Me.GrupoContato.Controls.Add(Me.ContatoExcluirCheckBox)
        Me.GrupoContato.Controls.Add(Me.ContatoEditarCheckBox)
        Me.GrupoContato.Location = New System.Drawing.Point(283, 384)
        Me.GrupoContato.Name = "GrupoContato"
        Me.GrupoContato.Size = New System.Drawing.Size(256, 52)
        Me.GrupoContato.TabIndex = 40
        Me.GrupoContato.TabStop = False
        Me.GrupoContato.Text = "Contato"
        '
        'form_incluir_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(552, 475)
        Me.Controls.Add(Me.GrupoContato)
        Me.Controls.Add(TipoLabel)
        Me.Controls.Add(Me.TipoComboBox)
        Me.Controls.Add(Me.GrupoRelatorios)
        Me.Controls.Add(Me.GrupoFinancas)
        Me.Controls.Add(Me.ConsultaAgendaCheckBox)
        Me.Controls.Add(Me.GrupoEvolucaoClinica)
        Me.Controls.Add(Me.AnamneseCheckBox)
        Me.Controls.Add(Me.GrupoPaciente)
        Me.Controls.Add(Me.GrupoProfissional)
        Me.Controls.Add(Me.GrupoConvenio)
        Me.Controls.Add(Me.GrupoServicos)
        Me.Controls.Add(Me.GrupoUsuario)
        Me.Controls.Add(AssinaturaLabel)
        Me.Controls.Add(Me.AssinaturaTextBox)
        Me.Controls.Add(SenhaLabel)
        Me.Controls.Add(Me.SenhaTextBox)
        Me.Controls.Add(UsuarioLabel)
        Me.Controls.Add(Me.UsuarioTextBox)
        Me.Controls.Add(Me.LoginBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_incluir_usuario"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuário"
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LoginBindingNavigator.ResumeLayout(False)
        Me.LoginBindingNavigator.PerformLayout()
        Me.GrupoUsuario.ResumeLayout(False)
        Me.GrupoServicos.ResumeLayout(False)
        Me.GrupoConvenio.ResumeLayout(False)
        Me.GrupoProfissional.ResumeLayout(False)
        Me.GrupoPaciente.ResumeLayout(False)
        Me.GrupoEvolucaoClinica.ResumeLayout(False)
        Me.GrupoFinancas.ResumeLayout(False)
        Me.GrupoRelatorios.ResumeLayout(False)
        Me.GrupoContato.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Gerenciamento_CRAFIDataSet As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet
    Friend WithEvents LoginBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LoginTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LoginTableAdapter
    Friend WithEvents TableAdapterManager As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LoginBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents LoginBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AdicionarUsuarioToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CancelarUsuarioToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents UsuarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SenhaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LogControleTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter
    Friend WithEvents AssinaturaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GrupoUsuario As System.Windows.Forms.GroupBox
    Friend WithEvents UsuarioExcluirCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents UsuarioEditarCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents UsuarioNovoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GrupoServicos As System.Windows.Forms.GroupBox
    Friend WithEvents ServicosExcluirCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ServicosIncluirCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ServicosEditarCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ConvenioIncluirCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ConvenioEditarCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ConvenioExcluirCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GrupoConvenio As System.Windows.Forms.GroupBox
    Friend WithEvents ProfissionalIncluirCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ProfissionalEditarCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ProfissionalExcluirCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GrupoProfissional As System.Windows.Forms.GroupBox
    Friend WithEvents PacienteIncluirCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PacienteEditarCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PacienteExcluirCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GrupoPaciente As System.Windows.Forms.GroupBox
    Friend WithEvents ConsultaAgendaCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AnamneseCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GrupoEvolucaoClinica As System.Windows.Forms.GroupBox
    Friend WithEvents ECEvolucaoClinicaPacientesCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ECPesquisarCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FinancasReceitaCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GrupoFinancas As System.Windows.Forms.GroupBox
    Friend WithEvents FinancasDRECheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FinancasImpostosCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FinancasCustoFixoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FinancasDespesaVariavelCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FinancasCustoVariavelCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FinancasDespesaFixaCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents RelatoriosAniversariantesCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents RelatoriosConsultasCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents RelatoriosDRECheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents RelatoriosISACLICheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents RelatoriosLogEntradaCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents RelatoriosLogControleCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GrupoRelatorios As System.Windows.Forms.GroupBox
    Friend WithEvents TipoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ContatoIncluirCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ContatoEditarCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ContatoExcluirCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GrupoContato As System.Windows.Forms.GroupBox
End Class
