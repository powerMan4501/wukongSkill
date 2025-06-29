using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAIT_SwitchAttackAndWander")]
public class BAIT_SwitchAttackAndWander : BAIT_Base
{
	private static bool SwitchBattleFSMState_IsValid;

	private static int SwitchBattleFSMState_Offset;

	private static FFieldAddress SwitchBattleFSMState_PropertyAddress;

	private static bool MinWanderTime_IsValid;

	private static int MinWanderTime_Offset;

	private static bool MaxWanderTime_IsValid;

	private static int MaxWanderTime_Offset;

	private static bool MinComboNum_IsValid;

	private static int MinComboNum_Offset;

	private static bool MaxComboNum_IsValid;

	private static int MaxComboNum_Offset;

	private static bool OnPropertyChanged_IsValid;

	private static IntPtr OnPropertyChanged_FunctionAddress;

	private static int OnPropertyChanged_ParamsSize;

	private static bool OnPropertyChanged_MemberName_IsValid;

	private static int OnPropertyChanged_MemberName_Offset;

	private static FFieldAddress OnPropertyChanged_MemberName_PropertyAddress;

	private static bool OnPropertyChanged_PropertyName_IsValid;

	private static int OnPropertyChanged_PropertyName_Offset;

	private static FFieldAddress OnPropertyChanged_PropertyName_PropertyAddress;

	[DisplayName("切换类型")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_SwitchAttackAndWander:SwitchBattleFSMState")]
	public ESwitchBattleFSMState SwitchBattleFSMState
	{
		get
		{
			CheckDestroyed();
			if (!SwitchBattleFSMState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SwitchAttackAndWander:SwitchBattleFSMState");
				return ESwitchBattleFSMState.Attack;
			}
			return EnumMarshaler<ESwitchBattleFSMState>.FromNative(IntPtr.Add(base.Address, SwitchBattleFSMState_Offset), 0, SwitchBattleFSMState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SwitchBattleFSMState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SwitchAttackAndWander:SwitchBattleFSMState");
			}
			else
			{
				EnumMarshaler<ESwitchBattleFSMState>.ToNative(IntPtr.Add(base.Address, SwitchBattleFSMState_Offset), 0, SwitchBattleFSMState_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "SwitchBattleFSMState == ESwitchBattleFSMState::Wander")]
	[Tooltip("单位：秒")]
	[UMeta(MDProp.ClampMin, "0")]
	[UProperty]
	[EditAnywhere]
	[DisplayName("游走时间（最小值）")]
	[USharpPath("/Script/b1-Managed.BAIT_SwitchAttackAndWander:MinWanderTime")]
	public float MinWanderTime
	{
		get
		{
			CheckDestroyed();
			if (!MinWanderTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SwitchAttackAndWander:MinWanderTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinWanderTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinWanderTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SwitchAttackAndWander:MinWanderTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinWanderTime_Offset), value);
			}
		}
	}

	[DisplayName("游走时间（最大值）")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.ClampMin, "0")]
	[UMeta(MDProp.EditCondition, "SwitchBattleFSMState == ESwitchBattleFSMState::Wander")]
	[Tooltip("单位：秒")]
	[USharpPath("/Script/b1-Managed.BAIT_SwitchAttackAndWander:MaxWanderTime")]
	public float MaxWanderTime
	{
		get
		{
			CheckDestroyed();
			if (!MaxWanderTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SwitchAttackAndWander:MaxWanderTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxWanderTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxWanderTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SwitchAttackAndWander:MaxWanderTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxWanderTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("连招套数（最小值）")]
	[UMeta(MDProp.ClampMin, "0")]
	[UMeta(MDProp.EditCondition, "SwitchBattleFSMState == ESwitchBattleFSMState::Attack")]
	[USharpPath("/Script/b1-Managed.BAIT_SwitchAttackAndWander:MinComboNum")]
	public int MinComboNum
	{
		get
		{
			CheckDestroyed();
			if (!MinComboNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SwitchAttackAndWander:MinComboNum");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MinComboNum_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinComboNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SwitchAttackAndWander:MinComboNum");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MinComboNum_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("连招套数（最大值）")]
	[UMeta(MDProp.ClampMin, "0")]
	[UMeta(MDProp.EditCondition, "SwitchBattleFSMState == ESwitchBattleFSMState::Attack")]
	[USharpPath("/Script/b1-Managed.BAIT_SwitchAttackAndWander:MaxComboNum")]
	public int MaxComboNum
	{
		get
		{
			CheckDestroyed();
			if (!MaxComboNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SwitchAttackAndWander:MaxComboNum");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MaxComboNum_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxComboNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SwitchAttackAndWander:MaxComboNum");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MaxComboNum_Offset), value);
			}
		}
	}

	public override void ReceiveExecute(AActor OwnerActor)
	{
		if (OwnerActor is BGUCharacterCS actor)
		{
			switch (SwitchBattleFSMState)
			{
			case ESwitchBattleFSMState.Attack:
			{
				int num2 = MathLib.RandomIntInRange(MinComboNum, MaxComboNum);
				FMath.Clamp(num2, 0, num2);
				BUS_EventCollectionCS.Get(actor)?.Evt_SetMaxComboNum.Invoke(num2);
				BUS_EventCollectionCS.Get(actor)?.Evt_FSMEventTrigger.Invoke(EBGUFSMEventName.FSM_EVENT_BATTLE_ATTACK);
				break;
			}
			case ESwitchBattleFSMState.Wander:
			{
				float num = MathLib.RandomFloatInRange(MinWanderTime, MaxWanderTime);
				FMath.Clamp(num, 0f, num);
				BUS_EventCollectionCS.Get(actor)?.Evt_SetWatchTime.Invoke(num);
				BUS_EventCollectionCS.Get(actor)?.Evt_FSMEventTrigger.Invoke(EBGUFSMEventName.FSM_EVENT_BATTLE_WANDER);
				break;
			}
			}
		}
		FinishExecute(bSuccess: true);
	}

	[USharpPath("/Script/b1-Managed.BAIT_SwitchAttackAndWander:OnPropertyChanged")]
	protected override void OnPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
		if (PropertyName.Equals("SwitchBattleFSMState"))
		{
			ForceRefreshDetailView();
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAIT_SwitchAttackAndWander:OnPropertyChanged")]
	private static void OnPropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		BAIT_SwitchAttackAndWander bAIT_SwitchAttackAndWander = GCHelper.Find<BAIT_SwitchAttackAndWander>(obj);
		string memberName = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnPropertyChanged_MemberName_Offset));
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnPropertyChanged_PropertyName_Offset));
		bAIT_SwitchAttackAndWander.OnPropertyChanged_Implementation(memberName, propertyName);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAIT_SwitchAttackAndWander");
		NativeReflection.GetPropertyRef(ref SwitchBattleFSMState_PropertyAddress, intPtr, "SwitchBattleFSMState");
		SwitchBattleFSMState_Offset = NativeReflection.GetPropertyOffset(intPtr, "SwitchBattleFSMState");
		SwitchBattleFSMState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SwitchBattleFSMState", Classes.FEnumProperty);
		MinWanderTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "MinWanderTime");
		MinWanderTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MinWanderTime", Classes.FFloatProperty);
		MaxWanderTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxWanderTime");
		MaxWanderTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxWanderTime", Classes.FFloatProperty);
		MinComboNum_Offset = NativeReflection.GetPropertyOffset(intPtr, "MinComboNum");
		MinComboNum_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MinComboNum", Classes.FIntProperty);
		MaxComboNum_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxComboNum");
		MaxComboNum_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxComboNum", Classes.FIntProperty);
		OnPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPropertyChanged");
		OnPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPropertyChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnPropertyChanged_MemberName_PropertyAddress, OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_Offset = NativeReflection.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_IsValid = NativeReflection.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref OnPropertyChanged_PropertyName_PropertyAddress, OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_Offset = NativeReflection.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		OnPropertyChanged_IsValid = OnPropertyChanged_FunctionAddress != IntPtr.Zero && OnPropertyChanged_MemberName_IsValid && OnPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAIT_SwitchAttackAndWander:OnPropertyChanged", OnPropertyChanged_IsValid);
	}

	static BAIT_SwitchAttackAndWander()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BAIT_SwitchAttackAndWander)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BAIT_SwitchAttackAndWander));
	}
}
