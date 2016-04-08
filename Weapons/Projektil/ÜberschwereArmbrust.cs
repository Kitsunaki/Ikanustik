namespace Ikanustik.Weapons.Projektil {

  internal class ÜberschwereArmbrust : Waffe {

    public ÜberschwereArmbrust() {
      Name = "Überschwere Armbrust";
      Waffengattung = Waffengattungen.Projektil;
      Durability = 185;
      FullDurability = 185;
      Cost = 1250;
      MinDamage = 3;
      MaxDamage = 24;
    }
  }
}