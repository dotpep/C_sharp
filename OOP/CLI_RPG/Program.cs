// 1. Class, Attribute, Method, Constructor, Object, Instance, Garbage Collector:
public class Character
{
    // Attributes
    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackDamage { get; set; }

    // Constructor
    public Character(string name, int health, int attackDamage)
    {
        Name = name;
        Health = health;
        AttackDamage = attackDamage;
    }

    // Method
    public void Attack(Character target)
    {
        target.Health -= AttackDamage;
        Console.WriteLine($"{Name} attacks {target.Name} for {AttackDamage} damage!");
    }

    public void printInfo()
    {
        Console.WriteLine($"Name: {Name}, Health: {Health}, Attack Dmg: {AttackDamage}");
    }
}

//2. Static Class, Methods, Attributes:
public static class GameManager
{
    // Static Attribute
    public static int Level { get; set; } = 1;
    public static int Experience { get; set; }
    // Static Mehtod
    public static void IncreaseLevel(int experience)
    {
        Experience += experience;

        while (Experience >= 100)
        {
            Level++;
            Experience -= 100;
        }


    }

    public static void PrintStatsInfo()
    {
        Console.WriteLine($"lvl: {Level}");
        Console.WriteLine($"exp: {Experience}");
    }

}

internal class Program
{
    static private void TestCharacter()
    {
        Character player = new Character("Satoru", 100, 20);
        Character enemy = new Character("Goblin", 50, 10);
        //printInfo(player);
        //printInfo(enemy);
        //player.Attack(enemy);
        //enemy.Attack(player);
        //printInfo(player);
        //printInfo(enemy);


        player.printInfo();
        enemy.printInfo();

        player.Attack(enemy);
        enemy.Attack(player);

        player.printInfo();
        enemy.printInfo();
    }

    static private void TestGameManager()
    {
        GameManager.IncreaseLevel(50);
        GameManager.IncreaseLevel(20);

        GameManager.PrintStatsInfo();

        GameManager.IncreaseLevel(50);
        GameManager.PrintStatsInfo();

        GameManager.IncreaseLevel(215);
        GameManager.PrintStatsInfo();
    }

    private static void Main(string[] args)
    {
        TestGameManager();
    }
}