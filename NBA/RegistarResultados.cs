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
    public partial class RegistarResultados : Form
    {
        public string i;

        public RegistarResultados()
        {
            InitializeComponent();
        }

        private void RegistarResultados_Load(object sender, EventArgs e)
        {
            
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

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
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
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
           
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            int ret = BLL.Resultados.UpdateResultados(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString(), textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text,i);
            dataGridView2.Visible = false;
            dataGridView1.Visible = true;
            dataGridView1.DataSource = BLL.Resultados.Load();
            clear();
        }

        private void RegistarResultados_FormClosing(object sender, FormClosingEventArgs e)
        {
            VarG.RegistarResultados.flag = true;
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            int ret = BLL.Resultados.InsertResultados(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text,i);
            dataGridView2.Visible = false;
            dataGridView1.Visible = true;
            dataGridView1.DataSource = BLL.Resultados.Load();
            clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            dataGridView2.DataSource = BLL.Jogos.Load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;
            dataGridView1.Visible = true;
            dataGridView1.DataSource = BLL.Resultados.Load();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if ((radioButton1.Checked == true))
            {
                i = "Vitoria";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if ((radioButton2.Checked == true))
            {
                i = "Derrota";
            }
        }

        }

        }

       
    

