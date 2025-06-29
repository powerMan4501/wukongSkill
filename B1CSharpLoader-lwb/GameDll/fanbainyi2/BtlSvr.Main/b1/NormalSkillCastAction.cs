using System.Collections.Generic;
using b1.ECS;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class NormalSkillCastAction : ActionProcessBase
{
	private FRotator StartRot;

	public NormalSkillCastAction(AActor Own)
		: base(Own)
	{
	}

	public override void StartExecute(AIActionElem ActionElem)
	{
		base.StartExecute(ActionElem);
		FVector location = ActionElem.InputDataList[0].DataList[0].GetLocation();
		ACharacter character = ActionElem.InputDataList[0].DataList[0].GetCharacter();
		if (character != null)
		{
			UnitLockTargetInfo unitLockTargetInfo = new UnitLockTargetInfo(character, ETargetSourceType.None, ELockTargetWayType.Auto);
			if (unitLockTargetInfo.LockTargetEntity != Entity.Null)
			{
				BGUFunctionLibraryCS.BGUSetTargetInfo(!UGSE_EngineFuncLib.IsStandAlone(Own.World), Own, unitLockTargetInfo);
			}
		}
		int skillID = ActionElem.PreExeCache.SkillInfoList[0].SkillID;
		foreach (AISkillInfo skillInfo in ActionElem.PreExeCache.SkillInfoList)
		{
			float num = FVector.Dist2D(BGUFuncLibActorTransformCS.BGUGetActorLocation(Own), location);
			if (num < skillInfo.MaxRange * 1.1f && num > skillInfo.MinRange * 0.9f)
			{
				skillID = skillInfo.SkillID;
				break;
			}
		}
		BGUFuncLibAICS.BGURequestAIUseSkillWithSkillID_CSharp(Own, skillID, ECastSkillSourceType.AI_GOAP);
		BGUFuncLibActorTransformCS.BGUSetActorRotation(Own, MathLib.MakeRotFromX((location - BGUFuncLibActorTransformCS.BGUGetActorLocation(Own)).GetSafeNormal2D()), bTeleportPhysics: false);
		StartRot = BGUFuncLibActorTransformCS.BGUGetActorRotation(Own);
		State = AIActionProcessState.UnAvailable;
	}

	public override void ExecuteTick(float DeltaTime)
	{
		if (ActionElemList.Count != 0)
		{
			AIActionElem aIActionElem = ActionElemList[0];
			if (aIActionElem.State == AIActionState.Executing && aIActionElem.PreExeCache.FilterDesc.Tags.Contains(EActionTagType.KeepFacing))
			{
				FVector location = aIActionElem.InputDataList[0].DataList[0].GetLocation();
				BGUFuncLibActorTransformCS.BGUSetActorRotation(Own, MathLib.MakeRotFromX((location - BGUFuncLibActorTransformCS.BGUGetActorLocation(Own)).GetSafeNormal2D()), bTeleportPhysics: false);
			}
			if (aIActionElem.PreExeCache.FilterDesc.Tags.Contains(EActionTagType.RotationLock))
			{
				BGUFuncLibActorTransformCS.BGUSetActorRotation(Own, StartRot, bTeleportPhysics: false);
			}
			if (!BGUFunctionLibraryCS.BGUHasUnitState(Own, EBGUUnitState.Attacking))
			{
				BUS_EventCollectionCS.Get(Own).Evt_OnActionExeFinish.Invoke(ActionElemList[0]);
				State = AIActionProcessState.Available;
				ActionElemList.RemoveAt(0);
			}
		}
	}

	public override bool Abort(AIActionElem ActionElem)
	{
		return false;
	}

	public override bool CheckAbortByProcess(ActionProcessBase OtherProcess)
	{
		IsProcessing();
		return false;
	}

	public override AIActionElem GetCurAction()
	{
		if (State == AIActionProcessState.Available)
		{
			return null;
		}
		return ActionElemList[0];
	}

	public override bool CheckExecutable(FUStAIActionFilter Filter, ActionPreExeCache PreExeCache)
	{
		if (State == AIActionProcessState.UnAvailable)
		{
			return false;
		}
		if (BGUFunctionLibraryCS.BGUHasUnitState(Own, EBGUUnitState.Dead) || BGUFunctionLibraryCS.BGUHasUnitSimpleState(Own, EBGUSimpleState.PendingDeathInAnimationSyncing))
		{
			return false;
		}
		if (BGUFunctionLibraryCS.BGUHasUnitState(Own, EBGUUnitState.Attacking))
		{
			return false;
		}
		if (BGUFunctionLibraryCS.BGUHasUnitState(Own, EBGUUnitState.Beatback))
		{
			return false;
		}
		List<AISkillInfo> validSkillInfoList = BGU_DataUtil.GetReadOnlyData<IBUC_GOAPData, BUC_GOAPData>(Own).GetValidSkillInfoList();
		List<AISkillInfo> list = new List<AISkillInfo>();
		foreach (AISkillInfo item in validSkillInfoList)
		{
			bool flag = true;
			foreach (EActionTagType tag in Filter.Tags)
			{
				if (!item.Tags.Contains(tag))
				{
					flag = false;
				}
			}
			if (flag)
			{
				list.Add(item);
			}
		}
		if (list.Count == 0)
		{
			return false;
		}
		PreExeCache.SkillInfoList = list;
		return true;
	}
}
