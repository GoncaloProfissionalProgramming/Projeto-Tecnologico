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
    public partial class mavericks : Form
    {
        public mavericks()
        {
            InitializeComponent();
        }

        private void mavericks_FormClosing(object sender, FormClosingEventArgs e)
        {
            VarG.Mavericks.flag = true;
        }

        private void mavericks_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Mavericks1.Load();
            dataGridView2.DataSource = BLL.Mavericks2.Load();
            dataGridView3.DataSource = BLL.Mavericks3.Load();
            dataGridView4.DataSource = BLL.Mavericks4.Load();

        }
    }
}
