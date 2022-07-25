using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAI
{
    public partial class Driver : Form
    {
        int SelectedDriver = 0;

        TextBox firstNameBox;
        TextBox middleNameBox;
        TextBox secondNameBox;
        TextBox addressBox;
        MaskedTextBox maskedTextBox1;
        MaskedTextBox maskedTextBox2;

        public Driver(TextBox t1, TextBox t2, TextBox t3, TextBox t4, MaskedTextBox mb1, MaskedTextBox mb2)
        {
            InitializeComponent();
            firstNameBox = t1;
            middleNameBox = t2;
            secondNameBox = t3;
            addressBox = t4;
            maskedTextBox1 = mb1;
            maskedTextBox2 = mb2;
        }

        private void Driver_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gAIDataSet6.DriverSelect". При необходимости она может быть перемещена или удалена.
            this.driverSelectTableAdapter.Fill(this.gAIDataSet6.DriverSelect);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "" || textBox2.Text != "" || textBox1.Text != "")
            {
                try
                {
                    sqlConnection1.Open();
                    DataTable dt = new DataTable();
                    SqlCommand myCmd = new SqlCommand("SearchDriver", sqlConnection1);
                    myCmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(myCmd);
                    da.SelectCommand.Parameters.Add("firstName", SqlDbType.VarChar, (45)).Value = textBox3.Text;
                    da.SelectCommand.Parameters.Add("middleName", SqlDbType.VarChar, (45)).Value = textBox2.Text;
                    da.SelectCommand.Parameters.Add("secondName", SqlDbType.VarChar, (45)).Value = textBox1.Text;
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlConnection1.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    sqlConnection1.Close();
                }
            }
            else
            {
                MessageBox.Show("Rack");
            }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow row = GetCurrentRow(dataGridView1);
            SelectedDriver = Convert.ToInt32(row["idDriver"]);
            firstNameBox.Text = row["FirstName"].ToString();
            middleNameBox.Text = row["MiddleName"].ToString();
            secondNameBox.Text = row["SecondName"].ToString();
            addressBox.Text = row["Address"].ToString();
            maskedTextBox1.Text = row["LicenseSeries"].ToString();
            maskedTextBox2.Text = row["LicenseNumber"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.SelectedIdDriverFor2 = SelectedDriver;
            MessageBox.Show(Convert.ToString(Form1.SelectedIdDriverFor2));
            this.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            DataTable dt = new DataTable();
            SqlCommand myCmd = new SqlCommand("driverSelect", sqlConnection1);
            myCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection1.Close();
        }
    }
}
