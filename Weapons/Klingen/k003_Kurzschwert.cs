﻿namespace Ikanustik.Weapons {

  internal class Kurzschwert : Weapon {

    public Kurzschwert() {
      Weapon_Name = "Kurzschwert";
      Weapon_Class = "Klingenwaffe";
      Durability = 25;
      Weapon_FullDurability = 25;
      Weapon_Cost = 80;
      Min_Damage = 4;
      Max_Damage = 8;
    }

    public static new string Weapon_Name { get; set; }
    public static new string Weapon_Class { get; set; }
    public static new int Weapon_FullDurability { get; set; }
    public static new int Weapon_Cost { get; set; }
    public static new int Min_Damage { get; set; }
    public static new int Max_Damage { get; set; }
  }
}