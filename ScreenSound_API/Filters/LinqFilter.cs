using ScreenSound_API.Modelos;

namespace ScreenSound_API.LinqFilters;

internal class LinqFilter
{
    public static void FilterMusicGenre(List<Musica> musicas)
    {
        var allMusicsGenres = musicas.Select(g => g.Genero).Distinct().ToList();
        
        foreach (var genre in allMusicsGenres)
        {
            Console.WriteLine($"- {genre}");
        }            
    }
    public static void FilterArtistByGenreMusic(List<Musica> musicas, string genre)
    {
        var artistByGenre = musicas.Where(m => m.Genero!.Contains(genre)).Select(m => m.Artista).Distinct().Order().ToList();

        Console.WriteLine("Arstist By Genre Music!");
        foreach (var artist in artistByGenre)
        {
            Console.WriteLine($" - {artist}");
        }
    }

    public static void FilterMusicByArtist(List<Musica> musicas, string artist)
    {
        var musicByArtist = musicas.Where(m => m.Artista!.Equals(artist)).ToList();
        Console.WriteLine("Music By Artist!");
        foreach (var music in musicByArtist)
        {
            Console.WriteLine($"- music: {music.Nome}/ {music.Artista}");
        }
    }
}
