namespace Ikanustik.Weapons.Flegel {

  internal class Schmiedehammer : Waffe {

    public Schmiedehammer() {
      Name = "Schmiedehammer";
      Waffengattung = Waffengattungen.Flegel;
      Durability = 60;
      FullDurability = 60;
      Cost = 35;
      MinDamage = 2;
      MaxDamage = 5;
    }
  }
}