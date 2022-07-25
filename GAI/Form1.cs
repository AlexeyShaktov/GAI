using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using Excel = Microsoft.Office.Interop.Excel;

namespace GAI
{
    public partial class Form1 : Form
    {
        private Excel.Application excelapp;
        private Excel.Workbooks excelappworkbooks;
        private Excel.Workbook excelappworkbook;
        private Excel.Sheets excelsheets;
        private Excel.Worksheet excelworksheet;
        private Excel.Range excelcells;

        public int SelectedIdDriver = 0;
        int SelectedIdCar = 0;
        int SelectedViolationId = 0;
        int SelectedDriver_ViolationId = 0;
        int SelectedCarDriverId = 0;

        public static int SelectedIdDriverFor2 = 0;
        public static int SelectedIdCarFor2 = 0;
        public static int SelectedViolationIDFor2 = 0;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void sqlConnection1_InfoMessage(object sender, System.Data.SqlClient.SqlInfoMessageEventArgs e)
        {

        }

        public DataRow GetCurrentRow(DataGridView dg)
        {
            CurrencyManager cm = (CurrencyManager)dg.BindingContext[dg.DataSource, dg.DataMember];
            if (cm.Count == 0) { return null; }
            DataRowView drv = (DataRowView)cm.Current;
            return drv.Row;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gAIDataSet19.JoinViolationDriver". При необходимости она может быть перемещена или удалена.
            this.joinViolationDriverTableAdapter5.Fill(this.gAIDataSet19.JoinViolationDriver);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gAIDataSet18.JoinCarDriver". При необходимости она может быть перемещена или удалена.
            this.joinCarDriverTableAdapter2.Fill(this.gAIDataSet18.JoinCarDriver);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gAIDataSet17.JoinViolationDriver". При необходимости она может быть перемещена или удалена.
            this.joinViolationDriverTableAdapter4.Fill(this.gAIDataSet17.JoinViolationDriver);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gAIDataSet16.DriverSelect". При необходимости она может быть перемещена или удалена.
            this.driverSelectTableAdapter3.Fill(this.gAIDataSet16.DriverSelect);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gAIDataSet15.DriverSelect". При необходимости она может быть перемещена или удалена.
            this.driverSelectTableAdapter2.Fill(this.gAIDataSet15.DriverSelect);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gAIDataSet14.DriverSelect". При необходимости она может быть перемещена или удалена.
            this.driverSelectTableAdapter1.Fill(this.gAIDataSet14.DriverSelect);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gAIDataSet13.JoinCarDriver". При необходимости она может быть перемещена или удалена.
            this.joinCarDriverTableAdapter1.Fill(this.gAIDataSet13.JoinCarDriver);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gAIDataSet9.JoinViolationDriver". При необходимости она может быть перемещена или удалена.
            this.joinViolationDriverTableAdapter3.Fill(this.gAIDataSet9.JoinViolationDriver);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gAIDataSet8.JoinViolationDriver". При необходимости она может быть перемещена или удалена.
            this.joinViolationDriverTableAdapter2.Fill(this.gAIDataSet8.JoinViolationDriver);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gAIDataSet7.JoinViolationDriver". При необходимости она может быть перемещена или удалена.
            this.joinViolationDriverTableAdapter1.Fill(this.gAIDataSet7.JoinViolationDriver);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gAIDataSet5.JoinViolationDriver". При необходимости она может быть перемещена или удалена.
            this.joinViolationDriverTableAdapter.Fill(this.gAIDataSet5.JoinViolationDriver);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gAIDataSet4.JoinCarDriver". При необходимости она может быть перемещена или удалена.
            this.joinCarDriverTableAdapter.Fill(this.gAIDataSet4.JoinCarDriver);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gAIDataSet3.ViolationSelect". При необходимости она может быть перемещена или удалена.
            this.violationSelectTableAdapter.Fill(this.gAIDataSet3.ViolationSelect);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gAIDataSet2.Car_DriverSelect". При необходимости она может быть перемещена или удалена.
            this.car_DriverSelectTableAdapter.Fill(this.gAIDataSet2.Car_DriverSelect);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gAIDataSet1.CarSelect". При необходимости она может быть перемещена или удалена.
            this.carSelectTableAdapter.Fill(this.gAIDataSet1.CarSelect);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gAIDataSet.DriverSelect". При необходимости она может быть перемещена или удалена.
            this.driverSelectTableAdapter.Fill(this.gAIDataSet.DriverSelect);

            SqlConnection connection = new SqlConnection(sqlConnection2.ConnectionString);
            sqlConnection2.Open();

            SqlDataAdapter SelectCars = new SqlDataAdapter("CarSelect", sqlConnection2);
            SelectCars.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SelectCars.Fill(dt);

            DataTable dt1;
            SqlDataAdapter getDrivers = new SqlDataAdapter("getDriver", sqlConnection2);
            
            DataTable dt2;
            SqlDataAdapter getDate = new SqlDataAdapter("getViolationDate", sqlConnection2);
            
            DataTable dt3;
            SqlDataAdapter getViolation = new SqlDataAdapter("GetViolation", sqlConnection2);


            SelectCars.SelectCommand.CommandType = CommandType.StoredProcedure;
            getDrivers.SelectCommand.CommandType = CommandType.StoredProcedure;
            getDate.SelectCommand.CommandType = CommandType.StoredProcedure;
            getViolation.SelectCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    TreeNode node = new TreeNode("Автомобиль: " + dr["Brand"].ToString() + " Госномер " + dr["StateNumber"].ToString());

                    getDrivers.SelectCommand.Parameters.Add("idCar", SqlDbType.Int).Value = Convert.ToInt32(dr[0].ToString());

                    dt1 = new DataTable();
                    getDrivers.Fill(dt1);

                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        TreeNode node1 = new TreeNode("Водитель: " + dr1["SecondName"].ToString() + " " + dr1["FirstName"].ToString() + " " + dr1["MiddleName"].ToString());
                        node.Nodes.Add(node1);

                        getDate.SelectCommand.Parameters.Add("idDriver", SqlDbType.Int).Value = Convert.ToInt32(dr1[0].ToString());

                        dt2 = new DataTable();
                        getDate.Fill(dt2);

                        foreach (DataRow dr2 in dt2.Rows)
                        {
                            TreeNode node2 = new TreeNode("Дата: " + dr2["ViolationDate"].ToString());
                            node1.Nodes.Add(node2);

                            getViolation.SelectCommand.Parameters.Add("idDriver", SqlDbType.Int).Value = Convert.ToInt32(dr1[0].ToString());
                            getViolation.SelectCommand.Parameters.Add("date", SqlDbType.Date).Value = Convert.ToDateTime(dr2["ViolationDate"].ToString());

                            dt3 = new DataTable();
                            getViolation.Fill(dt3);
                            foreach (DataRow dr3 in dt3.Rows)
                            {
                                TreeNode node3 = new TreeNode("Нарушение: " + dr3["Name"].ToString());
                                node2.Nodes.Add(node3);
                            }
                            getViolation.SelectCommand.Parameters.Clear();

                        }

                        getDate.SelectCommand.Parameters.Clear();

                    }

                    getDrivers.SelectCommand.Parameters.Clear();

                    treeView1.Nodes.Add(node);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            sqlConnection2.Close();

            dataGridView2.Columns[0].Visible = false;
            dataGridView3.Columns[0].Visible = false;
            dataGridView4.Columns[0].Visible = false;
            dataGridView5.Columns[0].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow row = GetCurrentRow(dataGridView1);
            SelectedIdDriver = Convert.ToInt32(row["idDriver"]);
            firstNameBox.Text = row["FirstName"].ToString();
            middleNameBox.Text = row["MiddleName"].ToString();
            secondNameBox.Text = row["SecondName"].ToString();
            addressBox.Text = row["Address"].ToString();
            maskedTextBox1.Text = row["LicenseSeries"].ToString();
            maskedTextBox2.Text = row["LicenseNumber"].ToString();
            //label1.Text = SelectedIdDriver.ToString();

             
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "" || textBox2.Text != "" || textBox1.Text != "")
            {
                try
                {
                    sqlConnection2.Open();
                    DataTable dt = new DataTable();
                    SqlCommand myCmd = new SqlCommand("SearchDriver", sqlConnection2);
                    myCmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(myCmd);
                    da.SelectCommand.Parameters.Add("firstName", SqlDbType.VarChar, (45)).Value = textBox3.Text;
                    da.SelectCommand.Parameters.Add("middleName", SqlDbType.VarChar, (45)).Value = textBox2.Text;
                    da.SelectCommand.Parameters.Add("secondName", SqlDbType.VarChar, (45)).Value = textBox1.Text;
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlConnection2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } else
            {
                MessageBox.Show("Rack");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection2.Open();
            DataTable dt = new DataTable();
            SqlCommand myCmd = new SqlCommand("driverSelect", sqlConnection2);
            myCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection2.Close();
        }

        private void driverInsertButton_Click(object sender, EventArgs e)
        { 
                if (firstNameBox.Text != "" && middleNameBox.Text != "" && secondNameBox.Text != "" && addressBox.Text != "" && maskedTextBox1.MaskCompleted == true && maskedTextBox2.MaskCompleted == true) {
                try
                {
                    sqlConnection2.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("DriverInsert", sqlConnection2);
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sda.SelectCommand.Parameters.Add("firstName", SqlDbType.VarChar, (45)).Value = firstNameBox.Text;
                    sda.SelectCommand.Parameters.Add("middleName", SqlDbType.VarChar, (45)).Value = middleNameBox.Text;
                    sda.SelectCommand.Parameters.Add("secondName", SqlDbType.VarChar, (45)).Value = secondNameBox.Text;
                    sda.SelectCommand.Parameters.Add("address", SqlDbType.VarChar, (255)).Value = addressBox.Text;
                    sda.SelectCommand.Parameters.Add("licSer", SqlDbType.VarChar, (20)).Value = maskedTextBox1.Text;
                    sda.SelectCommand.Parameters.Add("licNum", SqlDbType.VarChar, (20)).Value = maskedTextBox2.Text;
                    sda.SelectCommand.ExecuteNonQuery();

                    SqlCommand cmd = new SqlCommand("DriverSelect", sqlConnection2);
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dataGridView1.DataSource = dt;

                    sqlConnection2.Close();
                    MessageBox.Show("Успешно добавлено");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    sqlConnection2.Close();
                }
            } else
            {
                MessageBox.Show("Заполните все поля");
            }
            
        }

        private void driverDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    sqlConnection2.Open();
                    DataTable dt = new DataTable();
                    SqlCommand myCmd = new SqlCommand("DriverDelete", sqlConnection2);
                    myCmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(myCmd);
                    da.SelectCommand.Parameters.Add("id", SqlDbType.VarChar, (45)).Value = SelectedIdDriver;
                    da.SelectCommand.ExecuteNonQuery();

                    SqlCommand cmd = new SqlCommand("DriverSelect", sqlConnection2);
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataTable dt1 = new DataTable();
                    dt1.Load(cmd.ExecuteReader());
                    dataGridView1.DataSource = dt1;
                    MessageBox.Show("Успешно удалено");
                    sqlConnection2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    sqlConnection2.Close();
                }
            }
            
        }

        private void driverUpdateButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Обновить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                if (firstNameBox.Text != "" && middleNameBox.Text != "" && secondNameBox.Text != "" && addressBox.Text != "" && maskedTextBox1.MaskCompleted == true && maskedTextBox2.MaskCompleted == true && SelectedIdDriver != 0)
                {
                    try
                    {
                        sqlConnection2.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("DriverUpdate", sqlConnection2);
                        sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                        sda.SelectCommand.Parameters.Add("id", SqlDbType.Int).Value = SelectedIdDriver;
                        sda.SelectCommand.Parameters.Add("firstName", SqlDbType.VarChar, (45)).Value = firstNameBox.Text;
                        sda.SelectCommand.Parameters.Add("middleName", SqlDbType.VarChar, (45)).Value = middleNameBox.Text;
                        sda.SelectCommand.Parameters.Add("secondName", SqlDbType.VarChar, (45)).Value = secondNameBox.Text;
                        sda.SelectCommand.Parameters.Add("address", SqlDbType.VarChar, (255)).Value = addressBox.Text;
                        sda.SelectCommand.Parameters.Add("licSer", SqlDbType.VarChar, (20)).Value = maskedTextBox1.Text;
                        sda.SelectCommand.Parameters.Add("licNum", SqlDbType.VarChar, (20)).Value = maskedTextBox2.Text;
                        sda.SelectCommand.ExecuteNonQuery();

                        SqlCommand cmd = new SqlCommand("DriverSelect", sqlConnection2);
                        cmd.CommandType = CommandType.StoredProcedure;
                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());
                        dataGridView1.DataSource = dt;

                        sqlConnection2.Close();
                        MessageBox.Show("Успешно обновлено");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        sqlConnection2.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все поля");
                }
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow row = GetCurrentRow(dataGridView2);
            brandBox.Text = row["Brand"].ToString();
            maskedTextBox4.Text = row["TechPassportSeries"].ToString();
            maskedTextBox3.Text = row["TechPassNumber"].ToString();
            maskedTextBox5.Text = row["StateNumber"].ToString();

            engineBox.Text = row["EngineNumber"].ToString();
            bodyBox.Text = row["BodyNumber"].ToString();
            ownerBox.Text = row["Owner"].ToString();
            ownerAddressBox.Text = row["OwnerAddress"].ToString();

            SelectedIdCar = Convert.ToInt32(row["idCar"]);


        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Обновить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                if (brandBox.Text != "" && engineBox.Text != "" && bodyBox.Text != "" && ownerBox.Text != "" && ownerAddressBox.Text != "" && maskedTextBox4.MaskCompleted == true && maskedTextBox3.MaskCompleted == true && maskedTextBox5.MaskCompleted == true && SelectedIdCar != 0)
                {
                    try
                    {
                        sqlConnection2.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("CarUpdate", sqlConnection2);
                        sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                        sda.SelectCommand.Parameters.Add("id", SqlDbType.Int).Value = SelectedIdCar;
                        sda.SelectCommand.Parameters.Add("brand", SqlDbType.VarChar, (45)).Value = brandBox.Text;
                        sda.SelectCommand.Parameters.Add("tPassSer", SqlDbType.VarChar, (45)).Value = maskedTextBox4.Text;
                        sda.SelectCommand.Parameters.Add("tPassNum", SqlDbType.VarChar, (255)).Value = maskedTextBox3.Text;
                        sda.SelectCommand.Parameters.Add("stateNum", SqlDbType.VarChar, (45)).Value = maskedTextBox5.Text;
                        sda.SelectCommand.Parameters.Add("engine", SqlDbType.VarChar, (45)).Value = engineBox.Text;
                        sda.SelectCommand.Parameters.Add("body", SqlDbType.VarChar, (255)).Value = bodyBox.Text;
                        sda.SelectCommand.Parameters.Add("ownerName", SqlDbType.VarChar, (45)).Value = ownerBox.Text;
                        sda.SelectCommand.Parameters.Add("ownerAddress", SqlDbType.VarChar, (255)).Value = ownerAddressBox.Text;
                        sda.SelectCommand.ExecuteNonQuery();

                        SqlCommand cmd = new SqlCommand("CarSelect", sqlConnection2);
                        cmd.CommandType = CommandType.StoredProcedure;
                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());
                        dataGridView2.DataSource = dt;

                        sqlConnection2.Close();
                        MessageBox.Show("Успешно обновлено");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        sqlConnection2.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все поля");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (searchCarBox.Text != "")
            {
                try
                {
                    sqlConnection2.Open();
                    DataTable dt = new DataTable();
                    SqlCommand myCmd = new SqlCommand("SearchCar", sqlConnection2);
                    myCmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(myCmd);
                    da.SelectCommand.Parameters.Add("stateNum", SqlDbType.VarChar, (20)).Value = searchCarBox.Text;
                    da.Fill(dt);
                    dataGridView2.DataSource = dt;
                    sqlConnection2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Rack");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sqlConnection2.Open();
            DataTable dt = new DataTable();
            SqlCommand myCmd = new SqlCommand("CarSelect", sqlConnection2);
            myCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            sqlConnection2.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (brandBox.Text != "" && engineBox.Text != "" && bodyBox.Text != "" && ownerBox.Text != "" && ownerAddressBox.Text != "" && maskedTextBox4.MaskCompleted == true && maskedTextBox3.MaskCompleted == true && maskedTextBox5.MaskCompleted == true && SelectedIdCar != 0)
            {
                try
                {
                    sqlConnection2.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("CarInsert", sqlConnection2);
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sda.SelectCommand.Parameters.Add("brand", SqlDbType.VarChar, (45)).Value = brandBox.Text;
                    sda.SelectCommand.Parameters.Add("tPassSer", SqlDbType.VarChar, (45)).Value = maskedTextBox4.Text;
                    sda.SelectCommand.Parameters.Add("tPassNum", SqlDbType.VarChar, (255)).Value = maskedTextBox3.Text;
                    sda.SelectCommand.Parameters.Add("stateNum", SqlDbType.VarChar, (45)).Value = maskedTextBox5.Text;
                    sda.SelectCommand.Parameters.Add("engine", SqlDbType.VarChar, (45)).Value = engineBox.Text;
                    sda.SelectCommand.Parameters.Add("body", SqlDbType.VarChar, (255)).Value = bodyBox.Text;
                    sda.SelectCommand.Parameters.Add("ownerName", SqlDbType.VarChar, (45)).Value = ownerBox.Text;
                    sda.SelectCommand.Parameters.Add("ownerAddress", SqlDbType.VarChar, (255)).Value = ownerAddressBox.Text;
                    sda.SelectCommand.ExecuteNonQuery();

                    SqlCommand cmd = new SqlCommand("CarSelect", sqlConnection2);
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dataGridView2.DataSource = dt;

                    sqlConnection2.Close();
                    MessageBox.Show("Успешно добавлено");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    sqlConnection2.Close();
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    sqlConnection2.Open();
                    DataTable dt = new DataTable();
                    SqlCommand myCmd = new SqlCommand("CarDelete", sqlConnection2);
                    myCmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(myCmd);
                    da.SelectCommand.Parameters.Add("id", SqlDbType.VarChar, (45)).Value = SelectedIdCar;
                    da.SelectCommand.ExecuteNonQuery();

                    SqlCommand cmd = new SqlCommand("CarSelect", sqlConnection2);
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataTable dt1 = new DataTable();
                    dt1.Load(cmd.ExecuteReader());
                    dataGridView2.DataSource = dt1;
                    MessageBox.Show("Успешно удалено");
                    sqlConnection2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    sqlConnection2.Close();
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (violationBox.Text != "")
            {
                try
                {
                    sqlConnection2.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("ViolationInsert", sqlConnection2);
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sda.SelectCommand.Parameters.Add("name", SqlDbType.VarChar, (255)).Value = violationBox.Text;
                    sda.SelectCommand.ExecuteNonQuery();

                    SqlCommand cmd = new SqlCommand("ViolationSelect", sqlConnection2);
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dataGridView3.DataSource = dt;

                    sqlConnection2.Close();
                    MessageBox.Show("Успешно добавлено");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    sqlConnection2.Close();
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Обновить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                if (violationBox.Text != "" && SelectedViolationId != 0)
                {
                    try
                    {
                        sqlConnection2.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("ViolationUpdate", sqlConnection2);
                        sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                        sda.SelectCommand.Parameters.Add("id", SqlDbType.Int).Value = SelectedViolationId;
                        sda.SelectCommand.Parameters.Add("name", SqlDbType.VarChar, (255)).Value = violationBox.Text;
                        sda.SelectCommand.ExecuteNonQuery();

                        SqlCommand cmd = new SqlCommand("ViolationSelect", sqlConnection2);
                        cmd.CommandType = CommandType.StoredProcedure;
                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());
                        dataGridView3.DataSource = dt;

                        sqlConnection2.Close();
                        MessageBox.Show("Успешно обновлено");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        sqlConnection2.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все поля");
                }
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow row = GetCurrentRow(dataGridView3);
            SelectedViolationId = Convert.ToInt32(row["idViolation"]);
            violationBox.Text = row["Name"].ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    sqlConnection2.Open();
                    DataTable dt = new DataTable();
                    SqlCommand myCmd = new SqlCommand("ViolationDelete", sqlConnection2);
                    myCmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(myCmd);
                    da.SelectCommand.Parameters.Add("id", SqlDbType.VarChar, (45)).Value = SelectedViolationId;
                    da.SelectCommand.ExecuteNonQuery();

                    SqlCommand cmd = new SqlCommand("ViolationSelect", sqlConnection2);
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataTable dt1 = new DataTable();
                    dt1.Load(cmd.ExecuteReader());
                    dataGridView3.DataSource = dt1;
                    MessageBox.Show("Успешно удалено");
                    sqlConnection2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    sqlConnection2.Close();
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Driver f = new Driver(this.textBox7,this.textBox6, this.textBox5, this.textBox4, this.maskedTextBox7, this.maskedTextBox6);
            f.ShowDialog();
            f.Owner = this;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Cars cars = new Cars(this.textBox12, this.maskedTextBox10, this.maskedTextBox9, this.maskedTextBox8, this.textBox11, this.textBox10, this.textBox9, this.textBox8);
            cars.ShowDialog();
            cars.Owner = this;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Violations v = new Violations(this.textBox13);
            v.ShowDialog();
            v.Owner = this;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (SelectedIdDriverFor2 != 0 && SelectedViolationIDFor2 != 0)
            {
                try
                {
                    sqlConnection2.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Driver_ViolationInsert", sqlConnection2);
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sda.SelectCommand.Parameters.Add("idViolation", SqlDbType.Int).Value = SelectedViolationIDFor2;
                    sda.SelectCommand.Parameters.Add("idDriver", SqlDbType.Int).Value = SelectedIdDriverFor2;
                    sda.SelectCommand.Parameters.Add("date", SqlDbType.Date).Value = dateTimePicker1.Value;
                    sda.SelectCommand.ExecuteNonQuery();

                    SqlCommand cmd = new SqlCommand("JoinViolationDriver", sqlConnection2);
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dataGridView5.DataSource = dt;

                    sqlConnection2.Close();
                    MessageBox.Show("Успешно добавлено");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    sqlConnection2.Close();
                }
            }
            else
            {
                MessageBox.Show("Выберите водителя, нарушение и дату");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (SelectedIdDriverFor2 != 0 && SelectedIdCarFor2 != 0)
            {
                try
                {
                    sqlConnection2.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Car_DriverInsert", sqlConnection2);
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sda.SelectCommand.Parameters.Add("idCar", SqlDbType.Int).Value = SelectedIdCarFor2;
                    sda.SelectCommand.Parameters.Add("idDriver", SqlDbType.Int).Value = SelectedIdDriverFor2;
                    sda.SelectCommand.ExecuteNonQuery();

                    SqlCommand cmd = new SqlCommand("JoinCarDriver", sqlConnection2);
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dataGridView4.DataSource = dt;

                    sqlConnection2.Close();
                    MessageBox.Show("Успешно добавлено");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    sqlConnection2.Close();
                }
            }
            else
            {
                MessageBox.Show("Выберите водителя и автомобиль");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Обновить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                if (SelectedDriver_ViolationId !=0 && SelectedViolationIDFor2 !=0 && dateTimePicker1 !=null && SelectedIdDriverFor2 != 0)
                {
                    try
                    {
                        sqlConnection2.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("Driver_ViolationUpdate", sqlConnection2);
                        sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                        sda.SelectCommand.Parameters.Add("id", SqlDbType.Int).Value = SelectedDriver_ViolationId;
                        sda.SelectCommand.Parameters.Add("idViolation", SqlDbType.Int).Value = SelectedViolationIDFor2;
                        sda.SelectCommand.Parameters.Add("idDriver", SqlDbType.Int).Value = SelectedIdDriverFor2;
                        sda.SelectCommand.Parameters.Add("date", SqlDbType.Date).Value = dateTimePicker1.Value;
                        sda.SelectCommand.ExecuteNonQuery();

                        SqlCommand cmd = new SqlCommand("JoinViolationDriver", sqlConnection2);
                        cmd.CommandType = CommandType.StoredProcedure;
                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());
                        dataGridView5.DataSource = dt;

                        sqlConnection2.Close();
                        MessageBox.Show("Успешно обновлено");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        sqlConnection2.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все поля");
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes && SelectedDriver_ViolationId != 0)
            {
                try
                {
                    sqlConnection2.Open();
                    DataTable dt = new DataTable();
                    SqlCommand myCmd = new SqlCommand("Driver_ViolationDelete", sqlConnection2);
                    myCmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(myCmd);
                    da.SelectCommand.Parameters.Add("id", SqlDbType.Int).Value = SelectedDriver_ViolationId;
                    da.SelectCommand.ExecuteNonQuery();

                    SqlCommand cmd = new SqlCommand("JoinViolationDriver", sqlConnection2);
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataTable dt1 = new DataTable();
                    dt1.Load(cmd.ExecuteReader());
                    dataGridView5.DataSource = dt1;
                    MessageBox.Show("Успешно удалено");
                    sqlConnection2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    sqlConnection2.Close();
                }
            }
        }

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow row = GetCurrentRow(dataGridView5);

            SelectedDriver_ViolationId = Convert.ToInt32(row["idDriver_Violation"]);
            dateTimePicker1.Value = Convert.ToDateTime(row["ViolationDate"]);
            textBox13.Text = row["Name"].ToString();

            textBox7.Text = row["FirstName"].ToString();
            textBox6.Text = row["MiddleName"].ToString();
            textBox5.Text = row["SecondName"].ToString();
            textBox4.Text = row["Address"].ToString();
            maskedTextBox7.Text = row["LicenseSeries"].ToString();
            maskedTextBox6.Text = row["LicenseNumber"].ToString();
            SelectedIdDriverFor2 = Convert.ToInt32(row["idDriver"]);
            MessageBox.Show(SelectedIdDriverFor2.ToString());
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (SelectedIdDriverFor2 != 0 && SelectedIdCarFor2 != 0 && SelectedCarDriverId != 0)
            {
                try
                {
                    sqlConnection2.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Car_DriverUpdate", sqlConnection2);
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sda.SelectCommand.Parameters.Add("id", SqlDbType.Int).Value = SelectedCarDriverId;
                    sda.SelectCommand.Parameters.Add("idCar", SqlDbType.Int).Value = SelectedIdCarFor2;
                    sda.SelectCommand.Parameters.Add("idDriver", SqlDbType.Int).Value = SelectedIdDriverFor2;
                    sda.SelectCommand.ExecuteNonQuery();

                    SqlCommand cmd = new SqlCommand("JoinCarDriver", sqlConnection2);
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dataGridView4.DataSource = dt;

                    sqlConnection2.Close();
                    MessageBox.Show("Успешно добавлено");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    sqlConnection2.Close();
                }
            }
            else
            {
                MessageBox.Show("Выберите водителя и автомобиль");
            }
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow row = GetCurrentRow(dataGridView4);

            SelectedCarDriverId = Convert.ToInt32(row["idCar_Driver"]);

            SelectedIdCarFor2 = Convert.ToInt32(row["idCar"]);
            SelectedIdDriverFor2 = Convert.ToInt32(row["idDriver"]);


            textBox7.Text = row["FirstName"].ToString();
            textBox6.Text = row["MiddleName"].ToString();
            textBox5.Text = row["SecondName"].ToString();
            textBox4.Text = row["Address"].ToString();
            maskedTextBox7.Text = row["LicenseSeries"].ToString();
            maskedTextBox6.Text = row["LicenseNumber"].ToString();
            
            MessageBox.Show(SelectedIdDriverFor2.ToString() + " " + SelectedIdCarFor2.ToString());

            textBox12.Text = row["Brand"].ToString();
            maskedTextBox10.Text = row["TechPassportSeries"].ToString();
            maskedTextBox9.Text = row["TechPassNumber"].ToString();
            maskedTextBox8.Text = row["StateNumber"].ToString();
            textBox11.Text = row["EngineNumber"].ToString();
            textBox10.Text = row["BodyNumber"].ToString();
            textBox9.Text = row["Owner"].ToString();
            textBox8.Text = row["OwnerAddress"].ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes && SelectedCarDriverId != 0)
            {
                try
                {
                    sqlConnection2.Open();
                    DataTable dt = new DataTable();
                    SqlCommand myCmd = new SqlCommand("Car_DriverDelete", sqlConnection2);
                    myCmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(myCmd);
                    da.SelectCommand.Parameters.Add("id", SqlDbType.Int).Value = SelectedCarDriverId;
                    da.SelectCommand.ExecuteNonQuery();

                    SqlCommand cmd = new SqlCommand("JoinCarDriver", sqlConnection2);
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataTable dt1 = new DataTable();
                    dt1.Load(cmd.ExecuteReader());
                    dataGridView4.DataSource = dt1;
                    MessageBox.Show("Успешно удалено");
                    sqlConnection2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    sqlConnection2.Close();
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            sqlConnection2.Open();
            SqlCommand cmd = new SqlCommand("SelectCarOnDate", sqlConnection2);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("startDate", SqlDbType.Date).Value = dateTimePicker2.Value;
            cmd.Parameters.Add("finishDate", SqlDbType.Date).Value = dateTimePicker3.Value;

            DataTable dataTable = new DataTable();
            dataTable.Load(cmd.ExecuteReader());
            dataGridView6.DataSource = dataTable;
            sqlConnection2.Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            sqlConnection2.Open();
            SqlCommand cmd = new SqlCommand("SelectDriverOnViolationAndBrand", sqlConnection2);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("Violation", SqlDbType.VarChar).Value = textBox15.Text;
            cmd.Parameters.Add("brand", SqlDbType.VarChar).Value = textBox14.Text;

            DataTable dataTable = new DataTable();
            dataTable.Load(cmd.ExecuteReader());
            dataGridView6.DataSource = dataTable;
            sqlConnection2.Close();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (dateTimePicker3.ToString() != "" && dateTimePicker2.ToString() != "")
            {
                Отчет f1 = new Отчет(dateTimePicker2.Value, dateTimePicker3.Value);
                f1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Установите даты");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            excelapp = new Excel.Application();
            excelapp.Visible = true;
            excelapp.SheetsInNewWorkbook = 3;
            excelapp.Workbooks.Add(Type.Missing);
            excelappworkbooks = excelapp.Workbooks;
            excelappworkbook = excelappworkbooks[1];
            excelsheets = excelappworkbook.Worksheets;
            excelworksheet = (Excel.Worksheet)excelsheets.get_Item(1);
            sqlConnection2.Open();
            int irow = 1;
            excelcells = excelworksheet.get_Range("A1", Type.Missing);
            excelcells.set_Value(Type.Missing, "Фамилия");
            excelcells = excelworksheet.get_Range("B1", Type.Missing);
            excelcells.set_Value(Type.Missing, "Имя");
            excelcells = excelworksheet.get_Range("C1", Type.Missing);
            excelcells.set_Value(Type.Missing, "Отчество");
            excelcells = excelworksheet.get_Range("D1", Type.Missing);
            excelcells.set_Value(Type.Missing, "Нарушение");
            excelcells = excelworksheet.get_Range("E1", Type.Missing);
            excelcells.set_Value(Type.Missing, "Марка авто");
            excelcells = excelworksheet.get_Range("F1", Type.Missing);
            excelcells.set_Value(Type.Missing, "Госномер");

            string strCmd = String.Format("SelectDriverOnViolationAndBrand");
            SqlCommand cmd = new SqlCommand(strCmd, sqlConnection2);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("Violation", SqlDbType.VarChar).Value = textBox15.Text;
            cmd.Parameters.Add("brand", SqlDbType.VarChar).Value = textBox14.Text;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                irow++;
                excelworksheet.Cells[irow, 1] = reader[0];
                excelworksheet.Cells[irow, 2] = reader[1];
                excelworksheet.Cells[irow, 3] = reader[2];
                excelworksheet.Cells[irow, 4] = reader[3];
                excelworksheet.Cells[irow, 5] = reader[4];
                excelworksheet.Cells[irow, 6] = reader[5];
            }

            sqlConnection2.Close();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();

            SqlConnection connection = new SqlConnection(sqlConnection2.ConnectionString);
            sqlConnection2.Open();

            SqlDataAdapter SelectCars = new SqlDataAdapter("CarSelect", sqlConnection2);
            SelectCars.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SelectCars.Fill(dt);

            DataTable dt1;
            SqlDataAdapter getDrivers = new SqlDataAdapter("getDriver", sqlConnection2);

            DataTable dt2;
            SqlDataAdapter getDate = new SqlDataAdapter("getViolationDate", sqlConnection2);

            DataTable dt3;
            SqlDataAdapter getViolation = new SqlDataAdapter("GetViolation", sqlConnection2);


            SelectCars.SelectCommand.CommandType = CommandType.StoredProcedure;
            getDrivers.SelectCommand.CommandType = CommandType.StoredProcedure;
            getDate.SelectCommand.CommandType = CommandType.StoredProcedure;
            getViolation.SelectCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    TreeNode node = new TreeNode("Автомобиль: " + dr["Brand"].ToString() + " Госномер " + dr["StateNumber"].ToString());

                    getDrivers.SelectCommand.Parameters.Add("idCar", SqlDbType.Int).Value = Convert.ToInt32(dr[0].ToString());

                    dt1 = new DataTable();
                    getDrivers.Fill(dt1);

                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        TreeNode node1 = new TreeNode("Водитель: " + dr1["SecondName"].ToString() + " " + dr1["FirstName"].ToString() + " " + dr1["MiddleName"].ToString());
                        node.Nodes.Add(node1);

                        getDate.SelectCommand.Parameters.Add("idDriver", SqlDbType.Int).Value = Convert.ToInt32(dr1[0].ToString());

                        dt2 = new DataTable();
                        getDate.Fill(dt2);

                        foreach (DataRow dr2 in dt2.Rows)
                        {
                            TreeNode node2 = new TreeNode("Дата: " + dr2["ViolationDate"].ToString());
                            node1.Nodes.Add(node2);

                            getViolation.SelectCommand.Parameters.Add("idDriver", SqlDbType.Int).Value = Convert.ToInt32(dr1[0].ToString());
                            getViolation.SelectCommand.Parameters.Add("date", SqlDbType.Date).Value = Convert.ToDateTime(dr2["ViolationDate"].ToString());

                            dt3 = new DataTable();
                            getViolation.Fill(dt3);
                            foreach (DataRow dr3 in dt3.Rows)
                            {
                                TreeNode node3 = new TreeNode("Нарушение: " + dr3["Name"].ToString());
                                node2.Nodes.Add(node3);
                            }
                            getViolation.SelectCommand.Parameters.Clear();

                        }

                        getDate.SelectCommand.Parameters.Clear();

                    }

                    getDrivers.SelectCommand.Parameters.Clear();

                    treeView1.Nodes.Add(node);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            sqlConnection2.Close();
        }
    }
}
