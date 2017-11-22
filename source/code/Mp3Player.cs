using System;
using System.IO;
using NAudio.Wave;

namespace Soundkey
{
    /// <summary>
    /// Der MP3 Player kann MP3 Dateien abspielen 
    /// </summary>
    public class Mp3Player
    {
        /// <summary>
        /// Spielt eine MP3 Datei ab.
        /// Falls die Datei nicht existiert, wird "anykey.mp3" abgespielt.
        /// </summary>
        public void spieleTon(string dateiname)
        {
            bool dateiGibtEs = File.Exists(dateiname);
            if (dateiGibtEs)
            {
                spieleDateiMitNAudio(dateiname);
            }
            else
            {
                try
                {
                    // Spiele anykey.mp3 ab
                    string ordner = Path.GetDirectoryName(dateiname);
                    string anykey = "anykey.mp3";
                    string neuedatei = ordner + "\\" + anykey;
                    bool gibtEsAnykey = File.Exists(neuedatei);
                    if (gibtEsAnykey)
                    {
                        spieleDateiMitNAudio(neuedatei);
                    }
                }
                catch (ArgumentException)
                {
                    // Passiert z.B. bei ungültigen Zeichen im Dateinamen
                    // Das wären <, >, |, *, ?, :, \ und /                    
                    // Bei diesen Tasten spielen wir einfach keinen Sound ab.
                }
            }
        }

        /// <summary>
        /// Spielt eine MP3 Datei tatsächlich ab.
        /// Voraussetzung: der Dateiname ist gültig.
        /// </summary>
        private void spieleDateiMitNAudio(string dateiname)
        {
            var mp3stream = new Mp3FileReader(dateiname);
            var ausgabe = new WaveOut();
            ausgabe.Init(mp3stream);
            ausgabe.Play();
            ausgabe.PlaybackStopped += BeimEnde;
        }

        /// <summary>
        /// Wenn die MP3 Datei fertig abgespielt ist, kann sie geschlossen werden.
        /// Ansonsten ist die Datei noch in Verwendung und kann z.B. nicht umbenannt werden.
        /// </summary>
        private void BeimEnde(object sender, StoppedEventArgs e)
        {
            var ausgabe = (WaveOut)sender;
            ausgabe.Dispose();
        }
    }
}
