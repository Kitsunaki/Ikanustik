namespace Ikanustik.Weapons.Projektil {

  internal class Balliste : Weapon {

    public Balliste() {
      Name = "Balliste";
      Class = WeaponClass.Projektil;
      Durability = 250;
      FullDurability = 250;
      Cost = 1800;
      MinDamage = 4;
      MaxDamage = 28;
    }
  }
}