using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptUMG;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4101)]
[BlueprintType]
[UMetaPath("/Script/JavascriptUMG.JavascriptColumn", "JavascriptUMG", UnrealModuleType.GamePlugin)]
public struct FJavascriptColumn
{
	private static bool FJavascriptColumn_IsValid;

	private static int FJavascriptColumn_StructSize;

	public FJavascriptColumn Copy()
	{
		return this;
	}

	public static FJavascriptColumn FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptColumn(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptColumn value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptColumn FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptColumn(nativeBuffer + arrayIndex * FJavascriptColumn_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptColumn value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptColumn_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptColumn_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptUMG.JavascriptColumn");
		}
	}

	public FJavascriptColumn(IntPtr nativeStruct)
	{
		if (!FJavascriptColumn_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptUMG.JavascriptColumn");
		}
	}

	static FJavascriptColumn()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptColumn)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptColumn));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptUMG.JavascriptColumn");
		FJavascriptColumn_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptColumn_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/JavascriptUMG.JavascriptColumn", FJavascriptColumn_IsValid);
	}
}
