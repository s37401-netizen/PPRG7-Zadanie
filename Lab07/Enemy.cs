public class Enemy
{
    public string Nazwa { get; }
    public int Hp { get; set; }
    public int Obrazenia { get; }

    public Enemy(string nazwa, int hp, int obrazenia)
    {
        Nazwa = nazwa;
        Hp = hp;
        Obrazenia = obrazenia;
    }

    public void TakeDamage(int obrazenia)
    {
        Hp -= obrazenia;

        if (Hp < 0)
        {
            Hp = 0;
        }
    }

    public bool IsAlive()
    {
        return Hp > 0;
    }
}
