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
    public partial class heat : Form
    {
        public heat()
        {
            InitializeComponent();
        }

        private void heat_FormClosing(object sender, FormClosingEventArgs e)
        {
            VarG.Heat.flag = true;
        }

        private void heat_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Heat1.Load();
            dataGridView2.DataSource = BLL.Heat2.Load();
        }
    }
}
