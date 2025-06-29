using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_QuestCovertTimerOverlapComp : BUS_StateMachineCompBase
{
	public class EnableState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.CheckerTag.State_Enabled;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.CheckerTag.Event_Disable, BGW_FlowUtils.CheckerTag.State_Disabled);
			base.EventTransitDictionary.Add(BGW_FlowUtils.SceneObjCommonEventTag.Next, BGW_FlowUtils.CheckerTag.State_Disabled);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_QuestCovertTimerOverlapComp bUS_QuestCovertTimerOverlapComp)
			{
				bUS_QuestCovertTimerOverlapComp.EnableChecker();
			}
		}
	}

	public class DisableState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.CheckerTag.State_Disabled;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.CheckerTag.Event_Enable, BGW_FlowUtils.CheckerTag.State_Enabled);
			base.EventTransitDictionary.Add(BGW_FlowUtils.SceneObjCommonEventTag.Next, BGW_FlowUtils.CheckerTag.State_Enabled);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_QuestCovertTimerOverlapComp bUS_QuestCovertTimerOverlapComp)
			{
				bUS_QuestCovertTimerOverlapComp.DisableChecker();
			}
		}
	}

	[UClass]
	[USharpPath("/Script/b1-Managed.QuestCovertTimerOverlapComp")]
	private class UQuestCovertTimerOverlapComp : UObject
	{
		private BUS_QuestCovertTimerOverlapComp OwnerComp;

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

		public void Init(BUS_QuestCovertTimerOverlapComp Component)
		{
			OwnerComp = Component;
		}

		[UFunction]
		[USharpPath("/Script/b1-Managed.QuestCovertTimerOverlapComp:OnCollisionBeginOverlap")]
		private void OnCollisionBeginOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult)
		{
			if (OwnerComp != null)
			{
				OwnerComp.OnCollisionBeginOverlap(OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex, bFromSweep, SweepResult);
			}
		}

		[UFunction]
		[USharpPath("/Script/b1-Managed.QuestCovertTimerOverlapComp:OnCollisionEndOverlap")]
		private void OnCollisionEndOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			if (OwnerComp != null)
			{
				OwnerComp.OnCollisionEndOverlap(OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex);
			}
		}

		[UFunctionInvoker("/Script/b1-Managed.QuestCovertTimerOverlapComp:OnCollisionEndOverlap")]
		private static void OnCollisionEndOverlap__Invoker(IntPtr buffer, IntPtr obj)
		{
			UQuestCovertTimerOverlapComp uQuestCovertTimerOverlapComp = GCHelper.Find<UQuestCovertTimerOverlapComp>(obj);
			UPrimitiveComponent overlappedComponent = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnCollisionEndOverlap_OverlappedComponent_Offset));
			AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnCollisionEndOverlap_OtherActor_Offset));
			UPrimitiveComponent otherComp = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnCollisionEndOverlap_OtherComp_Offset));
			int otherBodyIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnCollisionEndOverlap_OtherBodyIndex_Offset));
			uQuestCovertTimerOverlapComp.OnCollisionEndOverlap(overlappedComponent, otherActor, otherComp, otherBodyIndex);
		}

		[UFunctionInvoker("/Script/b1-Managed.QuestCovertTimerOverlapComp:OnCollisionBeginOverlap")]
		private static void OnCollisionBeginOverlap__Invoker(IntPtr buffer, IntPtr obj)
		{
			UQuestCovertTimerOverlapComp uQuestCovertTimerOverlapComp = GCHelper.Find<UQuestCovertTimerOverlapComp>(obj);
			UPrimitiveComponent overlappedComponent = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_OverlappedComponent_Offset));
			AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_OtherActor_Offset));
			UPrimitiveComponent otherComp = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_OtherComp_Offset));
			int otherBodyIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_OtherBodyIndex_Offset));
			bool bFromSweep = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_bFromSweep_Offset), 0, OnCollisionBeginOverlap_bFromSweep_PropertyAddress.Address);
			FHitResult sweepResult = FHitResult.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_SweepResult_Offset));
			uQuestCovertTimerOverlapComp.OnCollisionBeginOverlap(overlappedComponent, otherActor, otherComp, otherBodyIndex, bFromSweep, sweepResult);
		}

		private static void LoadNativeType()
		{
			IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.QuestCovertTimerOverlapComp");
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
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.QuestCovertTimerOverlapComp:OnCollisionEndOverlap", OnCollisionEndOverlap_IsValid);
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
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.QuestCovertTimerOverlapComp:OnCollisionBeginOverlap", OnCollisionBeginOverlap_IsValid);
		}

		static UQuestCovertTimerOverlapComp()
		{
			if (UnrealTypes.CanLazyLoadManagedType(typeof(UQuestCovertTimerOverlapComp)))
			{
				LoadNativeType();
			}
			UnrealTypes.OnCCtorCalled(typeof(UQuestCovertTimerOverlapComp));
		}
	}

	protected Dictionary<TWeakObject<UPrimitiveComponent>, bool> CollisionComponents = new Dictionary<TWeakObject<UPrimitiveComponent>, bool>();

	private TStrongObjectPtr<UQuestCovertTimerOverlapComp> mFunctionBinder = new TStrongObjectPtr<UQuestCovertTimerOverlapComp>();

	private bool OverlapEnable;

	private BUC_QuestCovertTimerOverlapData QuestCovertTimerOverlapData { get; set; }

	private UQuestCovertTimerOverlapComp FunctionBinder
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
		QuestCovertTimerOverlapData = RequireWritableData<BUC_QuestCovertTimerOverlapData>();
		base.SceneObjTag = BGW_FlowUtils.SceneObjTag.Checker;
		AddState(typeof(EnableState), 1);
		GSStateBase initialState = AddState(typeof(DisableState), 0);
		base.InitialState = initialState;
		FunctionBinder = UObject.NewObject<UQuestCovertTimerOverlapComp>(base.Owner);
		FunctionBinder.Init(this);
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		FunctionBinder = null;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		base.OnTickWithGroup(DeltaTime, TickGroup);
		InOrOutBoxCheck();
		InBox_RemainingTimeTick(DeltaTime);
		OutBox_RemainingTimeTick(DeltaTime);
	}

	private void InOrOutBoxCheck()
	{
		QuestCovertTimerOverlapData.bPlayerInBox = false;
		if (CollisionComponents.Count < 1)
		{
			return;
		}
		foreach (bool value in CollisionComponents.Values)
		{
			QuestCovertTimerOverlapData.bPlayerInBox |= value;
		}
	}

	private void InBox_RemainingTimeTick(float DeltaTime)
	{
		if (QuestCovertTimerOverlapData.bPlayerInBox)
		{
			QuestCovertTimerOverlapData.InBox_Remaining -= DeltaTime;
			if (QuestCovertTimerOverlapData.InBox_Remaining < 0f)
			{
				DisableChecker();
				NotifyGraph(BGW_FlowUtils.CommonTag.TimeOver);
			}
		}
	}

	private void OutBox_RemainingTimeTick(float DeltaTime)
	{
		if (QuestCovertTimerOverlapData.OutBox_Remaining != -1f && !QuestCovertTimerOverlapData.bPlayerInBox)
		{
			QuestCovertTimerOverlapData.OutBox_Remaining -= DeltaTime;
			if (QuestCovertTimerOverlapData.OutBox_Remaining < 0f)
			{
				DisableChecker();
				NotifyGraph(BGW_FlowUtils.CommonTag.TimeOut);
			}
		}
	}

	protected override void OnNotifyStartObserve()
	{
		if (OverlapEnable)
		{
			FixedOverlap();
		}
	}

	private void OnEnableOverlap()
	{
		foreach (UActorComponent item in base.Owner.GetComponentsByClass(UClass.GetClass<UPrimitiveComponent>()))
		{
			UBoxComponent uBoxComponent = item as UBoxComponent;
			if (!(uBoxComponent == null) && uBoxComponent.GetGenerateOverlapEvents())
			{
				TWeakObject<UPrimitiveComponent> key = new TWeakObject<UPrimitiveComponent>(uBoxComponent);
				CollisionComponents.Add(key, value: false);
				UBGUFunctionLibraryForCS.BGUBindOnComponentBeginOverlapEvent(uBoxComponent, FunctionBinder, B1GlobalFNames.OnCollisionBeginOverlap);
				UBGUFunctionLibraryForCS.BGUBindOnComponentEndOverlapEvent(uBoxComponent, FunctionBinder, B1GlobalFNames.OnCollisionEndOverlap);
			}
		}
		FixedOverlap();
		OverlapEnable = true;
		WriteLog("Enable Overlap");
	}

	private void FixedOverlap()
	{
		if (CollisionComponents.Count <= 0)
		{
			return;
		}
		List<TWeakObject<UPrimitiveComponent>> list = new List<TWeakObject<UPrimitiveComponent>>();
		list.AddRange(CollisionComponents.Keys);
		foreach (TWeakObject<UPrimitiveComponent> item in list)
		{
			item.Get().GetOverlappingActors(out var OverlappingActors, UClass.GetClass<AActor>());
			foreach (AActor item2 in OverlappingActors)
			{
				if (item2 is BGUCharacterCS { ECSArcheType: 5 })
				{
					CollisionComponents[item] = true;
					break;
				}
			}
		}
	}

	private void OnDisableOverlap()
	{
		if (CollisionComponents.Count > 0)
		{
			foreach (TWeakObject<UPrimitiveComponent> key in CollisionComponents.Keys)
			{
				UBGUFunctionLibraryForCS.BGUUnBindOnComponentBeginOverlapEvent(key.Get(), FunctionBinder, B1GlobalFNames.OnCollisionBeginOverlap);
				UBGUFunctionLibraryForCS.BGUUnBindOnComponentEndOverlapEvent(key.Get(), FunctionBinder, B1GlobalFNames.OnCollisionEndOverlap);
			}
		}
		OverlapEnable = false;
		WriteLog("Disable Overlap");
	}

	protected virtual void OnCollisionBeginOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult)
	{
		WriteLog("OnCollisionBeginOverlap");
		if (!(OtherActor == null) && OtherActor is BGUCharacterCS { ECSArcheType: 5 })
		{
			TWeakObject<UPrimitiveComponent> key = new TWeakObject<UPrimitiveComponent>(OverlappedComponent);
			if (CollisionComponents.ContainsKey(key))
			{
				CollisionComponents[key] = true;
			}
		}
	}

	protected virtual void OnCollisionEndOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
	{
		WriteLog("OnCollisionEndOverlap");
		if (!(OtherActor == null) && OtherActor is BGUCharacterCS { ECSArcheType: 5 })
		{
			TWeakObject<UPrimitiveComponent> key = new TWeakObject<UPrimitiveComponent>(OverlappedComponent);
			if (CollisionComponents.ContainsKey(key))
			{
				CollisionComponents[key] = false;
			}
		}
	}

	private void EnableChecker()
	{
		QuestCovertTimerOverlapData.bEnableCheck = true;
		SetCanTick(Val: true);
		OnEnableOverlap();
	}

	private void DisableChecker()
	{
		QuestCovertTimerOverlapData.bEnableCheck = false;
		SetCanTick(Val: false);
		OnDisableOverlap();
	}
}
