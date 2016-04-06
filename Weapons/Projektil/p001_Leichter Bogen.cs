namespace Ikanustik.Weapons {

  internal class Leichter_Bogen : Weapon {

    public Leichter_Bogen() {
      Name = "Leichter Bogen";
      Class = WeaponClass.Projektil;
      Durability = 30;
      FullDurability = 30;
      Cost = 25;
      MinDamage = 1;
      MaxDamage = 4;
    }
  }
}