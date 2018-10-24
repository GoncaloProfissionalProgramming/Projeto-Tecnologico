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
    public partial class Pacers : Form
    {
        public Pacers()
        {
            InitializeComponent();
        }

        private void Pacers_FormClosing(object sender, FormClosingEventArgs e)
        {
            VarG.Pacers.flag = true;
        }

        private void Pacers_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Pacers1.Load();
            dataGridView2.DataSource = BLL.Pacers2.Load();
        }
    }
}
