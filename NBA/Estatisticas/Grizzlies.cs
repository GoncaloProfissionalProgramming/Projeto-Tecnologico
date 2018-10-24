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
    public partial class Grizzlies : Form
    {
        public Grizzlies()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Grizzlies_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Grizzlies1.Load();
            dataGridView2.DataSource = BLL.Grizzlies2.Load();
            dataGridView3.DataSource = BLL.Grizzlies3.Load();
            dataGridView4.DataSource = BLL.Grizzlies4.Load();
        }

        private void Grizzlies_FormClosing(object sender, FormClosingEventArgs e)
        {
            VarG.Grizzlies.flag = true;
        }
    }
}
