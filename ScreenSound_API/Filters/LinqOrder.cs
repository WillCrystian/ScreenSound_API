using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound_API.Modelos;

namespace ScreenSound_API.Filters
{
    internal class LinqOrder
    {
        public static void ViewListSortedArtists(List<Musica> musicas)
        {
            var artistSorted = musicas.OrderBy(a => a.Artista).Select(a=> a.Artista).Distinct().ToList();
            foreach (var artist in artistSorted)
            {
                Console.WriteLine($"- {artist}");
            }
        }
    }
}
