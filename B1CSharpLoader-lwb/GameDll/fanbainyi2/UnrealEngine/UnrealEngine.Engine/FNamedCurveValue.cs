using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.NamedCurveValue", "Engine", UnrealModuleType.Engine)]
public struct FNamedCurveValue
{
	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.NamedCurveValue:Name")]
	public FName Name;

	private static bool Value_IsValid;

	private static int Value_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.NamedCurveValue:Value")]
	public float Value;

	private static bool FNamedCurveValue_IsValid;

	private static int FNamedCurveValue_StructSize;

	public FNamedCurveValue Copy()
	{
		return this;
	}

	public static FNamedCurveValue FromNative(IntPtr nativeBuffer)
	{
		return new FNamedCurveValue(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FNamedCurveValue value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FNamedCurveValue FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FNamedCurveValue(nativeBuffer + arrayIndex * FNamedCurveValue_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FNamedCurveValue value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FNamedCurveValue_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FNamedCurveValue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.NamedCurveValue");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
	}

	public FNamedCurveValue(IntPtr nativeStruct)
	{
		if (!FNamedCurveValue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.NamedCurveValue");
			Name = default(FName);
			Value = 0f;
		}
		else
		{
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			Value = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Value_Offset));
		}
	}

	static FNamedCurveValue()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FNamedCurveValue)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FNamedCurveValue));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.NamedCurveValue");
		FNamedCurveValue_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		Value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Value", Classes.FFloatProperty);
		FNamedCurveValue_IsValid = intPtr != IntPtr.Zero && Name_IsValid && Value_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.NamedCurveValue", FNamedCurveValue_IsValid);
	}
}
