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
    public partial class RegistarDatasJogos : Form
    {
        public string i;
        public RegistarDatasJogos()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RegistarDatasJogos_Load(object sender, EventArgs e)
        {
            textBox2.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void RegistarDatasJogos_FormClosing(object sender, FormClosingEventArgs e)
        {
            VarG.RegistarJogos.flag = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            dataGridView2.DataSource = BLL.Equipas.Load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;
            dataGridView1.Visible = true;
            dataGridView1.DataSource = BLL.Jogos.Load();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(textBox1.Text)))
            {
                MessageBox.Show("Não exsite equipa associada");
            }
            int ret = BLL.Jogos.InsertDatasJogos(textBox1.Text, textBox2.Text,i);
            dataGridView1.DataSource = BLL.Jogos.Load();
            clear();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            int ret = BLL.Jogos.UpdateDatasJogos(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString(), textBox1.Text, textBox2.Text,i);
            dataGridView1.DataSource = BLL.Jogos.Load();
            clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
        }
        private void clear()
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox2.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            textBox1.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if ((radioButton2.Checked == true))
            {
                i = "Fora";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if ((radioButton1.Checked == true))
            {
                i = "Casa";
            }
        }
    }
}
