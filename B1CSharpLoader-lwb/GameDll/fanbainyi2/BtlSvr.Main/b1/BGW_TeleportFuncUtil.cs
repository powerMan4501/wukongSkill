using System.Collections.Generic;
using BtlB1;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public static class BGW_TeleportFuncUtil
{
	public static bool CheckAndTransByRebirthPoint(int RebirthPointId, APlayerController PlayerController, out int TargetResId)
	{
		FUStRebirthPointDesc rebirthPointDesc = BGW_GameDB.GetRebirthPointDesc(RebirthPointId);
		TargetResId = 0;
		if (rebirthPointDesc != null && rebirthPointDesc.TransId > 0)
		{
			bool flag = true;
			if (rebirthPointDesc.DisableTransTaskId > 0)
			{
				IBPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(PlayerController);
				if (BGUFuncLibForTaskAndNPCTest.GetExistTaskStageState(rebirthPointDesc.DisableTransTaskId, readOnlyData.RoleData.RoleCs.Task.QuestList, out var Result) && Result == QuestStage.Finished)
				{
					flag = false;
				}
			}
			if (flag)
			{
				TargetResId = rebirthPointDesc.TransId;
				return true;
			}
		}
		return false;
	}

	public static void SetLevelsStateByLevelConfig(UObject GameInst)
	{
		IBIC_BossRushBattleData gameInstanceReadonlyData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_BossRushBattleData, BIC_BossRushBattleData>(GameInst);
		if (gameInstanceReadonlyData == null)
		{
			return;
		}
		foreach (KeyValuePair<string, EBossRushLevelLoadState> item in gameInstanceReadonlyData.GetFinalLevelLoadConfig())
		{
			EGSLevelState inTargetState = EGSLevelState.Unloaded;
			bool bKeywordMatch = false;
			switch (item.Value)
			{
			case EBossRushLevelLoadState.Auto:
				inTargetState = EGSLevelState.Auto;
				break;
			case EBossRushLevelLoadState.Load:
				inTargetState = EGSLevelState.LoadedVisible;
				break;
			case EBossRushLevelLoadState.Unload:
				inTargetState = EGSLevelState.Unloaded;
				break;
			case EBossRushLevelLoadState.AutoWithKeywords:
				bKeywordMatch = true;
				inTargetState = EGSLevelState.Auto;
				break;
			case EBossRushLevelLoadState.LoadWithKeywords:
				bKeywordMatch = true;
				inTargetState = EGSLevelState.LoadedVisible;
				break;
			case EBossRushLevelLoadState.UnloadWithKeywords:
				bKeywordMatch = true;
				inTargetState = EGSLevelState.Unloaded;
				break;
			}
			UBGUWCStreamingFuncLib.SetLevelsState(GameInst, item.Key, inTargetState, 99, bKeywordMatch);
		}
	}
}
