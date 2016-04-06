namespace Ikanustik.Weapons {

  internal class Dreizack : Weapon {

    public Dreizack() {
      Weapon_Name = "Dreizack";
      Weapon_Class = "Stangenwaffe";
      Durability = 30;
      Weapon_FullDurability = 30;
      Weapon_Cost = 520;
      Min_Damage = 8;
      Max_Damage = 21;
    }

    public static new string Weapon_Name { get; set; }
    public static new string Weapon_Class { get; set; }
    public static new int Weapon_FullDurability { get; set; }
    public static new int Weapon_Cost { get; set; }
    public static new int Min_Damage { get; set; }
    public static new int Max_Damage { get; set; }
  }
}