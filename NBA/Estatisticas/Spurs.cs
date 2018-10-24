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
    public partial class Spurs : Form
    {
        public Spurs()
        {
            InitializeComponent();
        }

        private void Spurs_FormClosing(object sender, FormClosingEventArgs e)
        {
            VarG.Spurs.flag = true;
        }

        private void Spurs_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Spurs1.Load();
            dataGridView2.DataSource = BLL.Spurs2.Load();
            dataGridView3.DataSource = BLL.Spurs3.Load();
            dataGridView4.DataSource = BLL.Spurs4.Load();

        }
    }
}
