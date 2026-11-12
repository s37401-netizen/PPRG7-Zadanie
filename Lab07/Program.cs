List<Enemy> enemies = new List<Enemy>
{
    new Enemy("Goblin", 30, 8),
    new Enemy("Nietoperz", 20, 5),
    new Enemy("Ork", 70, 15)
};

foreach (Enemy enemy in enemies)
{
    Console.WriteLine($"{enemy.Name}: {enemy.Health} HP");
}

Player player1 = new Player("Maciuś", 100, 25, 1, 40);
Player player2 = new Player("Nietoperz", 100, 25, 1, 90);
Enemy goblin = new Enemy("Goblin", 30, 8);
Enemy zombie = new Enemy("Zombie", 30, 8);

Console.WriteLine($"{player1.Name} oraz {player2.Name} spotykają {goblin.Name} i {zombie.Name}.");

zombie.TakeDamage(15);
goblin.TakeDamage(25);
Console.WriteLine($"{goblin.Name} ma {goblin.Health} HP.");

if (goblin.IsAlive())
{
    player1.TakeDamage(goblin.Damage);
    Console.WriteLine($"{player1.Name} ma {player1.Health} HP.");
}
else
{
    Console.WriteLine("Przeciwnik został pokonany.");
    player1.XP();
}

if (zombie.IsAlive())
{
    player2.TakeDamage(goblin.Damage);
    Console.WriteLine($"{player2.Name} ma {player2.Health} HP.");
}
else
{
    Console.WriteLine("Przeciwnik został pokonany.");
    player2.XP();
}

Console.WriteLine($"{player1.Name} ma {player1.Level} Level");
Console.WriteLine($"{player1.Name} ma {player1.Experience} XP");
Console.WriteLine($"{player2.Name} ma {player2.Level} Level");
Console.WriteLine($"{player2.Name} ma {player2.Experience} XP");
/*
while (true)
{
       
}
*/