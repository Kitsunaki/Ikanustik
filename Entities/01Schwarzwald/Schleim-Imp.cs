using System;

namespace Ikanustik.Entities._01Schwarzwald {

  internal class Schleim_Imp : Entity {

    public Schleim_Imp() {
      Health = 14;
      HealthPool = 14;
      Regeneration = 0;
      Name = "Schleim-Imp";
      DamageMin = 1;
      DamageMax = 2;
      MinGetGold = 3;
      MaxGetGold = 8;
      ExpMin = 8;
      ExpMax = 13;
      Armor = 2;
    }

    public override void Clash(Player player) {
      Console.Clear();
      Console.Write(new String('\n', 10));
      Console.WriteLine($"{Name} taucht auf. Ein kleiner Kobolddämon voller Ektoplasma! \nOb ein Spuk in der Nähe ist?");
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