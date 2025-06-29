using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.NamedTransform", "Engine", UnrealModuleType.Engine)]
public struct FNamedTransform
{
	private static bool Value_IsValid;

	private static int Value_Offset;

	[UProperty(Flags = (PropFlags)4503669420589061uL)]
	[UMetaPath("/Script/Engine.NamedTransform:Value")]
	public FTransform Value;

	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.NamedTransform:Name")]
	public FName Name;

	private static bool FNamedTransform_IsValid;

	private static int FNamedTransform_StructSize;

	public FNamedTransform Copy()
	{
		return this;
	}

	public static FNamedTransform FromNative(IntPtr nativeBuffer)
	{
		return new FNamedTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FNamedTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FNamedTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FNamedTransform(nativeBuffer + arrayIndex * FNamedTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FNamedTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FNamedTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FNamedTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.NamedTransform");
			return;
		}
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
	}

	public FNamedTransform(IntPtr nativeStruct)
	{
		if (!FNamedTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.NamedTransform");
			Value = default(FTransform);
			Name = default(FName);
		}
		else
		{
			Value = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(nativeStruct, Value_Offset));
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
		}
	}

	static FNamedTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FNamedTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FNamedTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.NamedTransform");
		FNamedTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		Value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Value", Classes.FStructProperty);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		FNamedTransform_IsValid = intPtr != IntPtr.Zero && Value_IsValid && Name_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.NamedTransform", FNamedTransform_IsValid);
	}
}
