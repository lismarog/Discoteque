using Discoteque.Data.Models;

namespace Discoteque.Business.IServices;

public interface IArtistService
{
    Task<IEnumerable<Artist>>GetArtistAsync();
    Task<Artist>GetById(int id);
    Task<Artist> UpdateArtist(Artist artist);
    Task<IEnumerable<Artist>>CreateArtist(Artist artist);
}