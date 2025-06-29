using System;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_NeutralFXAnimalSpawnLogicComp")]
internal class BUS_NeutralFXAnimalSpawnLogicComp : UActorCompBaseUObj
{
	private static string PARAMETER_NAME_WAKEUP;

	private b1.BUC_NeutralFXAnimalSpawnData SpawnData;

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

	private static bool StartEscapeWitchSpdCheck_IsValid;

	private static IntPtr StartEscapeWitchSpdCheck_FunctionAddress;

	private static int StartEscapeWitchSpdCheck_ParamsSize;

	private static bool StartEscapeWitchSpdCheck_OverlappedComponent_IsValid;

	private static int StartEscapeWitchSpdCheck_OverlappedComponent_Offset;

	private static bool StartEscapeWitchSpdCheck_OtherActor_IsValid;

	private static int StartEscapeWitchSpdCheck_OtherActor_Offset;

	private static bool StartEscapeWitchSpdCheck_OtherComp_IsValid;

	private static int StartEscapeWitchSpdCheck_OtherComp_Offset;

	private static bool StartEscapeWitchSpdCheck_OtherBodyIndex_IsValid;

	private static int StartEscapeWitchSpdCheck_OtherBodyIndex_Offset;

	private static bool StartEscapeWitchSpdCheck_bFromSweep_IsValid;

	private static int StartEscapeWitchSpdCheck_bFromSweep_Offset;

	private static FFieldAddress StartEscapeWitchSpdCheck_bFromSweep_PropertyAddress;

	private static bool StartEscapeWitchSpdCheck_SweepResult_IsValid;

	private static int StartEscapeWitchSpdCheck_SweepResult_Offset;

	private static FFieldAddress StartEscapeWitchSpdCheck_SweepResult_PropertyAddress;

	public override void OnAttach()
	{
		SpawnData = RequireWritableData<b1.BUC_NeutralFXAnimalSpawnData>();
		BGUNeutralFXAnimalSpawnPoint bGUNeutralFXAnimalSpawnPoint = Owner as BGUNeutralFXAnimalSpawnPoint;
		if (!(bGUNeutralFXAnimalSpawnPoint == null))
		{
			UBGUFunctionLibraryForCS.BGUBindOnComponentBeginOverlapEvent(bGUNeutralFXAnimalSpawnPoint.TriggerBox, this, B1GlobalFNames.StartEscape);
			UBGUFunctionLibraryForCS.BGUBindOnComponentBeginOverlapEvent(bGUNeutralFXAnimalSpawnPoint.TriggerBox_OutSide, this, B1GlobalFNames.StartEscapeWitchSpdCheck);
			base.BUSEventCollection.Evt_NeutralFXAnimalSpawnAreaInitSize += new Del_Void_FVector(InitSize);
			base.BUSEventCollection.Evt_DestroyNeutralFXAnimalSpawnner += new Del_Void(DestroySpawnner);
		}
	}

	public override void OnBeginPlay()
	{
		if (SpawnData != null && SpawnData.SpawnMomentType == EFXAnimalSpawnMomentType.SpawnAtBegin)
		{
			SpawnFXAnimal();
		}
		SetGenerateOverlap(bActive: true);
	}

	private void InitSize(FVector TargetBounds)
	{
		BGUNeutralFXAnimalSpawnPoint bGUNeutralFXAnimalSpawnPoint = Owner as BGUNeutralFXAnimalSpawnPoint;
		if (!(bGUNeutralFXAnimalSpawnPoint == null))
		{
			bGUNeutralFXAnimalSpawnPoint.TriggerBox.SetBoxExtent(TargetBounds);
			bGUNeutralFXAnimalSpawnPoint.TriggerBox_OutSide.SetBoxExtent(TargetBounds + new FVector(1.0, 1.0, 0.5) * SpawnData.Outside_Dist);
			bGUNeutralFXAnimalSpawnPoint.TriggerBox_OutSide.SetRelativeLocation(FVector.UpVector * SpawnData.Outside_Dist * 0.5, bSweep: false, out var _, bTeleport: false);
		}
	}

	private bool SpawnFXAnimal()
	{
		if (SpawnData.RandomNiagaraTemplateList.Count < 1)
		{
			return false;
		}
		UNiagaraSystem uNiagaraSystem = SpawnData.RandomNiagaraTemplateList[FMath.RandRange(0, SpawnData.RandomNiagaraTemplateList.Count - 1)];
		if (uNiagaraSystem != null)
		{
			SpawnData.NGComp = UNiagaraFunctionLibrary.SpawnSystemAtLocation(Owner, uNiagaraSystem, Owner.GetActorLocation(), Owner.GetActorRotation(), FVector.OneVector, bAutoDestroy: true, bAutoActivate: true, ENCPoolMethod.ManualRelease, bPreCullCheck: false);
		}
		return SpawnData.NGComp != null;
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_NeutralFXAnimalSpawnLogicComp:StartEscape")]
	private void StartEscape(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult)
	{
		if (OtherActor is BGUPlayerCharacterCS)
		{
			StartEscape_Impl();
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_NeutralFXAnimalSpawnLogicComp:StartEscapeWitchSpdCheck")]
	private void StartEscapeWitchSpdCheck(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult)
	{
		if (OtherActor is BGUPlayerCharacterCS && !(OtherActor.GetVelocity().Size() < SpawnData.Outside_Spd_Threshold))
		{
			StartEscape_Impl();
		}
	}

	private void StartEscape_Impl()
	{
		SetGenerateOverlap(bActive: false);
		if (SpawnData != null && SpawnData.SpawnMomentType == EFXAnimalSpawnMomentType.SpawnAtEscape)
		{
			SpawnFXAnimal();
		}
		if (SpawnData.NGComp != null)
		{
			SpawnData.NGComp.SetNiagaraVariableBool(PARAMETER_NAME_WAKEUP, InValue: true);
		}
		SpawnData.DestroyTimer_FX = SpawnData.DestroyTime_FX;
	}

	private void SetGenerateOverlap(bool bActive)
	{
		BGUNeutralFXAnimalSpawnPoint bGUNeutralFXAnimalSpawnPoint = Owner as BGUNeutralFXAnimalSpawnPoint;
		if (bGUNeutralFXAnimalSpawnPoint == null)
		{
			return;
		}
		if (bActive)
		{
			bGUNeutralFXAnimalSpawnPoint.TriggerBox.SetGenerateOverlapEvents(bInGenerateOverlapEvents: true);
			if (SpawnData.Outside_Spd_Threshold > 0f)
			{
				bGUNeutralFXAnimalSpawnPoint.TriggerBox_OutSide.SetGenerateOverlapEvents(bInGenerateOverlapEvents: true);
			}
		}
		else
		{
			bGUNeutralFXAnimalSpawnPoint.TriggerBox.SetGenerateOverlapEvents(bInGenerateOverlapEvents: false);
			bGUNeutralFXAnimalSpawnPoint.TriggerBox_OutSide.SetGenerateOverlapEvents(bInGenerateOverlapEvents: false);
		}
	}

	private void DestroyFXTimeTick(float DeltaTime)
	{
		if (SpawnData.DestroyTimer_FX >= 0f)
		{
			SpawnData.DestroyTimer_FX -= DeltaTime;
			if (SpawnData.DestroyTimer_FX <= 0f)
			{
				OnEscapeEnded();
			}
		}
	}

	private void DelayDestroySpawnnerTimeTick(float DeltaTime)
	{
		if (SpawnData.bActorPendingDestroy)
		{
			SpawnData.DelayDestroyTime_Spawnner -= DeltaTime;
			if (SpawnData.DelayDestroyTime_Spawnner <= 0f)
			{
				BGU_UnrealWorldUtil.DestroyActor(Owner);
			}
		}
	}

	private void OnEscapeEnded()
	{
		ReleaseNGComp();
		PendingDestroy();
	}

	private void PendingDestroy()
	{
		SpawnData.bActorPendingDestroy = true;
	}

	private void ReleaseNGComp()
	{
		if (SpawnData.NGComp != null)
		{
			SpawnData.NGComp.ReleaseToPool();
			SpawnData.NGComp = null;
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		DestroyFXTimeTick(DeltaTime);
		DelayDestroySpawnnerTimeTick(DeltaTime);
	}

	private void DestroySpawnner()
	{
		if (SpawnData.NGComp.IsNullOrDestroyed())
		{
			BGU_UnrealWorldUtil.DestroyActor(Owner);
		}
		else
		{
			OnEscapeEnded();
		}
	}

	static BUS_NeutralFXAnimalSpawnLogicComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_NeutralFXAnimalSpawnLogicComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_NeutralFXAnimalSpawnLogicComp));
		PARAMETER_NAME_WAKEUP = "User.WakeUp";
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_NeutralFXAnimalSpawnLogicComp:StartEscape")]
	private static void StartEscape__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BUS_NeutralFXAnimalSpawnLogicComp bUS_NeutralFXAnimalSpawnLogicComp = GCHelper.Find<b1.BUS_NeutralFXAnimalSpawnLogicComp>(obj);
		UPrimitiveComponent overlappedComponent = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, StartEscape_OverlappedComponent_Offset));
		AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, StartEscape_OtherActor_Offset));
		UPrimitiveComponent otherComp = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, StartEscape_OtherComp_Offset));
		int otherBodyIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, StartEscape_OtherBodyIndex_Offset));
		bool bFromSweep = BoolMarshaler.FromNative(IntPtr.Add(buffer, StartEscape_bFromSweep_Offset), 0, StartEscape_bFromSweep_PropertyAddress.Address);
		FHitResult sweepResult = FHitResult.FromNative(IntPtr.Add(buffer, StartEscape_SweepResult_Offset));
		bUS_NeutralFXAnimalSpawnLogicComp.StartEscape(overlappedComponent, otherActor, otherComp, otherBodyIndex, bFromSweep, sweepResult);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_NeutralFXAnimalSpawnLogicComp:StartEscapeWitchSpdCheck")]
	private static void StartEscapeWitchSpdCheck__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BUS_NeutralFXAnimalSpawnLogicComp bUS_NeutralFXAnimalSpawnLogicComp = GCHelper.Find<b1.BUS_NeutralFXAnimalSpawnLogicComp>(obj);
		UPrimitiveComponent overlappedComponent = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, StartEscapeWitchSpdCheck_OverlappedComponent_Offset));
		AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, StartEscapeWitchSpdCheck_OtherActor_Offset));
		UPrimitiveComponent otherComp = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, StartEscapeWitchSpdCheck_OtherComp_Offset));
		int otherBodyIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, StartEscapeWitchSpdCheck_OtherBodyIndex_Offset));
		bool bFromSweep = BoolMarshaler.FromNative(IntPtr.Add(buffer, StartEscapeWitchSpdCheck_bFromSweep_Offset), 0, StartEscapeWitchSpdCheck_bFromSweep_PropertyAddress.Address);
		FHitResult sweepResult = FHitResult.FromNative(IntPtr.Add(buffer, StartEscapeWitchSpdCheck_SweepResult_Offset));
		bUS_NeutralFXAnimalSpawnLogicComp.StartEscapeWitchSpdCheck(overlappedComponent, otherActor, otherComp, otherBodyIndex, bFromSweep, sweepResult);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUS_NeutralFXAnimalSpawnLogicComp");
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_NeutralFXAnimalSpawnLogicComp:StartEscape", StartEscape_IsValid);
		StartEscapeWitchSpdCheck_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "StartEscapeWitchSpdCheck");
		StartEscapeWitchSpdCheck_ParamsSize = NativeReflection.GetFunctionParamsSize(StartEscapeWitchSpdCheck_FunctionAddress);
		StartEscapeWitchSpdCheck_OverlappedComponent_Offset = NativeReflection.GetPropertyOffset(StartEscapeWitchSpdCheck_FunctionAddress, "OverlappedComponent");
		StartEscapeWitchSpdCheck_OverlappedComponent_IsValid = NativeReflection.ValidatePropertyClass(StartEscapeWitchSpdCheck_FunctionAddress, "OverlappedComponent", Classes.FObjectProperty);
		StartEscapeWitchSpdCheck_OtherActor_Offset = NativeReflection.GetPropertyOffset(StartEscapeWitchSpdCheck_FunctionAddress, "OtherActor");
		StartEscapeWitchSpdCheck_OtherActor_IsValid = NativeReflection.ValidatePropertyClass(StartEscapeWitchSpdCheck_FunctionAddress, "OtherActor", Classes.FObjectProperty);
		StartEscapeWitchSpdCheck_OtherComp_Offset = NativeReflection.GetPropertyOffset(StartEscapeWitchSpdCheck_FunctionAddress, "OtherComp");
		StartEscapeWitchSpdCheck_OtherComp_IsValid = NativeReflection.ValidatePropertyClass(StartEscapeWitchSpdCheck_FunctionAddress, "OtherComp", Classes.FObjectProperty);
		StartEscapeWitchSpdCheck_OtherBodyIndex_Offset = NativeReflection.GetPropertyOffset(StartEscapeWitchSpdCheck_FunctionAddress, "OtherBodyIndex");
		StartEscapeWitchSpdCheck_OtherBodyIndex_IsValid = NativeReflection.ValidatePropertyClass(StartEscapeWitchSpdCheck_FunctionAddress, "OtherBodyIndex", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref StartEscapeWitchSpdCheck_bFromSweep_PropertyAddress, StartEscapeWitchSpdCheck_FunctionAddress, "bFromSweep");
		StartEscapeWitchSpdCheck_bFromSweep_Offset = NativeReflection.GetPropertyOffset(StartEscapeWitchSpdCheck_FunctionAddress, "bFromSweep");
		StartEscapeWitchSpdCheck_bFromSweep_IsValid = NativeReflection.ValidatePropertyClass(StartEscapeWitchSpdCheck_FunctionAddress, "bFromSweep", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref StartEscapeWitchSpdCheck_SweepResult_PropertyAddress, StartEscapeWitchSpdCheck_FunctionAddress, "SweepResult");
		StartEscapeWitchSpdCheck_SweepResult_Offset = NativeReflection.GetPropertyOffset(StartEscapeWitchSpdCheck_FunctionAddress, "SweepResult");
		StartEscapeWitchSpdCheck_SweepResult_IsValid = NativeReflection.ValidatePropertyClass(StartEscapeWitchSpdCheck_FunctionAddress, "SweepResult", Classes.FStructProperty);
		StartEscapeWitchSpdCheck_IsValid = StartEscapeWitchSpdCheck_FunctionAddress != IntPtr.Zero && StartEscapeWitchSpdCheck_OverlappedComponent_IsValid && StartEscapeWitchSpdCheck_OtherActor_IsValid && StartEscapeWitchSpdCheck_OtherComp_IsValid && StartEscapeWitchSpdCheck_OtherBodyIndex_IsValid && StartEscapeWitchSpdCheck_bFromSweep_IsValid && StartEscapeWitchSpdCheck_SweepResult_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_NeutralFXAnimalSpawnLogicComp:StartEscapeWitchSpdCheck", StartEscapeWitchSpdCheck_IsValid);
	}
}
