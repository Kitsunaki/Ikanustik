namespace Ikanustik.Weapons.Stangen {

  internal class Dreizack : Waffe {

    public Dreizack() {
      Name = "Dreizack";
      Waffengattung = Waffengattungen.Stangen;
      Durability = 30;
      FullDurability = 30;
      Cost = 520;
      MinDamage = 8;
      MaxDamage = 21;
    }
  }
}