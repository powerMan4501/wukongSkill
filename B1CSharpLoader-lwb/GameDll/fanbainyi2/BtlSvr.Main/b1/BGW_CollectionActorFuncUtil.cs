using System.Collections.Generic;
using ResB1;
using UnrealEngine.Engine;

namespace b1;

public static class BGW_CollectionActorFuncUtil
{
	public static bool CheckTalentActive(AActor InteractActor, string HighLightFXPath)
	{
		if (HighLightFXPath == string.Empty)
		{
			return false;
		}
		IBPC_RoleBaseData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_RoleBaseData, BPC_RoleBaseData>(UGameplayStatics.GetPlayerState(InteractActor, 0));
		if (readOnlyData != null && readOnlyData.TalenList != null)
		{
			foreach (KeyValuePair<int, int> talen in readOnlyData.TalenList)
			{
				int commLogicCfgValue = GameDBRuntime.GetCommLogicCfgValue(CommCfgType.DashenEarsTalentId);
				if (talen.Key == commLogicCfgValue)
				{
					return true;
				}
			}
		}
		return false;
	}
}
