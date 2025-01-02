using Cmovies.Data.Data;
using CmoviesDAL.Data.Entities;
using CmoviesDAL.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CmoviesDAL.Data.Repository;

public class PaymentRepository :  IPaymentRepository
{
    private  CmovieDbContext _context;

    public PaymentRepository(CmovieDbContext context)
    {
        _context = context;
    }
    
    
    public async Task<IEnumerable<Payment>> GetAllAsync()
    {
        return await _context.Payments.ToListAsync();
    }

    public async Task<Payment?> GetByIdAsync(int id)
    {
        return await _context.Payments.SingleOrDefaultAsync(payment=>payment.Id == id);
    }

    public async Task AddAsync(Payment entity)
    {
        await   _context.Payments.AddAsync(entity);
    }

    public void Delete(Payment entity)
    {
        _context.Payments.Remove(entity);
    }

    public async Task DeleteByIdAsync(int id)
    {
        var paymentToDelete = await GetByIdAsync(id);
        if(paymentToDelete!=null)	_context.Payments.Remove(paymentToDelete);;
    }

    public void Update(Payment entity)
    {
        _context.Payments.Update(entity);
    }
}