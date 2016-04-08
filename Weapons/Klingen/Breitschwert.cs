namespace Ikanustik.Weapons.Klingen {

  internal class Breitschwert : Waffe {

    public Breitschwert() {
      Name = "Breitschwert";
      Waffengattung = Waffengattungen.Klingen;
      Durability = 55;
      FullDurability = 55;
      Cost = 400;
      MinDamage = 11;
      MaxDamage = 16;
    }
  }
}