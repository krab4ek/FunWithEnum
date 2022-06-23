class Program
{
    static void Main(string[] args)
    {
        #region C# Enum type
        Console.Write("*****Praktika with Enum*****\n");
        EmType emp = EmType.Grunt;
        EmType e2 = EmType.Manager;
        EmType1 e3 = EmType1.VicePresident;
        DayOfWeek day = DayOfWeek.Monday;
        ConsoleColor cc = ConsoleColor.Cyan;
        AskForBonus(emp);
        //выввести тип хранилища для значения перечисления
        Console.WriteLine($"EmType uses a {Enum.GetUnderlyingType(emp.GetType())} for storage");
        //выввести тип хранилища для значения перечисления typeof
        Console.WriteLine($"EmType uses a {Enum.GetUnderlyingType(typeof(EmType1))} for storage");
        //выводит строку
        Console.WriteLine($"emp is a {emp.ToString()}");
        //выводит key/value
        Console.WriteLine($"{emp.ToString()}={(byte)emp}");
        Console.WriteLine($"{emp.ToString()}={Enum.Format(typeof(EmType), emp, "d")}");
        //EvaluateEnum(emp);
        EvaluateEnum(e2);
        EvaluateEnum(e3);
        EvaluateEnum(day);
        EvaluateEnum(cc);
        Console.ReadLine();
    }
    enum EmType : byte
    {
        Manager,        //=0
        Grunt,          //=1
        Contractor,     //=2
        VicePresident   //=3
    }
    enum EmType1
    {
        //Нумерация начинается со значения 102
        Manager = 102,
        Grunt,          //=103
        Contractor,     //=104
        VicePresident   //=105
    }

    enum EmType2 : byte
    {
        Manager = 102,
        Grunt = 1,
        Contractor = 78,
        VicePresident = 5
    }
    #endregion

    static void AskForBonus(EmType em)
    {
        switch (em)
        {
            case EmType.Manager:
                Console.WriteLine("How about stock options instead?");
                break;
            case EmType.Grunt:
                Console.WriteLine("You have got to  be kidding...");
                break;
            case EmType.Contractor:
                Console.WriteLine("You already get enough cash...");
                break;
            case EmType.VicePresident:
                Console.WriteLine("VERY GOOD, Sir!");
                break;
        }

    }

    static void EvaluateEnum(System.Enum e)
    {
        Console.WriteLine($"=> Information about {e.GetType().Name}");
        Console.WriteLine($"Underlying storage type: " +
            $"{Enum.GetUnderlyingType(e.GetType())}");
        Array enumData = Enum.GetValues(e.GetType());
        Console.WriteLine($"This enum has {enumData.Length} members.");
        //Вывести строковое имя и ассоциированное значение,
        //используя флаг формата D
        for (int i = 0; i < enumData.Length; i++)
        {
            Console.WriteLine($"\tName:{enumData.GetValue(i)}," +
                $" \tValue:{enumData.GetValue(i):D}");
        }
        Console.WriteLine();
    }
}

