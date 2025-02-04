<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_imprimir_convenios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_imprimir_convenios))
        Me.ConveniosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gerenciamento_CRAFIDataSet = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet()
        Me.ImprimirConveniosReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ConveniosTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ConveniosTableAdapter()
        Me.ConveniosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.RazaoSocialToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.RazaoSocialToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.CidadeToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CidadeToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.EstadoToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.EstadoToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.EmailToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.EmailToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.BuscarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AtualizarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.TableAdapterManager = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager()
        CType(Me.ConveniosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConveniosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConveniosBindingNavigator.SuspendLayout()
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
        'ImprimirConveniosReportViewer
        '
        Me.ImprimirConveniosReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "ImprimirConveniosDataSet"
        ReportDataSource1.Value = Me.ConveniosBindingSource
        Me.ImprimirConveniosReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ImprimirConveniosReportViewer.LocalReport.ReportEmbeddedResource = "Gerenciamento_CRAFI.ImprimirConveniosReport.rdlc"
        Me.ImprimirConveniosReportViewer.Location = New System.Drawing.Point(93, 0)
        Me.ImprimirConveniosReportViewer.Name = "ImprimirConveniosReportViewer"
        Me.ImprimirConveniosReportViewer.Size = New System.Drawing.Size(625, 314)
        Me.ImprimirConveniosReportViewer.TabIndex = 0
        '
        'ConveniosTableAdapter
        '
        Me.ConveniosTableAdapter.ClearBeforeFill = True
        '
        'ConveniosBindingNavigator
        '
        Me.ConveniosBindingNavigator.AddNewItem = Nothing
        Me.ConveniosBindingNavigator.BindingSource = Me.ConveniosBindingSource
        Me.ConveniosBindingNavigator.CountItem = Nothing
        Me.ConveniosBindingNavigator.DeleteItem = Nothing
        Me.ConveniosBindingNavigator.Dock = System.Windows.Forms.DockStyle.Left
        Me.ConveniosBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ConveniosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RazaoSocialToolStripLabel, Me.RazaoSocialToolStripTextBox, Me.CidadeToolStripLabel, Me.CidadeToolStripTextBox, Me.EstadoToolStripLabel, Me.EstadoToolStripTextBox, Me.EmailToolStripLabel, Me.EmailToolStripTextBox, Me.BuscarToolStripButton, Me.ToolStripSeparator1, Me.AtualizarToolStripButton})
        Me.ConveniosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ConveniosBindingNavigator.MoveFirstItem = Nothing
        Me.ConveniosBindingNavigator.MoveLastItem = Nothing
        Me.ConveniosBindingNavigator.MoveNextItem = Nothing
        Me.ConveniosBindingNavigator.MovePreviousItem = Nothing
        Me.ConveniosBindingNavigator.Name = "ConveniosBindingNavigator"
        Me.ConveniosBindingNavigator.PositionItem = Nothing
        Me.ConveniosBindingNavigator.Size = New System.Drawing.Size(93, 314)
        Me.ConveniosBindingNavigator.TabIndex = 1
        Me.ConveniosBindingNavigator.Text = "BindingNavigator1"
        '
        'RazaoSocialToolStripLabel
        '
        Me.RazaoSocialToolStripLabel.Name = "RazaoSocialToolStripLabel"
        Me.RazaoSocialToolStripLabel.Size = New System.Drawing.Size(90, 15)
        Me.RazaoSocialToolStripLabel.Text = "Razão Social:"
        '
        'RazaoSocialToolStripTextBox
        '
        Me.RazaoSocialToolStripTextBox.Name = "RazaoSocialToolStripTextBox"
        Me.RazaoSocialToolStripTextBox.Size = New System.Drawing.Size(88, 23)
        '
        'CidadeToolStripLabel
        '
        Me.CidadeToolStripLabel.Name = "CidadeToolStripLabel"
        Me.CidadeToolStripLabel.Size = New System.Drawing.Size(90, 15)
        Me.CidadeToolStripLabel.Text = "Cidade:"
        '
        'CidadeToolStripTextBox
        '
        Me.CidadeToolStripTextBox.Name = "CidadeToolStripTextBox"
        Me.CidadeToolStripTextBox.Size = New System.Drawing.Size(88, 23)
        '
        'EstadoToolStripLabel
        '
        Me.EstadoToolStripLabel.Name = "EstadoToolStripLabel"
        Me.EstadoToolStripLabel.Size = New System.Drawing.Size(90, 15)
        Me.EstadoToolStripLabel.Text = "Estado:"
        '
        'EstadoToolStripTextBox
        '
        Me.EstadoToolStripTextBox.Name = "EstadoToolStripTextBox"
        Me.EstadoToolStripTextBox.Size = New System.Drawing.Size(88, 23)
        '
        'EmailToolStripLabel
        '
        Me.EmailToolStripLabel.Name = "EmailToolStripLabel"
        Me.EmailToolStripLabel.Size = New System.Drawing.Size(90, 15)
        Me.EmailToolStripLabel.Text = "E-mail:"
        '
        'EmailToolStripTextBox
        '
        Me.EmailToolStripTextBox.Name = "EmailToolStripTextBox"
        Me.EmailToolStripTextBox.Size = New System.Drawing.Size(88, 23)
        '
        'BuscarToolStripButton
        '
        Me.BuscarToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources._4998_32x32
        Me.BuscarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BuscarToolStripButton.Name = "BuscarToolStripButton"
        Me.BuscarToolStripButton.Size = New System.Drawing.Size(90, 20)
        Me.BuscarToolStripButton.Text = "Buscar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(90, 6)
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
        Me.TableAdapterManager.ServicosConveniosTableAdapter = Nothing
        Me.TableAdapterManager.ServicosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'form_imprimir_convenios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 314)
        Me.Controls.Add(Me.ImprimirConveniosReportViewer)
        Me.Controls.Add(Me.ConveniosBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_imprimir_convenios"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir Convênios"
        CType(Me.ConveniosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConveniosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConveniosBindingNavigator.ResumeLayout(False)
        Me.ConveniosBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImprimirConveniosReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ConveniosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Gerenciamento_CRAFIDataSet As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet
    Friend WithEvents ConveniosTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ConveniosTableAdapter
    Friend WithEvents ConveniosBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents RazaoSocialToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents RazaoSocialToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents CidadeToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CidadeToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents EstadoToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents EstadoToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents EmailToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents EmailToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BuscarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AtualizarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents TableAdapterManager As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager
End Class
