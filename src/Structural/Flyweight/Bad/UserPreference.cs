namespace Flyweight.Bad;
public class UserPreference
{
    public string Theme { get; set; }
    public string Language { get; set; }

    public UserPreference(string theme, string language)
    {
        Theme = theme;
        Language = language;
    }
}
