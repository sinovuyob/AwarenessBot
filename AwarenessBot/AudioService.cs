using System;
using System.IO;
using NAudio.Wave;

public static class AudioService
{
    public static void PlayWelcome()
    {
        try
        {
            string audioPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "welcome.wav");
            Console.WriteLine("Looking for audio at: " + audioPath);

            if (File.Exists(audioPath))
            {
                Console.WriteLine("File found. Attempting to play...");

                using (var audioFile = new AudioFileReader(audioPath))
                using (var outputDevice = new WaveOutEvent())
                {
                    outputDevice.Init(audioFile);
                    outputDevice.Play();

                    // Keep the program alive while playing
                    while (outputDevice.PlaybackState == PlaybackState.Playing)
                    {
                        System.Threading.Thread.Sleep(100);
                    }
                }

                Console.WriteLine("Playback finished.");
            }
            else
            {
                Console.WriteLine("ERROR: File not found at: " + audioPath);
                Console.WriteLine("Make sure welcome.wav is copied to the output directory.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Audio error: " + ex.Message);
            Console.WriteLine("Stack trace: " + ex.StackTrace);
        }
    }
}