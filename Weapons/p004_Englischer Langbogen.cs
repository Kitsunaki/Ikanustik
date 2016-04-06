namespace Ikanustik.Weapons {

  internal class Englischer_Langbogen : Weapon {

    public Englischer_Langbogen() {
      Weapon_Name = "Englischer Langbogen";
      Weapon_Class = "Projektilwaffe";
      Weapon_Durability = 90;
      Weapon_FullDurability = 90;
      Weapon_Cost = 520;
      Min_Damage = 3;
      Max_Damage = 18;
    }

    public static new string Weapon_Name { get; set; }
    public static new string Weapon_Class { get; set; }
    public static new int Weapon_FullDurability { get; set; }
    public static new int Weapon_Cost { get; set; }
    public static new int Min_Damage { get; set; }
    public static new int Max_Damage { get; set; }
  }
}