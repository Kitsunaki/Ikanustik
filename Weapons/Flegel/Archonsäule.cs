namespace Ikanustik.Weapons.Flegel {

  internal class Archonsäule : Waffe {

    public Archonsäule() {
      Name = "Archonsäule";
      Waffengattung = Waffengattungen.Flegel | Waffengattungen.Artefakt;
      Durability = 280;
      FullDurability = 280;
      Cost = 4420;
      MinDamage = 24;
      MaxDamage = 30;
    }
  }
}