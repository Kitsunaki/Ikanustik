namespace Ikanustik.Weapons.Projektil {

  internal class SilberBaliste : Waffe {

    public SilberBaliste() {
      Name = "Silber-Balliste";
      Waffengattung = Waffengattung.Projektil;
      Durability = 280;
      FullDurability = 280;
      Cost = 2250;
      MinDamage = 4;
      MaxDamage = 34;
    }
  }
}