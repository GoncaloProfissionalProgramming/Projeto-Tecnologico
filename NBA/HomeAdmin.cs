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
    public partial class HomeAdmin : Form
    {
        private int childFormNumber = 0;

        public HomeAdmin()
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

        private void printSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editMenu_Click(object sender, EventArgs e)
        {

        }

       
        private void indexToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }
        private void Home_Load(object sender, EventArgs e)
        {

        }
        private void treinadorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NBA.RegistarJogador opf = new NBA.RegistarJogador();
            opf.MdiParent = this;
              
            if(VarG.Jogador.flag==true)
            {
                opf.Show();
                VarG.Jogador.flag = false;
            }
            
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            
       
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            RegistarEstatisticas reg = new RegistarEstatisticas();
            reg.MdiParent = this;
            
            if (VarG.RegistarEstatisticas.flag == true)
            {
                reg.Show();
                VarG.RegistarEstatisticas.flag = false;
            }  
        }

        private void registarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistarTreinador regt = new RegistarTreinador();
            regt.MdiParent = this;
            
            if (VarG.TreinadorReg.flag == true)
            {
                regt.Show();
                VarG.TreinadorReg.flag = false;
            }
        }
        
        private void registarResultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistarResultados regres = new RegistarResultados();
            regres.MdiParent = this;

            if (VarG.RegistarResultados.flag == true)
            {
                regres.Show();
                VarG.RegistarResultados.flag = false;
            }
            }

        private void plantelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plantel plantel = new Plantel();
            plantel.MdiParent = this;
            
            if( VarG.Plantel.flag == true)
            {
                plantel.Show();
                VarG.Plantel.flag = false;
            }
        }

        private void treinadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Treinador treinador = new Treinador();
            treinador.MdiParent = this;
            
            if( VarG.Treinador.flag == true)
            {
                treinador.Show();
                VarG.Treinador.flag = false;
            }
        }

        private void registarJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistarDatasJogos jogos = new RegistarDatasJogos();
            jogos.MdiParent = this;

            if (VarG.RegistarJogos.flag == true)
            { 
                jogos.Show();
               VarG.RegistarJogos.flag = false;
            }
        }

        private void registarEquipasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistarEquipas regeq = new RegistarEquipas();
            regeq.MdiParent = this;

            if (VarG.RegistarEquipas.flag == true)
            {
                regeq.Show();
                VarG.RegistarEquipas.flag = false;
            }
        }

        private void terminarSessâoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            NBA.Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void equipasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NBA.Equipas eqadv = new Equipas();
            eqadv.MdiParent = this;
            if (VarG.Equipas.flag == true)
            {
                eqadv.Show();
                VarG.Equipas.flag = false;
            }
        }

        private void jogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NBA.DatasJogos DtsJgs = new DatasJogos();
            DtsJgs.MdiParent = this;
            if (VarG.DatasJogos.flag == true)
            {
                DtsJgs.Show();
                VarG.DatasJogos.flag = false;
            }
        }

        private void resultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NBA.Resultados result = new Resultados();
            result.MdiParent = this;
            if (VarG.Resultados.flag == true)
            {
                result.Show();
                VarG.Resultados.flag = false;
            }
        }

        private void estatisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NBA.Estatisticas estatistic = new Estatisticas();
            estatistic.MdiParent = this;
            if (VarG.Estatisticas.flag == true)
            {
                estatistic.Show();
                VarG.Estatisticas.flag = false;
            }
        }












        }

       
    

       

       

       
    }


