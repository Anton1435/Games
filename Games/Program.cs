using System;
class Program
{
    static void SelectRace()
    {
        string[] namesRace = {"Люди", "Эльфы", "Орки","Гоблины", "Гномы"};
        for (int i = 0; i < namesRace.Length -1; i++)
        {
            Console.Write(i+1 + " - " + namesRace[i] + ", ");
        }
        Console.WriteLine(namesRace.Length + " - " + namesRace[namesRace.Length-1] + ". ");
    }
    static void Main(string[]arg)
    {
     
      SelectRace();

    }
}