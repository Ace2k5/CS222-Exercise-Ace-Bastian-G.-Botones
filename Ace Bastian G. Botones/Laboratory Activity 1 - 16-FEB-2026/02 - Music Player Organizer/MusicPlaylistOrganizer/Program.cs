using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Songs to add: ");
        int numSongs = int.Parse(Console.ReadLine()!);

        Song[] playlist = new Song[numSongs];

        for (int i = 0; i < numSongs; i++)
        {
            Console.WriteLine($"\nSong #{i + 1}");

            Console.Write("Title: ");
            string title = Console.ReadLine()!;

            Console.Write("Artist: ");
            string artist = Console.ReadLine()!;

            Console.Write("Duration (minutes): ");
            string durationInput = Console.ReadLine()!;
            
            if (string.IsNullOrWhiteSpace(title) && string.IsNullOrWhiteSpace(artist) && string.IsNullOrWhiteSpace(durationInput))
            {
                playlist[i] = new Song();
            }
            else if (string.IsNullOrWhiteSpace(durationInput))
            {
                playlist[i] = new Song(title, artist);
            }
            else
            {
                double minutes = double.Parse(durationInput);
                playlist[i] = new Song(title, artist, minutes);
            }
        }

        Console.WriteLine("\n=== || MY PLAYLIST || ===");
        Console.WriteLine($"{"Title",-20}{"Artist",-16}{"Time"}");
        Console.WriteLine(new string('-', 48));

        double total = 0;
        foreach (Song song in playlist)
        {
            song.DisplaySong();
            total += song.minutes;
        }

        Console.WriteLine($"\nTotal Duration: {total:F2} mins");
        Console.WriteLine($"Average Duration: {total / numSongs:F2} mins");
    }
}

public class Song
{
    public string title;
    public string artist;
    public double minutes;

    public Song()
    {
        this.title = "Unknown";
        this.artist = "Unknown";
        this.minutes = 0.00;
    }

    public Song(string title, string artist) : this(title, artist, 0.00)
    {
    }

    public Song(string title, string artist, double minutes) : this()
    {
        if (!string.IsNullOrWhiteSpace(title)) this.title = title;
        if (!string.IsNullOrWhiteSpace(artist)) this.artist = artist;
        this.minutes = minutes;
    }

    public void DisplaySong()
    {
        Console.WriteLine($"{title,-20}{artist,-16}{minutes:F2}");
    }
}