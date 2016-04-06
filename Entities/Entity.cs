namespace Ikanustik.Entities {

  internal abstract class Entity {
    public string Name { get; set; }
    public int Health { get; set; }
    public int HealthPool { get; set; }
    public int DamageMin { get; set; }
    public int DamageMax { get; set; }
    public int Regeneration { get; set; }
    public int MinGetGold { get; set; }
    public int MaxGetGold { get; set; }
    public int ExpMin { get; set; }
    public int ExpMax { get; set; }
    public int Armor { get; set; }

    public Entity() {
      Name = "Leer";
      Health = 10;
      HealthPool = 10;
      DamageMin = 0;
      DamageMax = 0;
      Regeneration = 1;
      MinGetGold = 1;
      MaxGetGold = 1;
      ExpMin = 1;
      ExpMax = 2;
      Armor = 1;
    }

    public abstract void Clash(Player player);
  }
}