
int hp;
int dmg;

System.Console.WriteLine("Введите базовое здоровье (HP):");
 hp = int.Parse(System.Console.ReadLine());
 int maxhp = hp + 50;
if(hp >= 80) 
System.Console.WriteLine("персонаж целый");

 else if(hp >=21)
 System.Console.WriteLine("персонаж ранен");

 else 
System.Console.WriteLine("персонаж при смерти");

 

 










 System.Console.WriteLine("Введите базовый урон:");
dmg = int.Parse(System.Console.ReadLine());
 int critdmg = dmg * 2;
 System.Console.WriteLine($"максимальное здоровье: {maxhp}");
 System.Console.WriteLine($"критический урон: {critdmg}");

