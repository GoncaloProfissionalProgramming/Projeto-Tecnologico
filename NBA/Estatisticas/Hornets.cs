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
    public partial class Hornets : Form
    {
        public Hornets()
        {
            InitializeComponent();
        }

        private void Hornets_FormClosing(object sender, FormClosingEventArgs e)
        {
            VarG.Hornets.flag = true;
        }

        private void Hornets_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Hornets1.Load();
            dataGridView1.DataSource = BLL.Hornets2.Load();
        }
    }
}
