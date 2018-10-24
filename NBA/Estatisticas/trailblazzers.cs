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

namespace NBA.Estatisticas
{
    public partial class trailblazzers : Form
    {
        public trailblazzers()
        {
            InitializeComponent();
        }

        private void trailblazzers_FormClosing(object sender, FormClosingEventArgs e)
        {
            VarG.Traillblazzers.flag = true;
        }

        private void trailblazzers_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Trailblazzers1.Load();
            dataGridView2.DataSource = BLL.Trailblazzers2.Load();
            dataGridView3.DataSource = BLL.Trailblazzers3.Load();
            dataGridView4.DataSource = BLL.Trailblazzers4.Load();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
