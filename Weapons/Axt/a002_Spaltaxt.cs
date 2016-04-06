namespace Ikanustik.Weapons {

  internal class Spaltaxt : Weapon {

    public Spaltaxt() {
      Weapon_Name = "Spaltaxt";
      Weapon_Class = "Axtwaffe";
      Durability = 25;
      Weapon_FullDurability = 25;
      Weapon_Cost = 180;
      Min_Damage = 9;
      Max_Damage = 12;
    }

    public static new string Weapon_Name { get; set; }
    public static new string Weapon_Class { get; set; }
    public static new int Weapon_FullDurability { get; set; }
    public static new int Weapon_Cost { get; set; }
    public static new int Min_Damage { get; set; }
    public static new int Max_Damage { get; set; }
  }
}