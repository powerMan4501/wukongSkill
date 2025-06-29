using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BAN Detach Multiple Weapons")]
[USharpPath("/Script/b1-Managed.BAN_GSDetachMultipleWeapons")]
internal class BAN_GSDetachMultipleWeapons : BAN_GSBase
{
	private static bool WeaponIndexList_IsValid;

	private static int WeaponIndexList_Offset;

	private static FFieldAddress WeaponIndexList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> WeaponIndexList_Marshaler;

	private static bool DetachmentLocationRule_IsValid;

	private static int DetachmentLocationRule_Offset;

	private static FFieldAddress DetachmentLocationRule_PropertyAddress;

	private static bool DetachmentRotationRule_IsValid;

	private static int DetachmentRotationRule_Offset;

	private static FFieldAddress DetachmentRotationRule_PropertyAddress;

	private static bool DetachmentScaleRule_IsValid;

	private static int DetachmentScaleRule_Offset;

	private static FFieldAddress DetachmentScaleRule_PropertyAddress;

	private static bool IsEnableInteract_IsValid;

	private static int IsEnableInteract_Offset;

	private static FFieldAddress IsEnableInteract_PropertyAddress;

	private static bool DestroyDelayTime_IsValid;

	private static int DestroyDelayTime_Offset;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	private static bool bIsNativeBranchingPointCS_IsValid;

	private static IntPtr bIsNativeBranchingPointCS_FunctionAddress;

	private static int bIsNativeBranchingPointCS_ParamsSize;

	private static bool bIsNativeBranchingPointCS_ReturnValue_IsValid;

	private static int bIsNativeBranchingPointCS_ReturnValue_Offset;

	private static FFieldAddress bIsNativeBranchingPointCS_ReturnValue_PropertyAddress;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSDetachMultipleWeapons:WeaponIndexList")]
	public TArrayReadWrite<int> WeaponIndexList
	{
		get
		{
			CheckDestroyed();
			if (!WeaponIndexList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSDetachMultipleWeapons:WeaponIndexList");
				return null;
			}
			if (WeaponIndexList_Marshaler == null)
			{
				WeaponIndexList_Marshaler = new TArrayReadWriteMarshaler<int>(1, WeaponIndexList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return WeaponIndexList_Marshaler.FromNative(IntPtr.Add(base.Address, WeaponIndexList_Offset));
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSDetachMultipleWeapons:DetachmentLocationRule")]
	public EDetachmentRule DetachmentLocationRule
	{
		get
		{
			CheckDestroyed();
			if (!DetachmentLocationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSDetachMultipleWeapons:DetachmentLocationRule");
				return EDetachmentRule.KeepRelative;
			}
			return EnumMarshaler<EDetachmentRule>.FromNative(IntPtr.Add(base.Address, DetachmentLocationRule_Offset), 0, DetachmentLocationRule_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DetachmentLocationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSDetachMultipleWeapons:DetachmentLocationRule");
			}
			else
			{
				EnumMarshaler<EDetachmentRule>.ToNative(IntPtr.Add(base.Address, DetachmentLocationRule_Offset), 0, DetachmentLocationRule_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSDetachMultipleWeapons:DetachmentRotationRule")]
	public EDetachmentRule DetachmentRotationRule
	{
		get
		{
			CheckDestroyed();
			if (!DetachmentRotationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSDetachMultipleWeapons:DetachmentRotationRule");
				return EDetachmentRule.KeepRelative;
			}
			return EnumMarshaler<EDetachmentRule>.FromNative(IntPtr.Add(base.Address, DetachmentRotationRule_Offset), 0, DetachmentRotationRule_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DetachmentRotationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSDetachMultipleWeapons:DetachmentRotationRule");
			}
			else
			{
				EnumMarshaler<EDetachmentRule>.ToNative(IntPtr.Add(base.Address, DetachmentRotationRule_Offset), 0, DetachmentRotationRule_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSDetachMultipleWeapons:DetachmentScaleRule")]
	public EDetachmentRule DetachmentScaleRule
	{
		get
		{
			CheckDestroyed();
			if (!DetachmentScaleRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSDetachMultipleWeapons:DetachmentScaleRule");
				return EDetachmentRule.KeepRelative;
			}
			return EnumMarshaler<EDetachmentRule>.FromNative(IntPtr.Add(base.Address, DetachmentScaleRule_Offset), 0, DetachmentScaleRule_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DetachmentScaleRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSDetachMultipleWeapons:DetachmentScaleRule");
			}
			else
			{
				EnumMarshaler<EDetachmentRule>.ToNative(IntPtr.Add(base.Address, DetachmentScaleRule_Offset), 0, DetachmentScaleRule_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSDetachMultipleWeapons:IsEnableInteract")]
	public bool IsEnableInteract
	{
		get
		{
			CheckDestroyed();
			if (!IsEnableInteract_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSDetachMultipleWeapons:IsEnableInteract");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsEnableInteract_Offset), 0, IsEnableInteract_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsEnableInteract_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSDetachMultipleWeapons:IsEnableInteract");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsEnableInteract_Offset), 0, IsEnableInteract_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSDetachMultipleWeapons:DestroyDelayTime")]
	public float DestroyDelayTime
	{
		get
		{
			CheckDestroyed();
			if (!DestroyDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSDetachMultipleWeapons:DestroyDelayTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DestroyDelayTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DestroyDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSDetachMultipleWeapons:DestroyDelayTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DestroyDelayTime_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSDetachMultipleWeapons:bIsNativeBranchingPointCS")]
	protected override bool bIsNativeBranchingPointCS_Implementation()
	{
		return true;
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		IsEnableInteract = false;
		DestroyDelayTime = 0f;
		DetachmentLocationRule = EDetachmentRule.KeepWorld;
		DetachmentRotationRule = EDetachmentRule.KeepWorld;
		DetachmentScaleRule = EDetachmentRule.KeepWorld;
	}

	[USharpPath("/Script/b1-Managed.BAN_GSDetachMultipleWeapons:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor aActor = NotifyParam.MeshComp?.GetOwner();
		ABGUCharacter aBGUCharacter = aActor as ABGUCharacter;
		if (!(aActor != null) || !(aActor.World != null))
		{
			return;
		}
		foreach (int weaponIndex in WeaponIndexList)
		{
			AActor aActor2 = BGUFunctionLibraryCS.BGUGetWeaponByIndex(aBGUCharacter, weaponIndex);
			if (!(aActor2 != null))
			{
				continue;
			}
			BGUWeaponBase bGUWeaponBase = aActor2 as BGUWeaponBase;
			if (bGUWeaponBase != null)
			{
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUWeaponBase);
				if (bUS_GSEventCollection == null)
				{
					break;
				}
				if (IsEnableInteract)
				{
					bUS_GSEventCollection.Evt_SwitchNoInteraction.Invoke(P1: true);
				}
				bUS_GSEventCollection.Evt_ToggleWeaponRenderStatic.Invoke(P1: false);
				BUS_EventCollectionCS.Get(aBGUCharacter).Evt_DetachWeapon.Invoke(weaponIndex, DetachmentLocationRule, DetachmentRotationRule, DetachmentScaleRule, DestroyDelayTime);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSDetachMultipleWeapons:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSDetachMultipleWeapons bAN_GSDetachMultipleWeapons = GCHelper.Find<b1.BAN_GSDetachMultipleWeapons>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSDetachMultipleWeapons.GSNotifyCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSDetachMultipleWeapons:bIsNativeBranchingPointCS")]
	private static void bIsNativeBranchingPointCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSDetachMultipleWeapons bAN_GSDetachMultipleWeapons = GCHelper.Find<b1.BAN_GSDetachMultipleWeapons>(obj);
		bool value = bAN_GSDetachMultipleWeapons.bIsNativeBranchingPointCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, bIsNativeBranchingPointCS_ReturnValue_Offset), 0, bIsNativeBranchingPointCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSDetachMultipleWeapons");
		NativeReflection.GetPropertyRef(ref WeaponIndexList_PropertyAddress, intPtr, "WeaponIndexList");
		WeaponIndexList_Offset = NativeReflection.GetPropertyOffset(intPtr, "WeaponIndexList");
		WeaponIndexList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WeaponIndexList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref DetachmentLocationRule_PropertyAddress, intPtr, "DetachmentLocationRule");
		DetachmentLocationRule_Offset = NativeReflection.GetPropertyOffset(intPtr, "DetachmentLocationRule");
		DetachmentLocationRule_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DetachmentLocationRule", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref DetachmentRotationRule_PropertyAddress, intPtr, "DetachmentRotationRule");
		DetachmentRotationRule_Offset = NativeReflection.GetPropertyOffset(intPtr, "DetachmentRotationRule");
		DetachmentRotationRule_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DetachmentRotationRule", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref DetachmentScaleRule_PropertyAddress, intPtr, "DetachmentScaleRule");
		DetachmentScaleRule_Offset = NativeReflection.GetPropertyOffset(intPtr, "DetachmentScaleRule");
		DetachmentScaleRule_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DetachmentScaleRule", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref IsEnableInteract_PropertyAddress, intPtr, "IsEnableInteract");
		IsEnableInteract_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsEnableInteract");
		IsEnableInteract_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsEnableInteract", Classes.FBoolProperty);
		DestroyDelayTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "DestroyDelayTime");
		DestroyDelayTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DestroyDelayTime", Classes.FFloatProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSDetachMultipleWeapons:GSNotifyCS", GSNotifyCS_IsValid);
		bIsNativeBranchingPointCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "bIsNativeBranchingPointCS");
		bIsNativeBranchingPointCS_ParamsSize = NativeReflection.GetFunctionParamsSize(bIsNativeBranchingPointCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref bIsNativeBranchingPointCS_ReturnValue_PropertyAddress, bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		bIsNativeBranchingPointCS_IsValid = bIsNativeBranchingPointCS_FunctionAddress != IntPtr.Zero && bIsNativeBranchingPointCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSDetachMultipleWeapons:bIsNativeBranchingPointCS", bIsNativeBranchingPointCS_IsValid);
	}

	static BAN_GSDetachMultipleWeapons()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSDetachMultipleWeapons)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSDetachMultipleWeapons));
	}
}
