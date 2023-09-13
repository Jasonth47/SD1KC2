using System;
using System.Collections.Generic;

class MusicRecord
{
    public string Title { get; set; }
    public string Artist { get; set; }

    public MusicRecord(string title, string artist)
    {
        Title = title;
        Artist = artist;
    }
}

class VinylRecord : MusicRecord
{
    public string Genre { get; set; }

    public VinylRecord(string title, string artist, string genre) : base(title, artist)
    {
        Genre = genre;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many music records do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        if (numberOfRecords <= 0) // Exit the program
        {
            Console.WriteLine("No records were added. Exiting the program.");
            return; 
        }

        var recordList = new List<VinylRecord>();
        for (int i = 0; i < numberOfRecords; i++)
        {
            var vinylRecord = new VinylRecord("", "", ""); 

            Console.WriteLine($"Enter the title for Record {i + 1}: ");
            vinylRecord.Title = Console.ReadLine();

            Console.WriteLine($"Enter the artist for Record {i + 1}: ");
            vinylRecord.Artist = Console.ReadLine();

            Console.WriteLine($"Enter the genre for Record {i + 1}: ");
            vinylRecord.Genre = (Console.ReadLine());

            recordList.Add(vinylRecord);
        }

        Console.WriteLine("List of Music Records:");
        foreach (var record in recordList)
        {
            Console.WriteLine($"Title: {record.Title}, Artist: {record.Artist}, Genre: {record.Genre}");
        }
    }
}
