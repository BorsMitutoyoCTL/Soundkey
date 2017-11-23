using System;
using System.Threading;
using NAudio.Wave;
namespace SoundDiagnose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anzahl Geräte: " + WaveOut.DeviceCount + " zzgl. Audio Mapper");
            for (int n = -1; n < WaveOut.DeviceCount; n++)
            {
                var caps = WaveOut.GetCapabilities(n);
                Console.WriteLine("Gerät " + n + " Name   : " + caps.ProductName);
                Console.WriteLine("Gerät " + n + " Kanäle : " + caps.Channels);
            }

            for (int n = -1; n < WaveOut.DeviceCount; n++)
            {
                // MP3 abspielen
                var caps = WaveOut.GetCapabilities(n);
                Console.WriteLine("Spiele MP3 auf  " + caps.ProductName);
                var mp3 = new Mp3FileReader("test.mp3");
                var ausgabe = new WaveOut();
                ausgabe.DeviceNumber = n;
                ausgabe.Init(mp3);
                ausgabe.Play();
                while (ausgabe.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(100);
                }
                ausgabe.Dispose();
                mp3.Close();
                mp3.Dispose();

                Console.WriteLine("Gehört ? [J/N]");
                var eingabe = Console.ReadLine();
                if (eingabe == "J" || eingabe == "j")
                {
                    Console.WriteLine("Super!");
                }
                else
                {
                    Console.WriteLine("Schade ...");
                }
            }

            Console.WriteLine("Zum Beenden Enter drücken.");
            Console.ReadLine();
        }
    }
}
