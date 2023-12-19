using System.Text.Json;

namespace ScreenSound_API.Modelos;

internal class FavoriteSong
{
    
    public string? Name { get;}
    List<Musica> Songs { get; }

    public FavoriteSong(string name)
    {
        Name = name;
        Songs = new List<Musica> { };
    }

    public void AddMusic(Musica song)
    {
        Songs.Add(song);
    }

    public void ViewSongs()
    {
        Console.WriteLine($"Favorite Songs ({Name})");
        foreach (var song in Songs)
        {
            Console.WriteLine($"- {song.Nome} from ({song.Artista})");
        }
        Console.WriteLine();
    }

    public void GenerateJsonFile()
    {
        var json = JsonSerializer.Serialize(new
        {
            nome = Name,
            song = Songs
        });

        string nameFile = $"Favorite-Songs-{Name}.json";
        File.WriteAllText(nameFile, json );

        Console.WriteLine($"Arquivo Jason criado com sucesso! \n{Path.GetFullPath(nameFile)}");
    }
}
