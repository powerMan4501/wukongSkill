using System;
using b1.ECS;
using GUR.Runtime;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_GuidData : IBUC_GuidData, ICloneable, IPersistentECSData
{
	public FGameplayTag UnitFixedGuid { get; set; }

	public FGameplayTag UnitFixedGuidForGroup { get; set; }

	[GSGameDataSnapShot]
	public string UnitRandomGuid { get; set; }

	public void CopyBPDataToData(FUnitGuidData Data)
	{
		UnitFixedGuid = Data.GameplayTagGuid;
		UnitFixedGuidForGroup = Data.GameplayTagGuidForGroup;
	}

	public string GetFinalGuid()
	{
		return BGUFuncLibSceneObj.BGUGetFinalGuid(UnitFixedGuid, UnitRandomGuid);
	}

	public EUnitGuidType GetGuidType()
	{
		if (GameplayTagExtension.IsValid(UnitFixedGuid))
		{
			return EUnitGuidType.Fixed;
		}
		return EUnitGuidType.Random;
	}

	public void CopyUnitFixedGuidFromOther(BUC_GuidData other)
	{
		UnitFixedGuid = other.UnitFixedGuid;
		UnitFixedGuidForGroup = other.UnitFixedGuidForGroup;
	}

	public object Clone()
	{
		return new BUC_GuidData
		{
			UnitFixedGuid = UnitFixedGuid,
			UnitFixedGuidForGroup = UnitFixedGuidForGroup,
			UnitRandomGuid = UnitRandomGuid
		};
	}
}
