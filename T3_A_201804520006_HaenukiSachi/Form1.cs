//Haenuki Sachi (2018-0452-0006)
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T3_A_201804520006_HaenukiSachi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                radioButton5.Visible = true;
                radioButton6.Visible = true;
                radioButton7.Visible = true;
            }
            else
            {
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                radioButton9.Visible = true;
                radioButton10.Visible = true;
                radioButton11.Visible = true;
                radioButton12.Visible = true;
                radioButton13.Visible = true;
                radioButton14.Visible = true;
            }
            else
            {
                radioButton9.Visible = false;
                radioButton10.Visible = false;
                radioButton11.Visible = false;
                radioButton12.Visible = false;
                radioButton13.Visible = false;
                radioButton14.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                radioButton17.Visible = true;
                radioButton18.Visible = true;
                radioButton19.Visible = true;
                radioButton20.Visible = true;
                radioButton21.Visible = true;
            }
            else
            {
                radioButton17.Visible = false;
                radioButton18.Visible = false;
                radioButton19.Visible = false;
                radioButton20.Visible = false;
                radioButton21.Visible = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                radioButton24.Visible = true;
                radioButton25.Visible = true;
                radioButton26.Visible = true;
                radioButton27.Visible = true;
                radioButton28.Visible = true;
            }
            else
            {
                radioButton24.Visible = false;
                radioButton25.Visible = false;
                radioButton26.Visible = false;
                radioButton27.Visible = false;
                radioButton28.Visible = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                radioButton31.Visible = true;
                radioButton32.Visible = true;
                radioButton33.Visible = true;
                radioButton34.Visible = true;
                radioButton35.Visible = true;
            }
            else
            {
                radioButton31.Visible = false;
                radioButton32.Visible = false;
                radioButton33.Visible = false;
                radioButton34.Visible = false;
                radioButton35.Visible = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                radioButton38.Visible = true;
                radioButton39.Visible = true;
                radioButton40.Visible = true;
                radioButton41.Visible = true;
                radioButton42.Visible = true;
            }
            else
            {
                radioButton38.Visible = false;
                radioButton39.Visible = false;
                radioButton40.Visible = false;
                radioButton41.Visible = false;
                radioButton42.Visible = false;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                radioButton45.Visible = true;
                radioButton46.Visible = true;
                radioButton47.Visible = true;
                radioButton48.Visible = true;
                radioButton49.Visible = true;
            }
            else
            {
                radioButton45.Visible = false;
                radioButton46.Visible = false;
                radioButton47.Visible = false;
                radioButton48.Visible = false;
                radioButton49.Visible = false;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                radioButton51.Visible = true;
                radioButton52.Visible = true;
                radioButton53.Visible = true;
                radioButton54.Visible = true;
                radioButton55.Visible = true;
                radioButton56.Visible = true;
            }
            else
            {
                radioButton51.Visible = false;
                radioButton52.Visible = false;
                radioButton53.Visible = false;
                radioButton54.Visible = false;
                radioButton55.Visible = false;
                radioButton56.Visible = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            double A;
            A = 1.00797;
            int B;
            B = 1;
            textBox4.Text = B.ToString();
            textBox1.Text = A.ToString();
            if (radioButton1.Checked == true)
            {
                label1.Text = "H";
                label1.Visible = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 3;
            textBox4.Text = B.ToString();
            double A;
            A = 6.939;
            textBox1.Text = A.ToString();
            if (radioButton2.Checked == true)
            {
                label1.Text = "Li";
                label1.Visible = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 11;
            textBox4.Text = B.ToString();
            double A;
            A = 22.9;
            textBox1.Text = A.ToString();
            if (radioButton3.Checked == true)
            {
                label1.Text = "Na";
                label1.Visible = true;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 19;
            textBox4.Text = B.ToString();
            double A;
            A = 39.102;
            textBox1.Text = A.ToString();
            if (radioButton4.Checked == true)
            {
                label1.Text = "K";
                label1.Visible = true;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 37;
            textBox4.Text = B.ToString();
            double A;
            A = 85.47;
            textBox1.Text = A.ToString();
            if (radioButton5.Checked == true)
            {
                label1.Text = "Rb";
                label1.Visible = true;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 55;
            textBox4.Text = B.ToString();
            double A;
            A = 132.905;
            textBox1.Text = A.ToString();
            if (radioButton6.Checked == true)
            {
                label1.Text = "Cs";
                label1.Visible = true;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 87;
            textBox4.Text = B.ToString();
            double A;
            A = 223;
            textBox1.Text = A.ToString();
            if (radioButton7.Checked == true)
            {
                label1.Text = "Fr";
                label1.Visible = true;
            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 4;
            textBox4.Text = B.ToString();
            double A;
            A = 9.0122;
            textBox1.Text = A.ToString();
            if (radioButton14.Checked == true)
            {
                label1.Text = "Be";
                label1.Visible = true;
            }
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 12;
            textBox4.Text = B.ToString();
            double A;
            A = 24.312;
            textBox1.Text = A.ToString();
            if (radioButton13.Checked == true)
            {
                label1.Text = "Mg";
                label1.Visible = true;
            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 20;
            textBox4.Text = B.ToString();
            double A;
            A = 40.08;
            textBox1.Text = A.ToString();
            if (radioButton12.Checked == true)
            {
                label1.Text = "Ca";
                label1.Visible = true;
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 38;
            textBox4.Text = B.ToString();
            double A;
            A = 87.62;
            textBox1.Text = A.ToString();
            if (radioButton11.Checked == true)
            {
                label1.Text = "Sr";
                label1.Visible = true;
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 56;
            textBox4.Text = B.ToString();
            double A;
            A = 137.34;
            textBox1.Text = A.ToString();
            if (radioButton10.Checked == true)
            {
                label1.Text = "Ba";
                label1.Visible = true;
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 88;
            textBox4.Text = B.ToString();
            double A;
            A = 226;
            textBox1.Text = A.ToString();
            if (radioButton9.Checked == true)
            {
                label1.Text = "Ra";
                label1.Visible = true;
            }
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 5;
            textBox4.Text = B.ToString();
            double A;
            A = 10.811;
            textBox1.Text = A.ToString();
            if (radioButton21.Checked == true)
            {
                label1.Text = "B";
                label1.Visible = true;
            }
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 13;
            textBox4.Text = B.ToString();
            double A;
            A = 26.9815;
            textBox1.Text = A.ToString();
            if (radioButton20.Checked == true)
            {
                label1.Text = "Al";
                label1.Visible = true;
            }
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 31;
            textBox4.Text = B.ToString();
            double A;
            A = 69.72;
            textBox1.Text = A.ToString();
            if (radioButton19.Checked == true)
            {
                label1.Text = "Ga";
                label1.Visible = true;
            }
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 49;
            textBox4.Text = B.ToString();
            double A;
            A = 114.82;
            textBox1.Text = A.ToString();
            if (radioButton18.Checked == true)
            {
                label1.Text = "In";
                label1.Visible = true;
            }
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 81;
            textBox4.Text = B.ToString();
            double A;
            A = 204.37;
            textBox1.Text = A.ToString();
            if (radioButton17.Checked == true)
            {
                label1.Text = "Ti";
                label1.Visible = true;
            }
        }

        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 6;
            textBox4.Text = B.ToString();
            double A;
            A = 12.011;
            textBox1.Text = A.ToString();
            if (radioButton28.Checked == true)
            {
                label1.Text = "C";
                label1.Visible = true;
            }
        }

        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 14;
            textBox4.Text = B.ToString();
            double A;
            A = 28.085;
            textBox1.Text = A.ToString();
            if (radioButton27.Checked == true)
            {
                label1.Text = "Si";
                label1.Visible = true;
            }
        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 32;
            textBox4.Text = B.ToString();
            double A;
            A = 72.59;
            textBox1.Text = A.ToString();
            if (radioButton26.Checked == true)
            {
                label1.Text = "Ge";
                label1.Visible = true;
            }
        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 50;
            textBox4.Text = B.ToString();
            double A;
            A = 118.69;
            textBox1.Text = A.ToString();
            if (radioButton25.Checked == true)
            {
                label1.Text = "Sn";
                label1.Visible = true;
            }
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 82;
            textBox4.Text = B.ToString();
            double A;
            A = 207.19;
            textBox1.Text = A.ToString();
            if (radioButton24.Checked == true)
            {
                label1.Text = "Pb";
                label1.Visible = true;
            }
        }

        private void radioButton42_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 8;
            textBox4.Text = B.ToString();
            double A;
            A = 15.99;
            textBox1.Text = A.ToString();
            if (radioButton42.Checked == true)
            {
                label1.Text = "O";
                label1.Visible = true;
            }
        }

        private void radioButton41_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 16;
            textBox4.Text = B.ToString();
            double A;
            A = 32.064;
            textBox1.Text = A.ToString();
            if (radioButton41.Checked == true)
            {
                label1.Text = "S";
                label1.Visible = true;
            }
        }

        private void radioButton40_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 34;
            textBox4.Text = B.ToString();
            double A;
            A = 28.96;
            textBox1.Text = A.ToString();
            if (radioButton40.Checked == true)
            {
                label1.Text = "Se";
                label1.Visible = true;
            }
        }

        private void radioButton39_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 52;
            textBox4.Text = B.ToString();
            double A;
            A = 127.60;
            textBox1.Text = A.ToString();
            if (radioButton39.Checked == true)
            {
                label1.Text = "Te";
                label1.Visible = true;
            }
        }

        private void radioButton38_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 84;
            textBox4.Text = B.ToString();
            double A;
            A = 210;
            textBox1.Text = A.ToString();
            if (radioButton38.Checked == true)
            {
                label1.Text = "Po";
                label1.Visible = true;
            }
        }

        private void radioButton49_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 9;
            textBox4.Text = B.ToString();
            double A;
            A = 18.9084;
            textBox1.Text = A.ToString();
            if (radioButton49.Checked == true)
            {
                label1.Text = "F";
                label1.Visible = true;
            }
        }

        private void radioButton48_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 17;
            textBox4.Text = B.ToString();
            double A;
            A = 35.453;
            textBox1.Text = A.ToString();
            if (radioButton48.Checked == true)
            {
                label1.Text = "Cl";
                label1.Visible = true;
            }
        }

        private void radioButton47_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 35;
            textBox4.Text = B.ToString();
            double A;
            A = 79.909;
            textBox1.Text = A.ToString();
            if (radioButton47.Checked == true)
            {
                label1.Text = "Br";
                label1.Visible = true;
            }
        }

        private void radioButton46_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 53;
            textBox4.Text = B.ToString();
            double A;
            A = 126.904;
            textBox1.Text = A.ToString();
            if (radioButton46.Checked == true)
            {
                label1.Text = "I";
                label1.Visible = true;
            }
        }

        private void radioButton45_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 85;
            textBox4.Text = B.ToString();
            double A;
            A = 210;
            textBox1.Text = A.ToString();
            if (radioButton45.Checked == true)
            {
                label1.Text = "At";
                label1.Visible = true;
            }
        }

        private void radioButton56_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 2;
            textBox4.Text = B.ToString();
            double A;
            A = 4.0026;
            textBox1.Text = A.ToString();
            if (radioButton56.Checked == true)
            {
                label1.Text = "He";
                label1.Visible = true;
            }
        }

        private void radioButton55_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 10;
            textBox4.Text = B.ToString();
            double A;
            A = 20.183;
            textBox1.Text = A.ToString();
            if (radioButton55.Checked == true)
            {
                label1.Text = "Ne";
                label1.Visible = true;
            }
        }

        private void radioButton54_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 18;
            textBox4.Text = B.ToString();
            double A;
            A = 39.948;
            textBox1.Text = A.ToString();
            if (radioButton54.Checked == true)
            {
                label1.Text = "Ar";
                label1.Visible = true;
            }
        }

        private void radioButton53_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 36;
            textBox4.Text = B.ToString();
            double A;
            A = 83.80;
            textBox1.Text = A.ToString();
            if (radioButton53.Checked == true)
            {
                label1.Text = "Kr";
                label1.Visible = true;
            }
        }

        private void radioButton52_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 54;
            textBox4.Text = B.ToString();
            double A;
            A = 131.30;
            textBox1.Text = A.ToString();
            if (radioButton52.Checked == true)
            {
                label1.Text = "Xe";
                label1.Visible = true;
            }
        }

        private void radioButton51_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 86;
            textBox4.Text = B.ToString();
            double A;
            A = 222;
            textBox1.Text = A.ToString();
            if (radioButton51.Checked == true)
            {
                label1.Text = "Rn";
                label1.Visible = true;
            }
        }

        private void radioButton35_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 7;
            textBox4.Text = B.ToString();
            double A;
            A = 14.006;
            textBox1.Text = A.ToString();
            if (radioButton35.Checked == true)
            {
                label1.Text = "N";
                label1.Visible = true;
            }
        }

        private void radioButton34_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 15;
            textBox4.Text = B.ToString();
            double A;
            A = 30.973;
            textBox1.Text = A.ToString();
            if (radioButton34.Checked == true)
            {
                label1.Text = "P";
                label1.Visible = true;
            }
        }

        private void radioButton33_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 33;
            textBox4.Text = B.ToString();
            double A;
            A = 74.922;
            textBox1.Text = A.ToString();
            if (radioButton33.Checked == true)
            {
                label1.Text = "As";
                label1.Visible = true;
            }
        }

        private void radioButton32_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 51;
            textBox4.Text = B.ToString();
            double A;
            A = 121.75;
            textBox1.Text = A.ToString();
            if (radioButton32.Checked == true)
            {
                label1.Text = "Sb";
                label1.Visible = true;
            }
        }

        private void radioButton31_CheckedChanged(object sender, EventArgs e)
        {
            int B;
            B = 83;
            textBox4.Text = B.ToString();
            double A;
            A = 208.980;
            textBox1.Text = A.ToString();
            if (radioButton31.Checked == true)
            {
                label1.Text = "Bi";
                label1.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to exit from this program?","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
            else
                if(result == DialogResult.No)
                {

                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float A, B, C;
            A = float.Parse(textBox1.Text);
            B = float.Parse(textBox2.Text);
            C = B / A;
            textBox3.Text = C.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void golonganIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
                checkBox1.Checked = true;
            else
                checkBox1.Checked = false;
        }

        private void golonganIIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
                checkBox2.Checked = true;
            else
                checkBox2.Checked = false;
        }

        private void golonganIIIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked == false)
                checkBox3.Checked = true;
            else
                checkBox3.Checked = false;
        }

        private void golonganIVAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked == false)
                checkBox4.Checked = true;
            else
                checkBox4.Checked = false;
        }

        private void golonganVAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkBox5.Checked == false)
                checkBox5.Checked = true;
            else
                checkBox5.Checked = false;
        }

        private void golonganVIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkBox6.Checked == false)
                checkBox6.Checked = true;
            else
                checkBox6.Checked = false;
        }

        private void golonganVIIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkBox7.Checked == false)
                checkBox7.Checked = true;
            else
                checkBox7.Checked = false;
        }

        private void golonganVIIIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkBox8.Checked == false)
                checkBox8.Checked = true;
            else
                checkBox8.Checked = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to exit from this program?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
                if (result == DialogResult.No)
                {

                }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program ini dibuat oleh Haenuki Sachi", "Infromasi Program", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Centang golongan dan atom yang kalian inginkan, kemudian masukkan massa untuk menghitung mol.", "Petunjuk Penggunaan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
