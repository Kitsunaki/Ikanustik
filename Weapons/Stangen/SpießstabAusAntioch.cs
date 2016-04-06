namespace Ikanustik.Weapons.Stangen {

  internal class SpießstabAusAntioch : Waffe {

    public SpießstabAusAntioch() {
      Name = "Spießstab aus Antioch";
      Waffengattung = Waffengattung.Stangen | Waffengattung.Artefakt;
      Durability = 85;
      FullDurability = 85;
      Cost = 4400;
      MinDamage = 18;
      MaxDamage = 45;
    }
  }
}