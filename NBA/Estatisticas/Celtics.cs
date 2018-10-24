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

namespace NBA
{
    public partial class Celtics : Form
    {
        public Celtics()
        {
            InitializeComponent();
        }

        private void Celtics_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Celtics1.Load();
            dataGridView2.DataSource = BLL.Celtics2.Load();
        }

        private void Celtics_FormClosing(object sender, FormClosingEventArgs e)
        {
            VarG.Celtics.flag = true;
        }
    }
}
