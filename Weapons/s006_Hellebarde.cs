namespace Ikanustik.Weapons {

  internal class Hellebarde : Weapon {

    public Hellebarde() {
      Weapon_Name = "Hellebarde";
      Weapon_Class = "Stangenwaffe";
      Weapon_Durability = 59;
      Weapon_FullDurability = 59;
      Weapon_Cost = 1320;
      Min_Damage = 12;
      Max_Damage = 28;
    }

    public static new string Weapon_Name { get; set; }
    public static new string Weapon_Class { get; set; }
    public static new int Weapon_FullDurability { get; set; }
    public static new int Weapon_Cost { get; set; }
    public static new int Min_Damage { get; set; }
    public static new int Max_Damage { get; set; }
  }
}