using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(1, new Person("Agustin", 24));
            Node n2 = new Node(2, new Person("Rodrigo", 19));
            Node n3 = new Node(3, new Person("Jairo", 22));
            Node n4 = new Node(4, new Person("Adolfo", 19));
            Node n5 = new Node(5, new Person("Matias", 24));
            Node n6 = new Node(6, new Person("Brahian", 28));
            Node n7 = new Node(7, new Person("Esteban", 24));

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);
            
            // imprimir arbol
            TreeForm arbol = new TreeForm();
            SumVisitor visitor = new SumVisitor();
            
            arbol.AgregarFamiliar(n1.personaNodo.Name);
            arbol.AgregarFamiliar(n2.personaNodo.Name);
            arbol.AgregarFamiliar(n3.personaNodo.Name);
            arbol.AgregarFamiliar(n4.personaNodo.Name);
            arbol.AgregarFamiliar(n5.personaNodo.Name);
            arbol.AgregarFamiliar(n6.personaNodo.Name);
            arbol.AgregarFamiliar(n7.personaNodo.Name);
            
            
            // visitar el árbol aquí
            
            n1.Accept(visitor);
            Console.WriteLine("\nEsta es la forma de su arbol familiar:");
            arbol.mostrarArbol();
            Console.WriteLine($"\nLa edad total de toda la familia es de: {visitor.EdadTotal}\n");
        }
    }
}
