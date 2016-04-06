using System;

namespace Ikanustik.Entities._01Schwarzwald {

  internal class Die_Moira : Entity {

    public Die_Moira() {
      Health = 30;
      HealthPool = 30;
      Regeneration = 4;
      Name = "Die Moira";
      DamageMin = 1;
      DamageMax = 2;
      MinGetGold = 20;
      MaxGetGold = 45;
      ExpMin = 26;
      ExpMax = 42;
      Armor = 1;
    }

    public override void Clash(Player player) {
      Console.Clear();
      Console.Write(new String('\n', 10));
      Console.WriteLine($"{Name} taucht auf. Eine sehende Hexe und Dienerin der Stiefmutter.\nSie bewacht das Wohnmobil!");
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