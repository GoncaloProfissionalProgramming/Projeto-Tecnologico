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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {      
           passw(textBox2.Text);
           DataTable dt = BLL.Login.login(textBox1.Text,textBox2.Text);
           
          if (textBox1.Text=="Admin" && dt.Rows.Count > 0)
           {
              
                NBA.HomeAdmin opf = new HomeAdmin();
               this.Hide(); 
               opf.Show();
           
           }    
          else if (textBox1.Text=="Jogador" && dt.Rows.Count > 0)
          {
              NBA.Home opf2 = new Home();
              this.Hide();
              opf2.Show();

          }
          else if (textBox1.Text == "Treinador" && dt.Rows.Count > 0)
          {
              NBA.Home opf2 = new Home();
              this.Hide();
              opf2.Show();

          }
           else
           { 
               MessageBox.Show("Nome e/ou Senha errada(s)");
           }
           clear();
        

}
        private void clear()
        {
            textBox1.Text = null;
            textBox2.Text = null;
        }
        private void passw(string pass)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

     
       

        

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }
        }
}
    

