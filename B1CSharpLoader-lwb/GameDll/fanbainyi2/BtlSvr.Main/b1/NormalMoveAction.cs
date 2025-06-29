using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class NormalMoveAction : ActionProcessBase
{
	public FVector TargetLoc;

	public List<FVector> PathList;

	private float ProtectReachDis = 70f;

	private float ProtectTargetDis = 100f;

	private bool IsUpdate;

	public NormalMoveAction(AActor Own)
		: base(Own)
	{
		PathList = new List<FVector>();
	}

	public override void StartExecute(AIActionElem ActionElem)
	{
		base.StartExecute(ActionElem);
		TargetLoc = ActionElemList[0].InputDataList[0].DataList[0].GetLocation();
		IsUpdate = !ActionElemList[0].PreExeCache.FilterDesc.Tags.Contains(EActionTagType.DontUpdate);
		PathList = AIFuncLibForCS.FindPathToLocation(Own, BGUFuncLibActorTransformCS.BGUGetActorLocation(Own), TargetLoc);
		State = AIActionProcessState.UnAvailable;
	}

	public override void ExecuteTick(float DeltaTime)
	{
		if (ActionElemList.Count == 0)
		{
			return;
		}
		if (IsUpdate)
		{
			FVector location = ActionElemList[0].InputDataList[0].DataList[0].GetLocation();
			if (FVector.Dist(TargetLoc, location) > ProtectTargetDis)
			{
				TargetLoc = location;
				PathList = AIFuncLibForCS.FindPathToLocation(Own, BGUFuncLibActorTransformCS.BGUGetActorLocation(Own), TargetLoc);
			}
		}
		if (PathMove())
		{
			Finish();
		}
	}

	private bool PathMove()
	{
		if (FVector.Dist2D(TargetLoc, BGUFuncLibActorTransformCS.BGUGetActorLocation(Own)) < ProtectReachDis)
		{
			return true;
		}
		if (BGUFunctionLibraryCS.BGUHasUnitState(Own, EBGUUnitState.Beatback))
		{
			return true;
		}
		while (PathList.Count != 0)
		{
			FVector direction = PathList[0] - BGUFuncLibActorTransformCS.BGUGetActorLocation(Own);
			if (direction.Size2D() < ProtectReachDis)
			{
				PathList.RemoveAt(0);
				continue;
			}
			direction.Z = 0f;
			BUS_EventCollectionCS.Get(Own as ACharacter).Evt_SetMovementInput.Invoke(direction, 100f, BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(Own));
			return false;
		}
		return true;
	}

	public void Finish()
	{
		BUS_EventCollectionCS.Get(Own).Evt_OnActionExeFinish.Invoke(ActionElemList[0]);
		State = AIActionProcessState.Available;
		ActionElemList.RemoveAt(0);
	}

	public override bool Abort(AIActionElem ActionElem)
	{
		if (State == AIActionProcessState.Available)
		{
			return true;
		}
		if (ActionElemList[0] != ActionElem)
		{
			return true;
		}
		State = AIActionProcessState.Available;
		ActionElemList.RemoveAt(0);
		return true;
	}

	public override AIActionElem GetCurAction()
	{
		if (State == AIActionProcessState.Available)
		{
			return null;
		}
		return ActionElemList[0];
	}

	public override bool CheckAbortByProcess(ActionProcessBase OtherProcess)
	{
		if (!IsProcessing())
		{
			return false;
		}
		NormalMoveAction obj = OtherProcess as NormalMoveAction;
		NormalSkillCastAction normalSkillCastAction = OtherProcess as NormalSkillCastAction;
		if (obj != null)
		{
			return true;
		}
		if (normalSkillCastAction != null && !BGUFunctionLibraryCS.BGUHasUnitState(Own, EBGUUnitState.BMMoveAttack))
		{
			return true;
		}
		return false;
	}

	public override bool CheckExecutable(FUStAIActionFilter Filter, ActionPreExeCache PreExeCache)
	{
		if (BGUFunctionLibraryCS.BGUHasUnitState(Own, EBGUUnitState.Dead) || BGUFunctionLibraryCS.BGUHasUnitSimpleState(Own, EBGUSimpleState.PendingDeathInAnimationSyncing))
		{
			return false;
		}
		if (BGUFunctionLibraryCS.BGUHasUnitState(Own, EBGUUnitState.Attacking) && !BGUFunctionLibraryCS.BGUHasUnitState(Own, EBGUUnitState.BMMoveAttack))
		{
			return false;
		}
		if (BGUFunctionLibraryCS.BGUHasUnitState(Own, EBGUUnitState.Beatback))
		{
			return false;
		}
		return true;
	}
}
