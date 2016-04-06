namespace Ikanustik.Weapons.Projektil {

  internal class Walkürendonner : Weapon {

    public Walkürendonner() {
      Name = "Walkürendonner";
      Class = WeaponClass.Projektil | WeaponClass.Artefakt;
      Durability = 350;
      FullDurability = 350;
      Cost = 4000;
      MinDamage = 5;
      MaxDamage = 38;
    }
  }
}