﻿using System;
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

namespace NBA.Estatisticas1
{
    public partial class Kingz : Form
    {
        public Kingz()
        {
            InitializeComponent();
        }

        private void Kingz_FormClosing(object sender, FormClosingEventArgs e)
        {
            VarG.Kings.flag = true;
        }

        private void Kingz_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Kings1.Load();
            dataGridView2.DataSource = BLL.Kings2.Load();
            dataGridView3.DataSource = BLL.Kings3.Load();
            dataGridView4.DataSource = BLL.Kings4.Load();
        }
    }
}