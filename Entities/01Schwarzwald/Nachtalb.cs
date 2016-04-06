using System;

namespace Ikanustik.Entities._01Schwarzwald {

  internal class Nachtalb : Entity {

    public Nachtalb() {
      Health = 20;
      HealthPool = 20;
      Regeneration = 3;
      Name = "Nachtalb";
      DamageMin = 2;
      DamageMax = 3;
      MinGetGold = 11;
      MaxGetGold = 24;
      ExpMin = 17;
      ExpMax = 30;
      Armor = 6;
    }

    public override void Clash(Player player) {
      Console.Clear();
      Console.Write(new String('\n', 10));
      Console.WriteLine($"{Name} taucht auf. Ein Druckgeist, der des nachts die Menschen mit\nZerrbildern ihrer inneren Abgründe quält!");
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