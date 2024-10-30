/*
    Programmeur:    Manuela,dylane,andreas,cedric
    Date:           juin 2024
  
    Solution:       animeListe.sln
    Projet:         animeListe.csproj
    Classe:         animeListeForm.cs  
  
    But:			modification des donnes ajout des controles sur la pages a imprimer         
  
    Traitement:	    Implementer le code
   			
    Sorties:		imprimer des controles
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimeListe
{
    public partial class AnimeListeForm : Form
    {
        #region Initialisation
        public AnimeListeForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void AnimeListeForm_Load(object sender, EventArgs e)
        {
            LoadRTFFile();
            animeListePrintPreviewDialog.Width = SystemInformation.VirtualScreen.Width;
            animeListePrintPreviewDialog.Height = SystemInformation.VirtualScreen.Height;
            animeListePrintPreviewDialog.PrintPreviewControl.Zoom = 2;

           policesToolStripComboBox.SelectedIndexChanged -= policesToolStripComboBox_SelectedIndexChanged;
            AfficherPolicesInstallees();
            policesToolStripComboBox.SelectedIndexChanged += policesToolStripComboBox_SelectedIndexChanged;

        }

        #endregion

        #region police instaler
        private void AfficherPolicesInstallees()
        {
            try
            {
                var fonts = new System.Drawing.Text.InstalledFontCollection();
                foreach (FontFamily font in fonts.Families)
                {
                    policesToolStripComboBox.Items.Insert(0, font.Name);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Police
        private void policesToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Apply the selected font to the RichTextBox content
                typeAnimeRichTextBox.SelectionFont = new Font(policesToolStripComboBox.SelectedItem.ToString(), typeAnimeRichTextBox.SelectionFont.Size);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error applying font: {ex.Message}");
            }
        }
        #endregion

        #region rtf

        private string rtfFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data\\document.rtf");

        private void LoadRTFFile()
        {
            try
            {
                if (File.Exists(rtfFilePath))
                {
                    typeAnimeRichTextBox.LoadFile(rtfFilePath, RichTextBoxStreamType.PlainText);

                    string firstLineText = "Dragon Ball";
                    int startIndex = typeAnimeRichTextBox.Find(firstLineText);
                    if (startIndex != -1)
                    {
                        typeAnimeRichTextBox.Select(startIndex ,firstLineText.Length); // Sélectionner la première ligne
                    }

                    // Optionnel : Si tu veux défiler jusqu'à la sélection
                    typeAnimeRichTextBox.ScrollToCaret();

                }
                else
                {
                    MessageBox.Show($"Le fichier RTF n'a pas été trouvé : {rtfFilePath}");
                }
            }
            catch (Exception )
            {
                 MessageBox.Show($"Erreur lors du chargement du fichier RTF ");
            }
        }





        #endregion

        #region rechercher
        private void rechercheButton_Click(object sender, EventArgs e)
        {
            try
            {
                string motChercher = rechercherAnimeTextBox.Text;
                if (!string.IsNullOrEmpty(motChercher))
                {
                    int startIndex = 0;
                    int nbOccurence = 0;

                    while ((startIndex = typeAnimeRichTextBox.Find(motChercher, startIndex, RichTextBoxFinds.None)) != -1)
                    {
                        nbOccurence++;
                        startIndex += motChercher.Length;  // Move index forward
                    }

                    MessageBox.Show($"Le mot '{motChercher}' est apparu {nbOccurence} fois.");
                }
                else
                {
                    MessageBox.Show("Veuillez entrer un mot à rechercher.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during search: {ex.Message}");
            }

        }




        #endregion

        #region imprimer

        private void imprimerButton_Click(object sender, EventArgs e)
        {
            try
            {
                animeListePrintPreviewDialog.Document = animeListePrintDocument;
                animeListePrintPreviewDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during printing: {ex.Message}");
            }


        }
        private void animeListePrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {

            try
            {
                Image imageChoisie;
                imageChoisie = Properties.Resources.Big3;
                // Utilise la taille du PictureBox directement pour l'image imprimée
                int imgWidth = animeListePictureBox.Width;
                int imgHeight = animeListePictureBox.Height;

                // Calcul des coordonnées pour centrer l'image
                int posX = (int)((e.MarginBounds.Width) / 2);
                int posY = 50;

                // Dessine l'image centrée avec les dimensions du PictureBox
                e.Graphics.DrawImage(animeListePictureBox.Image, posX, posY, imgWidth, imgHeight);

                

                Font enteteFont, detailFont;

                enteteFont = new Font("Arial", 18.0F, FontStyle.Bold);
                detailFont = new Font("Arial", 14.0F);

                //definir les tailles par rapport au police

                Single hauteurPoliceEntete = enteteFont.GetHeight();
               

                //variable
                string titre = "liste anime ";
                string entete = "Type manga       Nom manga";
                //mesurer le titre 

                Single largeurTitreSingle = e.Graphics.MeasureString(titre, enteteFont).Width;


                
                //position du crayon

                float XFloat = e.MarginBounds.X;
                float YFloat = e.MarginBounds.Y;

                //imprimr le titre et souligner
                e.Graphics.DrawString(titre, enteteFont, Brushes.Blue, XFloat+280, YFloat+120);
                YFloat += hauteurPoliceEntete;
                e.Graphics.DrawLine(new Pen(Color.Blue, 3.0F), XFloat + 280, YFloat+120, XFloat + largeurTitreSingle+280, YFloat+120);


                //sous tutre goup box
                YFloat += 130;

                e.Graphics.DrawString(entete, detailFont, Brushes.Red, XFloat, YFloat);
                YFloat += hauteurPoliceEntete * 2;
                


                string content = typeAnimeRichTextBox.Rtf;
                // Custom logic to format and print the content
                e.Graphics.DrawString(typeAnimeRichTextBox.Text, new Font("Arial", 12), Brushes.Black, new PointF(100,YFloat-20));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"erreur lors de l impressiong: {ex.Message}");
            }
        }




        #endregion

        
    }
}
