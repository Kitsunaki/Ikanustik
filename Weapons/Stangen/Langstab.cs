namespace Ikanustik.Weapons.Stangen {

  internal class Langstab : Waffe {

    public Langstab() {
      Name = "Langstab";
      Waffengattung = Waffengattungen.Stangen;
      Durability = 5;
      FullDurability = 5;
      Cost = 30;
      MinDamage = 2;
      MaxDamage = 9;
    }
  }
}