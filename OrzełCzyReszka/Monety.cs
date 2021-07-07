using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;


namespace OrzełCzyReszka
{
    public partial class Monety : Form
    {
        public OrzełCzyReszka OrzResz;
        public Monety(OrzełCzyReszka glowna)
        {
            InitializeComponent();
            OrzResz = glowna;
           
            
        }
       

        private void Wybierz5zl_Click(object sender, EventArgs e)
        {
            OrzResz.Show();
            this.Close();
           
            
            
        }

        private void wybierz1zl_Click(object sender, EventArgs e)
        {
            OrzResz.Hide();
            this.Close();
            Form2 f2 = new Form2(OrzResz);
            f2.Show();

        }
    }
}
