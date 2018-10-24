namespace NBA
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.treinadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treinadorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jogadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plantelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adversáriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estatísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.treinadorToolStripMenuItem,
            this.jogadoresToolStripMenuItem,
            this.jogosToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // treinadorToolStripMenuItem
            // 
            this.treinadorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.treinadorToolStripMenuItem1});
            this.treinadorToolStripMenuItem.Name = "treinadorToolStripMenuItem";
            this.treinadorToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.treinadorToolStripMenuItem.Text = "Treinador";
            this.treinadorToolStripMenuItem.Click += new System.EventHandler(this.treinadorToolStripMenuItem_Click);
            // 
            // treinadorToolStripMenuItem1
            // 
            this.treinadorToolStripMenuItem1.Name = "treinadorToolStripMenuItem1";
            this.treinadorToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.treinadorToolStripMenuItem1.Text = "Treinadores";
            this.treinadorToolStripMenuItem1.Click += new System.EventHandler(this.treinadorToolStripMenuItem1_Click);
            // 
            // jogadoresToolStripMenuItem
            // 
            this.jogadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plantelToolStripMenuItem,
            this.adversáriasToolStripMenuItem});
            this.jogadoresToolStripMenuItem.Name = "jogadoresToolStripMenuItem";
            this.jogadoresToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.jogadoresToolStripMenuItem.Text = "Equipas";
            // 
            // plantelToolStripMenuItem
            // 
            this.plantelToolStripMenuItem.Name = "plantelToolStripMenuItem";
            this.plantelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.plantelToolStripMenuItem.Text = "Plantel";
            this.plantelToolStripMenuItem.Click += new System.EventHandler(this.plantelToolStripMenuItem_Click);
            // 
            // adversáriasToolStripMenuItem
            // 
            this.adversáriasToolStripMenuItem.Name = "adversáriasToolStripMenuItem";
            this.adversáriasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.adversáriasToolStripMenuItem.Text = "Equipas";
            this.adversáriasToolStripMenuItem.Click += new System.EventHandler(this.adversáriasToolStripMenuItem_Click);
            // 
            // jogosToolStripMenuItem
            // 
            this.jogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jogosToolStripMenuItem1,
            this.resultadosToolStripMenuItem,
            this.estatísticasToolStripMenuItem});
            this.jogosToolStripMenuItem.Name = "jogosToolStripMenuItem";
            this.jogosToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.jogosToolStripMenuItem.Text = "Jogos";
            // 
            // jogosToolStripMenuItem1
            // 
            this.jogosToolStripMenuItem1.Name = "jogosToolStripMenuItem1";
            this.jogosToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.jogosToolStripMenuItem1.Text = "Jogos";
            this.jogosToolStripMenuItem1.Click += new System.EventHandler(this.jogosToolStripMenuItem1_Click);
            // 
            // resultadosToolStripMenuItem
            // 
            this.resultadosToolStripMenuItem.Name = "resultadosToolStripMenuItem";
            this.resultadosToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.resultadosToolStripMenuItem.Text = "Resultados";
            this.resultadosToolStripMenuItem.Click += new System.EventHandler(this.resultadosToolStripMenuItem_Click);
            // 
            // estatísticasToolStripMenuItem
            // 
            this.estatísticasToolStripMenuItem.Name = "estatísticasToolStripMenuItem";
            this.estatísticasToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.estatísticasToolStripMenuItem.Text = "Estatísticas";
            this.estatísticasToolStripMenuItem.Click += new System.EventHandler(this.estatísticasToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.logoutToolStripMenuItem.Text = "Terminar Sessão";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem treinadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jogadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jogosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resultadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estatísticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treinadorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem plantelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adversáriasToolStripMenuItem;
    }
}



