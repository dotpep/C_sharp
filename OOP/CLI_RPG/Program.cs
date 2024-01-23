// 1. Class, Attribute, Method, Constructor, Object, Instance, Garbage Collector:
using System.Numerics;
using System;
using System.Reflection.PortableExecutable;

public class Character
{
    // Attributes
    public string Name { get; set; }
    private int _health;
    public int AttackDamage { get; set; }

    // Constructor
    public Character(string name, int health, int attackDamage)
    {
        Name = name;
        Health = health;
        AttackDamage = attackDamage;
    }

    // Encapsulation Getters and Setters
    public int Health
    {
        get { return _health; }
        set
        {
            _health = Math.Max(0, value);
            CheckDeath();
        }
    }

    // Health Logic
    private void CheckDeath()
    {
        if (_health <= 0)
        {
            HandleDeath();
        }
    }

    // 6. Polymorphism, virtual
    protected virtual void HandleDeath()
    {
        // Perform additional logic for handling death
        Console.WriteLine($"{Name} has died!");
        // Additional logic like respawning, game over, etc., can be added here.
    }

    // Method
    // 6. Polymorphism, virual
    public virtual void Attack(Character target)
    {
        if (_health > 0)
        {
            target.Health -= AttackDamage;
            Console.WriteLine($"{Name} attacks {target.Name} for {AttackDamage} damage!");
            CheckDeath();
        }
        else
        {
            Console.WriteLine($"{Name} is dead and cannot attack!");
        }
    }

    public void PrintInfo()
    {
        if (_health > 0)
        {
            Console.WriteLine($"Name: {Name}, Health: {_health}, Attack Dmg: {AttackDamage}");
        }
        else
        {
            Console.WriteLine($"{Name} is dead!");
        }
    }

    // 3. Operator Overloading:
    public static Character operator +(Character character1, Character character2)
    {
        // Combine two characters stats into 1
        return new Character($"{character1.Name} eat stats of {character2.Name}",
                             character1._health + character2._health,
                             character1.AttackDamage + character2.AttackDamage);
    }
}

// 5. Inheritance, base with 6. Polymorphism, overrid
public class Player : Character
{
    public Player(string name, int health, int attackDamage) : base(name, health, attackDamage)
    {
    }

    protected override void HandleDeath()
    {
        base.HandleDeath();
        Console.WriteLine("Game Over");
        Environment.Exit(0);
    }
}

public class Enemy : Character
{
    public Enemy(string name, int health, int attackDamage) : base(name, health, attackDamage)
    {
    }

    protected override void HandleDeath()
    {
        base.HandleDeath();
        Console.WriteLine($"{Name} is defeated!");
    }

    public override void Attack(Character target)
    {
        if (target.Health > 0)
        {
            base.Attack(target);
        }
        else
        {
            Console.WriteLine($"{Name} is dead and cannot attack!");
        }
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

// 4. Encapsulation, Getters and Setters:
public class EncapsulatedCharacter
{
    // Private backing fields
    private string _Name;
    private int _Health;

    // Public properties with encapsulation
    public string Name
    {
        get { return _Name; }
        set { _Name = value; }
    }

    public int Health
    {
        get { return _Health; }
        set
        {
            _Health = value;
            if (_Health < 0)
            {
                _Health = 0;
                // Perform additional logic for handling death
            }
        }
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


        player.PrintInfo();
        enemy.PrintInfo();

        player.Attack(enemy);
        enemy.Attack(player);

        player.PrintInfo();
        enemy.PrintInfo();
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

    static private void TestCombineCharacter()
    {
        Character player = new Character("Satoru", 100, 20);
        Character enemy = new Character("Goblin", 50, 10);

        player.PrintInfo();
        enemy.PrintInfo();

        Character combinedCharacter = player + enemy;

        combinedCharacter.PrintInfo();
    }

    static private void TestHealthLogic()
    {
        Player player = new Player("Satoru", 100, 35);
        Enemy enemy = new Enemy("Goblin", 50, 25);

        player.Attack(enemy);
        enemy.Attack(player);
        player.PrintInfo();
        enemy.PrintInfo();

        player.Attack(enemy);
        enemy.Attack(player);
        player.PrintInfo();
        enemy.PrintInfo();

        player.Attack(enemy);
        enemy.Attack(player);
        player.PrintInfo();
        enemy.PrintInfo();
    }

    private static void Main(string[] args)
    {
        TestHealthLogic();
        Console.ReadLine();
    }
}