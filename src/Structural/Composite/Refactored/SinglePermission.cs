namespace Composite.Refactored;
public class SinglePermission : IPermission
{
    private readonly string _permission;

    public SinglePermission(string permission)
    {
        _permission = permission;
    }

    public bool HasPermission(string permission)
    {
        return _permission.Equals(permission, StringComparison.OrdinalIgnoreCase);
    }
}
