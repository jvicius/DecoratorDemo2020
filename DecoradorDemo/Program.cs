using DecoradorDemo.Models;
using System;
using System.Collections.Generic;

namespace DecoradorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new List<ICafe>
            {
                new CafeAmericano(),
                new CafeExpreso(),
                new LecheDecorador(new CafeAmericano()),
                new LecheDecorador(new CafeExpreso()),
                new ChocolateDecorador(new LecheDecorador(new CafeAmericano())),
                new ChocolateDecorador(new LecheDecorador(new LecheDecorador(new CafeAmericano())))
            };
            
            foreach(var cafe in menu)
            {
                Console.WriteLine($"{cafe.ObtenerDescripcion()}...............${cafe.ObtenerCosto()}");
            }
        }
    }
}
