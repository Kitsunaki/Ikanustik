namespace Ikanustik.Weapons {

  internal class Kriegssense : Weapon {

    public Kriegssense() {
      Weapon_Name = "Kriegssense";
      Weapon_Class = "Stangenwaffe";
      Durability = 68;
      Weapon_FullDurability = 68;
      Weapon_Cost = 2100;
      Min_Damage = 14;
      Max_Damage = 33;
    }

    public static new string Weapon_Name { get; set; }
    public static new string Weapon_Class { get; set; }
    public static new int Weapon_FullDurability { get; set; }
    public static new int Weapon_Cost { get; set; }
    public static new int Min_Damage { get; set; }
    public static new int Max_Damage { get; set; }
  }
}