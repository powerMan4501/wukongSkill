using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UStruct(Flags = 528897)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.AnimNode_StateResult", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FAnimNode_StateResult
{
	private static bool Result_IsValid;

	private static int Result_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Engine.AnimNode_Root:Result")]
	public FPoseLink Result;

	private static bool FAnimNode_StateResult_IsValid;

	private static int FAnimNode_StateResult_StructSize;

	public FAnimNode_StateResult Copy()
	{
		return this;
	}

	public static FAnimNode_StateResult FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_StateResult(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_StateResult value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_StateResult FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_StateResult(nativeBuffer + arrayIndex * FAnimNode_StateResult_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_StateResult value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_StateResult_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_StateResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_StateResult");
		}
		else
		{
			FPoseLink.ToNative(IntPtr.Add(nativeStruct, Result_Offset), Result);
		}
	}

	public FAnimNode_StateResult(IntPtr nativeStruct)
	{
		if (!FAnimNode_StateResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_StateResult");
			Result = default(FPoseLink);
		}
		else
		{
			Result = FPoseLink.FromNative(IntPtr.Add(nativeStruct, Result_Offset));
		}
	}

	static FAnimNode_StateResult()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_StateResult)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_StateResult));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.AnimNode_StateResult");
		FAnimNode_StateResult_StructSize = NativeReflection.GetStructSize(intPtr);
		Result_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Result");
		Result_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Result", Classes.FStructProperty);
		FAnimNode_StateResult_IsValid = intPtr != IntPtr.Zero && Result_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.AnimNode_StateResult", FAnimNode_StateResult_IsValid);
	}
}
