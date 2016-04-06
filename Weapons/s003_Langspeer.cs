namespace Ikanustik.Weapons {

  internal class Langspeer : Weapon {

    public Langspeer() {
      Weapon_Name = "Langspeer";
      Weapon_Class = "Stangenwaffe";
      Weapon_Durability = 17;
      Weapon_FullDurability = 17;
      Weapon_Cost = 350;
      Min_Damage = 5;
      Max_Damage = 15;
    }

    public static new string Weapon_Name { get; set; }
    public static new string Weapon_Class { get; set; }
    public static new int Weapon_FullDurability { get; set; }
    public static new int Weapon_Cost { get; set; }
    public static new int Min_Damage { get; set; }
    public static new int Max_Damage { get; set; }
  }
}