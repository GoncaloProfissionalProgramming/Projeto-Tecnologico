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
    public partial class Knicks : Form
    {
        public Knicks()
        {
            InitializeComponent();
        }

        private void Knicks_FormClosing(object sender, FormClosingEventArgs e)
        {
            VarG.Knicks.flag = true;
        }

        private void Knicks_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Knicks1.Load();
            dataGridView1.DataSource = BLL.Knicks2.Load();
        }
    }
}
