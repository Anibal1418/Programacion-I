public class Guardian : Enemigo
{
    public Guardian(int hp = 10, int dmg = 2, int ac = 15, int res = 3, int cd = 2) : base(hp, dmg, ac)
    {
        this.nombre = "Guardian";
    }
   public new void ReducirVida(int dano) 
   { 
      puntosDeVida -= dano;

      if (puntosDeVida <= 0)
      {
        estaVivo = false;
      }

      Console.WriteLine($"El {nombre} ha perdido {dano} de puntos de vida y se encuentra a {puntosDeVida} puntos de vida.");
   }    
}
