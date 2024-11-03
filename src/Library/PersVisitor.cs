namespace Library;

public class PersVisitor : IVisitor
{
    private string nomb;

    public string Nomb
    {
        get
        {
            return this.nomb;
        }
    }

    public void Visit(Node node)
    {
        nomb = node.personaNodo.Name;
    }
}