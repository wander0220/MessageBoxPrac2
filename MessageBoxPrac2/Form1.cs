﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxPrac2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("내용");
            MessageBox.Show("내용", "제목");
            MessageBox.Show("내용", "제목"
                , MessageBoxButtons.RetryCancel);
            MessageBox.Show("내용", "제목"
                , MessageBoxButtons.AbortRetryIgnore
                , MessageBoxIcon.Asterisk);

        }
    }
}
