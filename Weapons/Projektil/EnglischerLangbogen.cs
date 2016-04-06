namespace Ikanustik.Weapons.Projektil {

  internal class EnglischerLangbogen : Waffe {

    public EnglischerLangbogen() {
      Name = "Englischer Langbogen";
      Waffengattung = Waffengattung.Projektil;
      Durability = 90;
      FullDurability = 90;
      Cost = 520;
      MinDamage = 3;
      MaxDamage = 18;
    }
  }
}