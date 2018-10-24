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
    public partial class Nets : Form
    {
        public Nets()
        {
            InitializeComponent();
        }

        private void Nets_FormClosing(object sender, FormClosingEventArgs e)
        {
            VarG.Nets.flag = true;
        }

        private void Nets_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Nets1.Load();
            dataGridView2.DataSource = BLL.Nets2.Load();
        }
    }
}
