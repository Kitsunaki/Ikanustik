namespace Ikanustik.Weapons {

  internal class Prunksichel : Weapon {

    public Prunksichel() {
      Weapon_Name = "Prunksichel";
      Weapon_Class = "Axtwaffe";
      Weapon_Durability = 32;
      Weapon_FullDurability = 32;
      Weapon_Cost = 950;
      Min_Damage = 21;
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