namespace Ikanustik.Weapons {

  internal class Harpunenlanze : Weapon {

    public Harpunenlanze() {
      Weapon_Name = "Harpunenlanze";
      Weapon_Class = "Stangenwaffe";
      Durability = 75;
      Weapon_FullDurability = 75;
      Weapon_Cost = 2500;
      Min_Damage = 16;
      Max_Damage = 38;
    }

    public static new string Weapon_Name { get; set; }
    public static new string Weapon_Class { get; set; }
    public static new int Weapon_FullDurability { get; set; }
    public static new int Weapon_Cost { get; set; }
    public static new int Min_Damage { get; set; }
    public static new int Max_Damage { get; set; }
  }
}