using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AppleImageUtils;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/AppleImageUtils.AppleImageUtilsImageConversionResult", "AppleImageUtils", UnrealModuleType.EnginePlugin)]
public struct FAppleImageUtilsImageConversionResult
{
	private static bool Error_IsValid;

	private static int Error_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/AppleImageUtils.AppleImageUtilsImageConversionResult:Error")]
	public string Error;

	private static bool ImageData_IsValid;

	private static FFieldAddress ImageData_PropertyAddress;

	private static int ImageData_Offset;

	[UProperty(Flags = (PropFlags)4503599627371028uL)]
	[UMetaPath("/Script/AppleImageUtils.AppleImageUtilsImageConversionResult:ImageData")]
	public List<byte> ImageData;

	private static bool FAppleImageUtilsImageConversionResult_IsValid;

	private static int FAppleImageUtilsImageConversionResult_StructSize;

	public FAppleImageUtilsImageConversionResult Copy()
	{
		FAppleImageUtilsImageConversionResult result = this;
		if (ImageData != null)
		{
			result.ImageData = new List<byte>(ImageData);
		}
		return result;
	}

	public static FAppleImageUtilsImageConversionResult FromNative(IntPtr nativeBuffer)
	{
		return new FAppleImageUtilsImageConversionResult(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAppleImageUtilsImageConversionResult value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAppleImageUtilsImageConversionResult FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAppleImageUtilsImageConversionResult(nativeBuffer + arrayIndex * FAppleImageUtilsImageConversionResult_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAppleImageUtilsImageConversionResult value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAppleImageUtilsImageConversionResult_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAppleImageUtilsImageConversionResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AppleImageUtils.AppleImageUtilsImageConversionResult");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Error_Offset), Error);
		new TArrayCopyMarshaler<byte>(1, ImageData_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ImageData_Offset), ImageData);
	}

	public FAppleImageUtilsImageConversionResult(IntPtr nativeStruct)
	{
		if (!FAppleImageUtilsImageConversionResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AppleImageUtils.AppleImageUtilsImageConversionResult");
			Error = FStringMarshaler.DefaultString;
			ImageData = null;
		}
		else
		{
			Error = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Error_Offset));
			ImageData = new TArrayCopyMarshaler<byte>(1, ImageData_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ImageData_Offset));
		}
	}

	static FAppleImageUtilsImageConversionResult()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAppleImageUtilsImageConversionResult)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAppleImageUtilsImageConversionResult));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AppleImageUtils.AppleImageUtilsImageConversionResult");
		FAppleImageUtilsImageConversionResult_StructSize = NativeReflection.GetStructSize(intPtr);
		Error_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Error");
		Error_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Error", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ImageData_PropertyAddress, intPtr, "ImageData");
		ImageData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ImageData");
		ImageData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ImageData", Classes.FArrayProperty);
		FAppleImageUtilsImageConversionResult_IsValid = intPtr != IntPtr.Zero && Error_IsValid && ImageData_IsValid;
		NativeReflection.LogStructIsValid("/Script/AppleImageUtils.AppleImageUtilsImageConversionResult", FAppleImageUtilsImageConversionResult_IsValid);
	}
}
