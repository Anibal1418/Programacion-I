using System.Security.Cryptography;

public class Jugador
{
   public string username;
   private int puntosDeVida;
   private int danoDeAtaque;
   private int danoDeHabilidad;
   private int armadura;
   private int Roll;
   private bool estaVivo = true;
   private Random randomGenerator = new Random();

   public Jugador(string user, int hp = 20, int AD = 5, int AP = 3, int ac = 12)
   {
      this.username = user;
      this.puntosDeVida = hp;
      this.danoDeAtaque = AD;
      this.danoDeHabilidad = AP;
      this.armadura = ac;
      if(hp <= 0)
      {
         estaVivo = false;
      }
   }
   public int GetPuntosDeVida() { return puntosDeVida;}
   public int GetDanoDeAtaque() { return danoDeAtaque;}
   public int GetDanoDeHabilidad() { return danoDeHabilidad;}
   public int GetArmadura() { return armadura; } 
   public bool EstaVivo() { return estaVivo;}

   public void ReducirVida(int dano) 
   { 
      puntosDeVida -= dano; 
      if (puntosDeVida <= 0)
      {
         estaVivo = false;
         Console.WriteLine($"{username} ha muerto, por lo tanto, usted ha perdido el juego.");
      }
   }
   public void Atacar(Enemigo enemigo)
   {
      Roll = randomGenerator.Next(0, 21);
      if(Roll > enemigo.GetArmadura())
      {
         Console.WriteLine($"El ataque fue un exito con un roll de {Roll}!");
         enemigo.ReducirVida(danoDeAtaque);
      }
      else
      {
         Console.WriteLine($"Su ataque fue un fracaso con un roll de {Roll}.");
      }

      //Por cada ataque cuerpo a cuerpo que el jugador haga, el enemigo responde
      if(enemigo.EstaVivo())
      {
         enemigo.Atacar(this);
      }
   } 

   public bool LograCorrer()
   {
      Roll = randomGenerator.Next(0, 21);
      if(Roll > 10)
      {
         Console.WriteLine($"{username} corre exitosamente");
         return true;
      }
      else
      {
         Console.WriteLine($"{username} fracasa en correr");
         return false;
      }
   }

   public void Habilidad(Enemigo[] enemigos)
   {
      Roll = randomGenerator.Next(0, 21);
      foreach (Enemigo enemigo in enemigos)
      {
         if(Roll > enemigo.GetArmadura())
         {
            Console.WriteLine($"{enemigo.Nombre()} ha sido alcanzado por el ataque en área con un roll de {Roll}.");
            if (enemigo is Esqueleto esqueleto)
            {
               esqueleto.ReducirVida(danoDeHabilidad);
            }
            else if (enemigo is Slime slime)
            {
               slime.ReducirVida(danoDeHabilidad);
            }
            else if (enemigo is Guardian guardian)
            {
               guardian.ReducirVida(danoDeHabilidad);
            }
         }
         else
         {
            Console.WriteLine($" {enemigo.Nombre()} ha esquivado el ataque con el roll de {Roll}.");
            enemigo.Atacar(this);
            //El enemigo solo responde si no lo alcanza la habilidad
         }
      }

   }
}
