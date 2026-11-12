public class Player
{
    public string Name { get; }
    public int Health { get; set; }
    public int MaxHealth { get; set; }
    public int Gold { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }

    public Player(string name, int maxHealth, int gold,  int level, int experience)
    {
        Name = name;
        MaxHealth = maxHealth;
        Health = maxHealth;
        Gold = gold;
        Level = level;
        Experience = experience;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        
        if (Health < 0)
        {
            Health = 0;
        }
    }

    public void Heal(int amount)
    {
        Health += amount;

        if (Health > MaxHealth)
        {
            Health = MaxHealth;
        }
    }

    public bool IsAlive()
    {
        return Health > 0;
    }

    public int XP()
    {
        Console.WriteLine("Dostałeś 10 XP");
        if (Experience + 10 >= 100)
        {
            Experience -= 100;
            return newLevel();
        }
        else
        {
            Console.WriteLine($"Twoj poziom {Level} Level");
            Experience += 10;
        }
        return Experience;
    }

    public int newLevel()
    {
        MaxHealth += 10;
        Health = MaxHealth;
        Level++;
        Console.WriteLine($"Masz {Level} Level)");
        return Level;
    }
    
}