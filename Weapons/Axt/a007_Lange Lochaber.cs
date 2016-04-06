namespace Ikanustik.Weapons {

  internal class Lochaber : Weapon {

    public Lochaber() {
      Weapon_Name = "Lange Lochaber";
      Weapon_Class = "Axtwaffe";
      Durability = 68;
      Weapon_FullDurability = 68;
      Weapon_Cost = 3000;
      Min_Damage = 30;
      Max_Damage = 36;
    }

    public static new string Weapon_Name { get; set; }
    public static new string Weapon_Class { get; set; }
    public static new int Weapon_FullDurability { get; set; }
    public static new int Weapon_Cost { get; set; }
    public static new int Min_Damage { get; set; }
    public static new int Max_Damage { get; set; }
  }
}