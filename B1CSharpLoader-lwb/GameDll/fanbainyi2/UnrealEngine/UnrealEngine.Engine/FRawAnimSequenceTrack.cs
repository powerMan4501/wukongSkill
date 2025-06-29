using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.RawAnimSequenceTrack", "Engine", UnrealModuleType.Engine)]
public struct FRawAnimSequenceTrack
{
	private static bool FRawAnimSequenceTrack_IsValid;

	private static int FRawAnimSequenceTrack_StructSize;

	public FRawAnimSequenceTrack Copy()
	{
		return this;
	}

	public static FRawAnimSequenceTrack FromNative(IntPtr nativeBuffer)
	{
		return new FRawAnimSequenceTrack(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRawAnimSequenceTrack value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRawAnimSequenceTrack FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRawAnimSequenceTrack(nativeBuffer + arrayIndex * FRawAnimSequenceTrack_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRawAnimSequenceTrack value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRawAnimSequenceTrack_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRawAnimSequenceTrack_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.RawAnimSequenceTrack");
		}
	}

	public FRawAnimSequenceTrack(IntPtr nativeStruct)
	{
		if (!FRawAnimSequenceTrack_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.RawAnimSequenceTrack");
		}
	}

	static FRawAnimSequenceTrack()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRawAnimSequenceTrack)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRawAnimSequenceTrack));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.RawAnimSequenceTrack");
		FRawAnimSequenceTrack_StructSize = NativeReflection.GetStructSize(intPtr);
		FRawAnimSequenceTrack_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.RawAnimSequenceTrack", FRawAnimSequenceTrack_IsValid);
	}
}
