namespace Ikanustik.Weapons {

  internal class Kolossales_Flamberg : Weapon {

    public Kolossales_Flamberg() {
      Weapon_Name = "Kolossales Flamberg";
      Weapon_Class = "Klingenwaffe";
      Durability = 105;
      Weapon_FullDurability = 105;
      Weapon_Cost = 3500;
      Min_Damage = 26;
      Max_Damage = 35;
    }

    public static new string Weapon_Name { get; set; }
    public static new string Weapon_Class { get; set; }
    public static new int Weapon_FullDurability { get; set; }
    public static new int Weapon_Cost { get; set; }
    public static new int Min_Damage { get; set; }
    public static new int Max_Damage { get; set; }
  }
}