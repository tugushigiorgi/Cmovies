namespace CmoviesDAL.Data.Entities;


public class Season :BaseEntity{
	
	public int NumberOfEpisodes {get;set;}
	
	public string Title {get;set;} =String.Empty;
	
	public int SeasonNumber {get;set;}
	
	public int SeriesId {get;set;}
	
	public Series series {get;set;}
	
	public List<Episode> Episodes {get;set;}=new();
	
	
	
	
	
	
	
}