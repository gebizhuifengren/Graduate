using GRADUATE.COMMON.Graphic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRADUATE.UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReviewDataMenu_Click(object sender, EventArgs e)
        {
            ReviewDataForm form = new ReviewDataForm();
            form.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void ClacBtn_Click(object sender, EventArgs e)
        {

        }

        private void ROCBtn_Click(object sender, EventArgs e)
        {
            //CoordinateHelper.DrawXY(this.graphicPanel1);
            //CoordinateHelper.DrawYLine(graphicPanel1, 3, 4, 5);
            //CoordinateHelper.DrawXLine(graphicPanel1, 1.2f, 8);
        }

        private void tissueCbo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void leftGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rightGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
