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
    public partial class philadelphia_ers : Form
    {
        public philadelphia_ers()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void philadelphia_ers_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.ers1.Load();
            dataGridView2.DataSource = BLL.ers2.Load();
        }

        private void philadelphia_ers_FormClosing(object sender, FormClosingEventArgs e)
        {
            VarG.Philadelphia_76ers.flag = true;
        }
    }
}
