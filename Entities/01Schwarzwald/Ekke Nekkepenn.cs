using System;

namespace Ikanustik.Entities._01Schwarzwald {

  internal class Ekke_Nekkepenn : Entity {

    public Ekke_Nekkepenn() {
      Health = 18;
      HealthPool = 18;
      Regeneration = 0;
      Name = "Ekke Nekkepenn";
      DamageMin = 1;
      DamageMax = 3;
      MinGetGold = 6;
      MaxGetGold = 28;
      ExpMin = 13;
      ExpMax = 17;
      Armor = 4;
    }

    public override void Clash(Player player) {
      Console.Clear();
      Console.Write(new String('\n', 10));
      Console.WriteLine($"{Name} taucht auf. Ein hinterlistiger Wassergeist aus dem Alpenraum.");
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