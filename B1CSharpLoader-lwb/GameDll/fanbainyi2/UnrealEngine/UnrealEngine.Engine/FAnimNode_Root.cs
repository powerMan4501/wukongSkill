using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.AnimNode_Root", "Engine", UnrealModuleType.Engine)]
public struct FAnimNode_Root
{
	private static bool Result_IsValid;

	private static int Result_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Engine.AnimNode_Root:Result")]
	public FPoseLink Result;

	private static bool FAnimNode_Root_IsValid;

	private static int FAnimNode_Root_StructSize;

	public FAnimNode_Root Copy()
	{
		return this;
	}

	public static FAnimNode_Root FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_Root(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_Root value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_Root FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_Root(nativeBuffer + arrayIndex * FAnimNode_Root_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_Root value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_Root_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_Root_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimNode_Root");
		}
		else
		{
			FPoseLink.ToNative(IntPtr.Add(nativeStruct, Result_Offset), Result);
		}
	}

	public FAnimNode_Root(IntPtr nativeStruct)
	{
		if (!FAnimNode_Root_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimNode_Root");
			Result = default(FPoseLink);
		}
		else
		{
			Result = FPoseLink.FromNative(IntPtr.Add(nativeStruct, Result_Offset));
		}
	}

	static FAnimNode_Root()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_Root)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_Root));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AnimNode_Root");
		FAnimNode_Root_StructSize = NativeReflection.GetStructSize(intPtr);
		Result_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Result");
		Result_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Result", Classes.FStructProperty);
		FAnimNode_Root_IsValid = intPtr != IntPtr.Zero && Result_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.AnimNode_Root", FAnimNode_Root_IsValid);
	}
}
