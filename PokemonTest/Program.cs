using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonRunLibrary;

namespace PokemonTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int number1 = int.Parse(args[0]);
            int number2 = int.Parse(args[1]);
            Pokemon pokemon1 = PokemonFactory.Create(1);
            Pokemon pokemon2 = PokemonFactory.Create(2);
        }
    }
}