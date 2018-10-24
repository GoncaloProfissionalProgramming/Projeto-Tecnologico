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
    public partial class RegistarTreinador : Form
    {
        public Image img;
        byte[] bArr;
        public RegistarTreinador()
        {
            InitializeComponent();
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
        private void RegistarTreinador_FormClosing(object sender, FormClosingEventArgs e)
        {
            VarG.TreinadorReg.flag = true;
        }

        private void RegistarTreinador_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = BLL.Treinador.Load();
            textBox8.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int ret = BLL.Treinador.InsertTreinador(textBox1.Text, Int32.Parse(textBox2.Text), textBox8.Text, textBox3.Text, Int32.Parse(textBox4.Text), Int32.Parse(textBox5.Text), Int32.Parse(textBox6.Text), Int32.Parse(textBox7.Text), bArr);
            dataGridView2.DataSource = BLL.Treinador.Load();
            try
            {
                bArr = (byte[])BLL.Imagem.loadpic(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value.ToString());
                pictureBox1.Image = byteArrayToImage(bArr);
            }
            catch (Exception ex)
            {
                pictureBox1.Image = null;
            }
            clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            int ret = BLL.Treinador.updateTreinador(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value.ToString(), textBox1.Text, Int32.Parse(textBox2.Text), textBox7.Text, textBox3.Text, Int32.Parse(textBox4.Text), Int32.Parse(textBox5.Text), Int32.Parse(textBox6.Text), Int32.Parse(textBox7.Text), bArr);
            dataGridView2.DataSource = BLL.Treinador.Load();
            try
            {
                bArr = (byte[])BLL.Imagem.loadpic(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value.ToString());
                pictureBox1.Image = byteArrayToImage(bArr);
            }
            catch (Exception ex)
            {
                pictureBox1.Image = null;
            }
            clear();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[1].Value.ToString();
            textBox2.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[2].Value.ToString();
            textBox7.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[2].Value.ToString();
            textBox3.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[4].Value.ToString();
            textBox4.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[5].Value.ToString();
            textBox5.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[6].Value.ToString();
            textBox6.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[7].Value.ToString();
            textBox7.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[8].Value.ToString();
           
            bArr = (byte[])dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[9].Value;
            pictureBox1.Image = byteArrayToImage(bArr);
        }
            
        private void clear()
        {   
           textBox1.Text = null;
           textBox2.Text = null;
           textBox7.Text = null;
           textBox3.Text = null;
           textBox4.Text = null;
           textBox5.Text = null;
           textBox6.Text = null;
           textBox7.Text = null;
           pictureBox1.Image = NBA.Properties.Resources.contact_outline;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            clear();
        } 
     
    }
}
