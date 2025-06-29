using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.AnimNode_SaveCachedPose", "Engine", UnrealModuleType.Engine)]
public struct FAnimNode_SaveCachedPose
{
	private static bool Pose_IsValid;

	private static int Pose_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Engine.AnimNode_SaveCachedPose:Pose")]
	public FPoseLink Pose;

	private static bool FAnimNode_SaveCachedPose_IsValid;

	private static int FAnimNode_SaveCachedPose_StructSize;

	public FAnimNode_SaveCachedPose Copy()
	{
		return this;
	}

	public static FAnimNode_SaveCachedPose FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_SaveCachedPose(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_SaveCachedPose value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_SaveCachedPose FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_SaveCachedPose(nativeBuffer + arrayIndex * FAnimNode_SaveCachedPose_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_SaveCachedPose value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_SaveCachedPose_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_SaveCachedPose_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimNode_SaveCachedPose");
		}
		else
		{
			FPoseLink.ToNative(IntPtr.Add(nativeStruct, Pose_Offset), Pose);
		}
	}

	public FAnimNode_SaveCachedPose(IntPtr nativeStruct)
	{
		if (!FAnimNode_SaveCachedPose_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimNode_SaveCachedPose");
			Pose = default(FPoseLink);
		}
		else
		{
			Pose = FPoseLink.FromNative(IntPtr.Add(nativeStruct, Pose_Offset));
		}
	}

	static FAnimNode_SaveCachedPose()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_SaveCachedPose)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_SaveCachedPose));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AnimNode_SaveCachedPose");
		FAnimNode_SaveCachedPose_StructSize = NativeReflection.GetStructSize(intPtr);
		Pose_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Pose");
		Pose_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Pose", Classes.FStructProperty);
		FAnimNode_SaveCachedPose_IsValid = intPtr != IntPtr.Zero && Pose_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.AnimNode_SaveCachedPose", FAnimNode_SaveCachedPose_IsValid);
	}
}
