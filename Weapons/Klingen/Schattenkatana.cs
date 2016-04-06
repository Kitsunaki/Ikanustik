namespace Ikanustik.Weapons.Klingen {

  internal class Schattenkatana : Weapon {

    public Schattenkatana() {
      Name = "Schattenstahlkatana";
      Class = WeaponClass.Klingen | WeaponClass.Artefakt;
      Durability = 108;
      FullDurability = 108;
      Cost = 7000;
      MinDamage = 32;
      MaxDamage = 40;
    }
  }
}