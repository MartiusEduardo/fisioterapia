<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_dre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_dre))
        Me.Gerenciamento_CRAFIDataSet = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet()
        Me.ReceitaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReceitaTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ReceitaTableAdapter()
        Me.TableAdapterManager = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager()
        Me.CustoFixoTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.CustoFixoTableAdapter()
        Me.CustoVariavelTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.CustoVariavelTableAdapter()
        Me.DespesaFixaTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.DespesaFixaTableAdapter()
        Me.DespesaVariavelTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.DespesaVariavelTableAdapter()
        Me.ImpostosSobreVendasTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ImpostosSobreVendasTableAdapter()
        Me.LoginTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LoginTableAdapter()
        Me.ImpostosSobreVendasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustoFixoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgv_dre = New System.Windows.Forms.DataGridView()
        Me.NomeColuna = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorColuna = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mc_dre = New System.Windows.Forms.MonthCalendar()
        Me.GrupoFiltrarPor = New System.Windows.Forms.GroupBox()
        Me.GrupoProfissional = New System.Windows.Forms.GroupBox()
        Me.btn_modificar_usuario_total = New System.Windows.Forms.Button()
        Me.UtilizarProfissionalCheckBox = New System.Windows.Forms.CheckBox()
        Me.ProfissionalLabel = New System.Windows.Forms.Label()
        Me.rdo_profissional = New System.Windows.Forms.RadioButton()
        Me.rdo_total = New System.Windows.Forms.RadioButton()
        Me.ProfissionalComboBox = New System.Windows.Forms.ComboBox()
        Me.LoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rdo_ano = New System.Windows.Forms.RadioButton()
        Me.rdo_mes = New System.Windows.Forms.RadioButton()
        Me.rdo_dia = New System.Windows.Forms.RadioButton()
        Me.CustoVariavelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DespesaFixaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DespesaVariavelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GrupoDatasDRE = New System.Windows.Forms.GroupBox()
        Me.rdo_data_baixa = New System.Windows.Forms.RadioButton()
        Me.rdo_data_emissao = New System.Windows.Forms.RadioButton()
        Me.rdo_data_cadastro = New System.Windows.Forms.RadioButton()
        Me.rdo_data_vencimento = New System.Windows.Forms.RadioButton()
        Me.dgv_tabelas_dre = New System.Windows.Forms.DataGridView()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceitaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImpostosSobreVendasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustoFixoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_dre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrupoFiltrarPor.SuspendLayout()
        Me.GrupoProfissional.SuspendLayout()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustoVariavelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DespesaFixaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DespesaVariavelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrupoDatasDRE.SuspendLayout()
        CType(Me.dgv_tabelas_dre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Gerenciamento_CRAFIDataSet
        '
        Me.Gerenciamento_CRAFIDataSet.DataSetName = "Gerenciamento_CRAFIDataSet"
        Me.Gerenciamento_CRAFIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReceitaBindingSource
        '
        Me.ReceitaBindingSource.DataMember = "Receita"
        Me.ReceitaBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
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
        Me.TableAdapterManager.ContatosTableAdapter = Nothing
        Me.TableAdapterManager.ConveniosTableAdapter = Nothing
        Me.TableAdapterManager.CustoFixoTableAdapter = Me.CustoFixoTableAdapter
        Me.TableAdapterManager.CustoVariavelTableAdapter = Me.CustoVariavelTableAdapter
        Me.TableAdapterManager.DespesaFixaTableAdapter = Me.DespesaFixaTableAdapter
        Me.TableAdapterManager.DespesaVariavelTableAdapter = Me.DespesaVariavelTableAdapter
        Me.TableAdapterManager.EvolucaoClinicaTableAdapter = Nothing
        Me.TableAdapterManager.ExamesComplementaresTableAdapter = Nothing
        Me.TableAdapterManager.ImpostosSobreVendasTableAdapter = Me.ImpostosSobreVendasTableAdapter
        Me.TableAdapterManager.LogControleTableAdapter = Nothing
        Me.TableAdapterManager.LogEntradaTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Me.LoginTableAdapter
        Me.TableAdapterManager.PacientesTableAdapter = Nothing
        Me.TableAdapterManager.ProfissionaisTableAdapter = Nothing
        Me.TableAdapterManager.ReceitaTableAdapter = Me.ReceitaTableAdapter
        Me.TableAdapterManager.ServicosConveniosTableAdapter = Nothing
        Me.TableAdapterManager.ServicosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustoFixoTableAdapter
        '
        Me.CustoFixoTableAdapter.ClearBeforeFill = True
        '
        'CustoVariavelTableAdapter
        '
        Me.CustoVariavelTableAdapter.ClearBeforeFill = True
        '
        'DespesaFixaTableAdapter
        '
        Me.DespesaFixaTableAdapter.ClearBeforeFill = True
        '
        'DespesaVariavelTableAdapter
        '
        Me.DespesaVariavelTableAdapter.ClearBeforeFill = True
        '
        'ImpostosSobreVendasTableAdapter
        '
        Me.ImpostosSobreVendasTableAdapter.ClearBeforeFill = True
        '
        'LoginTableAdapter
        '
        Me.LoginTableAdapter.ClearBeforeFill = True
        '
        'ImpostosSobreVendasBindingSource
        '
        Me.ImpostosSobreVendasBindingSource.DataMember = "ImpostosSobreVendas"
        Me.ImpostosSobreVendasBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'CustoFixoBindingSource
        '
        Me.CustoFixoBindingSource.DataMember = "CustoFixo"
        Me.CustoFixoBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'dgv_dre
        '
        Me.dgv_dre.AllowUserToAddRows = False
        Me.dgv_dre.AllowUserToDeleteRows = False
        Me.dgv_dre.BackgroundColor = System.Drawing.Color.White
        Me.dgv_dre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dre.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomeColuna, Me.ValorColuna})
        Me.dgv_dre.GridColor = System.Drawing.Color.White
        Me.dgv_dre.Location = New System.Drawing.Point(1, 12)
        Me.dgv_dre.Name = "dgv_dre"
        Me.dgv_dre.ReadOnly = True
        Me.dgv_dre.RowHeadersVisible = False
        Me.dgv_dre.Size = New System.Drawing.Size(639, 449)
        Me.dgv_dre.TabIndex = 0
        '
        'NomeColuna
        '
        Me.NomeColuna.HeaderText = "Nome"
        Me.NomeColuna.Name = "NomeColuna"
        Me.NomeColuna.ReadOnly = True
        Me.NomeColuna.Width = 300
        '
        'ValorColuna
        '
        Me.ValorColuna.HeaderText = "Valor"
        Me.ValorColuna.Name = "ValorColuna"
        Me.ValorColuna.ReadOnly = True
        '
        'mc_dre
        '
        Me.mc_dre.CalendarDimensions = New System.Drawing.Size(3, 2)
        Me.mc_dre.Location = New System.Drawing.Point(646, 150)
        Me.mc_dre.Name = "mc_dre"
        Me.mc_dre.TabIndex = 1
        '
        'GrupoFiltrarPor
        '
        Me.GrupoFiltrarPor.Controls.Add(Me.GrupoProfissional)
        Me.GrupoFiltrarPor.Controls.Add(Me.rdo_ano)
        Me.GrupoFiltrarPor.Controls.Add(Me.rdo_mes)
        Me.GrupoFiltrarPor.Controls.Add(Me.rdo_dia)
        Me.GrupoFiltrarPor.Location = New System.Drawing.Point(786, 12)
        Me.GrupoFiltrarPor.Name = "GrupoFiltrarPor"
        Me.GrupoFiltrarPor.Size = New System.Drawing.Size(345, 126)
        Me.GrupoFiltrarPor.TabIndex = 2
        Me.GrupoFiltrarPor.TabStop = False
        Me.GrupoFiltrarPor.Text = "Filtrar por"
        '
        'GrupoProfissional
        '
        Me.GrupoProfissional.Controls.Add(Me.btn_modificar_usuario_total)
        Me.GrupoProfissional.Controls.Add(Me.UtilizarProfissionalCheckBox)
        Me.GrupoProfissional.Controls.Add(Me.ProfissionalLabel)
        Me.GrupoProfissional.Controls.Add(Me.rdo_profissional)
        Me.GrupoProfissional.Controls.Add(Me.rdo_total)
        Me.GrupoProfissional.Controls.Add(Me.ProfissionalComboBox)
        Me.GrupoProfissional.Location = New System.Drawing.Point(56, 11)
        Me.GrupoProfissional.Name = "GrupoProfissional"
        Me.GrupoProfissional.Size = New System.Drawing.Size(276, 106)
        Me.GrupoProfissional.TabIndex = 5
        Me.GrupoProfissional.TabStop = False
        Me.GrupoProfissional.Text = "Profissional"
        '
        'btn_modificar_usuario_total
        '
        Me.btn_modificar_usuario_total.Location = New System.Drawing.Point(146, 17)
        Me.btn_modificar_usuario_total.Name = "btn_modificar_usuario_total"
        Me.btn_modificar_usuario_total.Size = New System.Drawing.Size(119, 23)
        Me.btn_modificar_usuario_total.TabIndex = 9
        Me.btn_modificar_usuario_total.Text = "Modificar usuário total"
        Me.btn_modificar_usuario_total.UseVisualStyleBackColor = True
        '
        'UtilizarProfissionalCheckBox
        '
        Me.UtilizarProfissionalCheckBox.AutoSize = True
        Me.UtilizarProfissionalCheckBox.Location = New System.Drawing.Point(7, 43)
        Me.UtilizarProfissionalCheckBox.Name = "UtilizarProfissionalCheckBox"
        Me.UtilizarProfissionalCheckBox.Size = New System.Drawing.Size(150, 17)
        Me.UtilizarProfissionalCheckBox.TabIndex = 8
        Me.UtilizarProfissionalCheckBox.Text = "Utilizar profissional no total"
        Me.UtilizarProfissionalCheckBox.UseVisualStyleBackColor = True
        '
        'ProfissionalLabel
        '
        Me.ProfissionalLabel.AutoSize = True
        Me.ProfissionalLabel.Location = New System.Drawing.Point(6, 63)
        Me.ProfissionalLabel.Name = "ProfissionalLabel"
        Me.ProfissionalLabel.Size = New System.Drawing.Size(63, 13)
        Me.ProfissionalLabel.TabIndex = 7
        Me.ProfissionalLabel.Text = "Profissional:"
        '
        'rdo_profissional
        '
        Me.rdo_profissional.AutoSize = True
        Me.rdo_profissional.Location = New System.Drawing.Point(62, 20)
        Me.rdo_profissional.Name = "rdo_profissional"
        Me.rdo_profissional.Size = New System.Drawing.Size(78, 17)
        Me.rdo_profissional.TabIndex = 6
        Me.rdo_profissional.Text = "Profissional"
        Me.rdo_profissional.UseVisualStyleBackColor = True
        '
        'rdo_total
        '
        Me.rdo_total.AutoSize = True
        Me.rdo_total.Checked = True
        Me.rdo_total.Location = New System.Drawing.Point(7, 20)
        Me.rdo_total.Name = "rdo_total"
        Me.rdo_total.Size = New System.Drawing.Size(49, 17)
        Me.rdo_total.TabIndex = 5
        Me.rdo_total.TabStop = True
        Me.rdo_total.Text = "Total"
        Me.rdo_total.UseVisualStyleBackColor = True
        '
        'ProfissionalComboBox
        '
        Me.ProfissionalComboBox.DataSource = Me.LoginBindingSource
        Me.ProfissionalComboBox.DisplayMember = "Usuario"
        Me.ProfissionalComboBox.FormattingEnabled = True
        Me.ProfissionalComboBox.Location = New System.Drawing.Point(6, 79)
        Me.ProfissionalComboBox.Name = "ProfissionalComboBox"
        Me.ProfissionalComboBox.Size = New System.Drawing.Size(188, 21)
        Me.ProfissionalComboBox.TabIndex = 4
        Me.ProfissionalComboBox.ValueMember = "Usuario"
        '
        'LoginBindingSource
        '
        Me.LoginBindingSource.DataMember = "Login"
        Me.LoginBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'rdo_ano
        '
        Me.rdo_ano.AutoSize = True
        Me.rdo_ano.Location = New System.Drawing.Point(6, 66)
        Me.rdo_ano.Name = "rdo_ano"
        Me.rdo_ano.Size = New System.Drawing.Size(44, 17)
        Me.rdo_ano.TabIndex = 2
        Me.rdo_ano.Text = "Ano"
        Me.rdo_ano.UseVisualStyleBackColor = True
        '
        'rdo_mes
        '
        Me.rdo_mes.AutoSize = True
        Me.rdo_mes.Checked = True
        Me.rdo_mes.Location = New System.Drawing.Point(6, 42)
        Me.rdo_mes.Name = "rdo_mes"
        Me.rdo_mes.Size = New System.Drawing.Size(45, 17)
        Me.rdo_mes.TabIndex = 1
        Me.rdo_mes.TabStop = True
        Me.rdo_mes.Text = "Mês"
        Me.rdo_mes.UseVisualStyleBackColor = True
        '
        'rdo_dia
        '
        Me.rdo_dia.AutoSize = True
        Me.rdo_dia.Location = New System.Drawing.Point(6, 19)
        Me.rdo_dia.Name = "rdo_dia"
        Me.rdo_dia.Size = New System.Drawing.Size(41, 17)
        Me.rdo_dia.TabIndex = 0
        Me.rdo_dia.Text = "Dia"
        Me.rdo_dia.UseVisualStyleBackColor = True
        '
        'CustoVariavelBindingSource
        '
        Me.CustoVariavelBindingSource.DataMember = "CustoVariavel"
        Me.CustoVariavelBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'DespesaFixaBindingSource
        '
        Me.DespesaFixaBindingSource.DataMember = "DespesaFixa"
        Me.DespesaFixaBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'DespesaVariavelBindingSource
        '
        Me.DespesaVariavelBindingSource.DataMember = "DespesaVariavel"
        Me.DespesaVariavelBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'GrupoDatasDRE
        '
        Me.GrupoDatasDRE.Controls.Add(Me.rdo_data_baixa)
        Me.GrupoDatasDRE.Controls.Add(Me.rdo_data_emissao)
        Me.GrupoDatasDRE.Controls.Add(Me.rdo_data_cadastro)
        Me.GrupoDatasDRE.Controls.Add(Me.rdo_data_vencimento)
        Me.GrupoDatasDRE.Location = New System.Drawing.Point(646, 12)
        Me.GrupoDatasDRE.Name = "GrupoDatasDRE"
        Me.GrupoDatasDRE.Size = New System.Drawing.Size(134, 126)
        Me.GrupoDatasDRE.TabIndex = 4
        Me.GrupoDatasDRE.TabStop = False
        Me.GrupoDatasDRE.Text = "Datas"
        '
        'rdo_data_baixa
        '
        Me.rdo_data_baixa.AutoSize = True
        Me.rdo_data_baixa.Location = New System.Drawing.Point(6, 89)
        Me.rdo_data_baixa.Name = "rdo_data_baixa"
        Me.rdo_data_baixa.Size = New System.Drawing.Size(92, 17)
        Me.rdo_data_baixa.TabIndex = 3
        Me.rdo_data_baixa.Text = "Data de Baixa"
        Me.rdo_data_baixa.UseVisualStyleBackColor = True
        '
        'rdo_data_emissao
        '
        Me.rdo_data_emissao.AutoSize = True
        Me.rdo_data_emissao.Location = New System.Drawing.Point(6, 66)
        Me.rdo_data_emissao.Name = "rdo_data_emissao"
        Me.rdo_data_emissao.Size = New System.Drawing.Size(105, 17)
        Me.rdo_data_emissao.TabIndex = 2
        Me.rdo_data_emissao.Text = "Data de Emissão"
        Me.rdo_data_emissao.UseVisualStyleBackColor = True
        '
        'rdo_data_cadastro
        '
        Me.rdo_data_cadastro.AutoSize = True
        Me.rdo_data_cadastro.Location = New System.Drawing.Point(6, 43)
        Me.rdo_data_cadastro.Name = "rdo_data_cadastro"
        Me.rdo_data_cadastro.Size = New System.Drawing.Size(108, 17)
        Me.rdo_data_cadastro.TabIndex = 1
        Me.rdo_data_cadastro.Text = "Data de Cadastro"
        Me.rdo_data_cadastro.UseVisualStyleBackColor = True
        '
        'rdo_data_vencimento
        '
        Me.rdo_data_vencimento.AutoSize = True
        Me.rdo_data_vencimento.Checked = True
        Me.rdo_data_vencimento.Location = New System.Drawing.Point(6, 19)
        Me.rdo_data_vencimento.Name = "rdo_data_vencimento"
        Me.rdo_data_vencimento.Size = New System.Drawing.Size(122, 17)
        Me.rdo_data_vencimento.TabIndex = 0
        Me.rdo_data_vencimento.TabStop = True
        Me.rdo_data_vencimento.Text = "Data de Vencimento"
        Me.rdo_data_vencimento.UseVisualStyleBackColor = True
        '
        'dgv_tabelas_dre
        '
        Me.dgv_tabelas_dre.AllowUserToAddRows = False
        Me.dgv_tabelas_dre.AllowUserToDeleteRows = False
        Me.dgv_tabelas_dre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tabelas_dre.Location = New System.Drawing.Point(1137, 12)
        Me.dgv_tabelas_dre.Name = "dgv_tabelas_dre"
        Me.dgv_tabelas_dre.ReadOnly = True
        Me.dgv_tabelas_dre.Size = New System.Drawing.Size(198, 126)
        Me.dgv_tabelas_dre.TabIndex = 5
        Me.dgv_tabelas_dre.Visible = False
        '
        'form_dre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(870, 307)
        Me.Controls.Add(Me.dgv_tabelas_dre)
        Me.Controls.Add(Me.GrupoDatasDRE)
        Me.Controls.Add(Me.GrupoFiltrarPor)
        Me.Controls.Add(Me.mc_dre)
        Me.Controls.Add(Me.dgv_dre)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_dre"
        Me.ShowIcon = False
        Me.Text = "Demonstração do Resulado do Exercício"
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceitaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImpostosSobreVendasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustoFixoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_dre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrupoFiltrarPor.ResumeLayout(False)
        Me.GrupoFiltrarPor.PerformLayout()
        Me.GrupoProfissional.ResumeLayout(False)
        Me.GrupoProfissional.PerformLayout()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustoVariavelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DespesaFixaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DespesaVariavelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrupoDatasDRE.ResumeLayout(False)
        Me.GrupoDatasDRE.PerformLayout()
        CType(Me.dgv_tabelas_dre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gerenciamento_CRAFIDataSet As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet
    Friend WithEvents ReceitaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReceitaTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ReceitaTableAdapter
    Friend WithEvents TableAdapterManager As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ImpostosSobreVendasTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ImpostosSobreVendasTableAdapter
    Friend WithEvents ImpostosSobreVendasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustoFixoTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.CustoFixoTableAdapter
    Friend WithEvents CustoFixoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dgv_dre As System.Windows.Forms.DataGridView
    Friend WithEvents NomeColuna As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorColuna As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mc_dre As System.Windows.Forms.MonthCalendar
    Friend WithEvents GrupoFiltrarPor As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_ano As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_mes As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_dia As System.Windows.Forms.RadioButton
    Friend WithEvents CustoVariavelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustoVariavelTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.CustoVariavelTableAdapter
    Friend WithEvents DespesaFixaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DespesaFixaTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.DespesaFixaTableAdapter
    Friend WithEvents DespesaVariavelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DespesaVariavelTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.DespesaVariavelTableAdapter
    Friend WithEvents GrupoDatasDRE As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_data_baixa As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_data_emissao As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_data_cadastro As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_data_vencimento As System.Windows.Forms.RadioButton
    Friend WithEvents dgv_tabelas_dre As System.Windows.Forms.DataGridView
    Friend WithEvents ProfissionalComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents LoginBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LoginTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LoginTableAdapter
    Friend WithEvents GrupoProfissional As System.Windows.Forms.GroupBox
    Friend WithEvents ProfissionalLabel As System.Windows.Forms.Label
    Friend WithEvents rdo_profissional As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_total As System.Windows.Forms.RadioButton
    Friend WithEvents UtilizarProfissionalCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents btn_modificar_usuario_total As System.Windows.Forms.Button
End Class
