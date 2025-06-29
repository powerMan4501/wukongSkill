using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DatasmithContent;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/DatasmithContent.DatasmithAssetImportOptions", "DatasmithContent", UnrealModuleType.EnginePlugin)]
public struct FDatasmithAssetImportOptions
{
	private static bool FDatasmithAssetImportOptions_IsValid;

	private static int FDatasmithAssetImportOptions_StructSize;

	public FDatasmithAssetImportOptions Copy()
	{
		return this;
	}

	public static FDatasmithAssetImportOptions FromNative(IntPtr nativeBuffer)
	{
		return new FDatasmithAssetImportOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDatasmithAssetImportOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDatasmithAssetImportOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDatasmithAssetImportOptions(nativeBuffer + arrayIndex * FDatasmithAssetImportOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDatasmithAssetImportOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FDatasmithAssetImportOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FDatasmithAssetImportOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DatasmithContent.DatasmithAssetImportOptions");
		}
	}

	public FDatasmithAssetImportOptions(IntPtr nativeStruct)
	{
		if (!FDatasmithAssetImportOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DatasmithContent.DatasmithAssetImportOptions");
		}
	}

	static FDatasmithAssetImportOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FDatasmithAssetImportOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDatasmithAssetImportOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/DatasmithContent.DatasmithAssetImportOptions");
		FDatasmithAssetImportOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		FDatasmithAssetImportOptions_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/DatasmithContent.DatasmithAssetImportOptions", FDatasmithAssetImportOptions_IsValid);
	}
}
