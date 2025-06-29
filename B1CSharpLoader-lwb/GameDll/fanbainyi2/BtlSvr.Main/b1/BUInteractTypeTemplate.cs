using System.Collections.Generic;
using b1.ECS;
using BtlB1;
using BtlShare;
using Google.Protobuf.Collections;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

public abstract class BUInteractTypeTemplate
{
	protected EPreCheckBehavior[] PreCheckBehaviorArr;

	private bool CheckHasItem(BPC_PlayerRoleData RoleData, RepeatedField<FUStInteractCondition> InteractCondition)
	{
		foreach (FUStInteractCondition item in InteractCondition)
		{
			if (RoleDataHelper.GetBagItemNum(RoleData, item.ConditionItemID) < item.ConditionItemNum)
			{
				return false;
			}
		}
		return true;
	}

	public bool PreCheckInteract(BUC_InteractData InteractiveData, AActor User, AActor InteractiveActor)
	{
		APawn aPawn = User as APawn;
		if (aPawn == null)
		{
			InteractiveData.InteractConstraint = EInteractConstraint.Other;
			return false;
		}
		IBPC_TransData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_TransData, BPC_TransData>(aPawn.PlayerState);
		IBPC_PlayerTagData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerTagData, BPC_PlayerTagData>(aPawn.PlayerState);
		BUC_BattleStateData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_BattleStateData>(aPawn);
		FVector actorLocation = User.GetActorLocation();
		if (unPersistentReadOnlyData == null || readOnlyData == null || readOnlyData2 == null)
		{
			InteractiveData.InteractConstraint = EInteractConstraint.Other;
			return false;
		}
		EPreCheckBehavior[] preCheckBehaviorArr = PreCheckBehaviorArr;
		for (int i = 0; i < preCheckBehaviorArr.Length; i++)
		{
			switch (preCheckBehaviorArr[i])
			{
			case EPreCheckBehavior.FocusOn:
			{
				FVector2D v = UGSE_UMGFuncLib.GetViewPortSize(User) / UWidgetLayoutLibrary.GetViewportScale(aPawn.GetController());
				double num = (double)v.X * 0.12;
				v.X *= 0.5f;
				v.Y *= 0.35f;
				UWidgetLayoutLibrary.ProjectWorldLocationToWidgetPosition(aPawn.GetController() as APlayerController, InteractiveData.IconSockVector, out var ScreenPosition, bPlayerViewportRelative: true);
				if (ScreenPosition.Distance2D(v) > num)
				{
					InteractiveData.InteractConstraint = EInteractConstraint.NotFocusEnough;
					return false;
				}
				break;
			}
			case EPreCheckBehavior.HasRequireItem:
				if (InteractiveData.ItemRequireCondition)
				{
					InteractiveData.InteractConstraint = EInteractConstraint.ItemRequireCondition;
					return false;
				}
				break;
			case EPreCheckBehavior.NotInBattle:
			{
				if (!unPersistentReadOnlyData.IsUnitInBattle())
				{
					break;
				}
				float leaveActivableDistance = UBGWFunctionLibraryCS.GetLeaveActivableDistance(InteractiveData.TrueActivableDistance);
				List<ABGUCharacter> allTargetCharacterList = BGUFunctionLibraryCS.GetAllTargetCharacterList(User as ABGUCharacter);
				if (allTargetCharacterList == null)
				{
					break;
				}
				foreach (ABGUCharacter item in allTargetCharacterList)
				{
					if (item == null)
					{
						continue;
					}
					IBUC_AIData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AIData, BUC_AIData>(item);
					if (unPersistentReadOnlyData2 != null && !unPersistentReadOnlyData2.CanEffectPlayerBattleState)
					{
						continue;
					}
					IBUC_UnitStateData readOnlyData4 = BGU_DataUtil.GetReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(item);
					if (readOnlyData4 == null || readOnlyData4.HasState(EBGUUnitState.Dead) || BGUFunctionLibraryCS.BGUHasUnitSimpleState(item, EBGUSimpleState.PendingDeathInAnimationSyncing))
					{
						continue;
					}
					FVector actorLocation2 = item.GetActorLocation();
					FVector actorLocation3 = InteractiveActor.GetActorLocation();
					if (FVector.Distance(actorLocation2, actorLocation3) < leaveActivableDistance)
					{
						IBUC_TargetInfoData readOnlyData5 = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(item);
						if (readOnlyData5 != null && readOnlyData5.GetTargetInfo().LockTargetEntity != Entity.Null && InteractiveData.IsInBothSide(actorLocation, actorLocation2))
						{
							InteractiveData.InteractConstraint = EInteractConstraint.EnemyAround;
							return false;
						}
					}
				}
				break;
			}
			case EPreCheckBehavior.NotInTransforming:
				if (readOnlyData2.HasTag(EBGPPlayerTag.Transforming))
				{
					InteractiveData.InteractConstraint = EInteractConstraint.TransForming;
					BGW_LogUtil.LogError("[InteractComp] 当前交互物类型 变身中 不能交互");
					return false;
				}
				break;
			case EPreCheckBehavior.CricketIdle:
			{
				IBUC_SimpleStateData readOnlyData3 = BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(InteractiveActor);
				if (readOnlyData3 != null && !readOnlyData3.HasSimpleState(EBGUSimpleState.CricketIdle))
				{
					InteractiveData.InteractConstraint = EInteractConstraint.CricketIdle;
					return false;
				}
				break;
			}
			}
		}
		return true;
	}

	public virtual bool TriggerInteractInput(int InteractiveActorID, AActor User, AActor InteractiveActor)
	{
		return true;
	}

	public virtual bool BreakInteractInput(int InteractiveActorID, AActor User, AActor InteractiveActor)
	{
		return true;
	}

	public virtual bool FinishInteractInput(int InteractiveActorID, AActor User, AActor InteractiveActor)
	{
		return true;
	}

	public virtual bool BreakInteract(int InteractiveActorID, AActor User, AActor InteractiveActor)
	{
		return true;
	}

	public virtual void FinishInteract(int InteractiveActorID, AActor User, AActor InteractiveActor)
	{
		BPC_PlayerInteractData readOnlyData = BGU_DataUtil.GetReadOnlyData<BPC_PlayerInteractData>((User as APawn).PlayerState);
		if (readOnlyData == null || readOnlyData.InteractActionDesc.InteractAction != EInteractAction.ToolNpc)
		{
			BUC_InteractData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_InteractData>(InteractiveActor);
			int interactCounter = readOnlyData2.InteractCounter;
			BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(User);
			if (bGW_EventCollection != null)
			{
				bGW_EventCollection.Evt_BGW_InteractGroup_Complete(readOnlyData2.ActionGroupID, interactCounter);
			}
			BGW_GameArchiveMgr.Get(User)?.MarkSaveArchive(EArchiveSaveSource.Interact);
		}
	}
}
