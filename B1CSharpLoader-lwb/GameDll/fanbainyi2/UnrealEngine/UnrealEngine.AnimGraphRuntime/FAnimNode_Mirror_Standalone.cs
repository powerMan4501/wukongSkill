using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.AnimNode_Mirror_Standalone", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FAnimNode_Mirror_Standalone
{
	private static bool FAnimNode_Mirror_Standalone_IsValid;

	private static int FAnimNode_Mirror_Standalone_StructSize;

	public FAnimNode_Mirror_Standalone Copy()
	{
		return this;
	}

	public static FAnimNode_Mirror_Standalone FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_Mirror_Standalone(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_Mirror_Standalone value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_Mirror_Standalone FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_Mirror_Standalone(nativeBuffer + arrayIndex * FAnimNode_Mirror_Standalone_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_Mirror_Standalone value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_Mirror_Standalone_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_Mirror_Standalone_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_Mirror_Standalone");
		}
	}

	public FAnimNode_Mirror_Standalone(IntPtr nativeStruct)
	{
		if (!FAnimNode_Mirror_Standalone_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_Mirror_Standalone");
		}
	}

	static FAnimNode_Mirror_Standalone()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_Mirror_Standalone)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_Mirror_Standalone));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.AnimNode_Mirror_Standalone");
		FAnimNode_Mirror_Standalone_StructSize = NativeReflection.GetStructSize(intPtr);
		FAnimNode_Mirror_Standalone_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.AnimNode_Mirror_Standalone", FAnimNode_Mirror_Standalone_IsValid);
	}
}
