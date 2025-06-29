using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.AnimNode_SequencePlayerBase", "Engine", UnrealModuleType.Engine)]
public struct FAnimNode_SequencePlayerBase
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

	private static bool FAnimNode_SequencePlayerBase_IsValid;

	private static int FAnimNode_SequencePlayerBase_StructSize;

	public FAnimNode_SequencePlayerBase Copy()
	{
		return this;
	}

	public static FAnimNode_SequencePlayerBase FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_SequencePlayerBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_SequencePlayerBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_SequencePlayerBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_SequencePlayerBase(nativeBuffer + arrayIndex * FAnimNode_SequencePlayerBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_SequencePlayerBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_SequencePlayerBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_SequencePlayerBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimNode_SequencePlayerBase");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BlendWeight_Offset), BlendWeight);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InternalTimeAccumulator_Offset), InternalTimeAccumulator);
	}

	public FAnimNode_SequencePlayerBase(IntPtr nativeStruct)
	{
		if (!FAnimNode_SequencePlayerBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimNode_SequencePlayerBase");
			BlendWeight = 0f;
			InternalTimeAccumulator = 0f;
		}
		else
		{
			BlendWeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BlendWeight_Offset));
			InternalTimeAccumulator = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InternalTimeAccumulator_Offset));
		}
	}

	static FAnimNode_SequencePlayerBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_SequencePlayerBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_SequencePlayerBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AnimNode_SequencePlayerBase");
		FAnimNode_SequencePlayerBase_StructSize = NativeReflection.GetStructSize(intPtr);
		BlendWeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlendWeight");
		BlendWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlendWeight", Classes.FFloatProperty);
		InternalTimeAccumulator_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InternalTimeAccumulator");
		InternalTimeAccumulator_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InternalTimeAccumulator", Classes.FFloatProperty);
		FAnimNode_SequencePlayerBase_IsValid = intPtr != IntPtr.Zero && BlendWeight_IsValid && InternalTimeAccumulator_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.AnimNode_SequencePlayerBase", FAnimNode_SequencePlayerBase_IsValid);
	}
}
