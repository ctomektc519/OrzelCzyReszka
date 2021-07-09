using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrzełCzyReszka
{
    public partial class Form2 : Form
    {
        private OrzełCzyReszka FormGlowny;
        public Form2(OrzełCzyReszka glowna)
        {
            InitializeComponent();
            FormGlowny = glowna;
            FormClosing += OrzelCzyReszka_FormClosing2;
        }
        private int[] values;
        private int x;
        private int orly2 = 0;
        private int reszki2 = 0;

        private void buttonZamknij2_Click(object sender, EventArgs e)
        {
            FormGlowny.Close();
        }
        internal void OrzelCzyReszka_FormClosing2(object sender, FormClosingEventArgs e)
        {
          
            e.Cancel = true;
            FormGlowny.Close();
        }
        
        private void ZmianaMonety2_Click(object sender, EventArgs e)
        {
            Monety moneta = new Monety(FormGlowny);
            FormClosing -= OrzelCzyReszka_FormClosing2;
            this.Close();
            FormGlowny.Show();
            moneta.Show();
        }

        private void buttonWyczysc2_Click(object sender, EventArgs e)
        {
            textBoxIleMonet2.Text = "1";
            LorlowWynik2.Text = "0";
            LReszekWynik2.Text = "0";
            pictureBox11.Image = null;
            pictureBox22.Image = null;
            pictureBox33.Image = null;
            pictureBox44.Image = null;
            pictureBox55.Image = null;
        }
        

        private async void buttonRzuc2_Click(object sender, EventArgs e)
        {
            try
            {
                x = Int16.Parse(textBoxIleMonet2.Text);
            }
            catch (FormatException)
            {
                LorlowWynik2.Text = "0";
                LReszekWynik2.Text = "0";
                pictureBox11.Image = null;
                pictureBox22.Image = null;
                pictureBox33.Image = null;
                pictureBox44.Image = null;
                pictureBox55.Image = null;
                MessageBox.Show("Wprowadzona wartość nie jest liczbą całkowitą!\n" +
                    "Wprowadź prawidłową wartość.");
                textBoxIleMonet2.Text = "1";
                return;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                return;
            }

            /// Wprowadzenie liczby spoza zakresu 1 - 5           

            if (x < 1 || x > 5)
            {
                LorlowWynik2.Text = "0";
                LReszekWynik2.Text = "0";
                pictureBox11.Image = null;
                pictureBox22.Image = null;
                pictureBox33.Image = null;
                pictureBox44.Image = null;
                pictureBox55.Image = null;
                MessageBox.Show("Proszę wprowadzić wartość całkowitą z przedziału 1-5.");
                textBoxIleMonet2.Text = "1";
                return;
            }

            /// **Losowanie
            LorlowWynik2.Text = "0";
            LReszekWynik2.Text = "0";
            pictureBox11.Image = null;
            pictureBox22.Image = null;
            pictureBox33.Image = null;
            pictureBox44.Image = null;
            pictureBox55.Image = null;
            try
            {
                Random losuj = new Random();
                values = new int[x];
                for (int i = 0; i < x; i++)
                {
                    values[i] = losuj.Next(0, 2);

                }
                /// Wizualizacja losowania

                switch (x)
                {
                    case 1:
                        pictureBox11.Image = Image.FromFile(@"Resources\1zlReszka.png");
                        await Task.Delay(500);
                        pictureBox11.Image = Image.FromFile(@"Resources\1zlOrzel.png");
                        await Task.Delay(500);
                        pictureBox11.Image = Image.FromFile(@"Resources\1zlReszka.png");
                        await Task.Delay(500);
                        pictureBox11.Image = Image.FromFile(@"Resources\1zlOrzel.png");
                        await Task.Delay(500);
                        break;
                    case 2:
                        pictureBox11.Image = Image.FromFile(@"Resources\1zlReszka.png");
                        pictureBox22.Image = Image.FromFile(@"Resources\1zlReszka.png");

                        await Task.Delay(500);
                        pictureBox11.Image = Image.FromFile(@"Resources\1zlOrzel.png");
                        pictureBox22.Image = Image.FromFile(@"Resources\1zlOrzel.png");

                        await Task.Delay(500);
                        pictureBox11.Image = Image.FromFile(@"Resources\1zlReszka.png");
                        pictureBox22.Image = Image.FromFile(@"Resources\1zlReszka.png");

                        await Task.Delay(500);
                        pictureBox11.Image = Image.FromFile(@"Resources\1zlOrzel.png");
                        pictureBox22.Image = Image.FromFile(@"Resources\1zlOrzel.png");

                        await Task.Delay(500);
                        break;
                    case 3:
                        pictureBox11.Image = Image.FromFile(@"Resources\1zlReszka.png");
                        pictureBox22.Image = Image.FromFile(@"Resources\1zlReszka.png");
                        pictureBox33.Image = Image.FromFile(@"Resources\1zlReszka.png");


                        await Task.Delay(500);
                        pictureBox11.Image = Image.FromFile(@"Resources\1zlOrzel.png");
                        pictureBox22.Image = Image.FromFile(@"Resources\1zlOrzel.png");
                        pictureBox33.Image = Image.FromFile(@"Resources\1zlOrzel.png");


                        await Task.Delay(500);
                        pictureBox11.Image = Image.FromFile(@"Resources\1zlReszka.png");
                        pictureBox22.Image = Image.FromFile(@"Resources\1zlReszka.png");
                        pictureBox33.Image = Image.FromFile(@"Resources\1zlReszka.png");


                        await Task.Delay(500);
                        pictureBox11.Image = Image.FromFile(@"Resources\1zlOrzel.png");
                        pictureBox22.Image = Image.FromFile(@"Resources\1zlOrzel.png");
                        pictureBox33.Image = Image.FromFile(@"Resources\1zlOrzel.png");

                        await Task.Delay(500);
                        break;
                    case 4:
                        pictureBox11.Image = Image.FromFile(@"Resources\1zlReszka.png");
                        pictureBox22.Image = Image.FromFile(@"Resources\1zlReszka.png");
                        pictureBox33.Image = Image.FromFile(@"Resources\1zlReszka.png");
                        pictureBox44.Image = Image.FromFile(@"Resources\1zlReszka.png");


                        await Task.Delay(500);
                        pictureBox11.Image = Image.FromFile(@"Resources\1zlOrzel.png");
                        pictureBox22.Image = Image.FromFile(@"Resources\1zlOrzel.png");
                        pictureBox33.Image = Image.FromFile(@"Resources\1zlOrzel.png");
                        pictureBox44.Image = Image.FromFile(@"Resources\1zlOrzel.png");


                        await Task.Delay(500);
                        pictureBox11.Image = Image.FromFile(@"Resources\1zlReszka.png");
                        pictureBox22.Image = Image.FromFile(@"Resources\1zlReszka.png");
                        pictureBox33.Image = Image.FromFile(@"Resources\1zlReszka.png");
                        pictureBox44.Image = Image.FromFile(@"Resources\1zlReszka.png");


                        await Task.Delay(500);
                        pictureBox11.Image = Image.FromFile(@"Resources\1zlOrzel.png");
                        pictureBox22.Image = Image.FromFile(@"Resources\1zlOrzel.png");
                        pictureBox33.Image = Image.FromFile(@"Resources\1zlOrzel.png");
                        pictureBox44.Image = Image.FromFile(@"Resources\1zlOrzel.png");

                        await Task.Delay(500);
                        break;
                    case 5:
                        pictureBox11.Image = Image.FromFile(@"Resources\1zlReszka.png");
                        pictureBox22.Image = Image.FromFile(@"Resources\1zlReszka.png");
                        pictureBox33.Image = Image.FromFile(@"Resources\1zlReszka.png");
                        pictureBox44.Image = Image.FromFile(@"Resources\1zlReszka.png");
                        pictureBox55.Image = Image.FromFile(@"Resources\1zlReszka.png");

                        await Task.Delay(500);
                        pictureBox11.Image = Image.FromFile(@"Resources\1zlOrzel.png");
                        pictureBox22.Image = Image.FromFile(@"Resources\1zlOrzel.png");
                        pictureBox33.Image = Image.FromFile(@"Resources\1zlOrzel.png");
                        pictureBox44.Image = Image.FromFile(@"Resources\1zlOrzel.png");
                        pictureBox55.Image = Image.FromFile(@"Resources\1zlOrzel.png");

                        await Task.Delay(500);
                        pictureBox11.Image = Image.FromFile(@"Resources\1zlReszka.png");
                        pictureBox22.Image = Image.FromFile(@"Resources\1zlReszka.png");
                        pictureBox33.Image = Image.FromFile(@"Resources\1zlReszka.png");
                        pictureBox44.Image = Image.FromFile(@"Resources\1zlReszka.png");
                        pictureBox55.Image = Image.FromFile(@"Resources\1zlReszka.png");

                        await Task.Delay(500);
                        pictureBox11.Image = Image.FromFile(@"Resources\1zlOrzel.png");
                        pictureBox22.Image = Image.FromFile(@"Resources\1zlOrzel.png");
                        pictureBox33.Image = Image.FromFile(@"Resources\1zlOrzel.png");
                        pictureBox44.Image = Image.FromFile(@"Resources\1zlOrzel.png");
                        pictureBox55.Image = Image.FromFile(@"Resources\1zlOrzel.png");

                        await Task.Delay(500);
                        break;

                    default:
                        break;

                }

                /// Obliczanie ilości orłów i Reszek                 
                for (int j = 0; j < values.Length; j++)
                {
                    int w = values[j];
                    switch (w)
                    {
                        case 0:
                            reszki2 += 1;
                            break;
                        case 1:
                            orly2 += 1;

                            break;
                        default:
                            continue;
                    }

                }
            }
            catch (Exception ii)
            {
                MessageBox.Show(ii.Message);
                return;
            }



            String wynikOrly = String.Format("{0}", orly2);
            LorlowWynik2.Text = wynikOrly;

            String wynikReszki = String.Format("{0}", reszki2);
            LReszekWynik2.Text = wynikReszki;

            orly2 = 0;
            reszki2 = 0;




            /// Wyświetlanie animacji orłów i Reszek
            try
            {
                switch (values[0])
                {
                    case 0:
                        pictureBox11.Image = Image.FromFile(@"Resources\1zlReszka.png");
                        break;
                    case 1:
                        pictureBox11.Image = Image.FromFile(@"Resources\1zlOrzel.png");
                        break;
                    default:
                        pictureBox11.Image = null;
                        break;
                }
            }
            catch (Exception ef)
            {
                MessageBox.Show(ef.Message);
            }


            if (1 < values.Length)
            {
                switch (values[1])
                {
                    case 0:
                        pictureBox22.Image = Image.FromFile(@"Resources\1zlReszka.png");
                        break;
                    case 1:
                        pictureBox22.Image = Image.FromFile(@"Resources\1zlOrzel.png");
                        break;
                    default:
                        //  pictureBox22.Image = null;
                        break;
                }
            }
            else
            {
                pictureBox22.Image = null;

            }
            if (2 < values.Length)
            {
                switch (values[2])
                {
                    case 0:
                        pictureBox33.Image = Image.FromFile(@"Resources\1zlReszka.png");
                        break;
                    case 1:
                        pictureBox33.Image = Image.FromFile(@"Resources\1zlOrzel.png");
                        break;
                    default:
                        pictureBox33.Image = null;
                        break;
                }
            }
            else

            {
                pictureBox33.Image = null;
            }
            if (3 < values.Length)
            {
                switch (values[3])
                {
                    case 0:
                        pictureBox44.Image = Image.FromFile(@"Resources\1zlReszka.png");
                        break;
                    case 1:
                        pictureBox44.Image = Image.FromFile(@"Resources\1zlOrzel.png");
                        break;
                    default:
                        pictureBox44.Image = null;
                        break;
                }
            }
            else
            {
                pictureBox44.Image = null;
            }
            if (4 < values.Length)
            {
                switch (values[4])
                {
                    case 0:
                        pictureBox55.Image = Image.FromFile(@"Resources\1zlReszka.png");
                        break;
                    case 1:
                        pictureBox55.Image = Image.FromFile(@"Resources\1zlOrzel.png");
                        break;
                    default:
                        pictureBox55.Image = null;
                        break;
                }
            }
            else
            {
                pictureBox55.Image = null;
            }

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }
    }
}

