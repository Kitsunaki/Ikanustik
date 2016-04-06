namespace Ikanustik.Weapons {

  internal class Krummsäbel : Weapon {

    public Krummsäbel() {
      Weapon_Name = "Krummsäbel";
      Weapon_Class = "Klingenwaffe";
      Weapon_Durability = 38;
      Weapon_FullDurability = 38;
      Weapon_Cost = 200;
      Min_Damage = 8;
      Max_Damage = 12;
    }

    public static new string Weapon_Name { get; set; }
    public static new string Weapon_Class { get; set; }
    public static new int Weapon_FullDurability { get; set; }
    public static new int Weapon_Cost { get; set; }
    public static new int Min_Damage { get; set; }
    public static new int Max_Damage { get; set; }
  }
}