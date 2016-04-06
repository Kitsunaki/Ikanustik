using System;
using Ikanustik.Entities;
using Ikanustik.Weapons;

namespace Ikanustik {

  internal class WeaponStore {

    public static void Store(Player player) {
      Console.Clear();
      Menus.Bar();
      Reinhart.ReinhartPortrait();
      Console.Write($"Reinhart: \n\"Der aktuelle Schaden von {player.Active_Weapon.Name} beträgt {player.Active_Weapon.MinDamage}-{player.Active_Weapon.MaxDamage} Schadenspunkte.");
      Console.WriteLine($"\nDu hast momentan {player.Gold} Gold bei dir. Was möchtest du dir anschauen?\"\n\n\tk) Klingenwaffen\n\tf) Flegelwaffen\n\ts) Stangenwaffen\n\ta) Axtwaffen\n\tp) Projektilwaffen\n");
      Console.WriteLine($"\tr) {player.Active_Weapon.Name} reparieren\n\n\te) Nichts kaufen");
      Console.Write("\nWahl: ");

      char choose = Console.ReadKey(true).KeyChar;
      if (choose == 'k') {
        Console.Clear();
        Menus.Bar();
        Console.WriteLine("\nWähle eine Waffe:\n");
        Console.WriteLine($"\t1) {Dolch.Weapon_Name}\t\tKostet {Dolch.Weapon_Cost} Gold\t\t{Dolch.Min_Damage}-{Dolch.Max_Damage} Schaden");
        Console.WriteLine($"\t2) {Krismesser.Weapon_Name}\t\tKostet {Krismesser.Weapon_Cost} Gold\t\t{Krismesser.Min_Damage}-{Krismesser.Max_Damage} Schaden");
        Console.WriteLine($"\t3) {Kurzschwert.Weapon_Name}\t\tKostet {Kurzschwert.Weapon_Cost} Gold\t\t{Kurzschwert.Min_Damage}-{Kurzschwert.Max_Damage} Schaden");
        Console.WriteLine($"\t4) {Krummsäbel.Weapon_Name}\t\tKostet {Krummsäbel.Weapon_Cost} Gold\t\t{Krummsäbel.Min_Damage}-{Krummsäbel.Max_Damage} Schaden");
        Console.WriteLine($"\t5) {Breitschwert.Weapon_Name}\t\tKostet {Breitschwert.Weapon_Cost} Gold\t\t{Breitschwert.Min_Damage}-{Breitschwert.Max_Damage} Schaden");
        Console.WriteLine($"\t6) {Claymore.Weapon_Name}\t\tKostet {Claymore.Weapon_Cost} Gold\t\t{Claymore.Min_Damage}-{Claymore.Max_Damage} Schaden");
        Console.WriteLine($"\t7) {Schweres_Bastardschwert.Weapon_Name}\tKostet {Schweres_Bastardschwert.Weapon_Cost} Gold\t{Schweres_Bastardschwert.Min_Damage}-{Schweres_Bastardschwert.Max_Damage} Schaden");
        Console.WriteLine($"\t8) {Kolossales_Flamberg.Weapon_Name}\t\tKostet {Kolossales_Flamberg.Weapon_Cost} Gold\t\t{Kolossales_Flamberg.Min_Damage}-{Kolossales_Flamberg.Max_Damage} Schaden");
        Console.WriteLine($"\t9) {Schattenkatana.Weapon_Name}\t\tKostet {Schattenkatana.Weapon_Cost} Gold\t\t{Schattenkatana.Min_Damage}-{Schattenkatana.Max_Damage} Schaden");
        Console.WriteLine($"\n\t0) Keine Auswahl treffen...");
        Console.Write("\nWahl: ");
        Weapon_choose_k(player);
      } else if (choose == 'f') {
        Console.Clear();
        Menus.Bar();
        Console.WriteLine($"\t1) {Schmiedehammer.Weapon_Name}\t\tKostet {Schmiedehammer.Weapon_Cost} Gold\t\t{Schmiedehammer.Min_Damage}-{Schmiedehammer.Max_Damage} Schaden");
        Console.WriteLine($"\t2) {Dreschflegel.Weapon_Name}\t\tKostet {Dreschflegel.Weapon_Cost} Gold\t\t{Dreschflegel.Min_Damage}-{Dreschflegel.Max_Damage} Schaden");
        Console.WriteLine($"\t3) {Streitkolben.Weapon_Name}\t\tKostet {Streitkolben.Weapon_Cost} Gold\t\t{Streitkolben.Min_Damage}-{Streitkolben.Max_Damage} Schaden");
        Console.WriteLine($"\t4) {Großer_Morgenstern.Weapon_Name}\t\tKostet {Großer_Morgenstern.Weapon_Cost} Gold\t\t{Großer_Morgenstern.Min_Damage}-{Großer_Morgenstern.Max_Damage} Schaden");
        Console.WriteLine($"\t5) {Kriegsszepter.Weapon_Name}\t\tKostet {Kriegsszepter.Weapon_Cost} Gold\t\t{Kriegsszepter.Min_Damage}-{Kriegsszepter.Max_Damage} Schaden");
        Console.WriteLine($"\t6) {Beidhändiger_Kriegshammer.Weapon_Name}\t\tKostet {Beidhändiger_Kriegshammer.Weapon_Cost} Gold\t\t{Beidhändiger_Kriegshammer.Min_Damage}-{Beidhändiger_Kriegshammer.Max_Damage} Schaden");
        Console.WriteLine($"\t7) {Höllenschmiedenhammer.Weapon_Name}\tKostet {Höllenschmiedenhammer.Weapon_Cost} Gold\t{Höllenschmiedenhammer.Min_Damage}-{Höllenschmiedenhammer.Max_Damage} Schaden");
        Console.WriteLine($"\t8) {Stygischer_Prunkknüttel.Weapon_Name}\t\tKostet {Stygischer_Prunkknüttel.Weapon_Cost} Gold\t\t{Stygischer_Prunkknüttel.Min_Damage}-{Stygischer_Prunkknüttel.Max_Damage} Schaden");
        Console.WriteLine($"\t9) {Archonsäule.Weapon_Name}\t\tKostet {Archonsäule.Weapon_Cost} Gold\t\t{Archonsäule.Min_Damage}-{Archonsäule.Max_Damage} Schaden");
        Console.WriteLine($"\n\t0) Keine Auswahl treffen...");
        Console.Write("\nWahl: ");
        Weapon_choose_f(player);
      } else if (choose == 's') {
        Console.Clear();
        Menus.Bar();
        Console.WriteLine($"\t1) {Langstab.Weapon_Name}\t\tKostet {Langstab.Weapon_Cost} Gold\t\t{Langstab.Min_Damage}-{Langstab.Max_Damage} Schaden");
        Console.WriteLine($"\t2) {Gleve.Weapon_Name}\t\tKostet {Gleve.Weapon_Cost} Gold\t\t{Gleve.Min_Damage}-{Gleve.Max_Damage} Schaden");
        Console.WriteLine($"\t3) {Langspeer.Weapon_Name}\t\tKostet {Langspeer.Weapon_Cost} Gold\t\t{Langspeer.Min_Damage}-{Langspeer.Max_Damage} Schaden");
        Console.WriteLine($"\t4) {Dreizack.Weapon_Name}\t\tKostet {Dreizack.Weapon_Cost} Gold\t\t{Dreizack.Min_Damage}-{Dreizack.Max_Damage} Schaden");
        Console.WriteLine($"\t5) {Bardike.Weapon_Name}\t\tKostet {Bardike.Weapon_Cost} Gold\t\t{Bardike.Min_Damage}-{Bardike.Max_Damage} Schaden");
        Console.WriteLine($"\t6) {Hellebarde.Weapon_Name}\t\tKostet {Hellebarde.Weapon_Cost} Gold\t\t{Hellebarde.Min_Damage}-{Hellebarde.Max_Damage} Schaden");
        Console.WriteLine($"\t7) {Kriegssense.Weapon_Name}\tKostet {Kriegssense.Weapon_Cost} Gold\t{Kriegssense.Min_Damage}-{Kriegssense.Max_Damage} Schaden");
        Console.WriteLine($"\t8) {Harpunenlanze.Weapon_Name}\t\tKostet {Harpunenlanze.Weapon_Cost} Gold\t\t{Harpunenlanze.Min_Damage}-{Harpunenlanze.Max_Damage} Schaden");
        Console.WriteLine($"\t9) {Spießstab_aus_Antioch.Weapon_Name}\t\tKostet {Spießstab_aus_Antioch.Weapon_Cost} Gold\t\t{Spießstab_aus_Antioch.Min_Damage}-{Spießstab_aus_Antioch.Max_Damage} Schaden");
        Console.WriteLine($"\n\t0) Keine Auswahl treffen...");
        Console.Write("\nWahl: ");
        Weapon_choose_s(player);
      } else if (choose == 'a') {
        Console.Clear();
        Menus.Bar();
        Console.WriteLine($"\t1) {Holzbeil.Weapon_Name}\t\tKostet {Holzbeil.Weapon_Cost} Gold\t\t{Holzbeil.Min_Damage}-{Holzbeil.Max_Damage} Schaden");
        Console.WriteLine($"\t2) {Spaltaxt.Weapon_Name}\t\tKostet {Spaltaxt.Weapon_Cost} Gold\t\t{Spaltaxt.Min_Damage}-{Spaltaxt.Max_Damage} Schaden");
        Console.WriteLine($"\t3) {Langaxt.Weapon_Name}\t\tKostet {Langaxt.Weapon_Cost} Gold\t\t{Langaxt.Min_Damage}-{Langaxt.Max_Damage} Schaden");
        Console.WriteLine($"\t4) {Rasiertalon.Weapon_Name}\t\tKostet {Rasiertalon.Weapon_Cost} Gold\t\t{Rasiertalon.Min_Damage}-{Rasiertalon.Max_Damage} Schaden");
        Console.WriteLine($"\t5) {Prunksichel.Weapon_Name}\t\tKostet {Prunksichel.Weapon_Cost} Gold\t\t{Prunksichel.Min_Damage}-{Prunksichel.Max_Damage} Schaden");
        Console.WriteLine($"\t6) {Doppelaxt.Weapon_Name}\t\tKostet {Doppelaxt.Weapon_Cost} Gold\t\t{Doppelaxt.Min_Damage}-{Doppelaxt.Max_Damage} Schaden");
        Console.WriteLine($"\t7) {Lochaber.Weapon_Name}\tKostet {Lochaber.Weapon_Cost} Gold\t{Lochaber.Min_Damage}-{Lochaber.Max_Damage} Schaden");
        Console.WriteLine($"\t8) {Antike_Spießaxt.Weapon_Name}\t\tKostet {Antike_Spießaxt.Weapon_Cost} Gold\t\t{Antike_Spießaxt.Min_Damage}-{Antike_Spießaxt.Max_Damage} Schaden");
        Console.WriteLine($"\t9) {Der_Wolkenbrecher.Weapon_Name}\t\tKostet {Der_Wolkenbrecher.Weapon_Cost} Gold\t\t{Der_Wolkenbrecher.Min_Damage}-{Der_Wolkenbrecher.Max_Damage} Schaden");
        Console.WriteLine($"\n\t0) Keine Auswahl treffen...");
        Console.Write("\nWahl: ");
        Weapon_choose_a(player);
      } else if (choose == 'p') {
        Console.Clear();
        Menus.Bar();
        Console.WriteLine($"\t1) {Leichter_Bogen.Weapon_Name}\t\tKostet {Leichter_Bogen.Weapon_Cost} Gold\t\t{Leichter_Bogen.Min_Damage}-{Leichter_Bogen.Max_Damage} Schaden");
        Console.WriteLine($"\t2) {Kleine_Armbrust.Weapon_Name}\t\tKostet {Kleine_Armbrust.Weapon_Cost} Gold\t\t{Kleine_Armbrust.Min_Damage}-{Kleine_Armbrust.Max_Damage} Schaden");
        Console.WriteLine($"\t3) {Kompositbogen.Weapon_Name}\t\tKostet {Kompositbogen.Weapon_Cost} Gold\t\t{Kompositbogen.Min_Damage}-{Kompositbogen.Max_Damage} Schaden");
        Console.WriteLine($"\t4) {Englischer_Langbogen.Weapon_Name}\t\tKostet {Englischer_Langbogen.Weapon_Cost} Gold\t\t{Englischer_Langbogen.Min_Damage}-{Englischer_Langbogen.Max_Damage} Schaden");
        Console.WriteLine($"\t5) {Kriegsbogen.Weapon_Name}\t\tKostet {Kriegsbogen.Weapon_Cost} Gold\t\t{Kriegsbogen.Min_Damage}-{Kriegsbogen.Max_Damage} Schaden");
        Console.WriteLine($"\t6) {Überschwere_Armbrust.Weapon_Name}\t\tKostet {Überschwere_Armbrust.Weapon_Cost} Gold\t\t{Überschwere_Armbrust.Min_Damage}-{Überschwere_Armbrust.Max_Damage} Schaden");
        Console.WriteLine($"\t7) {Balliste.Weapon_Name}\tKostet {Balliste.Weapon_Cost} Gold\t{Balliste.Min_Damage}-{Balliste.Max_Damage} Schaden");
        Console.WriteLine($"\t8) {Silber_Baliste.Weapon_Name}\t\tKostet {Silber_Baliste.Weapon_Cost} Gold\t\t{Silber_Baliste.Min_Damage}-{Silber_Baliste.Max_Damage} Schaden");
        Console.WriteLine($"\t9) {Walkürendonner.Weapon_Name}\t\tKostet {Walkürendonner.Weapon_Cost} Gold\t\t{Walkürendonner.Min_Damage}-{Walkürendonner.Max_Damage} Schaden");
        Console.WriteLine($"\n\t0) Keine Auswahl treffen...");
        Console.Write("\nWahl: ");
        Weapon_choose_p(player);
      } else if (choose == 'e') {
        Console.WriteLine("\nKeine Auswahl getroffen.");
        System.Threading.Thread.Sleep(2000);
      } else if (choose == 'r') {
        Reinhart.Repair(player);
      }
    }

    public static void Weapon_choose_k(Player player) {
      Weapon hand = null;
      int weapon = int.Parse(Console.ReadLine());
      switch (weapon) {
        case 1:
          hand = new Dolch();
          break;

        case 2:
          hand = new Krismesser();
          break;

        case 3:
          hand = new Kurzschwert();
          break;

        case 4:
          hand = new Krummsäbel();
          break;

        case 5:
          hand = new Breitschwert();
          break;

        case 6:
          hand = new Claymore();
          break;

        case 7:
          hand = new Schweres_Bastardschwert();
          break;

        case 8:
          hand = new Kolossales_Flamberg();
          break;

        case 9:
          hand = new Schattenkatana();
          break;

        case 0:
          break;

        default:
          Console.WriteLine("\nKeine Waffe ausgewählt!");
          break;
      }
      if (weapon == 0) {
        Console.Clear();
        Console.Write(new string('\n', 10));
        Console.WriteLine($"\t\t\tDu behälst {player.Active_Weapon.Name} als aktive Waffe!");
        System.Threading.Thread.Sleep(2000);
      } else if (player.Gold >= hand.Cost) {
        player.Active_Weapon = hand;
        player.Gold -= hand.Cost;
        Console.Clear();
        Console.Write(new String('\n', 10));
        Console.WriteLine($"\t\t\t{player.Active_Weapon.Name} wurde ausgewählt!");
        System.Threading.Thread.Sleep(2500);
      } else if (player.Gold <= hand.Cost) {
        Console.Clear();
        Console.Write(new String('\n', 10));
        Console.WriteLine("Dafür reicht dein Vermögen leider nicht aus!");
        System.Threading.Thread.Sleep(2000);
      }
    }

    public static void Weapon_choose_f(Player player) {
      Weapon hand = null;
      int weapon = int.Parse(Console.ReadLine());
      switch (weapon) {
        case 1:
          hand = new Schmiedehammer();
          break;

        case 2:
          hand = new Dreschflegel();
          break;

        case 3:
          hand = new Streitkolben();
          break;

        case 4:
          hand = new Großer_Morgenstern();
          break;

        case 5:
          hand = new Kriegsszepter();
          break;

        case 6:
          hand = new Beidhändiger_Kriegshammer();
          break;

        case 7:
          hand = new Höllenschmiedenhammer();
          break;

        case 8:
          hand = new Stygischer_Prunkknüttel();
          break;

        case 9:
          hand = new Archonsäule();
          break;

        default:
          Console.WriteLine("\nKeine Waffe ausgewählt!");
          break;
      }
      if (weapon == 0) {
        Console.Clear();
        Console.Write(new string('\n', 10));
        Console.WriteLine($"\t\t\tDu behälst {player.Active_Weapon.Name} als aktive Waffe!");
        System.Threading.Thread.Sleep(2000);
      } else if (player.Gold >= hand.Cost) {
        player.Active_Weapon = hand;
        player.Gold -= hand.Cost;
        Console.Clear();
        Console.Write(new String('\n', 10));
        Console.WriteLine($"\t\t\t{player.Active_Weapon.Name} wurde ausgewählt!");
        System.Threading.Thread.Sleep(2500);
      } else if (player.Gold <= hand.Cost) {
        Console.Clear();
        Console.Write(new String('\n', 10));
        Console.WriteLine("Dafür reicht dein Vermögen leider nicht aus!");
        System.Threading.Thread.Sleep(2000);
      }
    }

    public static void Weapon_choose_s(Player player) {
      Weapon hand = null;
      int weapon = int.Parse(Console.ReadLine());
      switch (weapon) {
        case 1:
          hand = new Langstab();
          break;

        case 2:
          hand = new Gleve();
          break;

        case 3:
          hand = new Langspeer();
          break;

        case 4:
          hand = new Dreizack();
          break;

        case 5:
          hand = new Bardike();
          break;

        case 6:
          hand = new Hellebarde();
          break;

        case 7:
          hand = new Kriegssense();
          break;

        case 8:
          hand = new Harpunenlanze();
          break;

        case 9:
          hand = new Spießstab_aus_Antioch();
          break;

        default:
          Console.WriteLine("\nKeine Waffe ausgewählt!");
          break;
      }
      if (weapon == 0) {
        Console.Clear();
        Console.Write(new string('\n', 10));
        Console.WriteLine($"\t\t\tDu behälst {player.Active_Weapon.Name} als aktive Waffe!");
        System.Threading.Thread.Sleep(2000);
      } else if (player.Gold >= hand.Cost) {
        player.Active_Weapon = hand;
        player.Gold -= hand.Cost;
        Console.Clear();
        Console.Write(new String('\n', 10));
        Console.WriteLine($"\t\t\t{player.Active_Weapon.Name} wurde ausgewählt!");
        System.Threading.Thread.Sleep(2500);
      } else if (player.Gold <= hand.Cost) {
        Console.Clear();
        Console.Write(new String('\n', 10));
        Console.WriteLine("Dafür reicht dein Vermögen leider nicht aus!");
        System.Threading.Thread.Sleep(2000);
      }
    }

    public static void Weapon_choose_a(Player player) {
      Weapon hand = null;
      int weapon = int.Parse(Console.ReadLine());
      switch (weapon) {
        case 1:
          hand = new Holzbeil();
          break;

        case 2:
          hand = new Spaltaxt();
          break;

        case 3:
          hand = new Langaxt();
          break;

        case 4:
          hand = new Rasiertalon();
          break;

        case 5:
          hand = new Prunksichel();
          break;

        case 6:
          hand = new Doppelaxt();
          break;

        case 7:
          hand = new Lochaber();
          break;

        case 8:
          hand = new Antike_Spießaxt();
          break;

        case 9:
          hand = new Der_Wolkenbrecher();
          break;

        case 0:
          break;

        default:
          Console.WriteLine("\nKeine Waffe ausgewählt!");
          break;
      }
      if (weapon == 0) {
        Console.Clear();
        Console.Write(new string('\n', 10));
        Console.WriteLine($"\t\t\tDu behälst {player.Active_Weapon.Name} als aktive Waffe!");
        System.Threading.Thread.Sleep(2000);
      } else if (player.Gold >= hand.Cost) {
        player.Active_Weapon = hand;
        player.Gold -= hand.Cost;
        Console.Clear();
        Console.Write(new String('\n', 10));
        Console.WriteLine($"\t\t\t{player.Active_Weapon.Name} wurde ausgewählt!");
        System.Threading.Thread.Sleep(2500);
      } else if (player.Gold <= hand.Cost) {
        Console.Clear();
        Console.Write(new String('\n', 10));
        Console.WriteLine("Dafür reicht dein Vermögen leider nicht aus!");
        System.Threading.Thread.Sleep(2000);
      }
    }

    public static void Weapon_choose_p(Player player) {
      Weapon hand = null;
      int weapon = int.Parse(Console.ReadLine());
      switch (weapon) {
        case 1:
          hand = new Leichter_Bogen();
          break;

        case 2:
          hand = new Kleine_Armbrust();
          break;

        case 3:
          hand = new Kompositbogen();
          break;

        case 4:
          hand = new Englischer_Langbogen();
          break;

        case 5:
          hand = new Kriegsbogen();
          break;

        case 6:
          hand = new Überschwere_Armbrust();
          break;

        case 7:
          hand = new Balliste();
          break;

        case 8:
          hand = new Silber_Baliste();
          break;

        case 9:
          hand = new Walkürendonner();
          break;

        case 0:
          break;

        default:
          Console.WriteLine("\nKeine Waffe ausgewählt!");
          break;
      }
      if (weapon == 0) {
        Console.Clear();
        Console.Write(new string('\n', 10));
        Console.WriteLine($"\t\t\tDu behälst {player.Active_Weapon.Name} als aktive Waffe!");
        System.Threading.Thread.Sleep(2000);
      } else if (player.Gold >= hand.Cost) {
        player.Active_Weapon = hand;
        player.Gold -= hand.Cost;
        Console.Clear();
        Console.Write(new String('\n', 10));
        Console.WriteLine($"\t\t\t{player.Active_Weapon.Name} wurde ausgewählt!");
        System.Threading.Thread.Sleep(2500);
      } else if (player.Gold <= hand.Cost) {
        Console.Clear();
        Console.Write(new String('\n', 10));
        Console.WriteLine("Dafür reicht dein Vermögen leider nicht aus!");
        System.Threading.Thread.Sleep(2000);
      }
    }
  }
}