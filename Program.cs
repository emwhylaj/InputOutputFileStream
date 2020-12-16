using System;
using System.IO;

namespace InputOutputFileStream
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string userName;
            Console.WriteLine("**********Welcome!!! Please enter your username************");
            userName = Console.ReadLine();

            string htmlFile = "<html>";
            htmlFile += "<body>";
            htmlFile += "<h1 style ='font-style: normal; text-align: center; background: crimson;'>";
            Console.WriteLine($"Hi {userName} what is the title of your news?");
            string blogHeading = Console.ReadLine();
            htmlFile += blogHeading + "</h1>";
            htmlFile += "<p style='text-align: center; font-style: italic; background: white; font-size: 20px;'>";
            Console.WriteLine("Please provide the full content of the news");
            string blogParagraph = Console.ReadLine();
            htmlFile += blogParagraph + "</p>";
            htmlFile += "</body>";
            htmlFile += "</html>";

            File.WriteAllText($"C:\\Users\\MuyiwaOlalekan\\OneDrive - Enov8 Solutions Ltd\\Desktop\\InputOutputFileStream\\" + userName+".html", htmlFile);
            DateTime dayOfCreation = DateTime.Today;
            DateTime timeOfCreation = DateTime.Now;
            Console.WriteLine("HTML file has been created on {0} {1} ", timeOfCreation.ToLongTimeString() ,dayOfCreation.ToLongDateString());
            Console.ReadLine();
        }
    }
}