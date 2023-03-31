using Clase3.Models;
namespace Clase3.Services;

public static class MovieServices
{
    static List<Movie> Movies { get; set; }

    static MovieServices()
    {
        Movies = new List<Movie>{
            new Movie { Name="Back to the Future", Code="BTF", Category="SciFi", Minutes=110 },
            new Movie { Name = "Avatar", Code = "AVT", Category = "SciFi", Minutes = 500},
            new Movie { Name="Hannibal", Code="HNL", Category="Terror", Minutes=110 }
    };
    }

    public static List<Movie> GetAll() => Movies;

}