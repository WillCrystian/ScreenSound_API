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
}
