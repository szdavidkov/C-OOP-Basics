public abstract class Monument
{
    private string name;

    public Monument(string name)
    {
        this.name = name;
    }

    public abstract int GetAffinity();

    public override string ToString()
    {
        var monumentType = this.GetType().Name;
        var typeEnd = monumentType.IndexOf("Monument");
        monumentType = monumentType.Insert(typeEnd, " ");

        return $"{monumentType}: {this.name}";
    }
}

