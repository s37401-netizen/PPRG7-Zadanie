public class Item
{
    public string Nazwa { get; }
    public int Cena { get; }
    public int LiczbaSztuk { get; set; }

    public Item(string nazwa, int cena)
    {
        Nazwa = nazwa;
        Cena = cena;
        LiczbaSztuk = 1;
    }

    public void AddOne()
    {
        LiczbaSztuk++;
    }

    public void RemoveOne()
    {
        if (LiczbaSztuk > 0)
        {
            LiczbaSztuk--;
        }
    }
}
