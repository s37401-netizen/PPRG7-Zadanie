public class Player
{
    public string Imie { get; set; }
    public int Hp { get; set; }
    public int MaksymalneHp { get; }
    public int Zloto { get; set; }

    public Player(string imie, int maksymalneHp, int zloto)
    {
        Imie = imie;
        MaksymalneHp = maksymalneHp;
        Hp = maksymalneHp;
        Zloto = zloto;
    }

    public void TakeDamage(int obrazenia)
    {
        Hp -= obrazenia;

        if (Hp < 0)
        {
            Hp = 0;
        }
    }

    public void Heal(int leczenie)
    {
        Hp += leczenie;

        if (Hp > MaksymalneHp)
        {
            Hp = MaksymalneHp;
        }
    }

    public bool IsAlive()
    {
        return Hp > 0;
    }
}
