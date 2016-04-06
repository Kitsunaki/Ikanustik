namespace Ikanustik.Weapons.Flegel {

  internal class Kriegsszepter : Waffe {

    public Kriegsszepter() {
      Name = "Kriegsszepter";
      Waffengattung = Waffengattung.Flegel;
      Durability = 130;
      FullDurability = 130;
      Cost = 440;
      MinDamage = 10;
      MaxDamage = 17;
    }
  }
}