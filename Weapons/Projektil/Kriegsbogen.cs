namespace Ikanustik.Weapons.Projektil {

  internal class Kriegsbogen : Waffe {

    public Kriegsbogen() {
      Name = "Kriegsbogen";
      Waffengattung = Waffengattungen.Projektil;
      Durability = 130;
      FullDurability = 130;
      Cost = 790;
      MinDamage = 3;
      MaxDamage = 20;
    }
  }
}