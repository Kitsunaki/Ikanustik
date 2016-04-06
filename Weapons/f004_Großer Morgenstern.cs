namespace Ikanustik.Weapons {

  internal class Großer_Morgenstern : Weapon {

    public Großer_Morgenstern() {
      Weapon_Name = "Großer Morgenstern";
      Weapon_Class = "Flegelwaffe";
      Weapon_Durability = 115;
      Weapon_Durability = 115;
      Weapon_Cost = 280;
      Min_Damage = 8;
      Max_Damage = 13;
    }

    public static new string Weapon_Name { get; set; }
    public static new string Weapon_Class { get; set; }
    public static new int Weapon_FullDurability { get; set; }
    public static new int Weapon_Cost { get; set; }
    public static new int Min_Damage { get; set; }
    public static new int Max_Damage { get; set; }
  }
}