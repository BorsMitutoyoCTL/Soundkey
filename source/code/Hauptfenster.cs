using System;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;

namespace Soundkey
{
    public partial class Hauptfenster : Form
    {
        public Hauptfenster()
        {
            InitializeComponent();
        }

        private void Hauptfenster_Load(object sender, EventArgs e)
        {
            Hook.GlobalEvents().KeyPress += BeiTastendruck;
        }

        private void BeiTastendruck(object sender, KeyPressEventArgs e)
        {
            // Taste als Text ermitteln
            string taste = e.KeyChar.ToString();
            if (e.KeyChar == 13)
            {
                taste = "Enter";
            }
            if (e.KeyChar == 32)
            {
                taste = "Leerzeichen";
            }

            // Dateiname "ausrechnen"
            string ordner = ausgewählterOrdner;
            string endung = ".mp3";
            string dateiname = ordner + "\\" + taste + endung;

            // MP3 Player nehmen und die Datei abspielen
            Mp3Player ipod = new Mp3Player();
            ipod.spieleTon(dateiname);
        }

        private void buttonVerstecken_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void MenuBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuAnzeigen_Click(object sender, EventArgs e)
        {
            Show();
        }

        private string ausgewählterOrdner;

        private void buttonAuswahl_Click(object sender, EventArgs e)
        {
            DialogResult antwort = verzeichnisAuswahl.ShowDialog();
            if (antwort == DialogResult.OK)
            {
                // Wenn der Benutzer OK geklicht hat, neues Verzeichnis übernehmen.
                ausgewählterOrdner = verzeichnisAuswahl.SelectedPath;
            }

            if (antwort == DialogResult.Cancel)
            {
                // Wenn der Benutzer abgebrochen hat, einfach nix tun.
                // So weitermachen wie vorher.
            }
        }
    }
}
