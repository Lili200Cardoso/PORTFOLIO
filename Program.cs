using System;
using projetoCarrefour.src.Entities;

namespace projetoCarrefour{

    class Program{
        static void Main(string[] args){

            Knight arus = new Knight("Arus", 23, "knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
            Ninja wedge = new Ninja("Wedge", 23, "Ninja");
            Wizard topasa = new Wizard("Topasa", 23, "Black Wizard");

            
            Console.WriteLine(arus.Attack(2));
            Console.WriteLine(wizard.Attack(7));
            Console.WriteLine(wedge.Attack(1));
            Console.WriteLine(topasa.Attack(3));
            
        }   
    }
}

