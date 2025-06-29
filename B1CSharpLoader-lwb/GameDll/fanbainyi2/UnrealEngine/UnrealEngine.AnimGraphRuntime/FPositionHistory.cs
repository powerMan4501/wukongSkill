using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.PositionHistory", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FPositionHistory
{
	private static bool FPositionHistory_IsValid;

	private static int FPositionHistory_StructSize;

	public FPositionHistory Copy()
	{
		return this;
	}

	public static FPositionHistory FromNative(IntPtr nativeBuffer)
	{
		return new FPositionHistory(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPositionHistory value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPositionHistory FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPositionHistory(nativeBuffer + arrayIndex * FPositionHistory_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPositionHistory value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPositionHistory_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPositionHistory_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.PositionHistory");
		}
	}

	public FPositionHistory(IntPtr nativeStruct)
	{
		if (!FPositionHistory_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.PositionHistory");
		}
	}

	static FPositionHistory()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPositionHistory)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPositionHistory));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.PositionHistory");
		FPositionHistory_StructSize = NativeReflection.GetStructSize(intPtr);
		FPositionHistory_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.PositionHistory", FPositionHistory_IsValid);
	}
}
