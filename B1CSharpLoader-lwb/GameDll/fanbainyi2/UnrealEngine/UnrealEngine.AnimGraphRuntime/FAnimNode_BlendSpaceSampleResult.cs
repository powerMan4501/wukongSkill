using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.AnimNode_BlendSpaceSampleResult", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FAnimNode_BlendSpaceSampleResult
{
	private static bool Result_IsValid;

	private static int Result_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Engine.AnimNode_Root:Result")]
	public FPoseLink Result;

	private static bool FAnimNode_BlendSpaceSampleResult_IsValid;

	private static int FAnimNode_BlendSpaceSampleResult_StructSize;

	public FAnimNode_BlendSpaceSampleResult Copy()
	{
		return this;
	}

	public static FAnimNode_BlendSpaceSampleResult FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_BlendSpaceSampleResult(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_BlendSpaceSampleResult value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_BlendSpaceSampleResult FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_BlendSpaceSampleResult(nativeBuffer + arrayIndex * FAnimNode_BlendSpaceSampleResult_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_BlendSpaceSampleResult value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_BlendSpaceSampleResult_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_BlendSpaceSampleResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_BlendSpaceSampleResult");
		}
		else
		{
			FPoseLink.ToNative(IntPtr.Add(nativeStruct, Result_Offset), Result);
		}
	}

	public FAnimNode_BlendSpaceSampleResult(IntPtr nativeStruct)
	{
		if (!FAnimNode_BlendSpaceSampleResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_BlendSpaceSampleResult");
			Result = default(FPoseLink);
		}
		else
		{
			Result = FPoseLink.FromNative(IntPtr.Add(nativeStruct, Result_Offset));
		}
	}

	static FAnimNode_BlendSpaceSampleResult()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_BlendSpaceSampleResult)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_BlendSpaceSampleResult));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.AnimNode_BlendSpaceSampleResult");
		FAnimNode_BlendSpaceSampleResult_StructSize = NativeReflection.GetStructSize(intPtr);
		Result_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Result");
		Result_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Result", Classes.FStructProperty);
		FAnimNode_BlendSpaceSampleResult_IsValid = intPtr != IntPtr.Zero && Result_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.AnimNode_BlendSpaceSampleResult", FAnimNode_BlendSpaceSampleResult_IsValid);
	}
}
