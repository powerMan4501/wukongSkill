namespace b1;

public class TamerCharacterNameAllocator
{
	public string GUID;

	public int AllocIdx;

	public bool NeverSpawned { get; protected set; } = true;

	public void Realloc()
	{
		AllocIdx++;
	}

	public string GetCurrentName()
	{
		return $"{GUID}@_{AllocIdx}";
	}

	public string GetCurrentNameForSpawn()
	{
		NeverSpawned = false;
		return GetCurrentName();
	}
}
