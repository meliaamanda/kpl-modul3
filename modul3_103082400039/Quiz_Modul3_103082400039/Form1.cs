using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Modul3_103082400039
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "Jawaban benar";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "Jawaban salah";
        }

        private void lblSoal_Click(object sender, EventArgs e)
        {
            
        }
        

        private void buttonD_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "Jawaban salah";
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "Jawaban salah";
        }

        private void lblOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
