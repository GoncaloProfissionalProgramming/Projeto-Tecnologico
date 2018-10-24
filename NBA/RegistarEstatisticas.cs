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
    public partial class RegistarEstatisticas : Form
    {
        public RegistarEstatisticas()
        {
            InitializeComponent();
        }

        private void RegistarEstatisticas_FormClosing(object sender, FormClosingEventArgs e)
        {
            VarG.RegistarEstatisticas.flag = true;
        }
        private void clear()
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
            textBox8.Text = null;
            textBox9.Text = null;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString(),

            textBox1.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[7].Value.ToString();
            textBox8.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[8].Value.ToString();
            textBox9.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[9].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;
            dataGridView1.Visible = true;
            dataGridView1.DataSource = BLL.Estatisticas.Load();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int ret = BLL.Estatisticas.InsertEstatisticas(textBox1.Text, Int32.Parse(textBox2.Text), Int32.Parse(textBox3.Text), Int32.Parse(textBox4.Text), textBox5.Text, Int32.Parse(textBox6.Text), textBox7.Text, textBox8.Text, Int32.Parse(textBox9.Text));
           dataGridView1.DataSource = BLL.Estatisticas.Load();
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            dataGridView2.DataSource = BLL.Jogos.Load();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            int ret = BLL.Estatisticas.UpdateEstatisticas(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString(), textBox1.Text, Int32.Parse(textBox2.Text), Int32.Parse(textBox3.Text), Int32.Parse(textBox4.Text), textBox5.Text, Int32.Parse(textBox6.Text), textBox7.Text, textBox8.Text, Int32.Parse(textBox9.Text));
            dataGridView1.DataSource = BLL.Estatisticas.Load();
            clear();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
