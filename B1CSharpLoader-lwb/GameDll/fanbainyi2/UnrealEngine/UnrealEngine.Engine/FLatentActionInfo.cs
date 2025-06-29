using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.LatentActionInfo", "Engine", UnrealModuleType.Engine)]
public struct FLatentActionInfo
{
	private static bool FLatentActionInfo_IsValid;

	private static int FLatentActionInfo_StructSize;

	public FLatentActionInfo Copy()
	{
		return this;
	}

	public static FLatentActionInfo FromNative(IntPtr nativeBuffer)
	{
		return new FLatentActionInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLatentActionInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLatentActionInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLatentActionInfo(nativeBuffer + arrayIndex * FLatentActionInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLatentActionInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLatentActionInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLatentActionInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.LatentActionInfo");
		}
	}

	public FLatentActionInfo(IntPtr nativeStruct)
	{
		if (!FLatentActionInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.LatentActionInfo");
		}
	}

	static FLatentActionInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLatentActionInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLatentActionInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.LatentActionInfo");
		FLatentActionInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		FLatentActionInfo_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.LatentActionInfo", FLatentActionInfo_IsValid);
	}
}
