using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_QuestOverlapComponent : BUS_StateMachineCompBase
{
	public class EnableState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.OverlapTag.State_Enabled;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.OverlapTag.Event_Disable, BGW_FlowUtils.OverlapTag.State_Disabled);
			base.EventTransitDictionary.Add(BGW_FlowUtils.SceneObjCommonEventTag.Next, BGW_FlowUtils.OverlapTag.State_Disabled);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_QuestOverlapComponent bUS_QuestOverlapComponent)
			{
				bUS_QuestOverlapComponent.EnableOverlap();
			}
		}

		public override void OnRecoverAction(BUS_StateMachineCompBase InOwner)
		{
			base.OnRecoverAction(InOwner);
			if (InOwner is BUS_QuestOverlapComponent bUS_QuestOverlapComponent)
			{
				bUS_QuestOverlapComponent.OnResetToOverlapEnable();
			}
		}
	}

	public class DisableState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.OverlapTag.State_Disabled;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.OverlapTag.Event_Enable, BGW_FlowUtils.OverlapTag.State_Enabled);
			base.EventTransitDictionary.Add(BGW_FlowUtils.SceneObjCommonEventTag.Next, BGW_FlowUtils.OverlapTag.State_Enabled);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_QuestOverlapComponent bUS_QuestOverlapComponent)
			{
				bUS_QuestOverlapComponent.DisableOverlap();
			}
		}

		public override void OnRecoverAction(BUS_StateMachineCompBase InOwner)
		{
			base.OnRecoverAction(InOwner);
			if (InOwner is BUS_QuestOverlapComponent bUS_QuestOverlapComponent)
			{
				bUS_QuestOverlapComponent.OnResetToOverlapDisable();
			}
		}
	}

	[UClass]
	[USharpPath("/Script/b1-Managed.QuestOverlapCompFunctionBinder")]
	protected class UQuestOverlapCompFunctionBinder : UObject
	{
		private BUS_QuestOverlapComponent OwnerComp;

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

		public void Init(BUS_QuestOverlapComponent Component)
		{
			OwnerComp = Component;
		}

		[UFunction]
		[USharpPath("/Script/b1-Managed.QuestOverlapCompFunctionBinder:OnCollisionBeginOverlap")]
		private void OnCollisionBeginOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult)
		{
			if (OwnerComp != null)
			{
				OwnerComp.OnCollisionBeginOverlap(OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex, bFromSweep, SweepResult);
			}
		}

		[UFunction]
		[USharpPath("/Script/b1-Managed.QuestOverlapCompFunctionBinder:OnCollisionEndOverlap")]
		private void OnCollisionEndOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			if (OwnerComp != null)
			{
				OwnerComp.OnCollisionEndOverlap(OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex);
			}
		}

		[UFunction]
		[USharpPath("/Script/b1-Managed.QuestOverlapCompFunctionBinder:OnActorEnter")]
		private void OnActorEnter(AActor OverlappedActor, AActor OtherActor)
		{
			if (OverlappedActor != null)
			{
				OwnerComp.OnActorEnter(OverlappedActor, OtherActor);
			}
		}

		[UFunction]
		[USharpPath("/Script/b1-Managed.QuestOverlapCompFunctionBinder:OnActorLeave")]
		private void OnActorLeave(AActor OverlappedActor, AActor OtherActor)
		{
			if (OverlappedActor != null)
			{
				OwnerComp.OnActorLeave(OverlappedActor, OtherActor);
			}
		}

		[UFunctionInvoker("/Script/b1-Managed.QuestOverlapCompFunctionBinder:OnActorEnter")]
		private static void OnActorEnter__Invoker(IntPtr buffer, IntPtr obj)
		{
			UQuestOverlapCompFunctionBinder uQuestOverlapCompFunctionBinder = GCHelper.Find<UQuestOverlapCompFunctionBinder>(obj);
			AActor overlappedActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnActorEnter_OverlappedActor_Offset));
			AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnActorEnter_OtherActor_Offset));
			uQuestOverlapCompFunctionBinder.OnActorEnter(overlappedActor, otherActor);
		}

		[UFunctionInvoker("/Script/b1-Managed.QuestOverlapCompFunctionBinder:OnActorLeave")]
		private static void OnActorLeave__Invoker(IntPtr buffer, IntPtr obj)
		{
			UQuestOverlapCompFunctionBinder uQuestOverlapCompFunctionBinder = GCHelper.Find<UQuestOverlapCompFunctionBinder>(obj);
			AActor overlappedActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnActorLeave_OverlappedActor_Offset));
			AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnActorLeave_OtherActor_Offset));
			uQuestOverlapCompFunctionBinder.OnActorLeave(overlappedActor, otherActor);
		}

		[UFunctionInvoker("/Script/b1-Managed.QuestOverlapCompFunctionBinder:OnCollisionEndOverlap")]
		private static void OnCollisionEndOverlap__Invoker(IntPtr buffer, IntPtr obj)
		{
			UQuestOverlapCompFunctionBinder uQuestOverlapCompFunctionBinder = GCHelper.Find<UQuestOverlapCompFunctionBinder>(obj);
			UPrimitiveComponent overlappedComponent = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnCollisionEndOverlap_OverlappedComponent_Offset));
			AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnCollisionEndOverlap_OtherActor_Offset));
			UPrimitiveComponent otherComp = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnCollisionEndOverlap_OtherComp_Offset));
			int otherBodyIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnCollisionEndOverlap_OtherBodyIndex_Offset));
			uQuestOverlapCompFunctionBinder.OnCollisionEndOverlap(overlappedComponent, otherActor, otherComp, otherBodyIndex);
		}

		[UFunctionInvoker("/Script/b1-Managed.QuestOverlapCompFunctionBinder:OnCollisionBeginOverlap")]
		private static void OnCollisionBeginOverlap__Invoker(IntPtr buffer, IntPtr obj)
		{
			UQuestOverlapCompFunctionBinder uQuestOverlapCompFunctionBinder = GCHelper.Find<UQuestOverlapCompFunctionBinder>(obj);
			UPrimitiveComponent overlappedComponent = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_OverlappedComponent_Offset));
			AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_OtherActor_Offset));
			UPrimitiveComponent otherComp = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_OtherComp_Offset));
			int otherBodyIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_OtherBodyIndex_Offset));
			bool bFromSweep = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_bFromSweep_Offset), 0, OnCollisionBeginOverlap_bFromSweep_PropertyAddress.Address);
			FHitResult sweepResult = FHitResult.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_SweepResult_Offset));
			uQuestOverlapCompFunctionBinder.OnCollisionBeginOverlap(overlappedComponent, otherActor, otherComp, otherBodyIndex, bFromSweep, sweepResult);
		}

		private static void LoadNativeType()
		{
			IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.QuestOverlapCompFunctionBinder");
			OnActorEnter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnActorEnter");
			OnActorEnter_ParamsSize = NativeReflection.GetFunctionParamsSize(OnActorEnter_FunctionAddress);
			OnActorEnter_OverlappedActor_Offset = NativeReflection.GetPropertyOffset(OnActorEnter_FunctionAddress, "OverlappedActor");
			OnActorEnter_OverlappedActor_IsValid = NativeReflection.ValidatePropertyClass(OnActorEnter_FunctionAddress, "OverlappedActor", Classes.FObjectProperty);
			OnActorEnter_OtherActor_Offset = NativeReflection.GetPropertyOffset(OnActorEnter_FunctionAddress, "OtherActor");
			OnActorEnter_OtherActor_IsValid = NativeReflection.ValidatePropertyClass(OnActorEnter_FunctionAddress, "OtherActor", Classes.FObjectProperty);
			OnActorEnter_IsValid = OnActorEnter_FunctionAddress != IntPtr.Zero && OnActorEnter_OverlappedActor_IsValid && OnActorEnter_OtherActor_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.QuestOverlapCompFunctionBinder:OnActorEnter", OnActorEnter_IsValid);
			OnActorLeave_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnActorLeave");
			OnActorLeave_ParamsSize = NativeReflection.GetFunctionParamsSize(OnActorLeave_FunctionAddress);
			OnActorLeave_OverlappedActor_Offset = NativeReflection.GetPropertyOffset(OnActorLeave_FunctionAddress, "OverlappedActor");
			OnActorLeave_OverlappedActor_IsValid = NativeReflection.ValidatePropertyClass(OnActorLeave_FunctionAddress, "OverlappedActor", Classes.FObjectProperty);
			OnActorLeave_OtherActor_Offset = NativeReflection.GetPropertyOffset(OnActorLeave_FunctionAddress, "OtherActor");
			OnActorLeave_OtherActor_IsValid = NativeReflection.ValidatePropertyClass(OnActorLeave_FunctionAddress, "OtherActor", Classes.FObjectProperty);
			OnActorLeave_IsValid = OnActorLeave_FunctionAddress != IntPtr.Zero && OnActorLeave_OverlappedActor_IsValid && OnActorLeave_OtherActor_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.QuestOverlapCompFunctionBinder:OnActorLeave", OnActorLeave_IsValid);
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
			OnCollisionEndOverlap_IsValid = OnCollisionEndOverlap_FunctionAddress != IntPtr.Zero && OnCollisionEndOverlap_OverlappedComponent_IsValid && OnCollisionEndOverlap_OtherActor_IsValid && OnCollisionEndOverlap_OtherComp_IsValid && OnCollisionEndOverlap_OtherBodyIndex_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.QuestOverlapCompFunctionBinder:OnCollisionEndOverlap", OnCollisionEndOverlap_IsValid);
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
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.QuestOverlapCompFunctionBinder:OnCollisionBeginOverlap", OnCollisionBeginOverlap_IsValid);
		}

		static UQuestOverlapCompFunctionBinder()
		{
			if (UnrealTypes.CanLazyLoadManagedType(typeof(UQuestOverlapCompFunctionBinder)))
			{
				LoadNativeType();
			}
			UnrealTypes.OnCCtorCalled(typeof(UQuestOverlapCompFunctionBinder));
		}
	}

	private TStrongObjectPtr<UQuestOverlapCompFunctionBinder> mFunctionBinder = new TStrongObjectPtr<UQuestOverlapCompFunctionBinder>();

	protected BUC_QuestOverlapData OverlapData { get; set; }

	protected List<TWeakObject<UPrimitiveComponent>> CollisionComponents { get; } = new List<TWeakObject<UPrimitiveComponent>>();

	protected UQuestOverlapCompFunctionBinder FunctionBinder
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

	private TWeakObject<APlayerController> LocalPlayerController { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		OverlapData = RequireWritableData<BUC_QuestOverlapData>();
		base.SceneObjTag = BGW_FlowUtils.SceneObjTag.OverlapBox;
		GSStateBase gSStateBase = AddState(typeof(EnableState), 1);
		GSStateBase gSStateBase2 = AddState(typeof(DisableState), 0);
		base.InitialState = (OverlapData.bAutoEnableOverlap ? gSStateBase : gSStateBase2);
		FunctionBinder = UObject.NewObject<UQuestOverlapCompFunctionBinder>(base.Owner);
		FunctionBinder.Init(this);
		OverlapData.bFirstTick = true;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		base.OnTickWithGroup(DeltaTime, TickGroup);
		if (!OverlapData.bFirstTick)
		{
			return;
		}
		OverlapData.bFirstTick = false;
		if (base.CurrentState == null || !GameplayTagExtension.IsTag(base.CurrentState.StateTag, BGW_FlowUtils.OverlapTag.State_Enabled) || !(UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner).GetControlledPawn() != null))
		{
			return;
		}
		List<UActorComponent> componentsByClass = base.Owner.GetComponentsByClass(UClass.GetClass<UPrimitiveComponent>());
		bool flag = false;
		foreach (UActorComponent item in componentsByClass)
		{
			UBoxComponent uBoxComponent = item as UBoxComponent;
			if (uBoxComponent == null)
			{
				continue;
			}
			uBoxComponent.GetOverlappingComponents(out var OutOverlappingComponents);
			foreach (UPrimitiveComponent item2 in OutOverlappingComponents)
			{
				BGUPlayerCharacterCS bGUPlayerCharacterCS = item2.GetOwner() as BGUPlayerCharacterCS;
				if (!bGUPlayerCharacterCS.IsNullOrDestroyed() && bGUPlayerCharacterCS.IsPlayerControlled())
				{
					flag = true;
				}
			}
		}
		if (flag)
		{
			NotifyGraph(BGW_FlowUtils.CommonTag.OverlapBegin);
			base.BGWEventCollection.Evt_BGS_PlayerEnterOverlap(base.GuidData.GetFinalGuid());
		}
		else
		{
			NotifyGraph(BGW_FlowUtils.CommonTag.OverlapEnd);
			base.BGWEventCollection.Evt_BGS_PlayerLeaveOverlap(base.GuidData.GetFinalGuid());
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		FunctionBinder = null;
	}

	protected virtual void OnResetToOverlapEnable()
	{
	}

	protected virtual void OnResetToOverlapDisable()
	{
	}

	private void EnableOverlap()
	{
		if (!OverlapData.bOverlapEnabled)
		{
			OverlapData.bOverlapEnabled = true;
			OnEnableOverlap();
		}
	}

	protected virtual void OnEnableOverlap()
	{
		foreach (UActorComponent item in base.Owner.GetComponentsByClass(UClass.GetClass<UPrimitiveComponent>()))
		{
			UBoxComponent uBoxComponent = item as UBoxComponent;
			if (uBoxComponent == null || !uBoxComponent.GetGenerateOverlapEvents())
			{
				continue;
			}
			CollisionComponents.Add(new TWeakObject<UPrimitiveComponent>(uBoxComponent));
			UBGUFunctionLibraryForCS.BGUBindOnComponentBeginOverlapEvent(uBoxComponent, FunctionBinder, B1GlobalFNames.OnCollisionBeginOverlap);
			UBGUFunctionLibraryForCS.BGUBindOnComponentEndOverlapEvent(uBoxComponent, FunctionBinder, B1GlobalFNames.OnCollisionEndOverlap);
			WriteLog("Enable Overlap");
			uBoxComponent.GetOverlappingComponents(out var OutOverlappingComponents);
			foreach (UPrimitiveComponent item2 in OutOverlappingComponents)
			{
				OnCollisionBeginOverlap(uBoxComponent, item2.GetOwner(), item2, 0, bFromSweep: false, default(FHitResult));
			}
		}
	}

	private void DisableOverlap()
	{
		if (OverlapData.bOverlapEnabled)
		{
			OnDisableOverlap();
			OverlapData.bOverlapEnabled = false;
		}
	}

	protected virtual void OnDisableOverlap()
	{
		foreach (TWeakObject<UPrimitiveComponent> collisionComponent in CollisionComponents)
		{
			if (collisionComponent.IsValid())
			{
				UBGUFunctionLibraryForCS.BGUUnBindOnComponentBeginOverlapEvent(collisionComponent.Get(), FunctionBinder, B1GlobalFNames.OnCollisionBeginOverlap);
				UBGUFunctionLibraryForCS.BGUUnBindOnComponentEndOverlapEvent(collisionComponent.Get(), FunctionBinder, B1GlobalFNames.OnCollisionEndOverlap);
				WriteLog("Disable Overlap");
			}
		}
		CollisionComponents.Clear();
	}

	protected override void OnNotifyStartObserve()
	{
		if (!OverlapData.bOverlapEnabled)
		{
			return;
		}
		foreach (UActorComponent item in base.Owner.GetComponentsByClass(UClass.GetClass<UPrimitiveComponent>()))
		{
			UBoxComponent uBoxComponent = item as UBoxComponent;
			if (uBoxComponent == null || !uBoxComponent.GetGenerateOverlapEvents())
			{
				continue;
			}
			uBoxComponent.GetOverlappingComponents(out var OutOverlappingComponents);
			foreach (UPrimitiveComponent item2 in OutOverlappingComponents)
			{
				OnCollisionBeginOverlap(uBoxComponent, item2.GetOwner(), item2, 0, bFromSweep: false, default(FHitResult));
			}
		}
	}

	protected virtual void OnCollisionBeginOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult)
	{
		if (!(OtherActor == null) && LocalPlayerController.IsValid())
		{
			bool flag = false;
			BGUPlayerCharacterCS bGUPlayerCharacterCS = OtherActor as BGUPlayerCharacterCS;
			if (!bGUPlayerCharacterCS.IsNullOrDestroyed())
			{
				flag = bGUPlayerCharacterCS.IsPlayerControlled();
			}
			if (flag)
			{
				WriteLog("OnCollisionBeginOverlap");
				NotifyGraph(BGW_FlowUtils.CommonTag.OverlapBegin);
				base.BGWEventCollection.Evt_BGS_PlayerEnterOverlap(base.GuidData.GetFinalGuid());
				OnCollisionBeginOverlapImpl(OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex, bFromSweep, SweepResult);
			}
			OverlapData.BeginOverlapAction?.Invoke(OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex, bFromSweep, SweepResult);
		}
	}

	protected virtual void OnCollisionEndOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
	{
		if (!(OtherActor == null) && LocalPlayerController.IsValid())
		{
			bool flag = false;
			BGUPlayerCharacterCS bGUPlayerCharacterCS = OtherActor as BGUPlayerCharacterCS;
			if (!bGUPlayerCharacterCS.IsNullOrDestroyed())
			{
				flag = bGUPlayerCharacterCS.IsPlayerControlled();
			}
			if (flag)
			{
				WriteLog("OnCollisionEndOverlap");
				NotifyGraph(BGW_FlowUtils.CommonTag.OverlapEnd);
				base.BGWEventCollection.Evt_BGS_PlayerLeaveOverlap(base.GuidData.GetFinalGuid());
				OnCollisionEndOverlapImpl(OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex);
			}
			OverlapData.EndOverlapAction?.Invoke(OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex);
		}
	}

	protected virtual void OnCollisionBeginOverlapImpl(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult)
	{
	}

	protected virtual void OnCollisionEndOverlapImpl(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
	{
	}

	protected virtual void OnActorEnter(AActor OverlappedActor, AActor OtherActor)
	{
	}

	protected virtual void OnActorLeave(AActor OverlappedActor, AActor OtherActor)
	{
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner);
		if (firstLocalPlayerController.GetControlledPawn() != null)
		{
			LocalPlayerController = new TWeakObject<APlayerController>(firstLocalPlayerController);
		}
	}
}
