namespace Ikanustik.Weapons.Axt {

  internal class DerWolkenbrecher : Waffe {

    public DerWolkenbrecher() {
      Name = "Der Wolkenbrecher";
      Waffengattung = Waffengattungen.Axt | Waffengattungen.Artefakt;
      Durability = 80;
      FullDurability = 80;
      Cost = 6200;
      MinDamage = 42;
      MaxDamage = 50;
    }
  }
}