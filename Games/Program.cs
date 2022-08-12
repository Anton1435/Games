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
        Console.WriteLine("Выберите вашу расу? ");
        int numberRase = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваша раса: " + namesRace[ numberRase-1]);
    }
        static void SelectSex()
    {
        string[] namesSex = {"Мужской", "Женский"};
        for (int i = 0; i < namesSex.Length -1; i++)
        {
            Console.Write(i+1 + " - " + namesSex[i] + ", ");
        }
        Console.WriteLine(namesSex.Length + " - " + namesSex[namesSex.Length-1] + ". ");
        Console.WriteLine("Выберите ваш пол? ");
        int numberSex = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваша пол: " + namesSex[ numberSex-1]);
    }
    static void SelectClass()
    {
        string[] namesClass = {"Войн", "Маг" ,"Разбойник", "Чернокнижник"};
        WriteSelect(namesClass);
        Console.WriteLine("Выберите ваш класс ? ");
        int numberClass = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваша класс : " + namesClass[ numberClass-1]);
    }

    static void WriteSelect(string[] args)      /////функция выбора
    {
        for (int i = 0; i < args.Length -1; i++)
        {
            Console.Write(i+1 + " - " + args[i] + ", ");
        }
        Console.WriteLine(args.Length + " - " + args[args.Length-1] + ". ");
          
    }
   
    static void Main(string[]arg)
    {
     
      SelectRace();
      SelectSex();
      SelectClass();
    }
}