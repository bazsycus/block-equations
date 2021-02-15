using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_Tombmuveletek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] iaTomb;
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            iaTomb = new int[10];
            textBox1.Clear();
            for (int i = 0; i < 10; i++)
            {
                iaTomb[i] = rnd.Next(1, 20);
                textBox1.Text += iaTomb[i].ToString() + "\r\n";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int iParos = 0;
            int iTobbszoros = 0;
            int iVeletlen = rnd.Next(1, 10);
            foreach (int iAkt in iaTomb)
            {
                if (iAkt%2==0)//ha az aktuális elem páros
                {
                    iParos++;
                }
                if (iAkt%iVeletlen==0)
                {
                    iTobbszoros++;
                }
            }
            label1.Text = iParos.ToString();
            label2.Text = "A véletlenszám: " + iVeletlen.ToString();
            label3.Text = iTobbszoros.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int iMax = iaTomb[0]; //referencia elem
            int iMin = iaTomb[0];
            for (int i = 0; i < iaTomb.Length; i++)
            {
                if (iaTomb[i]>iMax)
                {
                    iMax = iaTomb[i];
                }
                if (iaTomb[i]<iMin)
                {
                    iMin = iaTomb[i];
                }
            }

            label1.Text = "MAx: " + iMax.ToString();
            label2.Text = "min: " + iMin.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {//25% pontsázmú buborék
            for (int i = 0; i < iaTomb.Length-1; i++)
            {//minden futásnál 1 elem a helyére kerül
                for (int j = 0; j < iaTomb.Length-1; j++)
                {//az utolsó elemet nem tudjuk az utána levővel összevetni
                    //csere kérdését eldönteni
                    if (iaTomb[j]>iaTomb[j+1])//kisebb index nagyobb, mint a nagyobb index
                    {//akkor csere
                        int iTmp = iaTomb[j];
                        iaTomb[j] = iaTomb[j + 1];
                        iaTomb[j + 1] = iTmp;
                    }
                } //belső ciklus vége
            }//külső ciklus vége

            textBox1.Clear();
            foreach (int iAkt in iaTomb)
            {
                textBox1.Text += iAkt.ToString() + "\r\n";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {//50%-os zöldülő megoldás
            int iBelsoMeddig = iaTomb.Length - 1;
            for (int i = 0; i < iaTomb.Length - 1; i++)
            {//minden futásnál 1 elem a helyére kerül
                for (int j = 0; j < iBelsoMeddig; j++)
                {//az utolsó elemet nem tudjuk az utána levővel összevetni
                    //csere kérdését eldönteni
                    if (iaTomb[j] > iaTomb[j + 1])//kisebb index nagyobb, mint a nagyobb index
                    {//akkor csere
                        int iTmp = iaTomb[j];
                        iaTomb[j] = iaTomb[j + 1];
                        iaTomb[j + 1] = iTmp;
                    }
                } //belső ciklus vége
                iBelsoMeddig--;
            }//külső ciklus vége

            textBox1.Clear();
            foreach (int iAkt in iaTomb)
            {
                textBox1.Text += iAkt.ToString() + "\r\n";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {//100%-os megoldás
            int iBelsoMeddig = iaTomb.Length - 1;
            bool bCsere = true;
            //int iCsere = 1231231;
            while (bCsere)
            //While (iCsere>0)
            {//minden futásnál 1 elem a helyére kerül
                //iCsere=0;
                bCsere = false;
                for (int j = 0; j < iBelsoMeddig; j++)
                {//az utolsó elemet nem tudjuk az utána levővel összevetni
                    //csere kérdését eldönteni
                    if (iaTomb[j] > iaTomb[j + 1])//kisebb index nagyobb, mint a nagyobb index
                    {//akkor csere
                        int iTmp = iaTomb[j];
                        iaTomb[j] = iaTomb[j + 1];
                        iaTomb[j + 1] = iTmp;
                        bCsere = true;
                        //iCsere++;
                    }
                } //belső ciklus vége
                iBelsoMeddig--;
            }//külső ciklus vége

            textBox1.Clear();
            foreach (int iAkt in iaTomb)
            {
                textBox1.Text += iAkt.ToString() + "\r\n";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
