namespace GAI
{
    partial class Violations
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gAIDataSet11 = new GAI.GAIDataSet11();
            this.driverViolationSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driver_ViolationSelectTableAdapter = new GAI.GAIDataSet11TableAdapters.Driver_ViolationSelectTableAdapter();
            this.gAIDataSet12 = new GAI.GAIDataSet12();
            this.violationSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.violationSelectTableAdapter = new GAI.GAIDataSet12TableAdapters.ViolationSelectTableAdapter();
            this.idViolationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverViolationSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.violationSelectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idViolationDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.violationSelectBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 302);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // gAIDataSet11
            // 
            this.gAIDataSet11.DataSetName = "GAIDataSet11";
            this.gAIDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // driverViolationSelectBindingSource
            // 
            this.driverViolationSelectBindingSource.DataMember = "Driver_ViolationSelect";
            this.driverViolationSelectBindingSource.DataSource = this.gAIDataSet11;
            // 
            // driver_ViolationSelectTableAdapter
            // 
            this.driver_ViolationSelectTableAdapter.ClearBeforeFill = true;
            // 
            // gAIDataSet12
            // 
            this.gAIDataSet12.DataSetName = "GAIDataSet12";
            this.gAIDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // violationSelectBindingSource
            // 
            this.violationSelectBindingSource.DataMember = "ViolationSelect";
            this.violationSelectBindingSource.DataSource = this.gAIDataSet12;
            // 
            // violationSelectTableAdapter
            // 
            this.violationSelectTableAdapter.ClearBeforeFill = true;
            // 
            // idViolationDataGridViewTextBoxColumn
            // 
            this.idViolationDataGridViewTextBoxColumn.DataPropertyName = "idViolation";
            this.idViolationDataGridViewTextBoxColumn.HeaderText = "idViolation";
            this.idViolationDataGridViewTextBoxColumn.Name = "idViolationDataGridViewTextBoxColumn";
            this.idViolationDataGridViewTextBoxColumn.ReadOnly = true;
            this.idViolationDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Нарушение";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 500;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Подтвердить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Violations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 353);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Violations";
            this.Text = "Violations";
            this.Load += new System.EventHandler(this.Violations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverViolationSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.violationSelectBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GAIDataSet11 gAIDataSet11;
        private System.Windows.Forms.BindingSource driverViolationSelectBindingSource;
        private GAIDataSet11TableAdapters.Driver_ViolationSelectTableAdapter driver_ViolationSelectTableAdapter;
        private GAIDataSet12 gAIDataSet12;
        private System.Windows.Forms.BindingSource violationSelectBindingSource;
        private GAIDataSet12TableAdapters.ViolationSelectTableAdapter violationSelectTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idViolationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}