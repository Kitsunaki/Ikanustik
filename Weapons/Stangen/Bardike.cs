namespace Ikanustik.Weapons.Stangen {

  internal class Bardike : Waffe {

    public Bardike() {
      Name = "Bardike";
      Waffengattung = Waffengattungen.Stangen;
      Durability = 45;
      FullDurability = 45;
      Cost = 800;
      MinDamage = 10;
      MaxDamage = 25;
    }
  }
}