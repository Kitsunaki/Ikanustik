using System;

namespace Ikanustik.Entities._01Schwarzwald {

  internal class Moorleiche : Entity {

    public Moorleiche() {
      Health = 7;
      HealthPool = 7;
      Regeneration = 0;
      Name = "Moorleiche";
      DamageMin = 1;
      DamageMax = 4;
      MinGetGold = 5;
      MaxGetGold = 25;
      ExpMin = 10;
      ExpMax = 15;
      Armor = 2;
    }

    public override void Clash(Player player) {
      Console.Clear();
      Console.Write(new String('\n', 10));
      Console.WriteLine($"{Name} taucht auf. Lange scharfe Nägel und eine strohige modrige Haarpracht.");
      System.Threading.Thread.Sleep(5000);
      Console.Clear();
      while (Health > 0 && player.Health > 0) {
        Menus.ClashMenu(player, this);
      }
      if (player.Health > 0) {
        Menus.Victory(player, this);
      } else if (player.Health < 1) {
        Menus.Loose(player, this);
      }
    }
  }
}