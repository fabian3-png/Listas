using System;

class Producto
{
    public string Nombre {get; set;}
    public int Stock {get; set;}
    
    public Producto (string nombre, int stock)
    {
        Nombre= nombre;
        Stock= stock;
    }
    
}

class Program
{
    static void Main()
    {
    Producto p1 = new Producto("Mouse", 10);
     Producto p2 = new Producto("Teclado", 5);
     
     Console.WriteLine(p1. Nombre + "-" + p1. Stock);
    Console.WriteLine(p2. Nombre + "-" + p2. Stock);
    
    }
}
