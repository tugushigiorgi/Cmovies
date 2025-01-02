using Cmovies.Data.Data;
using CmoviesDAL.Data.Entities;
using CmoviesDAL.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CmoviesDAL.Data.Repository;

public class SubscriptionRepository :ISubscriptionRepository
{
    
    private  CmovieDbContext _context;

    public SubscriptionRepository(CmovieDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Subscription>> GetAllAsync()
    {
        return await _context.Subscriptions.ToListAsync();
    }

    public async Task<Subscription?> GetByIdAsync(int id)
    {
        return await _context.Subscriptions.SingleOrDefaultAsync(subscription=>subscription.Id == id);
    }

    public async Task AddAsync(Subscription entity)
    {
        await   _context.Subscriptions.AddAsync(entity); 
    }

    public void Delete(Subscription entity)
    {
        _context.Subscriptions.Remove(entity);
    }

    public async Task DeleteByIdAsync(int id)
    {
        var subscriptionToDelete = await GetByIdAsync(id);
        if(subscriptionToDelete!=null)	_context.Subscriptions.Remove(subscriptionToDelete);
    }

    public void Update(Subscription entity)
    {
        _context.Subscriptions.Update(entity);
    }
}