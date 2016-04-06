namespace Ikanustik.Weapons {

  internal class Beidhändiger_Kriegshammer : Weapon {

    public Beidhändiger_Kriegshammer() {
      Weapon_Name = "Beidhändiger Kriegshammer";
      Weapon_Class = "Flegelwaffe";
      Durability = 180;
      Weapon_FullDurability = 180;
      Weapon_Cost = 1050;
      Min_Damage = 14;
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