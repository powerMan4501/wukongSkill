using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[UMetaPath("/Script/Engine.BoneReference", "Engine", UnrealModuleType.Engine)]
public struct FBoneReference
{
	private static bool BoneName_IsValid;

	private static int BoneName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274817uL)]
	[UMetaPath("/Script/Engine.BoneReference:BoneName")]
	public FName BoneName;

	private static bool FBoneReference_IsValid;

	private static int FBoneReference_StructSize;

	public FBoneReference Copy()
	{
		return this;
	}

	public static FBoneReference FromNative(IntPtr nativeBuffer)
	{
		return new FBoneReference(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBoneReference value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBoneReference FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBoneReference(nativeBuffer + arrayIndex * FBoneReference_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBoneReference value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FBoneReference_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FBoneReference_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.BoneReference");
		}
		else
		{
			BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, BoneName_Offset), BoneName);
		}
	}

	public FBoneReference(IntPtr nativeStruct)
	{
		if (!FBoneReference_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.BoneReference");
			BoneName = default(FName);
		}
		else
		{
			BoneName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, BoneName_Offset));
		}
	}

	static FBoneReference()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FBoneReference)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBoneReference));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.BoneReference");
		FBoneReference_StructSize = NativeReflection.GetStructSize(intPtr);
		BoneName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BoneName");
		BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BoneName", Classes.FNameProperty);
		FBoneReference_IsValid = intPtr != IntPtr.Zero && BoneName_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.BoneReference", FBoneReference_IsValid);
	}
}
