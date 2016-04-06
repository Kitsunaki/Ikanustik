namespace Ikanustik.Weapons {

  internal class Rasiertalon : Weapon {

    public Rasiertalon() {
      Weapon_Name = "Rasierklingentalon";
      Weapon_Class = "Axtwaffe";
      Durability = 28;
      Weapon_FullDurability = 28;
      Weapon_Cost = 590;
      Min_Damage = 16;
      Max_Damage = 20;
    }

    public static new string Weapon_Name { get; set; }
    public static new string Weapon_Class { get; set; }
    public static new int Weapon_FullDurability { get; set; }
    public static new int Weapon_Cost { get; set; }
    public static new int Min_Damage { get; set; }
    public static new int Max_Damage { get; set; }
  }
}