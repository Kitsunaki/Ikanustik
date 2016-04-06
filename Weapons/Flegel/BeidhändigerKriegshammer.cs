namespace Ikanustik.Weapons.Flegel {

  internal class BeidhändigerKriegshammer : Waffe {

    public BeidhändigerKriegshammer() {
      Name = "Beidhändiger Kriegshammer";
      Waffengattung = Waffengattung.Flegel;
      Durability = 180;
      FullDurability = 180;
      Cost = 1050;
      MinDamage = 14;
      MaxDamage = 22;
    }
  }
}