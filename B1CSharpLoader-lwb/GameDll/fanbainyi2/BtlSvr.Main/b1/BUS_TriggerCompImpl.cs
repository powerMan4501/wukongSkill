using System;
using System.Collections.Generic;
using b1.ECS;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_TriggerCompImpl : BUS_StateMachineCompBase
{
	public class UnTriggeredState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.TriggerTag.State_UnTriggered;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.TriggerTag.Event_Trigger, BGW_FlowUtils.TriggerTag.State_Triggering);
			base.EventTransitDictionary.Add(BGW_FlowUtils.TriggerTag.Event_TriggerComplete, BGW_FlowUtils.TriggerTag.State_Triggered);
			base.EventTransitDictionary.Add(BGW_FlowUtils.SceneObjCommonEventTag.Next, BGW_FlowUtils.TriggerTag.State_Triggering);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is b1.BUS_TriggerCompImpl bUS_TriggerCompImpl && bUS_TriggerCompImpl.TriggerData.TriggerType == ETriggerType.Overlap && bUS_TriggerCompImpl.OverlapBox != null)
			{
				bUS_TriggerCompImpl.OverlapBox.SetGenerateOverlapEvents(bInGenerateOverlapEvents: true);
			}
		}
	}

	public class TriggeringState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.TriggerTag.State_Triggering;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.TriggerTag.Event_TriggerComplete, BGW_FlowUtils.TriggerTag.State_Triggered);
			base.EventTransitDictionary.Add(BGW_FlowUtils.SceneObjCommonEventTag.Next, BGW_FlowUtils.TriggerTag.State_Triggered);
			base.EventTransitDictionary.Add(BGW_FlowUtils.TriggerTag.Event_Reset, BGW_FlowUtils.TriggerTag.State_UnTriggered);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (!(InOwner is b1.BUS_TriggerCompImpl bUS_TriggerCompImpl))
			{
				return;
			}
			if (bUS_TriggerCompImpl.InteractData != null)
			{
				FUStInteractiveUnitCommDesc interactiveUnitCommDesc = BGW_GameDB.GetInteractiveUnitCommDesc(bUS_TriggerCompImpl.InteractData.InteractiveUnitID);
				if (interactiveUnitCommDesc != null && interactiveUnitCommDesc.InteractType == EInteractType.StandardObj)
				{
					return;
				}
			}
			bUS_TriggerCompImpl.OnEvent(BGW_FlowUtils.SceneObjCommonEventTag.Next);
		}
	}

	public class TriggeredState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.TriggerTag.State_Triggered;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.TriggerTag.Event_Reset, BGW_FlowUtils.TriggerTag.State_UnTriggered);
			base.EventTransitDictionary.Add(BGW_FlowUtils.SceneObjCommonEventTag.Next, BGW_FlowUtils.TriggerTag.State_UnTriggered);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is b1.BUS_TriggerCompImpl bUS_TriggerCompImpl && bUS_TriggerCompImpl.TriggerData.TriggerType == ETriggerType.Overlap && bUS_TriggerCompImpl.OverlapBox != null && !bUS_TriggerCompImpl.TriggerData.bEnableSwitch)
			{
				bUS_TriggerCompImpl.OverlapBox.SetGenerateOverlapEvents(bInGenerateOverlapEvents: false);
			}
		}
	}

	[UClass]
	[USharpPath("/Script/b1-Managed.TriggerCompFunctionBinder")]
	private class UTriggerCompFunctionBinder : UObject
	{
		private b1.BUS_TriggerCompImpl OwnerComp;

		private static bool OnCollisionOverlap_IsValid;

		private static IntPtr OnCollisionOverlap_FunctionAddress;

		private static int OnCollisionOverlap_ParamsSize;

		private static bool OnCollisionOverlap_OverlappedComponent_IsValid;

		private static int OnCollisionOverlap_OverlappedComponent_Offset;

		private static bool OnCollisionOverlap_OtherActor_IsValid;

		private static int OnCollisionOverlap_OtherActor_Offset;

		private static bool OnCollisionOverlap_OtherComp_IsValid;

		private static int OnCollisionOverlap_OtherComp_Offset;

		private static bool OnCollisionOverlap_OtherBodyIndex_IsValid;

		private static int OnCollisionOverlap_OtherBodyIndex_Offset;

		private static bool OnCollisionOverlap_bFromSweep_IsValid;

		private static int OnCollisionOverlap_bFromSweep_Offset;

		private static FFieldAddress OnCollisionOverlap_bFromSweep_PropertyAddress;

		private static bool OnCollisionOverlap_SweepResult_IsValid;

		private static int OnCollisionOverlap_SweepResult_Offset;

		private static FFieldAddress OnCollisionOverlap_SweepResult_PropertyAddress;

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

		public void Init(b1.BUS_TriggerCompImpl Component)
		{
			OwnerComp = Component;
		}

		[UFunction]
		[USharpPath("/Script/b1-Managed.TriggerCompFunctionBinder:OnCollisionOverlap")]
		private void OnCollisionOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult)
		{
			if (OwnerComp != null)
			{
				OwnerComp.OnCollisionOverlap(OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex, bFromSweep, SweepResult);
			}
		}

		[UFunction]
		[USharpPath("/Script/b1-Managed.TriggerCompFunctionBinder:OnCollisionEndOverlap")]
		private void OnCollisionEndOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			if (OwnerComp != null)
			{
				OwnerComp.OnCollisionEndOverlap(OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex);
			}
		}

		[UFunctionInvoker("/Script/b1-Managed.TriggerCompFunctionBinder:OnCollisionOverlap")]
		private static void OnCollisionOverlap__Invoker(IntPtr buffer, IntPtr obj)
		{
			UTriggerCompFunctionBinder uTriggerCompFunctionBinder = GCHelper.Find<UTriggerCompFunctionBinder>(obj);
			UPrimitiveComponent overlappedComponent = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnCollisionOverlap_OverlappedComponent_Offset));
			AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnCollisionOverlap_OtherActor_Offset));
			UPrimitiveComponent otherComp = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnCollisionOverlap_OtherComp_Offset));
			int otherBodyIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnCollisionOverlap_OtherBodyIndex_Offset));
			bool bFromSweep = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnCollisionOverlap_bFromSweep_Offset), 0, OnCollisionOverlap_bFromSweep_PropertyAddress.Address);
			FHitResult sweepResult = FHitResult.FromNative(IntPtr.Add(buffer, OnCollisionOverlap_SweepResult_Offset));
			uTriggerCompFunctionBinder.OnCollisionOverlap(overlappedComponent, otherActor, otherComp, otherBodyIndex, bFromSweep, sweepResult);
		}

		[UFunctionInvoker("/Script/b1-Managed.TriggerCompFunctionBinder:OnCollisionEndOverlap")]
		private static void OnCollisionEndOverlap__Invoker(IntPtr buffer, IntPtr obj)
		{
			UTriggerCompFunctionBinder uTriggerCompFunctionBinder = GCHelper.Find<UTriggerCompFunctionBinder>(obj);
			UPrimitiveComponent overlappedComponent = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnCollisionEndOverlap_OverlappedComponent_Offset));
			AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnCollisionEndOverlap_OtherActor_Offset));
			UPrimitiveComponent otherComp = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnCollisionEndOverlap_OtherComp_Offset));
			int otherBodyIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnCollisionEndOverlap_OtherBodyIndex_Offset));
			uTriggerCompFunctionBinder.OnCollisionEndOverlap(overlappedComponent, otherActor, otherComp, otherBodyIndex);
		}

		private static void LoadNativeType()
		{
			IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.TriggerCompFunctionBinder");
			OnCollisionOverlap_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnCollisionOverlap");
			OnCollisionOverlap_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCollisionOverlap_FunctionAddress);
			OnCollisionOverlap_OverlappedComponent_Offset = NativeReflection.GetPropertyOffset(OnCollisionOverlap_FunctionAddress, "OverlappedComponent");
			OnCollisionOverlap_OverlappedComponent_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionOverlap_FunctionAddress, "OverlappedComponent", Classes.FObjectProperty);
			OnCollisionOverlap_OtherActor_Offset = NativeReflection.GetPropertyOffset(OnCollisionOverlap_FunctionAddress, "OtherActor");
			OnCollisionOverlap_OtherActor_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionOverlap_FunctionAddress, "OtherActor", Classes.FObjectProperty);
			OnCollisionOverlap_OtherComp_Offset = NativeReflection.GetPropertyOffset(OnCollisionOverlap_FunctionAddress, "OtherComp");
			OnCollisionOverlap_OtherComp_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionOverlap_FunctionAddress, "OtherComp", Classes.FObjectProperty);
			OnCollisionOverlap_OtherBodyIndex_Offset = NativeReflection.GetPropertyOffset(OnCollisionOverlap_FunctionAddress, "OtherBodyIndex");
			OnCollisionOverlap_OtherBodyIndex_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionOverlap_FunctionAddress, "OtherBodyIndex", Classes.FIntProperty);
			NativeReflection.GetPropertyRef(ref OnCollisionOverlap_bFromSweep_PropertyAddress, OnCollisionOverlap_FunctionAddress, "bFromSweep");
			OnCollisionOverlap_bFromSweep_Offset = NativeReflection.GetPropertyOffset(OnCollisionOverlap_FunctionAddress, "bFromSweep");
			OnCollisionOverlap_bFromSweep_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionOverlap_FunctionAddress, "bFromSweep", Classes.FBoolProperty);
			NativeReflection.GetPropertyRef(ref OnCollisionOverlap_SweepResult_PropertyAddress, OnCollisionOverlap_FunctionAddress, "SweepResult");
			OnCollisionOverlap_SweepResult_Offset = NativeReflection.GetPropertyOffset(OnCollisionOverlap_FunctionAddress, "SweepResult");
			OnCollisionOverlap_SweepResult_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionOverlap_FunctionAddress, "SweepResult", Classes.FStructProperty);
			OnCollisionOverlap_IsValid = OnCollisionOverlap_FunctionAddress != IntPtr.Zero && OnCollisionOverlap_OverlappedComponent_IsValid && OnCollisionOverlap_OtherActor_IsValid && OnCollisionOverlap_OtherComp_IsValid && OnCollisionOverlap_OtherBodyIndex_IsValid && OnCollisionOverlap_bFromSweep_IsValid && OnCollisionOverlap_SweepResult_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.TriggerCompFunctionBinder:OnCollisionOverlap", OnCollisionOverlap_IsValid);
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
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.TriggerCompFunctionBinder:OnCollisionEndOverlap", OnCollisionEndOverlap_IsValid);
		}

		static UTriggerCompFunctionBinder()
		{
			if (UnrealTypes.CanLazyLoadManagedType(typeof(UTriggerCompFunctionBinder)))
			{
				LoadNativeType();
			}
			UnrealTypes.OnCCtorCalled(typeof(UTriggerCompFunctionBinder));
		}
	}

	private TStrongObjectPtr<UTriggerCompFunctionBinder> mFunctionBinder = new TStrongObjectPtr<UTriggerCompFunctionBinder>();

	private b1.BUC_TriggerData TriggerData { get; set; }

	private IBUC_InteractData InteractData { get; set; }

	private IBIC_GlobalActorData GlobalActorData { get; set; }

	private UBoxComponent OverlapBox { get; set; }

	private UTriggerCompFunctionBinder FunctionBinder
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
		TriggerData = RequireWritableData<b1.BUC_TriggerData>();
		InteractData = RequireReadOnlyData<IBUC_InteractData, BUC_InteractData>();
		GlobalActorData = RequireReadonlyGameInstanceData<IBIC_GlobalActorData, BIC_GlobalActorData>();
		base.SceneObjTag = BGW_FlowUtils.SceneObjTag.Trigger;
		base.BUSEventCollection.Evt_SetTriggerActors += new Del_Void_StringList(OnSetTriggerActors);
		GSStateBase initialState = AddState(typeof(UnTriggeredState), 0);
		AddState(typeof(TriggeringState), 1);
		AddState(typeof(TriggeredState), 2);
		base.InitialState = initialState;
		FunctionBinder = UObject.NewObject<UTriggerCompFunctionBinder>(base.Owner);
		FunctionBinder.Init(this);
	}

	public override void OnNetActive()
	{
		base.OnNetActive();
		TriggerData.RangeCheckTimer = 0.5f;
		InitOverlapCollision();
		InitTriggerCharacterGuid();
	}

	private void InitTriggerCharacterGuid()
	{
		if (TriggerData.TriggerCharacter != null)
		{
			TriggerData.TriggerCharacterGuid = BGU_DataUtil.GetActorGuid(TriggerData.TriggerCharacter);
		}
		else if (TriggerData.TriggerCharacterGuid.Length > 0)
		{
			TriggerData.TriggerCharacterGuid = BGUFuncLibSceneObj.BGUGetStandardGuidStr(TriggerData.TriggerCharacterGuid);
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if ((TriggerData.TriggerType != ETriggerType.CharacterState && TriggerData.TriggerType != ETriggerType.CharacterAttr && TriggerData.TriggerType != ETriggerType.CircleRangeCharacterDie) || (!TriggerData.bEnableSwitch && !GameplayTagExtension.IsTag(base.CurrentState.StateTag, BGW_FlowUtils.TriggerTag.State_UnTriggered)))
		{
			return;
		}
		if (TriggerData.TriggerType == ETriggerType.CircleRangeCharacterDie)
		{
			UpdateCircleRangeCharacterDie(DeltaTime);
			return;
		}
		AttachTriggerCharacter();
		if (TriggerData.TriggerType == ETriggerType.CharacterState && TriggerData.bUnitState && TriggerData.UnitState == EBGUUnitState.Dead && GlobalActorData.IsActorInitDataInitialized(TriggerData.TriggerCharacterGuid))
		{
			bool bTrigger = !GlobalActorData.GetActorAliveState(TriggerData.TriggerCharacterGuid);
			UpdateTriggerState(bTrigger);
			return;
		}
		if ((TriggerData.TriggerType == ETriggerType.CharacterState || TriggerData.TriggerType == ETriggerType.CharacterAttr) && !TriggerData.bAttachedTriggerCharacter)
		{
			UpdateTriggerState(TriggerData.TriggerStateWhenTriggerCharacterInvalid);
			return;
		}
		switch (TriggerData.TriggerType)
		{
		case ETriggerType.CharacterState:
			UpdateCharacterStateTrigger();
			break;
		case ETriggerType.CharacterAttr:
			UpdateCharacterAttrTrigger();
			break;
		}
	}

	private void InitOverlapCollision()
	{
		if (TriggerData.TriggerType != ETriggerType.Overlap)
		{
			return;
		}
		UBoxComponent componentByClass = GetOwner().GetComponentByClass<UBoxComponent>();
		if (!(componentByClass == null))
		{
			OverlapBox = componentByClass;
			UBGUFunctionLibraryForCS.BGUBindOnComponentBeginOverlapEvent(OverlapBox, FunctionBinder, B1GlobalFNames.OnCollisionOverlap);
			if (TriggerData.bEndOverlapTrigger)
			{
				UBGUFunctionLibraryForCS.BGUBindOnComponentEndOverlapEvent(OverlapBox, FunctionBinder, B1GlobalFNames.OnCollisionEndOverlap);
			}
		}
	}

	private void AttachTriggerCharacter()
	{
		if (TriggerData.TriggerCharacter != null)
		{
			TriggerData.bAttachedTriggerCharacter = true;
		}
		else if (!TriggerData.TriggerCharacterGuid.Equals(string.Empty))
		{
			TriggerData.TriggerCharacter = BGU_DataUtil.GetActorByGuid(GetOwner(), TriggerData.TriggerCharacterGuid) as ACharacter;
			TriggerData.bAttachedTriggerCharacter = TriggerData.TriggerCharacter != null;
		}
	}

	private void OnCollisionOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult)
	{
		if (OtherActor == null || TriggerData.TriggerType != ETriggerType.Overlap)
		{
			return;
		}
		if (TriggerData.bEndOverlapTrigger)
		{
			FVector velocity = OtherActor.GetVelocity();
			velocity.Normalize();
			TriggerData.BeginOverlapDir.Add(ECSUtil.ToEntity(OtherActor), velocity);
			return;
		}
		BUC_ActorBasicData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_ActorBasicData>(OtherActor);
		if (readOnlyData != null && readOnlyData.ActorType == BGU_ActorType.CharacterPlayer)
		{
			TriggerData.TriggerActorGuid = BGU_DataUtil.GetActorGuid(OtherActor);
			OnEvent(BGW_FlowUtils.SceneObjCommonEventTag.Next);
		}
	}

	private void OnCollisionEndOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
	{
		if (OtherActor == null || TriggerData.TriggerType != ETriggerType.Overlap)
		{
			return;
		}
		Entity key = ECSUtil.ToEntity(OtherActor);
		if (!TriggerData.BeginOverlapDir.ContainsKey(key))
		{
			return;
		}
		FVector velocity = OtherActor.GetVelocity();
		velocity.Normalize();
		float num = FVector.DotProduct(TriggerData.BeginOverlapDir[key], OverlapBox.GetForwardVector());
		float num2 = FVector.DotProduct(velocity, OverlapBox.GetForwardVector());
		float num3 = num * num2;
		TriggerData.BeginOverlapDir.Remove(key);
		if ((TriggerData.BeginEndOverlapTriggerDirectionType != EBeginEndOverlapTriggerDirectionType.SameDirection || !(num3 < 0f)) && (TriggerData.BeginEndOverlapTriggerDirectionType != EBeginEndOverlapTriggerDirectionType.DiffDirection || !(num3 >= 0f)))
		{
			BUC_ActorBasicData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_ActorBasicData>(OtherActor);
			if (readOnlyData != null && readOnlyData.ActorType == BGU_ActorType.CharacterPlayer)
			{
				TriggerData.TriggerActorGuid = BGU_DataUtil.GetActorGuid(OtherActor);
				OnEvent(BGW_FlowUtils.SceneObjCommonEventTag.Next);
			}
		}
	}

	private void UpdateCharacterStateTrigger()
	{
		if (TriggerData.TriggerType == ETriggerType.CharacterState && BGU_DataUtil.GetReadOnlyData<IBUC_GuidData, BUC_GuidData>(TriggerData.TriggerCharacter) != null)
		{
			bool flag = TriggerData.bCharacterActiveState || TriggerData.bUnitState || TriggerData.bSimpleState;
			if (TriggerData.bCharacterActiveState)
			{
				IBUC_TargetInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(TriggerData.TriggerCharacter);
				flag &= readOnlyData.GetTargetInfo().LockTargetEntity != Entity.Null;
			}
			if (TriggerData.bUnitState)
			{
				flag &= BGU_DataUtil.GetReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(TriggerData.TriggerCharacter)?.HasState(TriggerData.UnitState) ?? false;
			}
			if (TriggerData.bSimpleState)
			{
				flag &= BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(TriggerData.TriggerCharacter)?.HasSimpleState(TriggerData.SimpleState) ?? false;
			}
			UpdateTriggerState(flag);
		}
	}

	private void UpdateCharacterAttrTrigger()
	{
		if (TriggerData.TriggerType != ETriggerType.CharacterAttr)
		{
			return;
		}
		IBUC_AttrContainer readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>(TriggerData.TriggerCharacter);
		if (readOnlyData != null)
		{
			bool flag = true;
			if (TriggerData.bCompareRatio)
			{
				float ori = (readOnlyData.GetFloatValue(TriggerData.AttrFloatType) - readOnlyData.GetFloatValMin(TriggerData.AttrFloatType)) / (readOnlyData.GetFloatValMax(TriggerData.AttrFloatType) - readOnlyData.GetFloatValMin(TriggerData.AttrFloatType));
				flag &= AIFuncLibForCS.CompareValue(ori, TriggerData.CompareValue, TriggerData.CompareType);
			}
			else
			{
				flag &= AIFuncLibForCS.CompareValue(readOnlyData.GetFloatValue(TriggerData.AttrFloatType), TriggerData.CompareValue, TriggerData.CompareType);
			}
			UpdateTriggerState(flag);
		}
	}

	private void UpdateTriggerState(bool bTrigger)
	{
		if (!bTrigger && !GameplayTagExtension.IsTag(base.CurrentState.StateTag, BGW_FlowUtils.TriggerTag.State_UnTriggered))
		{
			TriggerData.TriggerActorGuid = BGU_DataUtil.GetActorGuid(TriggerData.TriggerCharacter);
			OnEvent(BGW_FlowUtils.SceneObjCommonEventTag.Spawn);
		}
		if (bTrigger && !GameplayTagExtension.IsTag(base.CurrentState.StateTag, BGW_FlowUtils.TriggerTag.State_Triggered))
		{
			TriggerData.TriggerActorGuid = BGU_DataUtil.GetActorGuid(TriggerData.TriggerCharacter);
			OnEvent(BGW_FlowUtils.SceneObjCommonEventTag.Next);
		}
	}

	private void UpdateCircleRangeCharacterDie(float DeltaTime)
	{
		TriggerData.RangeCheckTimer -= DeltaTime;
		if (TriggerData.RangeCheckTimer > 0f)
		{
			return;
		}
		TriggerData.RangeCheckTimer = 0.5f;
		bool bTrigger = true;
		foreach (string actorDataKey in GlobalActorData.GetActorDataKeys())
		{
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(base.Owner, actorDataKey);
			if (!(actorByGuid == null) && ((IBUC_ActorBasicData)BGU_DataUtil.GetReadOnlyData<BUC_ActorBasicData>(actorByGuid)).ActorType == BGU_ActorType.CharacterAI && !(FVector.Dist(BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner()), BGUFuncLibActorTransformCS.BGUGetActorLocation(actorByGuid)) > TriggerData.CircleRadius) && GlobalActorData.GetActorAliveState(actorDataKey))
			{
				bTrigger = false;
				break;
			}
		}
		UpdateTriggerState(bTrigger);
	}

	private void OnSetTriggerActors(List<string> TriggerActorsGuid)
	{
		TriggerData.TriggerActorGuid = ((TriggerActorsGuid != null && TriggerActorsGuid.Count > 0) ? TriggerActorsGuid[0] : "");
	}

	protected override void OnReset()
	{
		bool bEnableSwitch = TriggerData.bEnableSwitch;
		TriggerData.bEnableSwitch = true;
		OnSpawn();
		TriggerData.bEnableSwitch = bEnableSwitch;
	}
}
