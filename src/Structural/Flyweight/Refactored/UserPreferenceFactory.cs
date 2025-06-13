namespace Flyweight.Refactored;
public class UserPreferenceFactory
{
    private readonly Dictionary<string, UserPreference> _preferences = new();

    public UserPreference GetPreference(string theme, string language)
    {
        var key = $"{theme}:{language}";
        if (!_preferences.ContainsKey(key))
        {
            _preferences[key] = new UserPreference(theme, language);
        }

        return _preferences[key];
    }
}
