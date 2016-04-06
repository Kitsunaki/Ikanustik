using System;

namespace Ikanustik.Entities._01Schwarzwald {

  internal class Riesenratte : Entity {

    public Riesenratte() {
      Health = 12;
      HealthPool = 12;
      Regeneration = 0;
      Name = "Riesenratte";
      DamageMin = 1;
      DamageMax = 3;
      MinGetGold = 4;
      MaxGetGold = 8;
      ExpMin = 10;
      ExpMax = 15;
      Armor = 3;
    }

    public override void Clash(Player player) {
      Console.Clear();
      Console.Write(new String('\n', 10));
      Console.WriteLine($"{Name} taucht auf. Eine Mutation aus der Kanalisation eines AKW!");
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