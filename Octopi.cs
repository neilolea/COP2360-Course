using System;
class Octopus
{
    public string name;
    public int Age = 2;
    public string Color = "purple";
    static readonly int legs = 8;

    public void Swim()
    {
        Console.WriteLine($"{name} the {Color} octopus is now swimming");
    }
}

class Program
{
    static void Main()
    {
        Octopus[] myOctopuses = new Octopus[3];

        myOctopuses[0] = new Octopus();
        myOctopuses[0].name = "Steven";
        myOctopuses[0].Color = "red";

        myOctopuses[1] = new Octopus();
        myOctopuses[1].name = "Ocean";
        myOctopuses[1].Age = 5;

        myOctopuses[2] = new Octopus();
        myOctopuses[2].name = "Todd";
        myOctopuses[2].Color = "blue";

        for (int i = 0; i < myOctopuses.Length; i++)
        {
            Console.WriteLine($"{myOctopuses[i].name} is {myOctopuses[i].Age} years old");
            myOctopuses[i].Swim();
        }

        Console.ReadKey();
    }
}