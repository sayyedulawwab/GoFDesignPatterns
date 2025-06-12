namespace Composite.Bad;
public class User
{
    public List<string> Permissions { get; set; } = new();

    public bool HasPermission(string permission)
    {
        return Permissions.Contains(permission, StringComparer.OrdinalIgnoreCase);
    }
}
