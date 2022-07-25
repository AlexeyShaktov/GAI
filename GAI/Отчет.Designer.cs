namespace GAI
{
    partial class Отчет
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
            this.carSelectTableAdapter1 = new GAI.GAIDataSet10TableAdapters.CarSelectTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GAIDataSet22 = new GAI.GAIDataSet22();
            this.SelectCarOnDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SelectCarOnDateTableAdapter = new GAI.GAIDataSet22TableAdapters.SelectCarOnDateTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GAIDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectCarOnDateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // carSelectTableAdapter1
            // 
            this.carSelectTableAdapter1.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SelectCarOnDateBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GAI.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1042, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // GAIDataSet22
            // 
            this.GAIDataSet22.DataSetName = "GAIDataSet22";
            this.GAIDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SelectCarOnDateBindingSource
            // 
            this.SelectCarOnDateBindingSource.DataMember = "SelectCarOnDate";
            this.SelectCarOnDateBindingSource.DataSource = this.GAIDataSet22;
            // 
            // SelectCarOnDateTableAdapter
            // 
            this.SelectCarOnDateTableAdapter.ClearBeforeFill = true;
            // 
            // Отчет
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 451);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Отчет";
            this.Text = "Отчет";
            this.Load += new System.EventHandler(this.Отчет_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GAIDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectCarOnDateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GAIDataSet10TableAdapters.CarSelectTableAdapter carSelectTableAdapter1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SelectCarOnDateBindingSource;
        private GAIDataSet22 GAIDataSet22;
        private GAIDataSet22TableAdapters.SelectCarOnDateTableAdapter SelectCarOnDateTableAdapter;
    }
}