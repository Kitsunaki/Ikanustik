namespace Ikanustik.Weapons.Axt {

  internal class Holzbeil : Waffe {

    public Holzbeil() {
      Name = "Holzbeil";
      Waffengattung = Waffengattungen.Axt;
      Durability = 11;
      FullDurability = 11;
      Cost = 40;
      MinDamage = 5;
      MaxDamage = 8;
    }
  }
}