using System;
using System.Diagnostics;
using System.Text.Json;

namespace JSON_HelloWorld_BenF
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Settings settings = new Settings();

            settings.name = "Ben";
            settings.lives = 3;
            settings.level = 1;

            string jsonString = JsonSerializer.Serialize(settings);

            Console.WriteLine("JSON String:");
            Console.WriteLine("-------------------");
            Console.WriteLine(jsonString);
            Console.WriteLine("-------------------");


            System.IO.File.WriteAllText("settings.json", jsonString);

            //--------------------------------------------------------------
            //Deserialize

            string newJsonString = File.ReadAllText("settings.json");

            var settings2 = JsonSerializer.Deserialize<Settings>(newJsonString);

            if (settings2 != null )
            {
                Console.WriteLine("");
                Console.WriteLine("Deserialize From File");
                Console.WriteLine("-------------------");
                Console.WriteLine($"Name: {settings2.name}, Lives: {settings2.lives} Level: {settings2.level}" );
                Console.WriteLine("-------------------");


            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("-------------------");
                Console.WriteLine("Deserialize Failed");
                Console.WriteLine("-------------------");


            }

        }
    }

}