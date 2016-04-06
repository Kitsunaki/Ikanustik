using System;

namespace Ikanustik.Entities._01Schwarzwald {

  internal class Ghul : Entity {

    public Ghul() {
      Health = 16;
      HealthPool = 16;
      Regeneration = 0;
      Name = "Ghul";
      DamageMin = 1;
      DamageMax = 2;
      MinGetGold = 6;
      MaxGetGold = 21;
      ExpMin = 11;
      ExpMax = 15;
      Armor = 3;
    }

    public override void Clash(Player player) {
      Console.Clear();
      Console.Write(new String('\n', 10));
      Console.WriteLine($"{Name} taucht auf. Es verzehrt sich nach lebendigem Fleisch.");
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