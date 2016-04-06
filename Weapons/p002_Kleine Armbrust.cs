namespace Ikanustik.Weapons {

  internal class Kleine_Armbrust : Weapon {

    public Kleine_Armbrust() {
      Weapon_Name = "Kleine Armbrust";
      Weapon_Class = "Projektilwaffe";
      Weapon_Durability = 50;
      Weapon_FullDurability = 50;
      Weapon_Cost = 120;
      Min_Damage = 2;
      Max_Damage = 8;
    }

    public static new string Weapon_Name { get; set; }
    public static new string Weapon_Class { get; set; }
    public static new int Weapon_FullDurability { get; set; }
    public static new int Weapon_Cost { get; set; }
    public static new int Min_Damage { get; set; }
    public static new int Max_Damage { get; set; }
  }
}