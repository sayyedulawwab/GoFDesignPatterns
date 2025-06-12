namespace Composite.Refactored;
public class User
{
    public IPermission Permissions { get; }

    public User(IPermission permissions)
    {
        Permissions = permissions;
    }

    public bool HasPermission(string permission)
    {
        return Permissions.HasPermission(permission);
    }
}
