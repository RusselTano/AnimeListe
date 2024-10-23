namespace AnimeListe
{
    partial class AnimeListeForm
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
            this.animeListeMenuStrip = new System.Windows.Forms.MenuStrip();
            this.policesToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.typeAnimeLabel = new System.Windows.Forms.Label();
            this.typeAnimeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.imprimerButton = new System.Windows.Forms.Button();
            this.rechercheGroupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rechercherAnimeTextBox = new System.Windows.Forms.TextBox();
            this.rechercherAnimelabel = new System.Windows.Forms.Label();
            this.animeListePictureBox = new System.Windows.Forms.PictureBox();
            this.animeListeMenuStrip.SuspendLayout();
            this.rechercheGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animeListePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // animeListeMenuStrip
            // 
            this.animeListeMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.animeListeMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.policesToolStripComboBox});
            this.animeListeMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.animeListeMenuStrip.Name = "animeListeMenuStrip";
            this.animeListeMenuStrip.Size = new System.Drawing.Size(577, 32);
            this.animeListeMenuStrip.TabIndex = 0;
            this.animeListeMenuStrip.Text = "menuStrip1";
            // 
            // policesToolStripComboBox
            // 
            this.policesToolStripComboBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.policesToolStripComboBox.Name = "policesToolStripComboBox";
            this.policesToolStripComboBox.Size = new System.Drawing.Size(121, 28);
            this.policesToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.policesToolStripComboBox_SelectedIndexChanged);
            // 
            // typeAnimeLabel
            // 
            this.typeAnimeLabel.AutoSize = true;
            this.typeAnimeLabel.Location = new System.Drawing.Point(29, 239);
            this.typeAnimeLabel.Name = "typeAnimeLabel";
            this.typeAnimeLabel.Size = new System.Drawing.Size(358, 16);
            this.typeAnimeLabel.TabIndex = 2;
            this.typeAnimeLabel.Text = "Type d\'anime : (selection indique l\'anime le meilleur anime)";
            // 
            // typeAnimeRichTextBox
            // 
            this.typeAnimeRichTextBox.Location = new System.Drawing.Point(32, 269);
            this.typeAnimeRichTextBox.Name = "typeAnimeRichTextBox";
            this.typeAnimeRichTextBox.Size = new System.Drawing.Size(521, 142);
            this.typeAnimeRichTextBox.TabIndex = 3;
            this.typeAnimeRichTextBox.Text = "Shōnen\t\tDragon Ball \t\nShōnen\t\tNaruto\nShōnen\t\tOne Piece\nShōnen\t\tBleach \nShōnen\t\tMy" +
    " Hero Academia \nShojo\t\tFruits Basket\nShojo\t\tCardcaptor Sakura\nShojo\t\tNana\nShojo\t" +
    "\tAo Haru Ride\nShojo\t\tKimi ni Todoke\n\t";
            // 
            // imprimerButton
            // 
            this.imprimerButton.Location = new System.Drawing.Point(32, 427);
            this.imprimerButton.Name = "imprimerButton";
            this.imprimerButton.Size = new System.Drawing.Size(520, 52);
            this.imprimerButton.TabIndex = 4;
            this.imprimerButton.Text = "Imprimer la liste des animes";
            this.imprimerButton.UseVisualStyleBackColor = true;
            // 
            // rechercheGroupBox
            // 
            this.rechercheGroupBox.Controls.Add(this.button1);
            this.rechercheGroupBox.Controls.Add(this.rechercherAnimeTextBox);
            this.rechercheGroupBox.Controls.Add(this.rechercherAnimelabel);
            this.rechercheGroupBox.Location = new System.Drawing.Point(32, 504);
            this.rechercheGroupBox.Name = "rechercheGroupBox";
            this.rechercheGroupBox.Size = new System.Drawing.Size(520, 169);
            this.rechercheGroupBox.TabIndex = 5;
            this.rechercheGroupBox.TabStop = false;
            this.rechercheGroupBox.Text = "Recherche:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(482, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "Afficher le nombre d\'anime";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // rechercherAnimeTextBox
            // 
            this.rechercherAnimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rechercherAnimeTextBox.Location = new System.Drawing.Point(18, 58);
            this.rechercherAnimeTextBox.Multiline = true;
            this.rechercherAnimeTextBox.Name = "rechercherAnimeTextBox";
            this.rechercherAnimeTextBox.Size = new System.Drawing.Size(482, 27);
            this.rechercherAnimeTextBox.TabIndex = 7;
            // 
            // rechercherAnimelabel
            // 
            this.rechercherAnimelabel.AutoSize = true;
            this.rechercherAnimelabel.Location = new System.Drawing.Point(15, 35);
            this.rechercherAnimelabel.Name = "rechercherAnimelabel";
            this.rechercherAnimelabel.Size = new System.Drawing.Size(268, 16);
            this.rechercherAnimelabel.TabIndex = 6;
            this.rechercherAnimelabel.Text = "Type d\'anime recherche: (Shōnen et Shojo):";
            // 
            // animeListePictureBox
            // 
            this.animeListePictureBox.Image = global::AnimeListe.Properties.Resources.Big3;
            this.animeListePictureBox.Location = new System.Drawing.Point(117, 47);
            this.animeListePictureBox.Name = "animeListePictureBox";
            this.animeListePictureBox.Size = new System.Drawing.Size(370, 180);
            this.animeListePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.animeListePictureBox.TabIndex = 1;
            this.animeListePictureBox.TabStop = false;
            // 
            // AnimeListeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 698);
            this.Controls.Add(this.rechercheGroupBox);
            this.Controls.Add(this.imprimerButton);
            this.Controls.Add(this.typeAnimeRichTextBox);
            this.Controls.Add(this.typeAnimeLabel);
            this.Controls.Add(this.animeListePictureBox);
            this.Controls.Add(this.animeListeMenuStrip);
            this.MainMenuStrip = this.animeListeMenuStrip;
            this.Name = "AnimeListeForm";
            this.Text = "Anime Liste";
            this.Load += new System.EventHandler(this.AnimeListeForm_Load);
            this.animeListeMenuStrip.ResumeLayout(false);
            this.animeListeMenuStrip.PerformLayout();
            this.rechercheGroupBox.ResumeLayout(false);
            this.rechercheGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animeListePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip animeListeMenuStrip;
        private System.Windows.Forms.ToolStripComboBox policesToolStripComboBox;
        private System.Windows.Forms.PictureBox animeListePictureBox;
        private System.Windows.Forms.Label typeAnimeLabel;
        private System.Windows.Forms.RichTextBox typeAnimeRichTextBox;
        private System.Windows.Forms.Button imprimerButton;
        private System.Windows.Forms.GroupBox rechercheGroupBox;
        private System.Windows.Forms.Label rechercherAnimelabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox rechercherAnimeTextBox;
    }
}

