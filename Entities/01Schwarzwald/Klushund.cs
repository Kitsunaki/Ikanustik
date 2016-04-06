using System;

namespace Ikanustik.Entities._01Schwarzwald {

  internal class Klushund : Entity {

    public Klushund() {
      Health = 23;
      HealthPool = 23;
      Regeneration = 4;
      Name = "Klushund";
      DamageMin = 3;
      DamageMax = 6;
      MinGetGold = 16;
      MaxGetGold = 36;
      ExpMin = 22;
      ExpMax = 42;
      Armor = 6;
    }

    public override void Clash(Player player) {
      Console.Clear();
      Console.Write(new String('\n', 10));
      Console.WriteLine($"{Name} taucht auf. Ein großer finsterer Wolf, mit tellergroßen rot\nglühenden Augen! Ich glaube, er hat Hunger!");
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