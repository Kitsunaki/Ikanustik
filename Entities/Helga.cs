using System;
using Ikanustik.Entities._01Schwarzwald;

namespace Ikanustik.Entities {

  internal class Helga {

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

    public static void BlackwoodTrain1(Player player) {
      Console.Clear();
      Menus.Bar();
      Portrait();
      Console.Write("Helga:\n\"");
      Console.WriteLine("Gut, hier beginnt deine erste Lektion! Schauen wir, was dich am Leben erhält.\nDein Vitae oder Chakra, dass in dir fließt, nimmt bei Verletzungen ab.\nFließt es nicht mehr, bist du tot. Dein Tod ist das, was wir vermeiden wollen.\nAlso achte auf deine Lebenskraft! Allerdings fließt noch eine Macht in dir.\nEtwas dass sich Prana, Pneuma, Qi, Ruach, Astralenergie, Psi oder Mana nennt.\nEs ist ein weiterer Strom in dir, der die Energien dieser Welt lenken kann.\nWie du über die Welt denkst, so wird sie sich dir zeigen. Dein Mana ist für\nmagische Praxis essentiell! Du kannst mit Mana auch deine Lebenskraft erneuern.\"");
      Console.ReadLine();
      Console.WriteLine($"\n{player.Name}:\n\"Ich erinnere mich, dass ich einen leichten Heilzauber beherrsche.\"");
      Console.ReadLine();
      Console.WriteLine("Helga:\n\"Genau! Zwischen den Kämpfen kann ich dir weitere Zauber beibringen und dir\nzeigen, wie du durch dein Mana deinen Körper umstrukturierst. Dein Körper ist\neine alchemistische Maschine aus halbkristallinem Wasser. Das klingt komisch,\nbedeutet aber nur, dass die Magie auch deinen Körper stärken kann. So sagen\nes die Lehrbücher. Dein Mana erholt sich auch während Kämpfen automatisch,\nallerdings nur langsam. Du hast allerdings eine starke Gabe. Nach jedem Kampf\nverlangt es nur ein wenig Einkehr und dein Mana und deine Lebenskraft\nfüllen sich wieder komplett. Dafür kommst du allerdings auch zur Ruhe und\nverlierst deine Raserei.\"");
      Console.ReadLine();
      Console.WriteLine($"{player.Name}:\n\"Das habe ich schon bemerkt. Aber Raserei frischt sich im Kampf\ndann ja wieder auf!\"");
      Console.ReadLine();
      Console.WriteLine("Helga:\n\"Ja das ist richtig, aber das ist ein anderes Thema. Übe deine Kenntnisse\nerstmal am nächsten Gegner. Achte auf Lebenskraft und Mana und setze beides\nmit Bedacht ein.\"");
      Console.ReadLine();
    }

    public static void BlackwoodTrain2(Player player) {
      Console.Clear();
      Menus.Bar();
      Portrait();
      Console.Write("Helga:\n\"");
      Console.Write("Kommen wir zum nächsten Kampf! Deine Waffe ist nicht die einzige Instanz, die\nfür deinen Schaden zuständig ist! Es ist normal, dass du mindestens einen\nTreffer bei jedem Angriff landest; dein Gegner allerdings auch. Nun hast du\naber die Chance, mehrere Male zu treffen und zwar zufällig bis zum Maximalwert\ndeiner Ausdauer. Mehr Ausdauer, erhöht also die Chance, mehrfach Treffer\nlanden zu können. Beobachte dies bei deinem nächsten Kampf und sieh' dass\nnicht nur einzelne Werte wichtig sind, sondern ein perfektes Zusammenspiel\naus allem!");
      Console.Write("\"");
      Console.ReadLine();
    }

    public static void BlackwoodTrain3(Player player) {
      Console.Clear();
      Menus.Bar();
      Portrait();
      Console.Write("Helga:\n\"");
      Console.Write("Sehr gut. Wir haben bereits die Raserei, oder den Koller angesprochen. Diese\nFähigkeit lässt dich den Gegner einmal kritisch treffen, was den eingehenden\nSchaden verdreifacht! Dazu muss deine Genugtuung allerdings maximal sein.\nDie Wut im Kampf lädt sich bei jedem Schlagabtausch auf und entlädt sich nur\nbei einem Koller, oder nach der heilenden Einkehr am Ende des Kampfes. Solltest\ndu bereits überladen sein, wird sich nicht alle Wut entladen, sondern einen\nRest hinterlassen. Du kannst maximal ein Viertel deiner für den Koller nötigen\nGenugtuung pro Runde aufladen. Achte im folgenden Kampf darauf!");
      Console.Write("\"");
      Console.ReadLine();
    }

    public static void BlackwoodTrain4(Player player) {
      Console.Clear();
      Menus.Bar();
      Portrait();
      Console.Write("Helga:\n\"");
      Console.Write("Hast du dich schonmal gefragt, wozu du Stärke besitzt? Oder Resilienz? Beides\nhat miteinander zu tun. Die vorhandene Stärke erhöht den maximalen Schaden, den\ndu mit einer Waffe anrichten kannst. Und zwar erhöhst du pro zehn Stärke,\ndeinen Maximalschaden um das Doppelte des Grundwertes. Sieh die Stärke also pro\nPunkt, als ein Zehntel des Grundmaximalschadens einer Waffe an. Deine Kraft\nlässt den Schaden gegen Gegner höher ausfallen. Wie du dich in den einzelnen\nGebieten letztendlich entscheidest, ist deine Sache. Niemand kann alles\nperfektionieren, aber jeder sollte über seine Kräfte Bescheid wissen.");
      Console.Write("\"\n");
      Console.ReadLine();
      Console.WriteLine($"\n{player.Name}:\n\"Und was hat der Stärkegrad mit meiner Resilienz zu tun? Resilienz ist doch\ndie Fähigkeit, mit Hinternissen im Leben umzugehen, oder?\"");
      Console.ReadLine();
      Console.Write("\nHelga:\n\"");
      Console.Write("Das ist in etwa richtig. Resilienz ist quasi die Resistenz gegenüber\neintreffendem Schaden. Du ignorierst mindestens den eingehenden Schaden in\nHöhe deiner Resilienz als Prozentsatz. Ein Resilienzpunkt, lässt dich also\nmindestens ein Prozent des eingehenden Schadens durch deine Robustheit und\nZähigkeit parieren. Die Stärke ist da der Gegenpol. Bis 25 Stärkepunkten,\nkannst du maximal einem Viertel des eingehenden Schadens widerstehen. Bis 45\nStärke schon der Hälfte; bis 75 Stärke drei Vierteln; bis 120 Stärke 90%;\nund ab 120 Stärke ignorierst du 95% des eintreffenden Schadens. Das klingt\nkryptisch. Merke dir einfach, dass deine Resilienz die Unterkante und deine\nStärke die Oberkante der Schadensmenge begrenzen, die du abwehren kannst.");
      Console.Write("\"\n");
      Console.ReadLine();
      Console.WriteLine($"\n{player.Name}:\n\"Ich muss ja nur das Prinzip verstehen, nicht die Werte auswendig kennen.\nEs klingt komplizierter, als es letztendlich ist. Dann stürze ich mich mal in\nden nächsten Kampf und denke dabei an meine Stärke und meine Resilienz! Dabei\nbekomme ich auch garantiert den Kopf frei!\"");
      Console.ReadLine();
    }

    public static void BlackwoodTrain7(Player player) {
      Console.Clear();
      Menus.Bar();
      Portrait();
      Console.Write("Helga:\n\"");
      Console.Write("Nachdem du dich kennengelernt hast, wird es Zeit, deinen Gegner ebenfalls\nkennenzulernen! Wie du hat er eine lebenserhaltende Kraft, die ihn bei Verlust\numbringt. Ein Gegner hat jedoch die Chance von 50%, sich pro Runde um den\nWert seiner Selbstheilung zu erneuern. Daran solltest du denken. Außerdem\nignoriert auch der Gegner einen Teil des eingehenden Schadens. Und zwar die\nMenge des Rüstwertes als Prozentsatz von deinem Schaden. Wie aber auch bei\ndeiner Resilienz gilt, dass sich das bei geringem Schadenseinkommen nicht\nbemerkbar machen kann. Erst später, wenn du und deine Gegner beträchtlichen\nSchaden austeilt und pariert. Und selbstverständlich teilt auch dein Gegner\neinen Wert an Schaden aus, der seinem Angriff entspricht. Hüte dich also vor\ndeinem Gegner und beobachte ihn im folgenden Kampf genau!");
      Console.Write("\"");
      Console.ReadLine();
    }

    public static void BlackwoodTrain8(Player player) {
      Console.Clear();
      Menus.Bar();
      Portrait();
      Console.Write("Helga:\n\"");
      Console.Write("Du hast nun viel dazugelernt! Das wäre es so weit. Du bist bereit und musst\nnun stärker werden! Reinhart und ich werden dich begleiten und nach bestem\nWissen und Gewissen ausrüsten und lehren. Es wird spannend, dich wachsen zu\nsehen. Nun schlage dich zu unserem Wohnmobil durch! Von dort aus, können wir\nweiter planen. Siehst du den Lindwurm dort drüben? Übe dein neues Wissen doch\nmal an diesem starken Biest!");
      Console.Write("\"\n");
      Console.ReadLine();
      Console.WriteLine($"\n{player.Name}:\n\"Es gibt stärkere Drachen als Lindwürmer, aber ich werde diesen hier nicht\nunterschätzen. Ich bin gerade erst wieder im Geschäft...\"");
      Console.ReadLine();
    }
  }
}