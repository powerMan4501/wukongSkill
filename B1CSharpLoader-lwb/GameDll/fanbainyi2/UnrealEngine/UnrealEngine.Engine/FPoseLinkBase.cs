using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.PoseLinkBase", "Engine", UnrealModuleType.Engine)]
public struct FPoseLinkBase
{
	private static bool FPoseLinkBase_IsValid;

	private static int FPoseLinkBase_StructSize;

	public FPoseLinkBase Copy()
	{
		return this;
	}

	public static FPoseLinkBase FromNative(IntPtr nativeBuffer)
	{
		return new FPoseLinkBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPoseLinkBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPoseLinkBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPoseLinkBase(nativeBuffer + arrayIndex * FPoseLinkBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPoseLinkBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPoseLinkBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPoseLinkBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.PoseLinkBase");
		}
	}

	public FPoseLinkBase(IntPtr nativeStruct)
	{
		if (!FPoseLinkBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.PoseLinkBase");
		}
	}

	static FPoseLinkBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPoseLinkBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPoseLinkBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.PoseLinkBase");
		FPoseLinkBase_StructSize = NativeReflection.GetStructSize(intPtr);
		FPoseLinkBase_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.PoseLinkBase", FPoseLinkBase_IsValid);
	}
}
