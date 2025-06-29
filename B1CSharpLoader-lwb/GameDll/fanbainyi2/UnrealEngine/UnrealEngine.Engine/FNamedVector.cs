using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.NamedVector", "Engine", UnrealModuleType.Engine)]
public struct FNamedVector
{
	private static bool Value_IsValid;

	private static int Value_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.NamedVector:Value")]
	public FVector Value;

	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.NamedVector:Name")]
	public FName Name;

	private static bool FNamedVector_IsValid;

	private static int FNamedVector_StructSize;

	public FNamedVector Copy()
	{
		return this;
	}

	public static FNamedVector FromNative(IntPtr nativeBuffer)
	{
		return new FNamedVector(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FNamedVector value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FNamedVector FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FNamedVector(nativeBuffer + arrayIndex * FNamedVector_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FNamedVector value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FNamedVector_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FNamedVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.NamedVector");
			return;
		}
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
	}

	public FNamedVector(IntPtr nativeStruct)
	{
		if (!FNamedVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.NamedVector");
			Value = default(FVector);
			Name = default(FName);
		}
		else
		{
			Value = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Value_Offset));
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
		}
	}

	static FNamedVector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FNamedVector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FNamedVector));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.NamedVector");
		FNamedVector_StructSize = NativeReflection.GetStructSize(intPtr);
		Value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Value", Classes.FStructProperty);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		FNamedVector_IsValid = intPtr != IntPtr.Zero && Value_IsValid && Name_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.NamedVector", FNamedVector_IsValid);
	}
}
