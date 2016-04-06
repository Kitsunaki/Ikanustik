namespace Ikanustik.Weapons.Projektil {

  internal class Balliste : Waffe {

    public Balliste() {
      Name = "Balliste";
      Waffengattung = Waffengattung.Projektil;
      Durability = 250;
      FullDurability = 250;
      Cost = 1800;
      MinDamage = 4;
      MaxDamage = 28;
    }
  }
}