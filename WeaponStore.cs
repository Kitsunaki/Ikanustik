using System;

namespace Ikanustik {

  internal class WeaponStore {

    public static void Store(double Min_Damage, double Max_Damage, double Gold) {
      Console.WriteLine("\nAktueller Schaden beträgt " + Min_Damage + "-" + Max_Damage + " Schadenspunkte. Möchtest du ?nKlingenwaffen, Flegelwaffen oder Stangenwaffen anschauen?\n(k / f / s)");
      char choose = Console.ReadKey(true).KeyChar;
      if (choose == 'k') {
        Console.WriteLine("\nWähle eine Waffe:\n");
        Console.WriteLine("\t1) Dolch\tKostet 0 Gold\t1-2 Schaden!");
        Console.WriteLine("\t2) Krismesser\tKostet 20 Gold\t2-4 Schaden");
        Console.WriteLine("\t3) Kurzschwert\tKostet 60 Gold\t4-8 Schaden!");
        Console.WriteLine("\t4) Krummsäbel\tKostet 140 Gold\t8-12 Schaden!");
        Console.WriteLine("\t5) Breitschwert\tKostet 290 Gold\t10-15 Schaden");
        Console.WriteLine("\t6) Claymore\tKostet 500 Gold\t15-22 Schaden");
        Console.WriteLine("\t7) Schweres Bastardschwert\tKostet 1300 Gold\t20-28 Schaden");
        Console.Write("\nWahl: ");
        Weapon_choose_k(ref Min_Damage, ref Max_Damage, ref Gold); //muss den Waffennamen noch in den einzelnen Dingern deklarieren D:
      } else if (choose == 'f') {
        Console.WriteLine("\t1) Schmiedehammer\tKostet 35 Gold\t2-5 Schaden");
        Console.WriteLine("\t2) Dreschflegel\tKostet 58 Gold\t5-8 Schaden");
        Console.WriteLine("\t3) Streitkolben\tKostet 110 Gold\t7-13 Schaden");
        Console.WriteLine("\t4) Großer Morgenstern\tKostet 280 Gold\t9-19 Schaden");
        Console.WriteLine("\t5) Kriegsszepter\tKostet 440 Gold\t12-22 Schaden");
        Console.WriteLine("\t6) Beidhändiger Kriegshammer\tKostet 1050 Gold\t10-30 Schaden");
        Console.WriteLine("\t7) Höllenschmiedenhammer\tKostet 1780 Gold\t23-33 Schaden");
        Console.Write("\nWahl: ");
        Weapon_choose_f(ref Min_Damage, ref Max_Damage, ref Gold);
      } else if (choose == 's') {
        Console.WriteLine("\t5) Langstab\tKostet 30 Gold\t5-11 Schaden");
        Console.WriteLine("\t5) Gleve\tKostet 150 Gold\t8-13 Schaden");
        Console.WriteLine("\t5) Jungfern-Speer\tKostet 350 Gold\t12-18 Schaden");
        Console.WriteLine("\t5) Dreizack\tKostet 520 Gold\t14-22 Schaden");
        Console.WriteLine("\t5) Bardike\tKostet 800 Gold\t15-25 Schaden");
        Console.WriteLine("\t5) Hellebarde\tKostet 1320 Gold\t19-29 Schaden");
        Console.WriteLine("\t5) Kriegssense\tKostet 1900 Gold\t20-35 Schaden");
        Console.Write("\nWahl: ");
        Weapon_choose_s(ref Min_Damage, ref Max_Damage, ref Gold);
      }
    }

    public static void Weapon_choose_k(ref double Min_Damage, ref double Max_Damage, ref double Gold) {
      int weapon = int.Parse(Console.ReadLine());
      switch (weapon) {
        case 1:
          Min_Damage = 1;
          Max_Damage = 2;
          Console.WriteLine("\nDolch ausgewählt!");
          break;

        case 2:
          if (Gold >= 20) {
            Min_Damage = 2;
            Max_Damage = 4;
            Gold = Gold - 20;
            Console.WriteLine("\nKrismesser ausgewählt!");
            break;
          }
          Console.WriteLine("\nNicht genug Gold für diese Waffe!");
          break;

        case 3:
          if (Gold >= 60) {
            Min_Damage = 4;
            Max_Damage = 8;
            Gold = Gold - 60;
            Console.WriteLine("\nKurzschwert ausgewählt!");
            break;
          }
          Console.WriteLine("\nNicht genug Gold für diese Waffe!");
          break;

        case 4:
          if (Gold >= 140) {
            Min_Damage = 8;
            Max_Damage = 12;
            Gold = Gold - 140;
            Console.WriteLine("\nKrummsäbel ausgewählt!");
            break;
          }
          Console.WriteLine("\nNicht genug Gold für diese Waffe!");
          break;

        case 5:
          if (Gold >= 290) {
            Min_Damage = 10;
            Max_Damage = 15;
            Gold = Gold - 290;
            Console.WriteLine("Breitschwert ausgewählt!");
            break;
          }
          Console.WriteLine("\nNicht genug Gold für diese Waffe!");
          break;

        case 6:
          if (Gold >= 500) {
            Min_Damage = 15;
            Max_Damage = 22;
            Gold = Gold - 500;
            Console.WriteLine("Claymore ausgewählt!");
            break;
          }
          Console.WriteLine("\nNicht genug Gold für diese Waffe!");
          break;

        case 7:
          if (Gold >= 1300) {
            Min_Damage = 20;
            Max_Damage = 28;
            Gold = Gold - 1300;
            Console.WriteLine("Schweres Bastardschwert ausgewählt!");
            break;
          }
          Console.WriteLine("\nNicht genug Gold für diese Waffe!");
          break;

        default:
          Console.WriteLine("\nKeine Waffe ausgewählt!");
          break;
      }
    }

    public static void Weapon_choose_f(ref double Min_Damage, ref double Max_Damage, ref double Gold) {
      int weapon = int.Parse(Console.ReadLine());
      switch (weapon) {
        case 1:
          if (Gold >= 35) {
            Min_Damage = 2;
            Max_Damage = 5;
            Gold = Gold - 35;
            Console.WriteLine("\nSchmiedehammer ausgewählt!");
            break;
          }
          Console.WriteLine("\nNicht genug Gold für diese Waffe!");
          break;

        case 2:
          if (Gold >= 58) {
            Min_Damage = 5;
            Max_Damage = 8;
            Gold = Gold - 58;
            Console.WriteLine("\nDreschflegel ausgewählt!");
            break;
          }
          Console.WriteLine("\nNicht genug Gold für diese Waffe!");
          break;

        case 3:
          if (Gold >= 110) {
            Min_Damage = 7;
            Max_Damage = 13;
            Gold = Gold - 110;
            Console.WriteLine("\nStreitkolben ausgewählt!");
            break;
          }
          Console.WriteLine("\nNicht genug Gold für diese Waffe!");
          break;

        case 4:
          if (Gold >= 280) {
            Min_Damage = 9;
            Max_Damage = 19;
            Gold = Gold - 280;
            Console.WriteLine("\nGroßer Morgenstern ausgewählt!");
            break;
          }
          Console.WriteLine("\nNicht genug Gold für diese Waffe!");
          break;

        case 5:
          if (Gold >= 440) {
            Min_Damage = 12;
            Max_Damage = 22;
            Gold = Gold - 440;
            Console.WriteLine("Kriegsszepter ausgewählt!");
            break;
          }
          Console.WriteLine("\nNicht genug Gold für diese Waffe!");
          break;

        case 6:
          if (Gold >= 1050) {
            Min_Damage = 10;
            Max_Damage = 30;
            Gold = Gold - 1050;
            Console.WriteLine("Beidhändiger Kriegshammer ausgewählt!");
            break;
          }
          Console.WriteLine("\nNicht genug Gold für diese Waffe!");
          break;

        case 7:
          if (Gold >= 1780) {
            Min_Damage = 23;
            Max_Damage = 33;
            Gold = Gold - 1780;
            Console.WriteLine("Höllenschmiedenhammer ausgewählt!");
            break;
          }
          Console.WriteLine("\nNicht genug Gold für diese Waffe!");
          break;

        default:
          Console.WriteLine("\nKeine Waffe ausgewählt!");
          break;
      }
    }

    public static void Weapon_choose_s(ref double Min_Damage, ref double Max_Damage, ref double Gold) {
      int weapon = int.Parse(Console.ReadLine());
      switch (weapon) {
        case 1:
          if (Gold >= 30) {
            Min_Damage = 5;
            Max_Damage = 11;
            Gold = Gold - 30;
            Console.WriteLine("\nLangstab ausgewählt!");
            break;
          }
          Console.WriteLine("\nNicht genug Gold für diese Waffe!");
          break;

        case 2:
          if (Gold >= 150) {
            Min_Damage = 8;
            Max_Damage = 13;
            Gold = Gold - 150;
            Console.WriteLine("\nGleve ausgewählt!");
            break;
          }
          Console.WriteLine("\nNicht genug Gold für diese Waffe!");
          break;

        case 3:
          if (Gold >= 350) {
            Min_Damage = 12;
            Max_Damage = 18;
            Gold = Gold - 350;
            Console.WriteLine("\nJungfern-Speer ausgewählt!");
            break;
          }
          Console.WriteLine("\nNicht genug Gold für diese Waffe!");
          break;

        case 4:
          if (Gold >= 520) {
            Min_Damage = 14;
            Max_Damage = 22;
            Gold = Gold - 520;
            Console.WriteLine("\nDreizack ausgewählt!");
            break;
          }
          Console.WriteLine("\nNicht genug Gold für diese Waffe!");
          break;

        case 5:
          if (Gold >= 800) {
            Min_Damage = 15;
            Max_Damage = 25;
            Gold = Gold - 800;
            Console.WriteLine("Bardike ausgewählt!");
            break;
          }
          Console.WriteLine("\nNicht genug Gold für diese Waffe!");
          break;

        case 6:
          if (Gold >= 1320) {
            Min_Damage = 19;
            Max_Damage = 29;
            Gold = Gold - 1320;
            Console.WriteLine("Hellebarde ausgewählt!");
            break;
          }
          Console.WriteLine("\nNicht genug Gold für diese Waffe!");
          break;

        case 7:
          if (Gold >= 1900) {
            Min_Damage = 20;
            Max_Damage = 35;
            Gold = Gold - 1900;
            Console.WriteLine("Kriegssense ausgewählt!");
            break;
          }
          Console.WriteLine("\nNicht genug Gold für diese Waffe!");
          break;

        default:
          Console.WriteLine("\nKeine Waffe ausgewählt!");
          break;
      }
    }
  }
}