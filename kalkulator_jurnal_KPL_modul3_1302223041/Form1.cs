using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator_jurnal_KPL_modul3_1302223041
{
    
    public partial class Form1 : Form
    {
        int penyimpanAngka = 0, jumlah = 0;
        bool digitDuaAngka = false;
        string operasi = "", hasil = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (!digitDuaAngka)
                {
                    penyimpanAngka += 1;
                    digitDuaAngka = true;
                }
                else
                {
                    penyimpanAngka = (penyimpanAngka * 10) + 1;
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                if (!digitDuaAngka)
                {
                    penyimpanAngka += 2;
                    digitDuaAngka = true;
                }
                else
                {
                    penyimpanAngka = (penyimpanAngka * 10) + 2;
                }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                if (!digitDuaAngka)
                {
                    penyimpanAngka += 3;
                    digitDuaAngka = true;
                }
                else
                {
                    penyimpanAngka = (penyimpanAngka * 10) + 3;
                }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                if (!digitDuaAngka)
                {
                    penyimpanAngka += 4;
                    digitDuaAngka = true;
                }
                else
                {
                    penyimpanAngka = (penyimpanAngka * 10) + 4;
                }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
                if (!digitDuaAngka)
                {
                    penyimpanAngka += 5;
                    digitDuaAngka = true;
                }
                else
                {
                    penyimpanAngka = (penyimpanAngka * 10) + 5;
                }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
                if (!digitDuaAngka)
                {
                    penyimpanAngka += 6;
                    digitDuaAngka = true;
                }
                else
                {
                    penyimpanAngka = (penyimpanAngka * 10) + 6;
                }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
                if (!digitDuaAngka)
                {
                    penyimpanAngka += 7;
                    digitDuaAngka = true;
                }
                else
                {
                    penyimpanAngka = (penyimpanAngka * 10) + 7;
                }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
                if (!digitDuaAngka)
                {
                    penyimpanAngka += 8;
                    digitDuaAngka = true;
                }
                else
                {
                    penyimpanAngka = (penyimpanAngka * 10) + 8;
                }
           
        }

        

        private void button9_Click(object sender, EventArgs e)
        {
            
                if (!digitDuaAngka)
                {
                    penyimpanAngka += 9;
                    digitDuaAngka = true;
                }
                else
                {
                    penyimpanAngka = (penyimpanAngka * 10) + 9;
                }
            
        }

        private void button0_Click(object sender, EventArgs e)
        {
            
                if (!digitDuaAngka)
                {
                    penyimpanAngka += 0;
                    digitDuaAngka = true;
                }
                else
                {
                    penyimpanAngka = (penyimpanAngka * 10) + 0;
                }
            
        }

        private void buttonSamaDengan_Click(object sender, EventArgs e)
        {
            jumlah += penyimpanAngka;
            operasi += penyimpanAngka;
            label2.Text = operasi;
            hasil += "Hasilnya adalah " + jumlah;
            label1.Text = hasil;
            jumlah = 0;
            penyimpanAngka = 0;
            digitDuaAngka = false;
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            jumlah += penyimpanAngka;
            operasi += penyimpanAngka + " + ";
            label2.Text = operasi;
            penyimpanAngka = 0;
            digitDuaAngka = false;

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
