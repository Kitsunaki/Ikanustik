namespace Ikanustik.Weapons.Klingen {

  internal class Kurzschwert : Weapon {

    public Kurzschwert() {
      Name = "Kurzschwert";
      Class = WeaponClass.Klingen;
      Durability = 25;
      FullDurability = 25;
      Cost = 80;
      MinDamage = 4;
      MaxDamage = 8;
    }
  }
}