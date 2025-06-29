using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
public class BUS_RideControlTriggerComp : BUS_StateMachineCompBase
{
	[UClass]
	[USharpPath("/Script/b1-Managed.OverlapBoxFunctionBinder")]
	protected class UOverlapBoxFunctionBinder : UObject
	{
		private BUS_RideControlTriggerComp OwnerComp;

		private static bool OnActorEnter_IsValid;

		private static IntPtr OnActorEnter_FunctionAddress;

		private static int OnActorEnter_ParamsSize;

		private static bool OnActorEnter_OverlappedActor_IsValid;

		private static int OnActorEnter_OverlappedActor_Offset;

		private static bool OnActorEnter_OtherActor_IsValid;

		private static int OnActorEnter_OtherActor_Offset;

		private static bool OnActorLeave_IsValid;

		private static IntPtr OnActorLeave_FunctionAddress;

		private static int OnActorLeave_ParamsSize;

		private static bool OnActorLeave_OverlappedActor_IsValid;

		private static int OnActorLeave_OverlappedActor_Offset;

		private static bool OnActorLeave_OtherActor_IsValid;

		private static int OnActorLeave_OtherActor_Offset;

		public void Init(BUS_RideControlTriggerComp InComp)
		{
			OwnerComp = InComp;
		}

		[UFunction]
		[USharpPath("/Script/b1-Managed.OverlapBoxFunctionBinder:OnActorEnter")]
		private void OnActorEnter(AActor OverlappedActor, AActor OtherActor)
		{
			if (OverlappedActor != null)
			{
				OwnerComp.OnActorEnter(OverlappedActor, OtherActor);
			}
		}

		[UFunction]
		[USharpPath("/Script/b1-Managed.OverlapBoxFunctionBinder:OnActorLeave")]
		private void OnActorLeave(AActor OverlappedActor, AActor OtherActor)
		{
			if (OverlappedActor != null)
			{
				OwnerComp.OnActorLeave(OverlappedActor, OtherActor);
			}
		}

		[UFunctionInvoker("/Script/b1-Managed.OverlapBoxFunctionBinder:OnActorEnter")]
		private static void OnActorEnter__Invoker(IntPtr buffer, IntPtr obj)
		{
			UOverlapBoxFunctionBinder uOverlapBoxFunctionBinder = GCHelper.Find<UOverlapBoxFunctionBinder>(obj);
			AActor overlappedActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnActorEnter_OverlappedActor_Offset));
			AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnActorEnter_OtherActor_Offset));
			uOverlapBoxFunctionBinder.OnActorEnter(overlappedActor, otherActor);
		}

		[UFunctionInvoker("/Script/b1-Managed.OverlapBoxFunctionBinder:OnActorLeave")]
		private static void OnActorLeave__Invoker(IntPtr buffer, IntPtr obj)
		{
			UOverlapBoxFunctionBinder uOverlapBoxFunctionBinder = GCHelper.Find<UOverlapBoxFunctionBinder>(obj);
			AActor overlappedActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnActorLeave_OverlappedActor_Offset));
			AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnActorLeave_OtherActor_Offset));
			uOverlapBoxFunctionBinder.OnActorLeave(overlappedActor, otherActor);
		}

		private static void LoadNativeType()
		{
			IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.OverlapBoxFunctionBinder");
			OnActorEnter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnActorEnter");
			OnActorEnter_ParamsSize = NativeReflection.GetFunctionParamsSize(OnActorEnter_FunctionAddress);
			OnActorEnter_OverlappedActor_Offset = NativeReflection.GetPropertyOffset(OnActorEnter_FunctionAddress, "OverlappedActor");
			OnActorEnter_OverlappedActor_IsValid = NativeReflection.ValidatePropertyClass(OnActorEnter_FunctionAddress, "OverlappedActor", Classes.FObjectProperty);
			OnActorEnter_OtherActor_Offset = NativeReflection.GetPropertyOffset(OnActorEnter_FunctionAddress, "OtherActor");
			OnActorEnter_OtherActor_IsValid = NativeReflection.ValidatePropertyClass(OnActorEnter_FunctionAddress, "OtherActor", Classes.FObjectProperty);
			OnActorEnter_IsValid = OnActorEnter_FunctionAddress != IntPtr.Zero && OnActorEnter_OverlappedActor_IsValid && OnActorEnter_OtherActor_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.OverlapBoxFunctionBinder:OnActorEnter", OnActorEnter_IsValid);
			OnActorLeave_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnActorLeave");
			OnActorLeave_ParamsSize = NativeReflection.GetFunctionParamsSize(OnActorLeave_FunctionAddress);
			OnActorLeave_OverlappedActor_Offset = NativeReflection.GetPropertyOffset(OnActorLeave_FunctionAddress, "OverlappedActor");
			OnActorLeave_OverlappedActor_IsValid = NativeReflection.ValidatePropertyClass(OnActorLeave_FunctionAddress, "OverlappedActor", Classes.FObjectProperty);
			OnActorLeave_OtherActor_Offset = NativeReflection.GetPropertyOffset(OnActorLeave_FunctionAddress, "OtherActor");
			OnActorLeave_OtherActor_IsValid = NativeReflection.ValidatePropertyClass(OnActorLeave_FunctionAddress, "OtherActor", Classes.FObjectProperty);
			OnActorLeave_IsValid = OnActorLeave_FunctionAddress != IntPtr.Zero && OnActorLeave_OverlappedActor_IsValid && OnActorLeave_OtherActor_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.OverlapBoxFunctionBinder:OnActorLeave", OnActorLeave_IsValid);
		}

		static UOverlapBoxFunctionBinder()
		{
			if (UnrealTypes.CanLazyLoadManagedType(typeof(UOverlapBoxFunctionBinder)))
			{
				LoadNativeType();
			}
			UnrealTypes.OnCCtorCalled(typeof(UOverlapBoxFunctionBinder));
		}
	}

	private b1.BUC_RideControlTriggerData RideControlTriggerData;

	private IBGC_UnrealGameplayData UnrealGameplayData;

	private TStrongObjectPtr<UOverlapBoxFunctionBinder> mFunctionBinder = new TStrongObjectPtr<UOverlapBoxFunctionBinder>();

	protected UOverlapBoxFunctionBinder FunctionBinder
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
		base.OnAttach();
		RideControlTriggerData = RequireWritableData<b1.BUC_RideControlTriggerData>();
		UnrealGameplayData = RequireReadOnlyGameStateData<IBGC_UnrealGameplayData, BGC_UnrealGameplayData>();
		base.SceneObjTag = BGW_FlowUtils.SceneObjTag.OverlapBox;
		FunctionBinder = UObject.NewObject<UOverlapBoxFunctionBinder>(base.Owner);
		FunctionBinder.Init(this);
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		UBGUFunctionLibraryForCS.BGUBindOnActorBeginOverlapEvent(base.Owner, FunctionBinder, B1GlobalFNames.OnActorEnter);
		UBGUFunctionLibraryForCS.BGUBindOnActorEndOverlapEvent(base.Owner, FunctionBinder, B1GlobalFNames.OnActorLeave);
		base.Owner.GetOverlappingActors(out var OverlappingActors, UClass.GetClass<BGUPlayerCharacterCS>());
		foreach (AActor item in OverlappingActors)
		{
			OnActorEnter(base.Owner, item);
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		base.OnTickWithGroup(DeltaTime, TickGroup);
	}

	protected void OnActorEnter(AActor OverlappedActor, AActor OtherActor)
	{
		if (OtherActor is APawn aPawn && !aPawn.IsNullOrDestroyed() && aPawn.IsLocallyControlled() && aPawn.IsPlayerControlled())
		{
			BPS_EventCollectionCS.Get(aPawn.GetController() as APlayerController)?.Evt_TriggerAllowRide.Invoke(P1: false);
		}
	}

	protected void OnActorLeave(AActor OverlappedActor, AActor OtherActor)
	{
		if (OtherActor is APawn aPawn && !aPawn.IsNullOrDestroyed() && aPawn.IsLocallyControlled() && aPawn.IsPlayerControlled())
		{
			BPS_EventCollectionCS.Get(aPawn.GetController() as APlayerController)?.Evt_TriggerAllowRide.Invoke(P1: true);
		}
	}
}
