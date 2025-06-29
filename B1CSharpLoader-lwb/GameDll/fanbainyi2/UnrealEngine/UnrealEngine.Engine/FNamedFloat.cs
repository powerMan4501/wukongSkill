using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.NamedFloat", "Engine", UnrealModuleType.Engine)]
public struct FNamedFloat
{
	private static bool Value_IsValid;

	private static int Value_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.NamedFloat:Value")]
	public float Value;

	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.NamedFloat:Name")]
	public FName Name;

	private static bool FNamedFloat_IsValid;

	private static int FNamedFloat_StructSize;

	public FNamedFloat Copy()
	{
		return this;
	}

	public static FNamedFloat FromNative(IntPtr nativeBuffer)
	{
		return new FNamedFloat(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FNamedFloat value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FNamedFloat FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FNamedFloat(nativeBuffer + arrayIndex * FNamedFloat_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FNamedFloat value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FNamedFloat_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FNamedFloat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.NamedFloat");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
	}

	public FNamedFloat(IntPtr nativeStruct)
	{
		if (!FNamedFloat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.NamedFloat");
			Value = 0f;
			Name = default(FName);
		}
		else
		{
			Value = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Value_Offset));
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
		}
	}

	static FNamedFloat()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FNamedFloat)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FNamedFloat));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.NamedFloat");
		FNamedFloat_StructSize = NativeReflection.GetStructSize(intPtr);
		Value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Value", Classes.FFloatProperty);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		FNamedFloat_IsValid = intPtr != IntPtr.Zero && Value_IsValid && Name_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.NamedFloat", FNamedFloat_IsValid);
	}
}
