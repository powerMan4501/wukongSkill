using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.SimpleCharts;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/SimpleCharts.Indicator", "SimpleCharts", UnrealModuleType.GamePlugin)]
public struct FIndicator
{
	private static bool name_IsValid;

	private static int name_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/SimpleCharts.Indicator:name")]
	public string name;

	private static bool max_IsValid;

	private static int max_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.Indicator:max")]
	public float max;

	private static bool FIndicator_IsValid;

	private static int FIndicator_StructSize;

	public FIndicator Copy()
	{
		return this;
	}

	public static FIndicator FromNative(IntPtr nativeBuffer)
	{
		return new FIndicator(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FIndicator value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FIndicator FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FIndicator(nativeBuffer + arrayIndex * FIndicator_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FIndicator value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FIndicator_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FIndicator_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.Indicator");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, name_Offset), name);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, max_Offset), max);
	}

	public FIndicator(IntPtr nativeStruct)
	{
		if (!FIndicator_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.Indicator");
			name = FStringMarshaler.DefaultString;
			max = 0f;
		}
		else
		{
			name = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, name_Offset));
			max = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, max_Offset));
		}
	}

	static FIndicator()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FIndicator)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FIndicator));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SimpleCharts.Indicator");
		FIndicator_StructSize = NativeReflection.GetStructSize(intPtr);
		name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "name");
		name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "name", Classes.FStrProperty);
		max_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "max");
		max_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "max", Classes.FFloatProperty);
		FIndicator_IsValid = intPtr != IntPtr.Zero && name_IsValid && max_IsValid;
		NativeReflection.LogStructIsValid("/Script/SimpleCharts.Indicator", FIndicator_IsValid);
	}
}
