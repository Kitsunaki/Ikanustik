namespace Ikanustik.Weapons {

  internal class Balliste : Weapon {

    public Balliste() {
      Weapon_Name = "Balliste";
      Weapon_Class = "Projektilwaffe";
      Weapon_Durability = 250;
      Weapon_FullDurability = 250;
      Weapon_Cost = 1800;
      Min_Damage = 4;
      Max_Damage = 28;
    }

    public static new string Weapon_Name { get; set; }
    public static new string Weapon_Class { get; set; }
    public static new int Weapon_FullDurability { get; set; }
    public static new int Weapon_Cost { get; set; }
    public static new int Min_Damage { get; set; }
    public static new int Max_Damage { get; set; }
  }
}