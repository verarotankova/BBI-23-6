﻿using System;
// 2 уровень 3 задача
//struct Athlet
//{
//    public string _surname { get; private set; }
//    public double _attempt1 { get; private set; }
//    public double _attempt2 { get; private set; }
//    public double _attempt3 { get; private set; }

//    public double Bestresult
//    {
//        get { return Math.Max(Math.Max(_attempt1, _attempt2), _attempt3); }
//    }
//    public Athlet(string surname, double attempt1, double attempt2, double attempt3)
//    {
//        _surname = surname; _attempt1 = attempt1; _attempt2 = attempt2; _attempt3 = attempt3;
//    }



//}
//abstract class Discipline
//{
//    public string _namediscipline { get; private set; }

//    protected Discipline(string namediscipline)
//    {
//        _namediscipline = namediscipline;
//    }
//}

//class Longjump : Discipline
//{
//    public Longjump() : base("Прыжки в длину")
//    {
//    }
//}

//class Highjump : Discipline
//{
//    public Highjump() : base("Прыжки в высоту")
//    {
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        Athlet[] results = new Athlet[5];
//        results[0] = new Athlet("Пупкин", 5.5, 4.3, 6.5);
//        results[1] = new Athlet("Котиков", 3.4, 4.4, 4.4);
//        results[2] = new Athlet("Козлов", 4.0, 5.1, 4.9);
//        results[3] = new Athlet("Волков", 5.0, 5.0, 5.0);
//        results[4] = new Athlet("Рыбкин", 4.1, 3.9, 4.9);
//        Discipline[] disciplines = new Discipline[]
//        {
//            new Longjump(),
//            new Highjump()
//        };

//        Array.Sort(results, (r1, r2) => r2.Bestresult.CompareTo(r1.Bestresult));

//        Console.WriteLine("Итоговый протокол: ");
//        for (int i = 0; i < results.Length; i++)
//        {
//            Console.WriteLine($"{i + 1}. {disciplines[i % 2]._namediscipline}, {results[i]._surname}, {results[i].Bestresult} метров");
//        }
//    }
//}
//1 уровень 1 задача

//public class Athlet
//{
//    public string _surname { get; private set; }
//    public string _society { get; private set; }
//    public double _attempt1 { get; private set; }
//    public double _attempt2 { get; private set; }
//    public bool _disqualified { get; private set; }
//    public Athlet(string surname, string society, double attempt1, double attempt2)
//    {
//        _surname = surname;
//        _society = society;
//        _attempt1 = attempt1;
//        _attempt2 = attempt2;
//        _disqualified = false;
//    }
//    public void Disqualify()
//    {
//        _disqualified = true;
//    }
//    public double SumAttempt
//    {
//        get { return _attempt1 + _attempt2; }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Athlet[] results = new Athlet[5];
//        results[0] = new Athlet("Пупкин", "А", 5.5, 4.3);
//        results[1] = new Athlet("Котиков", "Б", 3.4, 3.0);
//        results[2] = new Athlet("Волков", "В", 5.0, 5.0);
//        results[3] = new Athlet("Козлов", "Г", 3.9, 4.8);
//        results[4] = new Athlet("Рыбкин", "Д", 5.1, 5.3);
//        results[2].Disqualify();

//        Array.Sort(results, (r1, r2) => r2.SumAttempt.CompareTo(r1.SumAttempt));

//        Console.WriteLine("Итоговый протокол:");
//        for (int i = 0; i < results.Length; i++)
//        {
//            if (results[i]._disqualified != true)
//            {
//                Console.WriteLine($"{i + 1}. {results[i]._surname}, {results[i]._society}, {results[i]._attempt1} метров, {results[i]._attempt2} метров");
//            }
//        }
//    }
//}
//3 уровень 3 задача
//class Team
//{
//    protected string _name;
//    private double[] _results = new double[6];
//    private int _count = 0;
//    private int _bestteam = 0;
//    public Team(string name, double[] results)
//    {
//        _name = name;
//        _results = results;
//        for (int i = 0; i < _results.Length; i++)
//        {
//            for (int j = 1; j <= 5; j++)
//            {
//                if (results[i] == j)
//                {
//                    _count += 6 - j;
//                }
//            }
//            if (results[i] == 1)
//            {
//                _bestteam = 1;
//            }
//        }
//    }
//    public int bestteam { get { return _bestteam; } }
//    public int count { get { return _count; } }
//    public void Print(string text = "Некорректная информация")
//    {
//        if (_name != null)
//        {
//            text = _name + " " + _count;
//        }
//        Console.WriteLine(text);
//    }
//}
//class WomanTeam : Team
//{
//    public WomanTeam(string name, double[] results) : base(name, results)
//    {
//        _name = "женская команда: " + name;
//    }
//}
//class ManTeam : Team
//{
//    public ManTeam(string name, double[] results) : base(name, results)
//    {
//        _name = "мужская команда: " + name;
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        WomanTeam[] womanTeam = new WomanTeam[3];
//        double[] result_woman = new double[6];
//        string name_woman;
//        for (int i = 0; i < womanTeam.Length; i++)
//        {
//            Console.WriteLine("Введите название женской команды:");
//            name_woman = Console.ReadLine();
//            Console.WriteLine("Введите места участниц команды:");
//            for (int j = 0; j < 6; j++)
//            {
//                result_woman[j] = double.Parse(Console.ReadLine());
//            }
//            womanTeam[i] = new WomanTeam(name_woman, result_woman);
//        }
//        ManTeam[] manteam = new ManTeam[3];
//        double[] results_man = new double[6];
//        string name_man;
//        for (int i = 0; i < manteam.Length; i++)
//        {
//            Console.WriteLine("Введите название мужской команды:");
//            name_man = Console.ReadLine();
//            Console.WriteLine("Введите места участников команды:");
//            for (int j = 0; j < 6; j++)
//            {
//                results_man[j] = double.Parse(Console.ReadLine());
//            }
//            manteam[i] = new ManTeam(name_man, results_man);
//        }
//        Team[] team = new Team[6];
//        for (int i = 0; i < manteam.Length; i++)
//        {
//            team[i] = manteam[i];
//        }
//        for (int i = 0; i < womanTeam.Length; i++)
//        {
//            team[i + 3] = womanTeam[i];        
//        }
//        for (int i = 0; i < team.Length; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                if (team[j].count < team[j + 1].count || (team[j].count == team[j + 1].count && team[j].bestteam < team[j + 1].bestteam))
//                {
//                    Team t = team[j];
//                    team[j] = team[j + 1];
//                    team[j + 1] = t;
//                }
//            }
//        }
//        Console.Write("Победитель - ");
//        team[0].Print();
//        Console.ReadKey();
//    }
//}