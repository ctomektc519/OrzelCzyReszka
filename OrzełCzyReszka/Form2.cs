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
    }
}
