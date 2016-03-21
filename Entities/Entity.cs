namespace Ikanustik.Entities {

  internal abstract class Entity {
    public string Name { get; set; }
    public double Health { get; set; }
    public double HealthPool { get; set; }
    public double Damage { get; set; }
    public double Regeneration { get; set; }

    public Entity() {
      Name = "Leer";
      Health = 10.0;
      HealthPool = 10.0;
      Damage = 1;
      Regeneration = 1;
    }

    public void Enemy_Healing() {
      Health += Regeneration;
    }
  }
}