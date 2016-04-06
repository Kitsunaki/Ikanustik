namespace Ikanustik.Weapons {

  internal class Überschwere_Armbrust : Weapon {

    public Überschwere_Armbrust() {
      Weapon_Name = "Überschwere Armbrust";
      Weapon_Class = "Projektilwaffe";
      Weapon_Durability = 185;
      Weapon_FullDurability = 185;
      Weapon_Cost = 1250;
      Min_Damage = 3;
      Max_Damage = 24;
    }

    public static new string Weapon_Name { get; set; }
    public static new string Weapon_Class { get; set; }
    public static new int Weapon_FullDurability { get; set; }
    public static new int Weapon_Cost { get; set; }
    public static new int Min_Damage { get; set; }
    public static new int Max_Damage { get; set; }
  }
}