using System.Text.Json;
using ScreenSound_API.Modelos;
using ScreenSound_API.LinqFilters;
using ScreenSound_API.Filters;

using (HttpClient client = new HttpClient())
{
    //filtrar artista por genero musical
    //filtrar as músicas de um artista.
	try
	{
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        //LinqFilter.FilterMusicGenre(musicas);
        LinqOrder.ViewListSortedArtists(musicas);
    }
	catch (Exception ex)
	{
        Console.WriteLine($"Ocorreu uma falha na requisição: {ex}");
    }

}