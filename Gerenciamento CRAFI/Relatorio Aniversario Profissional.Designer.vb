<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_relatorio_aniversario_profissional
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_relatorio_aniversario_profissional))
        Me.ProfissionaisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gerenciamento_CRAFIDataSet = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet()
        Me.ProfissionaisAniversariantesReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ProfissionaisTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ProfissionaisTableAdapter()
        Me.TableAdapterManager = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager()
        CType(Me.ProfissionaisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProfissionaisBindingSource
        '
        Me.ProfissionaisBindingSource.DataMember = "Profissionais"
        Me.ProfissionaisBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'Gerenciamento_CRAFIDataSet
        '
        Me.Gerenciamento_CRAFIDataSet.DataSetName = "Gerenciamento_CRAFIDataSet"
        Me.Gerenciamento_CRAFIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProfissionaisAniversariantesReportViewer
        '
        Me.ProfissionaisAniversariantesReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "ProfissionalAniversarianteDataSet"
        ReportDataSource1.Value = Me.ProfissionaisBindingSource
        Me.ProfissionaisAniversariantesReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ProfissionaisAniversariantesReportViewer.LocalReport.ReportEmbeddedResource = "Gerenciamento_CRAFI.ProfissionalAniversarianteReport.rdlc"
        Me.ProfissionaisAniversariantesReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.ProfissionaisAniversariantesReportViewer.Name = "ProfissionaisAniversariantesReportViewer"
        Me.ProfissionaisAniversariantesReportViewer.Size = New System.Drawing.Size(718, 314)
        Me.ProfissionaisAniversariantesReportViewer.TabIndex = 0
        '
        'ProfissionaisTableAdapter
        '
        Me.ProfissionaisTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.ProfissionaisTableAdapter = Me.ProfissionaisTableAdapter
        Me.TableAdapterManager.ReceitaTableAdapter = Nothing
        Me.TableAdapterManager.ServicosConveniosTableAdapter = Nothing
        Me.TableAdapterManager.ServicosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'form_relatorio_aniversario_profissional
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 314)
        Me.Controls.Add(Me.ProfissionaisAniversariantesReportViewer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_relatorio_aniversario_profissional"
        Me.ShowIcon = False
        Me.Text = "Relatório dos Profissionais Aniversariantes"
        CType(Me.ProfissionaisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProfissionaisAniversariantesReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ProfissionaisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Gerenciamento_CRAFIDataSet As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet
    Friend WithEvents ProfissionaisTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ProfissionaisTableAdapter
    Friend WithEvents TableAdapterManager As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager
End Class
