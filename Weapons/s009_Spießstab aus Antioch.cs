namespace Ikanustik.Weapons {

  internal class Spießstab_aus_Antioch : Weapon {

    public Spießstab_aus_Antioch() {
      Weapon_Name = "Spießstab aus Antioch";
      Weapon_Class = "Artefaktwaffe";
      Weapon_Durability = 85;
      Weapon_FullDurability = 85;
      Weapon_Cost = 4400;
      Min_Damage = 18;
      Max_Damage = 45;
    }

    public static new string Weapon_Name { get; set; }
    public static new string Weapon_Class { get; set; }
    public static new int Weapon_FullDurability { get; set; }
    public static new int Weapon_Cost { get; set; }
    public static new int Min_Damage { get; set; }
    public static new int Max_Damage { get; set; }
  }
}