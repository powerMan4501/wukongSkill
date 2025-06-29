using System;
using BtlShare;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Attack State")]
[USharpPath("/Script/b1-Managed.BANS_GSAttackState")]
internal class BANS_GSAttackState : BANS_GSBase
{
	private static int MAGIC_BUFF_ID;

	private static bool EnableMove_IsValid;

	private static int EnableMove_Offset;

	private static FFieldAddress EnableMove_PropertyAddress;

	private static bool KeepMMRunning_IsValid;

	private static int KeepMMRunning_Offset;

	private static FFieldAddress KeepMMRunning_PropertyAddress;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	private static bool GSAllowCrossSection_IsValid;

	private static IntPtr GSAllowCrossSection_FunctionAddress;

	private static int GSAllowCrossSection_ParamsSize;

	private static bool GSAllowCrossSection_ReturnValue_IsValid;

	private static int GSAllowCrossSection_ReturnValue_Offset;

	private static FFieldAddress GSAllowCrossSection_ReturnValue_PropertyAddress;

	private static bool GSOnSectionManuallyChanged_IsValid;

	private static IntPtr GSOnSectionManuallyChanged_FunctionAddress;

	private static int GSOnSectionManuallyChanged_ParamsSize;

	private static bool GSOnSectionManuallyChanged_OwnerChar_IsValid;

	private static int GSOnSectionManuallyChanged_OwnerChar_Offset;

	private static bool GSOnSectionManuallyChanged_RemainingDuration_IsValid;

	private static int GSOnSectionManuallyChanged_RemainingDuration_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackState:EnableMove")]
	public bool EnableMove
	{
		get
		{
			CheckDestroyed();
			if (!EnableMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackState:EnableMove");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableMove_Offset), 0, EnableMove_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackState:EnableMove");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableMove_Offset), 0, EnableMove_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Anim Notify")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackState:KeepMMRunning")]
	public bool KeepMMRunning
	{
		get
		{
			CheckDestroyed();
			if (!KeepMMRunning_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackState:KeepMMRunning");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, KeepMMRunning_Offset), 0, KeepMMRunning_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!KeepMMRunning_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackState:KeepMMRunning");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, KeepMMRunning_Offset), 0, KeepMMRunning_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.AnimNSType = EGsEnAnimNS.AttackState;
		EnableMove = false;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSAttackState:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		if (UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(NotifyParam.owner))
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_UnitStateTrigger.Invoke(EBUStateTrigger.AttackStateBegin, TotalDuration, NeedForceUpdate: true);
			if (EnableMove)
			{
				BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_UnitStateTrigger.Invoke(EBUStateTrigger.EnableMoveInSkill, TotalDuration, NeedForceUpdate: true);
			}
			if (KeepMMRunning)
			{
				BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_BuffAdd.Invoke(MAGIC_BUFF_ID, bGUCharacterCS, bGUCharacterCS, TotalDuration * 1000f, EBuffSourceType.Notify);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSAttackState:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		if (!UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(NotifyParam.owner) && KeepMMRunning)
		{
			BUS_EventCollectionCS.Get(NotifyParam.owner).Evt_BuffRemove.Invoke(MAGIC_BUFF_ID, EBuffEffectTriggerType.None, 1);
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSAttackState:GSAllowCrossSection")]
	protected override bool GSAllowCrossSection_Implementation()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSAttackState:GSOnSectionManuallyChanged")]
	protected override void GSOnSectionManuallyChanged_Implementation(ABGUCharacter OwnerChar, float RemainingDuration)
	{
		if (!(OwnerChar == null))
		{
			if (BGUFunctionLibraryCS.BGUHasUnitState(OwnerChar, EBGUUnitState.Attacking))
			{
				BUS_EventCollectionCS.Get(OwnerChar).Evt_UnitStateTrigger.Invoke(EBUStateTrigger.AttackStateBegin, RemainingDuration, NeedForceUpdate: true);
			}
			if (BGUFunctionLibraryCS.BGUHasUnitState(OwnerChar, EBGUUnitState.AttackMoving))
			{
				BUS_EventCollectionCS.Get(OwnerChar).Evt_UnitStateTrigger.Invoke(EBUStateTrigger.EnableMoveInSkill, RemainingDuration, NeedForceUpdate: true);
			}
		}
	}

	static BANS_GSAttackState()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSAttackState)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSAttackState));
		MAGIC_BUFF_ID = 113;
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSAttackState:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSAttackState bANS_GSAttackState = GCHelper.Find<b1.BANS_GSAttackState>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSAttackState.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSAttackState:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSAttackState bANS_GSAttackState = GCHelper.Find<b1.BANS_GSAttackState>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSAttackState.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSAttackState:GSAllowCrossSection")]
	private static void GSAllowCrossSection__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSAttackState bANS_GSAttackState = GCHelper.Find<b1.BANS_GSAttackState>(obj);
		bool value = bANS_GSAttackState.GSAllowCrossSection_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, GSAllowCrossSection_ReturnValue_Offset), 0, GSAllowCrossSection_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSAttackState:GSOnSectionManuallyChanged")]
	private static void GSOnSectionManuallyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSAttackState bANS_GSAttackState = GCHelper.Find<b1.BANS_GSAttackState>(obj);
		ABGUCharacter ownerChar = UObjectMarshaler<ABGUCharacter>.FromNative(IntPtr.Add(buffer, GSOnSectionManuallyChanged_OwnerChar_Offset));
		float remainingDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSOnSectionManuallyChanged_RemainingDuration_Offset));
		bANS_GSAttackState.GSOnSectionManuallyChanged_Implementation(ownerChar, remainingDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSAttackState");
		NativeReflection.GetPropertyRef(ref EnableMove_PropertyAddress, intPtr, "EnableMove");
		EnableMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableMove");
		EnableMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableMove", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref KeepMMRunning_PropertyAddress, intPtr, "KeepMMRunning");
		KeepMMRunning_Offset = NativeReflection.GetPropertyOffset(intPtr, "KeepMMRunning");
		KeepMMRunning_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "KeepMMRunning", Classes.FBoolProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSAttackState:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSAttackState:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
		GSAllowCrossSection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSAllowCrossSection");
		GSAllowCrossSection_ParamsSize = NativeReflection.GetFunctionParamsSize(GSAllowCrossSection_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSAllowCrossSection_ReturnValue_PropertyAddress, GSAllowCrossSection_FunctionAddress, "ReturnValue");
		GSAllowCrossSection_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GSAllowCrossSection_FunctionAddress, "ReturnValue");
		GSAllowCrossSection_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GSAllowCrossSection_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GSAllowCrossSection_IsValid = GSAllowCrossSection_FunctionAddress != IntPtr.Zero && GSAllowCrossSection_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSAttackState:GSAllowCrossSection", GSAllowCrossSection_IsValid);
		GSOnSectionManuallyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSOnSectionManuallyChanged");
		GSOnSectionManuallyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnSectionManuallyChanged_FunctionAddress);
		GSOnSectionManuallyChanged_OwnerChar_Offset = NativeReflection.GetPropertyOffset(GSOnSectionManuallyChanged_FunctionAddress, "OwnerChar");
		GSOnSectionManuallyChanged_OwnerChar_IsValid = NativeReflection.ValidatePropertyClass(GSOnSectionManuallyChanged_FunctionAddress, "OwnerChar", Classes.FObjectProperty);
		GSOnSectionManuallyChanged_RemainingDuration_Offset = NativeReflection.GetPropertyOffset(GSOnSectionManuallyChanged_FunctionAddress, "RemainingDuration");
		GSOnSectionManuallyChanged_RemainingDuration_IsValid = NativeReflection.ValidatePropertyClass(GSOnSectionManuallyChanged_FunctionAddress, "RemainingDuration", Classes.FFloatProperty);
		GSOnSectionManuallyChanged_IsValid = GSOnSectionManuallyChanged_FunctionAddress != IntPtr.Zero && GSOnSectionManuallyChanged_OwnerChar_IsValid && GSOnSectionManuallyChanged_RemainingDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSAttackState:GSOnSectionManuallyChanged", GSOnSectionManuallyChanged_IsValid);
	}
}
