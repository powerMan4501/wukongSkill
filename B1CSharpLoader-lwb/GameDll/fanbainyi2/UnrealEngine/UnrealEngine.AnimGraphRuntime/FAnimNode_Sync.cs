using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.AnimNode_Sync", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FAnimNode_Sync
{
	private static bool FAnimNode_Sync_IsValid;

	private static int FAnimNode_Sync_StructSize;

	public FAnimNode_Sync Copy()
	{
		return this;
	}

	public static FAnimNode_Sync FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_Sync(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_Sync value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_Sync FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_Sync(nativeBuffer + arrayIndex * FAnimNode_Sync_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_Sync value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_Sync_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_Sync_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_Sync");
		}
	}

	public FAnimNode_Sync(IntPtr nativeStruct)
	{
		if (!FAnimNode_Sync_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_Sync");
		}
	}

	static FAnimNode_Sync()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_Sync)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_Sync));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.AnimNode_Sync");
		FAnimNode_Sync_StructSize = NativeReflection.GetStructSize(intPtr);
		FAnimNode_Sync_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.AnimNode_Sync", FAnimNode_Sync_IsValid);
	}
}
