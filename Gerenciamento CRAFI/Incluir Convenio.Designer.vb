﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_incluir_convenio
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
        Dim RazaoSocialLabel As System.Windows.Forms.Label
        Dim CNPJLabel As System.Windows.Forms.Label
        Dim InscricaoEstadualLabel As System.Windows.Forms.Label
        Dim EnderecoLabel As System.Windows.Forms.Label
        Dim CEPLabel As System.Windows.Forms.Label
        Dim CidadeLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim TelefoneLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim ContatoLabel As System.Windows.Forms.Label
        Dim TelefoneContatoLabel As System.Windows.Forms.Label
        Dim RamalContatoLabel As System.Windows.Forms.Label
        Dim ComentariosLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_incluir_convenio))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Gerenciamento_CRAFIDataSet = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet()
        Me.ConveniosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConveniosTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ConveniosTableAdapter()
        Me.TableAdapterManager = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager()
        Me.ServicosConveniosTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ServicosConveniosTableAdapter()
        Me.ConveniosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.AdicionarConvenioToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ConveniosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CancelarConvenioToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.RazaoSocialTextBox = New System.Windows.Forms.TextBox()
        Me.CNPJTextBox = New System.Windows.Forms.TextBox()
        Me.InscricaoEstadualTextBox = New System.Windows.Forms.TextBox()
        Me.EnderecoTextBox = New System.Windows.Forms.TextBox()
        Me.CEPTextBox = New System.Windows.Forms.TextBox()
        Me.CidadeTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoTextBox = New System.Windows.Forms.TextBox()
        Me.TelefoneTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.ContatoTextBox = New System.Windows.Forms.TextBox()
        Me.TelefoneContatoTextBox = New System.Windows.Forms.TextBox()
        Me.RamalContatoTextBox = New System.Windows.Forms.TextBox()
        Me.ComentariosTextBox = New System.Windows.Forms.TextBox()
        Me.GrupoContatoConvenio = New System.Windows.Forms.GroupBox()
        Me.ServicosConveniosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServicosConveniosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrupoServicosConvenio = New System.Windows.Forms.GroupBox()
        Me.LogControleTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter()
        RazaoSocialLabel = New System.Windows.Forms.Label()
        CNPJLabel = New System.Windows.Forms.Label()
        InscricaoEstadualLabel = New System.Windows.Forms.Label()
        EnderecoLabel = New System.Windows.Forms.Label()
        CEPLabel = New System.Windows.Forms.Label()
        CidadeLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        TelefoneLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        ContatoLabel = New System.Windows.Forms.Label()
        TelefoneContatoLabel = New System.Windows.Forms.Label()
        RamalContatoLabel = New System.Windows.Forms.Label()
        ComentariosLabel = New System.Windows.Forms.Label()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConveniosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConveniosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConveniosBindingNavigator.SuspendLayout()
        Me.GrupoContatoConvenio.SuspendLayout()
        CType(Me.ServicosConveniosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServicosConveniosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrupoServicosConvenio.SuspendLayout()
        Me.SuspendLayout()
        '
        'RazaoSocialLabel
        '
        RazaoSocialLabel.AutoSize = True
        RazaoSocialLabel.Location = New System.Drawing.Point(12, 45)
        RazaoSocialLabel.Name = "RazaoSocialLabel"
        RazaoSocialLabel.Size = New System.Drawing.Size(73, 13)
        RazaoSocialLabel.TabIndex = 1
        RazaoSocialLabel.Text = "Razão Social:"
        '
        'CNPJLabel
        '
        CNPJLabel.AutoSize = True
        CNPJLabel.Location = New System.Drawing.Point(48, 71)
        CNPJLabel.Name = "CNPJLabel"
        CNPJLabel.Size = New System.Drawing.Size(37, 13)
        CNPJLabel.TabIndex = 3
        CNPJLabel.Text = "CNPJ:"
        '
        'InscricaoEstadualLabel
        '
        InscricaoEstadualLabel.AutoSize = True
        InscricaoEstadualLabel.Location = New System.Drawing.Point(197, 71)
        InscricaoEstadualLabel.Name = "InscricaoEstadualLabel"
        InscricaoEstadualLabel.Size = New System.Drawing.Size(97, 13)
        InscricaoEstadualLabel.TabIndex = 5
        InscricaoEstadualLabel.Text = "Inscrição Estadual:"
        '
        'EnderecoLabel
        '
        EnderecoLabel.AutoSize = True
        EnderecoLabel.Location = New System.Drawing.Point(29, 97)
        EnderecoLabel.Name = "EnderecoLabel"
        EnderecoLabel.Size = New System.Drawing.Size(56, 13)
        EnderecoLabel.TabIndex = 7
        EnderecoLabel.Text = "Endereço:"
        '
        'CEPLabel
        '
        CEPLabel.AutoSize = True
        CEPLabel.Location = New System.Drawing.Point(54, 123)
        CEPLabel.Name = "CEPLabel"
        CEPLabel.Size = New System.Drawing.Size(31, 13)
        CEPLabel.TabIndex = 9
        CEPLabel.Text = "CEP:"
        '
        'CidadeLabel
        '
        CidadeLabel.AutoSize = True
        CidadeLabel.Location = New System.Drawing.Point(197, 123)
        CidadeLabel.Name = "CidadeLabel"
        CidadeLabel.Size = New System.Drawing.Size(43, 13)
        CidadeLabel.TabIndex = 11
        CidadeLabel.Text = "Cidade:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(42, 149)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(43, 13)
        EstadoLabel.TabIndex = 13
        EstadoLabel.Text = "Estado:"
        '
        'TelefoneLabel
        '
        TelefoneLabel.AutoSize = True
        TelefoneLabel.Location = New System.Drawing.Point(242, 149)
        TelefoneLabel.Name = "TelefoneLabel"
        TelefoneLabel.Size = New System.Drawing.Size(52, 13)
        TelefoneLabel.TabIndex = 15
        TelefoneLabel.Text = "Telefone:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(47, 175)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(38, 13)
        EmailLabel.TabIndex = 17
        EmailLabel.Text = "E-mail:"
        '
        'ContatoLabel
        '
        ContatoLabel.AutoSize = True
        ContatoLabel.Location = New System.Drawing.Point(11, 21)
        ContatoLabel.Name = "ContatoLabel"
        ContatoLabel.Size = New System.Drawing.Size(47, 13)
        ContatoLabel.TabIndex = 19
        ContatoLabel.Text = "Contato:"
        '
        'TelefoneContatoLabel
        '
        TelefoneContatoLabel.AutoSize = True
        TelefoneContatoLabel.Location = New System.Drawing.Point(6, 47)
        TelefoneContatoLabel.Name = "TelefoneContatoLabel"
        TelefoneContatoLabel.Size = New System.Drawing.Size(52, 13)
        TelefoneContatoLabel.TabIndex = 21
        TelefoneContatoLabel.Text = "Telefone:"
        '
        'RamalContatoLabel
        '
        RamalContatoLabel.AutoSize = True
        RamalContatoLabel.Location = New System.Drawing.Point(170, 47)
        RamalContatoLabel.Name = "RamalContatoLabel"
        RamalContatoLabel.Size = New System.Drawing.Size(40, 13)
        RamalContatoLabel.TabIndex = 23
        RamalContatoLabel.Text = "Ramal:"
        '
        'ComentariosLabel
        '
        ComentariosLabel.AutoSize = True
        ComentariosLabel.Location = New System.Drawing.Point(17, 288)
        ComentariosLabel.Name = "ComentariosLabel"
        ComentariosLabel.Size = New System.Drawing.Size(68, 13)
        ComentariosLabel.TabIndex = 25
        ComentariosLabel.Text = "Comentários:"
        '
        'Gerenciamento_CRAFIDataSet
        '
        Me.Gerenciamento_CRAFIDataSet.DataSetName = "Gerenciamento_CRAFIDataSet"
        Me.Gerenciamento_CRAFIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConveniosBindingSource
        '
        Me.ConveniosBindingSource.DataMember = "Convenios"
        Me.ConveniosBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'ConveniosTableAdapter
        '
        Me.ConveniosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnamneseTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CirurgiasTableAdapter = Nothing
        Me.TableAdapterManager.ConsultasTableAdapter = Nothing
        Me.TableAdapterManager.ConveniosTableAdapter = Me.ConveniosTableAdapter
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
        Me.TableAdapterManager.ServicosConveniosTableAdapter = Me.ServicosConveniosTableAdapter
        Me.TableAdapterManager.ServicosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ServicosConveniosTableAdapter
        '
        Me.ServicosConveniosTableAdapter.ClearBeforeFill = True
        '
        'ConveniosBindingNavigator
        '
        Me.ConveniosBindingNavigator.AddNewItem = Nothing
        Me.ConveniosBindingNavigator.BindingSource = Me.ConveniosBindingSource
        Me.ConveniosBindingNavigator.CountItem = Nothing
        Me.ConveniosBindingNavigator.DeleteItem = Nothing
        Me.ConveniosBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ConveniosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdicionarConvenioToolStripButton, Me.ConveniosBindingNavigatorSaveItem, Me.CancelarConvenioToolStripButton})
        Me.ConveniosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ConveniosBindingNavigator.MoveFirstItem = Nothing
        Me.ConveniosBindingNavigator.MoveLastItem = Nothing
        Me.ConveniosBindingNavigator.MoveNextItem = Nothing
        Me.ConveniosBindingNavigator.MovePreviousItem = Nothing
        Me.ConveniosBindingNavigator.Name = "ConveniosBindingNavigator"
        Me.ConveniosBindingNavigator.PositionItem = Nothing
        Me.ConveniosBindingNavigator.Size = New System.Drawing.Size(988, 25)
        Me.ConveniosBindingNavigator.TabIndex = 0
        Me.ConveniosBindingNavigator.Text = "BindingNavigator1"
        '
        'AdicionarConvenioToolStripButton
        '
        Me.AdicionarConvenioToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources.Button_White_Add
        Me.AdicionarConvenioToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AdicionarConvenioToolStripButton.Name = "AdicionarConvenioToolStripButton"
        Me.AdicionarConvenioToolStripButton.Size = New System.Drawing.Size(78, 22)
        Me.AdicionarConvenioToolStripButton.Text = "Adicionar"
        '
        'ConveniosBindingNavigatorSaveItem
        '
        Me.ConveniosBindingNavigatorSaveItem.Enabled = False
        Me.ConveniosBindingNavigatorSaveItem.Image = CType(resources.GetObject("ConveniosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ConveniosBindingNavigatorSaveItem.Name = "ConveniosBindingNavigatorSaveItem"
        Me.ConveniosBindingNavigatorSaveItem.Size = New System.Drawing.Size(58, 22)
        Me.ConveniosBindingNavigatorSaveItem.Text = "Salvar"
        '
        'CancelarConvenioToolStripButton
        '
        Me.CancelarConvenioToolStripButton.Enabled = False
        Me.CancelarConvenioToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources.Button_White_Stop
        Me.CancelarConvenioToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CancelarConvenioToolStripButton.Name = "CancelarConvenioToolStripButton"
        Me.CancelarConvenioToolStripButton.Size = New System.Drawing.Size(73, 22)
        Me.CancelarConvenioToolStripButton.Text = "Cancelar"
        '
        'RazaoSocialTextBox
        '
        Me.RazaoSocialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConveniosBindingSource, "RazaoSocial", True))
        Me.RazaoSocialTextBox.Enabled = False
        Me.RazaoSocialTextBox.Location = New System.Drawing.Point(91, 42)
        Me.RazaoSocialTextBox.Name = "RazaoSocialTextBox"
        Me.RazaoSocialTextBox.Size = New System.Drawing.Size(309, 20)
        Me.RazaoSocialTextBox.TabIndex = 2
        '
        'CNPJTextBox
        '
        Me.CNPJTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConveniosBindingSource, "CNPJ", True))
        Me.CNPJTextBox.Enabled = False
        Me.CNPJTextBox.Location = New System.Drawing.Point(91, 68)
        Me.CNPJTextBox.Name = "CNPJTextBox"
        Me.CNPJTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CNPJTextBox.TabIndex = 4
        '
        'InscricaoEstadualTextBox
        '
        Me.InscricaoEstadualTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConveniosBindingSource, "InscricaoEstadual", True))
        Me.InscricaoEstadualTextBox.Enabled = False
        Me.InscricaoEstadualTextBox.Location = New System.Drawing.Point(300, 68)
        Me.InscricaoEstadualTextBox.Name = "InscricaoEstadualTextBox"
        Me.InscricaoEstadualTextBox.Size = New System.Drawing.Size(100, 20)
        Me.InscricaoEstadualTextBox.TabIndex = 6
        '
        'EnderecoTextBox
        '
        Me.EnderecoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConveniosBindingSource, "Endereco", True))
        Me.EnderecoTextBox.Enabled = False
        Me.EnderecoTextBox.Location = New System.Drawing.Point(91, 94)
        Me.EnderecoTextBox.Name = "EnderecoTextBox"
        Me.EnderecoTextBox.Size = New System.Drawing.Size(309, 20)
        Me.EnderecoTextBox.TabIndex = 8
        '
        'CEPTextBox
        '
        Me.CEPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConveniosBindingSource, "CEP", True))
        Me.CEPTextBox.Enabled = False
        Me.CEPTextBox.Location = New System.Drawing.Point(91, 120)
        Me.CEPTextBox.Name = "CEPTextBox"
        Me.CEPTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CEPTextBox.TabIndex = 10
        '
        'CidadeTextBox
        '
        Me.CidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConveniosBindingSource, "Cidade", True))
        Me.CidadeTextBox.Enabled = False
        Me.CidadeTextBox.Location = New System.Drawing.Point(246, 120)
        Me.CidadeTextBox.Name = "CidadeTextBox"
        Me.CidadeTextBox.Size = New System.Drawing.Size(154, 20)
        Me.CidadeTextBox.TabIndex = 12
        '
        'EstadoTextBox
        '
        Me.EstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConveniosBindingSource, "Estado", True))
        Me.EstadoTextBox.Enabled = False
        Me.EstadoTextBox.Location = New System.Drawing.Point(91, 146)
        Me.EstadoTextBox.Name = "EstadoTextBox"
        Me.EstadoTextBox.Size = New System.Drawing.Size(145, 20)
        Me.EstadoTextBox.TabIndex = 14
        '
        'TelefoneTextBox
        '
        Me.TelefoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConveniosBindingSource, "Telefone", True))
        Me.TelefoneTextBox.Enabled = False
        Me.TelefoneTextBox.Location = New System.Drawing.Point(300, 146)
        Me.TelefoneTextBox.Name = "TelefoneTextBox"
        Me.TelefoneTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefoneTextBox.TabIndex = 16
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConveniosBindingSource, "Email", True))
        Me.EmailTextBox.Enabled = False
        Me.EmailTextBox.Location = New System.Drawing.Point(91, 172)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(309, 20)
        Me.EmailTextBox.TabIndex = 18
        '
        'ContatoTextBox
        '
        Me.ContatoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConveniosBindingSource, "Contato", True))
        Me.ContatoTextBox.Location = New System.Drawing.Point(64, 18)
        Me.ContatoTextBox.Name = "ContatoTextBox"
        Me.ContatoTextBox.Size = New System.Drawing.Size(239, 20)
        Me.ContatoTextBox.TabIndex = 20
        '
        'TelefoneContatoTextBox
        '
        Me.TelefoneContatoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConveniosBindingSource, "TelefoneContato", True))
        Me.TelefoneContatoTextBox.Location = New System.Drawing.Point(64, 44)
        Me.TelefoneContatoTextBox.Name = "TelefoneContatoTextBox"
        Me.TelefoneContatoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefoneContatoTextBox.TabIndex = 22
        '
        'RamalContatoTextBox
        '
        Me.RamalContatoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConveniosBindingSource, "RamalContato", True))
        Me.RamalContatoTextBox.Location = New System.Drawing.Point(216, 44)
        Me.RamalContatoTextBox.Name = "RamalContatoTextBox"
        Me.RamalContatoTextBox.Size = New System.Drawing.Size(87, 20)
        Me.RamalContatoTextBox.TabIndex = 24
        '
        'ComentariosTextBox
        '
        Me.ComentariosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConveniosBindingSource, "Comentarios", True))
        Me.ComentariosTextBox.Enabled = False
        Me.ComentariosTextBox.Location = New System.Drawing.Point(91, 285)
        Me.ComentariosTextBox.Multiline = True
        Me.ComentariosTextBox.Name = "ComentariosTextBox"
        Me.ComentariosTextBox.Size = New System.Drawing.Size(309, 100)
        Me.ComentariosTextBox.TabIndex = 26
        '
        'GrupoContatoConvenio
        '
        Me.GrupoContatoConvenio.Controls.Add(ContatoLabel)
        Me.GrupoContatoConvenio.Controls.Add(Me.ContatoTextBox)
        Me.GrupoContatoConvenio.Controls.Add(Me.TelefoneContatoTextBox)
        Me.GrupoContatoConvenio.Controls.Add(RamalContatoLabel)
        Me.GrupoContatoConvenio.Controls.Add(TelefoneContatoLabel)
        Me.GrupoContatoConvenio.Controls.Add(Me.RamalContatoTextBox)
        Me.GrupoContatoConvenio.Enabled = False
        Me.GrupoContatoConvenio.Location = New System.Drawing.Point(91, 198)
        Me.GrupoContatoConvenio.Name = "GrupoContatoConvenio"
        Me.GrupoContatoConvenio.Size = New System.Drawing.Size(309, 81)
        Me.GrupoContatoConvenio.TabIndex = 27
        Me.GrupoContatoConvenio.TabStop = False
        Me.GrupoContatoConvenio.Text = "Contato"
        '
        'ServicosConveniosBindingSource
        '
        Me.ServicosConveniosBindingSource.DataMember = "ServicosConvenios"
        Me.ServicosConveniosBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'ServicosConveniosDataGridView
        '
        Me.ServicosConveniosDataGridView.AutoGenerateColumns = False
        Me.ServicosConveniosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ServicosConveniosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ServicosConveniosDataGridView.DataSource = Me.ServicosConveniosBindingSource
        Me.ServicosConveniosDataGridView.Location = New System.Drawing.Point(6, 19)
        Me.ServicosConveniosDataGridView.Name = "ServicosConveniosDataGridView"
        Me.ServicosConveniosDataGridView.Size = New System.Drawing.Size(562, 318)
        Me.ServicosConveniosDataGridView.TabIndex = 27
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CNPJ"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CNPJ"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nome"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Codigo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ValorUnitario"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn4.HeaderText = "Valor Unitário"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'GrupoServicosConvenio
        '
        Me.GrupoServicosConvenio.Controls.Add(Me.ServicosConveniosDataGridView)
        Me.GrupoServicosConvenio.Enabled = False
        Me.GrupoServicosConvenio.Location = New System.Drawing.Point(406, 42)
        Me.GrupoServicosConvenio.Name = "GrupoServicosConvenio"
        Me.GrupoServicosConvenio.Size = New System.Drawing.Size(575, 343)
        Me.GrupoServicosConvenio.TabIndex = 28
        Me.GrupoServicosConvenio.TabStop = False
        Me.GrupoServicosConvenio.Text = "Serviços a serem prestados"
        '
        'LogControleTableAdapter
        '
        Me.LogControleTableAdapter.ClearBeforeFill = True
        '
        'form_incluir_convenio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(988, 392)
        Me.Controls.Add(Me.GrupoServicosConvenio)
        Me.Controls.Add(Me.GrupoContatoConvenio)
        Me.Controls.Add(ComentariosLabel)
        Me.Controls.Add(Me.ComentariosTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(TelefoneLabel)
        Me.Controls.Add(Me.TelefoneTextBox)
        Me.Controls.Add(EstadoLabel)
        Me.Controls.Add(Me.EstadoTextBox)
        Me.Controls.Add(CidadeLabel)
        Me.Controls.Add(Me.CidadeTextBox)
        Me.Controls.Add(CEPLabel)
        Me.Controls.Add(Me.CEPTextBox)
        Me.Controls.Add(EnderecoLabel)
        Me.Controls.Add(Me.EnderecoTextBox)
        Me.Controls.Add(InscricaoEstadualLabel)
        Me.Controls.Add(Me.InscricaoEstadualTextBox)
        Me.Controls.Add(CNPJLabel)
        Me.Controls.Add(Me.CNPJTextBox)
        Me.Controls.Add(RazaoSocialLabel)
        Me.Controls.Add(Me.RazaoSocialTextBox)
        Me.Controls.Add(Me.ConveniosBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_incluir_convenio"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Incluir Convênio"
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConveniosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConveniosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConveniosBindingNavigator.ResumeLayout(False)
        Me.ConveniosBindingNavigator.PerformLayout()
        Me.GrupoContatoConvenio.ResumeLayout(False)
        Me.GrupoContatoConvenio.PerformLayout()
        CType(Me.ServicosConveniosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServicosConveniosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrupoServicosConvenio.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Gerenciamento_CRAFIDataSet As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet
    Friend WithEvents ConveniosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConveniosTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ConveniosTableAdapter
    Friend WithEvents TableAdapterManager As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ConveniosBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents ConveniosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents RazaoSocialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CNPJTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InscricaoEstadualTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EnderecoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CEPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CidadeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EstadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContatoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefoneContatoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RamalContatoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComentariosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GrupoContatoConvenio As System.Windows.Forms.GroupBox
    Friend WithEvents ServicosConveniosTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ServicosConveniosTableAdapter
    Friend WithEvents AdicionarConvenioToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CancelarConvenioToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ServicosConveniosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ServicosConveniosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GrupoServicosConvenio As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LogControleTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter
End Class
