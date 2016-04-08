namespace Ikanustik.Weapons.Klingen {

  internal class Krummsäbel : Waffe {

    public Krummsäbel() {
      Name = "Krummsäbel";
      Waffengattung = Waffengattungen.Klingen;
      Durability = 38;
      FullDurability = 38;
      Cost = 200;
      MinDamage = 8;
      MaxDamage = 12;
    }
  }
}