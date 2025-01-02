namespace CmoviesDAL.Data.Entities;

public class Series :BaseEntity {
	
	public string Title {get;set;} =String.Empty;
	
	public string Slug {get;set;} =String.Empty;
	
	public DateTime UploadDate {get;set;}
	
	public int NumberOfSeasons {get;set;}
	
	public List<Season> Seasons {get;set;}=new();
	
	public List<Comment> Comments {get;set;}=new();
	
	public Details Details {get;set;} 
	
	
	
	
	
	
	
	
	
	
	
}