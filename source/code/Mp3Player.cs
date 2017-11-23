using System;
using System.IO;
using System.Threading;
using NAudio;
using NAudio.Wave;

namespace Soundkey
{
    /// <summary>
    /// Der MP3 Player kann MP3 Dateien abspielen 
    /// </summary>
    /// <example>
    /// Mp3Player ipod = new Mp3Player();
    /// ipod.spieleTon("C:\test.mp3");
    /// </example>
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

        Mp3FileReader mp3stream;

        static int maximaleAnzahlMP3sGleichzeitig = 10;
        static int aktuelleAnzahlGespielterTöne = 0;

        /// <summary>
        /// Spielt eine MP3 Datei tatsächlich ab.
        /// Voraussetzung: der Dateiname ist gültig.
        /// </summary>
        private void spieleDateiMitNAudio(string dateiname)
        {
            try
            {
                if (aktuelleAnzahlGespielterTöne < maximaleAnzahlMP3sGleichzeitig)
                {
                    mp3stream = new Mp3FileReader(dateiname);
                    var ausgabe = new WaveOut();
                    ausgabe.Init(mp3stream);
                    ausgabe.Play();
                    ausgabe.PlaybackStopped += BeimEnde;
                    Interlocked.Increment(ref aktuelleAnzahlGespielterTöne);
                }
            }
            catch (MmException)
            {
                // Soundkarte hat keinen Platz mehr
                // Einfach nix tun
            }
        }

        /// <summary>
        /// Wenn die MP3 Datei fertig abgespielt ist, kann sie geschlossen werden.
        /// Ansonsten ist die Datei noch in Verwendung und kann z.B. nicht umbenannt werden.
        /// </summary>
        private void BeimEnde(object sender, StoppedEventArgs e)
        {
            var ausgabe = (WaveOut)sender;
            ausgabe.Dispose();
            mp3stream.Close();
            mp3stream.Dispose();
            Interlocked.Decrement(ref aktuelleAnzahlGespielterTöne);
        }
    }
}
