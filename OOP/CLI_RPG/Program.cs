// 1. Class, Attribute, Method, Constructor, Object, Instance, Garbage Collector:
using System.Numerics;
using System;
using System.Reflection.PortableExecutable;
using System.Xml.Linq;
using System.Diagnostics;

public class Character
{
    // Attributes
    public string Name { get; set; }
    private int _health;
    public int AttackDamage { get; private set; }

    // Constructor
    public Character(string name, int health, int attackDamage)
    {
        Name = name;
        Health = health;
        SetAttackDamage(attackDamage);
    }

    // Encapsulation Getters and Setters
    private void SetAttackDamage(int attackDamage)
    {
        AttackDamage = attackDamage;
    }


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

// 7. Abstract, Abstract Class, Inheritance Abstraction:
public abstract class Weapon
{
    public abstract void Attack(Character target);
}

public class Sword : Weapon
{
    public string Name = "Sword";
    public int AttackDamage = 65;
    public override void Attack(Character target)
    {
        Console.WriteLine($"weapon {Name} attacked - Name: {target.Name} HP is {target.Health}-{AttackDamage}={target.Health - 65}");
    }
}


// 8. Interface:
public interface IHealable
{
    void Heal(int amount);
}

public class Healer : IHealable
{
    public void Heal(int amount)
    {
        Console.WriteLine($"Healed: {amount}");
    }
}


// 7. Abstract class (we don't create class instance of abstract class)
public abstract class LivingCreature
{
    public int CurrentHitPoints { get; set; }
    public int MaximumHitPoints { get; set; }

    public LivingCreature(int currentHitPoints, int maximumHitPoints)
    {
        CurrentHitPoints = currentHitPoints;
        MaximumHitPoints = maximumHitPoints;
    }
}

public class Monster : LivingCreature
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int MaximumDamage { get; set; }
    public int RewardExperiencePoints { get; set; }
    public int RewardGold { get; set; }

    public Monster(int id, string name, int maximumDamage,
        int rewardExperiencePoints, int rewardGold, 
        int currentHitPoints, int maximumHitPoints) : base(currentHitPoints, maximumHitPoints)
    {
        ID = id;
        Name = name;
        MaximumDamage = maximumDamage;
        RewardExperiencePoints = rewardExperiencePoints;
        RewardGold = rewardGold;
    }
}
public class PlayerSecond : LivingCreature
{
    public int Gold { get; set; }
    public int ExperiencePoints { get; set; }
    public int Level { get; set; }

    public PlayerSecond(int currentHitPoints, int maximumHitPoints, 
        int gold, int experiencePoints, 
        int level) : base(currentHitPoints, maximumHitPoints)
    {
        Gold = gold;
        ExperiencePoints = experiencePoints;
        Level = level;
    }
}



public abstract class Item
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string NamePlural { get; set; }

    public Item(int id, string name, string namePlural)
    {
        ID = id;
        Name = name;
        NamePlural = namePlural;
    }
}

public class HealingPotion : Item
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string NamePlural { get; set; }
    public int AmountToHeal { get; set; }

    public HealingPotion(int id, string name, string namePlural, int amountToHeal)
    : base(id, name, namePlural)
    {
        AmountToHeal = amountToHeal;
    }
}

public class WeaponSecond : Item
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string NamePlural { get; set; }
    public int MinimumDamage { get; set; }
    public int MaximumDamage { get; set; }

    public WeaponSecond(int id, string name, string namePlural,
     int minimumDamage, int maximumDamage) :
     base(id, name, namePlural)
    {
        MinimumDamage = minimumDamage;
        MaximumDamage = maximumDamage;
    }
}


// 8. Interface for player progress Saving featured (we use this interface like type value (type hinting) and iteract with interface)

public interface ILoadUserGame
{
    void Save(Player player);
    void Read(Player player);
}

public class SaveIntoPlainText : ILoadUserGame
{
    public void Read(Player player)
    {
        Console.WriteLine($"Saving player {player.Name}'s stats to plain text.");
    }

    public void Save(Player player)
    {
        Console.WriteLine($"Reading player {player.Name}'s stats from plain text.");
    }
}

public class SaveIntoJSON : ILoadUserGame
{
    public void Read(Player player)
    {
        Console.WriteLine($"Saving player {player.Name}'s stats to JSON.");
    }

    public void Save(Player player)
    {
        Console.WriteLine($"Reading player {player.Name}'s stats from JSON.");
    }
}


// Abstract class
abstract class Vehicle
{
    public abstract void Move();
}

class Auto : Vehicle
{
    public override void Move()
    {
        throw new NotImplementedException();
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
    private static void TestCharacter()
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

    private static void TestGameManager()
    {
        GameManager.IncreaseLevel(50);
        GameManager.IncreaseLevel(20);

        GameManager.PrintStatsInfo();

        GameManager.IncreaseLevel(50);
        GameManager.PrintStatsInfo();

        GameManager.IncreaseLevel(215);
        GameManager.PrintStatsInfo();
    }

    private static void TestCombineCharacter()
    {
        Character player = new Character("Satoru", 100, 20);
        Character enemy = new Character("Goblin", 50, 10);

        player.PrintInfo();
        enemy.PrintInfo();

        Character combinedCharacter = player + enemy;

        combinedCharacter.PrintInfo();
    }

    private static void TestHealthLogic()
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

        //TestHealthLogic();
        //Console.ReadLine();
    }

    private static void TestWeaponAbstract()
    {
        Player player = new Player("Satoru", 100, 35);
        Enemy enemy = new Enemy("Goblin", 100, 25);

        Weapon sword = new Sword();
        sword.Attack(enemy);
    }

    private static void TestHealInterface()
    {
        IHealable heal = new Healer();
        heal.Heal(75);
    }

    private static void TestAbstractItemLiving()
    {
        // int currentHitPoints, int maximumHitPoints, int gold, int experiencePoints, int level

        //public PlayerSecond(int currentHitPoints, int maximumHitPoints,
        //int gold, int experiencePoints,
        //int level) : base(currentHitPoints, maximumHitPoints)

        LivingCreature player = new PlayerSecond(
            currentHitPoints: 10,
            maximumHitPoints: 100,
            gold: 10,
            experiencePoints: 20,
            level: 1
        );

        string hp = player.CurrentHitPoints.ToString();
        Console.WriteLine("HP: " + hp);
    }

    private static void TestInterfaceSaving()
    {
        Player player = new Player("Satoru", 100, 35);

        ILoadUserGame plainTextSaver = new SaveIntoPlainText();
        plainTextSaver.Save(player);
        plainTextSaver.Read(player);

        ILoadUserGame jsonSaver = new SaveIntoJSON();
        jsonSaver.Save(player);
        jsonSaver.Read(player);
    }

    private static void Main(string[] args)
    {
        TestInterfaceSaving();
    }
}