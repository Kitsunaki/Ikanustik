using System;

namespace Ikanustik.Entities._01Schwarzwald {

  internal class Vepar : Entity {

    public Vepar() {
      Health = 17;
      HealthPool = 17;
      Regeneration = 1;
      Name = "Vepar";
      DamageMin = 2;
      DamageMax = 3;
      MinGetGold = 2;
      MaxGetGold = 4;
    }

    public override void Clash(Player player) {
      Console.Clear();
      VeparPortrait();
      Console.WriteLine($"\n\n{Name} taucht auf. Ein Wassderdämon, der sich mit Beifuß beschwören lässt.");
      System.Threading.Thread.Sleep(5000);
      Console.Clear();
      while (Health > 0 && player.Health > 0) {
        Menus.ClashMenu(player, this);
      }
      if (player.Health > 0) {
        Menus.Victory(player, this);
      } else if (player.Health < 1) {
        Console.WriteLine("Der Dämon hält kurz vor seinem vernichtenden Schlag inne, und greift dich \nbeim Taumeln auf. Er legt dich ins Nahe Moos und verschwindet wieder in die \nHöllen. Dein Tod wäre nicht seine Aufgabe gewesen. Du erholst dich erstmal.");
        player.Health = player.HealthPool;
        player.Mana = player.ManaPool;
        player.Satisfaction = 0;
        Console.ReadLine();
      }
    }

    public static void VeparPortrait() {
      Console.Write("  /|\\||/|\\|/'|||||/'|\\\n");
      Console.Write(" /||||||||/||\\|||/||\\\\\\\\\n");
      Console.Write(" |||/////////        \\||\n");
      Console.Write(" ||/////   -____   ___\\\n");
      Console.Write(" ||||||     ___ - /___/\n");
      Console.Write(" |/   ||   \\_(_) |/(_)\n");
      Console.Write(" | |  |          \\  |\n");
      Console.Write(" |                \\ /\n");
      Console.Write(" \\__|   /      /___\\\n");
      Console.Write("   |   /  ________\\\n");
      Console.Write("   |     /________|\n");
      Console.Write("   |    |      ||\n");
      Console.Write("   |    |  ____||___\n");
      Console.Write("   |    | /   __    \\\n");
      Console.Write("   |   /_/___/__\\    \\\n");
      Console.Write("   |   \\________/\\___/\n");
      Console.Write("   |            |\n");
    }
  }
}