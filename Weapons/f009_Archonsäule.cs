namespace Ikanustik.Weapons {

  internal class Archonsäule : Weapon {

    public Archonsäule() {
      Weapon_Name = "Archonsäule";
      Weapon_Class = "Artefaktwaffe";
      Weapon_Durability = 280;
      Weapon_FullDurability = 280;
      Weapon_Cost = 4420;
      Min_Damage = 24;
      Max_Damage = 30;
    }

    public static new string Weapon_Name { get; set; }
    public static new string Weapon_Class { get; set; }
    public static new int Weapon_FullDurability { get; set; }
    public static new int Weapon_Cost { get; set; }
    public static new int Min_Damage { get; set; }
    public static new int Max_Damage { get; set; }
  }
}