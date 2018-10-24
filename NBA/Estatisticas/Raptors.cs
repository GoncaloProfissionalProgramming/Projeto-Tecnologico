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
    public partial class Raptors : Form
    {
        public Raptors()
        {
            InitializeComponent();
        }

        private void Raptors_FormClosing(object sender, FormClosingEventArgs e)
        {
            VarG.Raptors.flag = true;
        }

        private void Raptors_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Raptors1.Load();
            dataGridView2.DataSource = BLL.Raptors2.Load();
        }
    }
}
