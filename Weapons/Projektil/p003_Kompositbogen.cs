namespace Ikanustik.Weapons {

  internal class Kompositbogen : Weapon {

    public Kompositbogen() {
      Name = "Kompositbogen";
      Class = WeaponClass.Projektil;
      Durability = 60;
      FullDurability = 60;
      Cost = 300;
      MinDamage = 2;
      MaxDamage = 12;
    }
  }
}