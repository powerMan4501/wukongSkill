using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/UMG.PaintContext", "UMG", UnrealModuleType.Engine)]
public struct FPaintContext
{
	private static bool FPaintContext_IsValid;

	private static int FPaintContext_StructSize;

	public FPaintContext Copy()
	{
		return this;
	}

	public static FPaintContext FromNative(IntPtr nativeBuffer)
	{
		return new FPaintContext(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPaintContext value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPaintContext FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPaintContext(nativeBuffer + arrayIndex * FPaintContext_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPaintContext value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPaintContext_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPaintContext_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UMG.PaintContext");
		}
	}

	public FPaintContext(IntPtr nativeStruct)
	{
		if (!FPaintContext_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UMG.PaintContext");
		}
	}

	static FPaintContext()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPaintContext)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPaintContext));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UMG.PaintContext");
		FPaintContext_StructSize = NativeReflection.GetStructSize(intPtr);
		FPaintContext_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/UMG.PaintContext", FPaintContext_IsValid);
	}
}
