namespace Ikanustik.Weapons {

  internal class Schweres_Bastardschwert : Weapon {

    public Schweres_Bastardschwert() {
      Weapon_Name = "Schweres Bastardschwert";
      Weapon_Class = "Klingenwaffe";
      Durability = 98;
      Weapon_FullDurability = 98;
      Weapon_Cost = 1600;
      Min_Damage = 20;
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