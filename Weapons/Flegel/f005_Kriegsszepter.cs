namespace Ikanustik.Weapons {

  internal class Kriegsszepter : Weapon {

    public Kriegsszepter() {
      Weapon_Name = "Kriegsszepter";
      Weapon_Class = "Flegelwaffe";
      Durability = 130;
      Weapon_FullDurability = 130;
      Weapon_Cost = 440;
      Min_Damage = 10;
      Max_Damage = 17;
    }

    public static new string Weapon_Name { get; set; }
    public static new string Weapon_Class { get; set; }
    public static new int Weapon_FullDurability { get; set; }
    public static new int Weapon_Cost { get; set; }
    public static new int Min_Damage { get; set; }
    public static new int Max_Damage { get; set; }
  }
}