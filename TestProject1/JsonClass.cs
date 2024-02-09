
public class Rootobject
{
    public int numFound { get; set; }
    public int start { get; set; }
    public bool numFoundExact { get; set; }
    public Doc[] docs { get; set; }
    public int num_found { get; set; }
    public string q { get; set; }
    public object offset { get; set; }
}

public class Doc
{
    public string[] author_name { get; set; }
    public int first_publish_year { get; set; }
    public string title { get; set; }
    public string[] subject { get; set; }
}
