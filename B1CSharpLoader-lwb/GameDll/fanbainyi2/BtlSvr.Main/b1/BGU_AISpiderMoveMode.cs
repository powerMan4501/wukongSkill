using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGU_AISpiderMoveMode : BUC_MoveModeBase
{
	private IBGC_SpiderNavigationData SpiderNavigationData;

	public override void Init(BUS_MovementSystem Parent)
	{
		base.Init(Parent);
		SpiderNavigationData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_SpiderNavigationData, BGC_SpiderNavigationData>(OwnerCharacter);
	}

	protected override void OnUpdate(float DeltaTime)
	{
		if (MoveSys.MovementData.IsSpiderMoveReached)
		{
			return;
		}
		BUS_GSEventCollection evtCollection = EvtCollection;
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerCharacter);
		if ((MoveSys.MovementData.AISpiderMoveTargetPos - fVector).Size() < MoveSys.MovementData.AISpiderMoveAcceptableRadius)
		{
			MoveSys.MovementData.IsSpiderMoveReached = true;
			return;
		}
		MoveSys.MovementData.AISpiderMovePath = SpiderNavigationData.TryFindPath(fVector, ESpiderNavPositionType.Wall, MoveSys.MovementData.AISpiderMoveTargetPos, MoveSys.MovementData.AISpiderMoveTargetNormal, MoveSys.MovementData.AISpiderMoveTargetPosType);
		List<FSpiderNavPointInfo> aISpiderMovePath = MoveSys.MovementData.AISpiderMovePath;
		if (aISpiderMovePath.Count == 0)
		{
			return;
		}
		while (aISpiderMovePath.Count > 0 && (aISpiderMovePath[0].PointLocation - fVector).Size() < MoveSys.MovementData.AISpiderMoveAcceptableRadius)
		{
			aISpiderMovePath.RemoveAt(0);
		}
		if (aISpiderMovePath.Count == 2 && (fVector - aISpiderMovePath[1].PointLocation).Size() < (aISpiderMovePath[0].PointLocation - aISpiderMovePath[1].PointLocation).Size() + (aISpiderMovePath[0].PointLocation - fVector).Size())
		{
			aISpiderMovePath.RemoveAt(0);
		}
		if (aISpiderMovePath.Count == 0)
		{
			return;
		}
		FVector translation = aISpiderMovePath[0].PointLocation - fVector;
		FTransform fTransform = new FTransform(FQuat.FindBetween(aISpiderMovePath[0].PointNormal, FVector.UpVector));
		FVector direction = (new FTransform(translation) * fTransform).GetTranslation().ProjectVectorOnToPlane(FVector.UpVector);
		direction.Normalize();
		evtCollection.Evt_SetMovementInput.Invoke(direction, 1f, BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(OwnerCharacter));
		if (GSGameplayCVar.CVar_DrawDebugSpiderNavigation.GetValueInGameThread() != 0)
		{
			for (int i = 0; i < aISpiderMovePath.Count - 1; i++)
			{
				USystemLibrary.DrawDebugLine(OwnerCharacter, aISpiderMovePath[i].PointLocation, aISpiderMovePath[i + 1].PointLocation, FLinearColor.Green);
			}
			USystemLibrary.DrawDebugLine(OwnerCharacter, aISpiderMovePath[0].PointLocation, fVector, FLinearColor.Green);
			USystemLibrary.DrawDebugLine(OwnerCharacter, aISpiderMovePath[aISpiderMovePath.Count - 1].PointLocation, MoveSys.MovementData.AISpiderMoveTargetPos, FLinearColor.Green);
		}
	}

	protected override void OnEnd()
	{
		base.OnEnd();
	}

	public override EBGUMoveMode GetMoveMode()
	{
		return EBGUMoveMode.AISpiderMove;
	}
}
