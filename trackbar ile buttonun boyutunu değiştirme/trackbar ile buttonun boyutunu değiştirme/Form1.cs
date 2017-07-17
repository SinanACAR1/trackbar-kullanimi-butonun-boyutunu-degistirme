using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar1.Maximum = 200;
            trackBar1.Minimum = 20;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            button1.Height = trackBar1.Value;
           button1.Width = trackBar1.Value;
        }

      
    }
}
