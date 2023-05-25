using ServiceStack.DataAnnotations;

namespace MyApp.ServiceModel.Types;

public class Contact 
{
    public int Id { get; set; }
    public string UserAuthId { get; set; } = default!;
    public Title Title { get; set; }
    public string? Name { get; set; }
    public string? Color { get; set; }
    public FilmGenre? FavoriteGenre { get; set; }
    public int Age { get; set; }
}

public enum Title
{
    [Description("Mr.")] Mr,
    [Description("Mrs.")] Mrs,
    [Description("Miss.")] Miss
}

public enum FilmGenre
{
    Action,
    Adventure,
    Comedy,
    Drama,
}
