using System;

namespace Ikanustik.Entities._01Schwarzwald {

  internal class Empusa : Entity {

    public Empusa() {
      Health = 15;
      HealthPool = 15;
      Regeneration = 1;
      Name = "Empusa-Gespenst";
      DamageMin = 1;
      DamageMax = 2;
      MinGetGold = 5;
      MaxGetGold = 12;
      ExpMin = 12;
      ExpMax = 18;
      Armor = 5;
    }

    public override void Clash(Player player) {
      Console.Clear();
      Console.Write(new String('\n', 10));
      Console.WriteLine($"{Name} taucht auf. Ein ortsgebundener Geist mit einiger Macht.");
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