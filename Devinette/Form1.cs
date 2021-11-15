using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devinette
{
    public partial class Form1 : Form
    {
        private int randomNumber;

        public Form1()
        {
            InitializeComponent();
            randomNumber = randomNumb();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LabTxt_Click(object sender, EventArgs e)
        {

        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if ( randomNumber > int.Parse(txtB.Text))
            {
                LabRes.Text = txtB.Text + " est inférieure à X";
                LabRes.BackColor = Color.Red;
            }
            if (randomNumber < int.Parse(txtB.Text))
            {
                LabRes.Text = txtB.Text + " est supérieure à X";
                LabRes.BackColor = Color.Red;
            }
            if (randomNumber == int.Parse(txtB.Text))
            {
                LabRes.Text = txtB.Text + " est égale à X";
                LabRes.BackColor = Color.GreenYellow;
            }
        }

        private void bntR_Click(object sender, EventArgs e)
        {
            LabRes.Text = "";
            txtB.Text = "";
            LabRes.BackColor = Color.Empty;
            randomNumber = randomNumb();
        }

        public int randomNumb()
        {
            Random r = new Random();
            return r.Next(0, 100);   
        }
    }
}
