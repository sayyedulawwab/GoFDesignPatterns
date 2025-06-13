namespace Interpreter.Refactored;
public class OrExpression : IExpression
{
    private readonly IExpression _left;
    private readonly IExpression _right;

    public OrExpression(IExpression left, IExpression right)
    {
        _left = left;
        _right = right;
    }

    public bool Interpret(User user)
    {
        return _left.Interpret(user) || _right.Interpret(user);
    }
}
