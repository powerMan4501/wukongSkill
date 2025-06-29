using System.Collections.Generic;
using CommB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_AiWeakInteractCompImpl : UActorCompBaseCS
{
	private b1.BUC_AiWeakInteractData AiWeakInteractData;

	private IBUC_GuidData GuidData;

	private IBUC_TickRateData TickRateData;

	private b1.IBGC_SimpleOverlapMgrData SimpleOverlapMgrData;

	private IBGC_FollowPartnerMgrData FollowPartnerMgrData;

	private BGW_ECSWorld ECSWorld { get; set; }

	public override void OnAttach()
	{
		AiWeakInteractData = RequireWritableData<b1.BUC_AiWeakInteractData>();
		GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		TickRateData = RequireReadOnlyData<IBUC_TickRateData, BUC_TickRateData>();
		SimpleOverlapMgrData = RequireReadOnlyGameStateData<b1.IBGC_SimpleOverlapMgrData, BGC_SimpleOverlapMgrData>();
		FollowPartnerMgrData = RequireReadOnlyGameStateData<IBGC_FollowPartnerMgrData, BGC_FollowPartnerMgrData>();
		ECSWorld = BGW_ECSWorld.Get(Owner);
	}

	public override void PreBeginPlay()
	{
		AiWeakInteractData.OwnerLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
		AiWeakInteractData.TaskConditionSuccess = false;
		if (ECSWorld == null || AiWeakInteractData.InteractTriggerRadius <= 0 || AiWeakInteractData.AiConversationID <= 0)
		{
			SetCanTick(Val: false);
		}
		if (AiWeakInteractData.EnableTaskStageCondition)
		{
			AiWeakInteractData.TaskConditionSuccess = CheckTaskCondition();
			if (AiWeakInteractData.TaskConditionSuccess)
			{
				SetCanTick(Val: false);
			}
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!TickRateData.CanTickFor1000msInterval(out var _, out var _, out var _, out var _, out var _) || AiWeakInteractData.TaskConditionSuccess)
		{
			return;
		}
		if (AiWeakInteractData.EnableTaskStageCondition)
		{
			AiWeakInteractData.TaskConditionSuccess = CheckTaskCondition();
			if (AiWeakInteractData.TaskConditionSuccess)
			{
				SetCanTick(Val: false);
				return;
			}
		}
		if (!(FollowPartnerMgrData.FollowPartnerDisplayConfig == null) && !FollowPartnerMgrData.WeakAiInteractGUIDList.Contains(GuidData.GetFinalGuid()) && FollowPartnerMgrData.WeakAiInteractConversationTimer <= 0f && FollowPartnerMgrData.FollowPartnerDisplayConfig.WeakAiInteractConversationCD > 0)
		{
			CheckRadius();
		}
	}

	private bool CheckTaskCondition()
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner);
		APawn aPawn = firstLocalPlayerController?.GetControlledPawn();
		if (aPawn != null && aPawn.PlayerState != null)
		{
			IBPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(firstLocalPlayerController);
			if (readOnlyData != null && readOnlyData.RoleData != null && readOnlyData.RoleData.RoleCs != null && readOnlyData.RoleData.RoleCs.Task != null)
			{
				foreach (ReadOnlyQuestStageOne quest in readOnlyData.RoleData.RoleCs.Task.QuestList)
				{
					if (AiWeakInteractData.TaskStageID == quest.Id && (int)AiWeakInteractData.TaskStageStatus <= (int)quest.Stage)
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	private void CheckRadius()
	{
		SimpleOverlapMgrData.GetSimpleOverlapActorsByMask(Owner, AiWeakInteractData.OwnerLocation, 1, AiWeakInteractData.InteractTriggerRadius, 0f, 0f, default(FVector2D), IsSphere: true, out var OutList);
		switch (AiWeakInteractData.AiWeakInteractCheckType)
		{
		case EAiWeakInteractCheckType.BothPlayerAndFollowPartner:
		{
			if (OutList.Count < 2)
			{
				break;
			}
			bool flag2 = false;
			bool flag3 = false;
			AActor actor2 = null;
			foreach (AActor item in OutList)
			{
				if (flag2 && flag3)
				{
					break;
				}
				if (!(FVector.Distance(AiWeakInteractData.OwnerLocation, BGUFuncLibActorTransformCS.BGUGetActorLocation(item)) <= (float)AiWeakInteractData.InteractTriggerRadius))
				{
					continue;
				}
				FVector b2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(item) - AiWeakInteractData.OwnerLocation;
				if (!(FMath.Abs(MathLib.DegAcos(FVector.DotProduct(AiWeakInteractData.OwnerLocation, b2))) <= (float)AiWeakInteractData.InteractTriggerAngle) || !(item is BGUCharacterCS bGUCharacterCS))
				{
					continue;
				}
				if (bGUCharacterCS.IsPlayerControlled())
				{
					flag2 = true;
					continue;
				}
				IBUC_FollowPartnerData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_FollowPartnerData, b1.BUC_FollowPartnerData>(item);
				if (readOnlyData2 != null)
				{
					actor2 = item;
					flag3 = readOnlyData2.IsFollowPartnerUnit;
				}
			}
			if (flag2 && flag3)
			{
				BUS_EventCollectionCS.Get(actor2).Evt_TriggerAiConversationForWeakInteract.Invoke(GuidData.GetFinalGuid(), new List<int> { AiWeakInteractData.AiConversationID });
			}
			break;
		}
		case EAiWeakInteractCheckType.OnlyFollowPartner:
		{
			if (OutList.Count < 1)
			{
				break;
			}
			bool flag = false;
			AActor actor = null;
			foreach (AActor item2 in OutList)
			{
				if (flag)
				{
					break;
				}
				if (!(FVector.Distance(AiWeakInteractData.OwnerLocation, BGUFuncLibActorTransformCS.BGUGetActorLocation(item2)) <= (float)AiWeakInteractData.InteractTriggerRadius))
				{
					continue;
				}
				FVector b = BGUFuncLibActorTransformCS.BGUGetActorLocation(item2) - AiWeakInteractData.OwnerLocation;
				if (FMath.Abs(MathLib.DegAcos(FVector.DotProduct(AiWeakInteractData.OwnerLocation, b))) <= (float)AiWeakInteractData.InteractTriggerAngle && item2 is BGUCharacterCS)
				{
					IBUC_FollowPartnerData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_FollowPartnerData, b1.BUC_FollowPartnerData>(item2);
					if (readOnlyData != null)
					{
						actor = item2;
						flag = readOnlyData.IsFollowPartnerUnit;
					}
				}
			}
			if (flag)
			{
				BUS_EventCollectionCS.Get(actor).Evt_TriggerAiConversationForWeakInteract.Invoke(GuidData.GetFinalGuid(), new List<int> { AiWeakInteractData.AiConversationID });
			}
			break;
		}
		}
	}
}
