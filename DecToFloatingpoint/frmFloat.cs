using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Gemaakt door Conrad Van Vugt
//Klassen in ClassLibraryConradVanVugt.cs

namespace DecToFloatingpoint
{
    public partial class frmFloat : Form
    {
        public frmFloat()
        {
            InitializeComponent();
        }
        //variablen declareren
        #region variablen
        private String input;
        private String[] inputsplit;
        string output, outputvoork, outputnak;
        private string notatie;
        private int opschuiving;
        private string sign, exponent, fractie;
        #endregion

        #region keypresses
        //tegenhouden dat een gebruiker alles kan ingeven
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
        //tegenhouden dat een gebruiker alles kan ingeven
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
        //tegenhouden dat een gebruiker alles kan ingeven
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

        #endregion

        #region knoppen
        private void btnFloat_Click(object sender, EventArgs e)
        {
            //variablen declareren
            decimaalnaarfloat d2f = new decimaalnaarfloat();
            inputsplit = new String[1];
            input = txtInput.Text;

            //Voor klassen zie ClassLibraryConradVanVugt.cs

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
            
            //wegschrijven in textboxen
            txtSignOut.Text = sign;
            txtExpOut.Text = exponent;
            txtFractieOut.Text = fractie;
            
        }

        private void btnbinair_Click(object sender, EventArgs e)
        {
            //Variablen aanmaken
            string[] arromzet = new String[1];
            double dblDecOut;
            floatnaardecimaal omzetdec = new floatnaardecimaal();

            //Voor klassen zie ClassLibraryConradVanVugt.cs


            //Punt opschuiven en opslitsen in twee delen
            arromzet = omzetdec.puntopschuiven(txtExpIn.Text, txtFractieIn.Text).Split('.');
            
            //Deel voor de komma omzetten naar een getal en optellen bij het deel na de komma omgezet in een getal
            dblDecOut = omzetdec.voorkomma(arromzet[0]) + omzetdec.nakomma(arromzet[1]);

            //Het teken bepalen
            dblDecOut = omzetdec.Sign(txtSignIn.Text, dblDecOut);

            //Wegschrijven naar tekstbox
            txtGetalOut.Text = dblDecOut.ToString();
        }
        #endregion

    }
}



    


