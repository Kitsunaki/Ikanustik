using System;

namespace Ikanustik.Entities._01Schwarzwald {

  internal class Skelett : Entity {

    public Skelett() {
      Health = 8;
      HealthPool = 8;
      Regeneration = 0;
      Name = "Skelett";
      DamageMin = 1;
      DamageMax = 3;
      MinGetGold = 5;
      MaxGetGold = 18;
      ExpMin = 8;
      ExpMax = 12;
      Armor = 2;
    }

    public override void Clash(Player player) {
      Console.Clear();
      Console.Write(new String('\n', 10));
      Console.WriteLine($"{Name} taucht auf. Welch dunkle Magie hält dieses Gerippe zusammen?");
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