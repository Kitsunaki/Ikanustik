using System;

[Flags]
internal enum WeaponClass {
  NONE = 0,
  Kraft = 1,
  Axt = 2,
  Artefakt = 4,
  Flegel = 8,
  Klingen = 16,
  Projektil = 32,
  Stangen = 64
}