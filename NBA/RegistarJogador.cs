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
    public partial class RegistarJogador : Form
    {
       
        public Image img;
        byte[] bArr;
        public RegistarJogador()
        {
            InitializeComponent();
        }

        private void RegistarJogador_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Jogadores.Load();
            textBox2.Text = DateTime.Now.ToString("dd/MM/yyyy");
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(mStream);
            }
        }
        public byte[] imgToByteArray(Image img)
        {
            using (MemoryStream mStream = new MemoryStream())
            {
                img.Save(mStream, img.RawFormat);
                return mStream.ToArray();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "png|*.png";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = fd.FileName;
                img = Image.FromFile(fd.FileName, true);
                bArr = imgToByteArray(img);
                pictureBox1.Image = byteArrayToImage(bArr);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[7].Value.ToString();
            bArr = (byte[])dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[8].Value;
            pictureBox1.Image = byteArrayToImage(bArr);
        }

        private void RegistarJogador_FormClosing(object sender, FormClosingEventArgs e)
        {
            VarG.Jogador.flag = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int ret = BLL.Jogadores.InsertJogadores(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text,textBox6.Text,textBox7.Text, bArr);
            dataGridView1.DataSource = BLL.Jogadores.Load();
            try
            {
                bArr = (byte[])BLL.Imagem.loadpic(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
                pictureBox1.Image = byteArrayToImage(bArr);
            }
            catch (Exception ex)
            {
                pictureBox1.Image = null;
            }
            clear();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            int ret = BLL.Jogadores.updateJogadores(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString(), textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text,textBox7.Text, bArr);
            dataGridView1.DataSource = BLL.Jogadores.Load();
            try
            {
                bArr = (byte[])BLL.Imagem.loadpic(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
                pictureBox1.Image = byteArrayToImage(bArr);
            }
            catch (Exception ex)
            {
                pictureBox1.Image = null;
            }
            clear();
        }
        private void clear()
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox2.Text = DateTime.Now.ToString("dd/MM/yyyy");
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
            pictureBox1.Image = NBA.Properties.Resources.contact_outline;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
