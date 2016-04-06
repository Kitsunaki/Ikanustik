namespace Ikanustik.Weapons {

  internal class Walkürendonner : Weapon {

    public Walkürendonner() {
      Weapon_Name = "Walkürendonner";
      Weapon_Class = "Artefaktwaffe";
      Durability = 350;
      Weapon_FullDurability = 350;
      Weapon_Cost = 4000;
      Min_Damage = 5;
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