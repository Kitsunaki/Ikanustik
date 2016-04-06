namespace Ikanustik.Weapons.Klingen {

  internal class Dolch : Weapon {

    public Dolch() {
      Name = "Dolch";
      Class = WeaponClass.Klingen;
      Durability = 10;
      FullDurability = 10;
      Cost = 0;
      MinDamage = 1;
      MaxDamage = 3;
    }
  }
}