using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.TortoiseLevelGroupConfig")]
public struct FTortoiseLevelGroupConfig
{
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TortoiseLevelGroupConfig:ManagedLevels")]
	public List<string> ManagedLevels;

	private static int TortoiseLevelGroupConfig_StructSize;

	private static int TortoiseLevelGroupConfig_IsValid;

	private static bool ManagedLevels_IsValid;

	private static int ManagedLevels_Offset;

	private static FFieldAddress ManagedLevels_PropertyAddress;

	public FTortoiseLevelGroupConfig Copy()
	{
		FTortoiseLevelGroupConfig result = this;
		if (ManagedLevels != null)
		{
			result.ManagedLevels = new List<string>(ManagedLevels);
		}
		return result;
	}

	public static FTortoiseLevelGroupConfig FromNative(IntPtr nativeBuffer)
	{
		return new FTortoiseLevelGroupConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTortoiseLevelGroupConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTortoiseLevelGroupConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTortoiseLevelGroupConfig(IntPtr.Add(nativeBuffer, arrayIndex * TortoiseLevelGroupConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTortoiseLevelGroupConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * TortoiseLevelGroupConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (TortoiseLevelGroupConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TortoiseLevelGroupConfig");
		}
		else
		{
			new TArrayCopyMarshaler<string>(1, ManagedLevels_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(nativeStruct, ManagedLevels_Offset), ManagedLevels);
		}
	}

	public FTortoiseLevelGroupConfig(IntPtr nativeStruct)
	{
		if (TortoiseLevelGroupConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TortoiseLevelGroupConfig");
			ManagedLevels = null;
		}
		else
		{
			ManagedLevels = new TArrayCopyMarshaler<string>(1, ManagedLevels_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(nativeStruct, ManagedLevels_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.TortoiseLevelGroupConfig");
		TortoiseLevelGroupConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref ManagedLevels_PropertyAddress, intPtr, "ManagedLevels");
		ManagedLevels_Offset = NativeReflection.GetPropertyOffset(intPtr, "ManagedLevels");
		ManagedLevels_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ManagedLevels", Classes.FArrayProperty);
		TortoiseLevelGroupConfig_IsValid = ((intPtr != IntPtr.Zero && ManagedLevels_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.TortoiseLevelGroupConfig", (byte)TortoiseLevelGroupConfig_IsValid != 0);
	}

	static FTortoiseLevelGroupConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FTortoiseLevelGroupConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTortoiseLevelGroupConfig));
	}
}
