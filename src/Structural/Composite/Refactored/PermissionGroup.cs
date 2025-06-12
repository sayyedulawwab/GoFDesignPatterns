namespace Composite.Refactored;
public class PermissionGroup : IPermission
{
    private readonly List<IPermission> _permissions = new();

    public void Add(IPermission permission)
    {
        _permissions.Add(permission);
    }

    public bool HasPermission(string permission)
    {
        return _permissions.Any(p => p.HasPermission(permission));
    }
}
