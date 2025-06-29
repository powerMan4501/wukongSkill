using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.MM;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/MM.SkeletonStructure", "MM", UnrealModuleType.GamePlugin)]
public struct FSkeletonStructure
{
	private static bool BoneTransformPosition_IsValid;

	private static int BoneTransformPosition_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MM.SkeletonStructure:BoneTransformPosition")]
	public FVector BoneTransformPosition;

	private static bool BoneTransformVelocity_IsValid;

	private static int BoneTransformVelocity_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MM.SkeletonStructure:BoneTransformVelocity")]
	public FVector BoneTransformVelocity;

	private static bool FSkeletonStructure_IsValid;

	private static int FSkeletonStructure_StructSize;

	public FSkeletonStructure Copy()
	{
		return this;
	}

	public static FSkeletonStructure FromNative(IntPtr nativeBuffer)
	{
		return new FSkeletonStructure(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSkeletonStructure value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSkeletonStructure FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSkeletonStructure(nativeBuffer + arrayIndex * FSkeletonStructure_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSkeletonStructure value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSkeletonStructure_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSkeletonStructure_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MM.SkeletonStructure");
			return;
		}
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, BoneTransformPosition_Offset), BoneTransformPosition);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, BoneTransformVelocity_Offset), BoneTransformVelocity);
	}

	public FSkeletonStructure(IntPtr nativeStruct)
	{
		if (!FSkeletonStructure_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MM.SkeletonStructure");
			BoneTransformPosition = default(FVector);
			BoneTransformVelocity = default(FVector);
		}
		else
		{
			BoneTransformPosition = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, BoneTransformPosition_Offset));
			BoneTransformVelocity = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, BoneTransformVelocity_Offset));
		}
	}

	static FSkeletonStructure()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSkeletonStructure)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSkeletonStructure));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MM.SkeletonStructure");
		FSkeletonStructure_StructSize = NativeReflection.GetStructSize(intPtr);
		BoneTransformPosition_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BoneTransformPosition");
		BoneTransformPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BoneTransformPosition", Classes.FStructProperty);
		BoneTransformVelocity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BoneTransformVelocity");
		BoneTransformVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BoneTransformVelocity", Classes.FStructProperty);
		FSkeletonStructure_IsValid = intPtr != IntPtr.Zero && BoneTransformPosition_IsValid && BoneTransformVelocity_IsValid;
		NativeReflection.LogStructIsValid("/Script/MM.SkeletonStructure", FSkeletonStructure_IsValid);
	}
}
