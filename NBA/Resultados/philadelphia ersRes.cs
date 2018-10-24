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

namespace NBA.Resultados
{
    public partial class philadelphia_ers : Form
    {
        public philadelphia_ers()
        {
            InitializeComponent();
        }

        private void philadelphia_ers_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.ErsRes1.Load();
        }
    }
}
