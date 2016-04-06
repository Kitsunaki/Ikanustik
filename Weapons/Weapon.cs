using System;
using Ikanustik.Entities;

namespace Ikanustik.Weapons {

  internal abstract class Weapon : ICloneable {
    private static Random RND = new Random();

    public string Name { get; set; }
    public WeaponClass Class { get; protected set; }
    public int Cost { get; set; }
    public int Durability { get; set; }
    public int FullDurability { get; set; }
    public int MinDamage { get; set; }
    public int MaxDamage { get; set; }
    public int FullDamage { get; set; }
    public int EnemyDamage { get; set; }

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
          FullDamage = RND.Next(MinDamage * 3, ((MaxDamage * (player.Strengh / 10)) + 1) * 3);
          Krit_Case = "KOLLER!\n\tEin kritischer Treffer wurde eingefahren, doch die Genugtuung sinkt \n\twieder!";
        } else {
          FullDamage = RND.Next(MinDamage, ((MaxDamage * (player.Strengh / 10)) + 1));
        }

        int EnemyDUR = 0;
        if (player.ActiveWeapon.Class != WeaponClass.Projektil) {
          FullDamage = FullDamage * (100 - entity.Armor) / 100;
          EnemyDUR = entity.Armor;
        }

        entity.Health -= FullDamage;

        int Satisfaction_Rise = RND.Next(0, 26);
        player.Satisfaction += Satisfaction_Rise;

        string Weapon_Lost = " ";
        int Lose_Durability = RND.Next(0, 2);
        Durability -= Lose_Durability;
        if (Durability <= 0) {
          player.ActiveWeapon = new Faust();
          Weapon_Lost = "Die Waffe ist zerstört. Du kämpfst mit der Faust weiter!";
        }

        return $"\n\n\n\n\n\n\n\n\t{Krit_Case}\n\t{entity.Name} reduziert seinen Schaden um {EnemyDUR}% und erleidet noch {FullDamage} Schaden.\n\tDie Waffe \"{player.ActiveWeapon.Name}\" verlor {Lose_Durability} Haltbarkeit.\n\tDie Genugtuung stieg um {Satisfaction_Rise}% an.\n\t{Weapon_Lost}";
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

        EnemyDamage = RND.Next(entity.DamageMin, entity.DamageMax + 1);

        int ResiPercent = 25;
        if (player.Strengh >= 120) { ResiPercent = 95; } else if (player.Strengh >= 75) { ResiPercent = 90; } else if (player.Strengh >= 45) { ResiPercent = 75; } else if (player.Strengh >= 25) { ResiPercent = 50; } else { ResiPercent = 25; }
        int PlayerResi = RND.Next(player.Resilienz, (ResiPercent + 1));
        EnemyDamage -= ((EnemyDamage * PlayerResi) / 100);

        player.Health -= EnemyDamage;

        int EnemyRoundHeal = 0;
        int IfHeal = RND.Next(0, 2);
        if (IfHeal == 1) {
          entity.Health += entity.Regeneration;
          EnemyRoundHeal = entity.Regeneration;
        }

        return $"\n\n\n\n\n\n\n\n\t{entity.Name} teilte {EnemyDamage} Schaden aus.\n\t{entity.Name} heilte sich um {EnemyRoundHeal} selbst.\n\tDu widerstandest {PlayerResi}% des eigentlichen Schadens.";
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

    protected static void AddWeaponToStore(Weapon weapon) {
      if (!WeaponStore.Weapons.ContainsKey(weapon.Name))
        WeaponStore.Weapons.Add(weapon.Name, weapon);
    }

    public object Clone() {
      return this.MemberwiseClone();
    }
  }
}