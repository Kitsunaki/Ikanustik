namespace Ikanustik.Weapons.Stangen {

  internal class Gleve : Waffe {

    public Gleve() {
      Name = "Gleve";
      Waffengattung = Waffengattungen.Stangen;
      Durability = 11;
      FullDurability = 11;
      Cost = 150;
      MinDamage = 3;
      MaxDamage = 13;
    }
  }
}