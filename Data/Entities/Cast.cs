namespace CmoviesDAL.Data.Entities;

public class Cast:BaseEntity{
	
	
	public string Name {get;set;} =String.Empty;
	
	public string SurName {get;set;} =String.Empty;
	
	public string Picture {get;set;} =String.Empty;
	
	public int Birthday  {get;set;}
	
	public string Description {get;set;} =String.Empty;
	
	
	
	
	
	
}