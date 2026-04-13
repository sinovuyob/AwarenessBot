using System;

public static class SecurityTips
{
    public static void DisplayPasswordTips(string name)
    {
        ChatbotUI.PrintHeader("PASSWORD SAFETY GUIDES FOR " + name);
        ChatbotUI.PrintInfo("• Use passwords that are at least 12 characters long");
        ChatbotUI.PrintInfo("• Combine uppercase, lowercase, numbers, and special characters");
        ChatbotUI.PrintInfo("• Never reuse passwords across different accounts");
        ChatbotUI.PrintInfo("• Avoid using personal information like birthdays or names");
        ChatbotUI.PrintInfo("• Change passwords immediately if you suspect a breach");
        ChatbotUI.PrintDivider("dotted");
        ChatbotUI.PrintInfo("Remember " + name + ", a strong password is your first line of defence!", isWarning: true);
        Console.WriteLine();
    }

    public static void DisplayPhishingTips(string name)
    {
        ChatbotUI.PrintHeader("PHISHING AWARENESS FOR " + name);
        ChatbotUI.PrintInfo("• Always verify the sender's email address before clicking links");
        ChatbotUI.PrintInfo("• Never share sensitive information via email or text");
        ChatbotUI.PrintInfo("• Hover over links to see the actual URL before clicking");
        ChatbotUI.PrintInfo("• Be suspicious of unexpected attachments, even from known senders");
        ChatbotUI.PrintInfo("• Look for spelling errors and urgent language - common phishing tactics");
        ChatbotUI.PrintDivider("dotted");
        ChatbotUI.PrintInfo("Stay vigilant! Think before you click!", isWarning: true);
        Console.WriteLine();
    }

    public static void DisplaySafeBrowsingTips(string name)
    {
        ChatbotUI.PrintHeader("SAFE BROWSING TIPS FOR " + name);
        ChatbotUI.PrintInfo("• Keep your browser and all extensions updated");
        ChatbotUI.PrintInfo("• Avoid saving passwords in your browser");
        ChatbotUI.PrintInfo("• Clear cookies and cache regularly");
        ChatbotUI.PrintInfo("• Enable 'Do Not Track' and privacy features");
        ChatbotUI.PrintInfo("• Be cautious of what you download and from where");
        ChatbotUI.PrintDivider("dotted");
        ChatbotUI.PrintInfo("Browse smartly " + name + "! Your online safety matters!", isWarning: false);
        Console.WriteLine();
    }

    public static void DisplayDataProtectionTips(string name)
    {
        ChatbotUI.PrintHeader("DATA PROTECTION FOR " + name);
        ChatbotUI.PrintInfo("• Encrypt sensitive files before storing them in the cloud");
        ChatbotUI.PrintInfo("• Follow the 3-2-1 backup rule: 3 copies, 2 different media, 1 offsite");
        ChatbotUI.PrintInfo("• Regularly update your backup strategy");
        ChatbotUI.PrintInfo("• Test your backups to ensure they work!");
        ChatbotUI.PrintDivider("dotted");
        Console.WriteLine();
    }

    public static void DisplayGeneralTips(string name)
    {
        ChatbotUI.PrintHeader("GENERAL SECURITY TIPS FOR " + name);
        ChatbotUI.PrintInfo("• Always keep your operating system updated");
        ChatbotUI.PrintInfo("• Use a VPN on public Wi-Fi networks");
        ChatbotUI.PrintInfo("• Regularly backup your important data");
        ChatbotUI.PrintInfo("• Be careful what you share on social media");
        ChatbotUI.PrintInfo("• Lock your computer when stepping away");
        ChatbotUI.PrintInfo("• Verify software downloads from official sources only");
        ChatbotUI.PrintDivider("dotted");
        ChatbotUI.PrintInfo("Stay protected " + name + "! Security is a continuous journey!", isWarning: false);
        Console.WriteLine();
    }
}