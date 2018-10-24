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
    
    public partial class Treinador : Form
    {
        byte[] bArr;
        public Treinador()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(mStream);
            }
        }
        private void Treinador_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Treinador.Load();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Treinador.LoadTreinadorNome("%" + textBox1.Text + "%");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bArr = (byte[])dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[9].Value;
            pictureBox1.Image = byteArrayToImage(bArr);
        }

        private void Treinador_FormClosing(object sender, FormClosingEventArgs e)
        {
            VarG.Treinador.flag = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
