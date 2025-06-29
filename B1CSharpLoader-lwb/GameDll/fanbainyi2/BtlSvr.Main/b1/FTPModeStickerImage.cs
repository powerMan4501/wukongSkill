using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.FTPModeStickerImage")]
public struct FTPModeStickerImage
{
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("显示名称")]
	[USharpPath("/Script/b1-Managed.FTPModeStickerImage:DisplayName")]
	public FText DisplayName;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("贴图")]
	[USharpPath("/Script/b1-Managed.FTPModeStickerImage:ImageTex")]
	public UTexture2D ImageTex;

	private static int FTPModeStickerImage_StructSize;

	private static int FTPModeStickerImage_IsValid;

	private static bool DisplayName_IsValid;

	private static int DisplayName_Offset;

	private static bool ImageTex_IsValid;

	private static int ImageTex_Offset;

	public FTPModeStickerImage Copy()
	{
		return this;
	}

	public static FTPModeStickerImage FromNative(IntPtr nativeBuffer)
	{
		return new FTPModeStickerImage(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTPModeStickerImage value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTPModeStickerImage FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTPModeStickerImage(IntPtr.Add(nativeBuffer, arrayIndex * FTPModeStickerImage_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTPModeStickerImage value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FTPModeStickerImage_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FTPModeStickerImage_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FTPModeStickerImage");
			return;
		}
		FTextMarshaler.ToNative(IntPtr.Add(nativeStruct, DisplayName_Offset), DisplayName);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(nativeStruct, ImageTex_Offset), ImageTex);
	}

	public FTPModeStickerImage(IntPtr nativeStruct)
	{
		if (FTPModeStickerImage_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FTPModeStickerImage");
			DisplayName = null;
			ImageTex = null;
		}
		else
		{
			DisplayName = FTextMarshaler.FromNative(IntPtr.Add(nativeStruct, DisplayName_Offset));
			ImageTex = UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(nativeStruct, ImageTex_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FTPModeStickerImage");
		FTPModeStickerImage_StructSize = NativeReflection.GetStructSize(intPtr);
		DisplayName_Offset = NativeReflection.GetPropertyOffset(intPtr, "DisplayName");
		DisplayName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DisplayName", Classes.FTextProperty);
		ImageTex_Offset = NativeReflection.GetPropertyOffset(intPtr, "ImageTex");
		ImageTex_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ImageTex", Classes.FObjectProperty);
		FTPModeStickerImage_IsValid = ((intPtr != IntPtr.Zero && DisplayName_IsValid && ImageTex_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FTPModeStickerImage", (byte)FTPModeStickerImage_IsValid != 0);
	}

	static FTPModeStickerImage()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FTPModeStickerImage)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTPModeStickerImage));
	}
}
