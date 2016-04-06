namespace Ikanustik.Weapons {

  internal class Schattenkatana : Weapon {

    public Schattenkatana() {
      Weapon_Name = "Schattenstahlkatana";
      Weapon_Class = "Artefaktwaffe";
      Weapon_Durability = 108;
      Weapon_FullDurability = 108;
      Weapon_Cost = 7000;
      Min_Damage = 32;
      Max_Damage = 40;
    }

    public static new string Weapon_Name { get; set; }
    public static new string Weapon_Class { get; set; }
    public static new int Weapon_FullDurability { get; set; }
    public static new int Weapon_Cost { get; set; }
    public static new int Min_Damage { get; set; }
    public static new int Max_Damage { get; set; }
  }
}