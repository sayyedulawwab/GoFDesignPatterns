namespace Interpreter.Refactored;
public class TerminalExpression : IExpression
{
    private readonly string _property;
    private readonly string _operation;
    private readonly string _value;

    public TerminalExpression(string property, string operation, string value)
    {
        _property = property;
        _operation = operation;
        _value = value;
    }

    public bool Interpret(User user)
    {
        object propValue = _property.ToLower() switch
        {
            "age" => user.Age,
            "country" => user.Country,
            "status" => user.Status,
            "points" => user.Points,
            _ => null
        };

        if (propValue == null) return false;

        return _operation switch
        {
            ">" => Convert.ToInt32(propValue) > int.Parse(_value),
            "==" => propValue.ToString() == _value,
            _ => false
        };
    }
}
