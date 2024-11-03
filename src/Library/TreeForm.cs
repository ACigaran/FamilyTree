using Microsoft.VisualBasic;

namespace Library;

public class TreeForm
{
    private List<string> arbolFamiliar = new List<string>();

    public void AgregarFamiliar(string nombre)
    {
        arbolFamiliar.Add(nombre);
    }

    public void mostrarArbol()
    {
        Console.WriteLine($"    {arbolFamiliar[0]}");
        Console.WriteLine($"    /{Strings.Space(arbolFamiliar[0].Length-2)}\\");
            for (int i = 1; i < arbolFamiliar.Count; i += 2)
            {
                if (i +1 < arbolFamiliar.Count)
                {
                    int space = (i + 1) * 2;
                    Console.WriteLine($"{Strings.Space(space)}{arbolFamiliar[i]}  -   {arbolFamiliar[i + 1]}");
                    Console.WriteLine($"{Strings.Space(space)}/{Strings.Space(arbolFamiliar[i].Length)}\\   /{Strings.Space(arbolFamiliar[i + 1].Length)}\\");
                }
                else
                {
                    int space = (i + 1) * 2;
                    Console.WriteLine($"{Strings.Space(space)}{arbolFamiliar[i]}");
                    Console.WriteLine($"{Strings.Space(space)}/{Strings.Space(arbolFamiliar[i].Length)}\\");
                }
            }
    }
}