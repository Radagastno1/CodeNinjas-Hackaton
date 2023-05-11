using CORE.Entities;
using CORE.Interfaces;

namespace INFRASTRUCTURE.Repositories;

public class ChallengeRepository : IRepository<CORE.Entities.Challenge>
{
    private readonly INFRASTRUCTURE.Data.SevenGoContext _sevenGoContext;
    public ChallengeRepository(INFRASTRUCTURE.Data.SevenGoContext sevenGoContext)
    {
        _sevenGoContext = sevenGoContext;
    }
    public async Task<Challenge> Create(Challenge obj)
    {
         try
        {
            await _sevenGoContext .AddAsync(movie);
            await _sevenGoContext.SaveChangesAsync();
            var recentlyAddedMovie = await _trananDbContext.Movies
                .OrderByDescending(m => m.MovieId)
                .FirstOrDefaultAsync();
            return recentlyAddedMovie;
        }
        catch (Exception e)
        {
            return null;
        }
    }

    public void DeleteById(int id)
    {
        throw new NotImplementedException();
    }

    public List<Challenge> Get()
    {
        throw new NotImplementedException();
    }

    public Challenge GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Challenge Update(Challenge obj)
    {
        throw new NotImplementedException();
    }
}