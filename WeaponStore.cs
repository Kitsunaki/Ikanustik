using System;
using System.Collections.Generic;
using System.Linq;
using Ikanustik.Entities;
using Ikanustik.Entities.NPC;
using Ikanustik.Weapons;
using Ikanustik.Weapons.Axt;
using Ikanustik.Weapons.Flegel;
using Ikanustik.Weapons.Klingen;
using Ikanustik.Weapons.Projektil;
using Ikanustik.Weapons.Stangen;

namespace Ikanustik {

  internal class WeaponStore {
    private static readonly List<Waffe> _waffen = new List<Waffe>();

    /// <summary>
    /// Liste von Waffen zurück die im Store erhältlich sind.
    /// </summary>
    public static List<Waffe> Waffen {
      get {
        return _waffen;
      }
    }

    /// <summary>
    /// Statischer Konstruktor
    /// </summary>
    static WeaponStore() {
      InitStore();
    }

    /// <summary>
    /// Initialisiert den Store
    /// </summary>
    private static void InitStore() {
      // Äxte
      Waffen.AddRange(new Waffe[] {
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
      Waffen.AddRange(new Waffe[] {
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
      Waffen.AddRange(new Waffe[] {
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
      Waffen.AddRange(new Waffe[] {
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
      Waffen.AddRange(new Waffe[] {
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

    /// <summary>
    /// Gibt eine Liste an Waffen aus
    /// </summary>
    /// <param name="player">Der Spieler der mit dem Shop interargiert</param>
    /// <param name="waffengattung">Waffengattung nach welcher gefiltert werden soll</param>
    private static void ShowWeapons(Player player, Waffengattungen waffengattung) {
      /*
       * Sucht in der Liste "Waffen" alle Waffen einer speziellen Waffengattung.
       * Die Waffen werden im Anschluss nach ihrem Preis aufsteigend sortiert und in einer neuen Liste gespeichert.
       */
      var waffen = (from waffe in Waffen
                    where waffe.Waffengattung == waffengattung
                    orderby waffe.Cost
                    select waffe).ToList();

      Console.Clear();
      Menus.Bar();
      Console.WriteLine("\nWähle eine Waffe:\n");
      for (int i = 0; i < waffen.Count; i++) {
        Waffe w = waffen[i];
        Console.WriteLine($"\t{i + 1}) {w.Name}\t\tKostet {w.Cost} Gold\t\t{w.MinDamage}-{w.MaxDamage} Schaden");
      }
      Console.WriteLine($"\n\t0) Keine Auswahl treffen...");
      Console.Write("\nWahl: ");
      ChooseWeapon(player, waffen);
    }

    /// <summary>
    /// Wählt aus einer Liste von Waffen eine aus und fügt sie ggf. dem Spieler hinzu.
    /// </summary>
    /// <param name="player">Der Spieler</param>
    /// <param name="waffen">Liste mit Waffen</param>
    private static void ChooseWeapon(Player player, IList<Waffe> waffen) {
      /*
       * Dieser Delegat ersetzt die Codewiederholung zum anzeigen der Message
       */
      Action<string, int> printMessage = (message, timeToWait) => {
        Console.Clear();
        Console.Write(new string('\n', 10));
        Console.WriteLine(message);
        System.Threading.Thread.Sleep(2000);
      };

      int choose = int.Parse(Console.ReadLine());

      if (choose == 0) {
        printMessage($"\t\t\tDu behälst {player.ActiveWeapon.Name} als aktive Waffe!", 2000);
      } else if (choose > 0 && choose <= waffen.Count) {
        Waffe hand = (Waffe)waffen[choose - 1].Clone();
        if (player.Gold >= hand.Cost) {
          player.ActiveWeapon = hand;
          player.Gold -= hand.Cost;
          printMessage($"\t\t\t{player.ActiveWeapon.Name} wurde ausgewählt!", 2500);
        } else {
          printMessage("Dafür reicht dein Vermögen leider nicht aus!", 2000);
        }
      } else {
        Console.WriteLine("\nKeine Waffe ausgewählt!");
      }
    }

    public static void Store(Player player) {
      Console.Clear();
      Menus.Bar();
      Reinhart.Portrait();
      Console.Write($"Reinhart: \n\"Der aktuelle Schaden von {player.ActiveWeapon.Name} beträgt {player.ActiveWeapon.MinDamage}-{player.ActiveWeapon.MaxDamage} Schadenspunkte.");
      Console.WriteLine($"\nDu hast momentan {player.Gold} Gold bei dir. Was möchtest du dir anschauen?\"\n\n\tk) Klingenwaffen\n\tf) Flegelwaffen\n\ts) Stangenwaffen\n\ta) Axtwaffen\n\tp) Projektilwaffen\n");
      Console.WriteLine($"\tr) {player.ActiveWeapon.Name} reparieren\n\n\te) Nichts kaufen");
      Console.Write("\nWahl: ");

      char choose = Console.ReadKey(true).KeyChar;
      if (choose == 'k') {
        ShowWeapons(player, Waffengattungen.Klingen);
      } else if (choose == 'f') {
        ShowWeapons(player, Waffengattungen.Flegel);
      } else if (choose == 's') {
        ShowWeapons(player, Waffengattungen.Stangen);
      } else if (choose == 'a') {
        ShowWeapons(player, Waffengattungen.Axt);
      } else if (choose == 'p') {
        ShowWeapons(player, Waffengattungen.Projektil);
      } else if (choose == 'e') {
        Console.WriteLine("\nKeine Auswahl getroffen.");
        System.Threading.Thread.Sleep(2000);
      } else if (choose == 'r') {
        Reinhart.Repair(player);
      }
    }
  }
}