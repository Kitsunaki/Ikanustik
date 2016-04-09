using System;

namespace Ikanustik.Entities.NPC {

  internal class Reinhart : NPC {

    public Reinhart() {
      Health = 100;
      HealthPool = 100;
      Regeneration = 0;
      Name = "Reinhart";
      DamageMin = 5;
      DamageMax = 10;
      MinGetGold = 25;
      MaxGetGold = 50;
    }

    public override void Clash(Player player) {
      Console.Clear();
      Console.Write(new String('\n', 10));
      Console.WriteLine($"{Name} taucht auf. Du forderst ihn zu einem freundschaftlichen Duell heraus!");
      System.Threading.Thread.Sleep(4400);
      Console.Clear();
      while (Health > 0) {
        Menus.ClashMenu(player, this);
      }
      Menus.Victory(player, this);
    }

    public static void Repair(Player player) {
      Console.Clear();
      Menus.Bar();
      Portrait();
      Console.Write($"\tReinhart:\n\"");

      int RepairCost = player.ActiveWeapon.MinDamage * (player.ActiveWeapon.FullDurability - player.ActiveWeapon.Durability);
      if (player.ActiveWeapon.Waffengattung == Waffengattungen.Stangen) {
        RepairCost = RepairCost / 2;
      }

      Console.Write($"Na juut {player.Name}. Ick kann deine aktuelle Waffe reparieren! Dem aktuellen \nVerschleiß nach, kostet das {RepairCost} Gold. Soll icke dit reparieren?");
      Console.Write($"\"\n(j/n)");
      Console.Write($"\n\n{player.Name}: ");
      char AskRepair = Console.ReadKey(true).KeyChar;

      if (AskRepair == 'j' || AskRepair == 'J') {
        if (player.Gold < RepairCost) {
          Console.WriteLine("\"Ja! Aber hier...meine Geldbörse...\"\n\nReinhart: \"Du Gurkenfred! Du has' gar nisch genug Kohle uff de' Kralle!\"\n(Press ENTER)");
          Console.ReadLine();
        } else if (player.Gold >= RepairCost) {
          Console.Beep();
          player.Gold -= RepairCost;
          player.ActiveWeapon.Durability = player.ActiveWeapon.FullDurability;
          Console.WriteLine($"\"Ja!\"\n\nReinhart: \"Gut! Dein {player.ActiveWeapon.Name} is' wieder wie frisch vom Laster jefallen!\"\n(Press ENTER)");
          Console.ReadLine();
        }
      } else if (AskRepair == 'n' || AskRepair == 'N') {
        Console.WriteLine("\"Nein.\"\n\nReinhart: \"Gut du Huckedunkel. Dann komm wieder, sobald du wat zu reparieren has'.\"\n(Press ENTER)");
        Console.ReadLine();
      }
    }

    public static void IntroBlackwood(Player player) {
      Console.Clear();
      Menus.Bar();
      Console.WriteLine("Ein großer breiter Mann mit einem riesigen Rucksack kommt dir entgegen. \nÜberall hängen Waffen heraus und daran. Vorm Bauch trägt der Waffenhändler \neinen mobilen Amboss. Mit angestrengter Miene nähert er sich dir und ihr \nscheint euch bereits zu kennen.");
      Console.ReadLine();
      Console.Clear();
      Menus.Bar();
      Portrait();
      Console.Write($"\tReinhart:\n\"");
      Console.Write($"Tach {player.Name}, wat jeht? Ick muss dir wat sagen! Ick spüre die Energie \nvon deiner Stiefmutter inner Nähe. Schnell, kiek dich bei meinen Waffen um, \nbevor die Olle da ist! Dolche gibt es so uff die Kralle. Davon habe ick genug.");
      Console.Write($"\"");
      Console.ReadLine();
    }

    public static void BlackwoodStepmother(Player player) {
      Console.Clear();
      Menus.Bar();
      Portrait();
      Console.Write($"\tReinhart:\n\"");
      Console.Write($"Hast du das anjekiekt? Es konnte sich net wehren! Dit war gar koin Lebewesen,\nnur ein lebloser Golem! Die Olle plant doch irjendwatt! Wir müssen dich \nvorbereiten. Du musst Helga finden. Sie kann disch Unterricht geben! Zwischen \njedem Kampf, kannste bei mir innekieken, ob du neue Waffen broochst. Ick giff \ndir mol 10 Gold uff die Kralle. Kannste beholten. Und nu viel Erfolg.");
      Console.Write($"\"");
      player.Gold += 10;
      Console.ReadLine();
    }

    public static void Map(Player player) {
      Console.Clear();
      Menus.Bar();
      Portrait();
      Console.Write($"\tReinhart:\n\"");
      Console.Write($"Willste mal in mein Angebot kieken? Sach ditte gleich!");
      Console.Write($"\"");
      Console.ReadLine();
    }

    public static void Portrait() {
      Console.Write("        .-'--.\n");
      Console.Write("      .'      '.\n");
      Console.Write("     /     _    `-.\n");
      Console.Write("    /      .\\-     \\,  ,\n");
      Console.Write("   ;       .-|-'    \\####,\n");
      Console.Write("   |,       .-|-'    ;####\n");
      Console.Write("  ,##         `     ,|###\"\n");
      Console.Write("#,####, \"#,        ,#|^;#\n");
      Console.Write("`######  `#####,|##\" |`)|\n");
      Console.Write(" `#####    ```O\\`\\O_.| ;\\\n");
      Console.Write("  (-`\\#,    .-'` |`  : `;\n");
      Console.Write("  `\\ ;\\#,         \\   \\-'\n");
      Console.Write("    )( \\#    ,,_   \\   ;\n");
      Console.Write("    (_,  \\  /   `'./   |\n");
      Console.Write("      \\  / | .-`'--'`. |\n");
      Console.Write("       | ( \\   ,  /_,  |\n");
      Console.Write("       \\    `   ``     /\n");
      Console.Write("        '-.__     // .'\n");
      Console.Write("             `'`.__.'\n");
    }
  }
}