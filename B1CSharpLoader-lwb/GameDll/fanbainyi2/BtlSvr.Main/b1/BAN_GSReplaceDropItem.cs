using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BAN Replace Drop Item")]
[UClass]
[USharpPath("/Script/b1-Managed.BAN_GSReplaceDropItem")]
internal class BAN_GSReplaceDropItem : BAN_GSBase
{
	private static bool WeaponIndexList_IsValid;

	private static int WeaponIndexList_Offset;

	private static FFieldAddress WeaponIndexList_PropertyAddress;

	private TMapReadWriteMarshaler<int, int> WeaponIndexList_Marshaler;

	private static bool ReplacementLocationRule_IsValid;

	private static int ReplacementLocationRule_Offset;

	private static FFieldAddress ReplacementLocationRule_PropertyAddress;

	private static bool ReplacementRotationRule_IsValid;

	private static int ReplacementRotationRule_Offset;

	private static FFieldAddress ReplacementRotationRule_PropertyAddress;

	private static bool ReplacementScaleRule_IsValid;

	private static int ReplacementScaleRule_Offset;

	private static FFieldAddress ReplacementScaleRule_PropertyAddress;

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

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_GSReplaceDropItem:WeaponIndexList")]
	public TMapReadWrite<int, int> WeaponIndexList
	{
		get
		{
			CheckDestroyed();
			if (!WeaponIndexList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSReplaceDropItem:WeaponIndexList");
				return null;
			}
			if (WeaponIndexList_Marshaler == null)
			{
				WeaponIndexList_Marshaler = new TMapReadWriteMarshaler<int, int>(1, WeaponIndexList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return WeaponIndexList_Marshaler.FromNative(IntPtr.Add(base.Address, WeaponIndexList_Offset));
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSReplaceDropItem:ReplacementLocationRule")]
	public EDetachmentRule ReplacementLocationRule
	{
		get
		{
			CheckDestroyed();
			if (!ReplacementLocationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSReplaceDropItem:ReplacementLocationRule");
				return EDetachmentRule.KeepRelative;
			}
			return EnumMarshaler<EDetachmentRule>.FromNative(IntPtr.Add(base.Address, ReplacementLocationRule_Offset), 0, ReplacementLocationRule_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ReplacementLocationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSReplaceDropItem:ReplacementLocationRule");
			}
			else
			{
				EnumMarshaler<EDetachmentRule>.ToNative(IntPtr.Add(base.Address, ReplacementLocationRule_Offset), 0, ReplacementLocationRule_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_GSReplaceDropItem:ReplacementRotationRule")]
	public EDetachmentRule ReplacementRotationRule
	{
		get
		{
			CheckDestroyed();
			if (!ReplacementRotationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSReplaceDropItem:ReplacementRotationRule");
				return EDetachmentRule.KeepRelative;
			}
			return EnumMarshaler<EDetachmentRule>.FromNative(IntPtr.Add(base.Address, ReplacementRotationRule_Offset), 0, ReplacementRotationRule_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ReplacementRotationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSReplaceDropItem:ReplacementRotationRule");
			}
			else
			{
				EnumMarshaler<EDetachmentRule>.ToNative(IntPtr.Add(base.Address, ReplacementRotationRule_Offset), 0, ReplacementRotationRule_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_GSReplaceDropItem:ReplacementScaleRule")]
	public EDetachmentRule ReplacementScaleRule
	{
		get
		{
			CheckDestroyed();
			if (!ReplacementScaleRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSReplaceDropItem:ReplacementScaleRule");
				return EDetachmentRule.KeepRelative;
			}
			return EnumMarshaler<EDetachmentRule>.FromNative(IntPtr.Add(base.Address, ReplacementScaleRule_Offset), 0, ReplacementScaleRule_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ReplacementScaleRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSReplaceDropItem:ReplacementScaleRule");
			}
			else
			{
				EnumMarshaler<EDetachmentRule>.ToNative(IntPtr.Add(base.Address, ReplacementScaleRule_Offset), 0, ReplacementScaleRule_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		ReplacementLocationRule = EDetachmentRule.KeepWorld;
		ReplacementRotationRule = EDetachmentRule.KeepWorld;
		ReplacementScaleRule = EDetachmentRule.KeepWorld;
	}

	[USharpPath("/Script/b1-Managed.BAN_GSReplaceDropItem:bIsNativeBranchingPointCS")]
	protected override bool bIsNativeBranchingPointCS_Implementation()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.BAN_GSReplaceDropItem:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor aActor = NotifyParam.MeshComp?.GetOwner();
		BGUCharacterCS bGUCharacterCS = aActor as BGUCharacterCS;
		if (!(aActor != null) || !(aActor.World != null))
		{
			return;
		}
		foreach (KeyValuePair<int, int> weaponIndex in WeaponIndexList)
		{
			AActor aActor2 = BGUFunctionLibraryCS.BGUGetWeaponByIndex(bGUCharacterCS, weaponIndex.Key);
			if (aActor2 != null)
			{
				BGUWeaponBase bGUWeaponBase = aActor2 as BGUWeaponBase;
				if (bGUWeaponBase != null)
				{
					BPS_GSEventCollection.Get((aActor as APawn).PlayerState).Evt_RequestDropSpecialItem.Invoke(bGUCharacterCS, weaponIndex.Value, BGUFuncLibActorTransformCS.BGUGetActorTransform(bGUWeaponBase));
					BUS_EventCollectionCS.Get(bGUCharacterCS)?.Evt_DetachWeapon.Invoke(weaponIndex.Key, ReplacementLocationRule, ReplacementRotationRule, ReplacementScaleRule, 0f);
				}
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSReplaceDropItem:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSReplaceDropItem bAN_GSReplaceDropItem = GCHelper.Find<b1.BAN_GSReplaceDropItem>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSReplaceDropItem.GSNotifyCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSReplaceDropItem:bIsNativeBranchingPointCS")]
	private static void bIsNativeBranchingPointCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSReplaceDropItem bAN_GSReplaceDropItem = GCHelper.Find<b1.BAN_GSReplaceDropItem>(obj);
		bool value = bAN_GSReplaceDropItem.bIsNativeBranchingPointCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, bIsNativeBranchingPointCS_ReturnValue_Offset), 0, bIsNativeBranchingPointCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSReplaceDropItem");
		NativeReflection.GetPropertyRef(ref WeaponIndexList_PropertyAddress, intPtr, "WeaponIndexList");
		WeaponIndexList_Offset = NativeReflection.GetPropertyOffset(intPtr, "WeaponIndexList");
		WeaponIndexList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WeaponIndexList", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref ReplacementLocationRule_PropertyAddress, intPtr, "ReplacementLocationRule");
		ReplacementLocationRule_Offset = NativeReflection.GetPropertyOffset(intPtr, "ReplacementLocationRule");
		ReplacementLocationRule_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ReplacementLocationRule", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref ReplacementRotationRule_PropertyAddress, intPtr, "ReplacementRotationRule");
		ReplacementRotationRule_Offset = NativeReflection.GetPropertyOffset(intPtr, "ReplacementRotationRule");
		ReplacementRotationRule_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ReplacementRotationRule", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref ReplacementScaleRule_PropertyAddress, intPtr, "ReplacementScaleRule");
		ReplacementScaleRule_Offset = NativeReflection.GetPropertyOffset(intPtr, "ReplacementScaleRule");
		ReplacementScaleRule_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ReplacementScaleRule", Classes.FEnumProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSReplaceDropItem:GSNotifyCS", GSNotifyCS_IsValid);
		bIsNativeBranchingPointCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "bIsNativeBranchingPointCS");
		bIsNativeBranchingPointCS_ParamsSize = NativeReflection.GetFunctionParamsSize(bIsNativeBranchingPointCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref bIsNativeBranchingPointCS_ReturnValue_PropertyAddress, bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		bIsNativeBranchingPointCS_IsValid = bIsNativeBranchingPointCS_FunctionAddress != IntPtr.Zero && bIsNativeBranchingPointCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSReplaceDropItem:bIsNativeBranchingPointCS", bIsNativeBranchingPointCS_IsValid);
	}

	static BAN_GSReplaceDropItem()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSReplaceDropItem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSReplaceDropItem));
	}
}
