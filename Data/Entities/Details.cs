namespace CmoviesDAL.Data.Entities;


public class Details : BaseEntity{
	
	public int SeriesId {get;set;}
	
	public int MovieId {get;set;}
	
	public DateTime ReleaseDate {get;set;}
	
	public double Duration {get;set;}
	
	public string Country {get;set;} =String.Empty;
	
	public string Description {get;set;} =String.Empty;
	
	public double Imdb {get;set;}
	
	public string PosterUrl {get;set;} =String.Empty;
	
	public int Likes {get;set;}
	
	public List<Cast>  Casts {get;set;} =new();
	
	public List<Genre> Genres {get;set;} =new();
	
	
	
	
	
	
	
}