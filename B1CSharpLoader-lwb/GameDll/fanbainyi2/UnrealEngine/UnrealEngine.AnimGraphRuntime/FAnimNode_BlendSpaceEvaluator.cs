using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.AnimNode_BlendSpaceEvaluator", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FAnimNode_BlendSpaceEvaluator
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

	private static bool NormalizedTime_IsValid;

	private static int NormalizedTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_BlendSpaceEvaluator:NormalizedTime")]
	public float NormalizedTime;

	private static bool FAnimNode_BlendSpaceEvaluator_IsValid;

	private static int FAnimNode_BlendSpaceEvaluator_StructSize;

	public FAnimNode_BlendSpaceEvaluator Copy()
	{
		return this;
	}

	public static FAnimNode_BlendSpaceEvaluator FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_BlendSpaceEvaluator(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_BlendSpaceEvaluator value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_BlendSpaceEvaluator FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_BlendSpaceEvaluator(nativeBuffer + arrayIndex * FAnimNode_BlendSpaceEvaluator_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_BlendSpaceEvaluator value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_BlendSpaceEvaluator_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_BlendSpaceEvaluator_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_BlendSpaceEvaluator");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, NormalizedTime_Offset), NormalizedTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BlendWeight_Offset), BlendWeight);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InternalTimeAccumulator_Offset), InternalTimeAccumulator);
	}

	public FAnimNode_BlendSpaceEvaluator(IntPtr nativeStruct)
	{
		if (!FAnimNode_BlendSpaceEvaluator_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_BlendSpaceEvaluator");
			NormalizedTime = 0f;
			BlendWeight = 0f;
			InternalTimeAccumulator = 0f;
		}
		else
		{
			NormalizedTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, NormalizedTime_Offset));
			BlendWeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BlendWeight_Offset));
			InternalTimeAccumulator = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InternalTimeAccumulator_Offset));
		}
	}

	static FAnimNode_BlendSpaceEvaluator()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_BlendSpaceEvaluator)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_BlendSpaceEvaluator));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.AnimNode_BlendSpaceEvaluator");
		FAnimNode_BlendSpaceEvaluator_StructSize = NativeReflection.GetStructSize(intPtr);
		BlendWeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlendWeight");
		BlendWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlendWeight", Classes.FFloatProperty);
		InternalTimeAccumulator_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InternalTimeAccumulator");
		InternalTimeAccumulator_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InternalTimeAccumulator", Classes.FFloatProperty);
		NormalizedTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NormalizedTime");
		NormalizedTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NormalizedTime", Classes.FFloatProperty);
		FAnimNode_BlendSpaceEvaluator_IsValid = intPtr != IntPtr.Zero && NormalizedTime_IsValid && BlendWeight_IsValid && InternalTimeAccumulator_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.AnimNode_BlendSpaceEvaluator", FAnimNode_BlendSpaceEvaluator_IsValid);
	}
}
