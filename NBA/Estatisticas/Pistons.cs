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
    public partial class Pistons : Form
    {
        public Pistons()
        {
            InitializeComponent();
        }

        private void Pistons_FormClosing(object sender, FormClosingEventArgs e)
        {
            VarG.Pistons.flag = true;
        }

        private void Pistons_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Pistons1.Load();
            dataGridView2.DataSource = BLL.Pistons2.Load();
        }
    }
}
