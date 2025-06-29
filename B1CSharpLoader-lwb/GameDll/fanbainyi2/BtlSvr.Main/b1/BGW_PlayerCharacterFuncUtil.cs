using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public static class BGW_PlayerCharacterFuncUtil
{
	public static (int, int) GetLocalPlayerResIdAndExtendID(UObject WorldContext)
	{
		BGUCharacterCS bGUCharacterCS = UGameplayStatics.GetPlayerCharacter(WorldContext, 0) as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			return (bGUCharacterCS.GetResID(), bGUCharacterCS.GetFinalBattleInfoExtendID());
		}
		int commLogicCfgValue = GameDBRuntime.GetCommLogicCfgValue(CommCfgType.PlayerDefaultResid);
		return (commLogicCfgValue, commLogicCfgValue * 100 + 1);
	}
}
