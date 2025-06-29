using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.RotationRetargetingInfo", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FRotationRetargetingInfo
{
	private static bool FRotationRetargetingInfo_IsValid;

	private static int FRotationRetargetingInfo_StructSize;

	public FRotationRetargetingInfo Copy()
	{
		return this;
	}

	public static FRotationRetargetingInfo FromNative(IntPtr nativeBuffer)
	{
		return new FRotationRetargetingInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRotationRetargetingInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRotationRetargetingInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRotationRetargetingInfo(nativeBuffer + arrayIndex * FRotationRetargetingInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRotationRetargetingInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRotationRetargetingInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRotationRetargetingInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.RotationRetargetingInfo");
		}
	}

	public FRotationRetargetingInfo(IntPtr nativeStruct)
	{
		if (!FRotationRetargetingInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.RotationRetargetingInfo");
		}
	}

	static FRotationRetargetingInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRotationRetargetingInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRotationRetargetingInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.RotationRetargetingInfo");
		FRotationRetargetingInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		FRotationRetargetingInfo_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.RotationRetargetingInfo", FRotationRetargetingInfo_IsValid);
	}
}
