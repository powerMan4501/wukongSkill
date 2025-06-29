using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.SimpleCharts;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/SimpleCharts.funnelData", "SimpleCharts", UnrealModuleType.GamePlugin)]
public struct FfunnelData
{
	private static bool name_IsValid;

	private static int name_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/SimpleCharts.funnelData:name")]
	public string name;

	private static bool value_IsValid;

	private static int value_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.funnelData:value")]
	public float value;

	private static bool FfunnelData_IsValid;

	private static int FfunnelData_StructSize;

	public FfunnelData Copy()
	{
		return this;
	}

	public static FfunnelData FromNative(IntPtr nativeBuffer)
	{
		return new FfunnelData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FfunnelData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FfunnelData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FfunnelData(nativeBuffer + arrayIndex * FfunnelData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FfunnelData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FfunnelData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FfunnelData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.funnelData");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, name_Offset), name);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, value_Offset), value);
	}

	public FfunnelData(IntPtr nativeStruct)
	{
		if (!FfunnelData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.funnelData");
			name = FStringMarshaler.DefaultString;
			value = 0f;
		}
		else
		{
			name = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, name_Offset));
			value = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, value_Offset));
		}
	}

	static FfunnelData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FfunnelData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FfunnelData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SimpleCharts.funnelData");
		FfunnelData_StructSize = NativeReflection.GetStructSize(intPtr);
		name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "name");
		name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "name", Classes.FStrProperty);
		value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "value");
		value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "value", Classes.FFloatProperty);
		FfunnelData_IsValid = intPtr != IntPtr.Zero && name_IsValid && value_IsValid;
		NativeReflection.LogStructIsValid("/Script/SimpleCharts.funnelData", FfunnelData_IsValid);
	}
}
