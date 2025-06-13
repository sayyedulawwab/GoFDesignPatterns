namespace Interpreter.Bad;

public class UserFilterService
{
    public bool Filter(User user, string condition)
    {
        // Naive parsing and hardcoded checks
        if (condition == "age > 18 AND country == US")
        {
            return user.Age > 18 && user.Country == "US";
        }
        else if (condition == "status == Active OR points > 1000")
        {
            return user.Status == "Active" || user.Points > 1000;
        }

        // No extensibility
        return false;
    }
}
