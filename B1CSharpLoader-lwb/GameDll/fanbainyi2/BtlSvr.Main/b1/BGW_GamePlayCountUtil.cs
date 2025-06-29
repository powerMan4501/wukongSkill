using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public static class BGW_GamePlayCountUtil
{
	public static int GetCurGamePlayCount(UObject Owner)
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner);
		if (firstLocalPlayerController != null)
		{
			IBPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(firstLocalPlayerController);
			if (readOnlyData != null)
			{
				return GetCurGamePlayCount(Owner, readOnlyData);
			}
		}
		return -1;
	}

	public static int GetCurGamePlayCount(UObject Owner, IBPC_PlayerRoleData PlayerRoleData)
	{
		if (PlayerRoleData != null)
		{
			if (DebugConfig.DebugGameCount > 0)
			{
				return DebugConfig.DebugGameCount;
			}
			if (B1Global.GIsBossRushMode)
			{
				IBIC_BossRushData gameInstanceReadonlyData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_BossRushData, BIC_BossRushData>(Owner);
				if (gameInstanceReadonlyData != null)
				{
					int result = 1;
					if (gameInstanceReadonlyData.BossRushType == EBossRushType.Rechallenge)
					{
						switch (gameInstanceReadonlyData.BossRushBattleData.Score)
						{
						case 1:
							result = 1;
							break;
						case 2:
							result = 3;
							break;
						case 3:
							result = 6;
							break;
						}
					}
					else if (gameInstanceReadonlyData.BossRushType == EBossRushType.BossIterations || gameInstanceReadonlyData.BossRushType == EBossRushType.IterationsPractise)
					{
						result = 1;
					}
					return result;
				}
			}
			return PlayerRoleData.GetNewGamePlusCount();
		}
		return -1;
	}
}
