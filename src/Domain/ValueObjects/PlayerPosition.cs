using Domain.Common;

namespace Domain.ValueObjects;
public class PlayerPosition : ValueObject
{
    static PlayerPosition() { }

    public string Position { get; private set; } = "Forward";
    

    protected override IEnumerable<object> GetEqualityComponents()
    {
        throw new NotImplementedException();
    }
}