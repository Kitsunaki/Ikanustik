namespace Ikanustik.Weapons {

  internal class Bardike : Weapon {

    public Bardike() {
      Weapon_Name = "Bardike";
      Weapon_Class = "Stangenwaffe";
      Durability = 45;
      Weapon_FullDurability = 45;
      Weapon_Cost = 800;
      Min_Damage = 10;
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