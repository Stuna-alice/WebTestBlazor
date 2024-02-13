namespace GameStop.Client.Models;

public class Game
{
    public int game_Id { get; set; }
    public required string game_Name { get; set; } 
    public required string game_Genre { get; set; } 
    public decimal game_Price { get; set; } 
    public  DateTime game_ReleaseDate { get; set; } 
}