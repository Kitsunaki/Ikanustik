namespace Ikanustik.Weapons.Stangen {

  internal class Kriegssense : Waffe {

    public Kriegssense() {
      Name = "Kriegssense";
      Waffengattung = Waffengattungen.Stangen;
      Durability = 68;
      FullDurability = 68;
      Cost = 2100;
      MinDamage = 14;
      MaxDamage = 33;
    }
  }
}