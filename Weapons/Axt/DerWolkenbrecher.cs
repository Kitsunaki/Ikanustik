namespace Ikanustik.Weapons.Axt {

  internal class DerWolkenbrecher : Waffe {

    public DerWolkenbrecher() {
      Name = "Der Wolkenbrecher";
      Waffengattung = Waffengattung.Axt | Waffengattung.Artefakt;
      Durability = 80;
      FullDurability = 80;
      Cost = 6200;
      MinDamage = 42;
      MaxDamage = 50;
    }
  }
}