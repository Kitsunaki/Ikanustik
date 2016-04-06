namespace Ikanustik.Weapons {

  internal class Krismesser : Weapon {

    public Krismesser() {
      Weapon_Name = "Krismesser";
      Weapon_Class = "Klingenwaffe";
      Durability = 15;
      Weapon_FullDurability = 15;
      Weapon_Cost = 35;
      Min_Damage = 2;
      Max_Damage = 5;
    }

    public static new string Weapon_Name { get; set; }
    public static new string Weapon_Class { get; set; }
    public static new int Weapon_FullDurability { get; set; }
    public static new int Weapon_Cost { get; set; }
    public static new int Min_Damage { get; set; }
    public static new int Max_Damage { get; set; }
  }
}