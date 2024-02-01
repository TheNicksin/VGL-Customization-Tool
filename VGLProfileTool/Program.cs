using System;
using System.Diagnostics;
using System.Net;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter background link: ");
        string backgroundInput = Console.ReadLine();

        Console.Write("Enter profile pic link: ");
        string profilePicInput = Console.ReadLine();

        Console.Write("Enter some profile text: ");
        string profileTextInput = Console.ReadLine();
        profileTextInput = profileTextInput.Replace(" ", @"%20");

        var bgData = new WebClient().DownloadString("http://localhost:42281/customization/background_image/update?link=" + backgroundInput);
        var picData = new WebClient().DownloadString("http://localhost:42281/home/profile_picture/update?link=" + profilePicInput);
        var textData = new WebClient().DownloadString("http://localhost:42281/home/profile_text/update?text=" + profileTextInput);
    }
}