using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimeListe
{
    public partial class AnimeListeForm : Form
    {
        public AnimeListeForm()
        {
            InitializeComponent();
        }

        private void AnimeListeForm_Load(object sender, EventArgs e)
        {
            policesToolStripComboBox.SelectedIndexChanged -= policesToolStripComboBox_SelectedIndexChanged;
            AfficherPolicesInstallees();
            policesToolStripComboBox.SelectedIndexChanged += policesToolStripComboBox_SelectedIndexChanged;
        }
        private void policesToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void AfficherPolicesInstallees()
        {
            try
            {
                InstalledFontCollection oInstalledFonts = new InstalledFontCollection();

                foreach (FontFamily oFontFamily in oInstalledFonts.Families)
                {
                    policesToolStripComboBox.Items.Add(oFontFamily.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
