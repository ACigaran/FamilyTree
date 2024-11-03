namespace Library;

using System.Collections.Generic;
using System.Collections.ObjectModel;

public class Node
{
    private int number;
    public Person personaNodo;

    private List<Node> children = new List<Node>();

    public int Number {
        get
        {
            return this.number;
        }
    }
    
    public ReadOnlyCollection<Node> Children {
        get
        {
            return this.children.AsReadOnly();
        }
    }

    public Node(int number, Person persona = null)
    {
        this.number = number;
        this.personaNodo = persona;
    }

    public string nombrePersonaNodo()
    {
        return personaNodo.Name;
    }
    public void AddChildren(Node n)
    {
        this.children.Add(n);
    }
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
        foreach (var item in this.children)
        {
            item.Accept(visitor);
        }
    }
}
