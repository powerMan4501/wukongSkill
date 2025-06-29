using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.SimpleCharts;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/SimpleCharts.GaugeData", "SimpleCharts", UnrealModuleType.GamePlugin)]
public struct FGaugeData
{
	private static bool name_IsValid;

	private static int name_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/SimpleCharts.GaugeData:name")]
	public string name;

	private static bool value_IsValid;

	private static int value_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.GaugeData:value")]
	public float value;

	private static bool FGaugeData_IsValid;

	private static int FGaugeData_StructSize;

	public FGaugeData Copy()
	{
		return this;
	}

	public static FGaugeData FromNative(IntPtr nativeBuffer)
	{
		return new FGaugeData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGaugeData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGaugeData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGaugeData(nativeBuffer + arrayIndex * FGaugeData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGaugeData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGaugeData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGaugeData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.GaugeData");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, name_Offset), name);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, value_Offset), value);
	}

	public FGaugeData(IntPtr nativeStruct)
	{
		if (!FGaugeData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.GaugeData");
			name = FStringMarshaler.DefaultString;
			value = 0f;
		}
		else
		{
			name = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, name_Offset));
			value = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, value_Offset));
		}
	}

	static FGaugeData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGaugeData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGaugeData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SimpleCharts.GaugeData");
		FGaugeData_StructSize = NativeReflection.GetStructSize(intPtr);
		name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "name");
		name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "name", Classes.FStrProperty);
		value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "value");
		value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "value", Classes.FFloatProperty);
		FGaugeData_IsValid = intPtr != IntPtr.Zero && name_IsValid && value_IsValid;
		NativeReflection.LogStructIsValid("/Script/SimpleCharts.GaugeData", FGaugeData_IsValid);
	}
}
