namespace Ikanustik.Entities {

  internal class Player : Entity {

    public Player() {
      //Grundwerte
      Name = "Leer";
      Score = 0;
      Maxscore = 259;
      Gold = 0;

      //Laune
      Satisfaction = 0;
      Stamina = 4;

      //Leben
      Health = 10;
      HealthPool = 10;

      //Angriff
      Damage = 0;
    }

    public double Score { get; set; }
    public double Maxscore { get; set; }
    public double Satisfaction { get; set; }
    public int Stamina { get; set; }
    public double Gold { get; set; }

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
  }
}