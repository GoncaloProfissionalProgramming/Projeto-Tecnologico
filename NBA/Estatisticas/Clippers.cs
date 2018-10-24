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
    public partial class Clippers : Form
    {
        public Clippers()
        {
            InitializeComponent();
        }

        private void Clippers_FormClosing(object sender, FormClosingEventArgs e)
        {
            VarG.Clippers.flag = true;
        }

        private void Clippers_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Clippers1.Load();
            dataGridView2.DataSource = BLL.Clippers2.Load();
            dataGridView3.DataSource = BLL.Clippers3.Load();
            dataGridView4.DataSource = BLL.Clippers4.Load();
        }
    }
}
