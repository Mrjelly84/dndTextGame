﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dndTextGame
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            Form1 gameForm = new Form1();
            gameForm.ShowDialog();
            
            this.Close();

        }
    }
}
