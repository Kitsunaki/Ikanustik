using System;
using Ikanustik.Weapons;

namespace Ikanustik.Entities {

  internal class Stepmother : Entity {

    public Stepmother() {
      Health = 15;
      HealthPool = 15;
      Regeneration = 0;
      Name = "Stiefmutter";
      Damage = 0;
    }

    public void Clash(Player user, Weapon weapon) {
      Console.WriteLine("Ein Gegner taucht auf. Nur die Hölle kann ihn geschickt haben!");
      System.Threading.Thread.Sleep(1000);
      Console.Clear();
      Console.WriteLine("Gegner:");
      Console.WriteLine("\t" + Name + "\t" + Health + "/" + HealthPool + " Lebenspunkte\t" + Regeneration + " Selbstheilung\n");
      Console.WriteLine(user.Name + ": ");
      Console.WriteLine("\t" + user.Satisfaction + " Genugtuung\t" + user.Health + "/" + user.HealthPool + " Lebenspunkte\t" + user.Stamina + " Ausdauer");
      Console.WriteLine(/*Waffe*/);

      Console.WriteLine("\nStarte den Angriff mit a!");
      char fight = Console.ReadKey(true).KeyChar;
      if (fight == 'a') {
        Console.Clear();
        Menus.Bar();
        Random hitr = new Random();
        int hit = hitr.Next(2, user.Stamina);
        for (int i = 0; i < (hit - 1); i++) {
          weapon.Attack(user);
          Console.WriteLine("TREFFER! " + Name + " behält {0:0} Lebenspunkte. Gold steigt auf {1,2}!", Health, user.Gold);
        }
      } else {
        Console.WriteLine("Kein Angriff diese Runde!");
      }
      //Wenn Lebenspunkte unter 0
      Console.WriteLine(Name + " wurde besiegt. Weiter mit Enter!");
      user.Gold = user.Gold + 3;
      Console.ReadLine();
      Console.Clear();
    }
  }
}