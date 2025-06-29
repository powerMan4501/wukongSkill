using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1;

public class BUC_SuperArmorLevelMappingData : IBUC_SuperArmorLevelMappingData, IPersistentECSData
{
	public Dictionary<string, List<GSSuperArmorMappingTargetInfo>> SuperArmorLevelMapping { get; set; }

	public BUC_SuperArmorLevelMappingData()
	{
		SuperArmorLevelMapping = new Dictionary<string, List<GSSuperArmorMappingTargetInfo>>();
	}

	public float GetSuperArmorLevelValue(string SuperArmorLevelName, string BlameInfo, string ToBlame, AActor Caster)
	{
		if (BGUFunctionLibraryCS.BGUGetSuperArmorValueByLevel(SuperArmorLevelName, BlameInfo, ToBlame, out var SuperArmorValue, Caster))
		{
			return SuperArmorValue;
		}
		return 0f;
	}

	public float GetSuperArmorValue(float SuperArmorValue, string BlameInfo, string ToBlame)
	{
		return SuperArmorValue;
	}
}
