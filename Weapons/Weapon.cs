using System;
using Ikanustik.Entities;

namespace Ikanustik.Weapons {

  internal abstract class Weapon {
    private static Random W = new Random();
    private static Random D = new Random();
    private static Random S = new Random();
    private static Random ED = new Random();
    private static Random EH = new Random();
    private static Random RESI = new Random();

    public string Weapon_Name { get; set; }
    public string Weapon_Class { get; set; }
    public int Weapon_Cost { get; set; }
    public int Weapon_Durability { get; set; }
    public int Weapon_FullDurability { get; set; }
    public int Min_Damage { get; set; }
    public int Max_Damage { get; set; }
    public int Full_Damage { get; set; }
    public int Enemy_Damage { get; set; }

    public string Attack(Entity entity, Player player) {
      if (entity.Health >= 1) {
        Console.Clear();
        Console.Write(new String('\n', 10));
        Console.WriteLine($"{player.Name} greift nun an!");
        System.Threading.Thread.Sleep(2000);

        StabAni(player, entity);
        string Krit_Case = " ";
        if (player.Satisfaction >= 100) {
          player.Satisfaction -= 100;
          Full_Damage = W.Next(Min_Damage * 3, ((Max_Damage * (player.Strengh / 10)) + 1) * 3);
          Krit_Case = "KOLLER!\n\tEin kritischer Treffer wurde eingefahren, doch die Genugtuung sinkt \n\twieder!";
        } else {
          Full_Damage = W.Next(Min_Damage, ((Max_Damage * (player.Strengh / 10)) + 1));
        }

        int EnemyDUR = 0;
        if (player.Active_Weapon.Weapon_Class != "Projektilwaffe") {
          Full_Damage = Full_Damage * (100 - entity.Armor) / 100;
          EnemyDUR = entity.Armor;
        }

        entity.Health -= Full_Damage;

        int Satisfaction_Rise = S.Next(0, 26);
        player.Satisfaction += Satisfaction_Rise;

        string Weapon_Lost = " ";
        int Lose_Durability = D.Next(0, 2);
        Weapon_Durability -= Lose_Durability;
        if (Weapon_Durability <= 0) {
          player.Active_Weapon = new Faust();
          Weapon_Lost = "Die Waffe ist zerstört. Du kämpfst mit der Faust weiter!";
        }

        return $"\n\n\n\n\n\n\n\n\t{Krit_Case}\n\t{entity.Name} reduziert seinen Schaden um {EnemyDUR}% und erleidet noch {Full_Damage} Schaden.\n\tDie Waffe \"{player.Active_Weapon.Weapon_Name}\" verlor {Lose_Durability} Haltbarkeit.\n\tDie Genugtuung stieg um {Satisfaction_Rise}% an.\n\t{Weapon_Lost}";
      } else {
        return $"\t\t\t\tGegner vernichtet!";
      }
    }

    public string EnemyAttack(Player player, Entity entity) {
      if (player.Health >= 1) {
        Console.Clear();
        Console.Write(new String('\n', 10));
        Console.WriteLine($"{entity.Name} greift nun an!");
        System.Threading.Thread.Sleep(1000);

        EneStabAni(player, entity);

        Enemy_Damage = ED.Next(entity.DamageMin, entity.DamageMax + 1);

        int ResiPercent = 25;
        if (player.Strengh >= 120) { ResiPercent = 95; } else if (player.Strengh >= 75) { ResiPercent = 90; } else if (player.Strengh >= 45) { ResiPercent = 75; } else if (player.Strengh >= 25) { ResiPercent = 50; } else { ResiPercent = 25; }
        int PlayerResi = RESI.Next(player.Resilienz, (ResiPercent + 1));
        Enemy_Damage -= ((Enemy_Damage * PlayerResi) / 100);

        player.Health -= Enemy_Damage;

        int EnemyRoundHeal = 0;
        int IfHeal = EH.Next(0, 2);
        if (IfHeal == 1) {
          entity.Health += entity.Regeneration;
          EnemyRoundHeal = entity.Regeneration;
        }

        return $"\n\n\n\n\n\n\n\n\t{entity.Name} teilte {Enemy_Damage} Schaden aus.\n\t{entity.Name} heilte sich um {EnemyRoundHeal} selbst.\n\tDu widerstandest {PlayerResi}% des eigentlichen Schadens.";
      } else {
        player.Health = 1;
        return $"\n\n\n\n\n\n\n\n{player.Name} fällt in Ohnmacht.";
      }
    }

    private static void StabAni(Player player, Entity entity) {
      int i;
      string LZ = " ";
      for (i = 0; i < 48; i++) {
        Console.Clear();
        LZ = LZ.Insert(1, " ");
        Console.Write(new String('\n', 7));
        Console.WriteLine("       {0,-50} {1,20}\n\n", player.Name, entity.Name);
        Console.WriteLine(LZ + "       /|   ________________");
        Console.WriteLine(LZ + "O |===| * > ________________ >");
        Console.WriteLine(LZ + "       \\| ");
        System.Threading.Thread.Sleep(25);
      }
      for (i = 0; i < 48; i++) {
        Console.Clear();
        LZ = LZ.Remove(1, 1);
        Console.Write(new String('\n', 7));
        Console.WriteLine("       {0,-50} {1,20}\n\n", player.Name, entity.Name);
        Console.WriteLine(LZ + "       /|   ________________");
        Console.WriteLine(LZ + "O |===| * > ________________ >");
        Console.WriteLine(LZ + "       \\| ");
        System.Threading.Thread.Sleep(25);
      }
      Console.Clear();
    }

    private static void EneStabAni(Player player, Entity entity) {
      int i;
      string LZ = "                                                ";
      for (i = 0; i < 47; i++) {
        Console.Clear();
        LZ = LZ.Remove(1, 1);
        Console.Write(new String('\n', 7));
        Console.WriteLine("       {0,-50} {1,20}\n\n", player.Name, entity.Name);
        Console.WriteLine(LZ + "  ________________   |\\");
        Console.WriteLine(LZ + "< ________________ < * |===| O");
        Console.WriteLine(LZ + "                     |/ ");
        System.Threading.Thread.Sleep(25);
      }
      for (i = 0; i < 48; i++) {
        Console.Clear();
        LZ = LZ.Insert(1, " ");
        Console.Write(new String('\n', 7));
        Console.WriteLine("       {0,-50} {1,20}\n\n", player.Name, entity.Name);
        Console.WriteLine(LZ + "  ________________   |\\");
        Console.WriteLine(LZ + "< ________________ < * |===| O");
        Console.WriteLine(LZ + "                     |/ ");
        System.Threading.Thread.Sleep(25);
      }
      Console.Clear();
    }
  }
}