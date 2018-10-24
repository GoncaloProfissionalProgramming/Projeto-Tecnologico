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
    public partial class RegistarEquipas : Form
    {
        public Image img;
        byte[] bArr;
        public RegistarEquipas()
        {
            InitializeComponent();
        }

        private void RegistarEquipas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Equipas.Load();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            bArr = (byte[])dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value;
            pictureBox1.Image = byteArrayToImage(bArr);
        }

        private void RegistarEquipas_FormClosing(object sender, FormClosingEventArgs e)
        {
            VarG.RegistarEquipas.flag = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int ret = BLL.Equipas.InsertEquipas(textBox1.Text, bArr);
            dataGridView1.DataSource = BLL.Equipas.Load();
            clear();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            int ret = BLL.Equipas.UpdateEquipas(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString(), textBox1.Text, bArr);
            dataGridView1.DataSource = BLL.Equipas.Load();
            clear();
        }

        private void clear()
        {
            textBox1.Text = null;
            pictureBox1.Image = null;

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
            clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
