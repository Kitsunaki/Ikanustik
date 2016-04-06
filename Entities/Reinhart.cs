using System;

namespace Ikanustik.Entities {

  internal class Reinhart : Entity {

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
      ReinhartPortrait();
      Console.Write($"\tReinhart:\n\"");

      int RepairCost = player.Active_Weapon.Min_Damage * (player.Active_Weapon.Weapon_FullDurability - player.Active_Weapon.Weapon_Durability);
      if (player.Active_Weapon.Weapon_Class == "Stangenwaffe") {
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
          player.Active_Weapon.Weapon_Durability = player.Active_Weapon.Weapon_FullDurability;
          Console.WriteLine($"\"Ja!\"\n\nReinhart: \"Gut! Dein {player.Active_Weapon.Weapon_Name} is' wieder wie frisch vom Laster jefallen!\"\n(Press ENTER)");
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
      ReinhartPortrait();
      Console.Write($"\tReinhart:\n\"");
      Console.Write($"Tach {player.Name}, wat jeht? Ick muss dir wat sagen! Ick spüre die Energie \nvon deiner Stiefmutter inner Nähe. Schnell, kiek dich bei meinen Waffen um, \nbevor die Olle da ist! Dolche gibt es so uff die Kralle. Davon habe ick genug.");
      Console.Write($"\"");
      Console.ReadLine();
    }

    public static void BlackwoodStepmother(Player player) {
      Console.Clear();
      Menus.Bar();
      ReinhartPortrait();
      Console.Write($"\tReinhart:\n\"");
      Console.Write($"Hast du das anjekiekt? Es konnte sich net wehren! Dit war gar koin Lebewesen,\nnur ein lebloser Golem! Die Olle plant doch irjendwatt! Wir müssen dich \nvorbereiten. Du musst Helga finden. Sie kann disch Unterricht geben! Zwischen \njedem Kampf, kannste bei mir innekieken, ob du neue Waffen broochst. Ick giff \ndir mol 10 Gold uff die Kralle. Kannste beholten. Und nu viel Erfolg.");
      Console.Write($"\"");
      player.Gold += 10;
      Console.ReadLine();
    }

    public static void Map(Player player) {
      Console.Clear();
      Menus.Bar();
      ReinhartPortrait();
      Console.Write($"\tReinhart:\n\"");
      Console.Write($"Willste mal in mein Angebot kieken? Sach ditte gleich!");
      Console.Write($"\"");
      Console.ReadLine();
    }

    public static void ReinhartPortrait() {
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

    public static void BlackwoodTrain5(Player player) {
      Console.Clear();
      Menus.Bar();
      ReinhartPortrait();
      Console.Write("Reinhart:\n\"");
      Console.Write("Bevor Helga sisch hier mit deinem Training ganz meschugge macht, will icke\nooch noch wat beitrajen! Ick werde dir wat über Waffen vertellen. Du koofst\n'se bei mir für Jold und jegen 'nen Preis für meene Werkzeuge, kann ick\nWaffen sojar wieder zusammenflicken. Die Räpperatur wird teurer, je höher der\nMinimoolschooden der Waffe is' und je stärker du die Waffe schon\nverklöppelt has'. Rischig lohnen, tut sich das Einsetzen meener Werkzeuje also\nerst bei fetteren Waffen. Du konnscht den Gegnern eenen aufn Döötz hauen, mit\neenem zufälligen Wert zwischen dem minioolen und maximoolen Schaden deiner\nWaffe. Das hängt janz davon ab, wie juut deen Schwung so ausfällt. Kann vorher\nniemand versischern. Außerdem besteht eine 50% Schanse, dass deene Waffe beem\nKloppen ein Haltbarkeit verliern tut. Is' der Wert bei null, is' die Waffe\nim Oarsch und du kanns' nur noch mit 'de Mäusefäustschen kloppen. Das is'\nnisch zu empfehlen. Also achte im kommenden Kampf off deene Waffe, den\nSchooden und die Haltbarkeit. Und denke dran, dass deen Gegner dir och Schaden\nrinne kloppet!");
      Console.Write("\"");
      Console.ReadLine();
    }

    public static void BlackwoodTrain6(Player player) {
      Console.Clear();
      Menus.Bar();
      ReinhartPortrait();
      Console.Write("Reinhart:\n\"");
      Console.Write("Wat' ick dir noch sajen kann, is' dat es eene Waffenklasse gibt. Die is'\nnisch so wischtich, aber ich sortiere meene Woffen nach Klinge, Flegel,\nStange, Oxt und Projektil. Die haben olle ihre Vorzüsche. Klingen sind\nausjewogen, Flegel halten viel uss, Stangen haben 'ne fette Reichwoite im\nSchaden, Äxte mochen dicke Löcher in die Geechner rin, und Projektilwaffen\nsind toll jegen Rüstungen der Geechner. Denn sie brechen durch olles duarsch.\nDann jibbet es noch Artefakte, das sind die fettesten Oschis unter jeder\n einzelnen Waffenklasse. Goiler Scheiß, wa?");
      Console.Write("\"");
      Console.ReadLine();
    }
  }
}