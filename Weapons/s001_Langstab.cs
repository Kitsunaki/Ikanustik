namespace Ikanustik.Weapons {

  internal class Langstab : Weapon {

    public Langstab() {
      Weapon_Name = "Langstab";
      Weapon_Class = "Stangenwaffe";
      Weapon_Durability = 5;
      Weapon_FullDurability = 5;
      Weapon_Cost = 30;
      Min_Damage = 2;
      Max_Damage = 9;
    }

    public static new string Weapon_Name { get; set; }
    public static new string Weapon_Class { get; set; }
    public static new int Weapon_FullDurability { get; set; }
    public static new int Weapon_Cost { get; set; }
    public static new int Min_Damage { get; set; }
    public static new int Max_Damage { get; set; }
  }
}