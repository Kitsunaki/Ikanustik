namespace Ikanustik.Weapons.Projektil {

  internal class KleineArmbrust : Waffe {

    public KleineArmbrust() {
      Name = "Kleine Armbrust";
      Waffengattung = Waffengattungen.Projektil;
      Durability = 50;
      FullDurability = 50;
      Cost = 120;
      MinDamage = 2;
      MaxDamage = 8;
    }
  }
}