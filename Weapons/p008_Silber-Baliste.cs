namespace Ikanustik.Weapons {

  internal class Silber_Baliste : Weapon {

    public Silber_Baliste() {
      Weapon_Name = "Silber-Balliste";
      Weapon_Class = "Projektilwaffe";
      Weapon_Durability = 280;
      Weapon_FullDurability = 280;
      Weapon_Cost = 2250;
      Min_Damage = 4;
      Max_Damage = 34;
    }

    public static new string Weapon_Name { get; set; }
    public static new string Weapon_Class { get; set; }
    public static new int Weapon_FullDurability { get; set; }
    public static new int Weapon_Cost { get; set; }
    public static new int Min_Damage { get; set; }
    public static new int Max_Damage { get; set; }
  }
}