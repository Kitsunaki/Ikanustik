namespace Ikanustik.Weapons {

  internal class Breitschwert : Weapon {

    public Breitschwert() {
      Weapon_Name = "Breitschwert";
      Weapon_Class = "Klingenwaffe";
      Weapon_Durability = 55;
      Weapon_FullDurability = 55;
      Weapon_Cost = 400;
      Min_Damage = 11;
      Max_Damage = 16;
    }

    public static new string Weapon_Name { get; set; }
    public static new string Weapon_Class { get; set; }
    public static new int Weapon_FullDurability { get; set; }
    public static new int Weapon_Cost { get; set; }
    public static new int Min_Damage { get; set; }
    public static new int Max_Damage { get; set; }
  }
}