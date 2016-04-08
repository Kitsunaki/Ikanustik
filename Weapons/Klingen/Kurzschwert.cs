namespace Ikanustik.Weapons.Klingen {

  internal class Kurzschwert : Waffe {

    public Kurzschwert() {
      Name = "Kurzschwert";
      Waffengattung = Waffengattungen.Klingen;
      Durability = 25;
      FullDurability = 25;
      Cost = 80;
      MinDamage = 4;
      MaxDamage = 8;
    }
  }
}