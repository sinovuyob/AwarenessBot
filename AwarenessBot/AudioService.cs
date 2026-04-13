using System;
using System.IO;

public static class AudioService
{
    public static void PlayWelcome()
    {
        string audioPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Audio", "welcome.wav");
        Console.WriteLine("Looking for audio at: " + audioPath);

        if (File.Exists(audioPath))
        {
            Console.WriteLine("File found. Attempting to play...");
            try
            {
                using (var player = new System.Media.SoundPlayer(audioPath))
                {
                    player.PlaySync();
                }
                Console.WriteLine("Playback finished.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Playback error: " + ex.Message);
            }
        }
        else
        {
            Console.WriteLine("ERROR: File not found!");
        }
    }
}