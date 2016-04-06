namespace Ikanustik.Weapons {

  internal class Dreschflegel : Weapon {

    public Dreschflegel() {
      Weapon_Name = "Dreschflegel";
      Weapon_Class = "Flegelwaffe";
      Weapon_Durability = 35;
      Weapon_Durability = 35;
      Weapon_Cost = 75;
      Min_Damage = 3;
      Max_Damage = 8;
    }

    public static new string Weapon_Name { get; set; }
    public static new string Weapon_Class { get; set; }
    public static new int Weapon_FullDurability { get; set; }
    public static new int Weapon_Cost { get; set; }
    public static new int Min_Damage { get; set; }
    public static new int Max_Damage { get; set; }
  }
}