using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptGraphEditor;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/JavascriptGraphEditor.JavascriptArrangedWidget", "JavascriptGraphEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptArrangedWidget
{
	private static bool FJavascriptArrangedWidget_IsValid;

	private static int FJavascriptArrangedWidget_StructSize;

	public FJavascriptArrangedWidget Copy()
	{
		return this;
	}

	public static FJavascriptArrangedWidget FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptArrangedWidget(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptArrangedWidget value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptArrangedWidget FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptArrangedWidget(nativeBuffer + arrayIndex * FJavascriptArrangedWidget_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptArrangedWidget value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptArrangedWidget_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptArrangedWidget_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptGraphEditor.JavascriptArrangedWidget");
		}
	}

	public FJavascriptArrangedWidget(IntPtr nativeStruct)
	{
		if (!FJavascriptArrangedWidget_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptGraphEditor.JavascriptArrangedWidget");
		}
	}

	static FJavascriptArrangedWidget()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptArrangedWidget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptArrangedWidget));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptGraphEditor.JavascriptArrangedWidget");
		FJavascriptArrangedWidget_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptArrangedWidget_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/JavascriptGraphEditor.JavascriptArrangedWidget", FJavascriptArrangedWidget_IsValid);
	}
}
