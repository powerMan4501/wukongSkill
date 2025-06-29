using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.ChargeLevelConfig")]
public struct FChargeLevelConfig
{
	[DisplayName("配置")]
	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ChargeLevelConfig:InfoList")]
	public List<FChargeLevelUnitInfo> InfoList;

	private static int ChargeLevelConfig_StructSize;

	private static int ChargeLevelConfig_IsValid;

	private static bool InfoList_IsValid;

	private static int InfoList_Offset;

	private static FFieldAddress InfoList_PropertyAddress;

	public void Clear()
	{
		InfoList?.Clear();
	}

	public FChargeLevelConfig Copy()
	{
		FChargeLevelConfig result = this;
		if (InfoList != null)
		{
			result.InfoList = new List<FChargeLevelUnitInfo>(InfoList);
		}
		return result;
	}

	public static FChargeLevelConfig FromNative(IntPtr nativeBuffer)
	{
		return new FChargeLevelConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FChargeLevelConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FChargeLevelConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FChargeLevelConfig(IntPtr.Add(nativeBuffer, arrayIndex * ChargeLevelConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FChargeLevelConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * ChargeLevelConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (ChargeLevelConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ChargeLevelConfig");
		}
		else
		{
			new TArrayCopyMarshaler<FChargeLevelUnitInfo>(1, InfoList_PropertyAddress, CachedMarshalingDelegates<FChargeLevelUnitInfo, FChargeLevelUnitInfo>.FromNative, CachedMarshalingDelegates<FChargeLevelUnitInfo, FChargeLevelUnitInfo>.ToNative).ToNative(IntPtr.Add(nativeStruct, InfoList_Offset), InfoList);
		}
	}

	public FChargeLevelConfig(IntPtr nativeStruct)
	{
		if (ChargeLevelConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ChargeLevelConfig");
			InfoList = null;
		}
		else
		{
			InfoList = new TArrayCopyMarshaler<FChargeLevelUnitInfo>(1, InfoList_PropertyAddress, CachedMarshalingDelegates<FChargeLevelUnitInfo, FChargeLevelUnitInfo>.FromNative, CachedMarshalingDelegates<FChargeLevelUnitInfo, FChargeLevelUnitInfo>.ToNative).FromNative(IntPtr.Add(nativeStruct, InfoList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.ChargeLevelConfig");
		ChargeLevelConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref InfoList_PropertyAddress, intPtr, "InfoList");
		InfoList_Offset = NativeReflection.GetPropertyOffset(intPtr, "InfoList");
		InfoList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InfoList", Classes.FArrayProperty);
		ChargeLevelConfig_IsValid = ((intPtr != IntPtr.Zero && InfoList_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.ChargeLevelConfig", (byte)ChargeLevelConfig_IsValid != 0);
	}

	static FChargeLevelConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FChargeLevelConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FChargeLevelConfig));
	}
}
