<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_relatorio_demonstracao_do_resultado_do_exercicio
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_relatorio_demonstracao_do_resultado_do_exercicio))
        Me.ReceitaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gerenciamento_CRAFIDataSet = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet()
        Me.CustoFixoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImpostosSobreVendasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustoVariavelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DespesaFixaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DespesaVariavelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DREReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReceitaTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ReceitaTableAdapter()
        Me.CustoFixoTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.CustoFixoTableAdapter()
        Me.ImpostosSobreVendasTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ImpostosSobreVendasTableAdapter()
        Me.CustoVariavelTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.CustoVariavelTableAdapter()
        Me.TableAdapterManager = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager()
        Me.DespesaFixaTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.DespesaFixaTableAdapter()
        Me.DespesaVariavelTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.DespesaVariavelTableAdapter()
        Me.mc_relatorio_dre = New System.Windows.Forms.MonthCalendar()
        Me.GrupoDatasDRE = New System.Windows.Forms.GroupBox()
        Me.rdo_data_baixa = New System.Windows.Forms.RadioButton()
        Me.rdo_data_emissao = New System.Windows.Forms.RadioButton()
        Me.rdo_data_cadastro = New System.Windows.Forms.RadioButton()
        Me.rdo_data_vencimento = New System.Windows.Forms.RadioButton()
        Me.GrupoFiltrarPor = New System.Windows.Forms.GroupBox()
        Me.GrupoProfissional = New System.Windows.Forms.GroupBox()
        Me.ProfissionalLabel = New System.Windows.Forms.Label()
        Me.UtilizarProfissionalCheckBox = New System.Windows.Forms.CheckBox()
        Me.ProfissionalComboBox = New System.Windows.Forms.ComboBox()
        Me.LoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rdo_profissional = New System.Windows.Forms.RadioButton()
        Me.rdo_total = New System.Windows.Forms.RadioButton()
        Me.rdo_ano = New System.Windows.Forms.RadioButton()
        Me.rdo_mes = New System.Windows.Forms.RadioButton()
        Me.rdo_dia = New System.Windows.Forms.RadioButton()
        Me.LoginTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LoginTableAdapter()
        CType(Me.ReceitaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustoFixoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImpostosSobreVendasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustoVariavelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DespesaFixaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DespesaVariavelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrupoDatasDRE.SuspendLayout()
        Me.GrupoFiltrarPor.SuspendLayout()
        Me.GrupoProfissional.SuspendLayout()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'CustoFixoBindingSource
        '
        Me.CustoFixoBindingSource.DataMember = "CustoFixo"
        Me.CustoFixoBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'ImpostosSobreVendasBindingSource
        '
        Me.ImpostosSobreVendasBindingSource.DataMember = "ImpostosSobreVendas"
        Me.ImpostosSobreVendasBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
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
        'DREReportViewer
        '
        ReportDataSource1.Name = "DREDataSet"
        ReportDataSource1.Value = Me.ReceitaBindingSource
        ReportDataSource2.Name = "CustoFixoDataSet"
        ReportDataSource2.Value = Me.CustoFixoBindingSource
        ReportDataSource3.Name = "ImpostosDataSet"
        ReportDataSource3.Value = Me.ImpostosSobreVendasBindingSource
        ReportDataSource4.Name = "CustoVariavelDataSet"
        ReportDataSource4.Value = Me.CustoVariavelBindingSource
        ReportDataSource5.Name = "DespesaFixaDataSet"
        ReportDataSource5.Value = Me.DespesaFixaBindingSource
        ReportDataSource6.Name = "DespesaVariavelDataSet"
        ReportDataSource6.Value = Me.DespesaVariavelBindingSource
        Me.DREReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.DREReportViewer.LocalReport.DataSources.Add(ReportDataSource2)
        Me.DREReportViewer.LocalReport.DataSources.Add(ReportDataSource3)
        Me.DREReportViewer.LocalReport.DataSources.Add(ReportDataSource4)
        Me.DREReportViewer.LocalReport.DataSources.Add(ReportDataSource5)
        Me.DREReportViewer.LocalReport.DataSources.Add(ReportDataSource6)
        Me.DREReportViewer.LocalReport.ReportEmbeddedResource = "Gerenciamento_CRAFI.DREReport.rdlc"
        Me.DREReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.DREReportViewer.Name = "DREReportViewer"
        Me.DREReportViewer.Size = New System.Drawing.Size(627, 439)
        Me.DREReportViewer.TabIndex = 0
        '
        'ReceitaTableAdapter
        '
        Me.ReceitaTableAdapter.ClearBeforeFill = True
        '
        'CustoFixoTableAdapter
        '
        Me.CustoFixoTableAdapter.ClearBeforeFill = True
        '
        'ImpostosSobreVendasTableAdapter
        '
        Me.ImpostosSobreVendasTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.PacientesTableAdapter = Nothing
        Me.TableAdapterManager.ProfissionaisTableAdapter = Nothing
        Me.TableAdapterManager.ReceitaTableAdapter = Me.ReceitaTableAdapter
        Me.TableAdapterManager.ServicosConveniosTableAdapter = Nothing
        Me.TableAdapterManager.ServicosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DespesaFixaTableAdapter
        '
        Me.DespesaFixaTableAdapter.ClearBeforeFill = True
        '
        'DespesaVariavelTableAdapter
        '
        Me.DespesaVariavelTableAdapter.ClearBeforeFill = True
        '
        'mc_relatorio_dre
        '
        Me.mc_relatorio_dre.CalendarDimensions = New System.Drawing.Size(3, 2)
        Me.mc_relatorio_dre.Location = New System.Drawing.Point(643, 128)
        Me.mc_relatorio_dre.Name = "mc_relatorio_dre"
        Me.mc_relatorio_dre.TabIndex = 1
        '
        'GrupoDatasDRE
        '
        Me.GrupoDatasDRE.Controls.Add(Me.rdo_data_baixa)
        Me.GrupoDatasDRE.Controls.Add(Me.rdo_data_emissao)
        Me.GrupoDatasDRE.Controls.Add(Me.rdo_data_cadastro)
        Me.GrupoDatasDRE.Controls.Add(Me.rdo_data_vencimento)
        Me.GrupoDatasDRE.Location = New System.Drawing.Point(643, 0)
        Me.GrupoDatasDRE.Name = "GrupoDatasDRE"
        Me.GrupoDatasDRE.Size = New System.Drawing.Size(200, 117)
        Me.GrupoDatasDRE.TabIndex = 7
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
        'GrupoFiltrarPor
        '
        Me.GrupoFiltrarPor.Controls.Add(Me.GrupoProfissional)
        Me.GrupoFiltrarPor.Controls.Add(Me.rdo_ano)
        Me.GrupoFiltrarPor.Controls.Add(Me.rdo_mes)
        Me.GrupoFiltrarPor.Controls.Add(Me.rdo_dia)
        Me.GrupoFiltrarPor.Location = New System.Drawing.Point(849, 0)
        Me.GrupoFiltrarPor.Name = "GrupoFiltrarPor"
        Me.GrupoFiltrarPor.Size = New System.Drawing.Size(387, 117)
        Me.GrupoFiltrarPor.TabIndex = 6
        Me.GrupoFiltrarPor.TabStop = False
        Me.GrupoFiltrarPor.Text = "Filtrar por"
        '
        'GrupoProfissional
        '
        Me.GrupoProfissional.Controls.Add(Me.ProfissionalLabel)
        Me.GrupoProfissional.Controls.Add(Me.UtilizarProfissionalCheckBox)
        Me.GrupoProfissional.Controls.Add(Me.ProfissionalComboBox)
        Me.GrupoProfissional.Controls.Add(Me.rdo_profissional)
        Me.GrupoProfissional.Controls.Add(Me.rdo_total)
        Me.GrupoProfissional.Location = New System.Drawing.Point(57, 19)
        Me.GrupoProfissional.Name = "GrupoProfissional"
        Me.GrupoProfissional.Size = New System.Drawing.Size(312, 87)
        Me.GrupoProfissional.TabIndex = 6
        Me.GrupoProfissional.TabStop = False
        Me.GrupoProfissional.Text = "Profissional"
        '
        'ProfissionalLabel
        '
        Me.ProfissionalLabel.AutoSize = True
        Me.ProfissionalLabel.Location = New System.Drawing.Point(6, 47)
        Me.ProfissionalLabel.Name = "ProfissionalLabel"
        Me.ProfissionalLabel.Size = New System.Drawing.Size(63, 13)
        Me.ProfissionalLabel.TabIndex = 9
        Me.ProfissionalLabel.Text = "Profissional:"
        '
        'UtilizarProfissionalCheckBox
        '
        Me.UtilizarProfissionalCheckBox.AutoSize = True
        Me.UtilizarProfissionalCheckBox.Location = New System.Drawing.Point(146, 21)
        Me.UtilizarProfissionalCheckBox.Name = "UtilizarProfissionalCheckBox"
        Me.UtilizarProfissionalCheckBox.Size = New System.Drawing.Size(150, 17)
        Me.UtilizarProfissionalCheckBox.TabIndex = 8
        Me.UtilizarProfissionalCheckBox.Text = "Utilizar profissional no total"
        Me.UtilizarProfissionalCheckBox.UseVisualStyleBackColor = True
        '
        'ProfissionalComboBox
        '
        Me.ProfissionalComboBox.DataSource = Me.LoginBindingSource
        Me.ProfissionalComboBox.DisplayMember = "Usuario"
        Me.ProfissionalComboBox.FormattingEnabled = True
        Me.ProfissionalComboBox.Location = New System.Drawing.Point(75, 44)
        Me.ProfissionalComboBox.Name = "ProfissionalComboBox"
        Me.ProfissionalComboBox.Size = New System.Drawing.Size(221, 21)
        Me.ProfissionalComboBox.TabIndex = 4
        Me.ProfissionalComboBox.ValueMember = "Usuario"
        '
        'LoginBindingSource
        '
        Me.LoginBindingSource.DataMember = "Login"
        Me.LoginBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
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
        'LoginTableAdapter
        '
        Me.LoginTableAdapter.ClearBeforeFill = True
        '
        'form_relatorio_demonstracao_do_resultado_do_exercicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(846, 265)
        Me.Controls.Add(Me.GrupoDatasDRE)
        Me.Controls.Add(Me.GrupoFiltrarPor)
        Me.Controls.Add(Me.mc_relatorio_dre)
        Me.Controls.Add(Me.DREReportViewer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_relatorio_demonstracao_do_resultado_do_exercicio"
        Me.ShowIcon = False
        Me.Text = "Relatório de Demonstração do Resultado do Exercício"
        CType(Me.ReceitaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustoFixoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImpostosSobreVendasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustoVariavelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DespesaFixaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DespesaVariavelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrupoDatasDRE.ResumeLayout(False)
        Me.GrupoDatasDRE.PerformLayout()
        Me.GrupoFiltrarPor.ResumeLayout(False)
        Me.GrupoFiltrarPor.PerformLayout()
        Me.GrupoProfissional.ResumeLayout(False)
        Me.GrupoProfissional.PerformLayout()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DREReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReceitaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Gerenciamento_CRAFIDataSet As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet
    Friend WithEvents CustoFixoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ImpostosSobreVendasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReceitaTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ReceitaTableAdapter
    Friend WithEvents CustoFixoTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.CustoFixoTableAdapter
    Friend WithEvents ImpostosSobreVendasTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ImpostosSobreVendasTableAdapter
    Friend WithEvents CustoVariavelTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.CustoVariavelTableAdapter
    Friend WithEvents CustoVariavelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DespesaFixaTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.DespesaFixaTableAdapter
    Friend WithEvents DespesaFixaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DespesaVariavelTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.DespesaVariavelTableAdapter
    Friend WithEvents DespesaVariavelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents mc_relatorio_dre As System.Windows.Forms.MonthCalendar
    Friend WithEvents GrupoDatasDRE As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_data_baixa As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_data_emissao As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_data_cadastro As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_data_vencimento As System.Windows.Forms.RadioButton
    Friend WithEvents GrupoFiltrarPor As System.Windows.Forms.GroupBox
    Friend WithEvents ProfissionalComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents rdo_ano As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_mes As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_dia As System.Windows.Forms.RadioButton
    Friend WithEvents LoginBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LoginTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LoginTableAdapter
    Friend WithEvents GrupoProfissional As System.Windows.Forms.GroupBox
    Friend WithEvents ProfissionalLabel As System.Windows.Forms.Label
    Friend WithEvents UtilizarProfissionalCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents rdo_profissional As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_total As System.Windows.Forms.RadioButton
End Class
