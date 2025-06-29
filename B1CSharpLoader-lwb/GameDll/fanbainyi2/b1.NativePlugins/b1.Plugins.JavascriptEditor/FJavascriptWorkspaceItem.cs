using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/JavascriptEditor.JavascriptWorkspaceItem", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptWorkspaceItem
{
	private static bool FJavascriptWorkspaceItem_IsValid;

	private static int FJavascriptWorkspaceItem_StructSize;

	public FJavascriptWorkspaceItem Copy()
	{
		return this;
	}

	public static FJavascriptWorkspaceItem FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptWorkspaceItem(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptWorkspaceItem value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptWorkspaceItem FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptWorkspaceItem(nativeBuffer + arrayIndex * FJavascriptWorkspaceItem_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptWorkspaceItem value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptWorkspaceItem_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptWorkspaceItem_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptWorkspaceItem");
		}
	}

	public FJavascriptWorkspaceItem(IntPtr nativeStruct)
	{
		if (!FJavascriptWorkspaceItem_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptWorkspaceItem");
		}
	}

	static FJavascriptWorkspaceItem()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptWorkspaceItem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptWorkspaceItem));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptEditor.JavascriptWorkspaceItem");
		FJavascriptWorkspaceItem_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptWorkspaceItem_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/JavascriptEditor.JavascriptWorkspaceItem", FJavascriptWorkspaceItem_IsValid);
	}
}
