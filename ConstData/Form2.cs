﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstData
{
    public partial class Form2 : Form
    {
        private string receivedData;

        public Form2(string data)
        {
            InitializeComponent();
            receivedData = data;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = receivedData;
        }
    }
}
