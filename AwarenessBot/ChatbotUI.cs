using System;
using System.Threading;

public static class ChatbotUI
{
    private static readonly ConsoleColor DefaultColor = ConsoleColor.Gray;
    private static readonly ConsoleColor HeaderColor = ConsoleColor.Cyan;
    private static readonly ConsoleColor UserColor = ConsoleColor.Yellow;
    private static readonly ConsoleColor BotColor = ConsoleColor.Green;
    private static readonly ConsoleColor HighlightColor = ConsoleColor.Magenta;

    public static void PrintWelcomeBanner()
    {
        // Top border
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine(new string('═', 80));
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(@"   ___      _                                        _ _             _                                                 ___       _   ");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(@"  / __\   _| |__   ___ _ __ ___  ___  ___ _   _ _ __(_) |_ _   _    /_\__      ____ _ _ __ ___ _ __   ___  ___ ___    / __\ ___ | |_ ");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(@" / / | | | | '_ \ / _ \ '__/ __|/ _ \/ __| | | | '__| | __| | | |  //_\\ \ /\ / / _` | '__/ _ \ '_ \ / _ \/ __/ __|  /__\/// _ \| __|");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(@"/ /__| |_| | |_) |  __/ |  \__ \  __/ (__| |_| | |  | | |_| |_| | /  _  \ V  V / (_| | | |  __/ | | |  __/\__ \__ \ / \/  \ (_) | |_ ");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(@"\____/\__, |_.__/ \___|_|  |___/\___|\___|\__,_|_|  |_|\__|\__, | \_/ \_/\_/\_/ \__,_|_|  \___|_| |_|\___||___/___/ \_____/\___/ \__|");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(@"      |___/                                                |___/                                                                     ");
        Console.ResetColor();

        // Bottom border
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine(new string('═', 80));
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n    >>> INITIALIZING CYBERSECURITY PROTOCOLS <<<\n");
        Console.ResetColor();

        string[] bootMessages = {
            "Loading security modules",
            "Establishing encrypted channel",
            "Verifying user credentials",
            "Activating firewall",
            "Scanning for threats",
            "Launching Digital Guardian interface"
        };

        foreach (string msg in bootMessages)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("    " + msg);
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(400);
                Console.Write(".");
            }
            Console.WriteLine(" ✅");
            Console.ResetColor();
            Thread.Sleep(300);
        }

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("\n    System readiness: ");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        int totalSteps = 20;
        for (int i = 0; i <= totalSteps; i++)
        {
            int percent = (i * 100) / totalSteps;
            Console.Write("\r    System readiness: " + new string('█', i) + new string('░', totalSteps - i) + " " + percent + "%");
            Thread.Sleep(100);
        }
        Console.WriteLine(" ✅\n");
        Console.ResetColor();

        // Typing effect final message
        Console.ForegroundColor = ConsoleColor.Magenta;
        string finalMessage = "    Welcome, user. Your Digital Guardian is ready. Stay safe!";
        foreach (char c in finalMessage)
        {
            Console.Write(c);
            Thread.Sleep(30);
        }
        Console.WriteLine("\n");
        Console.ResetColor();

        Thread.Sleep(800);
    }

    public static void PrintHeader(string title)
    {
        Console.ForegroundColor = HeaderColor;
        Console.WriteLine("\n╔═══════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ " + title.PadRight(55) + " ║");
        Console.WriteLine("╚═══════════════════════════════════════════════════════════╝");
        Console.ResetColor();
        Thread.Sleep(300);
    }

    public static void PrintDivider(string style = "solid")
    {
        Console.ForegroundColor = HeaderColor;
        if (style == "solid")
            Console.WriteLine(new string('═', 70));
        else
            Console.WriteLine("•" + new string('•', 70) + "•");
        Console.ResetColor();
    }

    public static void TypeText(string text, int delayMs = 30)
    {
        Console.ForegroundColor = BotColor;
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(delayMs);
        }
        Console.ResetColor();
        Console.WriteLine();
    }

    public static void PrintBotResponse(string message, bool useTypingEffect = false, int delayMs = 25)
    {
        Console.ForegroundColor = BotColor;
        Console.Write("Bot: ");
        Console.ResetColor();

        if (useTypingEffect)
            TypeText(message, delayMs);
        else
            Console.WriteLine(message);
    }

    public static void PrintUserPrompt(string userName)
    {
        Console.ForegroundColor = UserColor;
        Console.Write("\n" + userName + ": ");
        Console.ResetColor();
    }

    public static void PrintInfo(string message, bool isWarning = false)
    {
        Console.ForegroundColor = isWarning ? ConsoleColor.Red : ConsoleColor.Cyan;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    public static void PrintTopicList(string[] topics)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\n📌 You can ask about:");
        Console.ResetColor();
        foreach (var topic in topics)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("   • ");
            Console.ResetColor();
            Console.WriteLine(topic);
        }
        Console.WriteLine();
    }
}