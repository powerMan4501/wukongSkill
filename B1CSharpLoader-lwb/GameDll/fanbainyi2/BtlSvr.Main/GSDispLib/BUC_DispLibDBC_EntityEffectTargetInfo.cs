using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_EntityEffectTargetInfo")]
public struct BUC_DispLibDBC_EntityEffectTargetInfo
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("影响Comps")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_EntityEffectTargetInfo:CompsFilterMode")]
	public DispLibDBCCompsFilterMode CompsFilterMode;

	[UMeta(MD.ToolTip, "")]
	[UMeta(MDProp.EditCondition, "CompsFilterMode != DispLibDBCCompsFilterMode::AllComps")]
	[DisplayName("CompTags")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_EntityEffectTargetInfo:CompTags")]
	public List<FName> CompTags;

	private static int BUC_DispLibDBC_EntityEffectTargetInfo_StructSize;

	private static int BUC_DispLibDBC_EntityEffectTargetInfo_IsValid;

	private static bool CompsFilterMode_IsValid;

	private static int CompsFilterMode_Offset;

	private static FFieldAddress CompsFilterMode_PropertyAddress;

	private static bool CompTags_IsValid;

	private static int CompTags_Offset;

	private static FFieldAddress CompTags_PropertyAddress;

	public bool isVaild()
	{
		DispLibDBCCompsFilterMode compsFilterMode = CompsFilterMode;
		if (compsFilterMode - 1 <= DispLibDBCCompsFilterMode.ByTags)
		{
			if (CompTags.Count == 0)
			{
				return false;
			}
			for (int i = 0; i < CompTags.Count; i++)
			{
				if (CompTags[i] != FName.None)
				{
					return true;
				}
			}
		}
		return true;
	}

	public BUC_DispLibDBC_EntityEffectTargetInfo Copy()
	{
		BUC_DispLibDBC_EntityEffectTargetInfo result = this;
		if (CompTags != null)
		{
			result.CompTags = new List<FName>(CompTags);
		}
		return result;
	}

	public static BUC_DispLibDBC_EntityEffectTargetInfo FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibDBC_EntityEffectTargetInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibDBC_EntityEffectTargetInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibDBC_EntityEffectTargetInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibDBC_EntityEffectTargetInfo(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_EntityEffectTargetInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibDBC_EntityEffectTargetInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_EntityEffectTargetInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_EntityEffectTargetInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_EntityEffectTargetInfo");
			return;
		}
		EnumMarshaler<DispLibDBCCompsFilterMode>.ToNative(IntPtr.Add(nativeStruct, CompsFilterMode_Offset), 0, CompsFilterMode_PropertyAddress.Address, CompsFilterMode);
		new TArrayCopyMarshaler<FName>(1, CompTags_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, CompTags_Offset), CompTags);
	}

	public BUC_DispLibDBC_EntityEffectTargetInfo(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_EntityEffectTargetInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_EntityEffectTargetInfo");
			CompsFilterMode = DispLibDBCCompsFilterMode.AllComps;
			CompTags = null;
		}
		else
		{
			CompsFilterMode = EnumMarshaler<DispLibDBCCompsFilterMode>.FromNative(IntPtr.Add(nativeStruct, CompsFilterMode_Offset), 0, CompsFilterMode_PropertyAddress.Address);
			CompTags = new TArrayCopyMarshaler<FName>(1, CompTags_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, CompTags_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibDBC_EntityEffectTargetInfo");
		BUC_DispLibDBC_EntityEffectTargetInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref CompsFilterMode_PropertyAddress, intPtr, "CompsFilterMode");
		CompsFilterMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompsFilterMode");
		CompsFilterMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompsFilterMode", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref CompTags_PropertyAddress, intPtr, "CompTags");
		CompTags_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompTags");
		CompTags_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompTags", Classes.FArrayProperty);
		BUC_DispLibDBC_EntityEffectTargetInfo_IsValid = ((intPtr != IntPtr.Zero && CompsFilterMode_IsValid && CompTags_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibDBC_EntityEffectTargetInfo", (byte)BUC_DispLibDBC_EntityEffectTargetInfo_IsValid != 0);
	}

	static BUC_DispLibDBC_EntityEffectTargetInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibDBC_EntityEffectTargetInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibDBC_EntityEffectTargetInfo));
	}
}
