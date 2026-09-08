string namestring;
string characterClass;
string weapon;
System.Console.WriteLine("введите имя персонажа:");
namestring = System.Console.ReadLine();

System.Console.WriteLine("Введите класс (Воин, Маг, Лучник):");
characterClass = System.Console.ReadLine();

System.Console.WriteLine("Введите оружие:");
weapon = System.Console.ReadLine();

System.Console.WriteLine($"Имя: {namestring}");
System.Console.WriteLine($"класс: {characterClass}");
System.Console.WriteLine($"оружие: {weapon}");
