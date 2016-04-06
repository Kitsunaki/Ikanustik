namespace Ikanustik.Weapons.Stangen {

  internal class Bardike : Weapon {

    public Bardike() {
      Name = "Bardike";
      Class = WeaponClass.Stangen;
      Durability = 45;
      FullDurability = 45;
      Cost = 800;
      MinDamage = 10;
      MaxDamage = 25;
    }
  }
}