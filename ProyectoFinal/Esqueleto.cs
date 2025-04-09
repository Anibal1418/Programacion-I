public class Esqueleto : Enemigo
{
    public Esqueleto(int hp = 5, int dmg = 5, int ac = 10): base(hp, dmg, ac)
    {
        this.nombre = "Esqueleto";
    }
}
