using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecToFloatingpoint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private String input;
        private String[] inputsplit;
        string notatie;
        private void button1_Click(object sender, EventArgs e)
        {
            notatie = "";
            inputsplit = new String[1];
            input = textBox1.Text;
            //opsplitsen deel voor de komma en na de komma
            inputsplit = input.Split('.', ',');
            //converteren deel voor de komma naar binair
            notatie += IntToBin(inputsplit[0]);
            notatie += ".";
            //converteren van decimaal deel naar binair
            notatie += Converting(inputsplit[1]);
            label1.Text = notatie;

        }
        private string IntToBin(string voorkomma) {
            //variablen declareren
            int voork = 0;
            string binair = "";
            //Test of deel voor de komma omgezet kan worden
            if (int.TryParse(voorkomma,out voork)) {
                //blijven loopen tot dat voork onder nul is
                while(voork >= 1)
                {
                    //als de restdelling van voork niet 1 is
                    if(voork%2 != 1)
                    {
                        binair += "0";
                    }
                    else
                    {
                        binair += "1";
                    }
                    voork = voork / 2;
                }
                
            }
            //string omdraaien
            char[] arr = binair.ToCharArray();
            Array.Reverse(arr);
            binair = new string(arr);

            MessageBox.Show(binair);
            //binair getal teruggeven
            return binair;

        }
        private string Converting(string decdeel)
        {
            //0, voor het deciaam deel toevoegen
            decdeel = "0," + decdeel;
            //variabelen declareren
            string binair = "";
            Boolean stopwhile = false;
            decimal dec = 0;
            //kijk of het deel na de komma omgezet kan worden
            if(decimal.TryParse(decdeel, out dec))
            {
                //het  getal maal 2 blijven doen tot de rest exact 1 is
                while (stopwhile == false) {
                    //als het getal maal 2 groter of gelijk is aan 1 kijken of het 1 is of groter als 1
                    if (dec * 2 >= 1)
                    {
                        dec = dec * 2;
                        //Als het getal exact 1 is een 1 toevoegen aan binaire notatie en met de loop stoppen
                        if (dec == 1)
                        {
                            binair += "1";
                            stopwhile = true;
                        }
                        //anders een 1 toevoegen aan binaire notatie en 1 van het getal aftrekken
                        else {
                            binair += "1";
                            dec = dec - 1;
                        }
                    }
                    //Als het niet groter is als 1 een 0 toevoegen aan binaire notatie
                    else {
                        dec = dec * 2;
                        binair += "0";

                    }
                }

            }
            MessageBox.Show(binair);
            return binair;
        }
        private void verplaatskomma(string binair) {

        }
    }
}
