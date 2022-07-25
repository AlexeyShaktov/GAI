namespace GAI
{
    partial class Cars
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
            this.gAIDataSet10 = new GAI.GAIDataSet10();
            this.carSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carSelectTableAdapter = new GAI.GAIDataSet10TableAdapters.CarSelectTableAdapter();
            this.idCarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.techPassportSeriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.techPassNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodyNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchCarBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carSelectBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCarDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.techPassportSeriesDataGridViewTextBoxColumn,
            this.techPassNumberDataGridViewTextBoxColumn,
            this.stateNumberDataGridViewTextBoxColumn,
            this.engineNumberDataGridViewTextBoxColumn,
            this.bodyNumberDataGridViewTextBoxColumn,
            this.ownerDataGridViewTextBoxColumn,
            this.ownerAddressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.carSelectBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(886, 357);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // gAIDataSet10
            // 
            this.gAIDataSet10.DataSetName = "GAIDataSet10";
            this.gAIDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carSelectBindingSource
            // 
            this.carSelectBindingSource.DataMember = "CarSelect";
            this.carSelectBindingSource.DataSource = this.gAIDataSet10;
            // 
            // carSelectTableAdapter
            // 
            this.carSelectTableAdapter.ClearBeforeFill = true;
            // 
            // idCarDataGridViewTextBoxColumn
            // 
            this.idCarDataGridViewTextBoxColumn.DataPropertyName = "idCar";
            this.idCarDataGridViewTextBoxColumn.HeaderText = "idCar";
            this.idCarDataGridViewTextBoxColumn.Name = "idCarDataGridViewTextBoxColumn";
            this.idCarDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCarDataGridViewTextBoxColumn.Visible = false;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Марка";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // techPassportSeriesDataGridViewTextBoxColumn
            // 
            this.techPassportSeriesDataGridViewTextBoxColumn.DataPropertyName = "TechPassportSeries";
            this.techPassportSeriesDataGridViewTextBoxColumn.HeaderText = "Серия ТП";
            this.techPassportSeriesDataGridViewTextBoxColumn.Name = "techPassportSeriesDataGridViewTextBoxColumn";
            this.techPassportSeriesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // techPassNumberDataGridViewTextBoxColumn
            // 
            this.techPassNumberDataGridViewTextBoxColumn.DataPropertyName = "TechPassNumber";
            this.techPassNumberDataGridViewTextBoxColumn.HeaderText = "Номер ТП";
            this.techPassNumberDataGridViewTextBoxColumn.Name = "techPassNumberDataGridViewTextBoxColumn";
            this.techPassNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stateNumberDataGridViewTextBoxColumn
            // 
            this.stateNumberDataGridViewTextBoxColumn.DataPropertyName = "StateNumber";
            this.stateNumberDataGridViewTextBoxColumn.HeaderText = "Госномер";
            this.stateNumberDataGridViewTextBoxColumn.Name = "stateNumberDataGridViewTextBoxColumn";
            this.stateNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // engineNumberDataGridViewTextBoxColumn
            // 
            this.engineNumberDataGridViewTextBoxColumn.DataPropertyName = "EngineNumber";
            this.engineNumberDataGridViewTextBoxColumn.HeaderText = "Номер двигателя";
            this.engineNumberDataGridViewTextBoxColumn.Name = "engineNumberDataGridViewTextBoxColumn";
            this.engineNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bodyNumberDataGridViewTextBoxColumn
            // 
            this.bodyNumberDataGridViewTextBoxColumn.DataPropertyName = "BodyNumber";
            this.bodyNumberDataGridViewTextBoxColumn.HeaderText = "Номер кузова";
            this.bodyNumberDataGridViewTextBoxColumn.Name = "bodyNumberDataGridViewTextBoxColumn";
            this.bodyNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ownerDataGridViewTextBoxColumn
            // 
            this.ownerDataGridViewTextBoxColumn.DataPropertyName = "Owner";
            this.ownerDataGridViewTextBoxColumn.HeaderText = "Владелец";
            this.ownerDataGridViewTextBoxColumn.Name = "ownerDataGridViewTextBoxColumn";
            this.ownerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ownerAddressDataGridViewTextBoxColumn
            // 
            this.ownerAddressDataGridViewTextBoxColumn.DataPropertyName = "OwnerAddress";
            this.ownerAddressDataGridViewTextBoxColumn.HeaderText = "Адрес владельца";
            this.ownerAddressDataGridViewTextBoxColumn.Name = "ownerAddressDataGridViewTextBoxColumn";
            this.ownerAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.ownerAddressDataGridViewTextBoxColumn.Width = 150;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "dbo.CarSelect";
            this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "CarSelect", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("idCar", "idCar"),
                        new System.Data.Common.DataColumnMapping("Brand", "Brand"),
                        new System.Data.Common.DataColumnMapping("TechPassportSeries", "TechPassportSeries"),
                        new System.Data.Common.DataColumnMapping("TechPassNumber", "TechPassNumber"),
                        new System.Data.Common.DataColumnMapping("StateNumber", "StateNumber"),
                        new System.Data.Common.DataColumnMapping("EngineNumber", "EngineNumber"),
                        new System.Data.Common.DataColumnMapping("BodyNumber", "BodyNumber"),
                        new System.Data.Common.DataColumnMapping("Owner", "Owner"),
                        new System.Data.Common.DataColumnMapping("OwnerAddress", "OwnerAddress")})});
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=LAPTOP-CI7CDAV8;Initial Catalog=GAI;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchCarBox);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(31, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 138);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Найти автомобиль";
            // 
            // searchCarBox
            // 
            this.searchCarBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchCarBox.Location = new System.Drawing.Point(102, 47);
            this.searchCarBox.Name = "searchCarBox";
            this.searchCarBox.Size = new System.Drawing.Size(184, 26);
            this.searchCarBox.TabIndex = 32;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 51);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 16);
            this.label18.TabIndex = 31;
            this.label18.Text = "Госномер";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(102, 79);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 31);
            this.button6.TabIndex = 19;
            this.button6.Text = "Найти";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(197, 79);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(89, 31);
            this.button7.TabIndex = 18;
            this.button7.Text = "Сброс";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(802, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 34);
            this.button1.TabIndex = 52;
            this.button1.Text = "Подтвердить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 528);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Cars";
            this.Text = "Cars";
            this.Load += new System.EventHandler(this.Cars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carSelectBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GAIDataSet10 gAIDataSet10;
        private System.Windows.Forms.BindingSource carSelectBindingSource;
        private GAIDataSet10TableAdapters.CarSelectTableAdapter carSelectTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn techPassportSeriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn techPassNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodyNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerAddressDataGridViewTextBoxColumn;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox searchCarBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button1;
    }
}