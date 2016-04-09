using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikanustik.Entities.NPC {

  internal abstract class NPC : Entity {

    public static void BlackwoodTrain(Player player, int number, Action showPortrait) {
      Console.Clear();
      Menus.Bar();
      showPortrait();

      switch (number) {
        case 1:
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
          break;

        case 2:
          Console.Write("Helga:\n\"");
          Console.Write("Kommen wir zum nächsten Kampf! Deine Waffe ist nicht die einzige Instanz, die\nfür deinen Schaden zuständig ist! Es ist normal, dass du mindestens einen\nTreffer bei jedem Angriff landest; dein Gegner allerdings auch. Nun hast du\naber die Chance, mehrere Male zu treffen und zwar zufällig bis zum Maximalwert\ndeiner Ausdauer. Mehr Ausdauer, erhöht also die Chance, mehrfach Treffer\nlanden zu können. Beobachte dies bei deinem nächsten Kampf und sieh' dass\nnicht nur einzelne Werte wichtig sind, sondern ein perfektes Zusammenspiel\naus allem!");
          Console.Write("\"");
          Console.ReadLine();
          break;

        case 3:
          Console.Write("Helga:\n\"");
          Console.Write("Sehr gut. Wir haben bereits die Raserei, oder den Koller angesprochen. Diese\nFähigkeit lässt dich den Gegner einmal kritisch treffen, was den eingehenden\nSchaden verdreifacht! Dazu muss deine Genugtuung allerdings maximal sein.\nDie Wut im Kampf lädt sich bei jedem Schlagabtausch auf und entlädt sich nur\nbei einem Koller, oder nach der heilenden Einkehr am Ende des Kampfes. Solltest\ndu bereits überladen sein, wird sich nicht alle Wut entladen, sondern einen\nRest hinterlassen. Du kannst maximal ein Viertel deiner für den Koller nötigen\nGenugtuung pro Runde aufladen. Achte im folgenden Kampf darauf!");
          Console.Write("\"");
          Console.ReadLine();
          break;

        case 4:
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
          break;

        case 5:
          Console.Write("Reinhart:\n\"");
          Console.Write("Bevor Helga sisch hier mit deinem Training ganz meschugge macht, will icke\nooch noch wat beitrajen! Ick werde dir wat über Waffen vertellen. Du koofst\n'se bei mir für Jold und jegen 'nen Preis für meene Werkzeuge, kann ick\nWaffen sojar wieder zusammenflicken. Die Räpperatur wird teurer, je höher der\nMinimoolschooden der Waffe is' und je stärker du die Waffe schon\nverklöppelt has'. Rischig lohnen, tut sich das Einsetzen meener Werkzeuje also\nerst bei fetteren Waffen. Du konnscht den Gegnern eenen aufn Döötz hauen, mit\neenem zufälligen Wert zwischen dem minioolen und maximoolen Schaden deiner\nWaffe. Das hängt janz davon ab, wie juut deen Schwung so ausfällt. Kann vorher\nniemand versischern. Außerdem besteht eine 50% Schanse, dass deene Waffe beem\nKloppen ein Haltbarkeit verliern tut. Is' der Wert bei null, is' die Waffe\nim Oarsch und du kanns' nur noch mit 'de Mäusefäustschen kloppen. Das is'\nnisch zu empfehlen. Also achte im kommenden Kampf off deene Waffe, den\nSchooden und die Haltbarkeit. Und denke dran, dass deen Gegner dir och Schaden\nrinne kloppet!");
          Console.Write("\"");
          Console.ReadLine();
          break;

        case 6:
          Console.Write("Reinhart:\n\"");
          Console.Write("Wat' ick dir noch sajen kann, is' dat es eene Waffenklasse gibt. Die is'\nnisch so wischtich, aber ich sortiere meene Woffen nach Klinge, Flegel,\nStange, Oxt und Projektil. Die haben olle ihre Vorzüsche. Klingen sind\nausjewogen, Flegel halten viel uss, Stangen haben 'ne fette Reichwoite im\nSchaden, Äxte mochen dicke Löcher in die Geechner rin, und Projektilwaffen\nsind toll jegen Rüstungen der Geechner. Denn sie brechen durch olles duarsch.\nDann jibbet es noch Artefakte, das sind die fettesten Oschis unter jeder\n einzelnen Waffenklasse. Goiler Scheiß, wa?");
          Console.Write("\"");
          Console.ReadLine();
          break;

        case 7:
          Console.Write("Helga:\n\"");
          Console.Write("Nachdem du dich kennengelernt hast, wird es Zeit, deinen Gegner ebenfalls\nkennenzulernen! Wie du hat er eine lebenserhaltende Kraft, die ihn bei Verlust\numbringt. Ein Gegner hat jedoch die Chance von 50%, sich pro Runde um den\nWert seiner Selbstheilung zu erneuern. Daran solltest du denken. Außerdem\nignoriert auch der Gegner einen Teil des eingehenden Schadens. Und zwar die\nMenge des Rüstwertes als Prozentsatz von deinem Schaden. Wie aber auch bei\ndeiner Resilienz gilt, dass sich das bei geringem Schadenseinkommen nicht\nbemerkbar machen kann. Erst später, wenn du und deine Gegner beträchtlichen\nSchaden austeilt und pariert. Und selbstverständlich teilt auch dein Gegner\neinen Wert an Schaden aus, der seinem Angriff entspricht. Hüte dich also vor\ndeinem Gegner und beobachte ihn im folgenden Kampf genau!");
          Console.Write("\"");
          Console.ReadLine();
          break;

        case 8:
          Console.Write("Helga:\n\"");
          Console.Write("Du hast nun viel dazugelernt! Das wäre es so weit. Du bist bereit und musst\nnun stärker werden! Reinhart und ich werden dich begleiten und nach bestem\nWissen und Gewissen ausrüsten und lehren. Es wird spannend, dich wachsen zu\nsehen. Nun schlage dich zu unserem Wohnmobil durch! Von dort aus, können wir\nweiter planen. Siehst du den Lindwurm dort drüben? Übe dein neues Wissen doch\nmal an diesem starken Biest!");
          Console.Write("\"\n");
          Console.ReadLine();
          Console.WriteLine($"\n{player.Name}:\n\"Es gibt stärkere Drachen als Lindwürmer, aber ich werde diesen hier nicht\nunterschätzen. Ich bin gerade erst wieder im Geschäft...\"");
          Console.ReadLine();
          break;

        default:
          throw new NotImplementedException($"BlackwoodTrain #{number} not defined");
      }
    }
  }
}