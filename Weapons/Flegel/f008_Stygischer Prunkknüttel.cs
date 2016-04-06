namespace Ikanustik.Weapons {

  internal class Stygischer_Prunkknüttel : Weapon {

    public Stygischer_Prunkknüttel() {
      Weapon_Name = "Stygischer Prunkknüttel";
      Weapon_Class = "Flegelwaffe";
      Durability = 220;
      Weapon_FullDurability = 220;
      Weapon_Cost = 2520;
      Min_Damage = 19;
      Max_Damage = 25;
    }

    public static new string Weapon_Name { get; set; }
    public static new string Weapon_Class { get; set; }
    public static new int Weapon_FullDurability { get; set; }
    public static new int Weapon_Cost { get; set; }
    public static new int Min_Damage { get; set; }
    public static new int Max_Damage { get; set; }
  }
}