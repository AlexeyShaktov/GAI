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
    public partial class Cars : Form
    {
        int SelectedCar = 0;
        TextBox brandBox;
        TextBox engineBox;
        TextBox bodyBox;
        TextBox ownerBox;
        TextBox ownerAddressBox;
        MaskedTextBox maskedTextBox4;
        MaskedTextBox maskedTextBox3;
        MaskedTextBox maskedTextBox5;

        public Cars(TextBox tb1, MaskedTextBox mtb1, MaskedTextBox mtb2, MaskedTextBox mtb3, TextBox tb2, TextBox tb3, TextBox tb4, TextBox tb5)
        {
            InitializeComponent();
            brandBox = tb1;
            maskedTextBox4 = mtb1;
            maskedTextBox3 = mtb2;
            maskedTextBox5 = mtb3;
            engineBox = tb2;
            bodyBox = tb3;
            ownerBox = tb4;
            ownerAddressBox = tb5;
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gAIDataSet10.CarSelect". При необходимости она может быть перемещена или удалена.
            this.carSelectTableAdapter.Fill(this.gAIDataSet10.CarSelect);

        }

        public DataRow GetCurrentRow(DataGridView dg)
        {
            CurrencyManager cm = (CurrencyManager)dg.BindingContext[dg.DataSource, dg.DataMember];
            if (cm.Count == 0) { return null; }
            DataRowView drv = (DataRowView)cm.Current;
            return drv.Row;
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow row = GetCurrentRow(dataGridView1);
            brandBox.Text = row["Brand"].ToString();
            maskedTextBox4.Text = row["TechPassportSeries"].ToString();
            maskedTextBox3.Text = row["TechPassNumber"].ToString();
            maskedTextBox5.Text = row["StateNumber"].ToString();

            engineBox.Text = row["EngineNumber"].ToString();
            bodyBox.Text = row["BodyNumber"].ToString();
            ownerBox.Text = row["Owner"].ToString();
            ownerAddressBox.Text = row["OwnerAddress"].ToString();

            SelectedCar = Convert.ToInt32(row["idCar"]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.SelectedIdCarFor2 = SelectedCar;
            MessageBox.Show(Convert.ToString(Form1.SelectedIdCarFor2));
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (searchCarBox.Text != "")
            {
                try
                {
                    sqlConnection1.Open();
                    DataTable dt = new DataTable();
                    SqlCommand myCmd = new SqlCommand("SearchCar", sqlConnection1);
                    myCmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(myCmd);
                    da.SelectCommand.Parameters.Add("stateNum", SqlDbType.VarChar, (20)).Value = searchCarBox.Text;
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

        private void button7_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            DataTable dt = new DataTable();
            SqlCommand myCmd = new SqlCommand("carSelect", sqlConnection1);
            myCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection1.Close();
        }
    }
}
