using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.SimpleCharts;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/SimpleCharts.links", "SimpleCharts", UnrealModuleType.GamePlugin)]
public struct Flinks
{
	private static bool source_IsValid;

	private static int source_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/SimpleCharts.links:source")]
	public string source;

	private static bool target_IsValid;

	private static int target_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/SimpleCharts.links:target")]
	public string target;

	private static bool value_IsValid;

	private static int value_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.links:value")]
	public float value;

	private static bool Flinks_IsValid;

	private static int Flinks_StructSize;

	public Flinks Copy()
	{
		return this;
	}

	public static Flinks FromNative(IntPtr nativeBuffer)
	{
		return new Flinks(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, Flinks value)
	{
		value.ToNative(nativeBuffer);
	}

	public static Flinks FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new Flinks(nativeBuffer + arrayIndex * Flinks_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, Flinks value)
	{
		value.ToNative(nativeBuffer + arrayIndex * Flinks_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!Flinks_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.links");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, source_Offset), source);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, target_Offset), target);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, value_Offset), value);
	}

	public Flinks(IntPtr nativeStruct)
	{
		if (!Flinks_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.links");
			source = FStringMarshaler.DefaultString;
			target = FStringMarshaler.DefaultString;
			value = 0f;
		}
		else
		{
			source = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, source_Offset));
			target = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, target_Offset));
			value = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, value_Offset));
		}
	}

	static Flinks()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(Flinks)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(Flinks));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SimpleCharts.links");
		Flinks_StructSize = NativeReflection.GetStructSize(intPtr);
		source_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "source");
		source_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "source", Classes.FStrProperty);
		target_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "target");
		target_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "target", Classes.FStrProperty);
		value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "value");
		value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "value", Classes.FFloatProperty);
		Flinks_IsValid = intPtr != IntPtr.Zero && source_IsValid && target_IsValid && value_IsValid;
		NativeReflection.LogStructIsValid("/Script/SimpleCharts.links", Flinks_IsValid);
	}
}
