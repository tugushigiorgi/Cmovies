namespace CmoviesDAL.Data.Entities;

public class User :BaseEntity
{
    public string Username { get; set; }
    
    public string Surname { get; set; }
    
    public string Picture { get; set; }
    
    public List<Payment> Payments { get; set; }
    
}