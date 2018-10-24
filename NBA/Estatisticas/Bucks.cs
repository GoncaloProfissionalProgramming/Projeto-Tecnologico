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
    public partial class BucksRes : Form
    {
        public BucksRes()
        {
            InitializeComponent();
        }

        private void Bucks_FormClosing(object sender, FormClosingEventArgs e)
        {
            VarG.Bucks.flag = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Bucks_Load(object sender, EventArgs e)
        {
        dataGridView1.DataSource = BLL.Bucks1.Load();
        dataGridView2.DataSource = BLL.Bucks2.Load();
        }
    }
}
