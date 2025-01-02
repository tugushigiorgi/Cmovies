namespace CmoviesDAL.Data.Entities;


public class Media:BaseEntity{
	
	
	public string Language {get;set;} =String.Empty;
	
	public int MovieId  {get;set;}
	
	public int EpisodeID {get;set;}
	
	public double Duration {get;set;}
	
	public string Url {get;set;} =String.Empty;
	
	public string Format {get;set;} =String.Empty;
	
	public int Quality {get;set;}
	
	
	
	
}