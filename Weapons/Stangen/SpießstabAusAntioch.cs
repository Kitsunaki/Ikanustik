namespace Ikanustik.Weapons.Stangen {

  internal class SpießstabAusAntioch : Weapon {

    public SpießstabAusAntioch() {
      Name = "Spießstab aus Antioch";
      Class = WeaponClass.Stangen | WeaponClass.Artefakt;
      Durability = 85;
      FullDurability = 85;
      Cost = 4400;
      MinDamage = 18;
      MaxDamage = 45;
    }
  }
}