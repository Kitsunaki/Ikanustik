using System;

namespace Ikanustik.Entities {

  internal class Wendigo : Entity {

    public Wendigo() {
      Health = 30;
      HealthPool = 30;
      Regeneration = 2;
      Name = "Wendigo";
      Damage = 2;
    }

    private static void Clash() {
      Console.WriteLine("Ein Wendigo taucht auf. Eine fleischfressende Bestie mit einem Herz aus Eis. \nAlso so etwas Ähnliches wie eine Stiefmutter.");
    }
  }
}