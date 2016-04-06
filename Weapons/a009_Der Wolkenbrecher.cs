namespace Ikanustik.Weapons {

  internal class Der_Wolkenbrecher : Weapon {

    public Der_Wolkenbrecher() {
      Weapon_Name = "Der Wolkenbrecher";
      Weapon_Class = "Artefaktwaffe";
      Weapon_Durability = 80;
      Weapon_FullDurability = 80;
      Weapon_Cost = 6200;
      Min_Damage = 42;
      Max_Damage = 50;
    }

    public static new string Weapon_Name { get; set; }
    public static new string Weapon_Class { get; set; }
    public static new int Weapon_FullDurability { get; set; }
    public static new int Weapon_Cost { get; set; }
    public static new int Min_Damage { get; set; }
    public static new int Max_Damage { get; set; }
  }
}