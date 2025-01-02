using Cmovies.Data.Data;
using CmoviesDAL.Data.Entities;
using CmoviesDAL.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CmoviesDAL.Data.Repository;

public class DetailsRepository : IDetailsRepository
{
    private  CmovieDbContext _context;

    public DetailsRepository(CmovieDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Details>> GetAllAsync()
    {
        return await _context.Details.ToListAsync();
    }

    public async Task<Details?> GetByIdAsync(int id)
    {
        return await _context.Details.SingleOrDefaultAsync(details=>details.Id == id);
    }

    public async Task AddAsync(Details entity)
    {
        await   _context.Details.AddAsync(entity);
    }

    public void Delete(Details entity)
    {
        _context.Details.Remove(entity);
    }

    public async Task DeleteByIdAsync(int id)
    {
        var detailsToDelete = await GetByIdAsync(id);
        if(detailsToDelete!=null)	_context.Details.Remove(detailsToDelete);
    }

    public void Update(Details entity)
    {
        _context.Details.Update(entity);
    }
}