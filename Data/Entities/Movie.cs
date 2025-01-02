namespace CmoviesDAL.Data.Entities;



public class Movie :BaseEntity{
	
	
	public string Title {get;set;} =String.Empty;
	
	public string Slug {get;set;} =String.Empty;
	
	public DateTime UploadDate {get;set;}=DateTime.Now;
	
	public List<Media> Medias {get;set;}=new();
	
	//public List<Comment> Comments {get;set;} =new();
	
	public Details Details {get;set;}
	
	
	
	
	
	
}