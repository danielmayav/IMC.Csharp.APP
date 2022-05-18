using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC.DanielMayaVera
{
    public partial class formCal : Form
    {
        public formCal()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void formCal_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            lblDate.Text = fecha.ToString();
        }
    }
}
