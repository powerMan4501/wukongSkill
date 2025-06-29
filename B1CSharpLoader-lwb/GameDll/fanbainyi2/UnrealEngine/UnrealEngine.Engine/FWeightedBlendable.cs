using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.WeightedBlendable", "Engine", UnrealModuleType.Engine)]
public struct FWeightedBlendable
{
	private static bool Weight_IsValid;

	private static int Weight_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.WeightedBlendable:Weight")]
	public float Weight;

	private static bool Object_IsValid;

	private static int Object_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.WeightedBlendable:Object")]
	public UObject Object;

	private static bool FWeightedBlendable_IsValid;

	private static int FWeightedBlendable_StructSize;

	public FWeightedBlendable Copy()
	{
		return this;
	}

	public static FWeightedBlendable FromNative(IntPtr nativeBuffer)
	{
		return new FWeightedBlendable(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FWeightedBlendable value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FWeightedBlendable FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FWeightedBlendable(nativeBuffer + arrayIndex * FWeightedBlendable_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FWeightedBlendable value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FWeightedBlendable_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FWeightedBlendable_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.WeightedBlendable");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Weight_Offset), Weight);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(nativeStruct, Object_Offset), Object);
	}

	public FWeightedBlendable(IntPtr nativeStruct)
	{
		if (!FWeightedBlendable_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.WeightedBlendable");
			Weight = 0f;
			Object = null;
		}
		else
		{
			Weight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Weight_Offset));
			Object = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(nativeStruct, Object_Offset));
		}
	}

	static FWeightedBlendable()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FWeightedBlendable)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FWeightedBlendable));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.WeightedBlendable");
		FWeightedBlendable_StructSize = NativeReflection.GetStructSize(intPtr);
		Weight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Weight");
		Weight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Weight", Classes.FFloatProperty);
		Object_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Object");
		Object_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Object", Classes.FObjectProperty);
		FWeightedBlendable_IsValid = intPtr != IntPtr.Zero && Weight_IsValid && Object_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.WeightedBlendable", FWeightedBlendable_IsValid);
	}
}
