namespace Ikanustik.Weapons.Klingen {

  internal class Dolch : Waffe {

    public Dolch() {
      Name = "Dolch";
      Waffengattung = Waffengattungen.Klingen;
      Durability = 10;
      FullDurability = 10;
      Cost = 0;
      MinDamage = 1;
      MaxDamage = 3;
    }
  }
}