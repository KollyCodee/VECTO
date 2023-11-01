public class Image
{
    public int Id { get; set; }
    public string Path { get; set; }
    public List<Effect> Effects { get; set; }
}

public class Effect
{
    public string Name { get; set; }
    public Dictionary<string, string> Parameters { get; set; }
}