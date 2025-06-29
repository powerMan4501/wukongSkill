using System;
using System.Collections.Generic;
using b1.BGW;
using BtlB1;
using Diana.Common;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class ComboSSF : SkillScoreFilterBaseCS
{
	private float AngleScore;

	private float RealComboSkillScore;

	private float CoolDownScore;

	private float EndSkillScore;

	private float OptimalDisScore;

	private float LengestDisScore;

	private float HitAdditionScore;

	private float GroupCastAdditionMultipler;

	public ComboSSF()
	{
		InitScoreValue();
	}

	public override bool CalculateScore(AActor BGUActor, int SkillID, bool UsePursuitAnyWhere, out float Score)
	{
		InitScoreValue();
		if (UsePursuitAnyWhere)
		{
			CalcLengestDisScore(BGUActor, SkillID);
			Score = LengestDisScore;
		}
		else
		{
			CalcAngleScore(BGUActor, SkillID);
			CalcRealComboScore(BGUActor, SkillID);
			CalcEndSkillScore(BGUActor, SkillID);
			CalcCoolDownScore(BGUActor, SkillID);
			CalcOptimalDisScore(BGUActor, SkillID);
			CalcHitAddition(BGUActor, SkillID);
			CalcGroupAddition(BGUActor, SkillID);
			Score = (AngleScore + CoolDownScore + EndSkillScore + RealComboSkillScore + OptimalDisScore + HitAdditionScore) * GroupCastAdditionMultipler;
		}
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			string text = (UsePursuitAnyWhere ? $"[SSF_Combo] SkillID = {SkillID}, 追逐模式下特殊算分只计算距离, LengestDisScore = {LengestDisScore}, TotalScore = {Score}" : $"[SSF_Combo] SkillID = {SkillID}, AngleScore = {AngleScore}, RealComboSkillScore = {RealComboSkillScore}, CoolDownScore = {CoolDownScore}, EndSkillScore = {EndSkillScore}, OptimalDisScore = {OptimalDisScore}, HitAdditionScore = {HitAdditionScore}, GroupCastAdditionMultipler = {GroupCastAdditionMultipler}, TotalScore = {Score}");
			BGUFunctionLibraryCS.LogBattleInfo(BGUActor, EBattleInfoType.SkillCast, "<character>" + BGUActor.GetName().ConvertLongGuid2DisplayGuid() + "</><action> " + text + "</>");
		}
		return true;
	}

	private void InitScoreValue()
	{
		AngleScore = 0f;
		CoolDownScore = 0f;
		EndSkillScore = 0f;
		RealComboSkillScore = 0f;
		OptimalDisScore = 0f;
		HitAdditionScore = 0f;
		GroupCastAdditionMultipler = 1f;
	}

	private void CalcAngleScore(AActor Unit, int SkillID)
	{
		FUStSkillAIDesc skillAIDesc = BGW_GameDB.GetSkillAIDesc(SkillID);
		if (skillAIDesc == null)
		{
			return;
		}
		AActor aActor = BGUFunctionLibraryCS.BGUGetTarget(Unit);
		if (!(Unit == null) && !(aActor == null))
		{
			float num = UBGUFuncLibAI.BGUAICaculateTargetAngle(aActor, Unit);
			if (num >= 0f && num <= 45f)
			{
				AngleScore = skillAIDesc.AngleScoreSector0To45;
			}
			else if (num > 45f && num <= 90f)
			{
				AngleScore = skillAIDesc.AngleScoreSector45To90;
			}
			else if (num > 90f && num <= 135f)
			{
				AngleScore = skillAIDesc.AngleScoreSector90To135;
			}
			else if (num > 135f && num <= 180f)
			{
				AngleScore = skillAIDesc.AngleScoreSector135To180;
			}
			else if (num >= -180f && num <= -135f)
			{
				AngleScore = skillAIDesc.AngleScoreSector180ToNeg135;
			}
			else if (num > -135f && num <= -90f)
			{
				AngleScore = skillAIDesc.AngleScoreSectorNeg135ToNeg90;
			}
			else if (num > -90f && num <= -45f)
			{
				AngleScore = skillAIDesc.AngleScoreSectorNeg90ToNeg45;
			}
			else if (num > -45f && num <= 0f)
			{
				AngleScore = skillAIDesc.AngleScoreSectorNeg45To0;
			}
		}
	}

	private void CalcRealComboScore(AActor Unit, int SkillID)
	{
		if (Unit == null)
		{
			return;
		}
		BUC_AIData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AIData>(Unit);
		if (unPersistentReadOnlyData == null)
		{
			return;
		}
		BGWAISkillScoreConfigDataAsset aISkillScoreConfigDataAsset = BGW_PreloadAssetMgr.Get(Unit).AISkillScoreConfigDataAsset;
		if (aISkillScoreConfigDataAsset == null)
		{
			return;
		}
		if (unPersistentReadOnlyData.GetIsFirstSkill())
		{
			int curComboSkillNum = unPersistentReadOnlyData.GetCurComboSkillNum();
			float firstSkillRealComboAddition = aISkillScoreConfigDataAsset.FirstSkillRealComboAddition;
			int firstSkillRealComboSkillReduceNum = aISkillScoreConfigDataAsset.FirstSkillRealComboSkillReduceNum;
			RealComboSkillScore = firstSkillRealComboAddition * (float)(curComboSkillNum - firstSkillRealComboSkillReduceNum);
			return;
		}
		int num = BGUFuncLibSkillCS.BGUGetLastSkillID(Unit);
		FUStSkillAIDesc skillAIDesc = BGW_GameDB.GetSkillAIDesc(num);
		if (skillAIDesc != null)
		{
			int curComboStage = unPersistentReadOnlyData.GetCurComboStage();
			float realComboAddition = aISkillScoreConfigDataAsset.RealComboAddition;
			float otherComboSkillSubtraction = aISkillScoreConfigDataAsset.OtherComboSkillSubtraction;
			if (skillAIDesc.NextSkillList.Contains(SkillID))
			{
				RealComboSkillScore = realComboAddition * (float)curComboStage;
			}
			else if (IsOtherComboSkill(SkillID, num))
			{
				RealComboSkillScore = otherComboSkillSubtraction * (float)curComboStage;
			}
		}
	}

	private void CalcEndSkillScore(AActor Unit, int SkillID)
	{
		if (Unit == null)
		{
			return;
		}
		BUC_AIData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AIData>(Unit);
		if (unPersistentReadOnlyData == null)
		{
			return;
		}
		FUStSkillAIDesc skillAIDesc = BGW_GameDB.GetSkillAIDesc(SkillID);
		if (skillAIDesc == null)
		{
			return;
		}
		BGWAISkillScoreConfigDataAsset aISkillScoreConfigDataAsset = BGW_PreloadAssetMgr.Get(Unit).AISkillScoreConfigDataAsset;
		if (aISkillScoreConfigDataAsset == null)
		{
			return;
		}
		int curComboSkillNum = unPersistentReadOnlyData.GetCurComboSkillNum();
		int curComboStage = unPersistentReadOnlyData.GetCurComboStage();
		if (skillAIDesc.NextSkillList.Count == 0)
		{
			if (curComboSkillNum == curComboStage + 1)
			{
				EndSkillScore = aISkillScoreConfigDataAsset.EndSkillAddition;
			}
			else
			{
				EndSkillScore = aISkillScoreConfigDataAsset.EndSkillSubtraction;
			}
		}
	}

	private void CalcCoolDownScore(AActor Unit, int SkillID)
	{
		if (Unit == null)
		{
			return;
		}
		FUStSkillAIDesc skillAIDesc = BGW_GameDB.GetSkillAIDesc(SkillID);
		if (skillAIDesc == null)
		{
			return;
		}
		IBUC_SkillInstsData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>(Unit);
		if (readOnlyData == null)
		{
			return;
		}
		bool IsValid;
		float num = UBGUFunctionLibraryForCS.BGUGetCurrentTime(Unit, out IsValid);
		if (IsValid)
		{
			float lastSkillCastTime = readOnlyData.GetLastSkillCastTime(SkillID);
			if (lastSkillCastTime > 0f)
			{
				float num2 = num - lastSkillCastTime;
				CoolDownScore = FMath.Min(num2 * (float)skillAIDesc.CoolDownAddtion, skillAIDesc.CoolDownAdditionMax);
			}
			else
			{
				CoolDownScore = skillAIDesc.CoolDownAdditionMax;
			}
		}
	}

	private void CalcOptimalDisScore(AActor Unit, int SkillID)
	{
		AActor aActor = BGUFunctionLibraryCS.BGUGetTarget(Unit);
		if (Unit == null || aActor == null)
		{
			return;
		}
		FUStSkillAIDesc skillAIDesc = BGW_GameDB.GetSkillAIDesc(SkillID);
		if (skillAIDesc != null)
		{
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor);
			FVector fVector2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(Unit);
			float num = (float)(fVector - fVector2).VSizeXY();
			if (num >= skillAIDesc.OptimalDisMin && num <= skillAIDesc.OptimalDisMax)
			{
				OptimalDisScore = skillAIDesc.OptimalDisAddScore;
			}
		}
	}

	private void CalcHitAddition(AActor Unit, int SkillID)
	{
		AActor aActor = BGUFunctionLibraryCS.BGUGetTarget(Unit);
		if (!(Unit == null) && !(aActor == null) && BGW_GameDB.GetSkillAIDesc(SkillID) != null)
		{
			BUC_AIData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AIData>(Unit);
			if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.ComboInfo.SkillModifyScoreDic.TryGetValue(SkillID, out var value))
			{
				HitAdditionScore = value;
			}
		}
	}

	private void CalcGroupAddition(AActor Unit, int SkillID)
	{
		GroupCastAdditionMultipler = 1f;
		IBGC_GlobalAIMgrData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_GlobalAIMgrData, BGC_GlobalAIMgrData>(Unit);
		if (gameStateReadonlyData == null)
		{
			return;
		}
		IBUC_GuidData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_GuidData, BUC_GuidData>(Unit);
		if (readOnlyData == null)
		{
			return;
		}
		int actorResID = BGU_DataUtil.GetActorResID(Unit);
		if (!gameStateReadonlyData.CheckSkillIsInGroup(actorResID, readOnlyData.GetFinalGuid(), SkillID, out var GroupLastCastTime))
		{
			return;
		}
		bool IsValid;
		float num = UBGUFunctionLibraryForCS.BGUGetCurrentTime(Unit, out IsValid);
		if (IsValid)
		{
			float num2 = num - GroupLastCastTime;
			if (num2 > 10f)
			{
				GroupCastAdditionMultipler = 1f;
			}
			else if (num2 > 0f)
			{
				GroupCastAdditionMultipler = num2 / 10f;
			}
		}
	}

	private void CalcLengestDisScore(AActor Unit, int SkillID)
	{
		AActor aActor = BGUFunctionLibraryCS.BGUGetTarget(Unit);
		if (!(Unit == null) && !(aActor == null))
		{
			FUStSkillAIDesc skillAIDesc = BGW_GameDB.GetSkillAIDesc(SkillID);
			if (skillAIDesc != null)
			{
				FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor);
				FVector fVector2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(Unit);
				float num = (float)(fVector - fVector2).VSizeXY();
				LengestDisScore = 0f - Math.Abs(num - skillAIDesc.OptimalDisMax);
			}
		}
	}

	private bool IsOtherComboSkill(int SkillID, int LastSkillID)
	{
		foreach (KeyValuePair<int, FUStSkillAIDesc> item in BGW_GameDB.GetAllSkillAIDesc())
		{
			int key = item.Key;
			FUStSkillAIDesc value = item.Value;
			if (key != SkillID && key != LastSkillID && value.NextSkillList.Contains(SkillID))
			{
				return true;
			}
		}
		return false;
	}
}
