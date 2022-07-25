using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAI
{
    public partial class Violations : Form
    {
        TextBox box;
        int SelectedViolation = 0;

        public Violations(TextBox tb)
        {
            InitializeComponent();
            box = tb;
        }

        private void Violations_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gAIDataSet12.ViolationSelect". При необходимости она может быть перемещена или удалена.
            this.violationSelectTableAdapter.Fill(this.gAIDataSet12.ViolationSelect);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gAIDataSet11.Driver_ViolationSelect". При необходимости она может быть перемещена или удалена.
            this.driver_ViolationSelectTableAdapter.Fill(this.gAIDataSet11.Driver_ViolationSelect);

        }

        public DataRow GetCurrentRow(DataGridView dg)
        {
            CurrencyManager cm = (CurrencyManager)dg.BindingContext[dg.DataSource, dg.DataMember];
            if (cm.Count == 0) { return null; }
            DataRowView drv = (DataRowView)cm.Current;
            return drv.Row;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.SelectedViolationIDFor2 = SelectedViolation;
            MessageBox.Show(Convert.ToString(Form1.SelectedViolationIDFor2));
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow row = GetCurrentRow(dataGridView1);
            box.Text = row["Name"].ToString();


            SelectedViolation = Convert.ToInt32(row["idViolation"]);
        }
    }
}
