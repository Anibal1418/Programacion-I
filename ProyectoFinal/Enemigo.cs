public class Enemigo
{
   protected string nombre = "Enemigo";
   protected int puntosDeVida;
   protected int dano;
   protected int armadura;
   protected bool estaVivo = true;
   protected int Roll;
   protected Random randomGenerator = new Random();
   public Enemigo(int hp, int dmg, int ac)
   {
      puntosDeVida = hp;
      dano = dmg;
      armadura = ac;
      if (hp <= 0)
      {
         estaVivo = false;
      }
   }
   public int GetPuntosDeVida() { return puntosDeVida; }
   public void ReducirVida(int dano) 
   { 
      puntosDeVida -= dano; 
      if (puntosDeVida <= 0)
      {
         estaVivo = false;
      }
      Console.WriteLine($"El {nombre} ha perdido {dano} de puntos de vida y se encuentra a {puntosDeVida} puntos de vida.");
   }
   public int GetDano() { return dano; }
   public int GetArmadura() { return armadura; } 
   public string Nombre() { return nombre; }  
   public bool EstaVivo() { return estaVivo; }

   public void Atacar(Jugador jugador)
   {
      if(jugador.EstaVivo())
         {
         Roll = randomGenerator.Next(0, 21);
         if(Roll > jugador.GetArmadura())
         {
            Console.WriteLine($"El ataque del enemigo fue un exito con un roll de {Roll}!");
            jugador.ReducirVida(dano);
            Console.WriteLine($"{jugador.username} ha perdido {dano} de puntos de vida y se encuentra a {jugador.GetPuntosDeVida()} puntos de vida.");
         }
         else
         {
            Console.WriteLine($"El ataque del enemigo fue un fracaso con un roll de {Roll}.");
         }
      }
   } 

}
