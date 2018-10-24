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

namespace NBA.Estatisticas1
{
    public partial class Timberwolves : Form
    {
        public Timberwolves()
        {
            InitializeComponent();
        }

        private void Timberwolves_FormClosing(object sender, FormClosingEventArgs e)
        {
            VarG.Timberwolves.flag = true;
        }

        private void Timberwolves_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Timberwolves1.Load();
            dataGridView2.DataSource = BLL.Timberwolves2.Load();
            dataGridView3.DataSource = BLL.Timberwolves3.Load();
        }
    }
}
