using System.Collections.Generic;
using ArchiveB1;
using BtlB1;
using BtlShare;
using CommB1;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public static class EffectAttrApi
{
	public static EffectAttrList GetUnitBaseAttrList(int ResId, int BattleInfoExtendID, int NewGamePlusCount, AActor Actor = null)
	{
		EffectAttrDict effectAttrDict = new EffectAttrDict();
		effectAttrDict.AddAttrValue(EBGUAttrFloat.StaminaCostMultiperBase, 1f);
		FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(ResId);
		if (unitCommDesc == null)
		{
			BGW_LogUtil.LogError($"GetUnitCommDesc Failed, ResId:{ResId}");
			return new EffectAttrList();
		}
		FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(BattleInfoExtendID);
		if (unitBattleInfoExtendDesc == null)
		{
			BGW_LogUtil.LogError($"GetUnitBattleInfoExtendDesc Failed, BattleInfoExtendID{BattleInfoExtendID}");
			return new EffectAttrList();
		}
		FUStUnitLevelUpDesc unitLevelUpDesc = BGW_GameDB.GetUnitLevelUpDesc(ResId, BattleInfoExtendID);
		if (unitLevelUpDesc == null)
		{
			BGW_LogUtil.LogError($"GetUnitLevelUpDesc Failed, ResId{ResId}, BattleInfoExtendID{BattleInfoExtendID}");
			return new EffectAttrList();
		}
		UnitAttrHelper.FillUnitCommDescAttrList(effectAttrDict, unitCommDesc, unitBattleInfoExtendDesc);
		UnitAttrHelper.FillUnitLevelUpDescAttrList(effectAttrDict, unitLevelUpDesc);
		FUStPlayerCommDesc playerCommDesc = BGW_GameDB.GetPlayerCommDesc(ResId, null);
		if (playerCommDesc != null)
		{
			UnitAttrHelper.FillPlayerCommDescAttrList(effectAttrDict, playerCommDesc);
		}
		NewGamePlusDesc newGamePlusDesc = GameDBRuntime.GetNewGamePlusDesc(unitBattleInfoExtendDesc.LevelNumericalStrength, unitBattleInfoExtendDesc.QualityType, NewGamePlusCount);
		if (newGamePlusDesc != null)
		{
			UnitAttrHelper.FillNewGamePlusAttrList(effectAttrDict, newGamePlusDesc);
		}
		BGUCharacterCS bGUCharacterCS = Actor as BGUCharacterCS;
		if (B1Global.GIsBossRushMode && bGUCharacterCS != null && !bGUCharacterCS.IsNullOrDestroyed())
		{
			if (bGUCharacterCS.IsPlayerControlled())
			{
				IBIC_BossRushData gameInstanceReadonlyData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_BossRushData, BIC_BossRushData>(bGUCharacterCS);
				if (gameInstanceReadonlyData != null && (gameInstanceReadonlyData.BossRushType == EBossRushType.BossIterations || gameInstanceReadonlyData.BossRushType == EBossRushType.IterationsPractise))
				{
					foreach (int debuff in gameInstanceReadonlyData.BossRushBattleData.DebuffList)
					{
						BossRushDebuffDesc bossRushDebuffDesc = GameDBRuntime.GetBossRushDebuffDesc(debuff);
						if (bossRushDebuffDesc == null)
						{
							continue;
						}
						Dictionary<int, float> bossRushAttrOverrides = BGW_GameDB.GetBossRushAttrOverrides(bossRushDebuffDesc.DebuffId);
						if (bossRushAttrOverrides == null)
						{
							continue;
						}
						foreach (KeyValuePair<int, float> item in bossRushAttrOverrides)
						{
							effectAttrDict.OverrideAttrValue((EBGUAttrFloat)item.Key, item.Value);
						}
					}
				}
			}
			else
			{
				IBIC_BossRushBattleData gameInstanceReadonlyData2 = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_BossRushBattleData, BIC_BossRushBattleData>(bGUCharacterCS);
				if (gameInstanceReadonlyData2 != null)
				{
					effectAttrDict.AddAttrValue(EBGUAttrFloat.HpMaxMul, gameInstanceReadonlyData2.AdditionalHPMaxMul);
					effectAttrDict.AddAttrValue(EBGUAttrFloat.AtkMul, gameInstanceReadonlyData2.AdditionalAtkMul);
				}
			}
		}
		return effectAttrDict.Export();
	}

	public static EffectAttrList GetRoleBaseAttrList(UObject WorldContext, RoleAttrParam param)
	{
		EffectAttrDict effectAttrDict = new EffectAttrDict();
		var (num, battleInfoExtendID) = BGW_PlayerCharacterFuncUtil.GetLocalPlayerResIdAndExtendID(WorldContext);
		RoleAttrHelper.FillRoleExtAttr(WorldContext, num, effectAttrDict, param);
		BGUCharacterCS actor = UGameplayStatics.GetPlayerCharacter(WorldContext, 0) as BGUCharacterCS;
		EffectAttrList unitBaseAttrList = GetUnitBaseAttrList(num, battleInfoExtendID, 0, actor);
		effectAttrDict.AppendAttrList(unitBaseAttrList);
		return effectAttrDict.Export();
	}

	public static EffectAttrList GetRoleBaseAttrList(UObject WorldContext, RoleDataCS roleDataCS)
	{
		RoleAttrParam param = new RoleAttrParam();
		RoleAttrHelper.FillRoleAttrCalcParam(param, roleDataCS);
		return GetRoleBaseAttrList(WorldContext, param);
	}
}
