namespace CmoviesDAL.Data.Interfaces;

public interface IUnitOfWork
{
    
    ICastRepository CastRepository { get; }
    ICommentRepository CommentRepository { get; }
    IDetailsRepository DetailsRepository { get; }
    IEpisodeRepository EpisodeRepository { get; }
    IGenreRepository GenreRepository { get; }
    IMediaRepository MediaRepository { get; }
    IMoviesRepository MoviesRepository { get; }
    IPaymentRepository PaymentRepository { get; }
    ISeasonRepository SeasonRepository { get; }
    ISeriesRepository SeriesRepository { get; }
    ISubscriptionRepository SubscriptionRepository { get; }
    IUserRepository UserRepository { get; }
    Task SaveAsync();
}