namespace Ikanustik.Weapons {

  internal class Gleve : Weapon {

    public Gleve() {
      Weapon_Name = "Gleve";
      Weapon_Class = "Stangenwaffe";
      Weapon_Durability = 11;
      Weapon_FullDurability = 11;
      Weapon_Cost = 150;
      Min_Damage = 3;
      Max_Damage = 13;
    }

    public static new string Weapon_Name { get; set; }
    public static new string Weapon_Class { get; set; }
    public static new int Weapon_FullDurability { get; set; }
    public static new int Weapon_Cost { get; set; }
    public static new int Min_Damage { get; set; }
    public static new int Max_Damage { get; set; }
  }
}