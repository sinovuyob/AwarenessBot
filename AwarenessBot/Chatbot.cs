using System;

public class Chatbot
{
    private string name;

    public void Start()
    {
        AudioService.PlayWelcome();

        ChatbotUI.PrintWelcomeBanner();

        Console.Title = "Cybersecurity Awareness Chatbot";

        ChatbotUI.PrintHeader("WELCOME");
        Console.WriteLine("Welcome to the Cybersecurity Awareness Chatbot");

        Console.Write("What is your name? ");
        name = Console.ReadLine();

        ChatbotUI.PrintBotResponse("Hello " + name + "! I'm your Digital Guardian in Cyberspace.", useTypingEffect: true, delayMs: 20);

        // Chat Loop
        while (true)
        {
            ChatbotUI.PrintUserPrompt(name);
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "exit")
            {
                ChatbotUI.PrintDivider("dotted");
                ChatbotUI.PrintInfo("Goodbye " + name + "! STAY SAFE IN THE DIGITAL WORLD!", isWarning: false);
                ChatbotUI.PrintInfo("Remember: Think before you click, Always Stay Vigilant!", isWarning: true);
                break;
            }
            else if (userInput.Contains("hello") || userInput.Contains("hi") || userInput.Contains("hey"))
            {
                ChatbotUI.PrintBotResponse("Hello " + name + "! How can I help you today?", useTypingEffect: true);
            }
            else if (userInput.Contains("how are you"))
            {
                ChatbotUI.PrintBotResponse("I am functioning well, " + name + "! Ready to help you stay secure.", useTypingEffect: true);
            }
            else if (userInput.Contains("what is your purpose") || userInput.Contains("whats your purpose"))
            {
                ChatbotUI.PrintBotResponse("My purpose is to educate you, " + name + ", about cybersecurity and how to stay safe online.", useTypingEffect: true);
            }
            else if (userInput.Contains("what can i ask about you"))
            {
                ChatbotUI.PrintBotResponse("Great question, " + name + "! You can ask me about:", useTypingEffect: false);
                string[] topics = {
                                    "Password safety tips",
                                    "Phishing attack prevention",
                                    "Safe browsing practices",
                                    "Data protection",
                                    "General cybersecurity tips"
                           };
                ChatbotUI.PrintTopicList(topics);
            }
            else if (userInput.Contains("password"))
            {
                SecurityTips.DisplayPasswordTips(name);
            }
            else if (userInput.Contains("phishing"))
            {
                SecurityTips.DisplayPhishingTips(name);
            }
            else if (userInput.Contains("safe browsing") || userInput.Contains("browser"))
            {
                SecurityTips.DisplaySafeBrowsingTips(name);
            }
            else if (userInput.Contains("data protection") || userInput.Contains("data"))
            {
                SecurityTips.DisplayDataProtectionTips(name);
            }
            else if (userInput.Contains("security") || userInput.Contains("cyber") || userInput.Contains("protect"))
            {
                SecurityTips.DisplayGeneralTips(name);
            }
            else
            {
                ChatbotUI.PrintBotResponse("Sorry " + name + ", I didn't understand that. Try asking about cybersecurity topics.", useTypingEffect: true);
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}