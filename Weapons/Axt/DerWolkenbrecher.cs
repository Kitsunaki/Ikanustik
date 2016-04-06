namespace Ikanustik.Weapons.Axt {

  internal class DerWolkenbrecher : Weapon {

    public DerWolkenbrecher() {
      Name = "Der Wolkenbrecher";
      Class = WeaponClass.Axt | WeaponClass.Artefakt;
      Durability = 80;
      FullDurability = 80;
      Cost = 6200;
      MinDamage = 42;
      MaxDamage = 50;
    }
  }
}