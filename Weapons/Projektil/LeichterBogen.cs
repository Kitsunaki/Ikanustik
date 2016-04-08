namespace Ikanustik.Weapons.Projektil {

  internal class LeichterBogen : Waffe {

    public LeichterBogen() {
      Name = "Leichter Bogen";
      Waffengattung = Waffengattungen.Projektil;
      Durability = 30;
      FullDurability = 30;
      Cost = 25;
      MinDamage = 1;
      MaxDamage = 4;
    }
  }
}