<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_imprimir_convenio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_imprimir_convenio))
        Me.ConveniosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gerenciamento_CRAFIDataSet = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet()
        Me.ServicosConveniosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImprimirConvenioReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ConveniosTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ConveniosTableAdapter()
        Me.ServicosConveniosTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ServicosConveniosTableAdapter()
        Me.TableAdapterManager = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager()
        CType(Me.ConveniosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServicosConveniosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConveniosBindingSource
        '
        Me.ConveniosBindingSource.DataMember = "Convenios"
        Me.ConveniosBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'Gerenciamento_CRAFIDataSet
        '
        Me.Gerenciamento_CRAFIDataSet.DataSetName = "Gerenciamento_CRAFIDataSet"
        Me.Gerenciamento_CRAFIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ServicosConveniosBindingSource
        '
        Me.ServicosConveniosBindingSource.DataMember = "ServicosConvenios"
        Me.ServicosConveniosBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'ImprimirConvenioReportViewer
        '
        Me.ImprimirConvenioReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "ImprimirConvenioDataSet"
        ReportDataSource1.Value = Me.ConveniosBindingSource
        ReportDataSource2.Name = "ImprimirServicosConvenioDataSet"
        ReportDataSource2.Value = Me.ServicosConveniosBindingSource
        Me.ImprimirConvenioReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ImprimirConvenioReportViewer.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ImprimirConvenioReportViewer.LocalReport.ReportEmbeddedResource = "Gerenciamento_CRAFI.ImprimirConvenioReport.rdlc"
        Me.ImprimirConvenioReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.ImprimirConvenioReportViewer.Name = "ImprimirConvenioReportViewer"
        Me.ImprimirConvenioReportViewer.Size = New System.Drawing.Size(718, 314)
        Me.ImprimirConvenioReportViewer.TabIndex = 0
        '
        'ConveniosTableAdapter
        '
        Me.ConveniosTableAdapter.ClearBeforeFill = True
        '
        'ServicosConveniosTableAdapter
        '
        Me.ServicosConveniosTableAdapter.ClearBeforeFill = True
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
        'form_imprimir_convenio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 314)
        Me.Controls.Add(Me.ImprimirConvenioReportViewer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_imprimir_convenio"
        Me.ShowIcon = False
        Me.Text = "Imprimir Convênio"
        CType(Me.ConveniosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServicosConveniosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImprimirConvenioReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ConveniosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Gerenciamento_CRAFIDataSet As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet
    Friend WithEvents ServicosConveniosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConveniosTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ConveniosTableAdapter
    Friend WithEvents ServicosConveniosTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ServicosConveniosTableAdapter
    Friend WithEvents TableAdapterManager As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager
End Class
