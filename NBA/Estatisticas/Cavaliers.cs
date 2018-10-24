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
    public partial class Cavaliers : Form
    {
        public Cavaliers()
        {
            InitializeComponent();
        }

        private void Cavaliers_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource=BLL.Cavaliers1.Load();
            dataGridView2.DataSource = BLL.Cavaliers2.Load();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cavaliers_FormClosing(object sender, FormClosingEventArgs e)
        {
            VarG.Cavaliers.flag = true;
        }
    }
}
