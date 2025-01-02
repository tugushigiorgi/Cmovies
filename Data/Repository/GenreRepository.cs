using Cmovies.Data.Data;
using CmoviesDAL.Data.Entities;
using CmoviesDAL.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CmoviesDAL.Data.Repository;

public class GenreRepository : IGenreRepository
{
    
    private  CmovieDbContext _context;

    public GenreRepository(CmovieDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Genre>> GetAllAsync()
    {
        return await _context.Genres.ToListAsync();
    }

    public async Task<Genre?> GetByIdAsync(int id)
    {
        return await _context.Genres.SingleOrDefaultAsync(genre=>genre.Id == id);
    }

    public async Task AddAsync(Genre entity)
    {
        await   _context.Genres.AddAsync(entity);
    }

    public void Delete(Genre entity)
    {
        _context.Genres.Remove(entity);
    }

    public async Task DeleteByIdAsync(int id)
    {
        var genreToDelete = await GetByIdAsync(id);
        if(genreToDelete!=null)	_context.Genres.Remove(genreToDelete);
    }

    public void Update(Genre entity)
    {
        _context.Genres.Update(entity);
    }
}