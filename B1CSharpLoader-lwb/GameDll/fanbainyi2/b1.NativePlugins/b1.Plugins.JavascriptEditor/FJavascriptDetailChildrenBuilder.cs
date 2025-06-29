using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/JavascriptEditor.JavascriptDetailChildrenBuilder", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptDetailChildrenBuilder
{
	private static bool FJavascriptDetailChildrenBuilder_IsValid;

	private static int FJavascriptDetailChildrenBuilder_StructSize;

	public FJavascriptDetailChildrenBuilder Copy()
	{
		return this;
	}

	public static FJavascriptDetailChildrenBuilder FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptDetailChildrenBuilder(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptDetailChildrenBuilder value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptDetailChildrenBuilder FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptDetailChildrenBuilder(nativeBuffer + arrayIndex * FJavascriptDetailChildrenBuilder_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptDetailChildrenBuilder value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptDetailChildrenBuilder_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptDetailChildrenBuilder_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptDetailChildrenBuilder");
		}
	}

	public FJavascriptDetailChildrenBuilder(IntPtr nativeStruct)
	{
		if (!FJavascriptDetailChildrenBuilder_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptDetailChildrenBuilder");
		}
	}

	static FJavascriptDetailChildrenBuilder()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptDetailChildrenBuilder)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptDetailChildrenBuilder));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptEditor.JavascriptDetailChildrenBuilder");
		FJavascriptDetailChildrenBuilder_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptDetailChildrenBuilder_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/JavascriptEditor.JavascriptDetailChildrenBuilder", FJavascriptDetailChildrenBuilder_IsValid);
	}
}
