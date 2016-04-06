namespace Ikanustik.Weapons {

  internal class Schmiedehammer : Weapon {

    public Schmiedehammer() {
      Weapon_Name = "Schmiedehammer";
      Weapon_Class = "Flegelwaffe";
      Weapon_Durability = 60;
      Weapon_FullDurability = 60;
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