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

    //filtrar artista por genero musical
    public static void FilterArtistByGenreMusic(List<Musica> musicas, string genre)
    {
        var artistByGenre = musicas.Where(m => m.Genero!.Contains(genre)).Select(m => m.Artista).Distinct().Order().ToList();

        Console.WriteLine("Filter Arstist By Genre Music!");
        foreach (var artist in artistByGenre)
        {
            Console.WriteLine($" - {artist}");
        }
    }
    //filtrar as músicas de um artista.
}
