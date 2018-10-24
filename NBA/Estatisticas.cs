using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BusinessLogicLayer;

namespace NBA
{
    public partial class Estatisticas : Form
    {
        public Estatisticas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Estatisticas_FormClosing(object sender, FormClosingEventArgs e)
        {
            VarG.Estatisticas.flag = true;
        }

        private void Estatisticas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Estatisticas.Load();
        }
    }
}
