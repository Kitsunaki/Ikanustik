namespace Ikanustik.Weapons {

  internal class KleineArmbrust : Weapon {

    public KleineArmbrust() {
      Name = "Kleine Armbrust";
      Class = WeaponClass.Projektil;
      Durability = 50;
      FullDurability = 50;
      Cost = 120;
      MinDamage = 2;
      MaxDamage = 8;
    }
  }
}