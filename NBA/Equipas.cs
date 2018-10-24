using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BusinessLogicLayer;
namespace NBA
{
    
    public partial class Equipas : Form
    {
        
        byte[] bArr;
        public Equipas()
        {
            InitializeComponent();
        }

       

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(mStream);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bArr = (byte[])dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value;
            pictureBox1.Image = byteArrayToImage(bArr);
        }

        private void Equipas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Equipas.Load();
        }

        private void Equipas_FormClosing(object sender, FormClosingEventArgs e)
        {
            VarG.Equipas.flag = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Equipas.LoadEquipasNome("%" + textBox1.Text + "%");
        }

       

        


    }
}
