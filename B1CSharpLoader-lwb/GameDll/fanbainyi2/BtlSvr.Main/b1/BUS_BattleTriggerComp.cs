using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
internal class BUS_BattleTriggerComp : BUS_StateMachineCompBase
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
			if (InOwner is b1.BUS_BattleTriggerComp bUS_BattleTriggerComp)
			{
				bUS_BattleTriggerComp.OnEnable();
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
			if (InOwner is b1.BUS_BattleTriggerComp bUS_BattleTriggerComp)
			{
				bUS_BattleTriggerComp.OnDisable();
			}
		}
	}

	[UClass]
	[USharpPath("/Script/b1-Managed.OverlapCompFunctionBinder")]
	protected class UOverlapCompFunctionBinder : UObject
	{
		private b1.BUS_BattleTriggerComp OwnerComp;

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

		public void Init(b1.BUS_BattleTriggerComp Component)
		{
			OwnerComp = Component;
		}

		[UFunction]
		[USharpPath("/Script/b1-Managed.OverlapCompFunctionBinder:OnActorEnter")]
		private void OnActorEnter(AActor OverlappedActor, AActor OtherActor)
		{
			if (OverlappedActor != null)
			{
				OwnerComp.OnActorEnter(OverlappedActor, OtherActor);
			}
		}

		[UFunction]
		[USharpPath("/Script/b1-Managed.OverlapCompFunctionBinder:OnActorLeave")]
		private void OnActorLeave(AActor OverlappedActor, AActor OtherActor)
		{
			if (OverlappedActor != null)
			{
				OwnerComp.OnActorLeave(OverlappedActor, OtherActor);
			}
		}

		[UFunctionInvoker("/Script/b1-Managed.OverlapCompFunctionBinder:OnActorEnter")]
		private static void OnActorEnter__Invoker(IntPtr buffer, IntPtr obj)
		{
			UOverlapCompFunctionBinder uOverlapCompFunctionBinder = GCHelper.Find<UOverlapCompFunctionBinder>(obj);
			AActor overlappedActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnActorEnter_OverlappedActor_Offset));
			AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnActorEnter_OtherActor_Offset));
			uOverlapCompFunctionBinder.OnActorEnter(overlappedActor, otherActor);
		}

		[UFunctionInvoker("/Script/b1-Managed.OverlapCompFunctionBinder:OnActorLeave")]
		private static void OnActorLeave__Invoker(IntPtr buffer, IntPtr obj)
		{
			UOverlapCompFunctionBinder uOverlapCompFunctionBinder = GCHelper.Find<UOverlapCompFunctionBinder>(obj);
			AActor overlappedActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnActorLeave_OverlappedActor_Offset));
			AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnActorLeave_OtherActor_Offset));
			uOverlapCompFunctionBinder.OnActorLeave(overlappedActor, otherActor);
		}

		private static void LoadNativeType()
		{
			IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.OverlapCompFunctionBinder");
			OnActorEnter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnActorEnter");
			OnActorEnter_ParamsSize = NativeReflection.GetFunctionParamsSize(OnActorEnter_FunctionAddress);
			OnActorEnter_OverlappedActor_Offset = NativeReflection.GetPropertyOffset(OnActorEnter_FunctionAddress, "OverlappedActor");
			OnActorEnter_OverlappedActor_IsValid = NativeReflection.ValidatePropertyClass(OnActorEnter_FunctionAddress, "OverlappedActor", Classes.FObjectProperty);
			OnActorEnter_OtherActor_Offset = NativeReflection.GetPropertyOffset(OnActorEnter_FunctionAddress, "OtherActor");
			OnActorEnter_OtherActor_IsValid = NativeReflection.ValidatePropertyClass(OnActorEnter_FunctionAddress, "OtherActor", Classes.FObjectProperty);
			OnActorEnter_IsValid = OnActorEnter_FunctionAddress != IntPtr.Zero && OnActorEnter_OverlappedActor_IsValid && OnActorEnter_OtherActor_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.OverlapCompFunctionBinder:OnActorEnter", OnActorEnter_IsValid);
			OnActorLeave_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnActorLeave");
			OnActorLeave_ParamsSize = NativeReflection.GetFunctionParamsSize(OnActorLeave_FunctionAddress);
			OnActorLeave_OverlappedActor_Offset = NativeReflection.GetPropertyOffset(OnActorLeave_FunctionAddress, "OverlappedActor");
			OnActorLeave_OverlappedActor_IsValid = NativeReflection.ValidatePropertyClass(OnActorLeave_FunctionAddress, "OverlappedActor", Classes.FObjectProperty);
			OnActorLeave_OtherActor_Offset = NativeReflection.GetPropertyOffset(OnActorLeave_FunctionAddress, "OtherActor");
			OnActorLeave_OtherActor_IsValid = NativeReflection.ValidatePropertyClass(OnActorLeave_FunctionAddress, "OtherActor", Classes.FObjectProperty);
			OnActorLeave_IsValid = OnActorLeave_FunctionAddress != IntPtr.Zero && OnActorLeave_OverlappedActor_IsValid && OnActorLeave_OtherActor_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.OverlapCompFunctionBinder:OnActorLeave", OnActorLeave_IsValid);
		}

		static UOverlapCompFunctionBinder()
		{
			if (UnrealTypes.CanLazyLoadManagedType(typeof(UOverlapCompFunctionBinder)))
			{
				LoadNativeType();
			}
			UnrealTypes.OnCCtorCalled(typeof(UOverlapCompFunctionBinder));
		}
	}

	private b1.BUC_BattleTriggerData BattleTriggerData;

	private TStrongObjectPtr<UOverlapCompFunctionBinder> mFunctionBinder = new TStrongObjectPtr<UOverlapCompFunctionBinder>();

	protected UOverlapCompFunctionBinder FunctionBinder
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
		BattleTriggerData = RequireWritableData<b1.BUC_BattleTriggerData>();
		base.SceneObjTag = BGW_FlowUtils.SceneObjTag.OverlapBox;
		GSStateBase gSStateBase = AddState(typeof(EnableState), 1);
		GSStateBase gSStateBase2 = AddState(typeof(DisableState), 0);
		base.InitialState = (BattleTriggerData.bAutoEnableOverlap ? gSStateBase : gSStateBase2);
		FunctionBinder = UObject.NewObject<UOverlapCompFunctionBinder>(base.Owner);
		FunctionBinder.Init(this);
		base.BUSEventCollection.Evt_ResetActorStatus += new Del_Void_ResetActorReason(OnResetActorStatus);
		base.BGSEventCollection.Evt_NotifyTamerSpawnUnit += new Del_Void_String(OnTamerSpawnUnit);
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		base.Owner.GetOverlappingActors(out var OverlappingActors, UClass.GetClass<BGUPlayerCharacterCS>());
		foreach (AActor item in OverlappingActors)
		{
			BGUCharacterCS bGUCharacterCS = item as BGUCharacterCS;
			if (bGUCharacterCS == null || !bGUCharacterCS.IsPlayerControlled())
			{
				return;
			}
			BattleTriggerData.EnteredPlayerCount++;
			TryTriggerBattle();
			UpdateBattleUnitControl();
		}
		UBGUFunctionLibraryForCS.BGUBindOnActorBeginOverlapEvent(base.Owner, FunctionBinder, B1GlobalFNames.OnActorEnter);
		UBGUFunctionLibraryForCS.BGUBindOnActorEndOverlapEvent(base.Owner, FunctionBinder, B1GlobalFNames.OnActorLeave);
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

	private void OnTamerSpawnUnit(string TamerGuid)
	{
		IBGC_TamerData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<BGC_TamerData>(base.Owner);
		if (gameStateReadonlyData == null || !BattleTriggerData.bIsEnabled || BattleTriggerData.EnteredPlayerCount == 0)
		{
			return;
		}
		if (BattleTriggerData.BattleUnitConfigInfos.TryGetValue(TamerGuid, out var value))
		{
			BGUCharacterCS bGUCharacterCS = BGU_DataUtil.GetActorByGuid(base.Owner, value.UnitGuid) as BGUCharacterCS;
			if (bGUCharacterCS == null)
			{
				return;
			}
			if (value.SwitchTeamID != 0)
			{
				bGUCharacterCS.SetTeamIDInCS(value.SwitchTeamID);
			}
		}
		if (!BattleTriggerData.UnitBattleGroupInfo.TryGetValue(TamerGuid, out var value2))
		{
			return;
		}
		foreach (string item in value2)
		{
			BGUCharacterCS bGUCharacterCS2 = BGU_DataUtil.GetActorByGuid(base.Owner, item) as BGUCharacterCS;
			if (bGUCharacterCS2 == null || (!BGU_DataUtil.GetIsPlayer(bGUCharacterCS2) && !gameStateReadonlyData.IsUnitSpawnFinished(item)))
			{
				return;
			}
		}
		foreach (string item2 in value2)
		{
			FBattleTriggerUnitConfigInfo fBattleTriggerUnitConfigInfo = BattleTriggerData.BattleUnitConfigInfos[item2];
			if (fBattleTriggerUnitConfigInfo.TargetUnitGuid.Count == 0)
			{
				continue;
			}
			BGUCharacterCS obj = BGU_DataUtil.GetActorByGuid(base.Owner, item2) as BGUCharacterCS;
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(obj);
			UnitLockTargetInfo unitLockTargetInfo = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(obj)?.GetTargetInfo();
			if (obj == null || bUS_GSEventCollection == null || unitLockTargetInfo == null)
			{
				continue;
			}
			bool flag = unitLockTargetInfo.LockTargetActor == null;
			foreach (string item3 in fBattleTriggerUnitConfigInfo.TargetUnitGuid)
			{
				BGUCharacterCS bGUCharacterCS3 = BGU_DataUtil.GetActorByGuid(base.Owner, item3) as BGUCharacterCS;
				if (!(bGUCharacterCS3 == null) && flag)
				{
					bUS_GSEventCollection.Evt_AICatchTarget.Invoke(bGUCharacterCS3, ETargetSourceType.Target_BattleTriggerBoxAssignTarget);
					flag = true;
				}
			}
		}
	}

	private void TriggerBattleLogic()
	{
		IBGC_TamerData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<BGC_TamerData>(base.Owner);
		if (gameStateReadonlyData == null)
		{
			return;
		}
		foreach (KeyValuePair<string, FBattleTriggerUnitConfigInfo> battleUnitConfigInfo in BattleTriggerData.BattleUnitConfigInfos)
		{
			BGUCharacterCS bGUCharacterCS = BGU_DataUtil.GetActorByGuid(base.Owner, battleUnitConfigInfo.Key) as BGUCharacterCS;
			if (!(bGUCharacterCS == null))
			{
				BUS_EventCollectionCS.Get(bGUCharacterCS)?.Evt_BuffRemove.Invoke(999999, EBuffEffectTriggerType.None, 1);
				if (battleUnitConfigInfo.Value.SwitchTeamID != 0)
				{
					bGUCharacterCS.SetTeamIDInCS(battleUnitConfigInfo.Value.SwitchTeamID);
				}
			}
		}
		foreach (List<string> battleGroup in BattleTriggerData.BattleGroups)
		{
			bool flag = false;
			foreach (string item in battleGroup)
			{
				BGUCharacterCS bGUCharacterCS2 = BGU_DataUtil.GetActorByGuid(base.Owner, item) as BGUCharacterCS;
				if (bGUCharacterCS2 == null || (!BGU_DataUtil.GetIsPlayer(bGUCharacterCS2) && !gameStateReadonlyData.IsUnitSpawnFinished(item)))
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				continue;
			}
			foreach (string item2 in battleGroup)
			{
				FBattleTriggerUnitConfigInfo fBattleTriggerUnitConfigInfo = BattleTriggerData.BattleUnitConfigInfos[item2];
				if (fBattleTriggerUnitConfigInfo.TargetUnitGuid.Count == 0)
				{
					continue;
				}
				BGUCharacterCS obj = BGU_DataUtil.GetActorByGuid(base.Owner, item2) as BGUCharacterCS;
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(obj);
				UnitLockTargetInfo unitLockTargetInfo = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(obj)?.GetTargetInfo();
				if (obj == null || bUS_GSEventCollection == null || unitLockTargetInfo == null)
				{
					continue;
				}
				bool flag2 = unitLockTargetInfo.LockTargetActor == null;
				foreach (string item3 in fBattleTriggerUnitConfigInfo.TargetUnitGuid)
				{
					BGUCharacterCS bGUCharacterCS3 = BGU_DataUtil.GetActorByGuid(base.Owner, item3) as BGUCharacterCS;
					if (!(bGUCharacterCS3 == null) && flag2)
					{
						bUS_GSEventCollection.Evt_AICatchTarget.Invoke(bGUCharacterCS3, ETargetSourceType.Target_BattleTriggerBoxAssignTarget);
						flag2 = true;
					}
				}
			}
		}
	}

	private void TryTriggerBattle()
	{
		if (BattleTriggerData.bIsEnabled && BattleTriggerData.EnteredPlayerCount > 0)
		{
			TriggerBattleLogic();
		}
	}

	private void OnResetActorStatus(EResetActorReason ResetReason)
	{
		TryTriggerBattle();
		UpdateBattleUnitControl();
	}

	private void UpdateBattleUnitControl()
	{
		if (BattleTriggerData.bIsEnabled && BattleTriggerData.EnteredPlayerCount > 0)
		{
			if (!BattleTriggerData.bIsAlwaysSpawnUnit)
			{
				BattleTriggerData.bIsAlwaysSpawnUnit = true;
				base.BGSEventCollection.Evt_BGS_BattleTriggerMarkUnitControl.Invoke(BGU_DataUtil.GetActorGuid(base.Owner), BattleTriggerData.BattleUnitConfigInfos.Keys);
			}
		}
		else if (BattleTriggerData.bIsAlwaysSpawnUnit)
		{
			BattleTriggerData.bIsAlwaysSpawnUnit = false;
			base.BGSEventCollection.Evt_BGS_BattleTriggerUnMarkUnitControl.Invoke(BGU_DataUtil.GetActorGuid(base.Owner));
		}
	}

	protected void OnEnable()
	{
		if (!BattleTriggerData.bIsEnabled)
		{
			BattleTriggerData.bIsEnabled = true;
			TryTriggerBattle();
			UpdateBattleUnitControl();
		}
	}

	protected void OnDisable()
	{
		if (BattleTriggerData.bIsEnabled)
		{
			BattleTriggerData.bIsEnabled = false;
			UpdateBattleUnitControl();
		}
	}

	protected void OnActorEnter(AActor OverlappedActor, AActor OtherActor)
	{
		BGUCharacterCS bGUCharacterCS = OtherActor as BGUCharacterCS;
		if (!(bGUCharacterCS == null) && bGUCharacterCS.IsPlayerControlled())
		{
			BattleTriggerData.EnteredPlayerCount++;
			TryTriggerBattle();
			UpdateBattleUnitControl();
		}
	}

	protected void OnActorLeave(AActor OverlappedActor, AActor OtherActor)
	{
		BGUCharacterCS bGUCharacterCS = OtherActor as BGUCharacterCS;
		if (!(bGUCharacterCS == null) && bGUCharacterCS.IsPlayerControlled())
		{
			BattleTriggerData.EnteredPlayerCount--;
			UpdateBattleUnitControl();
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		if (BattleTriggerData.bIsAlwaysSpawnUnit)
		{
			BattleTriggerData.bIsAlwaysSpawnUnit = false;
			base.BGSEventCollection?.Evt_BGS_BattleTriggerUnMarkUnitControl.Invoke(BGU_DataUtil.GetActorGuid(base.Owner));
		}
		base.BGSEventCollection.Evt_NotifyTamerSpawnUnit -= new Del_Void_String(OnTamerSpawnUnit);
	}
}
