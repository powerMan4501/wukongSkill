using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Toggle Weapon Status【武器的状态控制，总是被最后触发条的逻辑覆盖】")]
[USharpPath("/Script/b1-Managed.BANS_ToggleWeaponStatus")]
internal class BANS_ToggleWeaponStatus : BANS_GSBase
{
	private static bool WeaponIndexList_IsValid;

	private static int WeaponIndexList_Offset;

	private static FFieldAddress WeaponIndexList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> WeaponIndexList_Marshaler;

	private static bool TriggerShowFirst_IsValid;

	private static int TriggerShowFirst_Offset;

	private static FFieldAddress TriggerShowFirst_PropertyAddress;

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

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("武器Index列表")]
	[USharpPath("/Script/b1-Managed.BANS_ToggleWeaponStatus:WeaponIndexList")]
	public TArrayReadWrite<int> WeaponIndexList
	{
		get
		{
			CheckDestroyed();
			if (!WeaponIndexList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_ToggleWeaponStatus:WeaponIndexList");
				return null;
			}
			if (WeaponIndexList_Marshaler == null)
			{
				WeaponIndexList_Marshaler = new TArrayReadWriteMarshaler<int>(1, WeaponIndexList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return WeaponIndexList_Marshaler.FromNative(IntPtr.Add(base.Address, WeaponIndexList_Offset));
		}
	}

	[UProperty]
	[Tooltip("勾选上，先触发显示，结束触发隐藏；没勾则相反")]
	[DisplayName("先触发显示")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_ToggleWeaponStatus:TriggerShowFirst")]
	public bool TriggerShowFirst
	{
		get
		{
			CheckDestroyed();
			if (!TriggerShowFirst_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_ToggleWeaponStatus:TriggerShowFirst");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, TriggerShowFirst_Offset), 0, TriggerShowFirst_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TriggerShowFirst_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_ToggleWeaponStatus:TriggerShowFirst");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, TriggerShowFirst_Offset), 0, TriggerShowFirst_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
	}

	[USharpPath("/Script/b1-Managed.BANS_ToggleWeaponStatus:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		if (!UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(NotifyParam.owner))
		{
			BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
			if (bGUCharacterCS != null)
			{
				int fromInstanceID = NotifyParam.FromInstanceID;
				int uniqueID = (int)GetUniqueID();
				BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_ToggleWeaponsStatus_ByNotifyState.Invoke(WeaponIndexList.ToList(), TriggerShowFirst, NeedOverride: true, fromInstanceID, uniqueID);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_ToggleWeaponStatus:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		if (!UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(NotifyParam.owner))
		{
			BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
			if (bGUCharacterCS != null)
			{
				int fromInstanceID = NotifyParam.FromInstanceID;
				int uniqueID = (int)GetUniqueID();
				BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_ToggleWeaponsStatus_ByNotifyState.Invoke(WeaponIndexList.ToList(), !TriggerShowFirst, NeedOverride: false, fromInstanceID, uniqueID);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_ToggleWeaponStatus:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_ToggleWeaponStatus bANS_ToggleWeaponStatus = GCHelper.Find<b1.BANS_ToggleWeaponStatus>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_ToggleWeaponStatus.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_ToggleWeaponStatus:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_ToggleWeaponStatus bANS_ToggleWeaponStatus = GCHelper.Find<b1.BANS_ToggleWeaponStatus>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_ToggleWeaponStatus.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_ToggleWeaponStatus");
		NativeReflection.GetPropertyRef(ref WeaponIndexList_PropertyAddress, intPtr, "WeaponIndexList");
		WeaponIndexList_Offset = NativeReflection.GetPropertyOffset(intPtr, "WeaponIndexList");
		WeaponIndexList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WeaponIndexList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref TriggerShowFirst_PropertyAddress, intPtr, "TriggerShowFirst");
		TriggerShowFirst_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerShowFirst");
		TriggerShowFirst_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerShowFirst", Classes.FBoolProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_ToggleWeaponStatus:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_ToggleWeaponStatus:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_ToggleWeaponStatus()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_ToggleWeaponStatus)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_ToggleWeaponStatus));
	}
}
