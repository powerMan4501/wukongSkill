using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
public class BUS_OnlineAssistTriggerComp : BUS_StateMachineCompBase
{
	[UClass]
	[USharpPath("/Script/b1-Managed.OverlapBoxBinder")]
	protected class UOverlapBoxBinder : UObject
	{
		private BUS_OnlineAssistTriggerComp _ownerComp;

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

		public void Init(BUS_OnlineAssistTriggerComp ownerComp)
		{
			_ownerComp = ownerComp;
		}

		[UFunction]
		[USharpPath("/Script/b1-Managed.OverlapBoxBinder:OnActorEnter")]
		private void OnActorEnter(AActor OverlappedActor, AActor OtherActor)
		{
			if (OverlappedActor != null)
			{
				_ownerComp.OnActorEnter(OverlappedActor, OtherActor);
			}
		}

		[UFunction]
		[USharpPath("/Script/b1-Managed.OverlapBoxBinder:OnActorLeave")]
		private void OnActorLeave(AActor OverlappedActor, AActor OtherActor)
		{
			if (OverlappedActor != null)
			{
				_ownerComp.OnActorLeave(OverlappedActor, OtherActor);
			}
		}

		[UFunctionInvoker("/Script/b1-Managed.OverlapBoxBinder:OnActorEnter")]
		private static void OnActorEnter__Invoker(IntPtr buffer, IntPtr obj)
		{
			UOverlapBoxBinder uOverlapBoxBinder = GCHelper.Find<UOverlapBoxBinder>(obj);
			AActor overlappedActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnActorEnter_OverlappedActor_Offset));
			AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnActorEnter_OtherActor_Offset));
			uOverlapBoxBinder.OnActorEnter(overlappedActor, otherActor);
		}

		[UFunctionInvoker("/Script/b1-Managed.OverlapBoxBinder:OnActorLeave")]
		private static void OnActorLeave__Invoker(IntPtr buffer, IntPtr obj)
		{
			UOverlapBoxBinder uOverlapBoxBinder = GCHelper.Find<UOverlapBoxBinder>(obj);
			AActor overlappedActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnActorLeave_OverlappedActor_Offset));
			AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnActorLeave_OtherActor_Offset));
			uOverlapBoxBinder.OnActorLeave(overlappedActor, otherActor);
		}

		private static void LoadNativeType()
		{
			IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.OverlapBoxBinder");
			OnActorEnter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnActorEnter");
			OnActorEnter_ParamsSize = NativeReflection.GetFunctionParamsSize(OnActorEnter_FunctionAddress);
			OnActorEnter_OverlappedActor_Offset = NativeReflection.GetPropertyOffset(OnActorEnter_FunctionAddress, "OverlappedActor");
			OnActorEnter_OverlappedActor_IsValid = NativeReflection.ValidatePropertyClass(OnActorEnter_FunctionAddress, "OverlappedActor", Classes.FObjectProperty);
			OnActorEnter_OtherActor_Offset = NativeReflection.GetPropertyOffset(OnActorEnter_FunctionAddress, "OtherActor");
			OnActorEnter_OtherActor_IsValid = NativeReflection.ValidatePropertyClass(OnActorEnter_FunctionAddress, "OtherActor", Classes.FObjectProperty);
			OnActorEnter_IsValid = OnActorEnter_FunctionAddress != IntPtr.Zero && OnActorEnter_OverlappedActor_IsValid && OnActorEnter_OtherActor_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.OverlapBoxBinder:OnActorEnter", OnActorEnter_IsValid);
			OnActorLeave_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnActorLeave");
			OnActorLeave_ParamsSize = NativeReflection.GetFunctionParamsSize(OnActorLeave_FunctionAddress);
			OnActorLeave_OverlappedActor_Offset = NativeReflection.GetPropertyOffset(OnActorLeave_FunctionAddress, "OverlappedActor");
			OnActorLeave_OverlappedActor_IsValid = NativeReflection.ValidatePropertyClass(OnActorLeave_FunctionAddress, "OverlappedActor", Classes.FObjectProperty);
			OnActorLeave_OtherActor_Offset = NativeReflection.GetPropertyOffset(OnActorLeave_FunctionAddress, "OtherActor");
			OnActorLeave_OtherActor_IsValid = NativeReflection.ValidatePropertyClass(OnActorLeave_FunctionAddress, "OtherActor", Classes.FObjectProperty);
			OnActorLeave_IsValid = OnActorLeave_FunctionAddress != IntPtr.Zero && OnActorLeave_OverlappedActor_IsValid && OnActorLeave_OtherActor_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.OverlapBoxBinder:OnActorLeave", OnActorLeave_IsValid);
		}

		static UOverlapBoxBinder()
		{
			if (UnrealTypes.CanLazyLoadManagedType(typeof(UOverlapBoxBinder)))
			{
				LoadNativeType();
			}
			UnrealTypes.OnCCtorCalled(typeof(UOverlapBoxBinder));
		}
	}

	private BUC_OnlineAssistTriggerData _onlineAssistTriggerData;

	private readonly TStrongObjectPtr<UOverlapBoxBinder> _functionBinderPtr = new TStrongObjectPtr<UOverlapBoxBinder>();

	private UOverlapBoxBinder FunctionBinder
	{
		get
		{
			return _functionBinderPtr.Get();
		}
		set
		{
			_functionBinderPtr.Set(value);
		}
	}

	public override void OnAttach()
	{
		base.OnAttach();
		_onlineAssistTriggerData = RequireWritableData<BUC_OnlineAssistTriggerData>();
		base.SceneObjTag = BGW_FlowUtils.SceneObjTag.OverlapBox;
		FunctionBinder = UObject.NewObject<UOverlapBoxBinder>(base.Owner);
		FunctionBinder.Init(this);
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		UBGUFunctionLibraryForCS.BGUBindOnActorBeginOverlapEvent(base.Owner, FunctionBinder, B1GlobalFNames.OnActorEnter);
		UBGUFunctionLibraryForCS.BGUBindOnActorEndOverlapEvent(base.Owner, FunctionBinder, B1GlobalFNames.OnActorLeave);
		base.Owner.GetOverlappingActors(out var OverlappingActors, UClass.GetClass<BGUPlayerCharacterCS>());
		OverlappingActors.ForEach(delegate(AActor Player)
		{
			OnActorEnter(base.Owner, Player);
		});
		BGS_EventCollectionCS.Get(base.Owner).Evt_RegisterCrusadeMonsterInfo.Invoke(_onlineAssistTriggerData.RebirthPointId, _onlineAssistTriggerData.UnitGuid);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		base.OnTickWithGroup(DeltaTime, TickGroup);
		SetCanTick(Val: false);
	}

	private void OnActorEnter(AActor OverlappedActor, AActor OtherActor)
	{
		if (!OtherActor.IsNullOrDestroyed() && OtherActor is APawn aPawn && aPawn.IsLocallyControlled() && aPawn.IsPlayerControlled())
		{
			BGS_EventCollectionCS.Get(base.Owner).Evt_EnterCrusadeArea.Invoke(P1: true);
		}
	}

	private void OnActorLeave(AActor OverlappedActor, AActor OtherActor)
	{
		if (!OtherActor.IsNullOrDestroyed() && OtherActor is APawn aPawn && aPawn.IsLocallyControlled() && aPawn.IsPlayerControlled())
		{
			BGS_EventCollectionCS.Get(base.Owner).Evt_EnterCrusadeArea.Invoke(P1: false);
			BGS_EventCollectionCS.Get(base.Owner).Evt_TriggerAssistEvent.Invoke(EAssistEvent.MoveOutAssistArea);
		}
	}
}
