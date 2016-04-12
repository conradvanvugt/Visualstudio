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
        //variablen declareren
        private String input;
        private String[] inputsplit;
        string output, outputvoork, outputnak;
        private string notatie;
        private int opschuiving;
        private string sign, exponent, fractie;

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '1' || e.KeyChar == '2' || e.KeyChar == '3' || e.KeyChar == '4'
                || e.KeyChar == '5' || e.KeyChar == '6' || e.KeyChar == '7' || e.KeyChar == '8'
                || e.KeyChar == '9' || e.KeyChar == '0' || e.KeyChar == (char)8 ||  e.KeyChar == ',')
            {
                if (txtInput.Text.Contains(',') && e.KeyChar == ',')
                {
                    e.Handled = true;
                }
                else {
                    e.Handled = false;
                }
            }
            else {
                e.Handled = true;
            }
        }

        private void txtFractieIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '1' || e.KeyChar == '0' || e.KeyChar == (char)8)
            {

                if (txtFractieIn.Text.Length >= 26 && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                }
                else {
                    e.Handled = false;
                }
            }
            else {
                e.Handled = true;
            }
        }

        private void txtExpIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '1' || e.KeyChar == '0' || e.KeyChar == (char)8)
            {
                if (txtExpIn.Text.Length >= 8 && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                }
                else {
                    e.Handled = false;
                }
            }
            else {
                e.Handled = true;
            }
        }

        private void txtSignIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '1' || e.KeyChar == '0' || e.KeyChar == (char)8)
            {
                if (txtSignIn.Text.Length >= 1 && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                }
                else {
                    e.Handled = false;
                }
            }
            else {
                e.Handled = true;
            }
        }


        private void btnFloat_Click(object sender, EventArgs e)
        {
            decnaarfloat d2f = new decnaarfloat();
            inputsplit = new String[1];
            input = txtInput.Text;
            //opsplitsen deel voor de komma en na de komma
            inputsplit = input.Split(',');
            //converteren deel voor de komma naar binair
            outputvoork = d2f.ConvertVoorKomma(inputsplit[0]);
            //converteren van decimaal deel naar binair
            outputnak = d2f.ConvertNaKomma(inputsplit[1], outputvoork);
            //output samen nemen
            output = outputvoork + "." + outputnak;
            //komma verplaatsen, return waarde zijn de nieuwe notatie en hoeveel plaatsen de komma is opgeschoven
            d2f.Normaliseer(output, out notatie, out opschuiving);
            //volledige float maken met alle vorige inforamtie
            d2f.MaakFloat(input, notatie, opschuiving, out sign, out exponent, out fractie);
            //wegschrijven in label
            txtSignOut.Text = sign;
            txtExpOut.Text = exponent;
            txtFractieOut.Text = fractie;
            
        }

        private void btnbinair_Click(object sender, EventArgs e)
        {
            string[] arromzet = new String[1];
            double dblDecOut;
            floatnaardec omzetdec = new floatnaardec();
            arromzet = omzetdec.puntopschuiven(txtExpIn.Text, txtFractieIn.Text).Split('.');
            dblDecOut = omzetdec.voorkomma(arromzet[0]) + omzetdec.nakomma(arromzet[1]);
            dblDecOut = omzetdec.Sign(txtSignIn.Text, dblDecOut);
            txtGetalOut.Text = dblDecOut.ToString();
        }

        //klasse die decimaal naar float omzet
        private class decnaarfloat
        {
            public string ConvertVoorKomma(string voorkomma)
            {
                //variablen declareren
                int voork = 0;
                string binair = "";
                //Test of deel voor de komma omgezet kan worden
                if (int.TryParse(voorkomma, out voork))
                {
                    //absolute waarde nemen
                    voork = Math.Abs(voork);
                    //blijven loopen tot dat voork onder nul is

                    while (voork >= 1)
                    {
                        //als de restdelling van voork niet 1 is een nul bij binair plaatsen
                        if (voork % 2 != 1)
                        {
                            binair += "0";
                        }
                        //anders een 1 bij plaatsen
                        else
                        {
                            binair += "1";
                        }
                        //voork 2 door twee delen
                        voork = voork / 2;
                    }
                    //string omdraaien als binair niet leeg is
                    if (binair != "")
                    {
                        char[] arr = binair.ToCharArray();
                        Array.Reverse(arr);
                        binair = new string(arr);
                    }
                    //als het wel leeg is gewoon nul invullen
                    else {
                        binair = "0";
                    }
                }

                //binair getal teruggeven
                return binair;

            }
            //Deze methode zal het deel na de komma converteren naar decimaal
            public string ConvertNaKomma(string decdeel, string binvoork)
            {
                //0, voor het deciaam deel toevoegen
                decdeel = "0," + decdeel;
                //Variabelen declareren
                string binair = "";
                Boolean stopwhile = false;
                decimal dec = 0;

                //Kijk of het deel na de komma omgezet kan worden
                if (decimal.TryParse(decdeel, out dec))
                {
                    //Het  getal maal 2 blijven doen tot de rest exact 1 is
                    while (stopwhile == false)
                    {
                        //Als het getal maal 2 groter of gelijk is aan 1 kijken of het 1 is of groter als 1
                        if (dec * 2 >= 1)
                        {
                            dec = dec * 2;
                            //Als het getal exact 1 is een 1 toevoegen aan binaire notatie en met de loop stoppen
                            if (dec == 1)
                            {
                                binair += "1";
                                stopwhile = true;
                            }
                            //Anders een 1 toevoegen aan binaire notatie en 1 van het getal aftrekken
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
                        //oneindige loop voorkomen
                        if (binair.Length == 28 - 1 - binvoork.Length)
                        {
                            stopwhile = true;

                        }
                    }

                }
                return binair;
            }


            //Deze methode zal de komma na de eerste 1 verplaatsen
            public void Normaliseer(string binair, out string binairreturn, out int opschuiving)
            {
                //Variablen declareren
                int PlaatsKomma;
                int PlaatsEerstEen;
                //Bepaal waar de punt staat
                PlaatsKomma = binair.IndexOf('.');
                //Verwijder komma
                binair = binair.Replace(".", "");
                //Bepaal waar de eerst 1 staat
                PlaatsEerstEen = binair.IndexOf('1');
                //Kijk hoeveel plaatsen er tussen de komma en de een staan
                opschuiving = PlaatsKomma + PlaatsEerstEen - 1;
                //Verplaats komma na de eerste 1
                binairreturn = binair.Substring(PlaatsEerstEen, 1) + "." + binair.Substring(PlaatsEerstEen + 1, binair.Length - PlaatsEerstEen - 1);
            }
            //deze methode maakt van al de waarden die we hebben het getal in single-precision floating-point notatie
            public void MaakFloat(string input, string genormaliseerd, int opschuiving, out string sign, out string exponent, out string fractie)
            {
                //Variablen declareren
                int OmzettenNaarDec;
                //Input voor de zekerheid naar juiste formaat omzetten door . een , te maken
                input = input.Replace(".", ",");
                //Kijken of het getal positief is of niet zowel wordt sign 1
                if (decimal.Parse(input) < 0)
                {
                    sign = "1";
                }
                //Anders wordt sign 0
                else {
                    sign = "0";
                }
                //Getal dat om te zetten is naar deciaal bepalen
                OmzettenNaarDec = opschuiving + 127;
                //Omzetten naar deciaal en in exponent plaatsen
                exponent = ConvertVoorKomma(OmzettenNaarDec.ToString());
                //Aanvullen tot we 8 karakters hebben
                exponent = exponent.PadLeft(8, '0');
                //Substring van het genormaliseerde waarde nemen en het eerste getal + punt laten vallen de rest nemen
                fractie = genormaliseerd.Substring(2, genormaliseerd.Length - 2);
                //Aanvullen tot we 23 karakters hebben
                fractie = fractie.PadRight(23, '0');
            }
        }

        //klasse die float naar decimaal omzet
        private class floatnaardec
        {
            public String puntopschuiven(String exponent, String fractie)
            {
                int expo;
                int exponentdec = 0;
                int opschuiving;
                for (int i = exponent.Length; i > 0; i--)
                {
                    expo = int.Parse(exponent.Substring(i - 1, 1));
                    exponentdec += Convert.ToInt32(expo * (Math.Pow(2.0, Convert.ToDouble(exponent.Length - i))));
                }
                opschuiving = exponentdec - 127;
                fractie = "1" + fractie;
                fractie = fractie.Substring(0, opschuiving + 1) + "." + fractie.Substring(opschuiving + 1, fractie.Length - opschuiving - 1);

                fractie = fractie.TrimEnd('0');
                return fractie;

            }
            public double voorkomma(String voorkomma)
            {

                int voork;
                double voorkommadec = 0;
                for (int i = voorkomma.Length; i > 0; i--)
                {
                    voork = int.Parse(voorkomma.Substring(i - 1, 1));
                    voorkommadec += Convert.ToInt32(voork * (Math.Pow(2.0, Convert.ToDouble(voorkomma.Length - i))));
                }
                return voorkommadec;
            }
            public double nakomma(String nakomma)
            {
                double getal= 0.0; 
                for (int i = nakomma.Length - 1; i > 0; i--)
                {
                    if( int.Parse(nakomma.Substring(i, 1)) == 1)
                    {
                       getal += Math.Pow(i + 1.0, -2.0);
                    }
                }
                return getal;
            }
            public double Sign(String sign, Double DecOut)
            {
                if(sign == "1")
                {
                    DecOut = 0 - DecOut;

                }
                return DecOut;
            }
        }
    }
}



    


