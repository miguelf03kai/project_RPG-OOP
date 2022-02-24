using System;
using project.src.Entities;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninja argus = new Ninja("Argus",50,"Ninja",450,100);
            BlackWizard jill = new BlackWizard("Jill",48,"Black Wizard",440,95);
            Warrior luis = new Warrior("Luis",51,"Warrior",460,95);
            WhiteWizard anna = new WhiteWizard("Anna",48,"White Wizard",430,94);

            Console.WriteLine("------------------------------------------------\n"+
                            argus.ShowAttributes()+"\n\n"+argus.Attack(80)+"\n"+
                            "------------------------------------------------\n"+
                            "\n"+jill.ShowAttributes()+"\n\n"+jill.Attack(88)+"\n"+
                            "------------------------------------------------\n"+
                            "\n"+luis.ShowAttributes()+"\n\n"+luis.Attack(75)+"\n"+
                            "------------------------------------------------\n"+
                            "\n"+anna.ShowAttributes()+"\n\n"+anna.Attack(90)+"\n"+anna.HealSpell(50)+"\n"+
                            "------------------------------------------------");
        }
    }
}
