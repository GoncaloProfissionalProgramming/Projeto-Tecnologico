using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using System.IO;

namespace NBA
{
    public partial class Rockets : Form
    {
        public Rockets()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Rockets_FormClosing(object sender, FormClosingEventArgs e)
        {
            VarG.Rockets.flag = true;
        }

        private void Rockets_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Rockets1.Load();
            dataGridView2.DataSource = BLL.Rockets2.Load();
            dataGridView3.DataSource = BLL.Rockets3.Load();
        }
    }
}
