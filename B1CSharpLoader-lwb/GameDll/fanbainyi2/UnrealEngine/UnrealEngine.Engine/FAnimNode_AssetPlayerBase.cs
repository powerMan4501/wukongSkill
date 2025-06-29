using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.AnimNode_AssetPlayerBase", "Engine", UnrealModuleType.Engine)]
public struct FAnimNode_AssetPlayerBase
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

	private static bool FAnimNode_AssetPlayerBase_IsValid;

	private static int FAnimNode_AssetPlayerBase_StructSize;

	public FAnimNode_AssetPlayerBase Copy()
	{
		return this;
	}

	public static FAnimNode_AssetPlayerBase FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_AssetPlayerBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_AssetPlayerBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_AssetPlayerBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_AssetPlayerBase(nativeBuffer + arrayIndex * FAnimNode_AssetPlayerBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_AssetPlayerBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_AssetPlayerBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_AssetPlayerBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimNode_AssetPlayerBase");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BlendWeight_Offset), BlendWeight);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InternalTimeAccumulator_Offset), InternalTimeAccumulator);
	}

	public FAnimNode_AssetPlayerBase(IntPtr nativeStruct)
	{
		if (!FAnimNode_AssetPlayerBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimNode_AssetPlayerBase");
			BlendWeight = 0f;
			InternalTimeAccumulator = 0f;
		}
		else
		{
			BlendWeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BlendWeight_Offset));
			InternalTimeAccumulator = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InternalTimeAccumulator_Offset));
		}
	}

	static FAnimNode_AssetPlayerBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_AssetPlayerBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_AssetPlayerBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AnimNode_AssetPlayerBase");
		FAnimNode_AssetPlayerBase_StructSize = NativeReflection.GetStructSize(intPtr);
		BlendWeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlendWeight");
		BlendWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlendWeight", Classes.FFloatProperty);
		InternalTimeAccumulator_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InternalTimeAccumulator");
		InternalTimeAccumulator_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InternalTimeAccumulator", Classes.FFloatProperty);
		FAnimNode_AssetPlayerBase_IsValid = intPtr != IntPtr.Zero && BlendWeight_IsValid && InternalTimeAccumulator_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.AnimNode_AssetPlayerBase", FAnimNode_AssetPlayerBase_IsValid);
	}
}
