using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.AnimNode_PoseDriver", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FAnimNode_PoseDriver
{
	private static bool PoseAsset_IsValid;

	private static int PoseAsset_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_PoseHandler:PoseAsset")]
	public UPoseAsset PoseAsset;

	private static bool BlendWeight_IsValid;

	private static int BlendWeight_Offset;

	[UProperty(Flags = (PropFlags)11267864954675716uL)]
	[UMetaPath("/Script/Engine.AnimNode_AssetPlayerBase:BlendWeight")]
	public float BlendWeight;

	private static bool InternalTimeAccumulator_IsValid;

	private static int InternalTimeAccumulator_Offset;

	[UProperty(Flags = (PropFlags)11267864954675716uL)]
	[UMetaPath("/Script/Engine.AnimNode_AssetPlayerBase:InternalTimeAccumulator")]
	public float InternalTimeAccumulator;

	private static bool SourcePose_IsValid;

	private static int SourcePose_Offset;

	[UProperty(Flags = (PropFlags)4503668346847301uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_PoseDriver:SourcePose")]
	public FPoseLink SourcePose;

	private static bool FAnimNode_PoseDriver_IsValid;

	private static int FAnimNode_PoseDriver_StructSize;

	public FAnimNode_PoseDriver Copy()
	{
		return this;
	}

	public static FAnimNode_PoseDriver FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_PoseDriver(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_PoseDriver value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_PoseDriver FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_PoseDriver(nativeBuffer + arrayIndex * FAnimNode_PoseDriver_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_PoseDriver value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_PoseDriver_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_PoseDriver_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_PoseDriver");
			return;
		}
		FPoseLink.ToNative(IntPtr.Add(nativeStruct, SourcePose_Offset), SourcePose);
		UObjectMarshaler<UPoseAsset>.ToNative(IntPtr.Add(nativeStruct, PoseAsset_Offset), PoseAsset);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BlendWeight_Offset), BlendWeight);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InternalTimeAccumulator_Offset), InternalTimeAccumulator);
	}

	public FAnimNode_PoseDriver(IntPtr nativeStruct)
	{
		if (!FAnimNode_PoseDriver_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_PoseDriver");
			SourcePose = default(FPoseLink);
			PoseAsset = null;
			BlendWeight = 0f;
			InternalTimeAccumulator = 0f;
		}
		else
		{
			SourcePose = FPoseLink.FromNative(IntPtr.Add(nativeStruct, SourcePose_Offset));
			PoseAsset = UObjectMarshaler<UPoseAsset>.FromNative(IntPtr.Add(nativeStruct, PoseAsset_Offset));
			BlendWeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BlendWeight_Offset));
			InternalTimeAccumulator = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InternalTimeAccumulator_Offset));
		}
	}

	static FAnimNode_PoseDriver()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_PoseDriver)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_PoseDriver));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.AnimNode_PoseDriver");
		FAnimNode_PoseDriver_StructSize = NativeReflection.GetStructSize(intPtr);
		PoseAsset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PoseAsset");
		PoseAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PoseAsset", Classes.FObjectProperty);
		BlendWeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlendWeight");
		BlendWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlendWeight", Classes.FFloatProperty);
		InternalTimeAccumulator_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InternalTimeAccumulator");
		InternalTimeAccumulator_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InternalTimeAccumulator", Classes.FFloatProperty);
		SourcePose_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SourcePose");
		SourcePose_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SourcePose", Classes.FStructProperty);
		FAnimNode_PoseDriver_IsValid = intPtr != IntPtr.Zero && SourcePose_IsValid && PoseAsset_IsValid && BlendWeight_IsValid && InternalTimeAccumulator_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.AnimNode_PoseDriver", FAnimNode_PoseDriver_IsValid);
	}
}
