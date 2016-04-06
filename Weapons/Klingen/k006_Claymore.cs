namespace Ikanustik.Weapons {

  internal class Claymore : Weapon {

    public Claymore() {
      Weapon_Name = "Claymore";
      Weapon_Class = "Klingenwaffe";
      Durability = 83;
      Weapon_FullDurability = 83;
      Weapon_Cost = 900;
      Min_Damage = 15;
      Max_Damage = 22;
    }

    public static new string Weapon_Name { get; set; }
    public static new string Weapon_Class { get; set; }
    public static new int Weapon_FullDurability { get; set; }
    public static new int Weapon_Cost { get; set; }
    public static new int Min_Damage { get; set; }
    public static new int Max_Damage { get; set; }
  }
}