namespace Ikanustik.Weapons {

  internal class Langaxt : Weapon {

    public Langaxt() {
      Weapon_Name = "Langaxt";
      Weapon_Class = "Axtwaffe";
      Durability = 35;
      Weapon_FullDurability = 35;
      Weapon_Cost = 380;
      Min_Damage = 11;
      Max_Damage = 15;
    }

    public static new string Weapon_Name { get; set; }
    public static new string Weapon_Class { get; set; }
    public static new int Weapon_FullDurability { get; set; }
    public static new int Weapon_Cost { get; set; }
    public static new int Min_Damage { get; set; }
    public static new int Max_Damage { get; set; }
  }
}