using System;

namespace Ikanustik.Entities._01Schwarzwald {

  internal class Rasselbock : Entity {

    public Rasselbock() {
      Health = 6;
      HealthPool = 6;
      Regeneration = 0;
      Name = "Rasselbock";
      DamageMin = 1;
      DamageMax = 1;
      MinGetGold = 2;
      MaxGetGold = 9;
      ExpMin = 4;
      ExpMax = 8;
      Armor = 0;
    }

    public override void Clash(Player player) {
      Console.Clear();
      Console.Write(new String('\n', 10));
      Console.WriteLine($"{Name} taucht auf. Ein flinker Kobold und Nachkomme des Wolpertinger.");
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