using System;

namespace Ikanustik.Entities._01Schwarzwald {

  internal class Lindwurm : Entity {

    public Lindwurm() {
      Health = 25;
      HealthPool = 25;
      Regeneration = 2;
      Name = "Lindwurm";
      DamageMin = 3;
      DamageMax = 5;
      MinGetGold = 14;
      MaxGetGold = 32;
      ExpMin = 22;
      ExpMax = 38;
      Armor = 7;
    }

    public override void Clash(Player player) {
      Console.Clear();
      Console.Write(new String('\n', 10));
      Console.WriteLine($"{Name} taucht auf. Eine kleine Drachenschlange. Dennoch sind alle\nDrachen ernstzunehmende Gegner!");
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