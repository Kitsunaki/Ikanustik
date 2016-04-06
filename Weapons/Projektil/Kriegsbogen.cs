namespace Ikanustik.Weapons {

  internal class Kriegsbogen : Weapon {

    public Kriegsbogen() {
      Name = "Kriegsbogen";
      Class = WeaponClass.Projektil;
      Durability = 130;
      FullDurability = 130;
      Cost = 790;
      MinDamage = 3;
      MaxDamage = 20;
    }
  }
}