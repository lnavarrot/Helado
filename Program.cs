/*
Autor: Luisa Navarro
Descripción: Aplicacion de estructura selectiva multiple.
*/

using System;
internal class Program
{   
    private static double Main(string[] args)
    {
        int compra;
        string tipo;
        Console.WriteLine("Ingrese el monto de compra");
        compra = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe el Tipo de Cliente");
        tipo = Console.ReadLine();

        switch(tipo) 
        {
			case "A":
                compra - compra * 0.10;
                break;
			case "B":
                compra - (compra * 0.15);
                break;
            case "C":
                compra - (compra * 0.20);
                break;
            default:
                compra = 0;
                break;
        }
        Console.WriteLine("Total a pagar  " + compra);
    }
}
