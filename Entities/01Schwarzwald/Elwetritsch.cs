using System;

namespace Ikanustik.Entities._01Schwarzwald {

  internal class Elwetritsch : Entity {

    public Elwetritsch() {
      Health = 20;
      HealthPool = 25;
      Regeneration = 1;
      Name = "Elwetritsch";
      DamageMin = 1;
      DamageMax = 5;
      MinGetGold = 14;
      MaxGetGold = 32;
      ExpMin = 21;
      ExpMax = 40;
      Armor = 1;
    }

    public override void Clash(Player player) {
      Console.Clear();
      Console.Write(new String('\n', 10));
      Console.WriteLine($"{Name} taucht auf. Ein großer Hühnerdämon! Er ist bereits angeschlagen!");
      System.Threading.Thread.Sleep(4400);
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