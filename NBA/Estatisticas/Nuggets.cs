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
    public partial class Nuggets : Form
    {
        public Nuggets()
        {
            InitializeComponent();
        }

        private void Nuggets_FormClosing(object sender, FormClosingEventArgs e)
        {
            VarG.Nuggets.flag = true;
        }

        private void Nuggets_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Nuggets1.Load();
            dataGridView2.DataSource = BLL.Nuggets2.Load();
            dataGridView3.DataSource = BLL.Nuggets3.Load();
            dataGridView4.DataSource = BLL.Nuggets4.Load();
        }
    }
}
