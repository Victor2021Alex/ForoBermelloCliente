using ConsoleApp1.Models;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //agregarCliente();
        //consultarCliente();
        //consultarCliente();
        //modificarCliente();
        //eliminarClientee();
        consultarClienteFunciones();
    }

    public static void agregarCliente()
    {
        Console.WriteLine("Metodo agregar cliente");
        SchoolContext context = new SchoolContext();
        Cliente std = new Cliente();
        std.nombre = "Victor";
        context.Clientes.Add(std);
        context.SaveChanges();
      
        Console.WriteLine("Codigo: "+ std.ClienteId + " Nombre: "+ std.nombre);

    }

    public static void consultarCliente()
    {
        Console.WriteLine("Metodo consultar cliente");
        SchoolContext context = new SchoolContext();
        List<Cliente> listClientes= context.Clientes.ToList() ;

        foreach (var item in listClientes)
        {
            Console.WriteLine("Codigo: " + item.ClienteId + " Nombre: " + item.nombre);
        }
        
    }

    public static void consultarCliente2()
    {
        Console.WriteLine("Metodo consultar estudiante por Id");
        SchoolContext context = new SchoolContext();
        Cliente std = new Cliente();
        std = context.Clientes.Find(1);

       Console.WriteLine("Codigo: " + std.ClienteId + " Nombre: " + std.nombre);
      
    }

    public static void modificarCliente()
    {
        Console.WriteLine("Metodo modificar Cliente");
        SchoolContext context = new SchoolContext();
        Cliente std = new Cliente();
        std = context.Clientes.Find(1);

        std.nombre = "";
        context.SaveChanges();
        Console.WriteLine("Codigo: " + std.ClienteId + " Nombre: " + std.nombre);

    }

    public static void eliminarCliente()
    {
        Console.WriteLine("Metodo eliminar estudiante");
        SchoolContext context = new SchoolContext();
        Cliente std = new Cliente();
        std = context.Clientes.Find(2);
        context.Remove(std);
        context.SaveChanges();
        Console.WriteLine("Codigo: " + std.ClienteId + " Nombre: " + std.nombre);

    }
    public static void consultarClienteFunciones()
    {
        Console.WriteLine("Metodo consultar clientes con el uso de funciones");
        SchoolContext context = new SchoolContext();
        List<Cliente> listClientes;

        Console.WriteLine("Cantidad de registros: " + context.Clientes.Count());
        Cliente std = context.Clientes.First();

        Console.WriteLine("Primer elemento de la tabla:" +  std.ClienteId + "-" +std.nombre);


        listClientes = context.Clientes.Where(s => s.nombre.StartsWith("V")).ToList();
        
        
        foreach (var item in listClientes)
        {
            Console.WriteLine("Codigo: " + item.ClienteId + " Nombre: " + item.nombre);
        }
        

    }
}