namespace Interpreter.Refactored;
public class UserFilterInterpreter
{
    public IExpression Parse(string expression)
    {
        // This is a very simple parser for demonstration.
        // Supports expressions like:
        // "age > 18 AND country == US"
        // "status == Active OR points > 1000"

        if (expression.Contains(" AND "))
        {
            var parts = expression.Split(" AND ");
            return new AndExpression(Parse(parts[0]), Parse(parts[1]));
        }
        else if (expression.Contains(" OR "))
        {
            var parts = expression.Split(" OR ");
            return new OrExpression(Parse(parts[0]), Parse(parts[1]));
        }
        else
        {
            // Terminal expression: e.g. "age > 18", "country == US"
            var tokens = expression.Split(' ');
            return new TerminalExpression(tokens[0], tokens[1], tokens[2]);
        }
    }
}
