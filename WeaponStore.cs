using System;
using System.Collections.Generic;
using System.Linq;
using Ikanustik.Entities;
using Ikanustik.Weapons;
using Ikanustik.Weapons.Axt;
using Ikanustik.Weapons.Flegel;
using Ikanustik.Weapons.Klingen;
using Ikanustik.Weapons.Projektil;
using Ikanustik.Weapons.Stangen;

namespace Ikanustik {

  internal class WeaponStore {
    private static readonly List<Waffe> _weapons = new List<Waffe>();

    public static List<Waffe> Weapons {
      get {
        return _weapons;
      }
    }

    static WeaponStore() {
      AddWeaponsToShop();
    }

    private static void AddWeaponsToShop() {
      // Äxte
      Weapons.AddRange(new Waffe[] {
        new AntikeSpießaxt(),
        new DerWolkenbrecher(),
        new Doppelaxt(),
        new Holzbeil(),
        new Langaxt(),
        new LangeLochaber(),
        new Prunksichel(),
        new Rasiertalon(),
        new Spaltaxt()
      });

      // Flegel
      Weapons.AddRange(new Waffe[] {
        new Archonsäule(),
        new BeidhändigerKriegshammer(),
        new Dreschflegel(),
        new GroßerMorgenstern(),
        new Höllenschmiedenhammer(),
        new Kriegsszepter(),
        new Schmiedehammer(),
        new Streitkolben(),
        new StygischerPrunkknüttel()
      });

      // Klingen
      Weapons.AddRange(new Waffe[] {
        new Breitschwert(),
        new Claymore(),
        new Dolch(),
        new KolossalesFlamberg(),
        new Krismesser(),
        new Krummsäbel(),
        new Kurzschwert(),
        new Schattenkatana(),
        new SchweresBastardschwert()
      });

      // Projektil
      Weapons.AddRange(new Waffe[] {
        new Balliste(),
        new EnglischerLangbogen(),
        new KleineArmbrust(),
        new Kompositbogen(),
        new Kriegsbogen(),
        new LeichterBogen(),
        new SilberBaliste(),
        new ÜberschwereArmbrust(),
        new Walkürendonner()
      });

      // Stangen
      Weapons.AddRange(new Waffe[] {
        new Bardike(),
        new Dreizack(),
        new Gleve(),
        new Harpunenlanze(),
        new Hellebarde(),
        new Kriegssense(),
        new Langspeer(),
        new Langstab(),
        new SpießstabAusAntioch()
      });
    }

    private static void ShowWeapons(Player player, Waffengattung waffengattung) {
      var weapons = (from weapon in Weapons
                     where weapon.Waffengattung == waffengattung
                     orderby weapon.Cost
                     select weapon).ToList();

      Console.Clear();
      Menus.Bar();
      Console.WriteLine("\nWähle eine Waffe:\n");
      for (int i = 0; i < weapons.Count; i++) {
        Waffe w = weapons[i];
        Console.WriteLine($"\t{i}) {w.Name}\t\tKostet {w.Cost} Gold\t\t{w.MinDamage}-{w.MaxDamage} Schaden");
      }
      Console.WriteLine($"\n\t0) Keine Auswahl treffen...");
      Console.Write("\nWahl: ");
      ChooseWeapon(player, weapons);
    }

    public static void Store(Player player) {
      Console.Clear();
      Menus.Bar();
      Reinhart.ReinhartPortrait();
      Console.Write($"Reinhart: \n\"Der aktuelle Schaden von {player.ActiveWeapon.Name} beträgt {player.ActiveWeapon.MinDamage}-{player.ActiveWeapon.MaxDamage} Schadenspunkte.");
      Console.WriteLine($"\nDu hast momentan {player.Gold} Gold bei dir. Was möchtest du dir anschauen?\"\n\n\tk) Klingenwaffen\n\tf) Flegelwaffen\n\ts) Stangenwaffen\n\ta) Axtwaffen\n\tp) Projektilwaffen\n");
      Console.WriteLine($"\tr) {player.ActiveWeapon.Name} reparieren\n\n\te) Nichts kaufen");
      Console.Write("\nWahl: ");

      char choose = Console.ReadKey(true).KeyChar;
      if (choose == 'k') {
        ShowWeapons(player, Waffengattung.Klingen);
      } else if (choose == 'f') {
        ShowWeapons(player, Waffengattung.Flegel);
      } else if (choose == 's') {
        ShowWeapons(player, Waffengattung.Stangen);
      } else if (choose == 'a') {
        ShowWeapons(player, Waffengattung.Axt);
      } else if (choose == 'p') {
        ShowWeapons(player, Waffengattung.Projektil);
      } else if (choose == 'e') {
        Console.WriteLine("\nKeine Auswahl getroffen.");
        System.Threading.Thread.Sleep(2000);
      } else if (choose == 'r') {
        Reinhart.Repair(player);
      }
    }

    private static void ChooseWeapon(Player player, IList<Waffe> waffen) {
      int weapon = int.Parse(Console.ReadLine());

      if (weapon == 0) {
        Console.Clear();
        Console.Write(new string('\n', 10));
        Console.WriteLine($"\t\t\tDu behälst {player.ActiveWeapon.Name} als aktive Waffe!");
        System.Threading.Thread.Sleep(2000);
      } else if (weapon > 0 && weapon <= waffen.Count) {
        Waffe hand = (Waffe)waffen[weapon - 1].Clone();
        if (player.Gold >= hand.Cost) {
          player.ActiveWeapon = hand;
          player.Gold -= hand.Cost;
          Console.Clear();
          Console.Write(new String('\n', 10));
          Console.WriteLine($"\t\t\t{player.ActiveWeapon.Name} wurde ausgewählt!");
          System.Threading.Thread.Sleep(2500);
        } else {
          Console.Clear();
          Console.Write(new String('\n', 10));
          Console.WriteLine("Dafür reicht dein Vermögen leider nicht aus!");
          System.Threading.Thread.Sleep(2000);
        }
      } else {
        Console.WriteLine("\nKeine Waffe ausgewählt!");
      }
    }
  }
}