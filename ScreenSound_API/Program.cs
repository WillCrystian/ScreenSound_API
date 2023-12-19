using System.Text.Json;
using ScreenSound_API.Modelos;
using ScreenSound_API.LinqFilters;
using ScreenSound_API.Filters;

using (HttpClient client = new HttpClient())
{   
	try
	{
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        //LinqFilter.FilterMusicGenre(musicas);
        //LinqOrder.ViewListSortedArtists(musicas);
        //LinqFilter.FilterArtistByGenreMusic(musicas, "rock");
        //LinqFilter.FilterMusicByArtist(musicas, "U2");
    }
	catch (Exception ex)
	{
        Console.WriteLine($"Ocorreu uma falha na requisição: {ex}");
    }

}