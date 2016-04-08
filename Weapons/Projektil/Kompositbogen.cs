namespace Ikanustik.Weapons.Projektil {

  internal class Kompositbogen : Waffe {

    public Kompositbogen() {
      Name = "Kompositbogen";
      Waffengattung = Waffengattungen.Projektil;
      Durability = 60;
      FullDurability = 60;
      Cost = 300;
      MinDamage = 2;
      MaxDamage = 12;
    }
  }
}