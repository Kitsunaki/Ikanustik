using System;

namespace Ikanustik.Entities {

  internal class Stepmother : Entity {

    public Stepmother() {
      Health = 6;
      HealthPool = 6;
      Regeneration = 0;
      Name = "Stiefmutter";
      DamageMin = 0;
      DamageMax = 0;
      MinGetGold = 2;
      MaxGetGold = 4;
      ExpMin = 2;
      ExpMax = 5;
      Armor = 0;
    }

    public override void Clash(Player player) {
      Console.Clear();
      StepPortrait();
      Console.WriteLine($"\n\n{Name} taucht auf. Nur die Hölle kann dafür verantwortlich sein!");
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

    public static void StepPortrait() {
      Console.WriteLine("        /  /|");
      Console.WriteLine("    /     /   /  \\ \\");
      Console.WriteLine("  /  /  / / /  | \\ \\ \\");
      Console.WriteLine("   /    / / ||       \\");
      Console.WriteLine("          |           \\");
      Console.WriteLine("                       |");
      Console.WriteLine("           /- -\\    /-\\");
      Console.WriteLine("   -    - / __ _   / __|");
      Console.WriteLine(" / -        /\\| \\    |/");
      Console.WriteLine(" | /         _ /   \\  -\\");
      Console.WriteLine("  \\     \\           |  /");
      Console.WriteLine("    -    |       / /  |");
      Console.WriteLine("                     \\");
      Console.WriteLine("       \\     | _---- |");
      Console.WriteLine("               - --  /");
      Console.WriteLine("           -        -");
      Console.WriteLine("             \\   _ /");
    }
  }
}