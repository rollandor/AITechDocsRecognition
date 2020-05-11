using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AITechDocsRecognition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void imgBtnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ImgBtnHelp_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            bunifuImageButton4.ShowActiveImage = true;
            //bunifuImageButton4.BackColor = Color.FromArgb(156, 228, 238);
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
