using System;

namespace b1;

[Flags]
public enum ETamerSpawnRule
{
	Normal = 0,
	NeverSpawn = 1,
	AlwaysSpawn = 2,
	OnlySpawn = 4,
	BlockingSpawn = 8
}
