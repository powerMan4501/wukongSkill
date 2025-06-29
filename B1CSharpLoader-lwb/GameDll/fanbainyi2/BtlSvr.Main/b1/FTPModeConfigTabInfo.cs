using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.FTPModeConfigTabInfo")]
public struct FTPModeConfigTabInfo
{
	[BlueprintReadWrite]
	[DisplayName("贴图")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FTPModeConfigTabInfo:ImageTex")]
	public UTexture2D ImageTex;

	private static int FTPModeConfigTabInfo_StructSize;

	private static int FTPModeConfigTabInfo_IsValid;

	private static bool ImageTex_IsValid;

	private static int ImageTex_Offset;

	public FTPModeConfigTabInfo Copy()
	{
		return this;
	}

	public static FTPModeConfigTabInfo FromNative(IntPtr nativeBuffer)
	{
		return new FTPModeConfigTabInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTPModeConfigTabInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTPModeConfigTabInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTPModeConfigTabInfo(IntPtr.Add(nativeBuffer, arrayIndex * FTPModeConfigTabInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTPModeConfigTabInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FTPModeConfigTabInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FTPModeConfigTabInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FTPModeConfigTabInfo");
		}
		else
		{
			UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(nativeStruct, ImageTex_Offset), ImageTex);
		}
	}

	public FTPModeConfigTabInfo(IntPtr nativeStruct)
	{
		if (FTPModeConfigTabInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FTPModeConfigTabInfo");
			ImageTex = null;
		}
		else
		{
			ImageTex = UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(nativeStruct, ImageTex_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FTPModeConfigTabInfo");
		FTPModeConfigTabInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		ImageTex_Offset = NativeReflection.GetPropertyOffset(intPtr, "ImageTex");
		ImageTex_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ImageTex", Classes.FObjectProperty);
		FTPModeConfigTabInfo_IsValid = ((intPtr != IntPtr.Zero && ImageTex_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FTPModeConfigTabInfo", (byte)FTPModeConfigTabInfo_IsValid != 0);
	}

	static FTPModeConfigTabInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FTPModeConfigTabInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTPModeConfigTabInfo));
	}
}
