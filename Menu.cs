using System;
using Ikanustik.Entities;

namespace Ikanustik {

  internal class Menus {
    public static bool tut1 = false;
    public static bool tut2 = false;
    public static bool tut3 = false;
    public static bool tut4 = false;
    public static bool tut5 = false;
    public static bool tut6 = false;
    public static bool gam1 = false;
    public static bool gam2 = false;
    public static bool gam3 = false;

    public static void MainMenu(Player user, string version, double zeilen) {
      Console.WriteLine("________________________________________________________________________________\n");
      Console.WriteLine("♦♦♦ ---  Ikanustik  ---   Version " + version + "." + zeilen + "   ---   " + user.Score + " von " + user.Maxscore + " Punkten  --- ♦♦♦\n");
      Console.WriteLine("________________________________________________________________________________");
    }

    public static void ChooseGame(Player user, double zeilen, string version) {
      Console.WriteLine("1) Tutorial 1 \"Thermometer\"");
      Console.WriteLine("2) Tutorial 2 \"Carbonara\"");
      Console.WriteLine("3) Tutorial 3 \"Body Mass Index\"");
      Console.WriteLine("4) Tutorial 4 \"Schulzeit\"");
      Console.WriteLine("5) Tutorial 5 \"Lotto\"");
      Console.WriteLine("6) Tutorial 6 \"Wortverdrehung\"");
      Console.WriteLine("\n7) Spiel 1 \"Zahlenraten\"");
      Console.WriteLine("8) Spiel 2 \"Hotelbesuch\"");
      Console.WriteLine("9) Spiel 3 \"Finsterer Wald\"");
      Console.WriteLine("\n0) Codeeingabe\n");
      if (user.Score == user.Maxscore) {
        Console.WriteLine("♦♦♦ VORERST DURCHGESPIELT! :D ♦♦♦ VIELEN DANK FÜRS DABEISEIN! ♦♦♦ MÖPP! ♦♦♦");
      }
      int menuwahl = int.Parse(Console.ReadLine());
      if (menuwahl == 1) {
        if (tut1) {
          user.Score -= 10;
        }
        Console.Clear();
        Game.TutorialTERM(user, tut1);
      } else if (menuwahl == 2) {
        if (tut2 == true) {
          user.Score -= 8;
        }
        Console.Clear();
        Game.TutorialCARB(user, tut2);
      } else if (menuwahl == 3) {
        if (tut3 == true) {
          user.Score -= 8;
        }
        Console.Clear();
        Game.TutorialBMI(user, tut3);
      } else if (menuwahl == 4) {
        if (tut4 == true) {
          user.Score -= 17;
        }
        Console.Clear();
        Game.TutorialSCHL(user, tut4);
      } else if (menuwahl == 5) {
        if (tut5 == true) {
          user.Score -= 21;
        }
        Console.Clear();
        Game.TutorialLOT(user, tut5);
      } else if (menuwahl == 6) {
        if (tut6 == true) {
          user.Score -= 11;
        }
        Console.Clear();
        Game.TutorialWOR(user, tut6);
      } else if (menuwahl == 7) {
        if (gam1 == true) {
          user.Score -= 60;
        }
        Console.Clear();
        Game.GameZAHL(user, gam1);
      } else if (menuwahl == 8) {
        if (user.Score <= 99) {
          Console.WriteLine("\nDieser Level steht erst ab 100 Punkten zur Verfügung! (Enter zum Fortfahren)");
          Console.ReadLine();
        } else if (user.Score >= 100) {
          if (gam2 == true) {
            user.Score -= 24;
          }
          Console.Clear();
          Game.GameHOT(user, gam2);
        }
      } else if (menuwahl == 9) {
        if (user.Score <= 124) {
          Console.WriteLine("\nDieser Level steht erst ab 125 Punkten zur Verfügung! (Enter zum Fortfahren)");
          Console.ReadLine();
        } else if (user.Score >= 125) {
          if (gam3 == true) {
            user.Score -= 100;
          }
          Console.Clear();
          Game.GameWOOD(user, gam3);
        }
      } else if (menuwahl == 0) {
        Code(user, version, zeilen);
      } else {
        Console.Clear();
        Console.WriteLine("Die Eingabe war fehlerhaft. Bitte wiederholen.\n");
      }
    }

    public static void Code(Player user, string version, double zeilen) {
      char codeeing = 'n';
      do {
        Console.Clear();
        Menus.MainMenu(user, version, zeilen);
        Console.Write("\nCodeeingabe: ");
        string code = Console.ReadLine();
        try {
          switch (code) {
            case "475192":
              if (tut1 == false) {
                tut1 = true;
                user.Score += 10;
                Console.Beep();
                Console.WriteLine("Tutorial 1 wurde deinem Fortschritt angerechnet!\n");
                break;
              }
              Console.WriteLine("Turotial 1 wurde bereits hinzugefügt und kann nicht noch einmal angerechnet\nwerden. Versuch' mich nicht zu verarschen :P");
              break;

            case "939716":
              if (tut2 == false) {
                tut2 = true;
                user.Score += 8;
                Console.Beep();
                Console.WriteLine("Tutorial 2 wurde deinem Fortschritt angerechnet!\n");
                break;
              }
              Console.WriteLine("Turotial 2 wurde bereits hinzugefügt und kann nicht noch einmal angerechnet\nwerden. Versuch' mich nicht zu verarschen :P");
              break;

            case "477501":
              if (tut3 == false) {
                tut3 = true;
                user.Score += 8;
                Console.Beep();
                Console.WriteLine("Tutorial 3 wurde deinem Fortschritt angerechnet!\n");
                break;
              }
              Console.WriteLine("Turotial 3 wurde bereits hinzugefügt und kann nicht noch einmal angerechnet\nwerden. Versuch' mich nicht zu verarschen :P");
              break;

            case "897933":
              if (tut4 == false) {
                tut4 = true;
                user.Score += 17;
                Console.Beep();
                Console.WriteLine("Tutorial 4 wurde deinem Fortschritt angerechnet!\n");
                break;
              }
              Console.WriteLine("Turotial 4 wurde bereits hinzugefügt und kann nicht noch einmal angerechnet\nwerden. Versuch' mich nicht zu verarschen :P");
              break;

            case "141527":
              if (tut5 == false) {
                tut5 = true;
                user.Score += 21;
                Console.Beep();
                Console.WriteLine("Tutorial 5 wurde deinem Fortschritt angerechnet!\n");
                break;
              }
              Console.WriteLine("Turotial 5 wurde bereits hinzugefügt und kann nicht noch einmal angerechnet\nwerden. Versuch' mich nicht zu verarschen :P");
              break;

            case "320504":
              if (tut6 == false) {
                tut6 = true;
                user.Score += 11;
                Console.Beep();
                Console.WriteLine("Tutorial 6 wurde deinem Fortschritt angerechnet!\n");
                break;
              }
              Console.WriteLine("Turotial 6 wurde bereits hinzugefügt und kann nicht noch einmal angerechnet\nwerden. Versuch' mich nicht zu verarschen :P");
              break;

            case "653546":
              if (gam1 == false) {
                gam1 = true;
                user.Score += 58;
                Console.Beep();
                Console.WriteLine("Spiel 1 wurde deinem Fortschritt angerechnet!\n");
                break;
              }
              Console.WriteLine("Spiel 1 wurde bereits hinzugefügt und kann nicht noch einmal angerechnet\nwerden. Versuch' mich nicht zu verarschen :P");
              break;

            case "626832":
              if (gam2 == false) {
                gam2 = true;
                user.Score += 24;
                Console.Beep();
                Console.WriteLine("Spiel 2 wurde deinem Fortschritt angerechnet!\n");
                break;
              }
              Console.WriteLine("Spiel 2 wurde bereits hinzugefügt und kann nicht noch einmal angerechnet\nwerden. Versuch' mich nicht zu verarschen :P\n");
              break;

            case "rosebud":
              tut1 = true;
              tut2 = true;
              tut3 = true;
              tut4 = true;
              tut5 = true;
              tut6 = true;
              gam1 = true;
              user.Score = 135;
              Console.Beep();
              Console.WriteLine("Tutorial 1 - 6 und Spiel 1 wurden deinem Fortschritt angerechnet!\n");
              break;

            case "798990":
              if (gam3 == false) {
                gam3 = true;
                user.Score += 100;
                Console.Beep();
                Console.WriteLine("Spiel 3 wurde deinem Fortschritt angerechnet!\n");
                break;
              }
              Console.WriteLine("Spiel 3 wurde bereits hinzugefügt und kann nicht noch einmal angerechnet\nwerden. Versuch' mich nicht zu verarschen :P\n");
              break;

            default:
              Console.WriteLine("Fehlerhafte Codeeingabe!");
              break;
          }
        } catch {
          Console.WriteLine("Die Codeeingabe war nicht möglich!");
        }
        Console.WriteLine("Zurück ins Hauptmenü? (j)a oder (n)ein?");
        codeeing = Console.ReadKey().KeyChar;
      } while (codeeing == 'n');
    }

    public static void Bar() {
      Console.WriteLine("________________________________________________________________________________");
      Console.WriteLine("_____♦_____♦_____♦_____♦_____♦_____♦_____♦_____♦_____♦_____♦_____♦_____♦_____♦__");
      Console.WriteLine("_____I_____I_____I_____I_____I_____I_____I_____I_____I_____I_____I_____I_____I__");
      Console.WriteLine("_____♦_____♦_____♦_____♦_____♦_____♦_____♦_____♦_____♦_____♦_____♦_____♦_____♦__");
      Console.WriteLine("________________________________________________________________________________");
    }
  }
}