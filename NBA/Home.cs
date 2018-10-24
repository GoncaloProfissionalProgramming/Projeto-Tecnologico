using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBA
{
    public partial class Home : Form
    {
        private int childFormNumber = 0;

        public Home()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void treinadorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void treinadorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Treinador treinador = new Treinador();
            treinador.MdiParent = this;

            if (VarG.Treinador.flag == true)
            {
                treinador.Show();
                VarG.Treinador.flag = false;
            }

        }

        private void plantelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plantel plantel = new Plantel();
            plantel.MdiParent = this;

            if (VarG.Plantel.flag == true)
            {
                plantel.Show();
                VarG.Plantel.flag = false;
            }
        }

        private void jogosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DatasJogos jogos = new DatasJogos();
            jogos.MdiParent = this;

            if(VarG.DatasJogos.flag==true)
            {
                jogos.Show();
                VarG.DatasJogos.flag = false;
            }

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void resultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
         Resultados resultados = new Resultados();
            resultados.MdiParent = this;

            if (VarG.Resultados.flag == true)
            {
                resultados.Show();
                VarG.Resultados.flag = false;
            }
        }

        private void estatísticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Estatisticas estatisticas  = new Estatisticas();
           estatisticas.MdiParent = this;

            if (VarG.Estatisticas.flag == true)
            {
                estatisticas.Show();
                VarG.Estatisticas.flag = false;
            } 
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            NBA.Login log = new Login();
            log.Show();
        }

        private void adversáriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NBA.Equipas eqadv = new Equipas();
            eqadv.MdiParent = this;
            if (VarG.Equipas.flag == true)
            {
                eqadv.Show();
                VarG.Equipas.flag = false;
            }
        }
    }
}
