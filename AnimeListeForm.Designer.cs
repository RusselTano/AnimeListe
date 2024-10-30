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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimeListeForm));
            this.animeListeMenuStrip = new System.Windows.Forms.MenuStrip();
            this.policesToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.typeAnimeLabel = new System.Windows.Forms.Label();
            this.typeAnimeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.imprimerButton = new System.Windows.Forms.Button();
            this.rechercheGroupBox = new System.Windows.Forms.GroupBox();
            this.rechercheButton = new System.Windows.Forms.Button();
            this.rechercherAnimeTextBox = new System.Windows.Forms.TextBox();
            this.rechercherAnimelabel = new System.Windows.Forms.Label();
            this.animeListePictureBox = new System.Windows.Forms.PictureBox();
            this.animeListePrintDocument = new System.Drawing.Printing.PrintDocument();
            this.animeListeFontDialog = new System.Windows.Forms.FontDialog();
            this.animeListePrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.animeListeMenuStrip.SuspendLayout();
            this.rechercheGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animeListePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // animeListeMenuStrip
            // 
            this.animeListeMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.animeListeMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.animeListeMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.policesToolStripComboBox});
            this.animeListeMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.animeListeMenuStrip.Name = "animeListeMenuStrip";
            this.animeListeMenuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.animeListeMenuStrip.Size = new System.Drawing.Size(793, 44);
            this.animeListeMenuStrip.TabIndex = 0;
            this.animeListeMenuStrip.Text = "menuStrip1";
            // 
            // policesToolStripComboBox
            // 
            this.policesToolStripComboBox.Name = "policesToolStripComboBox";
            this.policesToolStripComboBox.Size = new System.Drawing.Size(165, 38);
            this.policesToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.policesToolStripComboBox_SelectedIndexChanged);
            // 
            // typeAnimeLabel
            // 
            this.typeAnimeLabel.AutoSize = true;
            this.typeAnimeLabel.Location = new System.Drawing.Point(40, 358);
            this.typeAnimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.typeAnimeLabel.Name = "typeAnimeLabel";
            this.typeAnimeLabel.Size = new System.Drawing.Size(521, 25);
            this.typeAnimeLabel.TabIndex = 2;
            this.typeAnimeLabel.Text = "Type d\'anime : (selection indique l\'anime le meilleur anime)";
            // 
            // typeAnimeRichTextBox
            // 
            this.typeAnimeRichTextBox.Location = new System.Drawing.Point(44, 404);
            this.typeAnimeRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.typeAnimeRichTextBox.Name = "typeAnimeRichTextBox";
            this.typeAnimeRichTextBox.Size = new System.Drawing.Size(715, 211);
            this.typeAnimeRichTextBox.TabIndex = 3;
            this.typeAnimeRichTextBox.Text = "";
            // 
            // imprimerButton
            // 
            this.imprimerButton.Location = new System.Drawing.Point(44, 640);
            this.imprimerButton.Margin = new System.Windows.Forms.Padding(4);
            this.imprimerButton.Name = "imprimerButton";
            this.imprimerButton.Size = new System.Drawing.Size(715, 78);
            this.imprimerButton.TabIndex = 4;
            this.imprimerButton.Text = "Imprimer la liste des animes";
            this.imprimerButton.UseVisualStyleBackColor = true;
            this.imprimerButton.Click += new System.EventHandler(this.imprimerButton_Click);
            // 
            // rechercheGroupBox
            // 
            this.rechercheGroupBox.Controls.Add(this.rechercheButton);
            this.rechercheGroupBox.Controls.Add(this.rechercherAnimeTextBox);
            this.rechercheGroupBox.Controls.Add(this.rechercherAnimelabel);
            this.rechercheGroupBox.Location = new System.Drawing.Point(44, 756);
            this.rechercheGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.rechercheGroupBox.Name = "rechercheGroupBox";
            this.rechercheGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.rechercheGroupBox.Size = new System.Drawing.Size(715, 254);
            this.rechercheGroupBox.TabIndex = 5;
            this.rechercheGroupBox.TabStop = false;
            this.rechercheGroupBox.Text = "Recherche:";
            // 
            // rechercheButton
            // 
            this.rechercheButton.Location = new System.Drawing.Point(25, 136);
            this.rechercheButton.Margin = new System.Windows.Forms.Padding(4);
            this.rechercheButton.Name = "rechercheButton";
            this.rechercheButton.Size = new System.Drawing.Size(663, 78);
            this.rechercheButton.TabIndex = 6;
            this.rechercheButton.Text = "Afficher le nombre d\'anime";
            this.rechercheButton.UseVisualStyleBackColor = true;
            this.rechercheButton.Click += new System.EventHandler(this.rechercheButton_Click);
            // 
            // rechercherAnimeTextBox
            // 
            this.rechercherAnimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rechercherAnimeTextBox.Location = new System.Drawing.Point(25, 87);
            this.rechercherAnimeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.rechercherAnimeTextBox.Multiline = true;
            this.rechercherAnimeTextBox.Name = "rechercherAnimeTextBox";
            this.rechercherAnimeTextBox.Size = new System.Drawing.Size(663, 40);
            this.rechercherAnimeTextBox.TabIndex = 7;
            // 
            // rechercherAnimelabel
            // 
            this.rechercherAnimelabel.AutoSize = true;
            this.rechercherAnimelabel.Location = new System.Drawing.Point(21, 52);
            this.rechercherAnimelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rechercherAnimelabel.Name = "rechercherAnimelabel";
            this.rechercherAnimelabel.Size = new System.Drawing.Size(399, 25);
            this.rechercherAnimelabel.TabIndex = 6;
            this.rechercherAnimelabel.Text = "Type d\'anime recherche: (Shōnen et Shojo):";
            // 
            // animeListePictureBox
            // 
            this.animeListePictureBox.Image = global::AnimeListe.Properties.Resources.Big3;
            this.animeListePictureBox.Location = new System.Drawing.Point(161, 70);
            this.animeListePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.animeListePictureBox.Name = "animeListePictureBox";
            this.animeListePictureBox.Size = new System.Drawing.Size(509, 270);
            this.animeListePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.animeListePictureBox.TabIndex = 1;
            this.animeListePictureBox.TabStop = false;
            // 
            // animeListePrintDocument
            // 
            this.animeListePrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.animeListePrintDocument_PrintPage);
            // 
            // animeListePrintPreviewDialog
            // 
            this.animeListePrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.animeListePrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.animeListePrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.animeListePrintPreviewDialog.Enabled = true;
            this.animeListePrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("animeListePrintPreviewDialog.Icon")));
            this.animeListePrintPreviewDialog.Name = "animeListePrintPreviewDialog";
            this.animeListePrintPreviewDialog.Visible = false;
            // 
            // AnimeListeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 1047);
            this.Controls.Add(this.rechercheGroupBox);
            this.Controls.Add(this.imprimerButton);
            this.Controls.Add(this.typeAnimeRichTextBox);
            this.Controls.Add(this.typeAnimeLabel);
            this.Controls.Add(this.animeListePictureBox);
            this.Controls.Add(this.animeListeMenuStrip);
            this.MainMenuStrip = this.animeListeMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AnimeListeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button rechercheButton;
        private System.Windows.Forms.TextBox rechercherAnimeTextBox;
        private System.Drawing.Printing.PrintDocument animeListePrintDocument;
        private System.Windows.Forms.FontDialog animeListeFontDialog;
        private System.Windows.Forms.PrintPreviewDialog animeListePrintPreviewDialog;
    }
}

