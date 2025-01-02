using Cmovies.Data.Data;
using CmoviesDAL.Data.Entities;
using CmoviesDAL.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CmoviesDAL.Data.Repository;

public class UserRepository : IUserRepository
{
    private  CmovieDbContext _context;

    public UserRepository(CmovieDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<User>> GetAllAsync()
    {
        return await _context.Users.ToListAsync();
    }

    public async Task<User?> GetByIdAsync(int id)
    {
        return await _context.Users.SingleOrDefaultAsync(user=>user.Id == id);
    }

    public async Task AddAsync(User entity)
    {
        await   _context.Users.AddAsync(entity);
    }

    public void Delete(User entity)
    {
        _context.Users.Remove(entity);
    }

    public async Task DeleteByIdAsync(int id)
    {
        var userToDelete = await GetByIdAsync(id);
        if(userToDelete!=null)	_context.Users.Remove(userToDelete);
    }

    public void Update(User entity)
    {
        _context.Users.Update(entity);
    }
}