namespace Ikanustik.Weapons.Klingen {

  internal class Claymore : Weapon {

    public Claymore() {
      Name = "Claymore";
      Class = WeaponClass.Klingen;
      Durability = 83;
      FullDurability = 83;
      Cost = 900;
      MinDamage = 15;
      MaxDamage = 22;
    }
  }
}