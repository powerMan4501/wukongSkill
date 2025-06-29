using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Plugins.SimpleCharts;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/SimpleCharts.Data", "SimpleCharts", UnrealModuleType.GamePlugin)]
public struct FData
{
	private static bool name_IsValid;

	private static int name_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/SimpleCharts.Data:name")]
	public string name;

	private static bool value_IsValid;

	private static FFieldAddress value_PropertyAddress;

	private static int value_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/SimpleCharts.Data:value")]
	public List<float> value;

	private static bool FData_IsValid;

	private static int FData_StructSize;

	public FData Copy()
	{
		FData result = this;
		if (value != null)
		{
			result.value = new List<float>(value);
		}
		return result;
	}

	public static FData FromNative(IntPtr nativeBuffer)
	{
		return new FData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FData(nativeBuffer + arrayIndex * FData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.Data");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, name_Offset), name);
		new TArrayCopyMarshaler<float>(1, value_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(nativeStruct, value_Offset), value);
	}

	public FData(IntPtr nativeStruct)
	{
		if (!FData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.Data");
			name = FStringMarshaler.DefaultString;
			value = null;
		}
		else
		{
			name = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, name_Offset));
			value = new TArrayCopyMarshaler<float>(1, value_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(nativeStruct, value_Offset));
		}
	}

	static FData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SimpleCharts.Data");
		FData_StructSize = NativeReflection.GetStructSize(intPtr);
		name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "name");
		name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref value_PropertyAddress, intPtr, "value");
		value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "value");
		value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "value", Classes.FArrayProperty);
		FData_IsValid = intPtr != IntPtr.Zero && name_IsValid && value_IsValid;
		NativeReflection.LogStructIsValid("/Script/SimpleCharts.Data", FData_IsValid);
	}
}
