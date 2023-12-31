using Discoteque.Business.IServices;
using Discoteque.Data.Models;

namespace Discoteque.Business.Services;

public class ArtistService : IArtistService
{

    public async Task<Artist> GetById(int id)
    {
        throw new NotImplementedException();
    }

     async Task<IEnumerable<Artist>> IArtistService.CreateArtist(Artist artist)
    {
        List<Artist> artistsList = new();
        Random random = new();

        Artist newArtist = new()
        {
            Id = random.Next(1, 100),
            Name = artist.Name,
            Label = artist.Label,
            IsOnTour = artist.IsOnTour
        };

        artistsList.Add(newArtist);

        return artistsList;
    }

    public async Task<IEnumerable<Artist>> GetArtistAsync()
    {
        Random random = new();
        List<Artist> artistsLlist = new()
        {
            new Artist() { Id = random.Next(1, 100), Name = "Adele", Label = "Columbia Records", IsOnTour = true },
            new Artist() { Id = random.Next(1, 100), Name = "Paramore", Label = "Warner Music", IsOnTour = false },
            new Artist() { Id = random.Next(1, 100), Name = "Reik", Label = "Sony Music Entertainment", IsOnTour = true },
            new Artist() { Id = random.Next(1, 100), Name = "Dua Lipa", Label = "Warner Records", IsOnTour = false },
            new Artist() { Id = random.Next(1, 100), Name = "J-LO", Label = "Capitol Records", IsOnTour = true }
        };

        return artistsLlist;
    }

    public Task<Artist> UpdateArtist(Artist artist)
    {
        throw new NotImplementedException();
    }

}
