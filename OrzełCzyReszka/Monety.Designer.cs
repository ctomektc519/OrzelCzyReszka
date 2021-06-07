namespace OrzełCzyReszka
{
    partial class Monety
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Monety));
            this.Title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Wybierz5zl = new System.Windows.Forms.Button();
            this.wybierz1zl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Title.ForeColor = System.Drawing.Color.Maroon;
            this.Title.Location = new System.Drawing.Point(94, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(189, 29);
            this.Title.TabIndex = 0;
            this.Title.Text = "Wybór monety";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(32, 167);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(103, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Wybierz5zl
            // 
            this.Wybierz5zl.AutoEllipsis = true;
            this.Wybierz5zl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Wybierz5zl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.Wybierz5zl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Wybierz5zl.Location = new System.Drawing.Point(208, 91);
            this.Wybierz5zl.Name = "Wybierz5zl";
            this.Wybierz5zl.Size = new System.Drawing.Size(119, 39);
            this.Wybierz5zl.TabIndex = 9;
            this.Wybierz5zl.Text = "Wybierz";
            this.Wybierz5zl.UseVisualStyleBackColor = false;
            // 
            // wybierz1zl
            // 
            this.wybierz1zl.AutoEllipsis = true;
            this.wybierz1zl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.wybierz1zl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.wybierz1zl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.wybierz1zl.Location = new System.Drawing.Point(208, 203);
            this.wybierz1zl.Name = "wybierz1zl";
            this.wybierz1zl.Size = new System.Drawing.Size(119, 39);
            this.wybierz1zl.TabIndex = 10;
            this.wybierz1zl.Text = "Wybierz";
            this.wybierz1zl.UseVisualStyleBackColor = false;
            // 
            // Monety
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(384, 281);
            this.Controls.Add(this.wybierz1zl);
            this.Controls.Add(this.Wybierz5zl);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Title);
            this.Name = "Monety";
            this.Text = "Wybór monety";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Wybierz5zl;
        private System.Windows.Forms.Button wybierz1zl;
    }
}