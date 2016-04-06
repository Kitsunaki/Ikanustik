namespace Ikanustik.Weapons {

  internal class EnglischerLangbogen : Weapon {

    public EnglischerLangbogen() {
      Name = "Englischer Langbogen";
      Class = WeaponClass.Projektil;
      Durability = 90;
      FullDurability = 90;
      Cost = 520;
      MinDamage = 3;
      MaxDamage = 18;
    }
  }
}