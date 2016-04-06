namespace Ikanustik.Weapons.Klingen {

  internal class Krismesser : Weapon {

    public Krismesser() {
      Name = "Krismesser";
      Class = WeaponClass.Klingen;
      Durability = 15;
      FullDurability = 15;
      Cost = 35;
      MinDamage = 2;
      MaxDamage = 5;
    }
  }
}