using System;
using System.Linq;
using Ikanustik.Entities;
using Ikanustik.Entities._01Schwarzwald;
using Ikanustik.Entities.NPC;

namespace Ikanustik {

  internal class Game {

    private static void Main(string[] args) {

      #region Einleitung

      string version = "1.8.6";
      double zeilen = 160403;

      Console.SetWindowSize(80, 50);
      Player player = new Player();
      Console.WriteLine("Liebe Grüße vom Entwickler. Viel Spaß im Spiel!");
      Console.ReadLine();
      Console.Write("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMMMMMMMMNNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMMMMMMMMMMMNMMMMMMMMMMMMMMMMMMMMMMMMMMNMMMMMMMMMMMMMMMMMMMMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNMMMMMMNMMDMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMMMMMMNMNMMMMMMMMMMMMMMMMMMMMMDMNNMMMMMMDMMMMMMMMMMMMMMMDMMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMMMMMNMMMMMMMMMMMMMMMMMMMMMMNMMNMMMNMMNMMNMDMMMNMMMMMMMMMNMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMMMMNMMMMMMMMMMNMMMMMMMMMMMMNMNNNMMMMNMMMNNMNMMMMMMMMMMMNMMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMMMMNMMMMMMMMMMMMMMMMMMMNMMDNNDDNMNNNNNN8DNNNMMMMMMMMMMMMNMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMMMMMMMMNMMMMMNMMMMMMNMNNNNNDDDNNNNNNDDDDNDNDNNMNMMMMMMMMNMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMMMMMMNNMMMMMMNMMMMMMMMNZNNDNNNZDDNNDDOO8DDO88DDNM8MMMMMMNMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMMMNMMMNMMMMMMMMMMMMMMNMDDDNDDDNDDN8$D8O8O8ZZZD88NODNMMMMDMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMMMMMMMDNMNMMNMNMMMMMMNM8DDDDN88D8DDZO8Z8888ODOZODZIDDNMNDMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMMMMMMMNNNNNMDNMMNDMNDMNNMN8D8DZNZ8OO88D88D8DNOOO?DZ8ONDDOMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMMMMMMMMNDND8MMMMMMNDMNDNNNDDD8DOZ8D88DDDDDNNNNNDMMNNNNONMMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMMMMMMNNDDM8Z8MMMMMMMDONDN8D8NNDZ88ODNNNMMMM8N$MMMMMMMMDOMMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMMMMMMMMDNNNZ8DMMDMMON$ZIO8$IZ8ZZO88DODMMMMMMMMNMNMMNMNMNMMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMMMMMMMNN8NNDD8NNDNNMDDDZZ8DZZZD8OO8N8MNNMMMMMMMMMMMMMMMMMMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMMMMMMMNNDNMDMD88D8Z$8?7$77?$$I$$$$+=7O8DDMMMMMMMMMMMNMMMMMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMMMMMMMNNNNMN8N$ZD8==?++Z:8DN$,+=I+=~~:~~+ONMMMMMMMMMMMNMMMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMMMMMMMMMNDNNMMDOD7$~~:~~,:8$..::::=~:,,:~8=DMNNNMMMMMMMMMMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMMMMMMNMMMMNNMNNNODZ=:,::=::::~~:,:::,,.,====+78DMMMMMMMMMMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMMMMMMMMMMMNNMMNNO=+:,,,,,,:,,,,,,:::,,.,~=~~==+$8NMMMMMMMMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMDND?=~~:,,,,,,,,,,,,::::,,.,:+~:~~+??NMMMMMMMMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMD7?+==~::,,,,,,,,,,,:,,,,,..:+~~~~=+7MMMMMMMMMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMMMMMMMMMNMMMZ??++~~:::,,,,,,,,,::,,,,,..:?~::~=INNNNDMMMMMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMM$??+=~~~::,,,,,,,,,:::::,,..,+~~~=?8N8OO$?DMMMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMD??+==~~:::,,,,,,,:~~:::,,,.,~~~=?DMZ+=++==MMMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMOI++==~~:::,,,,,,,,~::::,,,.,:?+?DMN~:::::~MMMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMMMMMMMMMMMM77D?++==~~~::,,,,,,,:===~::,,,~O?ZMM=::::::~MMMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMMMMMMMMMMM,?I7$?+===~~~::,,,,,,,,,,::?=~+D+IMM=::::::~=MMMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMMMMMMMMMMZ$+?+7Z?++==~~~:,:,,,,,,,,,:::=+??8M+::::::::=MMMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMMMMMMMMM.O+=+++?O?+====~~::::::,,,.,,::=?7IMI~~:::::::=MMMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMMMMMMMZ,D+=~+==+=Z?+++==~~~~~~I7I7II+7$I+7MI::::~::::::MMMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMMMMMM?,,+=~~==~=~~$$+===~~~:::~~~::~~~+?$NN:~:::::::::~MMMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMMMMM?:,,,~:~~~~~=~~?Z?==~~~~~~~~~=++I+?$8N7:~~~:::::::~MMMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMMMM~=Z,,..,::::~~~~~=Z+=~~::::~:~~~~~++IN?:,=:::::::~::MMMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMM8~=~I,,....::::::~~~~ZZ=~~:::,,::::~~+O$=~,~::::::~~:~$MMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMMMI~=,,.........:::::::~~7Z+=~::::::~~~+7D~:,~:::,:::::::=MMMMMM");
      Console.Write("MMMMMMMMMMMMMMMMM7=,,,,,.........,.,:::::~+ZOZ?=====++IND~:.,:,::::::::::~MMMMMM");
      Console.Write("MMMMMMMMMMMMMMMM?~:,,................,..,,,,ZDDNNNDDDNND~,,:,,,,,:::::::~~7MMMMM");
      Console.Write("MMMMMMMMMMMMMMMI::~,,,.................,......+8DDNNNN7,,:~,,,,::==:=+::~:~MMMMM");
      Console.Write("MMMMMMMMMMMMMM=~=~,,..............................,,,,,,:,,,,,,=::::::::~~~MMMMM");
      Console.Write("MMMMMMMMMMMMM+:....=..............................,,,,,,,,,,,~,,~,:+?:::~:~8MMMM");
      Console.Write("MMMMMMMMMMMM:...................................,...,,,,,,,,::,:,~:==,~::~~~MMMM");
      Console.Write("MMMMMMMMN,,........................................,,,,,,,,,,:,+,::::::::~~~8MMM");
      Console.Write("MMMMMM7,,.........,...............................,,,,,,,,:,,,,+,:,=:,::,~+~+MMM");
      Console.Write("MMMMM:,.....,.,...................,,,...............,,,,,,,,:,:,:::,,::::~I+~MMM");
      Console.Write("MMMM,,,.,,,,..........,......,...................,..,,,,,,,,::,,,,:,,,::::I~~ZMM");
      Console.Write("MMM.,,,,...........,,....,,,,,...,..............,.,,,,,,,,,,:,,:,:,=,:+:+:::~~MM");
      Console.Write("MM:,,..,,,,,,........,......,..................,,,,,,,,:,,,,,,,,,,~,:,7:::::~~MM");
      Console.Write("M=..,,,,,,.,,,...,.............,................,,,,,,,,,,:,,,,,,=,,=::,~::::~NM");
      Console.Write("O,,,~,,,,,,....,,..,..........................,...,,,,,,,,,,,,,,,,,,,,~:~:==:~IM");
      Console.Write("\nWie ist dein Name: ");
      player.Name = Console.ReadLine();
      if (player.Name == "") {
        Console.Clear();
        Console.Write(new String('\n', 10));
        Console.WriteLine("Da du zu doof bist, einen Namen einzugeben, nenne ich dich einfach \"Horst!\"");
        System.Threading.Thread.Sleep(4400);
        player.Name = "Horst";
        Console.Clear();
      }
      player.Score++;
      Console.Write("\nWelches Geschlecht hast du? (m)ännlich oder (w)eiblich? Bitte eingeben: ");
      string gend = Console.ReadLine();
      string anred = "Yo";
      player.Score++;
      if (gend == "m") {
        anred = "Herr";
      } else if (gend == "w") {
        anred = "Frau";
      }
      Console.WriteLine("\nFreut mich " + anred + " " + player + ". Dein Punktestand beträgt erst " + player.Score + " Punkte. Drücke Enter, um \nins Hauptmenü zu gelangen!\n");
      Console.WriteLine("Wähle dort das gewünschte Kapitel, oder gebe den gewünschten Code ein, um \nbereits gespielte Kapitel anzurechnen. Wähle die Kapitel durch Eingabe der \nZahl des Kapitels. Im Zweifelsfall geht es immer mit Enter weiter. Sammele \nPunkte und Erfolge. Viel Spaß! Punkte sammelt man Hauptsächlich durch \nMinispiele und den Beginn der Story des Hauptspiels. Im Hauptspiel zählen \nandere Werte, wie Gold und Erfahrung.");
      Console.WriteLine("________________________________________________________________________________");
      Console.ReadLine();

      #endregion Einleitung

      #region Menü in Dauerschleife

      do {
        Console.Clear();
        Console.Beep();

        Menus.MainMenu(player, version, zeilen);
        Menus.ChooseGame(player, zeilen, version);
      } while (player.Score <= 1000);

      #endregion Menü in Dauerschleife
    }

    #region Tutorials

    public static void TutorialTERM(Player player, bool tut1) {
      int scoreup = 1;
      Console.WriteLine("Ich gebe dir die Möglichkeit, deinen Punktestand durch Eingabe von \n\"whoop\" ein wenig zu erhöhen. Das geht fünf mal! Du wirst hier und da ein\npaar Punkte für deine Zeit mit mir bekommen!\n");

      while (scoreup <= 5) {
        string eingabe1 = Console.ReadLine();
        if (eingabe1 == "whoop") {
          player.Score++;
          scoreup++;
          Console.WriteLine("\nDer Punktestand erhöht sich auf " + player.Score + "!\n");
        } else {
          Console.WriteLine("Bitte erst fünf mal den Punktestand erhöhen!\n");
        }
      }

      Console.WriteLine("Du durchläufst nun quasi ein Tutorial. Das heißt nur, dass wir ein bisschen\nherumgemmeln und ein wenig testen. So lernst du meine Funktionsweise besser \nkennen.");

      double brutto = 0;
      double maerchensteuer_satz = 0.19;
      double netto = 0;
      double maerchensteuer = 0;

      Console.WriteLine("Ich bitte dich in Gesprächen, dich möglichst nah an meine Vorgaben zu halten.\nIch bin noch ein ganz junges Programm und könnte manches missverstehen.");
      Console.WriteLine("Kommen wir mal zu etwas Smalltalk! Für wie viel Geld, würdest du dir ein \nThermometer kaufen? Bitte als ganze Zahl eingeben.\n");
      brutto = double.Parse(Console.ReadLine());

      netto = brutto / (1 + maerchensteuer_satz);
      maerchensteuer = brutto - netto;

      Console.Write("\nBei {0:N2}", brutto);
      Console.Write(" Euronen Kosten und einem Märchensteuersatz \nvon {0:p}", maerchensteuer_satz);
      Console.Write(", kostet es nur {0:N2} Euronen", netto);
      Console.Write(" an sich \nund man muss {0:N2} Euronen", maerchensteuer);
      Console.Write(" an den gierigen Staat abtreten.");

      double celsius, fahrenheit, kelvin;

      Console.WriteLine("\nWie viel Grad hast du schätzungsweise bei dir im Zimmer?\n");

      celsius = double.Parse(Console.ReadLine());
      fahrenheit = ((celsius * 9) / 5) + 32;
      kelvin = celsius + 273.15;

      Console.Write("\nEine Temperatur von {0:F0}", celsius);
      Console.Write(" °C, geben die Ammis lieber \nals {0:F0}", fahrenheit);
      Console.Write(" °F, und Wissenschaftler lieber als {0:F0}", kelvin);
      Console.Write(" °K aus.");
      player.Score += 5;
      tut1 = true;
      Console.WriteLine("\n\nDer Code für Tutorial 1 lautet \"475192\" und wird nach Neustart über \ndie Codeeingabe eingegeben, den Fortschritt wieder anrechnen. Drücke \nEnter, um zurück ins Hauptmenü zu gelangen.");
      Console.WriteLine("________________________________________________________________________________");
      Console.ReadLine();
    }

    public static void TutorialCARB(Player player, bool tut2) {
      Console.WriteLine("\nIch habe hier jede Menge verbrannte Waffeln mit klebriger Carbonara. Hat da \njemand Interesse an ein paar davon?\n");
      string eingabe2 = Console.ReadLine();
      if (eingabe2 == "nein" || eingabe2 == "Nein") {
        Console.WriteLine("\nNicht so zurückhaltend! Ich hatte die extra eine Woche im Kühlschrank.");
        player.Score += 1;
      } else if (eingabe2 == "ja" || eingabe2 == "Ja") {
        Console.Write("\nDein Stahlmagen ist bewundernswert! ");
        player.Score += 3;
      } else {
        Console.Write("\nNanana, nicht ablenken! Kommen wir zum Geschäftlichen! ");
        player.Score += 2;
      }

      Console.WriteLine("Wie hoch ist die gewünschte Menge \nan Carbonara-Briketts? Nicht geizen, es gibt Staffelrabatt!\n");
      int stueck = int.Parse(Console.ReadLine());
      player.Score += 1;
      Console.WriteLine("\nOk und wie viel Geld, wäre dir eine Waffel wert?\n");
      double preis = double.Parse(Console.ReadLine());
      player.Score += 1;
      double summe = stueck * preis;
      if (stueck >= 20) {
        double sparen = summe / 10;
        summe = summe - sparen;
        Console.WriteLine("\nDicker Erlass! Du sparst ganze " + sparen + " Euro und musst nur \nnoch " + summe + " Euro Entgelt entrichten, sobald wir uns mal sehen.");
        player.Score += 3;
      } else if (stueck >= 10) {
        double sparen = summe / 20;
        summe = summe - sparen;
        Console.WriteLine("\nImmer noch gut gespart! Du sparst ganze \n" + sparen + " Euro und musst nur noch " + summe + " Euro Entgelt entrichten, \nsobald wir uns mal sehen.");
        player.Score += 2;
      } else if (stueck == 0 || preis == 0) {
        Console.WriteLine("\nHaha, dann eben nicht. Naja man kann nicht alles haben!");
        player.Score += 1;
      } else {
        Console.WriteLine("\nFür die geringe Menge, gibt es leider keinen Rabatt. Zu Zahlen sind \ndann " + summe + " Euro, sobald wir uns mal sehen.");
        player.Score += 1;
      }

      tut2 = true;
      Console.WriteLine("\nDer Code für Tutorial 2 lautet \"939716\" und wird nach Neustart über \ndie Codeeingabe eingegeben, den Fortschritt wieder anrechnen. Drücke \nEnter, um zurück ins Hauptmenü zu gelangen.");
      Console.WriteLine("________________________________________________________________________________");
      Console.ReadLine();
    }

    public static void TutorialBMI(Player player, bool tut3) {
      double kilo;
      double gross;
      double alter;
      double bmi;

      Console.Write("\nLass uns doch mal auf deine Gesundheit schauen. Ich weiß, dass der BMI \nnicht alles ist, aber er ist ein guter Rahmen. Wie viel wiegst du in Kilo? \nBitte als ganze Zahl eintragen.\n\nGewicht: ");
      kilo = int.Parse(Console.ReadLine());
      player.Score += 1;
      Console.Write("\nGut und wie groß bist du in Zentimetern? Es reichen auch ungefähre Werte!\n\nGröße: ");
      gross = int.Parse(Console.ReadLine());
      player.Score += 1;
      Console.Write("\nViele wissen es nicht, aber das Alter spielt eine Rolle. Also wie alt bist \ndu? Ich verrate es auch nicht weiter.\n\nAlter: ");
      alter = int.Parse(Console.ReadLine());
      player.Score += 1;
      bmi = (gross / 100 * gross / 100);
      bmi = kilo / bmi;

      if (alter <= 18) {
        Console.WriteLine("\nDu bist mit " + alter + " Jahren noch zu jung. Erst\nab 19 ist der BMI zu vergeben.");
      } else if (alter >= 19 && alter <= 24) {
        if (bmi >= 19 && bmi <= 24) {
          Console.WriteLine("\nMit einem BMI von " + bmi + " bist du in deiner \nAltersklasse gesund unterwegs!");
        } else if (bmi < 19) {
          Console.WriteLine("\nMit einem BMI von " + bmi + " hast du in deiner \nAltersklasse Untergewicht, iss mal mehr!");
        } else {
          Console.WriteLine("\nMit einem BMI von " + bmi + " hast du in deiner \nAltersklasse Übergewicht. Beweg' dich besser mal mehr.");
        }
      } else if (alter >= 25 && alter <= 34) {
        if (bmi >= 20 && bmi <= 25) {
          Console.WriteLine("\nMit einem BMI von " + bmi + " bist du in deiner \nAltersklasse gesund unterwegs!");
        } else if (bmi < 20) {
          Console.WriteLine("\nMit einem BMI von " + bmi + " hast du in deiner \nAltersklasse Untergewicht, iss mal mehr!");
        } else {
          Console.WriteLine("\nMit einem BMI von " + bmi + " hast du in deiner \nAltersklasse Übergewicht. Beweg' dich besser mal mehr.");
        }
      } else if (alter >= 35 && alter <= 44) {
        if (bmi >= 21 && bmi <= 26) {
          Console.WriteLine("\nMit einem BMI von " + bmi + " bist du in deiner \nAltersklasse gesund unterwegs!");
        } else if (bmi < 21) {
          Console.WriteLine("\nMit einem BMI von " + bmi + " hast du in deiner \nAltersklasse Untergewicht, iss mal mehr!");
        } else {
          Console.WriteLine("\nMit einem BMI von " + bmi + " hast du in deiner \nAltersklasse Übergewicht. Beweg' dich besser mal mehr.");
        }
      } else if (alter >= 45 && alter <= 54) {
        if (bmi >= 22 && bmi <= 27) {
          Console.WriteLine("\nMit einem BMI von " + bmi + " bist du in deiner \nAltersklasse gesund unterwegs!");
        } else if (bmi < 22) {
          Console.WriteLine("\nMit einem BMI von " + bmi + " hast du in deiner \nAltersklasse Untergewicht, iss mal mehr!");
        } else {
          Console.WriteLine("\nMit einem BMI von " + bmi + " hast du in deiner \nAltersklasse Übergewicht. Beweg' dich besser mal mehr.");
        }
      } else if (alter >= 55 && alter <= 64) {
        if (bmi >= 23 && bmi <= 28) {
          Console.WriteLine("\nMit einem BMI von " + bmi + " bist du in deiner \nAltersklasse gesund unterwegs!");
        } else if (bmi < 23) {
          Console.WriteLine("\nMit einem BMI von " + bmi + " hast du in deiner \nAltersklasse Untergewicht, iss mal mehr!");
        } else {
          Console.WriteLine("\nMit einem BMI von " + bmi + " hast du in deiner \nAltersklasse Übergewicht. Beweg' dich besser mal mehr.");
        }
      } else {
        if (bmi >= 24 && bmi <= 29) {
          Console.WriteLine("\nMit einem BMI von " + bmi + " bist du in deiner \nAltersklasse gesund unterwegs!");
        } else if (bmi < 24) {
          Console.WriteLine("\nMit einem BMI von " + bmi + " hast du in deiner \nAltersklasse Untergewicht, iss mal mehr!");
        } else {
          Console.WriteLine("\nMit einem BMI von " + bmi + " hast du in deiner \nAltersklasse Übergewicht. Beweg' dich besser mal mehr.");
        }
      }
      player.Score += 5;
      tut3 = true;
      Console.WriteLine("\nDer Code für Tutorial 3 lautet \"477501\" und wird nach Neustart über \ndie Codeeingabe eingegeben, den Fortschritt wieder anrechnen. Drücke \nEnter, um zurück ins Hauptmenü zu gelangen.");
      Console.WriteLine("________________________________________________________________________________");
      Console.ReadLine();
    }

    public static void TutorialSCHL(Player player, bool tut4) {
      int eingabe;
      int deutsch = 0;

      while (deutsch == 0) {
        Console.WriteLine("\nWelche Schulnote hattest du in deutsch?\n");
        eingabe = int.Parse(Console.ReadLine());
        switch (eingabe) {
          case 1:
            Console.Write("\nIm wahrsten Sinne des Wortes, sehr gut!");
            deutsch = deutsch + 1;
            break;

          case 2:
            Console.Write("\nImmer noch gut genug, um sich damit nicht verstecken \nzu müssen.");
            deutsch = deutsch + 1;
            break;

          case 3:
            Console.Write("\nBefriedigend, also hast du zumindest mitgearbeitet.");
            deutsch = deutsch + 1;
            break;

          case 4:
            Console.Write("\nAusreichend. Nun, ich habe meine Hausaufgaben auch \nimmer erst im Bus erledigt.");
            deutsch = deutsch + 1;
            break;

          case 5:
            Console.Write("\nMangelhaft. Das muss nun wirklich nicht sein. Du \nkannst doch sprechen?");
            deutsch = deutsch + 1;
            break;

          case 6:
            Console.Write("\nUngenügend. Warst du überhaupt da?");
            deutsch = deutsch + 1;
            break;

          default:
            Console.Write("\nHm, " + eingabe + "? Das glaube ich nicht. Zensuren \ngehen nur von 1 bis 6. Nochmal!");
            if (player.Score <= 16) {
              player.Score += 1;
              Console.WriteLine("Bonuspunkt für Vertippen!");
            }
            break;
        }
      }
      Console.WriteLine(" Danke für deine Ehrlichkeit!\n");
      player.Score += 2;

      string njain;

      Console.WriteLine("Magst du Mathe? Ich verstehe ja oder nein auch auf Englisch, Französisch \noder auch Japanisch.\n");
      njain = Console.ReadLine();
      switch (njain) {
        case "ja":
        case "yes":
        case "oui":
        case "hai":
          Console.Write("\nNun, dann können wir ja etwas rechnen!");
          player.Score += 2;
          break;

        case "nein":
        case "no":
        case "non":
        case "iie":
          Console.Write("\nNicht? Dann lass uns mal daran arbeiten. Lass uns rechnen.");
          player.Score += 1;
          break;

        default:
          Console.Write("\nIch habe die Eingabe nicht verstanden. Egal, lass uns rechnen!");
          player.Score -= 1;
          break;
      }

      double zahl1;
      double zahl2;
      string opera;

      Console.WriteLine(" Gib eine erste Zahl ein.\n");
      zahl1 = double.Parse(Console.ReadLine());
      Console.WriteLine("\nGib die zweite Zahl ein.\n");
      zahl2 = double.Parse(Console.ReadLine());
      Console.WriteLine("\nWähle den Operator. - Plus - Minus - Mal - Durch -\n");
      opera = Console.ReadLine();

      if (opera == "Plus" || opera == "plus" || opera == "+") {
        Console.Write("\nDas Ergebnis lautet ");
        Console.Write(zahl1 + zahl2);
        Console.Write(".");
      } else if (opera == "Minus" || opera == "minus" || opera == "-") {
        Console.Write("\nDas Ergebnis lautet ");
        Console.Write(zahl1 - zahl2);
        Console.Write(".");
      } else if (opera == "Mal" || opera == "mal" || opera == "*" || opera == "x") {
        Console.Write("\nDas Ergebnis lautet ");
        Console.Write(zahl1 * zahl2);
        Console.Write(".");
      } else if (opera == "Durch" || opera == "durch" || opera == ":" || opera == "/" || opera == "geteilt") {
        Console.Write("\nDas Ergebnis lautet ");
        Console.Write(zahl1 / zahl2);
        Console.Write(" . Der Rest ist ");
        Console.Write(zahl1 % zahl2);
        Console.Write(".");
      } else {
        Console.WriteLine("\nDas war eine inkorrekte Eingabe und gibt Punktabzug!");
        player.Score -= 1;
      }
      player.Score += 1;

      int setQua;
      int setFib;
      int setDopp;

      Console.WriteLine("\nBis zu welcher Zahl soll ich dir die Quadratzahlen aufzählen?\n");
      setQua = int.Parse(Console.ReadLine());
      player.Score += 1;
      Console.WriteLine();
      double quadrat = 1;
      while (quadrat < setQua) {
        Console.WriteLine("Das Quadrat von " + quadrat + " ist " + (quadrat * quadrat) + ".");
        quadrat++;
      }

      Console.WriteLine("\nDie Fibonacci-Reihe ist eine Zahlen-Reihe, dessen zweiter Summand mit der \nletzten Summe, die nächste Summe bildet. Bis zu welcher Zahl, soll ich \ndiese Reihe vorführen?\n");
      setFib = int.Parse(Console.ReadLine());
      player.Score += 1;
      Console.WriteLine();
      double folge = 1;
      double folge2 = 2;
      while (folge <= setFib) {
        Console.Write(folge + " ");
        folge = folge + folge2;
        Console.Write(folge2 + " ");
        folge2 = folge2 + folge;
      }
      Console.WriteLine();

      Console.WriteLine("\nAuch ein lustiges Experiment: Eine Zahl immer wieder zu verdoppeln. Bis zu \nwelchem Maximalwert soll ich das vorführen?\n");
      setDopp = int.Parse(Console.ReadLine());
      player.Score += 1;
      Console.WriteLine();
      double doppel = 1;
      while (doppel <= setDopp) {
        Console.Write(doppel + " ");
        doppel = doppel * 2;
      }
      Console.WriteLine();

      Console.WriteLine("\nHier ein wenig Kunst :3 \n");
      for (int i = 10; i >= 0; i--) {
        Console.Write("");
        for (int j = i; j >= 0; j--) {
          Console.Write(j + " ");
        }
        Console.WriteLine();
      }

      int start;
      int rzahl1 = 0;
      Console.WriteLine("\nGib mal eine Zahl ein. Ich zähle dann von 1 bis du deiner eingegebenen Zahl.\n");
      rzahl1 = int.Parse(Console.ReadLine());
      player.Score += 1;
      Console.WriteLine();
      for (start = 1; start != rzahl1; start++) {
        Console.Write(start + " ");
      }
      Console.Write(start);
      Console.WriteLine();

      int rzahl2 = 0;
      Console.WriteLine("\nGib mal eine Zahl ein. Ich zähle von deiner Zahl dann in Zweierschritten \nrunter.\n");
      rzahl2 = int.Parse(Console.ReadLine());
      player.Score += 1;
      Console.WriteLine();
      for (start = rzahl2; start >= 1; start = start - 2) {
        Console.Write(start + " ");
      }
      Console.WriteLine();

      int rzahl3 = 0;
      int aufab = 1;
      Console.WriteLine("\nNun zähle ich alleine auf 10 rauf und wieder runter.");
      for (rzahl3 = 1; rzahl3 > 0; rzahl3 = rzahl3 + aufab) {
        Console.Write(rzahl3 + " ");
        if (rzahl3 == 10) {
          aufab = -1;
        }
      }
      Console.WriteLine();

      int Saktuell = 0;
      int Smenge = 0;
      int Smin = 0;
      int Smax = 0;
      Console.WriteLine("\nNaja, als Programm mag ich nunmal Mathe. Denn für Programme gibt es nur \nEinsen und Nullen. Computer sind nicht schlau, nur schnell. Gib nun wahllos \neine Zahl ein und bestätige sie mit Enter. Ich sage dann etwas dazu. Das geht \nein paar Mal, abhängig von deinem Punktestand.\n");
      do {
        Saktuell = int.Parse(Console.ReadLine());
        Smenge++;
        Console.Write("\nDu hast bereits " + Smenge + " Zahlen eingegeben. ");
        while (Smax <= 0) {
          Smax = Saktuell;
        }
        while (Smin == 0) {
          Smin = Saktuell;
        }
        if (Saktuell > Smax) {
          Smax = Saktuell;
        }
        if (Saktuell < Smin) {
          Smin = Saktuell;
        }
        Console.WriteLine("Die kleinste getippte Zahl war \neine " + Smin + " und die größte Zahl war eine " + Smax + ". Und nun?\n");
      } while (Smenge <= (player.Score / 3));
      player.Score += 7;
      Console.WriteLine("Das sollte erstmal genügen. Ich entwickle mich ständig weiter. Und das \nnur, weil mein Programmierer in der Ausbildung ein wenig Langeweile \nhat und rumprobiert.");
      tut4 = true;
      Console.WriteLine("\nDer Code für Tutorial 4 lautet \"897933\" und wird nach Neustart über \ndie Codeeingabe eingegeben, den Fortschritt wieder anrechnen. Drücke \nEnter, um zurück ins Hauptmenü zu gelangen.");
      Console.WriteLine("________________________________________________________________________________");
      Console.ReadLine();
    }

    public static void TutorialLOT(Player player, bool tut5) {
      player.Score += 1;
      int aufgabe = 9;
      while (aufgabe != 5) {
        Console.WriteLine("\n\t\t\t  -----\tARRAYS\t-----\t\n\nWähle die Aufgabe:\n\n1)Notendurchschnitt \n2)Stundenlöhne \n3)Arrays befüllen und Berechnungen durchführen \n4)Lotto \n5)Ende \n");
        aufgabe = int.Parse(Console.ReadLine());

        try {
          if (aufgabe == 1) {
            int i = 0;
            Console.Write("\nWie viele Schulnoten willst du eingeben?: ");
            int menge = int.Parse(Console.ReadLine());

            double[] noten = new double[menge];
            for (i = 0; i < noten.Length; i++) {
              Console.Write("\nGib eine Schulnote ein: ");
              noten[i] = double.Parse(Console.ReadLine());
              Console.WriteLine("Eingelesen!");
            }

            double durchschnitt = noten.Sum() / noten.Length;
            Console.WriteLine("\nDein Notenschnitt liegt bei " + durchschnitt + "\n");
            player.Score += 7;
            Console.WriteLine("\nWeiter mit Enter...");
            Console.ReadLine();
            Console.Clear();
          } else if (aufgabe == 2) {
            int i = 0;
            int arbeiter = 1;
            int abteilung = 0;

            double[,] gehalt = new double[2, 4];
            Console.WriteLine("\nWir sammeln nun die Daten von 4 Mitarbeitern aus Abteilung 1 und 4 aus\nAbteilung 2.\n");

            for (i = 0; i < (gehalt.Length / 2); i++) {
              Console.Write("Abteilung 1: Bitte den Stundenlohn von Mitarbeiter " + (i + 1) + " eingeben: ");
              gehalt[0, i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (i = 0; i < (gehalt.Length / 2); i++) {
              Console.Write("Abteilung 2: Bitte den Stundenlohn von Mitarbeiter " + (i + 1) + " eingeben: ");
              gehalt[1, i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            do {
              Console.Write("Bitte die Zahl der gewünschten Abteilung angeben: ");
              abteilung = int.Parse(Console.ReadLine());
              Console.Write("Bitte die Zahl des gewünschten Mitarbeiters aus\nAbteilung " + abteilung + " eingeben, oder \"5\" um zum Menü zu gehen: ");
              arbeiter = int.Parse(Console.ReadLine());

              if (arbeiter <= 4) {
                Console.WriteLine("\nDer Stundenlohn von Mitarbeiter " + arbeiter + " entspricht " + gehalt[abteilung - 1, arbeiter - 1] + " Euro.");
                if (gehalt[abteilung - 1, arbeiter - 1] < 15) {
                  Console.WriteLine("Der Mitarbeiter ist ein Niedriglöhner.");
                }
                Console.WriteLine();
              } else if (arbeiter == 5 || abteilung == 5) {
                Console.WriteLine("Tschüß Abteilung 1 und 2.");
                arbeiter = 5;
                abteilung = 5;
              }
            } while (arbeiter != 5 || abteilung != 5);
            player.Score += 6;
            Console.WriteLine("\nWeiter mit Enter...");
            Console.ReadLine();
            Console.Clear();
          } else if (aufgabe == 3) {
            int i = 0;

            Console.WriteLine();
            double[] uebung3 = new double[5];
            for (i = 0; i < uebung3.Length; i++) {
              Console.Write("Gib eine Zahl ein: ");
              uebung3[i] = double.Parse(Console.ReadLine());
            }

            Console.Write("\nEingegeben wurden die Zahlen: ");
            foreach (double zahl in uebung3) {
              Console.Write(zahl + " ");
            }
            Console.Write(".");

            int[] zufalli = new int[5];
            Random zufalli1 = new Random();
            for (i = 0; i < zufalli.Length; i++) {
              zufalli[i] = zufalli1.Next(1, 101);
            }
            Console.Write("\n\nZufallszahlen: ");
            foreach (int zufalli2 in zufalli) {
              Console.Write(zufalli2 + " ");
            }
            Console.Write(".\n");
            Console.WriteLine("Die Summe der Zufallszahlen ist: " + zufalli.Sum() + " und der Mittelwert ist: " + (zufalli.Sum() / zufalli.Length) + ", die\nkleinste Zahl ist " + zufalli.Min() + " und die größte Zahl ist " + zufalli.Max() + ".");

            int puffer = zufalli[0];
            zufalli[0] = zufalli[4];
            zufalli[4] = puffer;
            puffer = zufalli[1];
            zufalli[1] = zufalli[3];
            zufalli[3] = puffer;

            Console.Write("Invertierte Ausgabe der Zahlen:");
            foreach (int zufalli2 in zufalli) {
              Console.Write(zufalli2 + " ");
            }
            Console.Write(".\n");

            Console.Write("\nGib eine beliebige Zahl an Kilometern ein: ");
            double ktemp = double.Parse(Console.ReadLine());
            double mtemp = ktemp * 0.621371;
            Console.WriteLine("\n" + ktemp + " Kilometer, werden in Amerika als " + mtemp + " Meilen angegeben. Wieso auch\nimmer man das alte angloamerikanische System, dem metrischen vorzieht.");
            player.Score += 6;
            Console.WriteLine("\nWeiter mit Enter...");
            Console.ReadLine();
            Console.Clear();
          } else if (aufgabe == 4) {
            int m;
            int[] lotto2 = new int[6];
            Random random = new Random();

            for (m = 0; m < lotto2.Length; m++) {
              int rand = random.Next(1, 50);
              for (int j = m - 1; j >= 0; j--) {
                if (lotto2[j] == rand) {
                  rand = random.Next(1, 50);
                  j = m;
                }
              }
              lotto2[m] = rand;
            }

            Console.Write("\nDie Lottozahlen lauten: ");
            foreach (int mischen2 in lotto2) {
              Console.Write(mischen2 + " ");
            }
            player.Score += 1;
            Console.WriteLine(".\n\nWeiter mit Enter...");
            Console.ReadLine();
            Console.Clear();
          } else if (aufgabe == 5) {
            Console.Write("\nZurück zum Hauptmenü.");
          }
        } catch {
          Console.WriteLine("\nFehlerhafte Eingabe. Punktabzug.");
          player.Score--;
          Console.Clear();
        }
      }
      tut5 = true;
      Console.WriteLine("\n\nDer Code für Tutorial 5 lautet \"141527\" und wird nach Neustart über \ndie Codeeingabe eingegeben, den Fortschritt wieder anrechnen. Drücke \nEnter, um zurück ins Hauptmenü zu gelangen.");
      Console.WriteLine("________________________________________________________________________________");
      Console.ReadLine();
    }

    public struct struktur {
      public int pernummer;
      public string pername;
      public string perfarbe;
    }

    public static void TutorialWOR(Player player, bool tut6) {
      string zeichenkette = "Eep";
      char zeichen;

      Console.Write("Gib' mal was ein: ");
      zeichenkette = Console.ReadLine();
      Console.Write("\nRevertierte Ausgabe: ");

      for (int i = zeichenkette.Length - 1; i >= 0; i--) {
        zeichen = zeichenkette[i];
        Console.Write(zeichen);
      }

      Console.Write("\n\nGib ein Wort ein und baue absichtlich ein Leerzeichen drin ein, wie einen \nabsichtlichen Fehler: ");
      string einwort = Console.ReadLine();
      Console.Write("Gib noch ein Wort ein, wieder mit undefiniert vielen Leerzeichen und auch \nA's darin: ");
      string zweiwort = Console.ReadLine();
      einwort = einwort.Replace(" ", "");
      zweiwort = zweiwort.Replace(" ", "");
      Console.WriteLine("\nIch habe aus " + einwort + " und aus " + zweiwort + " die Leerzeichen entfernt. \nMan kann auch bestimmen, ob ein Wort mit einem bestimmten Buchstaben beginnt, \nendet, einen Buchstaben an bestimmter Stelle enthält; man kann es aufteilen, \nvertauschen, vergleichen oder mit etwas auffüllen. Nett was alles geht.\n");
      einwort = einwort.Insert(2, "blah");
      zweiwort = zweiwort.Replace('a', 'b');
      Console.WriteLine("Ich habe nun im ersten Wort ab der zweiten Stelle blah eingefügt: " + einwort + " und beim \nzweiten Wort alle A's zu B's gewandelt: " + zweiwort);

      struktur mva;

      try {
        Console.WriteLine("\nDies ist ein Datensatz. Normalerweise kann man Werte aller Art speichern \nund wiedergeben. Das geht mit Werten, oder Arrays, oder eben Datensätzen\n(Strukturen.) Ich bin eine Struktur, eigentlich erst sinnvoll, wenn speichern \nund mehrere Benutzer möglich sind.");

        Console.Write("\nGib eine Nummer ein: ");
        mva.pernummer = int.Parse(Console.ReadLine());

        Console.Write("Gib einen Namen ein: ");
        mva.pername = Console.ReadLine();

        Console.Write("Gib eine Farbe ein: ");
        mva.perfarbe = Console.ReadLine();

        Console.WriteLine("\nDie eingegebene Nummer war: " + mva.pernummer);
        Console.WriteLine("Der eingegebene Name war: " + mva.pername);
        Console.WriteLine("Die eingegebene Farbe war: " + mva.perfarbe);
        Console.WriteLine("\nStrukturen sind erst nötig, wenn mehrere Datensätze im Spiel sind, aber ich\nwollte die Technik einer Struktur, hier schon mal austesten. Auch wenn man\nsie nur hinter den Kulissen erkennen kann.");
      } catch {
        Console.WriteLine("\nDie Eingabe war Fehlerhaft. Das gibt einen Punktabzug.");
      }
      player.Score += 11;
      tut6 = true;
      Console.WriteLine("\nDer Code für Tutorial 6 lautet \"320504\" und wird nach Neustart über \ndie Codeeingabe eingegeben, den Fortschritt wieder anrechnen. Drücke \nEnter, um zurück ins Hauptmenü zu gelangen.");
      Console.WriteLine("________________________________________________________________________________");
      Console.ReadLine();
    }

    #endregion Tutorials

    #region Vorspiele

    public static void GameZAHL(Player player, bool gam1) {
      Random zufall = new Random();
      int zzahl = zufall.Next(1, 101);
      int raten = 0;
      Console.Write("\nNach all dem trockenen Zeug, lass uns etwas spielen. Ich wähle eine Zahl \nzwischen 1 und 100. Rate, welche Zahl ich ausgesucht habe! ");
      do {
        Console.Write("Gib deine Wahl ein.\n\nRaten: ");
        raten = int.Parse(Console.ReadLine());
        if (raten < zzahl) {
          Console.Write("\nMeine Zahl ist größer, als deine geratene Zahl. ");
        } else if (raten > zzahl) {
          Console.Write("\nMeine Zahl ist kleiner, als deine geratene Zahl. ");
        }
      } while (raten != zzahl);

      Console.Write("\nDu hast es erraten " + player + "! ");
      player.Score += 9;

      Random zufall2 = new Random();
      int zzahl2 = zufall.Next(1, 251);
      int raten2 = 0;
      Console.Write("\nEinmal können wir noch raten, diesmal etwas schwerer. Ich denke nun an eine \nZahl zwischen 1 und 250! Viel Erfolg. ");
      do {
        Console.Write("Gib deine Wahl ein.\n\nRaten: ");
        raten2 = int.Parse(Console.ReadLine());
        if (raten2 < zzahl2) {
          Console.Write("\nMeine Zahl ist größer, als deine geratene Zahl. ");
        } else if (raten2 > zzahl2) {
          Console.Write("\nMeine Zahl ist kleiner, als deine geratene Zahl. ");
        }
      } while (raten2 != zzahl2);
      player.Score += 13;

      Random zufall3 = new Random();
      int zzahl3 = zufall.Next(1, 801);
      int raten3 = 0;
      Console.Write("\nWieder korrekt! Na dann eben noch schwerer. Ich denke nun an eine Zahl \nzwischen 1 und 800! Viel Erfolg! ");
      do {
        Console.Write("Gib deine Wahl ein.\n\nRaten:");
        raten3 = int.Parse(Console.ReadLine());
        if (raten3 < zzahl3) {
          Console.Write("\nMeine Zahl ist größer, als deine geratene Zahl. ");
        } else if (raten3 > zzahl3) {
          Console.Write("\nMeine Zahl ist kleiner, als deine geratene Zahl. ");
        }
      } while (raten3 != zzahl3);
      player.Score += 16;

      Random zufall4 = new Random();
      int zzahl4 = zufall.Next(1, 2501);
      int raten4 = 0;
      Console.Write("\nSuper, die war es! Dann nun ein letztes Mal. Ich denke nun an eine Zahl \nzwischen 1 und 2500! Viel Erfolg. ");
      do {
        Console.Write("Gib deine Wahl ein.\n\nRaten:");
        raten4 = int.Parse(Console.ReadLine());
        if (raten4 < zzahl4) {
          Console.Write("\nMeine Zahl ist größer, als deine geratene Zahl. ");
        } else if (raten4 > zzahl4) {
          Console.Write("\nMeine Zahl ist kleiner, als deine geratene Zahl. ");
        }
      } while (raten4 != zzahl4);
      player.Score += 20;
      Console.WriteLine("\nDas war mal wieder die richtige Wahl! Du bist gut. (Oder geduldig ;P)");
      gam1 = true;
      Console.WriteLine("\nDer Code für Spiel 1 lautet \"653546\" und wird nach Neustart über \ndie Codeeingabe eingegeben, den Fortschritt wieder anrechnen. Drücke \nEnter, um zurück ins Hauptmenü zu gelangen.");
      Console.WriteLine("________________________________________________________________________________");
      Console.ReadLine();
    }

    public static void GameHOT(Player player, bool gam2) {
      Console.WriteLine("\n\"Willkommen im Hotel 'Lumpen', ich hoffe der Aufenthalt wird angenehm \nverlaufen! Wenn nicht, ist auch gut!\"");
      double zpn = 30;
      double zpz = 40;
      double zph = 50;
      int bumo = 1;
      int tagö = 0;
      int bettz = 0;
      double hopr = 0;

      Console.Write("\n\"In welchem Monat möchtest du hier pennen? Bitte als Zahl angeben, wie üblich.\"\n\nMonat: ");
      bumo = int.Parse(Console.ReadLine());

      while (bumo < 1 || bumo > 12) {
        Console.Write("\n\"In der Schule haben wir gelernt, dass es keinen Dezwomber oder Jünanz gibt. \nWann also nun?\" \n\nMonat: ");
        bumo = int.Parse(Console.ReadLine());
      }
      player.Score += 2;

      Console.Write("\n\"Wie viele Nächte sollen gebucht werden?\n\nNächte: ");
      tagö = int.Parse(Console.ReadLine());

      while (tagö > 30) {
        Console.Write("\n\"In der Schule haben wir gelernt, dass ein Monat aus 30 Tagen und nicht \nmehr besteht. Also wie viele?\"\n\nNächte: ");
        tagö = int.Parse(Console.ReadLine());
      }
      player.Score += 1;

      while (bettz == 0 || bettz >= 3) {
        Console.Write("\n\"Wie viele Betten hättest du gern? Wir haben Einzelzimmer und Paarzimmer.\"\n\nBetten (1 oder 2): ");
        bettz = int.Parse(Console.ReadLine());
      }
      player.Score += 1;

      if (bumo == 1 || bumo == 2 || bumo == 11) {
        hopr = zpn * tagö;
        Console.Write("\n\"Das ist dann die Vorsaison");
      } else if (bumo == 7 || bumo == 8 || bumo == 12) {
        hopr = zph * tagö;
        Console.Write("\n\"Das ist dann die Hochsaison");
      } else {
        hopr = zpz * tagö;
        Console.Write("\n\"Das ist dann die Zwischensaison");
      }

      if (bettz == 2) {
        hopr = hopr * 1.5;
      }

      Console.WriteLine(" und es macht {0:F2} Euro für deinen Besuch \nin dem Hotel, dass selbst Gespenster verschreckt. Zum Abendessen bereite \nich noch klebrige Carbonara zu! Dein Zimmercode lautet \"miau\".", hopr);
      player.Score += 3;
      Console.WriteLine("\nDann mal Willkommen im Hotel.\" Als du dich in der Empfangshalle umsiehst,\nsiehst du einen Getränkeautomaten. Du schaust auf das Bedienfeld.\n");
      double auwasser = 0.50;
      double aulimonade = 1.00;
      double aubier = 2.00;
      double auredbull = 3.50;
      double aukakao = 1.75;
      double aubarcadi = 4.99;
      string augetrauswahl = "";
      int audosen = 0;
      double aupreis = 0;
      double aueinwurf = 0;
      int aui = 0;
      int eingabeaut = 0;

      Console.Write("    ---    Getränkeautomat    ---    Version 1.0    ---    Geöffnet    ---\n\nWählen Sie ihr Getränk aus:\n\n1) Wasser\t\t (0,50 Euro)\n2) Limonade\t\t (1,00 Euro)\n3) Bier\t\t\t (2,00 Euro)\n4) Red Bull\t\t (3,50 Euro)\n5) Fettarmer Kakao\t (1.75 Euro)\n6) Barcadi\t\t (4.99 Euro)\n\nGeben Sie ihre Auswahl als Zahl ein: ");
      eingabeaut = int.Parse(Console.ReadLine());
      while (eingabeaut >= 7) {
        Console.Write("\n\nIhre Auswahl ist ungültig. Bitte erneut versuchen: ");
        eingabeaut = int.Parse(Console.ReadLine());
      }
      Console.Write("\n\nWie viele Dosen des gewünschten Getränks sollen ausgegeben werden?\n\nDosen: ");
      player.Score += 3;
      audosen = int.Parse(Console.ReadLine());

      if (audosen >= 5) {
        Console.WriteLine("\nBitte nur in handelsüblichen Mengen bestellen. Dieser Automat ist nicht \ndie Metro. Sie bekommen eine Dose!");
        audosen = 1;
      }
      if (audosen <= 4) {
        switch (eingabeaut) {
          case 1:
            aupreis = audosen * auwasser;
            augetrauswahl = "Wasser";
            break;

          case 2:
            aupreis = audosen * aulimonade;
            augetrauswahl = "Zuckerwasser";
            break;

          case 3:
            aupreis = audosen * aubier;
            augetrauswahl = "Pegelretter";
            break;

          case 4:
            aupreis = audosen * auredbull;
            augetrauswahl = "Infarktdrink";
            break;

          case 5:
            aupreis = audosen * aukakao;
            augetrauswahl = "Diätpampe";
            break;

          case 6:
            aupreis = audosen * aubarcadi;
            augetrauswahl = "Abschussfläschchen";
            break;
        }

        player.Score += 2;
        Console.WriteLine("\n     ---     BEZAHLVORGANG     ---\n\nMögliche Münzen:\n>2.00< >1.00< >0.50< >0.20< >0.10< >0.05< >0.02< >0.01<\n\nEs fehlen noch {0:F2} Euro.\n", aupreis);

        while (aupreis >= 0.01) {
          aueinwurf = double.Parse(Console.ReadLine());
          if (aueinwurf >= 2.01) {
            Console.WriteLine("\nKeine Scheine du Eumel! Rückgabe: " + aueinwurf + " Euro!");
            aueinwurf = 0;
          }
          aupreis = aupreis - aueinwurf;
          if (aupreis >= 0.01) {
            Console.WriteLine("\nEs fehlen noch {0:F2} Euro.\nBitte werfen sie ein Geldstück ein.\n", aupreis);
          } else {
            Console.WriteLine("\nDie Schuld wurde beglichen.");
          }
          if (aupreis <= 0) {
            Console.WriteLine("Ihr Rückgeld beträgt {0:F2}", aupreis * (-1) + " Euro.");
          }
        }

        player.Score += 2;
        Console.WriteLine("\n     ---     GETRÄNKEAUSGABE     ---\n\n");
        for (aui = 1; aui < audosen + 1; aui++) {
          Console.WriteLine("Flasche " + aui + " von " + audosen + " wurde ausgegeben.");
        }
        Console.WriteLine("\nVielen Dank, bitte entnehmen sie ihr/e " + audosen + " " + augetrauswahl + "! Schönen Tag noch!");

        char matr = 'i';
        char behi = 'i';
        char aufbau = 'i';
        double kuko = 100;

        Console.WriteLine("\nNachdem du dein " + augetrauswahl + " genießend schnabulierst, gehst du an einem \nStand für Kursangebote hier im Hotel vorbei und liest dir ein Angebot \ngespannt durch:");
        Console.WriteLine("\nWir bieten einen Philosophie-Kurs an. Die Grundkosten belaufen sich \nauf 100 Euro. Soll  das benötigte Material dafür, für 30 Euro gestellt werden? \n(j / n)\n");
        while (matr != 'j' && matr != 'n') {
          matr = Console.ReadKey(true).KeyChar;
        }

        player.Score += 2;
        Console.WriteLine("Du gehst also zum Schalter und triffst deine Auswahl an der Rezeption.");

        switch (matr) {
          case 'j':
          case 'J':
            kuko = kuko + 30;
            Console.Write("\n\"Material gebucht! ");
            break;

          case 'n':
          case 'N':
            Console.Write("\n\"Kein Material gebucht! ");
            break;
        }

        Console.WriteLine("Zwecks möglichem Rabatt: Bist du arbeitslos oder \nSenior oder Normalo?\", fragt der Typ an der Rezeption. (a / s / n)");
        while (behi != 'a' && behi != 's' && behi != 'n') {
          behi = Console.ReadKey(true).KeyChar;
        }

        switch (behi) {
          case 'a':
          case 'A':
            kuko = kuko - 40;
            Console.Write("\n\"Dir wurden 40% vom Grundpreis erlassen. ");
            break;

          case 's':
          case 'S':
            kuko = kuko - 20;
            Console.Write("\n\"Dir wurden 20% vom Grundpreis erlassen. ");
            break;

          case 'n':
          case 'N':
            Console.Write("\n\"In dem Fall, besteht der volle Preis. ");
            break;
        }

        player.Score += 2;
        Console.WriteLine("Soll ein Aufbaukurs dazugebucht \nwerden? Das macht dann 50% mehr Grundpreis!\", freut sich der gierige Mann \nhinter der Theke und sabbert mit Dollarzeichen in den Augen. (j / n)");
        while (aufbau != 'j' && aufbau != 'n') {
          aufbau = Console.ReadKey(true).KeyChar;
        }

        switch (aufbau) {
          case 'j':
          case 'J':
            kuko = kuko + 50;
            Console.Write("\n\"Aufbaukurs dazugebucht! ");
            break;

          case 'n':
          case 'N':
            Console.Write("\n\"Aufbaukurs nicht dazugebucht! ");
            break;
        }

        player.Score += 2;
        Console.WriteLine("Deine persönlichen Kurskosten belaufen \nsich auf " + kuko + " Euro.\", sagt dir der Typ. Du bezahlst in Knöpfen\nund Kartoffeln und gehst danach auf dein Zimmer.");
        Console.WriteLine("An der Zimmertür gibt es keinen Kartenschlitz. Aber zum Glück\nerinnerst du dich an den Zimmercode und tippst ihn ein:");

        char a, b, c, d;

        do {
          Console.Write("\nPasswort eingeben, oder im Flur schlafen: \n");
          a = Console.ReadKey(true).KeyChar;
          Console.Write("*");
          b = Console.ReadKey(true).KeyChar;
          Console.Write("*");
          c = Console.ReadKey(true).KeyChar;
          Console.Write("*");
          d = Console.ReadKey(true).KeyChar;
          Console.Write("*\n");
        } while (a != 'm' && b != 'i' && c != 'a' && d != 'u');

        Console.WriteLine("\n\"Ihr Passwort: \"" + a + b + c + d + "\" war korrekt.\", dröhnt es aus der Tür und\nsie teilt sich zu drei Teilen, die in den Wänden verschwinden.");
        player.Score += 4;

        Console.WriteLine("Du siehst den Fernseher in deinem Appartement und schaltest ihn ein:");
        Console.ReadLine();
        int[] zahlen = new int[100000];

        for (int i = zahlen.Length - 1; i >= 0; i--) {
          zahlen[zahlen.Length - 1 - i] = i + 1;
        }

        foreach (int zahl in zahlen) {
          Console.Write("1337" + zahl + "7965");
          Console.Write("Ika nus tik!!");
        }
      }
      Console.Clear();
      gam2 = true;
      Console.WriteLine("\n\nDer Code für Spiel 2 lautet \"626832\" und wird nach Neustart über \ndie Codeeingabe eingegeben, den Fortschritt wieder anrechnen. Drücke \nEnter, um zurück ins Hauptmenü zu gelangen.");
      Console.WriteLine("________________________________________________________________________________");
      Console.ReadLine();
    }

    #endregion Vorspiele

    #region Kampfspiel

    public static void GameWOOD(Player player, bool gam3) {
      bool HelgaMet = false;
      player.Score += 100;
      Menus.Bar();
      Console.WriteLine("Dann lass uns mal ernster werden. Eine Geschichte erzählen. Und sie ist \nbestimmt auch so passiert! Ich versetze dich in meine Lage. Na dann wollen \nwir doch mal sehen. Drücke Enter, um die Geschichte zu \"entern\" :P");
      Console.ReadLine();
      Console.Clear();
      Menus.Bar();
      Console.WriteLine("Willkommen im tiefen Dickicht des wilden Schwarzwaldes. Du bewegst dich \nvorsichtig durch's Unterholz...Man sagt, hier lauerten Dämonen. Doch was ist \ndas? Eine Person.\n");
      Console.ReadLine();

      Console.Clear();
      Reinhart.IntroBlackwood(player);
      WeaponStore.Store(player);

      Entity enemyWood1 = new Stepmother();
      enemyWood1.Clash(player);

      Reinhart.BlackwoodStepmother(player);

      Menus.BetweenFight(player, HelgaMet);
      Entity enemyWood2 = new Rasselbock();
      enemyWood2.Clash(player);

      Menus.BetweenFight(player, HelgaMet);
      Entity enemyWood3 = new Skelett();
      enemyWood3.Clash(player);

      Menus.BetweenFight(player, HelgaMet);
      Entity enemyWood4 = new Untoter();
      enemyWood4.Clash(player);

      Menus.BetweenFight(player, HelgaMet);
      Entity enemyWood5 = new Moorleiche();
      enemyWood5.Clash(player);

      Menus.BetweenFight(player, HelgaMet);
      Entity enemyWood6 = new Ghul();
      enemyWood6.Clash(player);

      Menus.BetweenFight(player, HelgaMet);
      Entity enemyWood7 = new Ekke_Nekkepenn();
      enemyWood7.Clash(player);

      HelgaMet = true;
      Helga.BlackwoodHello(player);

      Menus.BetweenFight(player, HelgaMet);
      Helga.BlackwoodTrain1(player);
      Entity enemyWood8 = new Riesenratte();
      enemyWood8.Clash(player);

      Menus.BetweenFight(player, HelgaMet);
      Helga.BlackwoodTrain2(player);
      Entity enemyWood9 = new Schleim_Imp();
      enemyWood9.Clash(player);

      Menus.BetweenFight(player, HelgaMet);
      Helga.BlackwoodTrain3(player);
      Entity enemyWood10 = new Empusa();
      enemyWood10.Clash(player);

      Menus.BetweenFight(player, HelgaMet);
      Helga.BlackwoodTrain4(player);
      Entity enemyWood11 = new Schattenmann();
      enemyWood11.Clash(player);

      Menus.BetweenFight(player, HelgaMet);
      Reinhart.BlackwoodTrain5(player);
      Entity enemyWood12 = new Nachtalb();
      enemyWood12.Clash(player);

      Menus.BetweenFight(player, HelgaMet);
      Reinhart.BlackwoodTrain6(player);
      Entity enemyWood13 = new Klushund();
      enemyWood13.Clash(player);

      Menus.BetweenFight(player, HelgaMet);
      Helga.BlackwoodTrain7(player);
      Entity enemyWood14 = new Lich();
      enemyWood14.Clash(player);

      Menus.BetweenFight(player, HelgaMet);
      Helga.BlackwoodTrain8(player);
      Entity enemyWood15 = new Lindwurm();
      enemyWood15.Clash(player);

      Menus.BetweenFight(player, HelgaMet);
      Entity enemyWood16 = new Elwetritsch();
      enemyWood16.Clash(player);

      Menus.BetweenFight(player, HelgaMet);
      Entity enemyWood17 = new Die_Moira();
      enemyWood17.Clash(player);
    }

    #endregion Kampfspiel
  }
}