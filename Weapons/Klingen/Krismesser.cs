namespace Ikanustik.Weapons.Klingen {

  internal class Krismesser : Waffe {

    public Krismesser() {
      Name = "Krismesser";
      Waffengattung = Waffengattung.Klingen;
      Durability = 15;
      FullDurability = 15;
      Cost = 35;
      MinDamage = 2;
      MaxDamage = 5;
    }
  }
}