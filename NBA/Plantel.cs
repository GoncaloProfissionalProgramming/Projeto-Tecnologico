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
    public partial class Plantel : Form
    {
        byte[] bArr;
        public Plantel()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bArr = (byte[])dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[8].Value;
            pictureBox1.Image = byteArrayToImage(bArr);
        }

        private void Plantel_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Jogadores.Load();
        }

        private void Plantel_FormClosing(object sender, FormClosingEventArgs e)
        {
            VarG.Plantel.flag = true;
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(mStream);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = BLL.Jogadores.LoadJogadorNome("%" + textBox1.Text + "%");
            
        }
    }
}
