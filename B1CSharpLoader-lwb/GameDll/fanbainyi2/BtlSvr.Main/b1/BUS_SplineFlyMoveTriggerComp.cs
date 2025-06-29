using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_SplineFlyMoveTriggerComp : BUS_StateMachineCompBase
{
	public class EnableState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.OverlapTag.State_Enabled;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.SplineFlyMoveTag.Event_TriggerSplineFly, BGW_FlowUtils.SplineFlyMoveTag.State_InActived);
			base.EventTransitDictionary.Add(BGW_FlowUtils.SceneObjCommonEventTag.Next, BGW_FlowUtils.OverlapTag.State_Disabled);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			base.OnEnterAction(InOwner);
			if (InOwner is BUS_SplineFlyMoveTriggerComp bUS_SplineFlyMoveTriggerComp)
			{
				bUS_SplineFlyMoveTriggerComp.OnSetOverlapEnable(Value: true);
			}
		}
	}

	public class Disable : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.OverlapTag.State_Disabled;

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			base.OnEnterAction(InOwner);
			if (InOwner is BUS_SplineFlyMoveTriggerComp bUS_SplineFlyMoveTriggerComp)
			{
				bUS_SplineFlyMoveTriggerComp.OnSetOverlapEnable(Value: false);
			}
		}
	}

	public class InActivedState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.SplineFlyMoveTag.State_InActived;

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			base.OnEnterAction(InOwner);
			if (InOwner is BUS_SplineFlyMoveTriggerComp bUS_SplineFlyMoveTriggerComp)
			{
				bUS_SplineFlyMoveTriggerComp.JumpToFlyingState();
			}
		}
	}

	public class FlyingState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.SplineFlyMoveTag.State_Flying;

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			base.OnEnterAction(InOwner);
			if (InOwner is BUS_SplineFlyMoveTriggerComp bUS_SplineFlyMoveTriggerComp)
			{
				bUS_SplineFlyMoveTriggerComp.SetAllUnitFlyControllerInfo();
			}
		}

		public override void OnTickAction(BUS_StateMachineCompBase InOwner, float DeltaTime)
		{
			base.OnTickAction(InOwner, DeltaTime);
			if (InOwner is BUS_SplineFlyMoveTriggerComp bUS_SplineFlyMoveTriggerComp)
			{
				bUS_SplineFlyMoveTriggerComp.FlyingStateTick(DeltaTime);
			}
		}

		public override void OnExitAction(BUS_StateMachineCompBase InOwner)
		{
			base.OnExitAction(InOwner);
			if (InOwner is BUS_SplineFlyMoveTriggerComp bUS_SplineFlyMoveTriggerComp)
			{
				bUS_SplineFlyMoveTriggerComp.FlyinyEnd();
			}
		}
	}

	public class ActivedState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.SplineFlyMoveTag.State_Actived;
	}

	[UClass]
	[USharpPath("/Script/b1-Managed.SplineFlyMoveTriggerCompFunctionBinder")]
	protected class USplineFlyMoveTriggerCompFunctionBinder : UObject
	{
		private BUS_SplineFlyMoveTriggerComp OwnerComp;

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

		public void Init(BUS_SplineFlyMoveTriggerComp Component)
		{
			OwnerComp = Component;
		}

		[UFunction]
		[USharpPath("/Script/b1-Managed.SplineFlyMoveTriggerCompFunctionBinder:OnCollisionBeginOverlap")]
		private void OnCollisionBeginOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult)
		{
			if (OwnerComp != null)
			{
				OwnerComp.OnCollisionBeginOverlap(OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex, bFromSweep, SweepResult);
			}
		}

		[UFunction]
		[USharpPath("/Script/b1-Managed.SplineFlyMoveTriggerCompFunctionBinder:OnCollisionEndOverlap")]
		private void OnCollisionEndOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			if (OwnerComp != null)
			{
				OwnerComp.OnCollisionEndOverlap(OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex);
			}
		}

		[UFunctionInvoker("/Script/b1-Managed.SplineFlyMoveTriggerCompFunctionBinder:OnCollisionEndOverlap")]
		private static void OnCollisionEndOverlap__Invoker(IntPtr buffer, IntPtr obj)
		{
			USplineFlyMoveTriggerCompFunctionBinder uSplineFlyMoveTriggerCompFunctionBinder = GCHelper.Find<USplineFlyMoveTriggerCompFunctionBinder>(obj);
			UPrimitiveComponent overlappedComponent = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnCollisionEndOverlap_OverlappedComponent_Offset));
			AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnCollisionEndOverlap_OtherActor_Offset));
			UPrimitiveComponent otherComp = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnCollisionEndOverlap_OtherComp_Offset));
			int otherBodyIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnCollisionEndOverlap_OtherBodyIndex_Offset));
			uSplineFlyMoveTriggerCompFunctionBinder.OnCollisionEndOverlap(overlappedComponent, otherActor, otherComp, otherBodyIndex);
		}

		[UFunctionInvoker("/Script/b1-Managed.SplineFlyMoveTriggerCompFunctionBinder:OnCollisionBeginOverlap")]
		private static void OnCollisionBeginOverlap__Invoker(IntPtr buffer, IntPtr obj)
		{
			USplineFlyMoveTriggerCompFunctionBinder uSplineFlyMoveTriggerCompFunctionBinder = GCHelper.Find<USplineFlyMoveTriggerCompFunctionBinder>(obj);
			UPrimitiveComponent overlappedComponent = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_OverlappedComponent_Offset));
			AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_OtherActor_Offset));
			UPrimitiveComponent otherComp = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_OtherComp_Offset));
			int otherBodyIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_OtherBodyIndex_Offset));
			bool bFromSweep = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_bFromSweep_Offset), 0, OnCollisionBeginOverlap_bFromSweep_PropertyAddress.Address);
			FHitResult sweepResult = FHitResult.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_SweepResult_Offset));
			uSplineFlyMoveTriggerCompFunctionBinder.OnCollisionBeginOverlap(overlappedComponent, otherActor, otherComp, otherBodyIndex, bFromSweep, sweepResult);
		}

		private static void LoadNativeType()
		{
			IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.SplineFlyMoveTriggerCompFunctionBinder");
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
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.SplineFlyMoveTriggerCompFunctionBinder:OnCollisionEndOverlap", OnCollisionEndOverlap_IsValid);
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
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.SplineFlyMoveTriggerCompFunctionBinder:OnCollisionBeginOverlap", OnCollisionBeginOverlap_IsValid);
		}

		static USplineFlyMoveTriggerCompFunctionBinder()
		{
			if (UnrealTypes.CanLazyLoadManagedType(typeof(USplineFlyMoveTriggerCompFunctionBinder)))
			{
				LoadNativeType();
			}
			UnrealTypes.OnCCtorCalled(typeof(USplineFlyMoveTriggerCompFunctionBinder));
		}
	}

	private TStrongObjectPtr<USplineFlyMoveTriggerCompFunctionBinder> mFunctionBinder = new TStrongObjectPtr<USplineFlyMoveTriggerCompFunctionBinder>();

	private BUC_SplineFlyMoveTriggerData SplineFlyMoveTriggerData { get; set; }

	protected List<TWeakObject<UPrimitiveComponent>> CollisionComponents { get; } = new List<TWeakObject<UPrimitiveComponent>>();

	protected USplineFlyMoveTriggerCompFunctionBinder FunctionBinder
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

	private IBIC_StateMachineData StateMachineData { get; set; }

	private GSStateBase State_Enable { get; set; }

	private GSStateBase State_Disable { get; set; }

	private GSStateBase State_InActived { get; set; }

	private GSStateBase State_Flying { get; set; }

	private GSStateBase State_Actived { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		SplineFlyMoveTriggerData = RequireWritableData<BUC_SplineFlyMoveTriggerData>();
		StateMachineData = RequireReadonlyGameInstanceData<IBIC_StateMachineData, BIC_StateMachineData>();
		State_Enable = AddState(typeof(EnableState), 0);
		State_Disable = AddState(typeof(Disable), 1);
		State_InActived = AddState(typeof(InActivedState), 2);
		State_Flying = AddState(typeof(FlyingState), 3);
		State_Actived = AddState(typeof(ActivedState), 4);
		FunctionBinder = UObject.NewObject<USplineFlyMoveTriggerCompFunctionBinder>(base.Owner);
		FunctionBinder.Init(this);
		GSBindProp<bool> bOverlapEnable = SplineFlyMoveTriggerData.bOverlapEnable;
		bOverlapEnable.OnValueChanged = (GSBindProp<bool>.ValueChangedHandler)Delegate.Combine(bOverlapEnable.OnValueChanged, new GSBindProp<bool>.ValueChangedHandler(OnOverlapChange));
		base.InitialState = (SplineFlyMoveTriggerData.bAutoEnable ? State_Enable : State_Disable);
		base.BGSEventCollection.Evt_NotifyTamerSpawnUnit += new Del_Void_String(OnTamerSpawnUnit);
	}

	public void OnOverlapChange(EChangeReason Reason, bool OldValue, bool NewValue)
	{
		if (NewValue)
		{
			OnEnableOverlap();
		}
		else
		{
			OnDisableOverlap();
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		base.BGSEventCollection.Evt_NotifyTamerSpawnUnit -= new Del_Void_String(OnTamerSpawnUnit);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public void OnSetOverlapEnable(bool Value)
	{
		SplineFlyMoveTriggerData.bOverlapEnable.SetValue(EChangeReason.InnerOp, Value);
	}

	protected override bool IsIgnoreSavedState()
	{
		return true;
	}

	public void OnEnableOverlap()
	{
		foreach (UActorComponent item in base.Owner.GetComponentsByClass(UClass.GetClass<UPrimitiveComponent>()))
		{
			UShapeComponent uShapeComponent = item as UShapeComponent;
			if (uShapeComponent == null || !uShapeComponent.GetGenerateOverlapEvents())
			{
				continue;
			}
			CollisionComponents.Add(new TWeakObject<UPrimitiveComponent>(uShapeComponent));
			UBGUFunctionLibraryForCS.BGUBindOnComponentBeginOverlapEvent(uShapeComponent, FunctionBinder, B1GlobalFNames.OnCollisionBeginOverlap);
			UBGUFunctionLibraryForCS.BGUBindOnComponentEndOverlapEvent(uShapeComponent, FunctionBinder, B1GlobalFNames.OnCollisionEndOverlap);
			uShapeComponent.GetOverlappingComponents(out var OutOverlappingComponents);
			foreach (UPrimitiveComponent item2 in OutOverlappingComponents)
			{
				OnCollisionBeginOverlap(uShapeComponent, item2.GetOwner(), item2, 0, bFromSweep: false, default(FHitResult));
			}
		}
	}

	public void OnDisableOverlap()
	{
		foreach (TWeakObject<UPrimitiveComponent> collisionComponent in CollisionComponents)
		{
			collisionComponent.Get().GetOverlappingComponents(out var OutOverlappingComponents);
			foreach (UPrimitiveComponent item in OutOverlappingComponents)
			{
				OnCollisionEndOverlap(collisionComponent.Get(), item.GetOwner(), item, 0);
			}
			if (collisionComponent.IsValid())
			{
				UBGUFunctionLibraryForCS.BGUUnBindOnComponentBeginOverlapEvent(collisionComponent.Get(), FunctionBinder, B1GlobalFNames.OnCollisionBeginOverlap);
				UBGUFunctionLibraryForCS.BGUUnBindOnComponentEndOverlapEvent(collisionComponent.Get(), FunctionBinder, B1GlobalFNames.OnCollisionEndOverlap);
			}
		}
		CollisionComponents.Clear();
	}

	protected virtual void OnCollisionBeginOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult)
	{
		if (OtherActor == null || OtherActor as BGUCharacterCS == null)
		{
			return;
		}
		StateMachineData.GetCurrentSceneObjState(base.GuidData.GetFinalGuid(), out var GameplayTagContainerRef);
		if (!(OverlappedComponent.GetName() == "EndBox") || !GameplayTagContainerRef.HasTag(BGW_FlowUtils.SplineFlyMoveTag.State_Flying))
		{
			return;
		}
		if (SplineFlyMoveTriggerData.IsPlayerObserveMode)
		{
			BGUCharacterCS bGUCharacterCS = OtherActor as BGUCharacterCS;
			string OutActorGuid = "";
			bool flag = false;
			if (!bGUCharacterCS.IsNullOrDestroyed())
			{
				bGUCharacterCS.GetActorGuid(out OutActorGuid);
				foreach (SplineMoveConfig config in SplineFlyMoveTriggerData.Configs)
				{
					if (config.UnitGuid == OutActorGuid)
					{
						flag = true;
					}
				}
			}
			if (flag)
			{
				JumpToState(State_Actived);
			}
		}
		else
		{
			bool flag2 = !(OtherActor as BGUPlayerCharacterCS).IsNullOrDestroyed();
			if (flag2 && flag2)
			{
				JumpToState(State_Actived);
			}
		}
	}

	protected virtual void OnCollisionEndOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
	{
		if (!(OtherActor == null) && !(OtherActor as BGUPlayerCharacterCS).IsNullOrDestroyed())
		{
			NotifyGraph(BGW_FlowUtils.CommonTag.OverlapEnd);
			base.BGWEventCollection.Evt_BGS_PlayerLeaveOverlap(base.GuidData.GetFinalGuid());
		}
	}

	private void OnTamerSpawnUnit(string TamerGuid)
	{
		if (!base.Owner.IsNullOrDestroyed())
		{
			BGUCharacterCS bGUCharacterCS = BGU_DataUtil.GetActorByGuid(GetOwner(), TamerGuid) as BGUCharacterCS;
			if (!(bGUCharacterCS == null) && SplineFlyMoveTriggerData.CachedUnSpawnedConfig.TryGetValue(TamerGuid, out var value))
			{
				SetUnitFlyControllerInfo(bGUCharacterCS, value, Isplayer: false);
				SplineFlyMoveTriggerData.CachedUnSpawnedConfig.Remove(TamerGuid);
			}
		}
	}

	public void SetAllUnitFlyControllerInfo()
	{
		foreach (SplineMoveConfig config in SplineFlyMoveTriggerData.Configs)
		{
			BGUCharacterCS bGUCharacterCS = null;
			bool flag = false;
			if (config.UnitType == ESplineFlyUnitType.Player || config.UnitType == ESplineFlyUnitType.TransitionPlayer)
			{
				bGUCharacterCS = UBGUFunctionLibrary.GetPlayerCharacter(base.Owner) as BGUCharacterCS;
				flag = true;
			}
			else
			{
				bGUCharacterCS = BGU_DataUtil.GetActorByGuid(base.Owner, config.UnitGuid) as BGUCharacterCS;
				MarkTamerAlwaysSpawn(config.UnitGuid);
				flag = false;
			}
			if (bGUCharacterCS != null)
			{
				SetUnitFlyControllerInfo(bGUCharacterCS, config, flag);
			}
			else if (!SplineFlyMoveTriggerData.CachedUnSpawnedConfig.ContainsKey(config.UnitGuid))
			{
				SplineFlyMoveTriggerData.CachedUnSpawnedConfig.Add(config.UnitGuid, config);
			}
		}
	}

	public void MarkTamerAlwaysSpawn(string Guid)
	{
		base.BGSEventCollection.Evt_MarkTamerAlwaysSpawn.Invoke(Guid);
	}

	public void UnMarkTamerAlwaysSpawn(string Guid)
	{
		base.BGSEventCollection.Evt_UnMarkTamerAlwaysSpawn.Invoke(Guid);
	}

	public void SetUnitFlyControllerInfo(BGUCharacterCS Chr, SplineMoveConfig SplineMoveConfig, bool Isplayer)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Chr);
		BGUSplineActor splineActor = SplineMoveConfig.SplineActor.Value as BGUSplineActor;
		if (bUS_GSEventCollection != null && base.CurrentState == State_Flying)
		{
			bUS_GSEventCollection.Evt_SetSplineFlyControlInfo.Invoke(splineActor, default(FGSSplineFlyMoveInfo));
			bUS_GSEventCollection.Evt_SetMoveModeActive.Invoke(EBGUMoveMode.SplineFlyControl, SetActive: true);
			if (Isplayer)
			{
				bUS_GSEventCollection.Evt_SetTraceVelocityCameraInfo.Invoke(bUseTraceVelocityCamera: true, SplineFlyMoveTriggerData.TraceVelocityCameraSpeedRate);
				bUS_GSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.BanInputButCamera);
			}
			bUS_GSEventCollection.Evt_UpdateSpeedCtrlInfoBaseBySpdInfo.Invoke(SplineMoveConfig.JogSpeed, SplineMoveConfig.RunSpeed, SplineMoveConfig.SprintSpeed);
			bUS_GSEventCollection.Evt_SetFloatProperty.Invoke(EPropType.Movement_MaxFlySpeed, SplineMoveConfig.RunSpeed);
		}
	}

	public void JumpToFlyingState()
	{
		JumpToState(State_Flying, bSaveState: false);
	}

	public void FlyingStateTick(float DeltaTime)
	{
		foreach (SplineMoveConfig config in SplineFlyMoveTriggerData.Configs)
		{
			if (config.DelayTime > 0f)
			{
				config.DelayTime -= DeltaTime;
				continue;
			}
			BGUCharacterCS bGUCharacterCS = null;
			bGUCharacterCS = ((config.UnitType != ESplineFlyUnitType.Monster) ? (UBGUFunctionLibrary.GetPlayerCharacter(base.Owner) as BGUCharacterCS) : (BGU_DataUtil.GetActorByGuid(base.Owner, config.UnitGuid) as BGUCharacterCS));
			if (bGUCharacterCS != null)
			{
				config.FlyTime += DeltaTime;
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
				float floatValue = config.FlySpeedCurve.GetFloatValue(config.FlyTime);
				float num = floatValue / config.SprintSpeed;
				bUS_GSEventCollection.Evt_AISetSpeedRate.Invoke(num, EBGUSpeedCtrlID.MoveSpeedRate);
				EBUStateTrigger triggerID = ((floatValue < config.JogSpeed) ? EBUStateTrigger.AIInputWalk : ((!(floatValue < config.RunSpeed)) ? EBUStateTrigger.AIInputSprint : EBUStateTrigger.AIInputRun));
				bUS_GSEventCollection.Evt_SetCurFlySpeedRate.Invoke(num);
				bUS_GSEventCollection.Evt_UnitStateTrigger.Invoke(triggerID, 0f);
			}
		}
	}

	public void FlyinyEnd()
	{
		foreach (SplineMoveConfig config in SplineFlyMoveTriggerData.Configs)
		{
			BGUCharacterCS bGUCharacterCS = null;
			BUS_GSEventCollection bUS_GSEventCollection = null;
			if (config.UnitType == ESplineFlyUnitType.Player || config.UnitType == ESplineFlyUnitType.TransitionPlayer)
			{
				bGUCharacterCS = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner).GetControlledPawn() as BGUCharacterCS;
				bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
			}
			else
			{
				bGUCharacterCS = BGU_DataUtil.GetActorByGuid(base.Owner, config.UnitGuid) as BGUCharacterCS;
				UnMarkTamerAlwaysSpawn(config.UnitGuid);
				bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
			}
			if (bUS_GSEventCollection.IsNullOrDestroyed())
			{
				break;
			}
			if (SplineFlyMoveTriggerData.bUseTransform)
			{
				bUS_GSEventCollection.Evt_SetActorLocationAndRotation.Invoke(SplineFlyMoveTriggerData.PlayerEndTransform.GetLocation(), SplineFlyMoveTriggerData.PlayerEndTransform.Rotator(), bSweep: false, bTeleport: true);
			}
			if (SplineFlyMoveTriggerData.bDestoryControlledUnitInActived)
			{
				if (config.UnitType == ESplineFlyUnitType.Monster)
				{
					bUS_GSEventCollection.Evt_UnitDead.Invoke(bGUCharacterCS, EDeadReason.Suicide);
				}
			}
			else
			{
				bUS_GSEventCollection.Evt_AISetSpeedRate.Invoke(0f, EBGUSpeedCtrlID.MoveSpeedRate);
			}
		}
	}
}
