using System;
using app.src.Entities;
using App.src.Entities;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Knigth arus = new Knigth("Arus", 23, "Kninght");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
            Ninja wedge = new Ninja("Wedge", 42,"Ninja");
            BlackWizard topapa = new BlackWizard("Topapa", 42, "Bkack Wizard");

            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack(7));
            Console.WriteLine(wedge.Attack());
            Console.WriteLine(topapa.Attack());
        }
    }
}
