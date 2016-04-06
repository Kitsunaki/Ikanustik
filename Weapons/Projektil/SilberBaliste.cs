namespace Ikanustik.Weapons {

  internal class SilberBaliste : Weapon {

    public SilberBaliste() {
      Name = "Silber-Balliste";
      Class = WeaponClass.Projektil;
      Durability = 280;
      FullDurability = 280;
      Cost = 2250;
      MinDamage = 4;
      MaxDamage = 34;
    }
  }
}