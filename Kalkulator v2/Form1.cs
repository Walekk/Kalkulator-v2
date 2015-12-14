using System;
using System.Windows.Forms;

namespace Kalkulator_v2
{
    public partial class Form1 : Form
    {
        private bool zachowaj;
        string Dodawanie(double liczba1, double liczba2)
        {
            string wynik;
            try
            {

                wynik = (liczba1 + liczba2).ToString();
            }
            catch (NotFiniteNumberException)
            {
                zachowaj = false;
                buttonOblicz.Enabled = false;
                return "Podane liczby nie sa obslugiwane";
            }
            catch (OverflowException)
            {
                zachowaj = false;
                buttonOblicz.Enabled = false;
                return "Podane liczby są za duże, bądz za małe.";
            }
            catch (Exception)
            {
                zachowaj = false;
                buttonOblicz.Enabled = false;
                return "Wystapil nieoczekiwany blad";
            }
            zachowaj = true;
            return wynik;
        }
        string Odejmowanie(double liczba1, double liczba2)
        {
            string wynik;
            try
            {
                wynik = (liczba1 - liczba2).ToString();
            }
            catch (NotFiniteNumberException)
            {
                zachowaj = false;
                buttonOblicz.Enabled = false;
                return "Podane liczby nie sa obslugiwane";
            }
            catch (OverflowException)
            {
                zachowaj = false;
                buttonOblicz.Enabled = false;
                return "Podane liczby są za duże, bądz za małe.";
            }
            catch (Exception)
            {
                zachowaj = false;
                buttonOblicz.Enabled = false;
                return "Wystapil nieoczekiwany blad";
            }
            zachowaj = true;
            return wynik;
        }
        string Mnozenie(double liczba1, double liczba2)
        {
            string wynik;
            try
            {
                wynik = (liczba1 * liczba2).ToString();
            }
            catch (NotFiniteNumberException)
            {
                zachowaj = false;
                buttonOblicz.Enabled = false;
                return "Podane liczby nie sa obslugiwane";
            }
            catch (OverflowException)
            {
                zachowaj = false;
                buttonOblicz.Enabled = false;
                return "Podane liczby są za duże, bądz za małe.";
            }
            catch (Exception)
            {
                zachowaj = false;
                buttonOblicz.Enabled = false;
                return "Wystapil nieoczekiwany blad";
            }
            zachowaj = true;
            return wynik;
        }
        string Dzielenie(double liczba1, double liczba2)
        {
            string wynik;
            if (liczba2 == 0)
            {
                zachowaj = false;
                komunikatLiczba2.Text = "Bledna wartosc";
                return "Nie mozna dzielic przez 0";
            }
            try
            {
                wynik = (liczba1 / liczba2).ToString();
            }
            catch (DivideByZeroException)
            {
                zachowaj = false;
                buttonOblicz.Enabled = false;
                return "Nie mozna dzielic przez 0";
            }
            catch (NotFiniteNumberException)
            {
                zachowaj = false;
                buttonOblicz.Enabled = false;
                return "Podane liczby nie sa obslugiwane";
            }
            catch (OverflowException)
            {
                zachowaj = false;
                buttonOblicz.Enabled = false;
                return "Podane liczby są za duże, bądz za małe.";
            }
            catch (Exception)
            {
                zachowaj = false;
                buttonOblicz.Enabled = false;
                return "Wystapil nieoczekiwany blad";
            }
            zachowaj = true;
            return wynik;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            textBoxLIczba1.Focus();
            buttonKasujHistorieOperacji.Enabled = false;
            buttonZapiszJakoLiczba1.Enabled = false;
            buttonZapiszJakoLIczba2.Enabled = false;
            contextMenuStripHistoriaOperacji.Enabled = false;
            buttonOblicz.Enabled = false;
        }

        private void buttonOblicz_Click(object sender, EventArgs e)
        {
            double liczba1, liczba2;
            if (!double.TryParse(textBoxLIczba1.Text, out liczba1))
            {
                komunikatLiczba1.Text = "Błedna wartośc liczby 1";
                buttonOblicz.Enabled = false;
            }
            else komunikatLiczba1.Text = "";

            if (!double.TryParse(textBoxLiczba2.Text, out liczba2))
            {
                komunikatLiczba2.Text = "Błedna wartośc liczby 2";
                buttonOblicz.Enabled = false;
            }
            else komunikatLiczba2.Text = "";

            if (radioButtonDodawanie.Checked) richTextBoxWynik.Text = Dodawanie(liczba1, liczba2);
            else if (radioButtonOdejmowanie.Checked) richTextBoxWynik.Text = Odejmowanie(liczba1, liczba2);
            else if (radioButtonMnozenie.Checked) richTextBoxWynik.Text = Mnozenie(liczba1, liczba2);
            else if (radioButtonDzielenie.Checked) richTextBoxWynik.Text = Dzielenie(liczba1, liczba2);

        }
        private void textBoxLIczba1_TextChanged(object sender, EventArgs e)
        {
            buttonOblicz.Enabled = true;
            komunikatLiczba1.Text = "";
            #region Usuwanie znaków
            bool TempChanged = false, PrzecinekFlaga = true;
            string TempText = textBoxLIczba1.Text;
            for (int i = 0; i < TempText.Length; i++)
            {
                if (char.IsDigit(TempText[i])) continue;
                if (TempText[i] == ',')
                {
                    if (PrzecinekFlaga)
                    {
                        PrzecinekFlaga = false;
                        continue;
                    }
                    else
                    {
                        TempChanged = true;
                        TempText = TempText.Remove(i, 1);
                        continue;
                    }
                }
                if (TempText[i] == '-')
                {
                    if (i == 0) continue;
                    else TempText = TempText.Remove(i, 1);
                }
                TempChanged = true;
                TempText = TempText.Remove(i, 1);
            }
            if (TempChanged) textBoxLIczba1.Text = TempText;
            #endregion
        }
        private void textBoxLIczba1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.') e.KeyChar = ',';
            if ((char.IsDigit(e.KeyChar) == false) && (e.KeyChar != '-') && (e.KeyChar != ',') && (e.KeyChar != '\b')) e.Handled = true;
        }
        private void textBoxLiczba2_TextChanged(object sender, EventArgs e)
        {
            buttonOblicz.Enabled = true;
            komunikatLiczba2.Text = "";
            #region Usuwanie znaków
            bool TempChanged = false, PrzecinekFlaga = true;
            string TempText = textBoxLiczba2.Text;
            for (int i = 0; i < TempText.Length; i++)
            {
                if (char.IsDigit(TempText[i])) continue;
                if (TempText[i] == ',')
                {
                    if (PrzecinekFlaga)
                    {
                        PrzecinekFlaga = false;
                        continue;
                    }
                    else
                    {
                        TempChanged = true;
                        TempText = TempText.Remove(i, 1);
                        continue;
                    }
                }
                if (TempText[i] == '-')
                {
                    if (i == 0) continue;
                    else TempText = TempText.Remove(i, 1);
                }
                TempChanged = true;
                TempText = TempText.Remove(i, 1);
            }
            if (TempChanged) textBoxLiczba2.Text = TempText;
            #endregion
        }
        private void textBoxLiczba2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.') e.KeyChar = ',';
            if ((char.IsDigit(e.KeyChar) == false) && (e.KeyChar != '-') && (e.KeyChar != ',') && (e.KeyChar != '\b')) e.Handled = true;
        }
        private void richTextBoxWynik_TextChanged(object sender, EventArgs e)
        {
            buttonKasujHistorieOperacji.Enabled = true;
            buttonZapiszJakoLiczba1.Enabled = true;
            buttonZapiszJakoLIczba2.Enabled = true;
            contextMenuStripHistoriaOperacji.Enabled = true;
            if (zachowaj) richTextBoxHistoria.Text += richTextBoxWynik.Text + "\r\n";
        }
        private void buttonKasujHistorieOperacji_Click(object sender, EventArgs e)
        {
            richTextBoxHistoria.Text = "";
            buttonKasujHistorieOperacji.Enabled = false;
            buttonZapiszJakoLiczba1.Enabled = false;
            buttonZapiszJakoLIczba2.Enabled = false;
            contextMenuStripHistoriaOperacji.Enabled = false;
        }
        private void buttonZapiszJakoLiczba1_Click(object sender, EventArgs e)
        {
            textBoxLIczba1.Text = richTextBoxHistoria.SelectedText;
        }
        private void buttonZapiszJakoLIczba2_Click(object sender, EventArgs e)
        {
            textBoxLiczba2.Text = richTextBoxHistoria.SelectedText;
        }
        private void radioButtonDodawanie_CheckedChanged(object sender, EventArgs e)
        {
            if (textBoxLIczba1.Text != "" && textBoxLIczba1.Text != "")
                buttonOblicz.Enabled = true;
        }
        private void radioButtonOdejmowanie_CheckedChanged(object sender, EventArgs e)
        {
            if (textBoxLIczba1.Text != "" && textBoxLIczba1.Text != "")
                buttonOblicz.Enabled = true;
        }
        private void radioButtonMnozenie_CheckedChanged(object sender, EventArgs e)
        {
            if (textBoxLIczba1.Text != "" && textBoxLIczba1.Text != "")
                buttonOblicz.Enabled = true;
        }
        private void radioButtonDzielenie_CheckedChanged(object sender, EventArgs e)
        {
            if (textBoxLIczba1.Text != "" && textBoxLIczba1.Text != "")
                buttonOblicz.Enabled = true;
        }
        private void dodawanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBoxLIczba1.Text != "" && textBoxLiczba2.Text != "")
            {
                radioButtonDodawanie.PerformClick();
                buttonOblicz.PerformClick();
            }
        }
        private void odejmowanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBoxLIczba1.Text != "" && textBoxLiczba2.Text != "")
            {
                radioButtonOdejmowanie.PerformClick();
                buttonOblicz.PerformClick();
            }
        }
        private void mnozenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBoxLIczba1.Text != "" && textBoxLiczba2.Text != "")
            {
                radioButtonMnozenie.PerformClick();
                buttonOblicz.PerformClick();
            }
        }
        private void dzielenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBoxLIczba1.Text != "" && textBoxLiczba2.Text != "")
            {
                radioButtonDzielenie.PerformClick();
                buttonOblicz.PerformClick();
            }
        }
        private void wprowadzJakoLiczba1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonZapiszJakoLiczba1.PerformClick();
        }
        private void wprowadzJakoLiczba2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonZapiszJakoLIczba2.PerformClick();
        }
        private void kasujHistorieOperacjiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonKasujHistorieOperacji.PerformClick();
        }
    }
}
