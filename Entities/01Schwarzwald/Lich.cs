using System;

namespace Ikanustik.Entities._01Schwarzwald {

  internal class Lich : Entity {

    public Lich() {
      Health = 28;
      HealthPool = 28;
      Regeneration = 5;
      Name = "Lich";
      DamageMin = 1;
      DamageMax = 4;
      MinGetGold = 18;
      MaxGetGold = 43;
      ExpMin = 25;
      ExpMax = 50;
      Armor = 2;
    }

    public override void Clash(Player player) {
      Console.Clear();
      Console.Write(new String('\n', 10));
      Console.WriteLine($"{Name} taucht auf. Der gequälte Kadaver eines lebensdürstigen Magiers.");
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