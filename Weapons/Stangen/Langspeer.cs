namespace Ikanustik.Weapons.Stangen {

  internal class Langspeer : Waffe {

    public Langspeer() {
      Name = "Langspeer";
      Waffengattung = Waffengattung.Stangen;
      Durability = 17;
      FullDurability = 17;
      Cost = 350;
      MinDamage = 5;
      MaxDamage = 15;
    }
  }
}