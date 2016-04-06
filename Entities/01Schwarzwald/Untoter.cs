using System;

namespace Ikanustik.Entities._01Schwarzwald {

  internal class Untoter : Entity {

    public Untoter() {
      Health = 12;
      HealthPool = 12;
      Regeneration = 0;
      Name = "Untoter";
      DamageMin = 1;
      DamageMax = 2;
      MinGetGold = 4;
      MaxGetGold = 12;
      ExpMin = 7;
      ExpMax = 13;
      Armor = 1;
    }

    public override void Clash(Player player) {
      Console.Clear();
      Console.Write(new String('\n', 10));
      Console.WriteLine($"{Name} taucht auf. Ein Schrecken von Jenseits des Grabes!");
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