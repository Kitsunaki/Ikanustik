namespace Ikanustik.Weapons {

  internal class Doppelaxt : Weapon {

    public Doppelaxt() {
      Weapon_Name = "Schwere Doppelaxt";
      Weapon_Class = "Axtwaffe";
      Weapon_Durability = 60;
      Weapon_FullDurability = 60;
      Weapon_Cost = 1500;
      Min_Damage = 28;
      Max_Damage = 33;
    }

    public static new string Weapon_Name { get; set; }
    public static new string Weapon_Class { get; set; }
    public static new int Weapon_FullDurability { get; set; }
    public static new int Weapon_Cost { get; set; }
    public static new int Min_Damage { get; set; }
    public static new int Max_Damage { get; set; }
  }
}