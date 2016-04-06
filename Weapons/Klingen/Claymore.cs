namespace Ikanustik.Weapons.Klingen {

  internal class Claymore : Waffe {

    public Claymore() {
      Name = "Claymore";
      Waffengattung = Waffengattung.Klingen;
      Durability = 83;
      FullDurability = 83;
      Cost = 900;
      MinDamage = 15;
      MaxDamage = 22;
    }
  }
}