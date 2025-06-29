using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.AnimNode_PoseHandler", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FAnimNode_PoseHandler
{
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

	private static bool PoseAsset_IsValid;

	private static int PoseAsset_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_PoseHandler:PoseAsset")]
	public UPoseAsset PoseAsset;

	private static bool FAnimNode_PoseHandler_IsValid;

	private static int FAnimNode_PoseHandler_StructSize;

	public FAnimNode_PoseHandler Copy()
	{
		return this;
	}

	public static FAnimNode_PoseHandler FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_PoseHandler(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_PoseHandler value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_PoseHandler FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_PoseHandler(nativeBuffer + arrayIndex * FAnimNode_PoseHandler_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_PoseHandler value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_PoseHandler_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_PoseHandler_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_PoseHandler");
			return;
		}
		UObjectMarshaler<UPoseAsset>.ToNative(IntPtr.Add(nativeStruct, PoseAsset_Offset), PoseAsset);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BlendWeight_Offset), BlendWeight);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InternalTimeAccumulator_Offset), InternalTimeAccumulator);
	}

	public FAnimNode_PoseHandler(IntPtr nativeStruct)
	{
		if (!FAnimNode_PoseHandler_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_PoseHandler");
			PoseAsset = null;
			BlendWeight = 0f;
			InternalTimeAccumulator = 0f;
		}
		else
		{
			PoseAsset = UObjectMarshaler<UPoseAsset>.FromNative(IntPtr.Add(nativeStruct, PoseAsset_Offset));
			BlendWeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BlendWeight_Offset));
			InternalTimeAccumulator = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InternalTimeAccumulator_Offset));
		}
	}

	static FAnimNode_PoseHandler()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_PoseHandler)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_PoseHandler));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.AnimNode_PoseHandler");
		FAnimNode_PoseHandler_StructSize = NativeReflection.GetStructSize(intPtr);
		BlendWeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlendWeight");
		BlendWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlendWeight", Classes.FFloatProperty);
		InternalTimeAccumulator_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InternalTimeAccumulator");
		InternalTimeAccumulator_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InternalTimeAccumulator", Classes.FFloatProperty);
		PoseAsset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PoseAsset");
		PoseAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PoseAsset", Classes.FObjectProperty);
		FAnimNode_PoseHandler_IsValid = intPtr != IntPtr.Zero && PoseAsset_IsValid && BlendWeight_IsValid && InternalTimeAccumulator_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.AnimNode_PoseHandler", FAnimNode_PoseHandler_IsValid);
	}
}
