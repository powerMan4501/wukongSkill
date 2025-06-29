using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/UMG.RichTextStyleRow", "UMG", UnrealModuleType.Engine)]
public struct FRichTextStyleRow
{
	private static bool FRichTextStyleRow_IsValid;

	private static int FRichTextStyleRow_StructSize;

	public FRichTextStyleRow Copy()
	{
		return this;
	}

	public static FRichTextStyleRow FromNative(IntPtr nativeBuffer)
	{
		return new FRichTextStyleRow(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRichTextStyleRow value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRichTextStyleRow FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRichTextStyleRow(nativeBuffer + arrayIndex * FRichTextStyleRow_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRichTextStyleRow value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRichTextStyleRow_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRichTextStyleRow_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UMG.RichTextStyleRow");
		}
	}

	public FRichTextStyleRow(IntPtr nativeStruct)
	{
		if (!FRichTextStyleRow_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UMG.RichTextStyleRow");
		}
	}

	static FRichTextStyleRow()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRichTextStyleRow)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRichTextStyleRow));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UMG.RichTextStyleRow");
		FRichTextStyleRow_StructSize = NativeReflection.GetStructSize(intPtr);
		FRichTextStyleRow_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/UMG.RichTextStyleRow", FRichTextStyleRow_IsValid);
	}
}
