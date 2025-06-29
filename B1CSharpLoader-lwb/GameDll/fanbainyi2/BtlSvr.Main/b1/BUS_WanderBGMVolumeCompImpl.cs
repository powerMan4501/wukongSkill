using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_WanderBGMVolumeCompImpl : UActorCompBaseCS
{
	[UClass]
	[USharpPath("/Script/b1-Managed.BgmVolumeFunctionBinder")]
	private class UBgmVolumeFunctionBinder : UObject
	{
		private BUS_WanderBGMVolumeCompImpl OwnerComp;

		private static bool OnActorEnter_IsValid;

		private static IntPtr OnActorEnter_FunctionAddress;

		private static int OnActorEnter_ParamsSize;

		private static bool OnActorEnter_OverlapActor_IsValid;

		private static int OnActorEnter_OverlapActor_Offset;

		private static bool OnActorEnter_OtherActor_IsValid;

		private static int OnActorEnter_OtherActor_Offset;

		private static bool OnActorLeave_IsValid;

		private static IntPtr OnActorLeave_FunctionAddress;

		private static int OnActorLeave_ParamsSize;

		private static bool OnActorLeave_OverlapActor_IsValid;

		private static int OnActorLeave_OverlapActor_Offset;

		private static bool OnActorLeave_OtherActor_IsValid;

		private static int OnActorLeave_OtherActor_Offset;

		private static bool OnCollisionEndOverlap_IsValid;

		private static IntPtr OnCollisionEndOverlap_FunctionAddress;

		private static int OnCollisionEndOverlap_ParamsSize;

		private static bool OnCollisionEndOverlap_OverlappedComponent_IsValid;

		private static int OnCollisionEndOverlap_OverlappedComponent_Offset;

		private static bool OnCollisionEndOverlap_OtherActor_IsValid;

		private static int OnCollisionEndOverlap_OtherActor_Offset;

		private static bool OnCollisionEndOverlap_OtherComp_IsValid;

		private static int OnCollisionEndOverlap_OtherComp_Offset;

		private static bool OnCollisionEndOverlap_OtherBodyIndex_IsValid;

		private static int OnCollisionEndOverlap_OtherBodyIndex_Offset;

		private static bool OnCollisionEndOverlap_bFromSweep_IsValid;

		private static int OnCollisionEndOverlap_bFromSweep_Offset;

		private static FFieldAddress OnCollisionEndOverlap_bFromSweep_PropertyAddress;

		private static bool OnCollisionEndOverlap_SweepResult_IsValid;

		private static int OnCollisionEndOverlap_SweepResult_Offset;

		private static FFieldAddress OnCollisionEndOverlap_SweepResult_PropertyAddress;

		private static bool OnCollisionBeginOverlap_IsValid;

		private static IntPtr OnCollisionBeginOverlap_FunctionAddress;

		private static int OnCollisionBeginOverlap_ParamsSize;

		private static bool OnCollisionBeginOverlap_OverlappedComponent_IsValid;

		private static int OnCollisionBeginOverlap_OverlappedComponent_Offset;

		private static bool OnCollisionBeginOverlap_OtherActor_IsValid;

		private static int OnCollisionBeginOverlap_OtherActor_Offset;

		private static bool OnCollisionBeginOverlap_OtherComp_IsValid;

		private static int OnCollisionBeginOverlap_OtherComp_Offset;

		private static bool OnCollisionBeginOverlap_OtherBodyIndex_IsValid;

		private static int OnCollisionBeginOverlap_OtherBodyIndex_Offset;

		private static bool OnCollisionBeginOverlap_bFromSweep_IsValid;

		private static int OnCollisionBeginOverlap_bFromSweep_Offset;

		private static FFieldAddress OnCollisionBeginOverlap_bFromSweep_PropertyAddress;

		private static bool OnCollisionBeginOverlap_SweepResult_IsValid;

		private static int OnCollisionBeginOverlap_SweepResult_Offset;

		private static FFieldAddress OnCollisionBeginOverlap_SweepResult_PropertyAddress;

		public void Init(BUS_WanderBGMVolumeCompImpl Component)
		{
			OwnerComp = Component;
		}

		[UFunction]
		[USharpPath("/Script/b1-Managed.BgmVolumeFunctionBinder:OnCollisionBeginOverlap")]
		private void OnCollisionBeginOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult)
		{
			OwnerComp.OnCollisionBeginOverlap(OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex, bFromSweep, SweepResult);
		}

		[UFunction]
		[USharpPath("/Script/b1-Managed.BgmVolumeFunctionBinder:OnCollisionEndOverlap")]
		private void OnCollisionEndOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult)
		{
			OwnerComp.OnCollisionEndOverlap(OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex, bFromSweep, SweepResult);
		}

		[UFunction]
		[USharpPath("/Script/b1-Managed.BgmVolumeFunctionBinder:OnActorEnter")]
		private void OnActorEnter(AActor OverlapActor, AActor OtherActor)
		{
			OwnerComp.OnActorEnter(OverlapActor, OtherActor);
		}

		[UFunction]
		[USharpPath("/Script/b1-Managed.BgmVolumeFunctionBinder:OnActorLeave")]
		private void OnActorLeave(AActor OverlapActor, AActor OtherActor)
		{
			OwnerComp.OnActorLeave(OverlapActor, OtherActor);
		}

		[UFunctionInvoker("/Script/b1-Managed.BgmVolumeFunctionBinder:OnActorEnter")]
		private static void OnActorEnter__Invoker(IntPtr buffer, IntPtr obj)
		{
			UBgmVolumeFunctionBinder uBgmVolumeFunctionBinder = GCHelper.Find<UBgmVolumeFunctionBinder>(obj);
			AActor overlapActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnActorEnter_OverlapActor_Offset));
			AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnActorEnter_OtherActor_Offset));
			uBgmVolumeFunctionBinder.OnActorEnter(overlapActor, otherActor);
		}

		[UFunctionInvoker("/Script/b1-Managed.BgmVolumeFunctionBinder:OnActorLeave")]
		private static void OnActorLeave__Invoker(IntPtr buffer, IntPtr obj)
		{
			UBgmVolumeFunctionBinder uBgmVolumeFunctionBinder = GCHelper.Find<UBgmVolumeFunctionBinder>(obj);
			AActor overlapActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnActorLeave_OverlapActor_Offset));
			AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnActorLeave_OtherActor_Offset));
			uBgmVolumeFunctionBinder.OnActorLeave(overlapActor, otherActor);
		}

		[UFunctionInvoker("/Script/b1-Managed.BgmVolumeFunctionBinder:OnCollisionEndOverlap")]
		private static void OnCollisionEndOverlap__Invoker(IntPtr buffer, IntPtr obj)
		{
			UBgmVolumeFunctionBinder uBgmVolumeFunctionBinder = GCHelper.Find<UBgmVolumeFunctionBinder>(obj);
			UPrimitiveComponent overlappedComponent = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnCollisionEndOverlap_OverlappedComponent_Offset));
			AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnCollisionEndOverlap_OtherActor_Offset));
			UPrimitiveComponent otherComp = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnCollisionEndOverlap_OtherComp_Offset));
			int otherBodyIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnCollisionEndOverlap_OtherBodyIndex_Offset));
			bool bFromSweep = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnCollisionEndOverlap_bFromSweep_Offset), 0, OnCollisionEndOverlap_bFromSweep_PropertyAddress.Address);
			FHitResult sweepResult = FHitResult.FromNative(IntPtr.Add(buffer, OnCollisionEndOverlap_SweepResult_Offset));
			uBgmVolumeFunctionBinder.OnCollisionEndOverlap(overlappedComponent, otherActor, otherComp, otherBodyIndex, bFromSweep, sweepResult);
		}

		[UFunctionInvoker("/Script/b1-Managed.BgmVolumeFunctionBinder:OnCollisionBeginOverlap")]
		private static void OnCollisionBeginOverlap__Invoker(IntPtr buffer, IntPtr obj)
		{
			UBgmVolumeFunctionBinder uBgmVolumeFunctionBinder = GCHelper.Find<UBgmVolumeFunctionBinder>(obj);
			UPrimitiveComponent overlappedComponent = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_OverlappedComponent_Offset));
			AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_OtherActor_Offset));
			UPrimitiveComponent otherComp = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_OtherComp_Offset));
			int otherBodyIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_OtherBodyIndex_Offset));
			bool bFromSweep = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_bFromSweep_Offset), 0, OnCollisionBeginOverlap_bFromSweep_PropertyAddress.Address);
			FHitResult sweepResult = FHitResult.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_SweepResult_Offset));
			uBgmVolumeFunctionBinder.OnCollisionBeginOverlap(overlappedComponent, otherActor, otherComp, otherBodyIndex, bFromSweep, sweepResult);
		}

		private static void LoadNativeType()
		{
			IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BgmVolumeFunctionBinder");
			OnActorEnter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnActorEnter");
			OnActorEnter_ParamsSize = NativeReflection.GetFunctionParamsSize(OnActorEnter_FunctionAddress);
			OnActorEnter_OverlapActor_Offset = NativeReflection.GetPropertyOffset(OnActorEnter_FunctionAddress, "OverlapActor");
			OnActorEnter_OverlapActor_IsValid = NativeReflection.ValidatePropertyClass(OnActorEnter_FunctionAddress, "OverlapActor", Classes.FObjectProperty);
			OnActorEnter_OtherActor_Offset = NativeReflection.GetPropertyOffset(OnActorEnter_FunctionAddress, "OtherActor");
			OnActorEnter_OtherActor_IsValid = NativeReflection.ValidatePropertyClass(OnActorEnter_FunctionAddress, "OtherActor", Classes.FObjectProperty);
			OnActorEnter_IsValid = OnActorEnter_FunctionAddress != IntPtr.Zero && OnActorEnter_OverlapActor_IsValid && OnActorEnter_OtherActor_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BgmVolumeFunctionBinder:OnActorEnter", OnActorEnter_IsValid);
			OnActorLeave_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnActorLeave");
			OnActorLeave_ParamsSize = NativeReflection.GetFunctionParamsSize(OnActorLeave_FunctionAddress);
			OnActorLeave_OverlapActor_Offset = NativeReflection.GetPropertyOffset(OnActorLeave_FunctionAddress, "OverlapActor");
			OnActorLeave_OverlapActor_IsValid = NativeReflection.ValidatePropertyClass(OnActorLeave_FunctionAddress, "OverlapActor", Classes.FObjectProperty);
			OnActorLeave_OtherActor_Offset = NativeReflection.GetPropertyOffset(OnActorLeave_FunctionAddress, "OtherActor");
			OnActorLeave_OtherActor_IsValid = NativeReflection.ValidatePropertyClass(OnActorLeave_FunctionAddress, "OtherActor", Classes.FObjectProperty);
			OnActorLeave_IsValid = OnActorLeave_FunctionAddress != IntPtr.Zero && OnActorLeave_OverlapActor_IsValid && OnActorLeave_OtherActor_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BgmVolumeFunctionBinder:OnActorLeave", OnActorLeave_IsValid);
			OnCollisionEndOverlap_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnCollisionEndOverlap");
			OnCollisionEndOverlap_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCollisionEndOverlap_FunctionAddress);
			OnCollisionEndOverlap_OverlappedComponent_Offset = NativeReflection.GetPropertyOffset(OnCollisionEndOverlap_FunctionAddress, "OverlappedComponent");
			OnCollisionEndOverlap_OverlappedComponent_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionEndOverlap_FunctionAddress, "OverlappedComponent", Classes.FObjectProperty);
			OnCollisionEndOverlap_OtherActor_Offset = NativeReflection.GetPropertyOffset(OnCollisionEndOverlap_FunctionAddress, "OtherActor");
			OnCollisionEndOverlap_OtherActor_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionEndOverlap_FunctionAddress, "OtherActor", Classes.FObjectProperty);
			OnCollisionEndOverlap_OtherComp_Offset = NativeReflection.GetPropertyOffset(OnCollisionEndOverlap_FunctionAddress, "OtherComp");
			OnCollisionEndOverlap_OtherComp_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionEndOverlap_FunctionAddress, "OtherComp", Classes.FObjectProperty);
			OnCollisionEndOverlap_OtherBodyIndex_Offset = NativeReflection.GetPropertyOffset(OnCollisionEndOverlap_FunctionAddress, "OtherBodyIndex");
			OnCollisionEndOverlap_OtherBodyIndex_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionEndOverlap_FunctionAddress, "OtherBodyIndex", Classes.FIntProperty);
			NativeReflection.GetPropertyRef(ref OnCollisionEndOverlap_bFromSweep_PropertyAddress, OnCollisionEndOverlap_FunctionAddress, "bFromSweep");
			OnCollisionEndOverlap_bFromSweep_Offset = NativeReflection.GetPropertyOffset(OnCollisionEndOverlap_FunctionAddress, "bFromSweep");
			OnCollisionEndOverlap_bFromSweep_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionEndOverlap_FunctionAddress, "bFromSweep", Classes.FBoolProperty);
			NativeReflection.GetPropertyRef(ref OnCollisionEndOverlap_SweepResult_PropertyAddress, OnCollisionEndOverlap_FunctionAddress, "SweepResult");
			OnCollisionEndOverlap_SweepResult_Offset = NativeReflection.GetPropertyOffset(OnCollisionEndOverlap_FunctionAddress, "SweepResult");
			OnCollisionEndOverlap_SweepResult_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionEndOverlap_FunctionAddress, "SweepResult", Classes.FStructProperty);
			OnCollisionEndOverlap_IsValid = OnCollisionEndOverlap_FunctionAddress != IntPtr.Zero && OnCollisionEndOverlap_OverlappedComponent_IsValid && OnCollisionEndOverlap_OtherActor_IsValid && OnCollisionEndOverlap_OtherComp_IsValid && OnCollisionEndOverlap_OtherBodyIndex_IsValid && OnCollisionEndOverlap_bFromSweep_IsValid && OnCollisionEndOverlap_SweepResult_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BgmVolumeFunctionBinder:OnCollisionEndOverlap", OnCollisionEndOverlap_IsValid);
			OnCollisionBeginOverlap_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnCollisionBeginOverlap");
			OnCollisionBeginOverlap_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCollisionBeginOverlap_FunctionAddress);
			OnCollisionBeginOverlap_OverlappedComponent_Offset = NativeReflection.GetPropertyOffset(OnCollisionBeginOverlap_FunctionAddress, "OverlappedComponent");
			OnCollisionBeginOverlap_OverlappedComponent_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionBeginOverlap_FunctionAddress, "OverlappedComponent", Classes.FObjectProperty);
			OnCollisionBeginOverlap_OtherActor_Offset = NativeReflection.GetPropertyOffset(OnCollisionBeginOverlap_FunctionAddress, "OtherActor");
			OnCollisionBeginOverlap_OtherActor_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionBeginOverlap_FunctionAddress, "OtherActor", Classes.FObjectProperty);
			OnCollisionBeginOverlap_OtherComp_Offset = NativeReflection.GetPropertyOffset(OnCollisionBeginOverlap_FunctionAddress, "OtherComp");
			OnCollisionBeginOverlap_OtherComp_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionBeginOverlap_FunctionAddress, "OtherComp", Classes.FObjectProperty);
			OnCollisionBeginOverlap_OtherBodyIndex_Offset = NativeReflection.GetPropertyOffset(OnCollisionBeginOverlap_FunctionAddress, "OtherBodyIndex");
			OnCollisionBeginOverlap_OtherBodyIndex_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionBeginOverlap_FunctionAddress, "OtherBodyIndex", Classes.FIntProperty);
			NativeReflection.GetPropertyRef(ref OnCollisionBeginOverlap_bFromSweep_PropertyAddress, OnCollisionBeginOverlap_FunctionAddress, "bFromSweep");
			OnCollisionBeginOverlap_bFromSweep_Offset = NativeReflection.GetPropertyOffset(OnCollisionBeginOverlap_FunctionAddress, "bFromSweep");
			OnCollisionBeginOverlap_bFromSweep_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionBeginOverlap_FunctionAddress, "bFromSweep", Classes.FBoolProperty);
			NativeReflection.GetPropertyRef(ref OnCollisionBeginOverlap_SweepResult_PropertyAddress, OnCollisionBeginOverlap_FunctionAddress, "SweepResult");
			OnCollisionBeginOverlap_SweepResult_Offset = NativeReflection.GetPropertyOffset(OnCollisionBeginOverlap_FunctionAddress, "SweepResult");
			OnCollisionBeginOverlap_SweepResult_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionBeginOverlap_FunctionAddress, "SweepResult", Classes.FStructProperty);
			OnCollisionBeginOverlap_IsValid = OnCollisionBeginOverlap_FunctionAddress != IntPtr.Zero && OnCollisionBeginOverlap_OverlappedComponent_IsValid && OnCollisionBeginOverlap_OtherActor_IsValid && OnCollisionBeginOverlap_OtherComp_IsValid && OnCollisionBeginOverlap_OtherBodyIndex_IsValid && OnCollisionBeginOverlap_bFromSweep_IsValid && OnCollisionBeginOverlap_SweepResult_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BgmVolumeFunctionBinder:OnCollisionBeginOverlap", OnCollisionBeginOverlap_IsValid);
		}

		static UBgmVolumeFunctionBinder()
		{
			if (UnrealTypes.CanLazyLoadManagedType(typeof(UBgmVolumeFunctionBinder)))
			{
				LoadNativeType();
			}
			UnrealTypes.OnCCtorCalled(typeof(UBgmVolumeFunctionBinder));
		}
	}

	private b1.BUC_BGMVolumeData BGMVolumeData;

	private IBGC_UnrealGameplayData UnrealGameplayData;

	private IBGC_GameBgmMgrData GameBgmMgrData;

	private IBIC_GlobalActorData GlobalActorData;

	private TStrongObjectPtr<UBgmVolumeFunctionBinder> mFunctionBinder = new TStrongObjectPtr<UBgmVolumeFunctionBinder>();

	private UBgmVolumeFunctionBinder FunctionBinder
	{
		get
		{
			return mFunctionBinder.Get();
		}
		set
		{
			mFunctionBinder.Set(value);
		}
	}

	public override void OnAttach()
	{
		BGMVolumeData = RequireWritableData<b1.BUC_BGMVolumeData>();
		UnrealGameplayData = RequireReadOnlyGameStateData<IBGC_UnrealGameplayData, BGC_UnrealGameplayData>();
		GameBgmMgrData = RequireReadOnlyGameStateData<IBGC_GameBgmMgrData, BGC_GameBgmMgrData>();
		GlobalActorData = RequireReadonlyGameInstanceData<IBIC_GlobalActorData, BIC_GlobalActorData>();
		FunctionBinder = UObject.NewObject<UBgmVolumeFunctionBinder>(GetOwner());
		FunctionBinder.Init(this);
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		foreach (UActorComponent item in GetOwner().GetComponentsByClass(UClass.GetClass<UShapeComponent>()))
		{
			UShapeComponent uShapeComponent = item as UShapeComponent;
			if (uShapeComponent != null && uShapeComponent.GetCollisionProfileName() != B1GlobalFNames.Trigger)
			{
				uShapeComponent.SetCollisionProfileName(B1GlobalFNames.Trigger);
			}
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!GameBgmMgrData.HasInit)
		{
			return;
		}
		if (!BGMVolumeData.HasInit && ((UnrealGameplayData == null) ? UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner)?.GetControlledPawn() : UnrealGameplayData.GetFirstLocalPlayerController()?.GetControlledPawn()) != null)
		{
			BGMVolumeData.HasInit = true;
			SetCanTick(Val: false);
			foreach (UActorComponent item in GetOwner().GetComponentsByClass(UClass.GetClass<UShapeComponent>()))
			{
				UShapeComponent uShapeComponent = item as UShapeComponent;
				if (!(uShapeComponent != null) || uShapeComponent.ComponentHasTag(B1GlobalFNames.OutsideTag))
				{
					continue;
				}
				uShapeComponent.GetOverlappingActors(out var OverlappingActors, UClass.GetClass<ABGUCharacter>());
				foreach (AActor item2 in OverlappingActors)
				{
					OnActorEnter(GetOwner(), item2);
				}
				UBGUFunctionLibraryForCS.BGUBindOnComponentBeginOverlapEvent(uShapeComponent, FunctionBinder, B1GlobalFNames.OnCollisionBeginOverlap);
			}
			UBGUFunctionLibraryForCS.BGUBindOnActorEndOverlapEvent(Owner, FunctionBinder, B1GlobalFNames.OnActorLeave);
		}
		if (!BGMVolumeData.IsPlayerEnteredVolume)
		{
			return;
		}
		int currentVolumeInfoIndex = GetCurrentVolumeInfoIndex();
		if (BGMVolumeData.CurrentVolumeInfoIndex != currentVolumeInfoIndex)
		{
			BGUWanderBGMVolumeActor bGUWanderBGMVolumeActor = Owner as BGUWanderBGMVolumeActor;
			if (bGUWanderBGMVolumeActor != null)
			{
				BGMVolumeData.CurrentVolumeInfoIndex = currentVolumeInfoIndex;
				BGMVolumeInfo volumeInfoByIndex = GetVolumeInfoByIndex(BGMVolumeData.CurrentVolumeInfoIndex);
				base.BGSEventCollection?.Evt_BGS_BGMVolumeInfoUpdate.Invoke(bGUWanderBGMVolumeActor, volumeInfoByIndex);
			}
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		BGUWanderBGMVolumeActor bGUWanderBGMVolumeActor = Owner as BGUWanderBGMVolumeActor;
		if (!(bGUWanderBGMVolumeActor == null))
		{
			base.BGSEventCollection?.Evt_BGS_PlayerLeaveBgmVolume.Invoke(bGUWanderBGMVolumeActor);
		}
	}

	private bool CheckUnitAlive(List<FGsActorGuidReference> ObserveUnits, EBGMVolumeConditionSusCountType ConditionSusCountType)
	{
		if (ObserveUnits == null)
		{
			return false;
		}
		foreach (FGsActorGuidReference ObserveUnit in ObserveUnits)
		{
			if (GlobalActorData.GetActorAliveState(ObserveUnit.ActorGuid))
			{
				switch (ConditionSusCountType)
				{
				case EBGMVolumeConditionSusCountType.Once:
					return true;
				}
			}
			else if (ConditionSusCountType != EBGMVolumeConditionSusCountType.Once && ConditionSusCountType == EBGMVolumeConditionSusCountType.All)
			{
				return false;
			}
		}
		return ConditionSusCountType switch
		{
			EBGMVolumeConditionSusCountType.Once => false, 
			EBGMVolumeConditionSusCountType.All => true, 
			_ => false, 
		};
	}

	private AActor GetRootMaster(AActor Actor)
	{
		IBUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_MasterData, BUC_MasterData>(Actor);
		if (readOnlyData == null)
		{
			return null;
		}
		AActor masterActor = readOnlyData.GetMasterActor();
		while (Actor != masterActor)
		{
			Actor = masterActor;
			readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_MasterData, BUC_MasterData>(Actor);
			if (readOnlyData == null)
			{
				return null;
			}
			masterActor = readOnlyData.GetMasterActor();
		}
		return masterActor;
	}

	private bool CheckUnitIsInBattle(AActor Unit)
	{
		if (BGUFunctionLibraryCS.BGUIsUnitDead(Unit))
		{
			return false;
		}
		AActor aActor = ((UnrealGameplayData == null) ? UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner)?.GetControlledPawn() : UnrealGameplayData.GetFirstLocalPlayerController()?.GetControlledPawn());
		if (aActor == null)
		{
			return false;
		}
		IBUC_TargetInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(Unit);
		IBUC_UnitHatredData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_UnitHatredData, BUC_UnitHatredData>(Unit);
		if (readOnlyData == null || unPersistentReadOnlyData == null)
		{
			return false;
		}
		bool flag = false;
		AActor lockTargetActor = readOnlyData.GetTargetInfo().LockTargetActor;
		if (lockTargetActor != null && GetRootMaster(lockTargetActor) != aActor)
		{
			flag = true;
		}
		if (!flag)
		{
			AActor hatredTargetActor = unPersistentReadOnlyData.GetHatredTargetInfo(aActor).HatredTargetActor;
			if (hatredTargetActor != null && GetRootMaster(hatredTargetActor) != aActor)
			{
				flag = true;
			}
		}
		return flag;
	}

	private bool CheckUnitIsInBattle(List<FGsActorGuidReference> ObserveUnits, EBGMVolumeConditionSusCountType ConditionSusCountType)
	{
		if (ObserveUnits == null)
		{
			return false;
		}
		foreach (FGsActorGuidReference ObserveUnit in ObserveUnits)
		{
			if (CheckUnitIsInBattle(BGU_DataUtil.GetActorByGuid(Owner, ObserveUnit.ActorGuid)))
			{
				switch (ConditionSusCountType)
				{
				case EBGMVolumeConditionSusCountType.Once:
					return true;
				}
			}
			else if (ConditionSusCountType != EBGMVolumeConditionSusCountType.Once && ConditionSusCountType == EBGMVolumeConditionSusCountType.All)
			{
				return false;
			}
		}
		return ConditionSusCountType switch
		{
			EBGMVolumeConditionSusCountType.Once => false, 
			EBGMVolumeConditionSusCountType.All => true, 
			_ => false, 
		};
	}

	private bool CheckVolumeConditionSucceed(b1.BGMVolumeConditionGroupInfo ConditionGroupInfo)
	{
		foreach (b1.BGMVolumeConditionInfo condition in ConditionGroupInfo.Conditions)
		{
			switch (condition.Condition)
			{
			case EBGMVolumeConditionType.UnitAlive:
				if (!(condition.InverseCondition ^ CheckUnitAlive(condition.Actors, condition.ConditionSusCountType)))
				{
					return false;
				}
				break;
			case EBGMVolumeConditionType.UnitInBattle:
				if (!(condition.InverseCondition ^ CheckUnitIsInBattle(condition.Actors, condition.ConditionSusCountType)))
				{
					return false;
				}
				break;
			}
		}
		return true;
	}

	private bool CheckVolumeConditionSucceed(List<b1.BGMVolumeConditionGroupInfo> ConditionGroups)
	{
		foreach (b1.BGMVolumeConditionGroupInfo ConditionGroup in ConditionGroups)
		{
			if (CheckVolumeConditionSucceed(ConditionGroup))
			{
				return true;
			}
		}
		return false;
	}

	private int GetCurrentVolumeInfoIndex()
	{
		if (BGMVolumeData.VolumeConditionConfigInfos == null)
		{
			return -1;
		}
		for (int i = 0; i < BGMVolumeData.VolumeConditionConfigInfos.Count; i++)
		{
			b1.BGMVolumeConditionConfigInfo bGMVolumeConditionConfigInfo = BGMVolumeData.VolumeConditionConfigInfos[i];
			if (CheckVolumeConditionSucceed(bGMVolumeConditionConfigInfo.ConditionGroups))
			{
				return i;
			}
		}
		return -1;
	}

	private BGMVolumeInfo GetVolumeInfoByIndex(int VolumeInfoIndex)
	{
		if (VolumeInfoIndex < 0 || BGMVolumeData.VolumeConditionConfigInfos == null || VolumeInfoIndex >= BGMVolumeData.VolumeConditionConfigInfos.Count)
		{
			return new BGMVolumeInfo(BGMVolumeData.AkEventBegin, BGMVolumeData.AkEventStop, BGMVolumeData.VolumeBGMConfigDA, BGMVolumeData.VolumeGroupConfig);
		}
		return BGMVolumeData.VolumeConditionConfigInfos[VolumeInfoIndex].GetVolumeInfo();
	}

	public void OnCollisionBeginOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult)
	{
		OnActorEnter(Owner, OtherActor);
	}

	public void OnCollisionEndOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult)
	{
		OnActorLeave(Owner, OtherActor);
	}

	public void OnActorEnter(AActor OverlapActor, AActor OtherActor)
	{
		BGUWanderBGMVolumeActor bGUWanderBGMVolumeActor = Owner as BGUWanderBGMVolumeActor;
		if (!(bGUWanderBGMVolumeActor == null))
		{
			AActor aActor = ((UnrealGameplayData == null) ? UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner)?.GetControlledPawn() : UnrealGameplayData.GetFirstLocalPlayerController()?.GetControlledPawn());
			if (OtherActor == aActor)
			{
				BGMVolumeData.CurrentVolumeInfoIndex = GetCurrentVolumeInfoIndex();
				BGMVolumeInfo volumeInfoByIndex = GetVolumeInfoByIndex(BGMVolumeData.CurrentVolumeInfoIndex);
				base.BGSEventCollection?.Evt_BGS_PlayerEnterBgmVolume.Invoke(bGUWanderBGMVolumeActor, volumeInfoByIndex);
				BGMVolumeData.IsPlayerEnteredVolume = true;
				SetCanTick(Val: true);
			}
		}
	}

	public void OnActorLeave(AActor OverlapActor, AActor OtherActor)
	{
		BGUWanderBGMVolumeActor bGUWanderBGMVolumeActor = Owner as BGUWanderBGMVolumeActor;
		if (!(bGUWanderBGMVolumeActor == null))
		{
			AActor aActor = ((UnrealGameplayData == null) ? UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner)?.GetControlledPawn() : UnrealGameplayData.GetFirstLocalPlayerController()?.GetControlledPawn());
			if (OtherActor == aActor)
			{
				base.BGSEventCollection?.Evt_BGS_PlayerLeaveBgmVolume.Invoke(bGUWanderBGMVolumeActor);
				BGMVolumeData.IsPlayerEnteredVolume = false;
				SetCanTick(Val: false);
			}
		}
	}
}
