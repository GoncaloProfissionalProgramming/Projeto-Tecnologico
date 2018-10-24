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
    public partial class Magic : Form
    {
        public Magic()
        {
            InitializeComponent();
        }

        private void Magic_FormClosing(object sender, FormClosingEventArgs e)
        {
            VarG.Magic.flag = true;
        }

        private void Magic_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Magic1.Load();
            dataGridView2.DataSource = BLL.Magic2.Load();
            
        }
    }
}
