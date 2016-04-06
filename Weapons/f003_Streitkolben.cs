namespace Ikanustik.Weapons {

  internal class Streitkolben : Weapon {

    public Streitkolben() {
      Weapon_Name = "Streitkolben";
      Weapon_Class = "Flegelwaffe";
      Weapon_Durability = 90;
      Weapon_Durability = 90;
      Weapon_Cost = 110;
      Min_Damage = 5;
      Max_Damage = 10;
    }

    public static new string Weapon_Name { get; set; }
    public static new string Weapon_Class { get; set; }
    public static new int Weapon_FullDurability { get; set; }
    public static new int Weapon_Cost { get; set; }
    public static new int Min_Damage { get; set; }
    public static new int Max_Damage { get; set; }
  }
}