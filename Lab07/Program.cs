// 1. Problem: luźne zmienne
string imie = "Bohater";
int hp = 80;
int maksymalneHp = 100;
int zloto = 25;
bool maMiecz = true;
Console.WriteLine($"{imie}: {hp}/{maksymalneHp} HP, złoto: {zloto}, miecz: {maMiecz}");

// 2, 3, 4, 5. Klasa Player, właściwości, konstruktor, metody
Player player = new Player("Bohater", 100, 25);
player.Zloto += 10;
Console.WriteLine($"{player.Imie} ma {player.Zloto} sztuk złota.");

player.TakeDamage(35);
Console.WriteLine($"Po obrażeniach: {player.Hp}/{player.MaksymalneHp} HP");

player.Heal(50);
Console.WriteLine($"Po leczeniu: {player.Hp}/{player.MaksymalneHp} HP");
Console.WriteLine($"Czy żyje: {player.IsAlive()}");

// Niezależność obiektów
Player a = new Player("Ala", 100, 10);
Player b = new Player("Bartek", 100, 10);
Console.WriteLine($"Imię b: {b.Imie}");

// 6. Lista przeciwników
List<Enemy> enemies = new List<Enemy>
{
    new Enemy("Goblin", 30, 8),
    new Enemy("Nietoperz", 20, 5),
    new Enemy("Ork", 70, 15)
};

enemies[0].TakeDamage(10);
Console.WriteLine($"{enemies[0].Nazwa}: {enemies[0].Hp} HP");
Console.WriteLine($"{enemies[1].Nazwa}: {enemies[1].Hp} HP");

// 7. Prosta walka z kontrolą IsAlive()
Enemy goblin = new Enemy("Goblin", 30, 8);
Console.WriteLine($"{player.Imie} spotyka: {goblin.Nazwa}");
goblin.TakeDamage(12);
Console.WriteLine($"{goblin.Nazwa} ma teraz {goblin.Hp} HP.");

if (!goblin.IsAlive())
{
    Console.WriteLine("Przeciwnik został pokonany.");
}
else
{
    player.TakeDamage(goblin.Obrazenia);
    Console.WriteLine($"{player.Imie} ma teraz {player.Hp} HP.");
}

// 10. Zadanie aktywizujące: klasa Item
Item mikstura = new Item("Mikstura zdrowia", 15);
mikstura.AddOne();
mikstura.RemoveOne();
Console.WriteLine($"{mikstura.Nazwa} (cena: {mikstura.Cena}), sztuk: {mikstura.LiczbaSztuk}");
