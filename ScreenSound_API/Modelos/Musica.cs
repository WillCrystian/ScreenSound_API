using System.Text.Json.Serialization;

namespace ScreenSound_API.Modelos;

internal class Musica
{
    [JsonPropertyName("song")]
    public string? Nome { get; set; }
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }
    [JsonPropertyName("duration_ms")]
    public int? Duracao { get; set; }


    public void DisplayMusicInformation()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Música: {Nome}");
        Console.WriteLine($"Genero: {Genero}");
        Console.WriteLine($"Duração em segundos: {Duracao / 1000}");
    }
}
