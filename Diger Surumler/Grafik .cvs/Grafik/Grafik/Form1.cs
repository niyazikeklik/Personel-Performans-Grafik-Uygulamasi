﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       public Form5 form1;

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
          
            form1.cartesianChart1.Zoom = LiveCharts.ZoomingOptions.Xy;
            e.Cancel=true;
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}