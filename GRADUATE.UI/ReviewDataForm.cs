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
    public partial class ReviewDataForm : Form
    {
        public ReviewDataForm()
        {
            InitializeComponent();

            MessageBox.Show(this.Width.ToString());
            this.Left = 10;
            this.DataView.Width = this.Width - 20;
        }

        private void ReviewDataForm_Load(object sender, EventArgs e)
        {

        }

        private void ReviewDataForm_SizeChanged(object sender, EventArgs e)
        {
            this.DataView.Width = this.Width-20;
            this.DataView.Height = this.Height - 60;
        }
    }
}
