namespace Ikanustik.Weapons {

  internal class Dolch : Weapon {

    public Dolch() {
      Weapon_Name = "Dolch";
      Weapon_Class = "Klingenwaffe";
      Durability = 10;
      Weapon_FullDurability = 10;
      Weapon_Cost = 0;
      Min_Damage = 1;
      Max_Damage = 3;
    }

    public static new string Weapon_Name { get; set; }
    public static new string Weapon_Class { get; set; }
    public static new int Weapon_FullDurability { get; set; }
    public static new int Weapon_Cost { get; set; }
    public static new int Min_Damage { get; set; }
    public static new int Max_Damage { get; set; }
  }
}