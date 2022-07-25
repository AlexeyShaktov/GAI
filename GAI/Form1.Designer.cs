namespace GAI
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection2 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDriverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenseSeriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenseNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverSelectBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.gAIDataSet16 = new GAI.GAIDataSet16();
            this.driverSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gAIDataSet = new GAI.GAIDataSet();
            this.driverSelectTableAdapter = new GAI.GAIDataSetTableAdapters.DriverSelectTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.driverDeleteButton = new System.Windows.Forms.Button();
            this.driverUpdateButton = new System.Windows.Forms.Button();
            this.driverInsertButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.secondNameBox = new System.Windows.Forms.TextBox();
            this.middleNameBox = new System.Windows.Forms.TextBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchCarBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.ownerAddressBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.ownerBox = new System.Windows.Forms.TextBox();
            this.bodyBox = new System.Windows.Forms.TextBox();
            this.engineBox = new System.Windows.Forms.TextBox();
            this.brandBox = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idCarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.techPassportSeriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.techPassNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodyNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gAIDataSet1 = new GAI.GAIDataSet1();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.violationBox = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idViolationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.violationSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gAIDataSet3 = new GAI.GAIDataSet3();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label35 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button19 = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.maskedTextBox8 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox9 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox10 = new System.Windows.Forms.MaskedTextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox7 = new System.Windows.Forms.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.idDriverViolationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenseSeriesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenseNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.violationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDriverDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joinViolationDriverBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.gAIDataSet19 = new GAI.GAIDataSet19();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.idCarDriverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joinCarDriverBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gAIDataSet18 = new GAI.GAIDataSet18();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button22 = new System.Windows.Forms.Button();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.button20 = new System.Windows.Forms.Button();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button23 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.joinViolationDriverBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.gAIDataSet17 = new GAI.GAIDataSet17();
            this.joinViolationDriverBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.gAIDataSet9 = new GAI.GAIDataSet9();
            this.joinCarDriverBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gAIDataSet13 = new GAI.GAIDataSet13();
            this.joinCarDriverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gAIDataSet4 = new GAI.GAIDataSet4();
            this.joinViolationDriverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gAIDataSet5 = new GAI.GAIDataSet5();
            this.carDriverSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gAIDataSet2 = new GAI.GAIDataSet2();
            this.carSelectTableAdapter = new GAI.GAIDataSet1TableAdapters.CarSelectTableAdapter();
            this.car_DriverSelectTableAdapter = new GAI.GAIDataSet2TableAdapters.Car_DriverSelectTableAdapter();
            this.violationSelectTableAdapter = new GAI.GAIDataSet3TableAdapters.ViolationSelectTableAdapter();
            this.joinCarDriverTableAdapter = new GAI.GAIDataSet4TableAdapters.JoinCarDriverTableAdapter();
            this.joinViolationDriverTableAdapter = new GAI.GAIDataSet5TableAdapters.JoinViolationDriverTableAdapter();
            this.gAIDataSet7 = new GAI.GAIDataSet7();
            this.joinViolationDriverBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.joinViolationDriverTableAdapter1 = new GAI.GAIDataSet7TableAdapters.JoinViolationDriverTableAdapter();
            this.gAIDataSet8 = new GAI.GAIDataSet8();
            this.joinViolationDriverBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.joinViolationDriverTableAdapter2 = new GAI.GAIDataSet8TableAdapters.JoinViolationDriverTableAdapter();
            this.joinViolationDriverTableAdapter3 = new GAI.GAIDataSet9TableAdapters.JoinViolationDriverTableAdapter();
            this.joinCarDriverTableAdapter1 = new GAI.GAIDataSet13TableAdapters.JoinCarDriverTableAdapter();
            this.gAIDataSet14 = new GAI.GAIDataSet14();
            this.driverSelectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.driverSelectTableAdapter1 = new GAI.GAIDataSet14TableAdapters.DriverSelectTableAdapter();
            this.gAIDataSet15 = new GAI.GAIDataSet15();
            this.driverSelectBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.driverSelectTableAdapter2 = new GAI.GAIDataSet15TableAdapters.DriverSelectTableAdapter();
            this.driverSelectTableAdapter3 = new GAI.GAIDataSet16TableAdapters.DriverSelectTableAdapter();
            this.joinViolationDriverTableAdapter4 = new GAI.GAIDataSet17TableAdapters.JoinViolationDriverTableAdapter();
            this.joinCarDriverTableAdapter2 = new GAI.GAIDataSet18TableAdapters.JoinCarDriverTableAdapter();
            this.joinViolationDriverTableAdapter5 = new GAI.GAIDataSet19TableAdapters.JoinViolationDriverTableAdapter();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.button24 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverSelectBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIDataSet1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.violationSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIDataSet3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinViolationDriverBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinCarDriverBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIDataSet18)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinViolationDriverBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinViolationDriverBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinCarDriverBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinCarDriverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinViolationDriverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDriverSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinViolationDriverBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinViolationDriverBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverSelectBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverSelectBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            this.sqlConnection1.InfoMessage += new System.Data.SqlClient.SqlInfoMessageEventHandler(this.sqlConnection1_InfoMessage);
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "dbo.DriverSelect";
            this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand1.Connection = this.sqlConnection2;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlConnection2
            // 
            this.sqlConnection2.ConnectionString = "Data Source=LAPTOP-CI7CDAV8;Initial Catalog=GAI;Integrated Security=True";
            this.sqlConnection2.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "dbo.DriverInsert";
            this.sqlInsertCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlInsertCommand1.Connection = this.sqlConnection2;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@firstName", System.Data.SqlDbType.VarChar, 45, "FirstName"),
            new System.Data.SqlClient.SqlParameter("@middleName", System.Data.SqlDbType.VarChar, 45, "MiddleName"),
            new System.Data.SqlClient.SqlParameter("@secondName", System.Data.SqlDbType.VarChar, 45, "SecondName"),
            new System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.VarChar, 255, "Address"),
            new System.Data.SqlClient.SqlParameter("@licSer", System.Data.SqlDbType.VarChar, 20, "LicenseSeries"),
            new System.Data.SqlClient.SqlParameter("@licNum", System.Data.SqlDbType.VarChar, 20, "LicenseNumber")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = "dbo.DriverUpdate";
            this.sqlUpdateCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlUpdateCommand1.Connection = this.sqlConnection2;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, "idDriver"),
            new System.Data.SqlClient.SqlParameter("@firstName", System.Data.SqlDbType.VarChar, 45, "FirstName"),
            new System.Data.SqlClient.SqlParameter("@middleName", System.Data.SqlDbType.VarChar, 45, "MiddleName"),
            new System.Data.SqlClient.SqlParameter("@secondName", System.Data.SqlDbType.VarChar, 45, "SecondName"),
            new System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.VarChar, 255, "Address"),
            new System.Data.SqlClient.SqlParameter("@licSer", System.Data.SqlDbType.VarChar, 20, "LicenseSeries"),
            new System.Data.SqlClient.SqlParameter("@licNum", System.Data.SqlDbType.VarChar, 20, "LicenseNumber")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "dbo.DriverDelete";
            this.sqlDeleteCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlDeleteCommand1.Connection = this.sqlConnection2;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, "idDriver")});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "DriverSelect", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("idDriver", "idDriver"),
                        new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
                        new System.Data.Common.DataColumnMapping("MiddleName", "MiddleName"),
                        new System.Data.Common.DataColumnMapping("SecondName", "SecondName"),
                        new System.Data.Common.DataColumnMapping("Address", "Address"),
                        new System.Data.Common.DataColumnMapping("LicenseSeries", "LicenseSeries"),
                        new System.Data.Common.DataColumnMapping("LicenseNumber", "LicenseNumber")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDriverDataGridViewTextBoxColumn,
            this.secondNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.licenseSeriesDataGridViewTextBoxColumn,
            this.licenseNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.driverSelectBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(3, 6);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(746, 557);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idDriverDataGridViewTextBoxColumn
            // 
            this.idDriverDataGridViewTextBoxColumn.DataPropertyName = "idDriver";
            this.idDriverDataGridViewTextBoxColumn.HeaderText = "idDriver";
            this.idDriverDataGridViewTextBoxColumn.Name = "idDriverDataGridViewTextBoxColumn";
            this.idDriverDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDriverDataGridViewTextBoxColumn.Visible = false;
            // 
            // secondNameDataGridViewTextBoxColumn
            // 
            this.secondNameDataGridViewTextBoxColumn.DataPropertyName = "SecondName";
            this.secondNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.secondNameDataGridViewTextBoxColumn.Name = "secondNameDataGridViewTextBoxColumn";
            this.secondNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            this.middleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 200;
            // 
            // licenseSeriesDataGridViewTextBoxColumn
            // 
            this.licenseSeriesDataGridViewTextBoxColumn.DataPropertyName = "LicenseSeries";
            this.licenseSeriesDataGridViewTextBoxColumn.HeaderText = "Серия ВУ";
            this.licenseSeriesDataGridViewTextBoxColumn.Name = "licenseSeriesDataGridViewTextBoxColumn";
            this.licenseSeriesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // licenseNumberDataGridViewTextBoxColumn
            // 
            this.licenseNumberDataGridViewTextBoxColumn.DataPropertyName = "LicenseNumber";
            this.licenseNumberDataGridViewTextBoxColumn.HeaderText = "Номер ВУ";
            this.licenseNumberDataGridViewTextBoxColumn.Name = "licenseNumberDataGridViewTextBoxColumn";
            this.licenseNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // driverSelectBindingSource3
            // 
            this.driverSelectBindingSource3.DataMember = "DriverSelect";
            this.driverSelectBindingSource3.DataSource = this.gAIDataSet16;
            // 
            // gAIDataSet16
            // 
            this.gAIDataSet16.DataSetName = "GAIDataSet16";
            this.gAIDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // driverSelectBindingSource
            // 
            this.driverSelectBindingSource.DataMember = "DriverSelect";
            this.driverSelectBindingSource.DataSource = this.gAIDataSet;
            // 
            // gAIDataSet
            // 
            this.gAIDataSet.DataSetName = "GAIDataSet";
            this.gAIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // driverSelectTableAdapter
            // 
            this.driverSelectTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1244, 675);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.maskedTextBox2);
            this.tabPage1.Controls.Add(this.maskedTextBox1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.driverDeleteButton);
            this.tabPage1.Controls.Add(this.driverUpdateButton);
            this.tabPage1.Controls.Add(this.driverInsertButton);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.addressBox);
            this.tabPage1.Controls.Add(this.secondNameBox);
            this.tabPage1.Controls.Add(this.middleNameBox);
            this.tabPage1.Controls.Add(this.firstNameBox);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1236, 642);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Водители";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(897, 233);
            this.maskedTextBox2.Mask = "000000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(288, 26);
            this.maskedTextBox2.TabIndex = 22;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(897, 204);
            this.maskedTextBox1.Mask = "0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(288, 26);
            this.maskedTextBox1.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Location = new System.Drawing.Point(755, 353);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 210);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Найти водителя";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 35);
            this.button2.TabIndex = 19;
            this.button2.Text = "Найти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 35);
            this.button1.TabIndex = 18;
            this.button1.Text = "Сброс";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(10, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Фамилия";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(10, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Отчество";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(10, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Имя";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(142, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 26);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(142, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(288, 26);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(142, 38);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(288, 26);
            this.textBox3.TabIndex = 6;
            // 
            // driverDeleteButton
            // 
            this.driverDeleteButton.Location = new System.Drawing.Point(1051, 277);
            this.driverDeleteButton.Name = "driverDeleteButton";
            this.driverDeleteButton.Size = new System.Drawing.Size(134, 35);
            this.driverDeleteButton.TabIndex = 19;
            this.driverDeleteButton.Text = "Удалить";
            this.driverDeleteButton.UseVisualStyleBackColor = true;
            this.driverDeleteButton.Click += new System.EventHandler(this.driverDeleteButton_Click);
            // 
            // driverUpdateButton
            // 
            this.driverUpdateButton.Location = new System.Drawing.Point(911, 277);
            this.driverUpdateButton.Name = "driverUpdateButton";
            this.driverUpdateButton.Size = new System.Drawing.Size(134, 35);
            this.driverUpdateButton.TabIndex = 18;
            this.driverUpdateButton.Text = "Обновить";
            this.driverUpdateButton.UseVisualStyleBackColor = true;
            this.driverUpdateButton.Click += new System.EventHandler(this.driverUpdateButton_Click);
            // 
            // driverInsertButton
            // 
            this.driverInsertButton.Location = new System.Drawing.Point(771, 277);
            this.driverInsertButton.Name = "driverInsertButton";
            this.driverInsertButton.Size = new System.Drawing.Size(134, 35);
            this.driverInsertButton.TabIndex = 17;
            this.driverInsertButton.Text = "Добавить";
            this.driverInsertButton.UseVisualStyleBackColor = true;
            this.driverInsertButton.Click += new System.EventHandler(this.driverInsertButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(767, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Номер ВУ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(767, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Серия ВУ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(767, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Адрес";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(767, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(767, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Отчество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(767, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Имя";
            // 
            // addressBox
            // 
            this.addressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressBox.Location = new System.Drawing.Point(897, 172);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(288, 26);
            this.addressBox.TabIndex = 6;
            // 
            // secondNameBox
            // 
            this.secondNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondNameBox.Location = new System.Drawing.Point(897, 140);
            this.secondNameBox.Name = "secondNameBox";
            this.secondNameBox.Size = new System.Drawing.Size(288, 26);
            this.secondNameBox.TabIndex = 5;
            // 
            // middleNameBox
            // 
            this.middleNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middleNameBox.Location = new System.Drawing.Point(897, 108);
            this.middleNameBox.Name = "middleNameBox";
            this.middleNameBox.Size = new System.Drawing.Size(288, 26);
            this.middleNameBox.TabIndex = 4;
            // 
            // firstNameBox
            // 
            this.firstNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameBox.Location = new System.Drawing.Point(897, 76);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(288, 26);
            this.firstNameBox.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.ownerAddressBox);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.maskedTextBox5);
            this.tabPage2.Controls.Add(this.maskedTextBox3);
            this.tabPage2.Controls.Add(this.maskedTextBox4);
            this.tabPage2.Controls.Add(this.ownerBox);
            this.tabPage2.Controls.Add(this.bodyBox);
            this.tabPage2.Controls.Add(this.engineBox);
            this.tabPage2.Controls.Add(this.brandBox);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1236, 642);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Автомобили";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchCarBox);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Location = new System.Drawing.Point(805, 364);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 210);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Найти автомобиль";
            // 
            // searchCarBox
            // 
            this.searchCarBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchCarBox.Location = new System.Drawing.Point(152, 48);
            this.searchCarBox.Name = "searchCarBox";
            this.searchCarBox.Size = new System.Drawing.Size(273, 26);
            this.searchCarBox.TabIndex = 32;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 51);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 20);
            this.label18.TabIndex = 31;
            this.label18.Text = "Госномер";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(130, 157);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(134, 35);
            this.button6.TabIndex = 19;
            this.button6.Text = "Найти";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(284, 157);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(134, 35);
            this.button7.TabIndex = 18;
            this.button7.Text = "Сброс";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1089, 303);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 35);
            this.button3.TabIndex = 37;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(949, 303);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 35);
            this.button4.TabIndex = 36;
            this.button4.Text = "Обновить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(809, 303);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 35);
            this.button5.TabIndex = 35;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(805, 269);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(146, 20);
            this.label17.TabIndex = 34;
            this.label17.Text = "Адрес владельца";
            // 
            // ownerAddressBox
            // 
            this.ownerAddressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ownerAddressBox.Location = new System.Drawing.Point(957, 266);
            this.ownerAddressBox.Name = "ownerAddressBox";
            this.ownerAddressBox.Size = new System.Drawing.Size(273, 26);
            this.ownerAddressBox.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(805, 240);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(136, 20);
            this.label16.TabIndex = 32;
            this.label16.Text = "ФИО владельца";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(805, 205);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 20);
            this.label15.TabIndex = 31;
            this.label15.Text = "Кузов";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(805, 173);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 20);
            this.label14.TabIndex = 30;
            this.label14.Text = "Двигатель";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(805, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 20);
            this.label13.TabIndex = 29;
            this.label13.Text = "Госномер";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(805, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "ПТС номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(805, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "ПТС серия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(805, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Марка";
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.Location = new System.Drawing.Point(957, 138);
            this.maskedTextBox5.Mask = "?000??000";
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(273, 26);
            this.maskedTextBox5.TabIndex = 25;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(957, 106);
            this.maskedTextBox3.Mask = "000000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(273, 26);
            this.maskedTextBox3.TabIndex = 24;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(957, 77);
            this.maskedTextBox4.Mask = "00??";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(273, 26);
            this.maskedTextBox4.TabIndex = 23;
            // 
            // ownerBox
            // 
            this.ownerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ownerBox.Location = new System.Drawing.Point(957, 234);
            this.ownerBox.Name = "ownerBox";
            this.ownerBox.Size = new System.Drawing.Size(273, 26);
            this.ownerBox.TabIndex = 10;
            // 
            // bodyBox
            // 
            this.bodyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bodyBox.Location = new System.Drawing.Point(957, 202);
            this.bodyBox.Name = "bodyBox";
            this.bodyBox.Size = new System.Drawing.Size(273, 26);
            this.bodyBox.TabIndex = 9;
            // 
            // engineBox
            // 
            this.engineBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.engineBox.Location = new System.Drawing.Point(957, 170);
            this.engineBox.Name = "engineBox";
            this.engineBox.Size = new System.Drawing.Size(273, 26);
            this.engineBox.TabIndex = 8;
            // 
            // brandBox
            // 
            this.brandBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brandBox.Location = new System.Drawing.Point(957, 45);
            this.brandBox.Name = "brandBox";
            this.brandBox.Size = new System.Drawing.Size(273, 26);
            this.brandBox.TabIndex = 7;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCarDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.techPassportSeriesDataGridViewTextBoxColumn,
            this.techPassNumberDataGridViewTextBoxColumn,
            this.stateNumberDataGridViewTextBoxColumn,
            this.engineNumberDataGridViewTextBoxColumn,
            this.bodyNumberDataGridViewTextBoxColumn,
            this.ownerDataGridViewTextBoxColumn,
            this.ownerAddressDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.carSelectBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(793, 568);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // idCarDataGridViewTextBoxColumn
            // 
            this.idCarDataGridViewTextBoxColumn.DataPropertyName = "idCar";
            this.idCarDataGridViewTextBoxColumn.Frozen = true;
            this.idCarDataGridViewTextBoxColumn.HeaderText = "";
            this.idCarDataGridViewTextBoxColumn.Name = "idCarDataGridViewTextBoxColumn";
            this.idCarDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCarDataGridViewTextBoxColumn.Visible = false;
            this.idCarDataGridViewTextBoxColumn.Width = 5;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Марка";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.ReadOnly = true;
            this.brandDataGridViewTextBoxColumn.Width = 70;
            // 
            // techPassportSeriesDataGridViewTextBoxColumn
            // 
            this.techPassportSeriesDataGridViewTextBoxColumn.DataPropertyName = "TechPassportSeries";
            this.techPassportSeriesDataGridViewTextBoxColumn.HeaderText = "Серия техпаспорта";
            this.techPassportSeriesDataGridViewTextBoxColumn.Name = "techPassportSeriesDataGridViewTextBoxColumn";
            this.techPassportSeriesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // techPassNumberDataGridViewTextBoxColumn
            // 
            this.techPassNumberDataGridViewTextBoxColumn.DataPropertyName = "TechPassNumber";
            this.techPassNumberDataGridViewTextBoxColumn.HeaderText = "Номер техпаспорта";
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
            this.engineNumberDataGridViewTextBoxColumn.Width = 80;
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
            // 
            // carSelectBindingSource
            // 
            this.carSelectBindingSource.DataMember = "CarSelect";
            this.carSelectBindingSource.DataSource = this.gAIDataSet1;
            // 
            // gAIDataSet1
            // 
            this.gAIDataSet1.DataSetName = "GAIDataSet1";
            this.gAIDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.violationBox);
            this.tabPage3.Controls.Add(this.button8);
            this.tabPage3.Controls.Add(this.button9);
            this.tabPage3.Controls.Add(this.button10);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1236, 642);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Нарушения";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(768, 44);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(170, 20);
            this.label19.TabIndex = 42;
            this.label19.Text = "Название нарушения";
            // 
            // violationBox
            // 
            this.violationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.violationBox.Location = new System.Drawing.Point(772, 67);
            this.violationBox.Name = "violationBox";
            this.violationBox.Size = new System.Drawing.Size(273, 26);
            this.violationBox.TabIndex = 41;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1052, 116);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(134, 35);
            this.button8.TabIndex = 40;
            this.button8.Text = "Удалить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(912, 116);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(134, 35);
            this.button9.TabIndex = 39;
            this.button9.Text = "Обновить";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(772, 116);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(134, 35);
            this.button10.TabIndex = 38;
            this.button10.Text = "Добавить";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idViolationDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.violationSelectBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(16, 13);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(744, 545);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // idViolationDataGridViewTextBoxColumn
            // 
            this.idViolationDataGridViewTextBoxColumn.DataPropertyName = "idViolation";
            this.idViolationDataGridViewTextBoxColumn.HeaderText = "idViolation";
            this.idViolationDataGridViewTextBoxColumn.Name = "idViolationDataGridViewTextBoxColumn";
            this.idViolationDataGridViewTextBoxColumn.ReadOnly = true;
            this.idViolationDataGridViewTextBoxColumn.Visible = false;
            this.idViolationDataGridViewTextBoxColumn.Width = 5;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Нарушение";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 700;
            // 
            // violationSelectBindingSource
            // 
            this.violationSelectBindingSource.DataMember = "ViolationSelect";
            this.violationSelectBindingSource.DataSource = this.gAIDataSet3;
            // 
            // gAIDataSet3
            // 
            this.gAIDataSet3.DataSetName = "GAIDataSet3";
            this.gAIDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label35);
            this.tabPage4.Controls.Add(this.dateTimePicker1);
            this.tabPage4.Controls.Add(this.button19);
            this.tabPage4.Controls.Add(this.label34);
            this.tabPage4.Controls.Add(this.textBox13);
            this.tabPage4.Controls.Add(this.button16);
            this.tabPage4.Controls.Add(this.button17);
            this.tabPage4.Controls.Add(this.button18);
            this.tabPage4.Controls.Add(this.button13);
            this.tabPage4.Controls.Add(this.button14);
            this.tabPage4.Controls.Add(this.button15);
            this.tabPage4.Controls.Add(this.label26);
            this.tabPage4.Controls.Add(this.textBox8);
            this.tabPage4.Controls.Add(this.label27);
            this.tabPage4.Controls.Add(this.label28);
            this.tabPage4.Controls.Add(this.label29);
            this.tabPage4.Controls.Add(this.label30);
            this.tabPage4.Controls.Add(this.label31);
            this.tabPage4.Controls.Add(this.label32);
            this.tabPage4.Controls.Add(this.label33);
            this.tabPage4.Controls.Add(this.maskedTextBox8);
            this.tabPage4.Controls.Add(this.maskedTextBox9);
            this.tabPage4.Controls.Add(this.maskedTextBox10);
            this.tabPage4.Controls.Add(this.textBox9);
            this.tabPage4.Controls.Add(this.textBox10);
            this.tabPage4.Controls.Add(this.textBox11);
            this.tabPage4.Controls.Add(this.textBox12);
            this.tabPage4.Controls.Add(this.button12);
            this.tabPage4.Controls.Add(this.maskedTextBox6);
            this.tabPage4.Controls.Add(this.maskedTextBox7);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.label21);
            this.tabPage4.Controls.Add(this.label22);
            this.tabPage4.Controls.Add(this.label23);
            this.tabPage4.Controls.Add(this.label24);
            this.tabPage4.Controls.Add(this.label25);
            this.tabPage4.Controls.Add(this.textBox4);
            this.tabPage4.Controls.Add(this.textBox5);
            this.tabPage4.Controls.Add(this.textBox6);
            this.tabPage4.Controls.Add(this.textBox7);
            this.tabPage4.Controls.Add(this.button11);
            this.tabPage4.Controls.Add(this.dataGridView5);
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1236, 642);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Штраф";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(24, 407);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(135, 20);
            this.label35.TabIndex = 62;
            this.label35.Text = "Дата нарушения";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(248, 407);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 61;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(24, 267);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(213, 39);
            this.button19.TabIndex = 60;
            this.button19.Text = "Выбрать нарушение";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(24, 337);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(95, 20);
            this.label34.TabIndex = 59;
            this.label34.Text = "Нарушение";
            // 
            // textBox13
            // 
            this.textBox13.Enabled = false;
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox13.Location = new System.Drawing.Point(125, 337);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(323, 26);
            this.textBox13.TabIndex = 58;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(949, 594);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(134, 35);
            this.button16.TabIndex = 57;
            this.button16.Text = "Удалить";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(809, 594);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(134, 35);
            this.button17.TabIndex = 56;
            this.button17.Text = "Обновить";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(669, 594);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(134, 35);
            this.button18.TabIndex = 55;
            this.button18.Text = "Добавить";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(294, 594);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(134, 35);
            this.button13.TabIndex = 54;
            this.button13.Text = "Удалить";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(154, 594);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(134, 35);
            this.button14.TabIndex = 53;
            this.button14.Text = "Обновить";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(14, 594);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(134, 35);
            this.button15.TabIndex = 52;
            this.button15.Text = "Добавить";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(882, 558);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(146, 20);
            this.label26.TabIndex = 51;
            this.label26.Text = "Адрес владельца";
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox8.Location = new System.Drawing.Point(1034, 555);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(194, 26);
            this.textBox8.TabIndex = 50;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(882, 529);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(136, 20);
            this.label27.TabIndex = 49;
            this.label27.Text = "ФИО владельца";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(882, 494);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(52, 20);
            this.label28.TabIndex = 48;
            this.label28.Text = "Кузов";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(882, 462);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(92, 20);
            this.label29.TabIndex = 47;
            this.label29.Text = "Двигатель";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(882, 430);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(82, 20);
            this.label30.TabIndex = 46;
            this.label30.Text = "Госномер";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(882, 398);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(92, 20);
            this.label31.TabIndex = 45;
            this.label31.Text = "ПТС номер";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(882, 369);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(89, 20);
            this.label32.TabIndex = 44;
            this.label32.Text = "ПТС серия";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(882, 337);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(57, 20);
            this.label33.TabIndex = 43;
            this.label33.Text = "Марка";
            // 
            // maskedTextBox8
            // 
            this.maskedTextBox8.Enabled = false;
            this.maskedTextBox8.Location = new System.Drawing.Point(1034, 427);
            this.maskedTextBox8.Mask = "?000??000";
            this.maskedTextBox8.Name = "maskedTextBox8";
            this.maskedTextBox8.Size = new System.Drawing.Size(194, 26);
            this.maskedTextBox8.TabIndex = 42;
            // 
            // maskedTextBox9
            // 
            this.maskedTextBox9.Enabled = false;
            this.maskedTextBox9.Location = new System.Drawing.Point(1034, 395);
            this.maskedTextBox9.Mask = "000000";
            this.maskedTextBox9.Name = "maskedTextBox9";
            this.maskedTextBox9.Size = new System.Drawing.Size(194, 26);
            this.maskedTextBox9.TabIndex = 41;
            // 
            // maskedTextBox10
            // 
            this.maskedTextBox10.Enabled = false;
            this.maskedTextBox10.Location = new System.Drawing.Point(1034, 366);
            this.maskedTextBox10.Mask = "00??";
            this.maskedTextBox10.Name = "maskedTextBox10";
            this.maskedTextBox10.Size = new System.Drawing.Size(194, 26);
            this.maskedTextBox10.TabIndex = 40;
            // 
            // textBox9
            // 
            this.textBox9.Enabled = false;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox9.Location = new System.Drawing.Point(1034, 523);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(194, 26);
            this.textBox9.TabIndex = 39;
            // 
            // textBox10
            // 
            this.textBox10.Enabled = false;
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox10.Location = new System.Drawing.Point(1034, 491);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(194, 26);
            this.textBox10.TabIndex = 38;
            // 
            // textBox11
            // 
            this.textBox11.Enabled = false;
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox11.Location = new System.Drawing.Point(1034, 459);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(194, 26);
            this.textBox11.TabIndex = 37;
            // 
            // textBox12
            // 
            this.textBox12.Enabled = false;
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox12.Location = new System.Drawing.Point(1034, 334);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(194, 26);
            this.textBox12.TabIndex = 36;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(882, 267);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(213, 39);
            this.button12.TabIndex = 35;
            this.button12.Text = "Выбрать автомобиль";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // maskedTextBox6
            // 
            this.maskedTextBox6.Enabled = false;
            this.maskedTextBox6.Location = new System.Drawing.Point(627, 491);
            this.maskedTextBox6.Mask = "000000";
            this.maskedTextBox6.Name = "maskedTextBox6";
            this.maskedTextBox6.Size = new System.Drawing.Size(239, 26);
            this.maskedTextBox6.TabIndex = 34;
            // 
            // maskedTextBox7
            // 
            this.maskedTextBox7.Enabled = false;
            this.maskedTextBox7.Location = new System.Drawing.Point(627, 462);
            this.maskedTextBox7.Mask = "0000";
            this.maskedTextBox7.Name = "maskedTextBox7";
            this.maskedTextBox7.Size = new System.Drawing.Size(239, 26);
            this.maskedTextBox7.TabIndex = 33;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(497, 494);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(84, 20);
            this.label20.TabIndex = 32;
            this.label20.Text = "Номер ВУ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(497, 462);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(81, 20);
            this.label21.TabIndex = 31;
            this.label21.Text = "Серия ВУ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(497, 430);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(57, 20);
            this.label22.TabIndex = 30;
            this.label22.Text = "Адрес";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(497, 398);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(81, 20);
            this.label23.TabIndex = 29;
            this.label23.Text = "Фамилия";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(497, 366);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(83, 20);
            this.label24.TabIndex = 28;
            this.label24.Text = "Отчество";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(497, 334);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(40, 20);
            this.label25.TabIndex = 27;
            this.label25.Text = "Имя";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(627, 430);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(239, 26);
            this.textBox4.TabIndex = 26;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(627, 398);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(239, 26);
            this.textBox5.TabIndex = 25;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.Location = new System.Drawing.Point(627, 366);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(239, 26);
            this.textBox6.TabIndex = 24;
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7.Location = new System.Drawing.Point(627, 334);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(239, 26);
            this.textBox7.TabIndex = 23;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(497, 267);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(203, 39);
            this.button11.TabIndex = 2;
            this.button11.Text = "Выбрать водителя";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDriverViolationDataGridViewTextBoxColumn,
            this.secondNameDataGridViewTextBoxColumn2,
            this.firstNameDataGridViewTextBoxColumn2,
            this.middleNameDataGridViewTextBoxColumn2,
            this.licenseSeriesDataGridViewTextBoxColumn1,
            this.licenseNumberDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.violationDateDataGridViewTextBoxColumn,
            this.idDriverDataGridViewTextBoxColumn1});
            this.dataGridView5.DataSource = this.joinViolationDriverBindingSource5;
            this.dataGridView5.Location = new System.Drawing.Point(14, 21);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.Size = new System.Drawing.Size(645, 240);
            this.dataGridView5.TabIndex = 1;
            this.dataGridView5.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellClick);
            // 
            // idDriverViolationDataGridViewTextBoxColumn
            // 
            this.idDriverViolationDataGridViewTextBoxColumn.DataPropertyName = "idDriver_Violation";
            this.idDriverViolationDataGridViewTextBoxColumn.HeaderText = "idDriver_Violation";
            this.idDriverViolationDataGridViewTextBoxColumn.Name = "idDriverViolationDataGridViewTextBoxColumn";
            this.idDriverViolationDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDriverViolationDataGridViewTextBoxColumn.Width = 5;
            // 
            // secondNameDataGridViewTextBoxColumn2
            // 
            this.secondNameDataGridViewTextBoxColumn2.DataPropertyName = "SecondName";
            this.secondNameDataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.secondNameDataGridViewTextBoxColumn2.Name = "secondNameDataGridViewTextBoxColumn2";
            this.secondNameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn2
            // 
            this.firstNameDataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn2.HeaderText = "Имя";
            this.firstNameDataGridViewTextBoxColumn2.Name = "firstNameDataGridViewTextBoxColumn2";
            this.firstNameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // middleNameDataGridViewTextBoxColumn2
            // 
            this.middleNameDataGridViewTextBoxColumn2.DataPropertyName = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn2.HeaderText = "Отчество";
            this.middleNameDataGridViewTextBoxColumn2.Name = "middleNameDataGridViewTextBoxColumn2";
            this.middleNameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // licenseSeriesDataGridViewTextBoxColumn1
            // 
            this.licenseSeriesDataGridViewTextBoxColumn1.DataPropertyName = "LicenseSeries";
            this.licenseSeriesDataGridViewTextBoxColumn1.HeaderText = "Серия ВУ";
            this.licenseSeriesDataGridViewTextBoxColumn1.Name = "licenseSeriesDataGridViewTextBoxColumn1";
            this.licenseSeriesDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // licenseNumberDataGridViewTextBoxColumn1
            // 
            this.licenseNumberDataGridViewTextBoxColumn1.DataPropertyName = "LicenseNumber";
            this.licenseNumberDataGridViewTextBoxColumn1.HeaderText = "Номер ВУ";
            this.licenseNumberDataGridViewTextBoxColumn1.Name = "licenseNumberDataGridViewTextBoxColumn1";
            this.licenseNumberDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Нарушение";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // violationDateDataGridViewTextBoxColumn
            // 
            this.violationDateDataGridViewTextBoxColumn.DataPropertyName = "ViolationDate";
            this.violationDateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.violationDateDataGridViewTextBoxColumn.Name = "violationDateDataGridViewTextBoxColumn";
            this.violationDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDriverDataGridViewTextBoxColumn1
            // 
            this.idDriverDataGridViewTextBoxColumn1.DataPropertyName = "idDriver";
            this.idDriverDataGridViewTextBoxColumn1.HeaderText = "idDriver";
            this.idDriverDataGridViewTextBoxColumn1.Name = "idDriverDataGridViewTextBoxColumn1";
            this.idDriverDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDriverDataGridViewTextBoxColumn1.Width = 5;
            // 
            // joinViolationDriverBindingSource5
            // 
            this.joinViolationDriverBindingSource5.DataMember = "JoinViolationDriver";
            this.joinViolationDriverBindingSource5.DataSource = this.gAIDataSet19;
            // 
            // gAIDataSet19
            // 
            this.gAIDataSet19.DataSetName = "GAIDataSet19";
            this.gAIDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCarDriverDataGridViewTextBoxColumn,
            this.secondNameDataGridViewTextBoxColumn1,
            this.firstNameDataGridViewTextBoxColumn1,
            this.middleNameDataGridViewTextBoxColumn1,
            this.brandDataGridViewTextBoxColumn1,
            this.stateNumberDataGridViewTextBoxColumn1});
            this.dataGridView4.DataSource = this.joinCarDriverBindingSource2;
            this.dataGridView4.Location = new System.Drawing.Point(679, 21);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(545, 240);
            this.dataGridView4.TabIndex = 0;
            this.dataGridView4.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellClick);
            // 
            // idCarDriverDataGridViewTextBoxColumn
            // 
            this.idCarDriverDataGridViewTextBoxColumn.DataPropertyName = "idCar_Driver";
            this.idCarDriverDataGridViewTextBoxColumn.HeaderText = "idCar_Driver";
            this.idCarDriverDataGridViewTextBoxColumn.Name = "idCarDriverDataGridViewTextBoxColumn";
            this.idCarDriverDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCarDriverDataGridViewTextBoxColumn.Visible = false;
            this.idCarDriverDataGridViewTextBoxColumn.Width = 5;
            // 
            // secondNameDataGridViewTextBoxColumn1
            // 
            this.secondNameDataGridViewTextBoxColumn1.DataPropertyName = "SecondName";
            this.secondNameDataGridViewTextBoxColumn1.HeaderText = "Фамилия";
            this.secondNameDataGridViewTextBoxColumn1.Name = "secondNameDataGridViewTextBoxColumn1";
            this.secondNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn1
            // 
            this.firstNameDataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.HeaderText = "Имя";
            this.firstNameDataGridViewTextBoxColumn1.Name = "firstNameDataGridViewTextBoxColumn1";
            this.firstNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // middleNameDataGridViewTextBoxColumn1
            // 
            this.middleNameDataGridViewTextBoxColumn1.DataPropertyName = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn1.HeaderText = "Отчетсво";
            this.middleNameDataGridViewTextBoxColumn1.Name = "middleNameDataGridViewTextBoxColumn1";
            this.middleNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // brandDataGridViewTextBoxColumn1
            // 
            this.brandDataGridViewTextBoxColumn1.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn1.HeaderText = "Марка авто";
            this.brandDataGridViewTextBoxColumn1.Name = "brandDataGridViewTextBoxColumn1";
            this.brandDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // stateNumberDataGridViewTextBoxColumn1
            // 
            this.stateNumberDataGridViewTextBoxColumn1.DataPropertyName = "StateNumber";
            this.stateNumberDataGridViewTextBoxColumn1.HeaderText = "Госномер";
            this.stateNumberDataGridViewTextBoxColumn1.Name = "stateNumberDataGridViewTextBoxColumn1";
            this.stateNumberDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // joinCarDriverBindingSource2
            // 
            this.joinCarDriverBindingSource2.DataMember = "JoinCarDriver";
            this.joinCarDriverBindingSource2.DataSource = this.gAIDataSet18;
            // 
            // gAIDataSet18
            // 
            this.gAIDataSet18.DataSetName = "GAIDataSet18";
            this.gAIDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button24);
            this.tabPage5.Controls.Add(this.treeView1);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1236, 642);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Дерево";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(24, 17);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(1193, 608);
            this.treeView1.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.groupBox4);
            this.tabPage6.Controls.Add(this.groupBox3);
            this.tabPage6.Controls.Add(this.dataGridView6);
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1236, 642);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Отчеты";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button22);
            this.groupBox4.Controls.Add(this.label37);
            this.groupBox4.Controls.Add(this.label36);
            this.groupBox4.Controls.Add(this.button20);
            this.groupBox4.Controls.Add(this.dateTimePicker3);
            this.groupBox4.Controls.Add(this.dateTimePicker2);
            this.groupBox4.Location = new System.Drawing.Point(36, 339);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(539, 272);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Нарушения на интервале дат";
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(365, 192);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(145, 34);
            this.button22.TabIndex = 5;
            this.button22.Text = "Export to RDLC";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(18, 167);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(132, 20);
            this.label37.TabIndex = 4;
            this.label37.Text = "Дата окончания";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(18, 107);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(107, 20);
            this.label36.TabIndex = 3;
            this.label36.Text = "Дата начала";
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(251, 192);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(96, 34);
            this.button20.TabIndex = 2;
            this.button20.Text = "Найти";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(251, 150);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(259, 26);
            this.dateTimePicker3.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(251, 107);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(259, 26);
            this.dateTimePicker2.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button23);
            this.groupBox3.Controls.Add(this.button21);
            this.groupBox3.Controls.Add(this.label39);
            this.groupBox3.Controls.Add(this.label38);
            this.groupBox3.Controls.Add(this.textBox15);
            this.groupBox3.Controls.Add(this.textBox14);
            this.groupBox3.Location = new System.Drawing.Point(36, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(539, 280);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Определенный вид нарушения";
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(365, 152);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(145, 34);
            this.button23.TabIndex = 7;
            this.button23.Text = "Export to Excel";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(251, 152);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(96, 34);
            this.button21.TabIndex = 6;
            this.button21.Text = "Найти";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(18, 110);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(95, 20);
            this.label39.TabIndex = 5;
            this.label39.Text = "Нарушение";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(18, 59);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(154, 20);
            this.label38.TabIndex = 4;
            this.label38.Text = "Марка автомобиля";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(251, 104);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(259, 26);
            this.textBox15.TabIndex = 1;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(251, 59);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(259, 26);
            this.textBox14.TabIndex = 0;
            // 
            // dataGridView6
            // 
            this.dataGridView6.AllowUserToAddRows = false;
            this.dataGridView6.AllowUserToDeleteRows = false;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(581, 23);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.ReadOnly = true;
            this.dataGridView6.Size = new System.Drawing.Size(630, 588);
            this.dataGridView6.TabIndex = 0;
            // 
            // joinViolationDriverBindingSource4
            // 
            this.joinViolationDriverBindingSource4.DataMember = "JoinViolationDriver";
            this.joinViolationDriverBindingSource4.DataSource = this.gAIDataSet17;
            // 
            // gAIDataSet17
            // 
            this.gAIDataSet17.DataSetName = "GAIDataSet17";
            this.gAIDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // joinViolationDriverBindingSource3
            // 
            this.joinViolationDriverBindingSource3.DataMember = "JoinViolationDriver";
            this.joinViolationDriverBindingSource3.DataSource = this.gAIDataSet9;
            // 
            // gAIDataSet9
            // 
            this.gAIDataSet9.DataSetName = "GAIDataSet9";
            this.gAIDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // joinCarDriverBindingSource1
            // 
            this.joinCarDriverBindingSource1.DataMember = "JoinCarDriver";
            this.joinCarDriverBindingSource1.DataSource = this.gAIDataSet13;
            // 
            // gAIDataSet13
            // 
            this.gAIDataSet13.DataSetName = "GAIDataSet13";
            this.gAIDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // joinCarDriverBindingSource
            // 
            this.joinCarDriverBindingSource.DataMember = "JoinCarDriver";
            this.joinCarDriverBindingSource.DataSource = this.gAIDataSet4;
            // 
            // gAIDataSet4
            // 
            this.gAIDataSet4.DataSetName = "GAIDataSet4";
            this.gAIDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // joinViolationDriverBindingSource
            // 
            this.joinViolationDriverBindingSource.DataMember = "JoinViolationDriver";
            this.joinViolationDriverBindingSource.DataSource = this.gAIDataSet5;
            // 
            // gAIDataSet5
            // 
            this.gAIDataSet5.DataSetName = "GAIDataSet5";
            this.gAIDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carDriverSelectBindingSource
            // 
            this.carDriverSelectBindingSource.DataMember = "Car_DriverSelect";
            this.carDriverSelectBindingSource.DataSource = this.gAIDataSet2;
            // 
            // gAIDataSet2
            // 
            this.gAIDataSet2.DataSetName = "GAIDataSet2";
            this.gAIDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carSelectTableAdapter
            // 
            this.carSelectTableAdapter.ClearBeforeFill = true;
            // 
            // car_DriverSelectTableAdapter
            // 
            this.car_DriverSelectTableAdapter.ClearBeforeFill = true;
            // 
            // violationSelectTableAdapter
            // 
            this.violationSelectTableAdapter.ClearBeforeFill = true;
            // 
            // joinCarDriverTableAdapter
            // 
            this.joinCarDriverTableAdapter.ClearBeforeFill = true;
            // 
            // joinViolationDriverTableAdapter
            // 
            this.joinViolationDriverTableAdapter.ClearBeforeFill = true;
            // 
            // gAIDataSet7
            // 
            this.gAIDataSet7.DataSetName = "GAIDataSet7";
            this.gAIDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // joinViolationDriverBindingSource1
            // 
            this.joinViolationDriverBindingSource1.DataMember = "JoinViolationDriver";
            this.joinViolationDriverBindingSource1.DataSource = this.gAIDataSet7;
            // 
            // joinViolationDriverTableAdapter1
            // 
            this.joinViolationDriverTableAdapter1.ClearBeforeFill = true;
            // 
            // gAIDataSet8
            // 
            this.gAIDataSet8.DataSetName = "GAIDataSet8";
            this.gAIDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // joinViolationDriverBindingSource2
            // 
            this.joinViolationDriverBindingSource2.DataMember = "JoinViolationDriver";
            this.joinViolationDriverBindingSource2.DataSource = this.gAIDataSet8;
            // 
            // joinViolationDriverTableAdapter2
            // 
            this.joinViolationDriverTableAdapter2.ClearBeforeFill = true;
            // 
            // joinViolationDriverTableAdapter3
            // 
            this.joinViolationDriverTableAdapter3.ClearBeforeFill = true;
            // 
            // joinCarDriverTableAdapter1
            // 
            this.joinCarDriverTableAdapter1.ClearBeforeFill = true;
            // 
            // gAIDataSet14
            // 
            this.gAIDataSet14.DataSetName = "GAIDataSet14";
            this.gAIDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // driverSelectBindingSource1
            // 
            this.driverSelectBindingSource1.DataMember = "DriverSelect";
            this.driverSelectBindingSource1.DataSource = this.gAIDataSet14;
            // 
            // driverSelectTableAdapter1
            // 
            this.driverSelectTableAdapter1.ClearBeforeFill = true;
            // 
            // gAIDataSet15
            // 
            this.gAIDataSet15.DataSetName = "GAIDataSet15";
            this.gAIDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // driverSelectBindingSource2
            // 
            this.driverSelectBindingSource2.DataMember = "DriverSelect";
            this.driverSelectBindingSource2.DataSource = this.gAIDataSet15;
            // 
            // driverSelectTableAdapter2
            // 
            this.driverSelectTableAdapter2.ClearBeforeFill = true;
            // 
            // driverSelectTableAdapter3
            // 
            this.driverSelectTableAdapter3.ClearBeforeFill = true;
            // 
            // joinViolationDriverTableAdapter4
            // 
            this.joinViolationDriverTableAdapter4.ClearBeforeFill = true;
            // 
            // joinCarDriverTableAdapter2
            // 
            this.joinCarDriverTableAdapter2.ClearBeforeFill = true;
            // 
            // joinViolationDriverTableAdapter5
            // 
            this.joinViolationDriverTableAdapter5.ClearBeforeFill = true;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(1107, 582);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(98, 32);
            this.button24.TabIndex = 1;
            this.button24.Text = "Обновить";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 695);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "ГАИ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverSelectBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIDataSet1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.violationSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIDataSet3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinViolationDriverBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinCarDriverBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIDataSet18)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinViolationDriverBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinViolationDriverBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinCarDriverBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinCarDriverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinViolationDriverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDriverSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinViolationDriverBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinViolationDriverBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverSelectBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverSelectBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private GAIDataSet gAIDataSet;
        private System.Windows.Forms.BindingSource driverSelectBindingSource;
        private GAIDataSetTableAdapters.DriverSelectTableAdapter driverSelectTableAdapter;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.DataGridView dataGridView2;
        private GAIDataSet1 gAIDataSet1;
        private System.Windows.Forms.BindingSource carSelectBindingSource;
        private GAIDataSet1TableAdapters.CarSelectTableAdapter carSelectTableAdapter;
        public System.Windows.Forms.TabPage tabPage1;
        private GAIDataSet2 gAIDataSet2;
        private System.Windows.Forms.BindingSource carDriverSelectBindingSource;
        private GAIDataSet2TableAdapters.Car_DriverSelectTableAdapter car_DriverSelectTableAdapter;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox secondNameBox;
        private System.Windows.Forms.TextBox middleNameBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button driverDeleteButton;
        private System.Windows.Forms.Button driverUpdateButton;
        private System.Windows.Forms.Button driverInsertButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.TextBox ownerBox;
        private System.Windows.Forms.TextBox bodyBox;
        private System.Windows.Forms.TextBox engineBox;
        private System.Windows.Forms.TextBox brandBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox ownerAddressBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn techPassportSeriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn techPassNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodyNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox searchCarBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private GAIDataSet3 gAIDataSet3;
        private System.Windows.Forms.BindingSource violationSelectBindingSource;
        private GAIDataSet3TableAdapters.ViolationSelectTableAdapter violationSelectTableAdapter;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox violationBox;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.DataGridViewTextBoxColumn idViolationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView4;
        private GAIDataSet4 gAIDataSet4;
        private System.Windows.Forms.BindingSource joinCarDriverBindingSource;
        private GAIDataSet4TableAdapters.JoinCarDriverTableAdapter joinCarDriverTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView5;
        private GAIDataSet5 gAIDataSet5;
        private System.Windows.Forms.BindingSource joinViolationDriverBindingSource;
        private GAIDataSet5TableAdapters.JoinViolationDriverTableAdapter joinViolationDriverTableAdapter;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.MaskedTextBox maskedTextBox8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox9;
        private System.Windows.Forms.MaskedTextBox maskedTextBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        public System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.TextBox textBox5;
        public System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        public System.Windows.Forms.TextBox textBox7;
        public System.Windows.Forms.MaskedTextBox maskedTextBox6;
        public System.Windows.Forms.MaskedTextBox maskedTextBox7;
        private GAIDataSet7 gAIDataSet7;
        private System.Windows.Forms.BindingSource joinViolationDriverBindingSource1;
        private GAIDataSet7TableAdapters.JoinViolationDriverTableAdapter joinViolationDriverTableAdapter1;
        private GAIDataSet8 gAIDataSet8;
        private System.Windows.Forms.BindingSource joinViolationDriverBindingSource2;
        private GAIDataSet8TableAdapters.JoinViolationDriverTableAdapter joinViolationDriverTableAdapter2;
        private GAIDataSet9 gAIDataSet9;
        private System.Windows.Forms.BindingSource joinViolationDriverBindingSource3;
        private GAIDataSet9TableAdapters.JoinViolationDriverTableAdapter joinViolationDriverTableAdapter3;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox textBox13;
        protected internal System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private GAIDataSet13 gAIDataSet13;
        private System.Windows.Forms.BindingSource joinCarDriverBindingSource1;
        private GAIDataSet13TableAdapters.JoinCarDriverTableAdapter joinCarDriverTableAdapter1;
        private GAIDataSet14 gAIDataSet14;
        private System.Windows.Forms.BindingSource driverSelectBindingSource1;
        private GAIDataSet14TableAdapters.DriverSelectTableAdapter driverSelectTableAdapter1;
        private GAIDataSet15 gAIDataSet15;
        private System.Windows.Forms.BindingSource driverSelectBindingSource2;
        private GAIDataSet15TableAdapters.DriverSelectTableAdapter driverSelectTableAdapter2;
        private GAIDataSet16 gAIDataSet16;
        private System.Windows.Forms.BindingSource driverSelectBindingSource3;
        private GAIDataSet16TableAdapters.DriverSelectTableAdapter driverSelectTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDriverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseSeriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseNumberDataGridViewTextBoxColumn;
        private GAIDataSet17 gAIDataSet17;
        private System.Windows.Forms.BindingSource joinViolationDriverBindingSource4;
        private GAIDataSet17TableAdapters.JoinViolationDriverTableAdapter joinViolationDriverTableAdapter4;
        private GAIDataSet18 gAIDataSet18;
        private System.Windows.Forms.BindingSource joinCarDriverBindingSource2;
        private GAIDataSet18TableAdapters.JoinCarDriverTableAdapter joinCarDriverTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCarDriverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TreeView treeView1;
        private GAIDataSet19 gAIDataSet19;
        private System.Windows.Forms.BindingSource joinViolationDriverBindingSource5;
        private GAIDataSet19TableAdapters.JoinViolationDriverTableAdapter joinViolationDriverTableAdapter5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDriverViolationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseSeriesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn violationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDriverDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
    }
}

