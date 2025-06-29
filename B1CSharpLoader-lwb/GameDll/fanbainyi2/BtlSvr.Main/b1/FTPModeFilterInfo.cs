using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.FTPModeFilterInfo")]
public struct FTPModeFilterInfo
{
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("显示名称")]
	[USharpPath("/Script/b1-Managed.FTPModeFilterInfo:DisplayName")]
	public FText DisplayName;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("LUT贴图")]
	[USharpPath("/Script/b1-Managed.FTPModeFilterInfo:LUTTexture")]
	public UTexture LUTTexture;

	private static int FTPModeFilterInfo_StructSize;

	private static int FTPModeFilterInfo_IsValid;

	private static bool DisplayName_IsValid;

	private static int DisplayName_Offset;

	private static bool LUTTexture_IsValid;

	private static int LUTTexture_Offset;

	public FTPModeFilterInfo Copy()
	{
		return this;
	}

	public static FTPModeFilterInfo FromNative(IntPtr nativeBuffer)
	{
		return new FTPModeFilterInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTPModeFilterInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTPModeFilterInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTPModeFilterInfo(IntPtr.Add(nativeBuffer, arrayIndex * FTPModeFilterInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTPModeFilterInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FTPModeFilterInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FTPModeFilterInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FTPModeFilterInfo");
			return;
		}
		FTextMarshaler.ToNative(IntPtr.Add(nativeStruct, DisplayName_Offset), DisplayName);
		UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(nativeStruct, LUTTexture_Offset), LUTTexture);
	}

	public FTPModeFilterInfo(IntPtr nativeStruct)
	{
		if (FTPModeFilterInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FTPModeFilterInfo");
			DisplayName = null;
			LUTTexture = null;
		}
		else
		{
			DisplayName = FTextMarshaler.FromNative(IntPtr.Add(nativeStruct, DisplayName_Offset));
			LUTTexture = UObjectMarshaler<UTexture>.FromNative(IntPtr.Add(nativeStruct, LUTTexture_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FTPModeFilterInfo");
		FTPModeFilterInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		DisplayName_Offset = NativeReflection.GetPropertyOffset(intPtr, "DisplayName");
		DisplayName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DisplayName", Classes.FTextProperty);
		LUTTexture_Offset = NativeReflection.GetPropertyOffset(intPtr, "LUTTexture");
		LUTTexture_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LUTTexture", Classes.FObjectProperty);
		FTPModeFilterInfo_IsValid = ((intPtr != IntPtr.Zero && DisplayName_IsValid && LUTTexture_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FTPModeFilterInfo", (byte)FTPModeFilterInfo_IsValid != 0);
	}

	static FTPModeFilterInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FTPModeFilterInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTPModeFilterInfo));
	}
}
