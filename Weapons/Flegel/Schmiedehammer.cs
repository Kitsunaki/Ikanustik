namespace Ikanustik.Weapons.Flegel {

  internal class Schmiedehammer : Weapon {

    public Schmiedehammer() {
      Name = "Schmiedehammer";
      Class = WeaponClass.Flegel;
      Durability = 60;
      FullDurability = 60;
      Cost = 35;
      MinDamage = 2;
      MaxDamage = 5;
    }
  }
}