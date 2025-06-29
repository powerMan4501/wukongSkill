using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.AnimNode_SingleNode", "Engine", UnrealModuleType.Engine)]
public struct FAnimNode_SingleNode
{
	private static bool SourcePose_IsValid;

	private static int SourcePose_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Engine.AnimNode_SingleNode:SourcePose")]
	public FPoseLink SourcePose;

	private static bool FAnimNode_SingleNode_IsValid;

	private static int FAnimNode_SingleNode_StructSize;

	public FAnimNode_SingleNode Copy()
	{
		return this;
	}

	public static FAnimNode_SingleNode FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_SingleNode(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_SingleNode value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_SingleNode FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_SingleNode(nativeBuffer + arrayIndex * FAnimNode_SingleNode_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_SingleNode value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_SingleNode_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_SingleNode_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimNode_SingleNode");
		}
		else
		{
			FPoseLink.ToNative(IntPtr.Add(nativeStruct, SourcePose_Offset), SourcePose);
		}
	}

	public FAnimNode_SingleNode(IntPtr nativeStruct)
	{
		if (!FAnimNode_SingleNode_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimNode_SingleNode");
			SourcePose = default(FPoseLink);
		}
		else
		{
			SourcePose = FPoseLink.FromNative(IntPtr.Add(nativeStruct, SourcePose_Offset));
		}
	}

	static FAnimNode_SingleNode()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_SingleNode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_SingleNode));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AnimNode_SingleNode");
		FAnimNode_SingleNode_StructSize = NativeReflection.GetStructSize(intPtr);
		SourcePose_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SourcePose");
		SourcePose_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SourcePose", Classes.FStructProperty);
		FAnimNode_SingleNode_IsValid = intPtr != IntPtr.Zero && SourcePose_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.AnimNode_SingleNode", FAnimNode_SingleNode_IsValid);
	}
}
