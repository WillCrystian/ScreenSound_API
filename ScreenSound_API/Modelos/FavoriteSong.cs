namespace ScreenSound_API.Modelos;

internal class FavoriteSong
{
    
    public string? Nome { get;}
    List<Musica> Songs { get; }

    public FavoriteSong(string nome)
    {
        Nome = nome;
        Songs = new List<Musica> { };
    }

    public void AddMusic(Musica song)
    {
        Songs.Add(song);
    }

    public void ViewSongs()
    {
        Console.WriteLine($"Favorite Songs ({Nome})");
        foreach (var song in Songs)
        {
            Console.WriteLine($"- {song.Nome} from ({song.Artista})");
        }
        Console.WriteLine();
    }
}
