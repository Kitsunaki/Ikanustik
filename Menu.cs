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
      Console.WriteLine("°°° --- Ikanustik ---  Version " + version + "." + zeilen + "   ---   " + user.Score + " von " + user.Maxscore + " Punkten  --- °°°\n");
      Console.WriteLine("________________________________________________________________________________");
    }

    public static void ChooseGame(Player player, double zeilen, string version) {
      Console.WriteLine("Hauptspiel:\t\tMinispiele:\n");
      Console.WriteLine("s) Schwarzwald\t\t1) Tutorial 1 \"Thermometer\"");
      Console.WriteLine("?) ???\t\t\t2) Tutorial 2 \"Carbonara\"");
      Console.WriteLine("?) ???\t\t\t3) Tutorial 3 \"Body Mass Index\"");
      Console.WriteLine("?) ???\t\t\t4) Tutorial 4 \"Schulzeit\"");
      Console.WriteLine("?) ???\t\t\t5) Tutorial 5 \"Lotto\"");
      Console.WriteLine("?) ???\t\t\t6) Tutorial 6 \"Wortverdrehung\"");
      Console.WriteLine("?) ???\t\t\t7) Spiel 1 \"Zahlenraten\"");
      Console.WriteLine("?) ???\t\t\t8) Spiel 2 \"Hotelbesuch\"");
      Console.WriteLine("\n\t\t\t0) Codeeingabe\n");
      Console.Write("Auswahl: ");
      if (player.Score == player.Maxscore) {
        Console.WriteLine("♦♦♦ VORERST DURCHGESPIELT! :D ♦♦♦ VIELEN DANK FÜRS DABEISEIN! ♦♦♦ MÖPP! ♦♦♦");
      }
      string menuwahl = Console.ReadLine();
      try {
        if (menuwahl == "1") {
          if (tut1) {
            player.Score -= 10;
          }
          Console.Clear();
          Game.TutorialTERM(player, tut1);
        } else if (menuwahl == "2") {
          if (tut2 == true) {
            player.Score -= 8;
          }
          Console.Clear();
          Game.TutorialCARB(player, tut2);
        } else if (menuwahl == "3") {
          if (tut3 == true) {
            player.Score -= 8;
          }
          Console.Clear();
          Game.TutorialBMI(player, tut3);
        } else if (menuwahl == "4") {
          if (tut4 == true) {
            player.Score -= 17;
          }
          Console.Clear();
          Game.TutorialSCHL(player, tut4);
        } else if (menuwahl == "5") {
          if (tut5 == true) {
            player.Score -= 21;
          }
          Console.Clear();
          Game.TutorialLOT(player, tut5);
        } else if (menuwahl == "6") {
          if (tut6 == true) {
            player.Score -= 11;
          }
          Console.Clear();
          Game.TutorialWOR(player, tut6);
        } else if (menuwahl == "7") {
          if (gam1 == true) {
            player.Score -= 60;
          }
          Console.Clear();
          Game.GameZAHL(player, gam1);
        } else if (menuwahl == "8") {
          if (gam2 == true) {
            player.Score -= 24;
          }
          Console.Clear();
          Game.GameHOT(player, gam2);
        } else if (menuwahl == "s") {
          if (gam3 == true) {
            player.Score -= 100;
          }
          Console.Clear();
          Game.GameWOOD(player, gam3);
        } else if (menuwahl == "0") {
          Code(player, version, zeilen);
        }
      } catch {
      }
    }

    public static void Code(Player player, string version, double zeilen) {
      char codeeing = 'n';
      do {
        Console.Clear();
        Menus.MainMenu(player, version, zeilen);
        Console.Write("\nCodeeingabe: ");
        string code = Console.ReadLine();
        try {
          switch (code) {
            case "475192":
              if (tut1 == false) {
                tut1 = true;
                player.Score += 10;
                Console.Beep();
                Console.WriteLine("Tutorial 1 wurde deinem Fortschritt angerechnet!\n");
                break;
              }
              Console.WriteLine("Turotial 1 wurde bereits hinzugefügt und kann nicht noch einmal angerechnet\nwerden. Versuch' mich nicht zu verarschen :P");
              break;

            case "939716":
              if (tut2 == false) {
                tut2 = true;
                player.Score += 8;
                Console.Beep();
                Console.WriteLine("Tutorial 2 wurde deinem Fortschritt angerechnet!\n");
                break;
              }
              Console.WriteLine("Turotial 2 wurde bereits hinzugefügt und kann nicht noch einmal angerechnet\nwerden. Versuch' mich nicht zu verarschen :P");
              break;

            case "477501":
              if (tut3 == false) {
                tut3 = true;
                player.Score += 8;
                Console.Beep();
                Console.WriteLine("Tutorial 3 wurde deinem Fortschritt angerechnet!\n");
                break;
              }
              Console.WriteLine("Turotial 3 wurde bereits hinzugefügt und kann nicht noch einmal angerechnet\nwerden. Versuch' mich nicht zu verarschen :P");
              break;

            case "897933":
              if (tut4 == false) {
                tut4 = true;
                player.Score += 17;
                Console.Beep();
                Console.WriteLine("Tutorial 4 wurde deinem Fortschritt angerechnet!\n");
                break;
              }
              Console.WriteLine("Turotial 4 wurde bereits hinzugefügt und kann nicht noch einmal angerechnet\nwerden. Versuch' mich nicht zu verarschen :P");
              break;

            case "141527":
              if (tut5 == false) {
                tut5 = true;
                player.Score += 21;
                Console.Beep();
                Console.WriteLine("Tutorial 5 wurde deinem Fortschritt angerechnet!\n");
                break;
              }
              Console.WriteLine("Turotial 5 wurde bereits hinzugefügt und kann nicht noch einmal angerechnet\nwerden. Versuch' mich nicht zu verarschen :P");
              break;

            case "320504":
              if (tut6 == false) {
                tut6 = true;
                player.Score += 11;
                Console.Beep();
                Console.WriteLine("Tutorial 6 wurde deinem Fortschritt angerechnet!\n");
                break;
              }
              Console.WriteLine("Turotial 6 wurde bereits hinzugefügt und kann nicht noch einmal angerechnet\nwerden. Versuch' mich nicht zu verarschen :P");
              break;

            case "653546":
              if (gam1 == false) {
                gam1 = true;
                player.Score += 58;
                Console.Beep();
                Console.WriteLine("Spiel 1 wurde deinem Fortschritt angerechnet!\n");
                break;
              }
              Console.WriteLine("Spiel 1 wurde bereits hinzugefügt und kann nicht noch einmal angerechnet\nwerden. Versuch' mich nicht zu verarschen :P");
              break;

            case "626832":
              if (gam2 == false) {
                gam2 = true;
                player.Score += 24;
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
              gam2 = true;
              player.Score = 159;
              Console.Beep();
              Console.WriteLine("Tutorial 1 - 6 und Spiel 1 - 2 wurden deinem Fortschritt angerechnet!\n");
              break;

            case "798990":
              if (gam3 == false) {
                gam3 = true;
                player.Score += 100;
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
      Console.WriteLine("_____°_____°_____°_____°_____°_____°_____°_____°_____°_____°_____°_____°_____°__");
      Console.WriteLine("_____I_____I_____I_____I_____I_____I_____I_____I_____I_____I_____I_____I_____I__");
      Console.WriteLine("_____°_____°_____°_____°_____°_____°_____°_____°_____°_____°_____°_____°_____°__");
      Console.WriteLine("________________________________________________________________________________");
    }

    public static void ClashMenu(Player player, Entity entity) {
      int hit = 1;
      Console.Clear();
      Menus.Bar();
      Console.WriteLine($"{entity.Name}:\n\n\t{entity.Health}/{entity.HealthPool} Lebenspunkte\t{entity.Regeneration} Selbstheilung\n");
      Console.WriteLine($"\t{entity.DamageMin}-{entity.DamageMax} Schaden\t\t{entity.Armor} Rüstwert\n");
      Console.WriteLine($"{player.Name}:\n\n\t{player.Health}/{player.HealthPool} Lebenspunkte\t{player.Mana}/{player.ManaPool} Mana\n");
      Console.WriteLine($"\t{player.Stamina} Ausdauer\t\t{player.Satisfaction}% Genugtuung\n");
      Console.WriteLine($"\t{player.Strengh} Stärke\t\t{player.Resilienz} Resilienz\t\n");
      Console.WriteLine($"{player.Active_Weapon.Name} ({player.Active_Weapon.Class}):\n");
      Console.WriteLine($"\t{player.Active_Weapon.MinDamage}-{player.Active_Weapon.MaxDamage} Schaden\t\t{player.Active_Weapon.Durability} Haltbarkeit");

      Console.WriteLine("\n\n\n\tStarte den Angriff mit (a)!\tNutze Magie mit (m)!");
      char fight = Console.ReadKey(true).KeyChar;
      if (fight == 'a') {
        Console.Clear();
        Menus.Bar();
        Random hitr = new Random();
        hit = hitr.Next(2, player.Stamina + 1);
        for (int i = 0; i < (hit - 1); i++) {
          Console.WriteLine(player.Active_Weapon.Attack(entity, player));
          Console.WriteLine("\n(Press ENTER)");
          Console.ReadLine();
        }
        if (entity.Health >= 1) {
          Console.WriteLine(player.Active_Weapon.EnemyAttack(player, entity));
          Console.WriteLine("\n(Press ENTER)");
          Console.ReadLine();
        }
        if (player.Mana < player.ManaPool) {
          player.Mana++;
        }
      } else if (fight == 'm') {
        Console.Clear();
        Menus.Bar();
        Console.WriteLine($"{player.Name}:");
        Console.WriteLine($"\t{player.Mana}/{player.ManaPool} Mana\t\t{player.Health}/{player.HealthPool} Leben\t");
        Console.WriteLine($"\nBekannte Zauber:\n");
        Console.WriteLine($"\t1) Balsama-Heilzauber:\tKostet 2 Mana\tHeilt 3 Lebenspunkte.");
        char magic = Console.ReadKey().KeyChar;
        if (magic == '1') {
          if (player.Mana >= 2) {
            player.Health += 3;
            player.Mana -= 2;
            Console.Clear();
            Console.WriteLine("\n\n\n\tEin Segen wird dir zuteil und heilt 3 deiner Lebenspunkte\n\n\n");
            Console.WriteLine("                          (___  \\( )/  ___) ");
            Console.WriteLine("                            (___ | | ___)   ");
            Console.WriteLine("                               /\"| (\"\\      ");
            Console.WriteLine("                              ( (| |) )     ");
            Console.WriteLine("                               `.!' .'      ");
            Console.WriteLine("                                / .'\\       ");
            Console.WriteLine("                                \\|/ /       ");
            Console.WriteLine("                                 /.<        ");
            Console.WriteLine("                                (| |)       ");
            Console.WriteLine("                                 | '        ");
            Console.WriteLine("                                 `-'        ");

            if (player.Health > player.HealthPool) {
              player.Health = player.HealthPool;
            }
            System.Threading.Thread.Sleep(5000);
          } else if (player.Mana < 2) {
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\t\tNicht genug Mana!");
            System.Threading.Thread.Sleep(3000);
          }
        }
      } else {
      }
    }

    public static void Victory(Player player, Entity entity) {
      Console.Clear();
      Console.Write(new String('\n', 10));
      Random randomGold = new Random();
      int Get_Gold = randomGold.Next(entity.MinGetGold, entity.MaxGetGold + 1);
      player.Gold += Get_Gold;
      player.Health = player.HealthPool;
      player.Mana = player.ManaPool;
      player.Satisfaction = 0;
      Random Exp_GetR = new Random();
      int Exp_Get = Exp_GetR.Next(entity.ExpMin, entity.ExpMax + 1);
      player.Skill += Exp_Get;
      Console.WriteLine($"\t{entity.Name} wurde besiegt. \n\t{Get_Gold} Gold erhalten! \n\tDu fühlst dich erholt und beruhigst dich.\n\tDu bekommst {Exp_Get} Erfahrung dazu.\n\n(Press ENTER)");
      Console.ReadLine();
      Console.Clear();
    }

    public static void Loose(Player player, Entity entity) {
      Console.Clear();
      Menus.Bar();
      Console.WriteLine("Als deine Lebenspunkte auf Null sinken, spürst du die eisige Umklammerung \ndes Todes um dich und das einzige was in dieser Welt noch auf dich warte, \nist eine voranschreitende Erleichterung in völliger Dunkelheit. Die Sinne \nerstumpfen und etwas anderes wartet jenseits dieser Ebene auf dich. Der graue \nSchleier dieser Welt zieht sich auf und bietet den Blick auf strahlendes Licht\nvor dir. Nachdem deine Augen sich daran gewöhnen, erkennst du einen \nmild rauschenden Strand, an dessen glatten Steinen sich die azurne Gischt \nschmiegt und dahinter wogende saftige Wiesen unter einer rasch aufgehenden \nSonne. Langsam rappelst du dich auf und erkennst, dass du deine Aufgabe \nnicht erfüllen konntest und das Schicksal dessen, was du hinter dir ließest,\nnun in den Händen anderer liegt. Die glatten Steine schmeicheln deinen \nFüßen, als du Schritt für Schritt, aus dem warmen Wasser, den Steinstrand \nhinaufgehst und weder Hunger, noch Durst, noch andere Bedürfnisse verspürst. \nKein Schmerz, kein Leid, nur eine wohlige Wärme, die von innen heraus strahlt \nund bedingungslos annimmt. Ohne über die Dinge nachdenken zu müssen, ist dir \nbereits alles klar. Neue Gefilde erwarten dich und du spürst bereits das \nsatte Grün unter dir, auf dem nächtlicher unberühter Tau, einen kühlen Kontrast\nzur wärmenden Sonne über dir bietet...");
      System.Threading.Thread.Sleep(3000);
      Environment.Exit(0);
    }

    public static void BetweenFight(Player player, ref bool HelgaMet) {
      bool ready = false;

      do {
        Console.Clear();
        Menus.Bar();
        Console.WriteLine($"Spieler: {player.Name}\n\n\tGold: {player.Gold}\tErfahrung: {player.Skill}\tAusgerüstet: {player.Active_Weapon.Name} ({player.Active_Weapon.Durability}/{player.Active_Weapon.FullDurability})\n");
        if (HelgaMet == false) {
          Console.WriteLine($"\n\t1) Mit Reinhart sprechen");
          Console.WriteLine($"\t2) Gehe weiter!");
          Console.Write("Wahl: ");
          char mapwahl = Console.ReadKey().KeyChar;
          if (mapwahl == '1') {
            Reinhart.Map(player);
            WeaponStore.Store(player);
          } else if (mapwahl == '2') {
            ready = true;
          }
        } else if (HelgaMet == true) {
          Console.WriteLine($"\n\t1) Mit Reinhart sprechen");
          Console.WriteLine($"\t2) Mit Helga sprechen");
          Console.WriteLine($"\t3) Gehe weiter!");
          Console.Write("\nWahl: ");
          char mapwahl = Console.ReadKey().KeyChar;
          if (mapwahl == '1') {
            Reinhart.Map(player);
            WeaponStore.Store(player);
          } else if (mapwahl == '2') {
            Helga.Map(player);
          } else if (mapwahl == '3') {
            ready = true;
          }
        }
      } while (ready == false);
    }
  }
}