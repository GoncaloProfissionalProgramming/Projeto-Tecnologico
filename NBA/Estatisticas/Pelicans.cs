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
    public partial class Pelicans : Form
    {
        public Pelicans()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pelicans_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Pelicans1.Load();
            dataGridView2.DataSource = BLL.Pelicans2.Load();
            dataGridView3.DataSource = BLL.Pelicans3.Load();
        }

        private void Pelicans_FormClosing(object sender, FormClosingEventArgs e)
        {
            VarG.Pelicans.flag = true;
        }
    }
}
