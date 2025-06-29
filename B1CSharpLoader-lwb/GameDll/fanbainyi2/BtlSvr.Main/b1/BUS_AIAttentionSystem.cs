using System.Collections.Generic;
using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_AIAttentionSystem : UActorCompBaseCS
{
	private float AttentionInterval;

	private float TimeAccumulate;

	private BUC_AIAttentionData AIAttentionData;

	public override void OnAttach()
	{
		AIAttentionData = RequireWritableData<BUC_AIAttentionData>();
		base.BUSEventCollection.Evt_OnExitThink += new Del_Void(OnExitThink);
		base.BUSEventCollection.Evt_OnActiveCurThink += new Del_Void(OnActiveCurThink);
		base.BUSEventCollection.Evt_OnInitThink += new Del_OnInitThink(UpdateCurThinkInfo);
		base.BUSEventCollection.Evt_OnBasicActionFailed += new Del_OnBasicActionFailed(OnBasicActionFailed);
		base.BUSEventCollection.Evt_OnExecuteBaseAction += new Del_OnExecuteBaseAction(OnExecuteBaseAction);
		base.BUSEventCollection.Evt_OnExitActiveThink += new Del_Void(OnExitActiveThink);
		base.BUSEventCollection.Evt_OnGenerateSkillFeature += new Del_OnGenerateSkillFeature(OnGenerateSkillFeature);
	}

	public override void PreBeginPlay()
	{
		AttentionInterval = 0.1f;
		TimeAccumulate = 0f;
		AIAttentionData.Init();
		LoadSkillBaseActionInfo();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
	}

	private void OnGenerateSkillFeature(AFSkillArea SkillAreaFeature)
	{
		AIAttentionData.SkillAreaFeatureList.Add(new TStrongObjectPtr<AFSkillArea>(SkillAreaFeature));
	}

	private void OnExitActiveThink()
	{
		ResetActiveThink();
		AIAttentionData.CurThinkInfo.CurThinkTime = 0f;
	}

	private void OnExitThink()
	{
	}

	private void OnActiveCurThink()
	{
		AIAttentionData.CurThinkInfo.ActiveThinkName = AIAttentionData.CurThinkInfo.CurThinkName;
	}

	private void OnBasicActionFailed(EAIBasicActionState BAState)
	{
		ReduceAndTestBAToTestNum();
	}

	private void OnExecuteBaseAction(EAIBasicActionType BaseActionType)
	{
		UpdateSelfAttention();
	}

	private void ResetActiveThink()
	{
		AIAttentionData.CurThinkInfo.ActiveThinkName = "";
	}

	private void UpdateSelfAttention()
	{
		AIAttentionData.ValidSkillBasicActionDic.Clear();
		foreach (KeyValuePair<int, List<BaseActionMsg>> item in AIAttentionData.AllSkillBasicActionDic)
		{
			base.BUSEventCollection.Evt_OnSkillMappingStart.Invoke(item.Key);
			BUC_SkillMappingData bUC_SkillMappingData = RequireWritableData<BUC_SkillMappingData>();
			int num = item.Key;
			if (bUC_SkillMappingData != null)
			{
				num = bUC_SkillMappingData.GetCurResultSkillID(item.Key);
			}
			if (num == -1)
			{
				num = item.Key;
			}
			if (BGU_CommonUtil.CheckSkillCanCast(GetOwner(), item.Key, num) == ECanCastSkillResult.CCSR_OK)
			{
				if (AIAttentionData.AllSkillBasicActionDic.TryGetValue(num, out var value) && !AIAttentionData.ValidSkillBasicActionDic.ContainsKey(num))
				{
					AIAttentionData.ValidSkillBasicActionDic.Add(num, value);
				}
				else if (AIAttentionData.MappedSkillBasicActionDic.TryGetValue(num, out value) && !AIAttentionData.ValidSkillBasicActionDic.ContainsKey(num))
				{
					AIAttentionData.ValidSkillBasicActionDic.Add(num, value);
				}
			}
		}
	}

	private void UpdateCurThinkInfo(string ThinkName, int Num)
	{
		AIAttentionData.CurThinkInfo.CurThinkName = ThinkName;
		AIAttentionData.CurThinkInfo.BAToTestNum = Num;
	}

	private void ReduceAndTestBAToTestNum()
	{
		AIAttentionData.CurThinkInfo.BAToTestNum--;
		if (AIAttentionData.CurThinkInfo.BAToTestNum == 0)
		{
			base.BUSEventCollection.Evt_OnExitThink.Invoke();
			if (AIAttentionData.GetCurThinkInfo().ActiveThinkName == AIAttentionData.GetCurThinkInfo().CurThinkName)
			{
				base.BUSEventCollection.Evt_OnExitActiveThink.Invoke();
			}
		}
	}

	private void UpdateRunTimeAttentionInfo(float DeltaTime)
	{
		if (BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AIRequestManageData, BUC_AIRequestManageData>(GetOwner()).GetLastActionState() == EAIBasicActionState.Executing)
		{
			AIAttentionData.CurThinkInfo.CurThinkTime += DeltaTime;
		}
	}

	private void UpdateAttackableEnemyFeature()
	{
		AFAttackableEnemy aFAttackableEnemy = UObject.NewObject<AFAttackableEnemy>();
		BGUCharacterCS[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGUCharacterCS>(GetOwner());
		foreach (BGUCharacterCS bGUCharacterCS in allActorsOfClass)
		{
			if (!bGUCharacterCS.IsNullOrDestroyed() && BGUFunctionLibraryCS.BGUIsEnemyTeam(GetOwner(), bGUCharacterCS) && !BGUFunctionLibraryCS.BGUHasUnitState(bGUCharacterCS, EBGUUnitState.Dead) && !BGUFunctionLibraryCS.BGUHasUnitSimpleState(bGUCharacterCS, EBGUSimpleState.PendingDeathInAnimationSyncing) && !BGUFunctionLibraryCS.BGUHasUnitSimpleState(bGUCharacterCS, EBGUSimpleState.CantBeBaseTarget))
			{
				aFAttackableEnemy.EnemyActors.Add(bGUCharacterCS);
			}
		}
		if (aFAttackableEnemy.EnemyActors.Count != 0)
		{
			AIAttentionData.RunTimeFeatureList.Add(new TStrongObjectPtr<AttentionFeatureBase>(aFAttackableEnemy));
		}
	}

	private void UpdateStandInRangeFeature()
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (!(bGUCharacterCS == null) && AIFuncLibForCS.CheckPointInSkillArea(BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner()), bGUCharacterCS, IsEnemy: true))
		{
			AFStandInSkillArea obj = UObject.NewObject<AFStandInSkillArea>();
			AIAttentionData.RunTimeFeatureList.Add(new TStrongObjectPtr<AttentionFeatureBase>(obj));
		}
	}

	private void UpdateSkillAreaFeature()
	{
		foreach (TStrongObjectPtr<AFSkillArea> skillAreaFeature in AIAttentionData.SkillAreaFeatureList)
		{
			AFSkillArea aFSkillArea = skillAreaFeature.Get();
			if (aFSkillArea.ExecuteTime + aFSkillArea.DurationTime < GetOwner().World.GetTimeSeconds())
			{
				AIAttentionData.SkillAreaFeatureList.Remove(skillAreaFeature);
				break;
			}
		}
	}

	private void UpdateNearestEnemyFeature()
	{
		BGUCharacterCS bGUCharacterCS = null;
		float num = 999999f;
		BGUCharacterCS[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGUCharacterCS>(GetOwner());
		foreach (BGUCharacterCS bGUCharacterCS2 in allActorsOfClass)
		{
			if (!BGUFunctionLibraryCS.BGUHasUnitState(bGUCharacterCS2, EBGUUnitState.Dead) && !BGUFunctionLibraryCS.BGUHasUnitSimpleState(bGUCharacterCS2, EBGUSimpleState.PendingDeathInAnimationSyncing) && BGUFunctionLibraryCS.BGUIsEnemyTeam(GetOwner(), bGUCharacterCS2))
			{
				float num2 = FVector.Dist(BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner()), BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS2));
				if (num2 < num)
				{
					num = num2;
					bGUCharacterCS = bGUCharacterCS2;
				}
			}
		}
		if (bGUCharacterCS != null)
		{
			AFNearestEnemy aFNearestEnemy = UObject.NewObject<AFNearestEnemy>();
			aFNearestEnemy.EnemyCharacter = bGUCharacterCS;
			aFNearestEnemy.EnemyLoc = BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS);
			AIAttentionData.RunTimeFeatureList.Add(new TStrongObjectPtr<AttentionFeatureBase>(aFNearestEnemy));
		}
	}

	private void LoadSkillBaseActionInfo()
	{
		int actorResID = BGU_DataUtil.GetActorResID(GetOwner());
		foreach (KeyValuePair<int, FUStAISkillBasicActionDesc> item in BGW_GameDB.GetAllAISkillBasicActionDesc())
		{
			if (!item.Key.ToString().StartsWith(actorResID.ToString()))
			{
				continue;
			}
			List<BaseActionMsg> list = new List<BaseActionMsg>();
			FUStAISkillBasicActionDesc value = item.Value;
			foreach (FUStBasicAction basicAction in value.BasicActions)
			{
				BaseActionMsg baseActionMsg = new BaseActionMsg();
				baseActionMsg.AIBasicActionType = basicAction.BasicActionType;
				switch (basicAction.BasicActionType)
				{
				case EAIBasicActionType.RootMotionMove:
					baseActionMsg.MoveDis = basicAction.ActionParam[0];
					break;
				case EAIBasicActionType.DirectionDamage:
					baseActionMsg.Damage = basicAction.ActionParam[0];
					break;
				case EAIBasicActionType.MoveSkill:
					baseActionMsg.Damage = basicAction.ActionParam[0];
					break;
				}
				baseActionMsg.MaxRange = basicAction.MaxRange;
				baseActionMsg.MinRange = basicAction.MinRange;
				baseActionMsg.SkillID = item.Key;
				list.Add(baseActionMsg);
			}
			if (value.IsMappedSkill == EGSYesNo.Yes)
			{
				AIAttentionData.MappedSkillBasicActionDic.Add(item.Key, list);
			}
			else
			{
				AIAttentionData.AddSkillBAList(item.Key, list);
			}
		}
	}
}
