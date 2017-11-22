using System;
using System.Threading;
using System.Windows.Forms;

namespace Soundkey
{
    static class Program
    {
        /// <summary>
        /// Hier fängt das Programm an zu laufen.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Hier wird vom Betriebssystem eine Mutex angefordert.
            // Unser Setup kann dann prüfen, ob die Mutex schon vorhanden ist, oder nicht.
            // Falls die Mutex vorhanden ist, kann das Setup den Benutzer warnen, dass das Programm noch läuft und daher im Moment nicht deinstalliert werden kann.
            var mutex = new Mutex(false, "KeySoundIsRunning");
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Hauptfenster());
            }
            finally // mach das hier immer!
            {
                // Mutex wieder ans Betriebssystem zurückgeben ("löschen")
                mutex.Close();
            }
        }
    }
}
