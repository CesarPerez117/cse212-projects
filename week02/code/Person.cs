public class Person
{
    public readonly string Name;
    public int Turns { get; set; }
    public bool IsInfinite;

    internal Person(string name, int turns)
    {
        Name = name;
        Turns = turns;

        // Boolean used to determine in a if statement if they have infinite turns.
        // this will take it from every person who has 0 or negative turns.
        if (turns == 0 || turns < 0)
        {
            IsInfinite = true;
        }
        else
        {
            IsInfinite = false;
        }
    }

    public override string ToString()
    {
        return Turns <= 0 ? $"({Name}:Forever)" : $"({Name}:{Turns})";
    }
}