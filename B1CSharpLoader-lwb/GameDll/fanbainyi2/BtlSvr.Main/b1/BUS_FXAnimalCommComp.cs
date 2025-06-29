using System;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_FXAnimalCommComp")]
public class BUS_FXAnimalCommComp : UActorCompBaseUObj
{
	private static FName PARAMETER_NAME_ESCAPE;

	private static FName PARAMETER_NAME_DISAPPEAR;

	private BUC_FXAnimalCommData CommData;

	private IBGC_LocalPlayerSharedData LocalPlayerSharedData;

	private static bool StartEscape_IsValid;

	private static IntPtr StartEscape_FunctionAddress;

	private static int StartEscape_ParamsSize;

	private static bool StartEscape_OverlappedComponent_IsValid;

	private static int StartEscape_OverlappedComponent_Offset;

	private static bool StartEscape_OtherActor_IsValid;

	private static int StartEscape_OtherActor_Offset;

	private static bool StartEscape_OtherComp_IsValid;

	private static int StartEscape_OtherComp_Offset;

	private static bool StartEscape_OtherBodyIndex_IsValid;

	private static int StartEscape_OtherBodyIndex_Offset;

	private static bool StartEscape_bFromSweep_IsValid;

	private static int StartEscape_bFromSweep_Offset;

	private static FFieldAddress StartEscape_bFromSweep_PropertyAddress;

	private static bool StartEscape_SweepResult_IsValid;

	private static int StartEscape_SweepResult_Offset;

	private static FFieldAddress StartEscape_SweepResult_PropertyAddress;

	public override void OnAttach()
	{
		base.OnAttach();
		CommData = RequireWritableData<BUC_FXAnimalCommData>();
		LocalPlayerSharedData = RequireReadOnlyGameStateData<IBGC_LocalPlayerSharedData, BGC_LocalPlayerSharedData>();
		base.BUSEventCollection.Evt_FXAnimalBeginMoveWithSpline += new Del_FXAnimalBeginMoveWithSplined(BeginMoveWithSpline);
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		BGUFXAnimalActor bGUFXAnimalActor = Owner as BGUFXAnimalActor;
		if (bGUFXAnimalActor != null)
		{
			bGUFXAnimalActor.TriggerBox.SetCollisionEnabled(ECollisionEnabled.NoCollision);
			CommData.bCollisionEnable = false;
			UBGUFunctionLibraryForCS.BGUBindOnComponentBeginOverlapEvent(bGUFXAnimalActor.TriggerBox, this, B1GlobalFNames.StartEscape);
			bGUFXAnimalActor.TriggerBox.SetGenerateOverlapEvents(bInGenerateOverlapEvents: true);
		}
		BeginMove();
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		UpdateLifeTime(DeltaTime);
		UpdateMove(DeltaTime);
		UpdateEnableCollision(DeltaTime);
	}

	private void UpdateLifeTime(float DeltaTime)
	{
		switch (CommData.Phase)
		{
		case EFXAnimalPhase.Normal:
			CommData.Age_Normal += DeltaTime;
			if (CommData.Age_Normal >= CommData.Time_LifeTime)
			{
				EnterPhase_Disappear();
			}
			break;
		case EFXAnimalPhase.Escape:
			CommData.Age_Escape += DeltaTime;
			if (CommData.Age_Escape >= CommData.Time_EscapeToDisappear)
			{
				EnterPhase_Disappear();
			}
			break;
		case EFXAnimalPhase.Disappear:
			CommData.Age_Disappear += DeltaTime;
			if (CommData.Age_Disappear >= CommData.Time_DisappearToDestory)
			{
				Owner.DestroyActor();
			}
			break;
		}
	}

	private void UpdateMove(float DeltaTime)
	{
		if (CommData.bMoveOver)
		{
			return;
		}
		CommData.CurSpeed = GetCurSpeed(DeltaTime);
		if (CommData.CurSpeed <= 0f)
		{
			return;
		}
		switch (CommData.MoveType)
		{
		case EFXAnimalMoveType.NormalMove:
		{
			float num2 = CommData.CurSpeed * DeltaTime;
			Owner.AddActorWorldOffset(Owner.GetActorForwardVector() * num2, bSweep: false, out var _, bTeleport: true);
			break;
		}
		case EFXAnimalMoveType.SplineMove:
			if (!CommData.SplineComp.IsNullOrDestroyed())
			{
				float num = CommData.CurSpeed * DeltaTime;
				float splineLength = CommData.SplineComp.GetSplineLength();
				if (CommData.SplineMove_Distance >= splineLength)
				{
					CommData.bMoveOver = true;
					EnterPhase_Disappear();
					break;
				}
				CommData.SplineMove_Distance = MathLib.Clamp(CommData.SplineMove_Distance + num, 0f, splineLength);
				FVector locationAtDistanceAlongSpline = CommData.SplineComp.GetLocationAtDistanceAlongSpline(CommData.SplineMove_Distance, ESplineCoordinateSpace.World);
				Owner.SetActorLocation(locationAtDistanceAlongSpline, bSweep: false, out var _, bTeleport: false);
				FRotator rotationAtDistanceAlongSpline = CommData.SplineComp.GetRotationAtDistanceAlongSpline(CommData.SplineMove_Distance, ESplineCoordinateSpace.World);
				Owner.SetActorRotation(rotationAtDistanceAlongSpline, bTeleportPhysics: false);
			}
			break;
		}
	}

	private void UpdateEnableCollision(float DeltaTime)
	{
		CommData.DistToPlayerCheck_RemainTime -= DeltaTime;
		if (!(CommData.DistToPlayerCheck_RemainTime <= 0f))
		{
			return;
		}
		BGUFXAnimalActor bGUFXAnimalActor = Owner as BGUFXAnimalActor;
		if (!bGUFXAnimalActor.IsNullOrDestroyed())
		{
			float num = FVector.Dist(BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner), LocalPlayerSharedData.CachedLocalPlayerLocation);
			if (CommData.bCollisionEnable && num >= 15000f)
			{
				bGUFXAnimalActor.TriggerBox.SetCollisionEnabled(ECollisionEnabled.NoCollision);
				CommData.bCollisionEnable = false;
			}
			else if (!CommData.bCollisionEnable && num <= 10000f)
			{
				bGUFXAnimalActor.TriggerBox.SetCollisionEnabled(ECollisionEnabled.QueryOnly);
				CommData.bCollisionEnable = true;
			}
			CommData.DistToPlayerCheck_RemainTime = CommData.DistToPlayerCheck_Interval;
		}
	}

	private float GetCurSpeed(float DeltaTime)
	{
		if (CommData.SpeedType == EFXAnimalSpeedType.Normal)
		{
			return CommData.MoveSpeed_ByConfig;
		}
		return 0f;
	}

	private void EnterPhase_Escape()
	{
		CommData.Phase = EFXAnimalPhase.Escape;
		BGUFXAnimalActor bGUFXAnimalActor = Owner as BGUFXAnimalActor;
		if (!(bGUFXAnimalActor == null))
		{
			bGUFXAnimalActor.NiagaraComp.SetBoolParameter(PARAMETER_NAME_ESCAPE, Param: true);
		}
	}

	private void EnterPhase_Disappear()
	{
		CommData.Phase = EFXAnimalPhase.Disappear;
		BGUFXAnimalActor bGUFXAnimalActor = Owner as BGUFXAnimalActor;
		if (!(bGUFXAnimalActor == null))
		{
			bGUFXAnimalActor.NiagaraComp.SetBoolParameter(PARAMETER_NAME_DISAPPEAR, Param: true);
			base.BGSEventCollection.Evt_BGS_OnFXAnimalDisappear.Invoke(Owner);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_FXAnimalCommComp:StartEscape")]
	private void StartEscape(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult)
	{
		if (OtherActor is BGUPlayerCharacterCS && CommData.Phase == EFXAnimalPhase.Normal)
		{
			EnterPhase_Escape();
		}
	}

	private void BeginMove()
	{
		_ = CommData.MoveType;
		_ = 1;
	}

	private void BeginMoveWithSpline(USplineComponent SplineComp)
	{
		if (!(SplineComp == null))
		{
			CommData.MoveType = EFXAnimalMoveType.SplineMove;
			CommData.SplineComp = SplineComp;
		}
	}

	static BUS_FXAnimalCommComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_FXAnimalCommComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_FXAnimalCommComp));
		PARAMETER_NAME_ESCAPE = B1GlobalFNames.User_Escape;
		PARAMETER_NAME_DISAPPEAR = B1GlobalFNames.User_BeginDisapper;
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_FXAnimalCommComp:StartEscape")]
	private static void StartEscape__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_FXAnimalCommComp bUS_FXAnimalCommComp = GCHelper.Find<BUS_FXAnimalCommComp>(obj);
		UPrimitiveComponent overlappedComponent = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, StartEscape_OverlappedComponent_Offset));
		AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, StartEscape_OtherActor_Offset));
		UPrimitiveComponent otherComp = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, StartEscape_OtherComp_Offset));
		int otherBodyIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, StartEscape_OtherBodyIndex_Offset));
		bool bFromSweep = BoolMarshaler.FromNative(IntPtr.Add(buffer, StartEscape_bFromSweep_Offset), 0, StartEscape_bFromSweep_PropertyAddress.Address);
		FHitResult sweepResult = FHitResult.FromNative(IntPtr.Add(buffer, StartEscape_SweepResult_Offset));
		bUS_FXAnimalCommComp.StartEscape(overlappedComponent, otherActor, otherComp, otherBodyIndex, bFromSweep, sweepResult);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUS_FXAnimalCommComp");
		StartEscape_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "StartEscape");
		StartEscape_ParamsSize = NativeReflection.GetFunctionParamsSize(StartEscape_FunctionAddress);
		StartEscape_OverlappedComponent_Offset = NativeReflection.GetPropertyOffset(StartEscape_FunctionAddress, "OverlappedComponent");
		StartEscape_OverlappedComponent_IsValid = NativeReflection.ValidatePropertyClass(StartEscape_FunctionAddress, "OverlappedComponent", Classes.FObjectProperty);
		StartEscape_OtherActor_Offset = NativeReflection.GetPropertyOffset(StartEscape_FunctionAddress, "OtherActor");
		StartEscape_OtherActor_IsValid = NativeReflection.ValidatePropertyClass(StartEscape_FunctionAddress, "OtherActor", Classes.FObjectProperty);
		StartEscape_OtherComp_Offset = NativeReflection.GetPropertyOffset(StartEscape_FunctionAddress, "OtherComp");
		StartEscape_OtherComp_IsValid = NativeReflection.ValidatePropertyClass(StartEscape_FunctionAddress, "OtherComp", Classes.FObjectProperty);
		StartEscape_OtherBodyIndex_Offset = NativeReflection.GetPropertyOffset(StartEscape_FunctionAddress, "OtherBodyIndex");
		StartEscape_OtherBodyIndex_IsValid = NativeReflection.ValidatePropertyClass(StartEscape_FunctionAddress, "OtherBodyIndex", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref StartEscape_bFromSweep_PropertyAddress, StartEscape_FunctionAddress, "bFromSweep");
		StartEscape_bFromSweep_Offset = NativeReflection.GetPropertyOffset(StartEscape_FunctionAddress, "bFromSweep");
		StartEscape_bFromSweep_IsValid = NativeReflection.ValidatePropertyClass(StartEscape_FunctionAddress, "bFromSweep", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref StartEscape_SweepResult_PropertyAddress, StartEscape_FunctionAddress, "SweepResult");
		StartEscape_SweepResult_Offset = NativeReflection.GetPropertyOffset(StartEscape_FunctionAddress, "SweepResult");
		StartEscape_SweepResult_IsValid = NativeReflection.ValidatePropertyClass(StartEscape_FunctionAddress, "SweepResult", Classes.FStructProperty);
		StartEscape_IsValid = StartEscape_FunctionAddress != IntPtr.Zero && StartEscape_OverlappedComponent_IsValid && StartEscape_OtherActor_IsValid && StartEscape_OtherComp_IsValid && StartEscape_OtherBodyIndex_IsValid && StartEscape_bFromSweep_IsValid && StartEscape_SweepResult_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_FXAnimalCommComp:StartEscape", StartEscape_IsValid);
	}
}
