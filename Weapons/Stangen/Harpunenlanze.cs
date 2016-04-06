namespace Ikanustik.Weapons.Stangen {

  internal class Harpunenlanze : Waffe {

    public Harpunenlanze() {
      Name = "Harpunenlanze";
      Waffengattung = Waffengattung.Stangen;
      Durability = 75;
      FullDurability = 75;
      Cost = 2500;
      MinDamage = 16;
      MaxDamage = 38;
    }
  }
}