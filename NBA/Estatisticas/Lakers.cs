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
    public partial class Lakers : Form
    {
        public Lakers()
        {
            InitializeComponent();
        }

        private void Lakers_FormClosing(object sender, FormClosingEventArgs e)
        {
            VarG.Lakers.flag = true;
        }

        private void Lakers_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Lakers1.Load();
            dataGridView2.DataSource = BLL.Lakers2.Load();
            dataGridView3.DataSource = BLL.Lakers3.Load();
            dataGridView4.DataSource = BLL.Lakers4.Load();
        }
    }
}
