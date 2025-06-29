using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimationCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimationCore.TransformNoScale", "AnimationCore", UnrealModuleType.Engine)]
public struct FTransformNoScale
{
	private static bool Location_IsValid;

	private static int Location_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimationCore.TransformNoScale:Location")]
	public FVector Location;

	private static bool Rotation_IsValid;

	private static int Rotation_Offset;

	[UProperty(Flags = (PropFlags)4503669420589061uL)]
	[UMetaPath("/Script/AnimationCore.TransformNoScale:Rotation")]
	public FQuat Rotation;

	private static bool FTransformNoScale_IsValid;

	private static int FTransformNoScale_StructSize;

	public FTransformNoScale Copy()
	{
		return this;
	}

	public static FTransformNoScale FromNative(IntPtr nativeBuffer)
	{
		return new FTransformNoScale(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTransformNoScale value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTransformNoScale FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTransformNoScale(nativeBuffer + arrayIndex * FTransformNoScale_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTransformNoScale value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTransformNoScale_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTransformNoScale_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimationCore.TransformNoScale");
			return;
		}
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Location_Offset), Location);
		BlittableTypeMarshaler<FQuat>.ToNative(IntPtr.Add(nativeStruct, Rotation_Offset), Rotation);
	}

	public FTransformNoScale(IntPtr nativeStruct)
	{
		if (!FTransformNoScale_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimationCore.TransformNoScale");
			Location = default(FVector);
			Rotation = default(FQuat);
		}
		else
		{
			Location = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Location_Offset));
			Rotation = BlittableTypeMarshaler<FQuat>.FromNative(IntPtr.Add(nativeStruct, Rotation_Offset));
		}
	}

	static FTransformNoScale()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTransformNoScale)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTransformNoScale));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimationCore.TransformNoScale");
		FTransformNoScale_StructSize = NativeReflection.GetStructSize(intPtr);
		Location_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Location");
		Location_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Location", Classes.FStructProperty);
		Rotation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Rotation");
		Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Rotation", Classes.FStructProperty);
		FTransformNoScale_IsValid = intPtr != IntPtr.Zero && Location_IsValid && Rotation_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimationCore.TransformNoScale", FTransformNoScale_IsValid);
	}
}
