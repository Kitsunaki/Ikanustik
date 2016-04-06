namespace Ikanustik.Weapons.Axt {

  internal class Holzbeil : Weapon {

    public Holzbeil() {
      Name = "Holzbeil";
      Class = WeaponClass.Axt;
      Durability = 11;
      FullDurability = 11;
      Cost = 40;
      MinDamage = 5;
      MaxDamage = 8;
    }
  }
}