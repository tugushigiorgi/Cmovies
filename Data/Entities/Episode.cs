using CmoviesDAL.Data.Entities;

namespace CmoviesDAL.Data.Entities;


public class Episode :BaseEntity{
	
	public int SeasonId {get;set;}
	
	public string Title {get;set;}=String.Empty;
	
	public int EpisodeNumber {get;set;}
	
	public List<Media> Medias {get;set;}
	
	
	
	
	
	
	
}