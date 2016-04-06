namespace Ikanustik.Weapons {

  internal class Kriegsbogen : Weapon {

    public Kriegsbogen() {
      Weapon_Name = "Kriegsbogen";
      Weapon_Class = "Projektilwaffe";
      Durability = 130;
      Weapon_FullDurability = 130;
      Weapon_Cost = 790;
      Min_Damage = 3;
      Max_Damage = 20;
    }

    public static new string Weapon_Name { get; set; }
    public static new string Weapon_Class { get; set; }
    public static new int Weapon_FullDurability { get; set; }
    public static new int Weapon_Cost { get; set; }
    public static new int Min_Damage { get; set; }
    public static new int Max_Damage { get; set; }
  }
}