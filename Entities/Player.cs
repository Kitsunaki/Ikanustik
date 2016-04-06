using System;
using Ikanustik.Weapons;

namespace Ikanustik.Entities {

  internal class Player : Entity {

    public Player() {
      //Grundwerte
      Name = "Leer";
      Score = 0;
      Maxscore = 259;
      Gold = 0;
      Skill = 0;

      //Leben
      Health = 10;
      HealthPool = 10;

      //Attribute
      Strengh = 10;
      Resilienz = 1;
      Satisfaction = 0;
      Stamina = 5;

      //Angriff
      Active_Weapon = new Faust();
      Mana = 5;
      ManaPool = 5;
    }

    public double Score { get; set; }
    public double Maxscore { get; set; }
    public double Satisfaction { get; set; }
    public int Stamina { get; set; }
    public double Gold { get; set; }
    public Weapon Active_Weapon;
    public int Strengh { get; set; }
    public int Resilienz { get; set; }
    public double Mana { get; set; }
    public double ManaPool { get; set; }
    public int Skill { get; set; }

    public string GetHealthMessage() {
      return $"Deine Gesundheit beträgt {Health}/{HealthPool} HP";
    }

    public string GetGoldMessage() {
      return $"Du besitzt momentan {Gold} Gold.";
    }

    public string GetMoodMessage() {
      return $"Deine Genugtuung liegt bei {Satisfaction} und deine Ausdauer beträgt {Stamina} Punkte.";
    }

    public override string ToString() {
      return Name;
    }

    public override void Clash(Player player) {
      throw new NotImplementedException();
    }
  }
}