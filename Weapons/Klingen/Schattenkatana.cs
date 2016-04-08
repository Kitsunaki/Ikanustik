namespace Ikanustik.Weapons.Klingen {

  internal class Schattenkatana : Waffe {

    public Schattenkatana() {
      Name = "Schattenstahlkatana";
      Waffengattung = Waffengattungen.Klingen | Waffengattungen.Artefakt;
      Durability = 108;
      FullDurability = 108;
      Cost = 7000;
      MinDamage = 32;
      MaxDamage = 40;
    }
  }
}