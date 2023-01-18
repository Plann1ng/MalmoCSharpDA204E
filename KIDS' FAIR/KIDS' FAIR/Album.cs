using System;

public class Album
{
    public Album()
    { }
    //Album name, artist name, and number of tracks
    private string albumName;
    private string artistName;
    private int numOfTracks;

    /*Method to greet the user.*/
    public void greet() => Console.WriteLine("Starting the album program!\n");

    /*Method for reading name of the user's Album*/
    public void getAlbumNameInput()
    {
        Console.WriteLine("What is the name of your favourite music Album? ");
        albumName = Console.ReadLine();
    }

    /*Method for reading artist of the users Album*/
    public void getArtistNameInput()
    {
        Console.WriteLine($"What is the name of the Artist or Band for {albumName}?");
        artistName = Console.ReadLine();
    }

    /*Method for reading track count of the users Album*/
    public void getNumOfTracksInput()
    {
        Console.WriteLine($"How many tracks does {albumName} have? ");
        numOfTracks = int.Parse(Console.ReadLine());
    }
    /*Display info*/
    public void Displayinformation()
    {
        Console.WriteLine($"Album Name: {albumName}\nArtist/Band: {artistName} \nNumber of Tracks: {numOfTracks}\nEnjoy listening!");
    }

    /*Runner*/
    public void Start()
    {
        greet();
        getAlbumNameInput();
        getArtistNameInput();
        getNumOfTracksInput();
        Displayinformation();
    }
}



