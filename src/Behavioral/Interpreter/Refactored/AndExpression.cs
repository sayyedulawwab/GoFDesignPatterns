namespace Interpreter.Refactored;
public class AndExpression : IExpression
{
    private readonly IExpression _left;
    private readonly IExpression _right;

    public AndExpression(IExpression left, IExpression right)
    {
        _left = left;
        _right = right;
    }

    public bool Interpret(User user)
    {
        return _left.Interpret(user) && _right.Interpret(user);
    }
}
