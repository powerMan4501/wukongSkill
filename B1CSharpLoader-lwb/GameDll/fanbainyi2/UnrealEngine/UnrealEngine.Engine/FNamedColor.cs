using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.NamedColor", "Engine", UnrealModuleType.Engine)]
public struct FNamedColor
{
	private static bool Value_IsValid;

	private static int Value_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.NamedColor:Value")]
	public FColor Value;

	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.NamedColor:Name")]
	public FName Name;

	private static bool FNamedColor_IsValid;

	private static int FNamedColor_StructSize;

	public FNamedColor Copy()
	{
		return this;
	}

	public static FNamedColor FromNative(IntPtr nativeBuffer)
	{
		return new FNamedColor(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FNamedColor value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FNamedColor FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FNamedColor(nativeBuffer + arrayIndex * FNamedColor_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FNamedColor value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FNamedColor_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FNamedColor_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.NamedColor");
			return;
		}
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
	}

	public FNamedColor(IntPtr nativeStruct)
	{
		if (!FNamedColor_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.NamedColor");
			Value = default(FColor);
			Name = default(FName);
		}
		else
		{
			Value = BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(nativeStruct, Value_Offset));
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
		}
	}

	static FNamedColor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FNamedColor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FNamedColor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.NamedColor");
		FNamedColor_StructSize = NativeReflection.GetStructSize(intPtr);
		Value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Value", Classes.FStructProperty);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		FNamedColor_IsValid = intPtr != IntPtr.Zero && Value_IsValid && Name_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.NamedColor", FNamedColor_IsValid);
	}
}
