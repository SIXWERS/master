
int hp;
int dmg;


System.Console.WriteLine("Введите базовое здоровье (HP):");
 hp = int.Parse(System.Console.ReadLine());
 int maxhp = hp + 50;
 System.Console.WriteLine("Введите базовый урон:");
dmg = int.Parse(System.Console.ReadLine());
 int critdmg = dmg * 2;
 System.Console.WriteLine($"максимальное здоровье: {maxhp}");
 System.Console.WriteLine($"критический урон: {critdmg}");
