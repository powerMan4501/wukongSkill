using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/JavascriptEditor.JavascriptAssetData", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptAssetData
{
	private static bool FJavascriptAssetData_IsValid;

	private static int FJavascriptAssetData_StructSize;

	public FJavascriptAssetData Copy()
	{
		return this;
	}

	public static FJavascriptAssetData FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptAssetData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptAssetData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptAssetData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptAssetData(nativeBuffer + arrayIndex * FJavascriptAssetData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptAssetData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptAssetData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptAssetData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptAssetData");
		}
	}

	public FJavascriptAssetData(IntPtr nativeStruct)
	{
		if (!FJavascriptAssetData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptAssetData");
		}
	}

	static FJavascriptAssetData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptAssetData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptAssetData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptEditor.JavascriptAssetData");
		FJavascriptAssetData_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptAssetData_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/JavascriptEditor.JavascriptAssetData", FJavascriptAssetData_IsValid);
	}
}
