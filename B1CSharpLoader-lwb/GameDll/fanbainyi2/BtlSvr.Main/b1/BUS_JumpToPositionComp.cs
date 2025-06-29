using System;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_JumpToPositionComp : UActorCompBaseCS
{
	private BUC_JumpToPositionData JumpToPositionData;

	public override void OnAttach()
	{
		JumpToPositionData = RequireWritableData<BUC_JumpToPositionData>();
		base.BUSEventCollection.Evt_TriggerJumpToPosition += new Del_TriggerJumpToPosition(OnTriggerJumpToPosition);
	}

	public override void OnBeginPlay()
	{
		SetCanTick(Val: false);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		JumpToPositionDuration(DeltaTime);
	}

	private void OnTriggerJumpToPosition(EBGUJumpTargetType JumpTarget, float Height, bool TargetAddCapsuleHalfHeight, bool CalibrationTrans, bool bResetSceneItemOnFinish, float TotalDuration)
	{
		if (OwnerAsCharacterCS == null)
		{
			return;
		}
		bool flag = false;
		JumpToPositionData.Height = Height;
		JumpToPositionData.CalibrationTrans = CalibrationTrans;
		JumpToPositionData.bResetSceneItemOnFinish = bResetSceneItemOnFinish;
		JumpToPositionData.TotalDuration = TotalDuration;
		JumpToPositionData.CurTime = 0f;
		JumpToPositionData.OriginLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerAsCharacterCS);
		switch (JumpTarget)
		{
		case EBGUJumpTargetType.CurrentTarget:
		{
			AActor aActor = BGUFunctionLibraryCS.BGUGetTarget(OwnerAsCharacterCS);
			if (aActor != null)
			{
				JumpToPositionData.TargetLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor);
				flag = true;
			}
			break;
		}
		case EBGUJumpTargetType.SceneItem:
		{
			BUC_SceneItemData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_SceneItemData>(OwnerAsCharacterCS);
			if (readOnlyData != null)
			{
				BGUSceneItemBase sceneItemCatch = readOnlyData.SceneItemCatch;
				if (sceneItemCatch != null)
				{
					BGU_DataUtil.GetReadOnlyData<BUC_SceneItemCommData>(sceneItemCatch);
					JumpToPositionData.TargetLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(sceneItemCatch);
					JumpToPositionData.TargetRotation = BGUFuncLibActorTransformCS.BGUGetActorRotation(sceneItemCatch);
					flag = true;
				}
			}
			break;
		}
		}
		if (TargetAddCapsuleHalfHeight)
		{
			JumpToPositionData.TargetLocation.Z += OwnerAsCharacterCS.CapsuleComponent.GetScaledCapsuleHalfHeight();
		}
		if (flag)
		{
			float num = FVector.DistXY(JumpToPositionData.TargetLocation, JumpToPositionData.OriginLocation);
			float num2 = JumpToPositionData.TargetLocation.Z - JumpToPositionData.OriginLocation.Z;
			if (num2 == 0f)
			{
				JumpToPositionData.ZMaxVarDis = num / 2f;
			}
			else if (num2 > 0f)
			{
				JumpToPositionData.ZMaxVarDis = (float)((double)num - Math.Sqrt(num * num - num2 * num * num / (num2 + Height))) / num2 * (num2 + Height);
			}
			else
			{
				JumpToPositionData.ZMaxVarDis = (float)((double)(num * Height) - Math.Sqrt(num * num * Height * Height - num * num * Height * num2)) / num2;
			}
			JumpToPositionData.CurrentJumping = true;
			SetCanTick(Val: true);
		}
		else if (bResetSceneItemOnFinish)
		{
			BUS_EventCollectionCS.Get(OwnerAsCharacterCS)?.Evt_RemoveCatchedSceneItemAndReset.Invoke();
		}
	}

	private void JumpToPositionDuration(float DeltaTime)
	{
		if (OwnerAsCharacterCS == null || !JumpToPositionData.CurrentJumping)
		{
			return;
		}
		if (JumpToPositionData.CurTime < JumpToPositionData.TotalDuration)
		{
			float num = FVector.DistXY(JumpToPositionData.OriginLocation, JumpToPositionData.TargetLocation);
			float num2 = JumpToPositionData.TargetLocation.Z - JumpToPositionData.OriginLocation.Z;
			float num3 = JumpToPositionData.CurTime / JumpToPositionData.TotalDuration * num;
			FVector fVector = (JumpToPositionData.TargetLocation - JumpToPositionData.OriginLocation) * JumpToPositionData.CurTime / JumpToPositionData.TotalDuration;
			float num4 = 0f;
			num4 = ((num2 > 0f) ? ((0f - (JumpToPositionData.Height + num2)) / (JumpToPositionData.ZMaxVarDis * JumpToPositionData.ZMaxVarDis) * (num3 - JumpToPositionData.ZMaxVarDis) * (num3 - JumpToPositionData.ZMaxVarDis) + JumpToPositionData.Height + num2) : ((JumpToPositionData.ZMaxVarDis != 0f) ? ((0f - JumpToPositionData.Height) / (JumpToPositionData.ZMaxVarDis * JumpToPositionData.ZMaxVarDis) * (num3 - JumpToPositionData.ZMaxVarDis) * (num3 - JumpToPositionData.ZMaxVarDis) + JumpToPositionData.Height) : (num2 / (num * num) * (JumpToPositionData.CurTime / JumpToPositionData.TotalDuration * num) * (JumpToPositionData.CurTime / JumpToPositionData.TotalDuration * num))));
			fVector.Z = num4;
			OwnerAsCharacterCS.SetActorLocation(JumpToPositionData.OriginLocation + fVector, bSweep: false, out var _, bTeleport: true);
			JumpToPositionData.CurTime += DeltaTime;
			return;
		}
		JumpToPositionData.CurrentJumping = false;
		if (JumpToPositionData.CalibrationTrans)
		{
			FRotator worldRotation = OwnerAsCharacterCS.RootComponent.GetWorldRotation();
			worldRotation.Yaw = JumpToPositionData.TargetRotation.Yaw;
			OwnerAsCharacterCS.RootComponent.SetWorldLocationAndRotation(JumpToPositionData.TargetLocation, worldRotation, bSweep: false, out var _, bTeleport: false);
		}
		if (JumpToPositionData.bResetSceneItemOnFinish)
		{
			BUS_EventCollectionCS.Get(OwnerAsCharacterCS)?.Evt_RemoveCatchedSceneItemAndReset.Invoke();
		}
		SetCanTick(Val: false);
	}
}
