using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.AnimNode_SequenceEvaluator", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FAnimNode_SequenceEvaluator
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

	private static bool FAnimNode_SequenceEvaluator_IsValid;

	private static int FAnimNode_SequenceEvaluator_StructSize;

	public FAnimNode_SequenceEvaluator Copy()
	{
		return this;
	}

	public static FAnimNode_SequenceEvaluator FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_SequenceEvaluator(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_SequenceEvaluator value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_SequenceEvaluator FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_SequenceEvaluator(nativeBuffer + arrayIndex * FAnimNode_SequenceEvaluator_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_SequenceEvaluator value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_SequenceEvaluator_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_SequenceEvaluator_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_SequenceEvaluator");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BlendWeight_Offset), BlendWeight);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InternalTimeAccumulator_Offset), InternalTimeAccumulator);
	}

	public FAnimNode_SequenceEvaluator(IntPtr nativeStruct)
	{
		if (!FAnimNode_SequenceEvaluator_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_SequenceEvaluator");
			BlendWeight = 0f;
			InternalTimeAccumulator = 0f;
		}
		else
		{
			BlendWeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BlendWeight_Offset));
			InternalTimeAccumulator = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InternalTimeAccumulator_Offset));
		}
	}

	static FAnimNode_SequenceEvaluator()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_SequenceEvaluator)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_SequenceEvaluator));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.AnimNode_SequenceEvaluator");
		FAnimNode_SequenceEvaluator_StructSize = NativeReflection.GetStructSize(intPtr);
		BlendWeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlendWeight");
		BlendWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlendWeight", Classes.FFloatProperty);
		InternalTimeAccumulator_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InternalTimeAccumulator");
		InternalTimeAccumulator_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InternalTimeAccumulator", Classes.FFloatProperty);
		FAnimNode_SequenceEvaluator_IsValid = intPtr != IntPtr.Zero && BlendWeight_IsValid && InternalTimeAccumulator_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.AnimNode_SequenceEvaluator", FAnimNode_SequenceEvaluator_IsValid);
	}
}
