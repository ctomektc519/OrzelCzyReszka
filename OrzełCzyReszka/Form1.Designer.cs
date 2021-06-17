namespace OrzełCzyReszka
{
    partial class OrzełCzyReszka
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrzełCzyReszka));
            this.label_Title = new System.Windows.Forms.Label();
            this.IleMonet = new System.Windows.Forms.Label();
            this.textBoxIleMonet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LOrlow = new System.Windows.Forms.Label();
            this.LReszek = new System.Windows.Forms.Label();
            this.LorlowWynik = new System.Windows.Forms.Label();
            this.LReszekWynik = new System.Windows.Forms.Label();
            this.buttonRzuc = new System.Windows.Forms.Button();
            this.buttonWyczysc = new System.Windows.Forms.Button();
            this.buttonZamknij = new System.Windows.Forms.Button();
            this.ZmianaMonety = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            resources.ApplyResources(this.label_Title, "label_Title");
            this.label_Title.ForeColor = System.Drawing.Color.Maroon;
            this.label_Title.Name = "label_Title";
            this.label_Title.Click += new System.EventHandler(this.label_Title_Click);
            // 
            // IleMonet
            // 
            resources.ApplyResources(this.IleMonet, "IleMonet");
            this.IleMonet.ForeColor = System.Drawing.Color.Black;
            this.IleMonet.Name = "IleMonet";
            this.IleMonet.Click += new System.EventHandler(this.IleMonet_Click);
            // 
            // textBoxIleMonet
            // 
            resources.ApplyResources(this.textBoxIleMonet, "textBoxIleMonet");
            this.textBoxIleMonet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBoxIleMonet.Name = "textBoxIleMonet";
            this.textBoxIleMonet.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // LOrlow
            // 
            resources.ApplyResources(this.LOrlow, "LOrlow");
            this.LOrlow.Name = "LOrlow";
            // 
            // LReszek
            // 
            resources.ApplyResources(this.LReszek, "LReszek");
            this.LReszek.Name = "LReszek";
            // 
            // LorlowWynik
            // 
            resources.ApplyResources(this.LorlowWynik, "LorlowWynik");
            this.LorlowWynik.ForeColor = System.Drawing.Color.Maroon;
            this.LorlowWynik.Name = "LorlowWynik";
            // 
            // LReszekWynik
            // 
            resources.ApplyResources(this.LReszekWynik, "LReszekWynik");
            this.LReszekWynik.ForeColor = System.Drawing.Color.Maroon;
            this.LReszekWynik.Name = "LReszekWynik";
            // 
            // buttonRzuc
            // 
            this.buttonRzuc.AutoEllipsis = true;
            resources.ApplyResources(this.buttonRzuc, "buttonRzuc");
            this.buttonRzuc.Name = "buttonRzuc";
            this.buttonRzuc.UseVisualStyleBackColor = true;
            this.buttonRzuc.Click += new System.EventHandler(this.buttonRzuc_Click);
            // 
            // buttonWyczysc
            // 
            this.buttonWyczysc.AutoEllipsis = true;
            resources.ApplyResources(this.buttonWyczysc, "buttonWyczysc");
            this.buttonWyczysc.Name = "buttonWyczysc";
            this.buttonWyczysc.UseVisualStyleBackColor = true;
            this.buttonWyczysc.Click += new System.EventHandler(this.Button2_Click);
            // 
            // buttonZamknij
            // 
            this.buttonZamknij.AutoEllipsis = true;
            this.buttonZamknij.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.buttonZamknij, "buttonZamknij");
            this.buttonZamknij.Name = "buttonZamknij";
            this.buttonZamknij.UseVisualStyleBackColor = true;
            this.buttonZamknij.Click += new System.EventHandler(this.buttonZamknij_Click);
            // 
            // ZmianaMonety
            // 
            this.ZmianaMonety.AutoEllipsis = true;
            this.ZmianaMonety.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.ZmianaMonety, "ZmianaMonety");
            this.ZmianaMonety.Name = "ZmianaMonety";
            this.ZmianaMonety.UseVisualStyleBackColor = true;
            this.ZmianaMonety.Click += new System.EventHandler(this.ZmianaMonety_Click);
            // 
            // pictureBox5
            // 
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // OrzełCzyReszka
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.ZmianaMonety);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonZamknij);
            this.Controls.Add(this.buttonWyczysc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonRzuc);
            this.Controls.Add(this.LReszekWynik);
            this.Controls.Add(this.LorlowWynik);
            this.Controls.Add(this.LReszek);
            this.Controls.Add(this.LOrlow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIleMonet);
            this.Controls.Add(this.IleMonet);
            this.Controls.Add(this.label_Title);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "OrzełCzyReszka";
            this.Load += new System.EventHandler(this.OrzełCzyReszka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label IleMonet;
        private System.Windows.Forms.TextBox textBoxIleMonet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LOrlow;
        private System.Windows.Forms.Label LReszek;
        private System.Windows.Forms.Label LorlowWynik;
        private System.Windows.Forms.Label LReszekWynik;
        private System.Windows.Forms.Button buttonRzuc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonWyczysc;
        private System.Windows.Forms.Button buttonZamknij;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button ZmianaMonety;
    }
}

