namespace b1;

public class BUC_ProceduralMapGeneratorData : b1.IBUC_ProceduralMapGeneratorData
{
	public MapProceduralInfo MapInfo;

	public int GlobalCharacterSpawnConfigID;

	public MapProceduralInfo GetMapInfo()
	{
		return MapInfo;
	}

	public int GetCharacterSpawnConfigID()
	{
		return GlobalCharacterSpawnConfigID;
	}
}
