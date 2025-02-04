<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_imprimir_servicos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_imprimir_servicos))
        Me.ServicosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gerenciamento_CRAFIDataSet = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet()
        Me.ImprimirServicosReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ServicosTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ServicosTableAdapter()
        Me.ServicosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.NomeToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.NomeToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.CodigoToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CodigoToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ValorUnitarioToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ValorUnitarioToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.BuscarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.BuscaToolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.AtualizarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.TableAdapterManager = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager()
        CType(Me.ServicosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServicosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ServicosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ServicosBindingSource
        '
        Me.ServicosBindingSource.DataMember = "Servicos"
        Me.ServicosBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'Gerenciamento_CRAFIDataSet
        '
        Me.Gerenciamento_CRAFIDataSet.DataSetName = "Gerenciamento_CRAFIDataSet"
        Me.Gerenciamento_CRAFIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ImprimirServicosReportViewer
        '
        Me.ImprimirServicosReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "ImprimirServicosDataSet"
        ReportDataSource1.Value = Me.ServicosBindingSource
        Me.ImprimirServicosReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ImprimirServicosReportViewer.LocalReport.ReportEmbeddedResource = "Gerenciamento_CRAFI.ImprimirServicosReport.rdlc"
        Me.ImprimirServicosReportViewer.Location = New System.Drawing.Point(93, 0)
        Me.ImprimirServicosReportViewer.Name = "ImprimirServicosReportViewer"
        Me.ImprimirServicosReportViewer.Size = New System.Drawing.Size(625, 314)
        Me.ImprimirServicosReportViewer.TabIndex = 0
        '
        'ServicosTableAdapter
        '
        Me.ServicosTableAdapter.ClearBeforeFill = True
        '
        'ServicosBindingNavigator
        '
        Me.ServicosBindingNavigator.AddNewItem = Nothing
        Me.ServicosBindingNavigator.BindingSource = Me.ServicosBindingSource
        Me.ServicosBindingNavigator.CountItem = Nothing
        Me.ServicosBindingNavigator.DeleteItem = Nothing
        Me.ServicosBindingNavigator.Dock = System.Windows.Forms.DockStyle.Left
        Me.ServicosBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ServicosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NomeToolStripLabel, Me.NomeToolStripTextBox, Me.CodigoToolStripLabel, Me.CodigoToolStripTextBox, Me.ValorUnitarioToolStripLabel, Me.ValorUnitarioToolStripTextBox, Me.BuscarToolStripButton, Me.BuscaToolStripSeparator, Me.AtualizarToolStripButton})
        Me.ServicosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ServicosBindingNavigator.MoveFirstItem = Nothing
        Me.ServicosBindingNavigator.MoveLastItem = Nothing
        Me.ServicosBindingNavigator.MoveNextItem = Nothing
        Me.ServicosBindingNavigator.MovePreviousItem = Nothing
        Me.ServicosBindingNavigator.Name = "ServicosBindingNavigator"
        Me.ServicosBindingNavigator.PositionItem = Nothing
        Me.ServicosBindingNavigator.Size = New System.Drawing.Size(93, 314)
        Me.ServicosBindingNavigator.TabIndex = 1
        Me.ServicosBindingNavigator.Text = "BindingNavigator1"
        '
        'NomeToolStripLabel
        '
        Me.NomeToolStripLabel.Name = "NomeToolStripLabel"
        Me.NomeToolStripLabel.Size = New System.Drawing.Size(90, 15)
        Me.NomeToolStripLabel.Text = "Nome:"
        '
        'NomeToolStripTextBox
        '
        Me.NomeToolStripTextBox.Name = "NomeToolStripTextBox"
        Me.NomeToolStripTextBox.Size = New System.Drawing.Size(88, 23)
        '
        'CodigoToolStripLabel
        '
        Me.CodigoToolStripLabel.Name = "CodigoToolStripLabel"
        Me.CodigoToolStripLabel.Size = New System.Drawing.Size(90, 15)
        Me.CodigoToolStripLabel.Text = "Código:"
        '
        'CodigoToolStripTextBox
        '
        Me.CodigoToolStripTextBox.Name = "CodigoToolStripTextBox"
        Me.CodigoToolStripTextBox.Size = New System.Drawing.Size(88, 23)
        '
        'ValorUnitarioToolStripLabel
        '
        Me.ValorUnitarioToolStripLabel.Name = "ValorUnitarioToolStripLabel"
        Me.ValorUnitarioToolStripLabel.Size = New System.Drawing.Size(90, 15)
        Me.ValorUnitarioToolStripLabel.Text = "Valor Unitário:"
        '
        'ValorUnitarioToolStripTextBox
        '
        Me.ValorUnitarioToolStripTextBox.Name = "ValorUnitarioToolStripTextBox"
        Me.ValorUnitarioToolStripTextBox.Size = New System.Drawing.Size(88, 23)
        '
        'BuscarToolStripButton
        '
        Me.BuscarToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources._4998_32x32
        Me.BuscarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BuscarToolStripButton.Name = "BuscarToolStripButton"
        Me.BuscarToolStripButton.Size = New System.Drawing.Size(90, 20)
        Me.BuscarToolStripButton.Text = "Buscar"
        '
        'BuscaToolStripSeparator
        '
        Me.BuscaToolStripSeparator.Name = "BuscaToolStripSeparator"
        Me.BuscaToolStripSeparator.Size = New System.Drawing.Size(90, 6)
        '
        'AtualizarToolStripButton
        '
        Me.AtualizarToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources._8437_32x32
        Me.AtualizarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AtualizarToolStripButton.Name = "AtualizarToolStripButton"
        Me.AtualizarToolStripButton.Size = New System.Drawing.Size(90, 20)
        Me.AtualizarToolStripButton.Text = "Atualizar"
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
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.PacientesTableAdapter = Nothing
        Me.TableAdapterManager.ProfissionaisTableAdapter = Nothing
        Me.TableAdapterManager.ReceitaTableAdapter = Nothing
        Me.TableAdapterManager.ServicosConveniosTableAdapter = Nothing
        Me.TableAdapterManager.ServicosTableAdapter = Me.ServicosTableAdapter
        Me.TableAdapterManager.UpdateOrder = Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'form_imprimir_servicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 314)
        Me.Controls.Add(Me.ImprimirServicosReportViewer)
        Me.Controls.Add(Me.ServicosBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_imprimir_servicos"
        Me.ShowIcon = False
        Me.Text = "Imprimir Serviços"
        CType(Me.ServicosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServicosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ServicosBindingNavigator.ResumeLayout(False)
        Me.ServicosBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImprimirServicosReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ServicosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Gerenciamento_CRAFIDataSet As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet
    Friend WithEvents ServicosTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ServicosTableAdapter
    Friend WithEvents ServicosBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents NomeToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents NomeToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents CodigoToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CodigoToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ValorUnitarioToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ValorUnitarioToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BuscarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents BuscaToolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AtualizarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents TableAdapterManager As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager
End Class
