using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.LevelNameConfig")]
public struct LevelNameConfig
{
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.LevelNameConfig:NameList")]
	public List<int> NameList;

	private static int LevelNameConfig_StructSize;

	private static int LevelNameConfig_IsValid;

	private static bool NameList_IsValid;

	private static int NameList_Offset;

	private static FFieldAddress NameList_PropertyAddress;

	public LevelNameConfig Copy()
	{
		LevelNameConfig result = this;
		if (NameList != null)
		{
			result.NameList = new List<int>(NameList);
		}
		return result;
	}

	public static LevelNameConfig FromNative(IntPtr nativeBuffer)
	{
		return new LevelNameConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, LevelNameConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static LevelNameConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new LevelNameConfig(IntPtr.Add(nativeBuffer, arrayIndex * LevelNameConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, LevelNameConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * LevelNameConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (LevelNameConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.LevelNameConfig");
		}
		else
		{
			new TArrayCopyMarshaler<int>(1, NameList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, NameList_Offset), NameList);
		}
	}

	public LevelNameConfig(IntPtr nativeStruct)
	{
		if (LevelNameConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.LevelNameConfig");
			NameList = null;
		}
		else
		{
			NameList = new TArrayCopyMarshaler<int>(1, NameList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, NameList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.LevelNameConfig");
		LevelNameConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref NameList_PropertyAddress, intPtr, "NameList");
		NameList_Offset = NativeReflection.GetPropertyOffset(intPtr, "NameList");
		NameList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NameList", Classes.FArrayProperty);
		LevelNameConfig_IsValid = ((intPtr != IntPtr.Zero && NameList_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.LevelNameConfig", (byte)LevelNameConfig_IsValid != 0);
	}

	static LevelNameConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(LevelNameConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(LevelNameConfig));
	}
}
