namespace Ikanustik.Weapons {

  internal class Höllenschmiedenhammer : Weapon {

    public Höllenschmiedenhammer() {
      Weapon_Name = "Höllenschmiedenhammer";
      Weapon_Class = "Flegelwaffe";
      Durability = 195;
      Weapon_FullDurability = 195;
      Weapon_Cost = 1980;
      Min_Damage = 15;
      Max_Damage = 23;
    }

    public static new string Weapon_Name { get; set; }
    public static new string Weapon_Class { get; set; }
    public static new int Weapon_FullDurability { get; set; }
    public static new int Weapon_Cost { get; set; }
    public static new int Min_Damage { get; set; }
    public static new int Max_Damage { get; set; }
  }
}