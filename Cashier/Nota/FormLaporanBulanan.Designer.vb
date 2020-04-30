<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanBulanan
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.KasirDataSet = New Cashier.KasirDataSet()
        Me.tbl_detailjualBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbl_detailjualTableAdapter = New Cashier.KasirDataSetTableAdapters.tbl_detailjualTableAdapter()
        Me.tbl_adminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbl_adminTableAdapter = New Cashier.KasirDataSetTableAdapters.tbl_adminTableAdapter()
        CType(Me.KasirDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_detailjualBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_adminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tbl_detailjualBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.tbl_adminBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Cashier.LaporanBulanan.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(843, 635)
        Me.ReportViewer1.TabIndex = 0
        '
        'KasirDataSet
        '
        Me.KasirDataSet.DataSetName = "KasirDataSet"
        Me.KasirDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbl_detailjualBindingSource
        '
        Me.tbl_detailjualBindingSource.DataMember = "tbl_detailjual"
        Me.tbl_detailjualBindingSource.DataSource = Me.KasirDataSet
        '
        'tbl_detailjualTableAdapter
        '
        Me.tbl_detailjualTableAdapter.ClearBeforeFill = True
        '
        'tbl_adminBindingSource
        '
        Me.tbl_adminBindingSource.DataMember = "tbl_admin"
        Me.tbl_adminBindingSource.DataSource = Me.KasirDataSet
        '
        'tbl_adminTableAdapter
        '
        Me.tbl_adminTableAdapter.ClearBeforeFill = True
        '
        'FormLaporanBulanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 635)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormLaporanBulanan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan Bulanan"
        CType(Me.KasirDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_detailjualBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_adminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_detailjualBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KasirDataSet As Cashier.KasirDataSet
    Friend WithEvents tbl_adminBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tbl_detailjualTableAdapter As Cashier.KasirDataSetTableAdapters.tbl_detailjualTableAdapter
    Friend WithEvents tbl_adminTableAdapter As Cashier.KasirDataSetTableAdapters.tbl_adminTableAdapter
End Class
