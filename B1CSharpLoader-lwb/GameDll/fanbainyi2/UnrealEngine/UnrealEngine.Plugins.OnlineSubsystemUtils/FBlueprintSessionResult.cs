using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystemUtils;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/OnlineSubsystemUtils.BlueprintSessionResult", "OnlineSubsystemUtils", UnrealModuleType.EnginePlugin)]
public struct FBlueprintSessionResult
{
	private static bool FBlueprintSessionResult_IsValid;

	private static int FBlueprintSessionResult_StructSize;

	public FBlueprintSessionResult Copy()
	{
		return this;
	}

	public static FBlueprintSessionResult FromNative(IntPtr nativeBuffer)
	{
		return new FBlueprintSessionResult(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBlueprintSessionResult value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBlueprintSessionResult FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBlueprintSessionResult(nativeBuffer + arrayIndex * FBlueprintSessionResult_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBlueprintSessionResult value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FBlueprintSessionResult_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FBlueprintSessionResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/OnlineSubsystemUtils.BlueprintSessionResult");
		}
	}

	public FBlueprintSessionResult(IntPtr nativeStruct)
	{
		if (!FBlueprintSessionResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/OnlineSubsystemUtils.BlueprintSessionResult");
		}
	}

	static FBlueprintSessionResult()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FBlueprintSessionResult)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBlueprintSessionResult));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/OnlineSubsystemUtils.BlueprintSessionResult");
		FBlueprintSessionResult_StructSize = NativeReflection.GetStructSize(intPtr);
		FBlueprintSessionResult_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/OnlineSubsystemUtils.BlueprintSessionResult", FBlueprintSessionResult_IsValid);
	}
}
