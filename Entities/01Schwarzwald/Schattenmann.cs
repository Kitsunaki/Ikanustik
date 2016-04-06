using System;

namespace Ikanustik.Entities._01Schwarzwald {

  internal class Schattenmann : Entity {

    public Schattenmann() {
      Health = 18;
      HealthPool = 18;
      Regeneration = 1;
      Name = "Schattenmann";
      DamageMin = 2;
      DamageMax = 3;
      MinGetGold = 8;
      MaxGetGold = 17;
      ExpMin = 15;
      ExpMax = 21;
      Armor = 4;
    }

    public override void Clash(Player player) {
      Console.Clear();
      Console.Write(new String('\n', 10));
      Console.WriteLine($"{Name} taucht auf. Ein flinker Schemen, der von Kindesangst zehrt und wächst.");
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