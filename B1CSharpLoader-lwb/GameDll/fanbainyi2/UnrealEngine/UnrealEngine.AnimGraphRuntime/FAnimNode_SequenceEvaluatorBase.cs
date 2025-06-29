using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.AnimNode_SequenceEvaluatorBase", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FAnimNode_SequenceEvaluatorBase
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

	private static bool FAnimNode_SequenceEvaluatorBase_IsValid;

	private static int FAnimNode_SequenceEvaluatorBase_StructSize;

	public FAnimNode_SequenceEvaluatorBase Copy()
	{
		return this;
	}

	public static FAnimNode_SequenceEvaluatorBase FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_SequenceEvaluatorBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_SequenceEvaluatorBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_SequenceEvaluatorBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_SequenceEvaluatorBase(nativeBuffer + arrayIndex * FAnimNode_SequenceEvaluatorBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_SequenceEvaluatorBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_SequenceEvaluatorBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_SequenceEvaluatorBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_SequenceEvaluatorBase");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BlendWeight_Offset), BlendWeight);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InternalTimeAccumulator_Offset), InternalTimeAccumulator);
	}

	public FAnimNode_SequenceEvaluatorBase(IntPtr nativeStruct)
	{
		if (!FAnimNode_SequenceEvaluatorBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_SequenceEvaluatorBase");
			BlendWeight = 0f;
			InternalTimeAccumulator = 0f;
		}
		else
		{
			BlendWeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BlendWeight_Offset));
			InternalTimeAccumulator = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InternalTimeAccumulator_Offset));
		}
	}

	static FAnimNode_SequenceEvaluatorBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_SequenceEvaluatorBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_SequenceEvaluatorBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.AnimNode_SequenceEvaluatorBase");
		FAnimNode_SequenceEvaluatorBase_StructSize = NativeReflection.GetStructSize(intPtr);
		BlendWeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlendWeight");
		BlendWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlendWeight", Classes.FFloatProperty);
		InternalTimeAccumulator_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InternalTimeAccumulator");
		InternalTimeAccumulator_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InternalTimeAccumulator", Classes.FFloatProperty);
		FAnimNode_SequenceEvaluatorBase_IsValid = intPtr != IntPtr.Zero && BlendWeight_IsValid && InternalTimeAccumulator_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.AnimNode_SequenceEvaluatorBase", FAnimNode_SequenceEvaluatorBase_IsValid);
	}
}
