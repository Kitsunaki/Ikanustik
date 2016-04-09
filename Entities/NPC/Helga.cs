using System;
using Ikanustik.Entities._01Schwarzwald;

namespace Ikanustik.Entities.NPC {

  internal class Helga : NPC {

    public static void Train() {
      Console.WriteLine("                     .-~~~~~~~~~-._       _.- ~~~~~~~~~-.");
      Console.WriteLine("                 __.'              ~.   .~              `.__");
      Console.WriteLine("               .'//                  \\./                  \\\\`.");
      Console.WriteLine("             .'//                     |                     \\\\`.");
      Console.WriteLine("           .'// .-~\"\"\"\"\"\"\"~~~~-._     |     _,-~~~~\"\"\"\"\"\"\"~-. \\\\`.");
      Console.WriteLine("         .'//.-\"                 `-.  |  .-'                 \"-.\\\\`.");
      Console.WriteLine("       .'//______.============-..   \\ | /   ..-============.______\\\\`.");
      Console.WriteLine("     .'______________________________\\|/______________________________`.");
      Console.ReadLine();
    }

    public static void Portrait() {
      Console.Write("              .#########.#######..\n");
      Console.Write("            .#######################.\n");
      Console.Write("          .############################.\n");
      Console.Write("         .################################.\n");
      Console.Write("        .#########,##,#####################.\n");
      Console.Write("       .#########-#,'########## ############.\n");
      Console.Write("      .######'#-##' # ##'### #. `####:#######.\n");
      Console.Write("      #####:'# #'###,##' # # +#. `###:':######\n");
      Console.Write("     .####,'###,##  ###  # # #`#. -####`######.\n");
      Console.Write("    .####+.' ,'#  ##' #   # # #`#`.`#####::####\n");
      Console.Write("     ####'    #  '##'  #   #_'# #.## `#######;##\n");
      Console.Write("     #:##'      '       #   # ``..__# `#######:#\n");
      Console.Write("     #:##'  .#######s.   #.  .s######.\\`#####:##\n");
      Console.Write("     #:##   .\"______\"\"'    '\"\"_____\"\". `.#####:#\n");
      Console.Write("   .#:##   ><'( O)'> )    ( <'( O)`><   `####;#\n");
      Console.Write("   ##:##  , , -==-' '.    .` `-==- . \\  ######'\n");
      Console.Write("   #|-'| / /      ,  :    : ,       \\ ` :####:'\n");
      Console.Write("   :#  |: '  '   /  .     .  .  `    `  |`####\n");
      Console.Write("   #|  :|   /   '  ' //    `  \\   . ,   :  #:# \n");
      Console.Write("  # L. | | ,  /   `.-._ _.-.'   .  \\ \\  : ) J##\n");
      Console.Write("  ###\\ `  /  '                   \\  : : |  /##\n");
      Console.Write("   ## #|.:: '       _ -- _ _      ` | | |'####\n");
      Console.Write("   #####|\\  |  (.-'.__`-'__.`-.)   :| ' ######\n");
      Console.Write("   ######\\:      `-...___..-' '     :: /######\n");
      Console.Write("   #######\\``.                   ,'|  /#######\n");
      Console.Write("  .# ######\\  \\       ___       / /' /#######\n");
      Console.Write("  # #'#####|\\  \\    -     -    /  ,'|### #. #.\n");
      Console.Write("  `#  #####| '-.`             ' ,-'  |### #  #\n");
      Console.Write("      #' `#|    '._         ,.-'     #`#`#.\n");
      Console.Write("           |       .'------' :       |#   #\n");
      Console.Write("           |       :         :       |\n");
      Console.Write("           |       :         :       |\n");
      Console.Write("                   :         :          \n");
    }

    public static void Training(Player player) {
      int training = 1;
      int quantity = 0;
      int round = 1;
      Console.WriteLine("Wie viele Gegner sollen erstellt werden?");
      quantity = int.Parse(Console.ReadLine());

      Entity[] entities = new Entity[quantity];
      for (int i = 0; i < entities.Length; i++) { entities[i] = new Vepar(); }

      while (training == 1) {
        Console.WriteLine(new String('\n', 10));
        Console.WriteLine($"Runde {round} von {quantity}! Kampf!");
        System.Threading.Thread.Sleep(2000);
        entities[round - 1].Clash(player);
        round++;
        Console.WriteLine("Möchtest du Übungskampf fortsetzen?\n(j/n)");
        Console.Write("Wahl: ");
        string sparing = Console.ReadLine();
        switch (sparing) {
          case "ja":
          case "Ja":
            training = 1;
            break;

          case "nein":
          case "Nein":
            training = 0;
            break;

          default:
            break;
        }
      }
    }

    public static void BlackwoodHello(Player player) {
      Console.Clear();
      Menus.Bar();
      Console.WriteLine("Auf der Lichtung, auf dem schon der merkwürdige Kobold Ekke Nekkepenn gegen \ndich kämpfte, siehst du eine Frau stehen, die sich nun langsam auf dich \nzubewegt. Reinhart winkt ihr wissend zu, sie scheinen sich also zu kennen. \nDie Frau hat mittellange rostbraune Haare mit blonden Strähnen und strahlt \ndich solariumgebräunt an. Dabei erkennst du aufgeklebte Schmucksteine auf \nihren Zähnen. Sie trägt einen goldenen Nasenring und ein mit Pailletten \nbestücktes Top.");
      Console.ReadLine();
      Console.Clear();
      Menus.Bar();
      Portrait();
      Console.Write("Helga:\n\"");
      Console.Write("Na Hallo! Da bist du ja! Ich habe dich gegen den Kobold kämpfen sehen. \nMan sieht, dass du schon früher Kämpfe ausgetragen hast. Es wird Zeit, \ndich deiner alten Stärke zurück zu führen. Das klappt nicht, wenn du nur \nauf immer dickere Waffen setzt, daher werde ich dich trainieren. Komm \njederzeit zu mir, sobald du genug Erfahrungen im Kampf gesammelt hast, um \nneue Techniken zu lernen. Ich schließe mich deiner Gruppe an und werde dir in \nden kommenden Kämpfen erklären, was du teilweise sicher schon selbst heraus-\ngefunden hast!");
      Console.Write("\"");
    }

    public static void Map(Player player) {
      Console.Clear();
      Menus.Bar();
      Portrait();
      Console.Write("Helga:\n\"");
      Console.Write("Na was kann ich Gutes für dich tun?");
      Console.Write($"\"\n\n\t1) Trainieren\n\n{player.Name}: ");
      char HelgaChoose = Console.ReadKey(true).KeyChar;
      if (HelgaChoose == '1') {
        Console.Clear();
        Train();
        Console.ReadLine();
      }
    }

    public override void Clash(Player player) {
      throw new NotImplementedException();
    }
  }
}