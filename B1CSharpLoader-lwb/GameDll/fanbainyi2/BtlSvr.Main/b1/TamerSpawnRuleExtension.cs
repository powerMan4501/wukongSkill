namespace b1;

public static class TamerSpawnRuleExtension
{
	public static ETamerSpawnRule AddSpawnRuleFlag(this ref ETamerSpawnRule SpawnRuleFlags, ETamerSpawnRule InSpawnRule)
	{
		SpawnRuleFlags |= InSpawnRule;
		return SpawnRuleFlags;
	}

	public static ETamerSpawnRule RemoveSpawnRuleFlag(this ref ETamerSpawnRule SpawnRuleFlags, ETamerSpawnRule InSpawnRule)
	{
		SpawnRuleFlags &= ~InSpawnRule;
		return SpawnRuleFlags;
	}

	public static bool HasSpawnRuleFlag(this ETamerSpawnRule SpawnRuleFlags, ETamerSpawnRule InSpawnRule)
	{
		return (SpawnRuleFlags & InSpawnRule) == InSpawnRule;
	}
}
