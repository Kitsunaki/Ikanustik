using System;
using Ikanustik.Entities;

namespace Ikanustik.Weapons {

  internal abstract class Weapon {
    private static Random W = new Random();

    public string Weapon_Name { get; set; }
    public int Min_Damage { get; set; }
    public int Max_Damage { get; set; }
    public double Full_Damage { get; set; }

    public string Attack(Entity entity) {
      if (entity.Health >= 0.2) {
        StabAni();

        double Full_Damage = W.Next(Min_Damage, Max_Damage + 1);
        entity.Health -= Full_Damage;
        return $"{entity.Name} erleidet {Full_Damage} Schaden.";
      } else {
        return $"Overkill-";
      }
    }

    private static void StabAni() {
      int i;
      string LZ = " ";
      for (i = 0; i < 48; i++) {
        Console.Clear();
        LZ = LZ.Insert(1, " ");
        Console.Write(new String('\n', 10));
        Console.WriteLine(LZ + "       /|   ________________");
        Console.WriteLine(LZ + "O |===| * > ________________ >");
        Console.WriteLine(LZ + "       \\| ");
        System.Threading.Thread.Sleep(25);
      }
      for (i = 0; i < 48; i++) {
        Console.Clear();
        LZ = LZ.Remove(1, 1);
        Console.Write(new String('\n', 10));
        Console.WriteLine(LZ + "       /|   ________________");
        Console.WriteLine(LZ + "O |===| * > ________________ >");
        Console.WriteLine(LZ + "       \\| ");
        System.Threading.Thread.Sleep(25);
      }
      Console.Clear();
    }
  }
}