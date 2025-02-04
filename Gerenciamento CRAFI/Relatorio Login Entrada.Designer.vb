<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_relatorio_login_entrada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_relatorio_login_entrada))
        Me.LogEntradaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gerenciamento_CRAFIDataSet = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet()
        Me.ReportViewerLogEntrada = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.LogEntradaTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogEntradaTableAdapter()
        Me.TableAdapterManager = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager()
        CType(Me.LogEntradaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogEntradaBindingSource
        '
        Me.LogEntradaBindingSource.DataMember = "LogEntrada"
        Me.LogEntradaBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'Gerenciamento_CRAFIDataSet
        '
        Me.Gerenciamento_CRAFIDataSet.DataSetName = "Gerenciamento_CRAFIDataSet"
        Me.Gerenciamento_CRAFIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewerLogEntrada
        '
        Me.ReportViewerLogEntrada.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "LogEntradaDataSet"
        ReportDataSource1.Value = Me.LogEntradaBindingSource
        Me.ReportViewerLogEntrada.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewerLogEntrada.LocalReport.ReportEmbeddedResource = "Gerenciamento_CRAFI.LogEntradaReport.rdlc"
        Me.ReportViewerLogEntrada.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewerLogEntrada.Name = "ReportViewerLogEntrada"
        Me.ReportViewerLogEntrada.Size = New System.Drawing.Size(718, 314)
        Me.ReportViewerLogEntrada.TabIndex = 0
        '
        'LogEntradaTableAdapter
        '
        Me.LogEntradaTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.LogEntradaTableAdapter = Me.LogEntradaTableAdapter
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.PacientesTableAdapter = Nothing
        Me.TableAdapterManager.ProfissionaisTableAdapter = Nothing
        Me.TableAdapterManager.ReceitaTableAdapter = Nothing
        Me.TableAdapterManager.ServicosConveniosTableAdapter = Nothing
        Me.TableAdapterManager.ServicosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'form_relatorio_login_entrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 314)
        Me.Controls.Add(Me.ReportViewerLogEntrada)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_relatorio_login_entrada"
        Me.ShowIcon = False
        Me.Text = "Relatório Login de Entrada"
        CType(Me.LogEntradaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewerLogEntrada As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents LogEntradaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Gerenciamento_CRAFIDataSet As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet
    Friend WithEvents LogEntradaTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogEntradaTableAdapter
    Friend WithEvents TableAdapterManager As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager
End Class
