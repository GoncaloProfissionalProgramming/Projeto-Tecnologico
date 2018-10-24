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
    public partial class wizards : Form
    {
        public wizards()
        {
            InitializeComponent();
        }

        private void wizards_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Wizards1.Load();
            dataGridView2.DataSource = BLL.Wizards2.Load();
        }

        private void wizards_FormClosing(object sender, FormClosingEventArgs e)
        {
            VarG.Wizards.flag = true;
        }
    }
}
