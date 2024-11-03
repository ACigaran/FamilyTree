namespace Library;

public class SumVisitor: IVisitor
{
    private int sum = 0;
    private int edadtotal = 0;

    public int Sum
    {
        get
        {
            return this.sum;
        }
    }

    public int EdadTotal
    {
        get
        {
            return this.edadtotal;
        }
    }
    public void Visit(Node node)
    {
        sum += node.Number;
        edadtotal += node.personaNodo.Age;
    }
}
