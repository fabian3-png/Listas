using System;
using System.Collections.Generic;

class Producto
{
 public string Nombre {get; set;}   
}

class Program
{
    static void Main()
    {
        List<Producto> productos = new List<Producto>();
        
        productos.Add(new Producto{Nombre= "Mouse"});
        productos.Add(new Producto{Nombre= "Teclado"});
        productos.Add(new Producto{Nombre= "Monitor"});
        productos.Add(new Producto{Nombre= "Camara"});
        productos.Add(new Producto{Nombre= "Mousepad"});
        productos.Add(new Producto{Nombre= "Audifonos"});
       
    
        
        Console.WriteLine("Lista:");
        foreach (var p in productos)
        {
            Console.WriteLine(p. Nombre);
        }
    }
}
