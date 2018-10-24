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
    public partial class Suns : Form
    {
        public Suns()
        {
            InitializeComponent();
        }

        private void Suns_FormClosing(object sender, FormClosingEventArgs e)
        {
            VarG.Suns.flag = true;
        }

        private void Suns_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Suns1.Load();
            dataGridView2.DataSource = BLL.Suns2.Load();
            dataGridView3.DataSource = BLL.Suns3.Load();
            dataGridView4.DataSource = BLL.Suns4.Load();
        }
    }
}
