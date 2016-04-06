namespace Ikanustik.Weapons.Flegel {
  internal class Archonsäule : Weapon {
    public Archonsäule() {
      Name = "Archonsäule";
      Class = WeaponClass.Flegel | WeaponClass.Artefakt;
      Durability = 280;
      FullDurability = 280;
      Cost = 4420;
      MinDamage = 24;
      MaxDamage = 30;
    }
  }
}