namespace Ikanustik.Weapons.Stangen {

  internal class Langstab : Weapon {

    public Langstab() {
      Name = "Langstab";
      Class = WeaponClass.Stangen;
      Durability = 5;
      FullDurability = 5;
      Cost = 30;
      MinDamage = 2;
      MaxDamage = 9;
    }
  }
}