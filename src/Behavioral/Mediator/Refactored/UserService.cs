using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Refactored;
public class UserService : IService
{
    private IMediator? _mediator;

    public void SetMediator(IMediator mediator)
    {
        _mediator = mediator;
    }

    public void CreateUser(string username)
    {
        Console.WriteLine($"User '{username}' created.");
        _mediator?.Notify(this, "UserCreated", username);
    }
}