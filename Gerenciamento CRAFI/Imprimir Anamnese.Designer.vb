<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_imprimir_anamnese
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_imprimir_anamnese))
        Me.AnamneseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gerenciamento_CRAFIDataSet = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet()
        Me.CirurgiasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExamesComplementaresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImprimirAnamneseReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.AnamneseTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.AnamneseTableAdapter()
        Me.ExamesComplementaresTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ExamesComplementaresTableAdapter()
        Me.CirurgiasTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.CirurgiasTableAdapter()
        Me.TableAdapterManager = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager()
        CType(Me.AnamneseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CirurgiasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamesComplementaresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AnamneseBindingSource
        '
        Me.AnamneseBindingSource.DataMember = "Anamnese"
        Me.AnamneseBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'Gerenciamento_CRAFIDataSet
        '
        Me.Gerenciamento_CRAFIDataSet.DataSetName = "Gerenciamento_CRAFIDataSet"
        Me.Gerenciamento_CRAFIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CirurgiasBindingSource
        '
        Me.CirurgiasBindingSource.DataMember = "Cirurgias"
        Me.CirurgiasBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'ExamesComplementaresBindingSource
        '
        Me.ExamesComplementaresBindingSource.DataMember = "ExamesComplementares"
        Me.ExamesComplementaresBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'ImprimirAnamneseReportViewer
        '
        Me.ImprimirAnamneseReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "ImprimirAnamneseDataSet"
        ReportDataSource1.Value = Me.AnamneseBindingSource
        ReportDataSource2.Name = "ImprimirAnamneseCirurgiaDataSet"
        ReportDataSource2.Value = Me.CirurgiasBindingSource
        ReportDataSource3.Name = "ImprimirAnamneseECDataSet"
        ReportDataSource3.Value = Me.ExamesComplementaresBindingSource
        Me.ImprimirAnamneseReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ImprimirAnamneseReportViewer.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ImprimirAnamneseReportViewer.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ImprimirAnamneseReportViewer.LocalReport.ReportEmbeddedResource = "Gerenciamento_CRAFI.ImprimirAnamneseReport.rdlc"
        Me.ImprimirAnamneseReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.ImprimirAnamneseReportViewer.Name = "ImprimirAnamneseReportViewer"
        Me.ImprimirAnamneseReportViewer.Size = New System.Drawing.Size(718, 314)
        Me.ImprimirAnamneseReportViewer.TabIndex = 0
        '
        'AnamneseTableAdapter
        '
        Me.AnamneseTableAdapter.ClearBeforeFill = True
        '
        'ExamesComplementaresTableAdapter
        '
        Me.ExamesComplementaresTableAdapter.ClearBeforeFill = True
        '
        'CirurgiasTableAdapter
        '
        Me.CirurgiasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnamneseTableAdapter = Me.AnamneseTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CirurgiasTableAdapter = Me.CirurgiasTableAdapter
        Me.TableAdapterManager.ConsultasTableAdapter = Nothing
        Me.TableAdapterManager.ConveniosTableAdapter = Nothing
        Me.TableAdapterManager.CustoFixoTableAdapter = Nothing
        Me.TableAdapterManager.CustoVariavelTableAdapter = Nothing
        Me.TableAdapterManager.DespesaFixaTableAdapter = Nothing
        Me.TableAdapterManager.DespesaVariavelTableAdapter = Nothing
        Me.TableAdapterManager.EvolucaoClinicaTableAdapter = Nothing
        Me.TableAdapterManager.ExamesComplementaresTableAdapter = Me.ExamesComplementaresTableAdapter
        Me.TableAdapterManager.ImpostosSobreVendasTableAdapter = Nothing
        Me.TableAdapterManager.LogControleTableAdapter = Nothing
        Me.TableAdapterManager.LogEntradaTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.PacientesTableAdapter = Nothing
        Me.TableAdapterManager.ProfissionaisTableAdapter = Nothing
        Me.TableAdapterManager.ReceitaTableAdapter = Nothing
        Me.TableAdapterManager.ServicosConveniosTableAdapter = Nothing
        Me.TableAdapterManager.ServicosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'form_imprimir_anamnese
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 314)
        Me.Controls.Add(Me.ImprimirAnamneseReportViewer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_imprimir_anamnese"
        Me.ShowIcon = False
        Me.Text = "Imprimir Anamnese"
        CType(Me.AnamneseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CirurgiasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamesComplementaresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImprimirAnamneseReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents AnamneseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Gerenciamento_CRAFIDataSet As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet
    Friend WithEvents AnamneseTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.AnamneseTableAdapter
    Friend WithEvents ExamesComplementaresTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ExamesComplementaresTableAdapter
    Friend WithEvents CirurgiasTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.CirurgiasTableAdapter
    Friend WithEvents CirurgiasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ExamesComplementaresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager
End Class
