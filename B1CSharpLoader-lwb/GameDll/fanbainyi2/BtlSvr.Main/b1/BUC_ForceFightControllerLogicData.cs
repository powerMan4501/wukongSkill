using System.Collections.Generic;

namespace b1;

internal class BUC_ForceFightControllerLogicData : b1.IBUC_ForceFightControllerLogicData
{
	public List<BGUCharacterCS> UnitsEnteredArea;

	public Dictionary<string, FForceFightUnitGroupConfig> PendingSpawnUnitRequests;

	public List<FForceFightUnitGroupConfig> ForceFightControlConfig { get; set; }

	public BUC_ForceFightControllerLogicData()
	{
		ForceFightControlConfig = new List<FForceFightUnitGroupConfig>();
		UnitsEnteredArea = new List<BGUCharacterCS>();
		PendingSpawnUnitRequests = new Dictionary<string, FForceFightUnitGroupConfig>();
	}
}
