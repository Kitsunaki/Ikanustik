﻿namespace Ikanustik.Weapons.Projektil {

  internal class Walkürendonner : Waffe {

    public Walkürendonner() {
      Name = "Walkürendonner";
      Waffengattung = Waffengattungen.Projektil | Waffengattungen.Artefakt;
      Durability = 350;
      FullDurability = 350;
      Cost = 4000;
      MinDamage = 5;
      MaxDamage = 38;
    }
  }
}