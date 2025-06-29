using System;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_TortoiseMoveMgrComp")]
internal class BUS_TortoiseMoveMgrComp : UActorCompBaseUObj
{
	private b1.BUC_TortoiseMoveMgrActorData LevelMoveData;

	private float LastRollOffset;

	private float LastPitchOffset;

	public override void OnAttach()
	{
		LevelMoveData = RequireWritableData<b1.BUC_TortoiseMoveMgrActorData>();
		base.BGSEventCollection.Evt_BGS_StartTortoiseFakeMove += new Del_BGS_StartTortoiseFakeMove(StartTortoiseFakeMove);
		base.BGSEventCollection.Evt_BGS_StopTortoiseFakeMove += new Del_BGS_Void(StopTortoiseFakeMove);
	}

	private void StartTortoiseFakeMove(UAnimSequence InverseAnim, bool bIsLoop)
	{
		LevelMoveData.IsOnInverseAnim = true;
		LevelMoveData.ShouldStopInverseAnim = false;
		LevelMoveData.InverseAnimationSequence = InverseAnim;
		LevelMoveData.bInverseAnimLoop = bIsLoop;
		LevelMoveData.AnimReversed = false;
		LevelMoveData.AnimCurrentTime = 0f;
		LevelMoveData.AnimLastTime = 0f;
	}

	private void CalCurrentTime(float DeltaTime)
	{
		if (LevelMoveData.ShouldStopInverseAnim)
		{
			LevelMoveData.AnimCurrentTime = 0f;
			return;
		}
		LevelMoveData.AnimLastTime = LevelMoveData.AnimCurrentTime;
		if (!LevelMoveData.AnimReversed)
		{
			if (LevelMoveData.AnimCurrentTime + DeltaTime > LevelMoveData.InverseAnimationSequence.SequenceLength)
			{
				LevelMoveData.AnimCurrentTime = 2f * LevelMoveData.InverseAnimationSequence.SequenceLength - (LevelMoveData.AnimCurrentTime + DeltaTime);
				LevelMoveData.AnimReversed = true;
			}
			else
			{
				LevelMoveData.AnimCurrentTime += DeltaTime;
			}
		}
		else if (LevelMoveData.AnimCurrentTime - DeltaTime < 0f)
		{
			if (!LevelMoveData.bInverseAnimLoop)
			{
				LevelMoveData.ShouldStopInverseAnim = true;
				LevelMoveData.AnimCurrentTime = 0f;
			}
			else
			{
				LevelMoveData.AnimCurrentTime = DeltaTime - LevelMoveData.AnimCurrentTime;
				LevelMoveData.AnimReversed = false;
			}
		}
		else
		{
			LevelMoveData.AnimCurrentTime -= DeltaTime;
		}
	}

	private void EnvironmentFakeMove(float DeltaTime)
	{
		FTransform animBoneTransformFromLastTick = BGUFunctionLibraryCS.GetAnimBoneTransformFromLastTick(LevelMoveData.InverseAnimationSequence, LevelMoveData.AnimCurrentTime, LevelMoveData.AnimLastTime, LevelMoveData.LevelMoveAttachedBone);
		foreach (FName fakeMoveLevel in LevelMoveData.FakeMoveLevels)
		{
			BGUFunctionLibraryCS.RotateLevelRelativeToParentTransform(LevelMoveData.Tortoise, fakeMoveLevel, BGUFuncLibActorTransformCS.BGUGetActorTransform(LevelMoveData.Tortoise), animBoneTransformFromLastTick.InvertTransform());
		}
	}

	private void InverseCamera()
	{
		FTransform animBoneTransformFromLastTick = BGUFunctionLibraryCS.GetAnimBoneTransformFromLastTick(LevelMoveData.InverseAnimationSequence, LevelMoveData.AnimCurrentTime, 0f, LevelMoveData.LevelMoveAttachedBone);
		BGUPlayerCharacterCS bGUPlayerCharacterCS = UBGUFunctionLibrary.GetPlayerCharacter(LevelMoveData.Tortoise) as BGUPlayerCharacterCS;
		if (!(bGUPlayerCharacterCS == null))
		{
			UCameraComponent followCamera = bGUPlayerCharacterCS.GetFollowCamera();
			FTransform worldTransform = followCamera.GetWorldTransform();
			worldTransform.SetRotation(FQuat.Identity);
			FRotator fRotator = BGUFunctionLibraryCS.CalTransformRelativeToParentTransformOffset(worldTransform, BGUFuncLibActorTransformCS.BGUGetActorTransform(LevelMoveData.Tortoise), animBoneTransformFromLastTick).InvertTransform().Rotator();
			FRotator worldRotation = followCamera.GetWorldRotation();
			float val = MathLib.DegreesToRadians(UGSE_EngineFuncLib.GetFirstLocalPlayerController(this).GetControlRotation().Yaw);
			float num = MathLib.Sin(val);
			float num2 = MathLib.Cos(val);
			float num3 = num * fRotator.Pitch + num2 * fRotator.Roll;
			float num4 = num * fRotator.Roll + num2 * fRotator.Pitch;
			float num5 = worldRotation.Roll + num3 - LastRollOffset;
			float num6 = worldRotation.Pitch + num4 - LastPitchOffset;
			LastRollOffset = num3;
			LastPitchOffset = num4;
			followCamera.SetWorldRotation(new FRotator(num6, worldRotation.Yaw, num5), bSweep: false, out var _, bTeleport: true);
		}
	}

	public void StopTortoiseFakeMove()
	{
		LevelMoveData.ShouldStopInverseAnim = true;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!(LevelMoveData.Tortoise == null) && LevelMoveData.IsOnInverseAnim)
		{
			CalCurrentTime(DeltaTime);
			EnvironmentFakeMove(DeltaTime);
			InverseCamera();
			if (LevelMoveData.ShouldStopInverseAnim)
			{
				LevelMoveData.IsOnInverseAnim = false;
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_TortoiseMoveMgrComp");
	}

	static BUS_TortoiseMoveMgrComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_TortoiseMoveMgrComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_TortoiseMoveMgrComp));
	}
}
