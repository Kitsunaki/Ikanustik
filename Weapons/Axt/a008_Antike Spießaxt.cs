namespace Ikanustik.Weapons {

  internal class Antike_Spießaxt : Weapon {

    public Antike_Spießaxt() {
      Weapon_Name = "Antike Spießaxt";
      Weapon_Class = "Axtwaffe";
      Durability = 76;
      Weapon_FullDurability = 76;
      Weapon_Cost = 4800;
      Min_Damage = 38;
      Max_Damage = 46;
    }

    public static new string Weapon_Name { get; set; }
    public static new string Weapon_Class { get; set; }
    public static new int Weapon_FullDurability { get; set; }
    public static new int Weapon_Cost { get; set; }
    public static new int Min_Damage { get; set; }
    public static new int Max_Damage { get; set; }
  }
}