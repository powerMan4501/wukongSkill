using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/UMG.RichImageRow", "UMG", UnrealModuleType.Engine)]
public struct FRichImageRow
{
	private static bool FRichImageRow_IsValid;

	private static int FRichImageRow_StructSize;

	public FRichImageRow Copy()
	{
		return this;
	}

	public static FRichImageRow FromNative(IntPtr nativeBuffer)
	{
		return new FRichImageRow(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRichImageRow value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRichImageRow FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRichImageRow(nativeBuffer + arrayIndex * FRichImageRow_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRichImageRow value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRichImageRow_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRichImageRow_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UMG.RichImageRow");
		}
	}

	public FRichImageRow(IntPtr nativeStruct)
	{
		if (!FRichImageRow_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UMG.RichImageRow");
		}
	}

	static FRichImageRow()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRichImageRow)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRichImageRow));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UMG.RichImageRow");
		FRichImageRow_StructSize = NativeReflection.GetStructSize(intPtr);
		FRichImageRow_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/UMG.RichImageRow", FRichImageRow_IsValid);
	}
}
