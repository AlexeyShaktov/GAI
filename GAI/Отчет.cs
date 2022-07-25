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
    public partial class Отчет : Form
    {
        DateTime Start;
        DateTime Finish;
        public Отчет(DateTime s, DateTime f)
        {
            InitializeComponent();
            Start = s;
            Finish = f;
        }

        private void Отчет_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "GAIDataSet22.SelectCarOnDate". При необходимости она может быть перемещена или удалена.
            this.SelectCarOnDateTableAdapter.Fill(this.GAIDataSet22.SelectCarOnDate, Start, Finish);

            this.reportViewer1.RefreshReport();
        }
    }
}
