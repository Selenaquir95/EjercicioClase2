

using Entities;
using System.Data.Common;

public class Program
{
    public static void Main(string[] args)
    {
        //Instancia del Gato

        var myCat = new Cat() { Id = 1, Name= "Misingo"};
        Console.WriteLine("El Id del gato: " + myCat.Id);
        Console.WriteLine("El nombre del gato: " + myCat.Name);
        Console.WriteLine("Ingrese una descripción para el gato");
        myCat.Description = Console.ReadLine();
    }
}
