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
    public partial class hawks : Form
    {
        public hawks()
        {
            InitializeComponent();
        }

        private void hawks_FormClosing(object sender, FormClosingEventArgs e)
        {
            VarG.Hawks.flag = true;
        }

        private void hawks_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Hawks1.Load();
            dataGridView2.DataSource = BLL.Hawks2.Load();
        }
    }
}
