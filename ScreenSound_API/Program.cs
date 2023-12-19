using System.Text.Json;
using ScreenSound_API.Modelos;
using ScreenSound_API.LinqFilters;
using ScreenSound_API.Filters;
using ScreenSound_API.Modelos;

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

        FavoriteSong SongsWilliam = new FavoriteSong("William");

        SongsWilliam.AddMusic(musicas[845]);
        SongsWilliam.AddMusic(musicas[1630]);
        SongsWilliam.AddMusic(musicas[1458]);
        SongsWilliam.AddMusic(musicas[1842]);
        SongsWilliam.AddMusic(musicas[1422]);
        SongsWilliam.AddMusic(musicas[1039]);
        SongsWilliam.AddMusic(musicas[89]);
        SongsWilliam.AddMusic(musicas[128]);

        SongsWilliam.ViewSongs();


    }
	catch (Exception ex)
	{
        Console.WriteLine($"Ocorreu uma falha na requisição: {ex}");
    }

}