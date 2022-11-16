namespace SistemaVentaAkira.View.Reportes
{
    partial class ArticulosVendidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ListaProdcutosbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ListaProductosCatebindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ListaProdcutosProveedorbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ListaProdcutosbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaProductosCatebindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaProdcutosProveedorbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaProdcutosbindingSource
            // 
            this.ListaProdcutosbindingSource.DataMember = "ListaProdcutos";
            this.ListaProdcutosbindingSource.DataSource = typeof(SistemaVentaAkira.Controller.Reporte.ReporteProducto);
            // 
            // ListaProductosCatebindingSource
            // 
            this.ListaProductosCatebindingSource.DataMember = "ListaProductosCate";
            this.ListaProductosCatebindingSource.DataSource = typeof(SistemaVentaAkira.Controller.Reporte.ReporteProducto);
            // 
            // ListaProdcutosProveedorbindingSource
            // 
            this.ListaProdcutosProveedorbindingSource.DataMember = "ListaProdcutosProveedor";
            this.ListaProdcutosProveedorbindingSource.DataSource = typeof(SistemaVentaAkira.Controller.Reporte.ReporteProducto);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ListaProdcutosbindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.ListaProductosCatebindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.ListaProdcutosProveedorbindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaVentaAkira.View.Reportes.Report_Prod.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ArticulosVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ArticulosVendidos";
            this.Text = "ArticulosVendidos";
            this.Load += new System.EventHandler(this.ArticulosVendidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListaProdcutosbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaProductosCatebindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaProdcutosProveedorbindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ListaProdcutosbindingSource;
        private System.Windows.Forms.BindingSource ListaProductosCatebindingSource;
        private System.Windows.Forms.BindingSource ListaProdcutosProveedorbindingSource;
    }
}