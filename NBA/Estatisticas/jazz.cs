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
    public partial class jazz : Form
    {
        public jazz()
        {
            InitializeComponent();
        }

        private void jazz_FormClosing(object sender, FormClosingEventArgs e)
        {
            VarG.Jazz.flag = true;
        }

        private void jazz_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Jazz1.Load();
            dataGridView2.DataSource = BLL.Jazz2.Load();
        }
    }
}
