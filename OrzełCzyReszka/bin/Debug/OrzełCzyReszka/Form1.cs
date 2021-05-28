/*
Author: Tomasz Cieślik
Title: Program Orzeł czy reszka
Date: 10.05.2021
*/
/*
Changelog:
*/

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
    public partial class OrzełCzyReszka : Form
    {
        private int[] values;
        private int orly = 0;
        private int reszki = 0;
        private int x;
        public OrzełCzyReszka()
        {
            InitializeComponent();

            ///** Wyłączenie kontrolek zamykania, minimalizacji... w aplikacji**

            // ControlBox = false; 

            ///** Powiązanie metody OrzelCzyReszka_FormClosing ze zdarzeniem zamykania aplikacji:

            FormClosing += OrzelCzyReszka_FormClosing;

        }

        private void OrzełCzyReszka_Load(object sender, EventArgs e)
        {

        }

        private void label_Title_Click(object sender, EventArgs e)
        {

        }

        private void IleMonet_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        /// ** Przycisk Wyczyść**


        private void Button2_Click(object sender, EventArgs e)
        {
            textBoxIleMonet.Text = "1";
            LorlowWynik.Text = "0";
            LReszekWynik.Text = "0";
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
        }

        /// ** Przycisk Zamknij      

        private void buttonZamknij_Click(object sender, EventArgs e)
        {
            /* 
             if (MessageBox.Show("Czy napewno chcesz wyjść z programu?"
                  , "Koniec", MessageBoxButtons.YesNo) == DialogResult.Yes)
              {
               //   MessageBox.Show("Dziękujemy za skorzystanie programu.", "Dziękujemy");
                  Application.Exit();
              }
              */
            Application.Exit();

        }
        // Operacje wykonywana w momencie próby zamknięcia programu

        private void OrzelCzyReszka_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.DialogResult wynik = MessageBox.Show(
                  "Czy napewno chcesz zamknąć program ?",
                  "Zamykanie programu",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Exclamation,
                  MessageBoxDefaultButton.Button2);

            e.Cancel = (wynik == DialogResult.No);

            /// ** Dodatkowe okno zamykania 
            /// ** 10.0.2021 - Po analizie wyłączono
            /*
            if (wynik == DialogResult.Yes)
            {
                MessageBox.Show("Dziękujemy za skorzystanie programu!", "Koniec");
            }
            */
        }


        /// ** Przycisk Rzuć

        private async void buttonRzuc_Click(object sender, EventArgs e)
        {

            /// Konwersja tekstu na int

            try
            {
                x = Int16.Parse(textBoxIleMonet.Text);
            } catch (FormatException)
            {
                LorlowWynik.Text = "0";
                LReszekWynik.Text = "0";
                pictureBox1.Image = null;
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
                MessageBox.Show("Wprowadzona wartość nie jest liczbą całkowitą!\n" +
                    "Wprowadź prawidłową wartość.");
                textBoxIleMonet.Text = "1";
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
                LorlowWynik.Text = "0";
                LReszekWynik.Text = "0";
                pictureBox1.Image = null;
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
                MessageBox.Show("Proszę wprowadzić wartość całkowitą z przedziału 1-5.");
                textBoxIleMonet.Text = "1";
                return;
            }
            /// **Losowanie
            LorlowWynik.Text = "0";
            LReszekWynik.Text = "0";
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            try {
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
                        pictureBox1.Image = Image.FromFile(@"Resources\5ReszkazOk.png");
                        await Task.Delay(500);
                        pictureBox1.Image = Image.FromFile(@"Resources\Orzel2.png");
                        await Task.Delay(500);
                        pictureBox1.Image = Image.FromFile(@"Resources\5ReszkazOk.png");
                        await Task.Delay(500);
                        pictureBox1.Image = Image.FromFile(@"Resources\Orzel2.png");
                        await Task.Delay(500);
                        break;
                    case 2:
                        pictureBox1.Image = Image.FromFile(@"Resources\5ReszkazOk.png");
                        pictureBox2.Image = Image.FromFile(@"Resources\5ReszkazOk.png");

                        await Task.Delay(500);
                        pictureBox1.Image = Image.FromFile(@"Resources\Orzel2.png");
                        pictureBox2.Image = Image.FromFile(@"Resources\Orzel2.png");

                        await Task.Delay(500);
                        pictureBox1.Image = Image.FromFile(@"Resources\5ReszkazOk.png");
                        pictureBox2.Image = Image.FromFile(@"Resources\5ReszkazOk.png");

                        await Task.Delay(500);
                        pictureBox1.Image = Image.FromFile(@"Resources\Orzel2.png");
                        pictureBox2.Image = Image.FromFile(@"Resources\Orzel2.png");

                        await Task.Delay(500);
                        break;
                    case 3:
                        pictureBox1.Image = Image.FromFile(@"Resources\5ReszkazOk.png");
                        pictureBox2.Image = Image.FromFile(@"Resources\5ReszkazOk.png");
                        pictureBox3.Image = Image.FromFile(@"Resources\5ReszkazOk.png");


                        await Task.Delay(500);
                        pictureBox1.Image = Image.FromFile(@"Resources\Orzel2.png");
                        pictureBox2.Image = Image.FromFile(@"Resources\Orzel2.png");
                        pictureBox3.Image = Image.FromFile(@"Resources\Orzel2.png");


                        await Task.Delay(500);
                        pictureBox1.Image = Image.FromFile(@"Resources\5ReszkazOk.png");
                        pictureBox2.Image = Image.FromFile(@"Resources\5ReszkazOk.png");
                        pictureBox3.Image = Image.FromFile(@"Resources\5ReszkazOk.png");


                        await Task.Delay(500);
                        pictureBox1.Image = Image.FromFile(@"Resources\Orzel2.png");
                        pictureBox2.Image = Image.FromFile(@"Resources\Orzel2.png");
                        pictureBox3.Image = Image.FromFile(@"Resources\Orzel2.png");

                        await Task.Delay(500);
                        break;
                    case 4:
                        pictureBox1.Image = Image.FromFile(@"Resources\5ReszkazOk.png");
                        pictureBox2.Image = Image.FromFile(@"Resources\5ReszkazOk.png");
                        pictureBox3.Image = Image.FromFile(@"Resources\5ReszkazOk.png");
                        pictureBox4.Image = Image.FromFile(@"Resources\5ReszkazOk.png");


                        await Task.Delay(500);
                        pictureBox1.Image = Image.FromFile(@"Resources\Orzel2.png");
                        pictureBox2.Image = Image.FromFile(@"Resources\Orzel2.png");
                        pictureBox3.Image = Image.FromFile(@"Resources\Orzel2.png");
                        pictureBox4.Image = Image.FromFile(@"Resources\Orzel2.png");


                        await Task.Delay(500);
                        pictureBox1.Image = Image.FromFile(@"Resources\5ReszkazOk.png");
                        pictureBox2.Image = Image.FromFile(@"Resources\5ReszkazOk.png");
                        pictureBox3.Image = Image.FromFile(@"Resources\5ReszkazOk.png");
                        pictureBox4.Image = Image.FromFile(@"Resources\5ReszkazOk.png");


                        await Task.Delay(500);
                        pictureBox1.Image = Image.FromFile(@"Resources\Orzel2.png");
                        pictureBox2.Image = Image.FromFile(@"Resources\Orzel2.png");
                        pictureBox3.Image = Image.FromFile(@"Resources\Orzel2.png");
                        pictureBox4.Image = Image.FromFile(@"Resources\Orzel2.png");

                        await Task.Delay(500);
                        break;
                    case 5:
                        pictureBox1.Image = Image.FromFile(@"Resources\5ReszkazOk.png");
                        pictureBox2.Image = Image.FromFile(@"Resources\5ReszkazOk.png");
                        pictureBox3.Image = Image.FromFile(@"Resources\5ReszkazOk.png");
                        pictureBox4.Image = Image.FromFile(@"Resources\5ReszkazOk.png");
                        pictureBox5.Image = Image.FromFile(@"Resources\5ReszkazOk.png");

                        await Task.Delay(500);
                        pictureBox1.Image = Image.FromFile(@"Resources\Orzel2.png");
                        pictureBox2.Image = Image.FromFile(@"Resources\Orzel2.png");
                        pictureBox3.Image = Image.FromFile(@"Resources\Orzel2.png");
                        pictureBox4.Image = Image.FromFile(@"Resources\Orzel2.png");
                        pictureBox5.Image = Image.FromFile(@"Resources\Orzel2.png");

                        await Task.Delay(500);
                        pictureBox1.Image = Image.FromFile(@"Resources\5ReszkazOk.png");
                        pictureBox2.Image = Image.FromFile(@"Resources\5ReszkazOk.png");
                        pictureBox3.Image = Image.FromFile(@"Resources\5ReszkazOk.png");
                        pictureBox4.Image = Image.FromFile(@"Resources\5ReszkazOk.png");
                        pictureBox5.Image = Image.FromFile(@"Resources\5ReszkazOk.png");
                        
                        await Task.Delay(500);
                        pictureBox1.Image = Image.FromFile(@"Resources\Orzel2.png");
                        pictureBox2.Image = Image.FromFile(@"Resources\Orzel2.png");
                        pictureBox3.Image = Image.FromFile(@"Resources\Orzel2.png");
                        pictureBox4.Image = Image.FromFile(@"Resources\Orzel2.png");
                        pictureBox5.Image = Image.FromFile(@"Resources\Orzel2.png");

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
                                reszki += 1;
                                break;
                            case 1:
                                orly += 1;

                                break;
                            default:
                                continue;
                        }

                    }
                }catch (Exception ii)
            {
                MessageBox.Show(ii.Message);
                return;
            }



            String wynikOrly = String.Format("{0}", orly);
            LorlowWynik.Text = wynikOrly;

            String wynikReszki = String.Format("{0}", reszki);
            LReszekWynik.Text = wynikReszki;

            orly = 0;
            reszki = 0;




            /// Wyświetlanie animacji orłów i Reszek
            try
            {
                switch (values[0])
                {
                    case 0:
                        pictureBox1.Image = Image.FromFile(@"Resources\5ReszkazOk.png");
                        break;
                    case 1:
                        pictureBox1.Image = Image.FromFile(@"Resources\Orzel2.png");
                        break;
                    default:
                        pictureBox1.Image = null;
                        break;
                }
            } catch (Exception ef)
            {
                MessageBox.Show(ef.Message);
            }


            if (1 < values.Length)
            {
                switch (values[1])
                {
                    case 0:
                        pictureBox2.Image = Image.FromFile(@"Resources\5ReszkazOk.png");
                        break;
                    case 1:
                        pictureBox2.Image = Image.FromFile(@"Resources\Orzel2.png");
                        break;
                    default:
                        //  pictureBox2.Image = null;
                        break;
                }
            }
            else {
                pictureBox2.Image = null;

            }
            if (2 < values.Length)
            {
                switch (values[2])
                {
                    case 0:
                        pictureBox3.Image = Image.FromFile(@"Resources\5ReszkazOk.png");
                        break;
                    case 1:
                        pictureBox3.Image = Image.FromFile(@"Resources\Orzel2.png");
                        break;
                    default:
                        pictureBox3.Image = null;
                        break;
                }
            } else

            {
                pictureBox3.Image = null;
            }
            if (3 < values.Length)
            {
                switch (values[3])
                {
                    case 0:
                        pictureBox4.Image = Image.FromFile(@"Resources\5ReszkazOk.png");
                        break;
                    case 1:
                        pictureBox4.Image = Image.FromFile(@"Resources\Orzel2.png");
                        break;
                    default:
                        pictureBox4.Image = null;
                        break;
                }
            }
            else
            {
                pictureBox4.Image = null;
            }
            if (4 < values.Length)
            {
                switch (values[4])
                {
                    case 0:
                        pictureBox5.Image = Image.FromFile(@"Resources\5ReszkazOk.png");
                        break;
                    case 1:
                        pictureBox5.Image = Image.FromFile(@"Resources\Orzel2.png");
                        break;
                    default:
                        pictureBox5.Image = null;
                        break;
                }
            }
            else
            {
                pictureBox5.Image = null;
            }
                    
        }
    
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
       
        }
        
    }
}
