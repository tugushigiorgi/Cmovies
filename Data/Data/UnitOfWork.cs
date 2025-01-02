using CmoviesDAL.Data.Interfaces;
using CmoviesDAL.Data.Repository;

namespace Cmovies.Data.Data;

public class UnitOfWork :IUnitOfWork
{
    
    private readonly CmovieDbContext _context;
    public UnitOfWork(CmovieDbContext context)
    {
        _context = context;
    }
    
    
    public ICastRepository CastRepository => new CastRepository( _context);
    public ICommentRepository CommentRepository => new CommentRepository(_context);
    public IDetailsRepository DetailsRepository => new DetailsRepository(_context);
    public IEpisodeRepository EpisodeRepository => new EpisodeRepository(_context);
    public IGenreRepository GenreRepository => new GenreRepository(_context);
    public IMediaRepository MediaRepository => new MediaRepository(_context);
    public IMoviesRepository MoviesRepository => new MovieRepository(_context);
    public IPaymentRepository PaymentRepository => new PaymentRepository(_context);
    public ISeasonRepository SeasonRepository => new SeasonRepository(_context);
    public ISeriesRepository SeriesRepository => new SeriesRepository(_context);
    public ISubscriptionRepository SubscriptionRepository => new SubscriptionRepository(_context);
    public IUserRepository UserRepository => new UserRepository(_context);
    public Task SaveAsync()
    {
        return _context.SaveChangesAsync();
    }
}