using System.Collections.Generic;
using b1.BGW;
using b1.ECS;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUIAComplexMontage : BUInteractActionTemplate
{
	private UAnimInstance PlayerAnimInstance;

	private UAnimInstance TargetAnimInstance;

	public BUIAComplexMontage()
	{
		ParamIntNum = 0;
		ParamStringNum = 2;
	}

	public override bool DoInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		UAnimMontage uAnimMontage = BGW_PreloadAssetMgr.Get(User).TryGetCachedResourceObj<UAnimMontage>(Action.ParamsString[0], ELoadResourceType.SyncLoadAndCache);
		bool flag = false;
		List<ABGUCharacter> allTargetCharacterList = BGUFunctionLibraryCS.GetAllTargetCharacterList(User as ABGUCharacter);
		if (allTargetCharacterList != null)
		{
			for (int i = 0; i < allTargetCharacterList.Count; i++)
			{
				ABGUCharacter aBGUCharacter = allTargetCharacterList[i];
				if (aBGUCharacter != null && BGU_DataUtil.GetActorResID(aBGUCharacter) == 2012 && BGU_DataUtil.GetReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(aBGUCharacter) != null)
				{
					IBUC_TargetInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(aBGUCharacter);
					if (readOnlyData != null && readOnlyData.GetTargetInfo().LockTargetEntity != Entity.Null)
					{
						flag = true;
						BGW_LogUtil.LogError("[interactcomp] 石先锋临时逻辑命中");
					}
				}
			}
		}
		if (uAnimMontage != null && !flag)
		{
			BGUFunctionLibraryCS.BGUTriggerUnitState(User, EBUStateTrigger.AttackStateBegin, -1f);
			BGUFuncLibAnim.BGUActorTryPlayMontage(User, uAnimMontage, FName.None, EMontageBindReason.Interact);
		}
		UAnimMontage uAnimMontage2 = BGW_PreloadAssetMgr.Get(InteractiveActor).TryGetCachedResourceObj<UAnimMontage>(Action.ParamsString[1], ELoadResourceType.SyncLoadAndCache);
		if (uAnimMontage2 == null)
		{
			return false;
		}
		BGUFunctionLibraryCS.BGUTriggerUnitState(InteractiveActor, EBUStateTrigger.AttackStateBegin, -1f);
		BGUFuncLibAnim.BGUActorTryPlayMontage(InteractiveActor, uAnimMontage2, FName.None, EMontageBindReason.Interact);
		return true;
	}

	public override void OnBreakInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		if (!PlayerAnimInstance.IsNullOrDestroyed())
		{
			PlayerAnimInstance.Montage_Stop(0.2f, null);
		}
		if (!TargetAnimInstance.IsNullOrDestroyed())
		{
			TargetAnimInstance.Montage_Stop(0.2f, null);
		}
	}
}
