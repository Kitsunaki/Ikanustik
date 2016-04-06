namespace Ikanustik.Weapons {

  internal class Holzbeil : Weapon {

    public Holzbeil() {
      Weapon_Name = "Holzbeil";
      Weapon_Class = "Axtwaffe";
      Weapon_Durability = 11;
      Weapon_FullDurability = 11;
      Weapon_Cost = 40;
      Min_Damage = 5;
      Max_Damage = 8;
    }

    public static new string Weapon_Name { get; set; }
    public static new string Weapon_Class { get; set; }
    public static new int Weapon_FullDurability { get; set; }
    public static new int Weapon_Cost { get; set; }
    public static new int Min_Damage { get; set; }
    public static new int Max_Damage { get; set; }
  }
}