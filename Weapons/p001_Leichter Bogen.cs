namespace Ikanustik.Weapons {

  internal class Leichter_Bogen : Weapon {

    public Leichter_Bogen() {
      Weapon_Name = "Leichter Bogen";
      Weapon_Class = "Projektilwaffe";
      Weapon_Durability = 30;
      Weapon_FullDurability = 30;
      Weapon_Cost = 25;
      Min_Damage = 1;
      Max_Damage = 4;
    }

    public static new string Weapon_Name { get; set; }
    public static new string Weapon_Class { get; set; }
    public static new int Weapon_FullDurability { get; set; }
    public static new int Weapon_Cost { get; set; }
    public static new int Min_Damage { get; set; }
    public static new int Max_Damage { get; set; }
  }
}