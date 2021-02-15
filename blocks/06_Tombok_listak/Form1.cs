using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_Tombok_listak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //deklaráció

        //típus[] tömbnév = new tíipus[elemszám];
        //0->elemszám-1 lesz az index magyarul név[0] és név[elemszám-1]
        //int[] iaNyitotomb = new int[10]; egysoros
        int[] iaNyitotomb;

        //List<típus> név = new List<típus>();
        List<int> ilNyitolista;

        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            iaNyitotomb = new int[10];//két soros deklaráció
            //ezen a ponton a tömb 10 elemű
            for (int i = 0; i < 10; i++)
            {
                iaNyitotomb[i] = rnd.Next(1, 101);
            }
            
            ilNyitolista = new List<int>(); //lista elemszáma 0
            for (int i = 0; i < 10; i++)
            {
                ilNyitolista.Add(rnd.Next(1,101));
            }
            //lista már 10 elemű
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int iTombelemszam = iaNyitotomb.Length; //ez mindig a deklarált hossz
            int iListaelemszam = ilNyitolista.Count; //lista valós elemszáma
            //1. elem nev[0], 
            //5. elem nev[4]
            //n. elem nev[n-1]
            //utolsó nev[elemszam-1]
            
            label1.Text = iaNyitotomb[rnd.Next(0,iTombelemszam)].ToString();
            label2.Text = ilNyitolista[rnd.Next(0, iListaelemszam)].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); //.Text="";

            /*for (int i = 0; i < iaNyitotomb.Length; i++)
            {
                textBox1.Text += iaNyitotomb[i].ToString() + "\r\n";
            }*/
            foreach (int iAktualis in iaNyitotomb)
            {//      ebbe a változóba ezt a listát/tömböt rakja bele egyesével
                //iAktualis az minden iterációban a következő elem
                textBox1.Text += iAktualis.ToString() + "\r\n";
            }
            textBox1.Text += "----------" + "\r\n";
            foreach (int iAktualislistaelem in ilNyitolista)
            {
                textBox1.Text += iAktualislistaelem.ToString() + "\r\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ilNyitolista.Add(rnd.Next(1, 101));//lista bővítés

            int[] iaTmp = new int[iaNyitotomb.Length];
            for (int i = 0; i < iaNyitotomb.Length; i++)
            {
                iaTmp[i] = iaNyitotomb[i];
            }
            iaNyitotomb = new int[iaNyitotomb.Length + 1];
            for (int i = 0; i < iaTmp.Length; i++)
            {
                iaNyitotomb[i] = iaTmp[i];
            }
            iaNyitotomb[iaNyitotomb.Length-1] = rnd.Next(1, 101);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ilNyitolista.Insert(5, rnd.Next(1, 101));
            int[] iaTmp = new int[iaNyitotomb.Length];
            for (int i = 0; i < iaNyitotomb.Length; i++)
            {
                iaTmp[i] = iaNyitotomb[i];
            }
            iaNyitotomb = new int[iaNyitotomb.Length + 1];
            for (int i = 0; i < 5; i++)
            {
                iaNyitotomb[i] = iaTmp[i];
            }
            iaNyitotomb[5] = rnd.Next(1, 101);
            for (int i = 5; i < iaTmp.Length; i++)
            {
                iaNyitotomb[i+1] = iaTmp[i];
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ilNyitolista.RemoveAt(5);
            int[] iaTmp = new int[iaNyitotomb.Length];
            for (int i = 0; i < iaNyitotomb.Length; i++)
            {
                iaTmp[i] = iaNyitotomb[i];
            }
            iaNyitotomb = new int[iaNyitotomb.Length-1];
            for (int i = 0; i < 5; i++)
            {
                iaNyitotomb[i] = iaTmp[i];
            }
            
            for (int i = 6; i < iaTmp.Length; i++)
            {
                iaNyitotomb[i-1] = iaTmp[i];
            }

            List<int> ilTmp = new List<int>();
            ilTmp = iaNyitotomb.ToList();
            ilTmp.Add(0);
            iaNyitotomb = ilTmp.ToArray();
        }
    }
}
