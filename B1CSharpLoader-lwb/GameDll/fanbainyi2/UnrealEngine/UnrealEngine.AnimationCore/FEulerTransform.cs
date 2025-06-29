using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimationCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimationCore.EulerTransform", "AnimationCore", UnrealModuleType.Engine)]
public struct FEulerTransform
{
	private static bool Location_IsValid;

	private static int Location_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimationCore.EulerTransform:Location")]
	public FVector Location;

	private static bool Rotation_IsValid;

	private static int Rotation_Offset;

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/AnimationCore.EulerTransform:Rotation")]
	public FRotator Rotation;

	private static bool Scale_IsValid;

	private static int Scale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimationCore.EulerTransform:Scale")]
	public FVector Scale;

	private static bool FEulerTransform_IsValid;

	private static int FEulerTransform_StructSize;

	public FEulerTransform Copy()
	{
		return this;
	}

	public static FEulerTransform FromNative(IntPtr nativeBuffer)
	{
		return new FEulerTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FEulerTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FEulerTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FEulerTransform(nativeBuffer + arrayIndex * FEulerTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FEulerTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FEulerTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FEulerTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimationCore.EulerTransform");
			return;
		}
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Location_Offset), Location);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(nativeStruct, Rotation_Offset), Rotation);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Scale_Offset), Scale);
	}

	public FEulerTransform(IntPtr nativeStruct)
	{
		if (!FEulerTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimationCore.EulerTransform");
			Location = default(FVector);
			Rotation = default(FRotator);
			Scale = default(FVector);
		}
		else
		{
			Location = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Location_Offset));
			Rotation = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(nativeStruct, Rotation_Offset));
			Scale = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Scale_Offset));
		}
	}

	static FEulerTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FEulerTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FEulerTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimationCore.EulerTransform");
		FEulerTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		Location_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Location");
		Location_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Location", Classes.FStructProperty);
		Rotation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Rotation");
		Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Rotation", Classes.FStructProperty);
		Scale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Scale");
		Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Scale", Classes.FStructProperty);
		FEulerTransform_IsValid = intPtr != IntPtr.Zero && Location_IsValid && Rotation_IsValid && Scale_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimationCore.EulerTransform", FEulerTransform_IsValid);
	}
}
