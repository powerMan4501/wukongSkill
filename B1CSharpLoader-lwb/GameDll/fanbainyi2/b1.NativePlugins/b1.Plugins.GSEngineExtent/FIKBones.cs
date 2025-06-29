using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSEngineExtent;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GSEngineExtent.IKBones", "GSEngineExtent", UnrealModuleType.GamePlugin)]
public struct FIKBones
{
	private static bool NumBonesInLimb_IsValid;

	private static int NumBonesInLimb_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/GSEngineExtent.IKBones:NumBonesInLimb")]
	public int NumBonesInLimb;

	private static bool FIKBones_IsValid;

	private static int FIKBones_StructSize;

	public FIKBones Copy()
	{
		return this;
	}

	public static FIKBones FromNative(IntPtr nativeBuffer)
	{
		return new FIKBones(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FIKBones value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FIKBones FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FIKBones(nativeBuffer + arrayIndex * FIKBones_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FIKBones value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FIKBones_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FIKBones_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSEngineExtent.IKBones");
		}
		else
		{
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, NumBonesInLimb_Offset), NumBonesInLimb);
		}
	}

	public FIKBones(IntPtr nativeStruct)
	{
		if (!FIKBones_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSEngineExtent.IKBones");
			NumBonesInLimb = 0;
		}
		else
		{
			NumBonesInLimb = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, NumBonesInLimb_Offset));
		}
	}

	static FIKBones()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FIKBones)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FIKBones));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GSEngineExtent.IKBones");
		FIKBones_StructSize = NativeReflection.GetStructSize(intPtr);
		NumBonesInLimb_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumBonesInLimb");
		NumBonesInLimb_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumBonesInLimb", Classes.FIntProperty);
		FIKBones_IsValid = intPtr != IntPtr.Zero && NumBonesInLimb_IsValid;
		NativeReflection.LogStructIsValid("/Script/GSEngineExtent.IKBones", FIKBones_IsValid);
	}
}
