using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptGraphEditor;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/JavascriptGraphEditor.JavascriptDetermineLinkGeometryContainer", "JavascriptGraphEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptDetermineLinkGeometryContainer
{
	private static bool FJavascriptDetermineLinkGeometryContainer_IsValid;

	private static int FJavascriptDetermineLinkGeometryContainer_StructSize;

	public FJavascriptDetermineLinkGeometryContainer Copy()
	{
		return this;
	}

	public static FJavascriptDetermineLinkGeometryContainer FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptDetermineLinkGeometryContainer(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptDetermineLinkGeometryContainer value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptDetermineLinkGeometryContainer FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptDetermineLinkGeometryContainer(nativeBuffer + arrayIndex * FJavascriptDetermineLinkGeometryContainer_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptDetermineLinkGeometryContainer value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptDetermineLinkGeometryContainer_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptDetermineLinkGeometryContainer_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptGraphEditor.JavascriptDetermineLinkGeometryContainer");
		}
	}

	public FJavascriptDetermineLinkGeometryContainer(IntPtr nativeStruct)
	{
		if (!FJavascriptDetermineLinkGeometryContainer_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptGraphEditor.JavascriptDetermineLinkGeometryContainer");
		}
	}

	static FJavascriptDetermineLinkGeometryContainer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptDetermineLinkGeometryContainer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptDetermineLinkGeometryContainer));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptGraphEditor.JavascriptDetermineLinkGeometryContainer");
		FJavascriptDetermineLinkGeometryContainer_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptDetermineLinkGeometryContainer_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/JavascriptGraphEditor.JavascriptDetermineLinkGeometryContainer", FJavascriptDetermineLinkGeometryContainer_IsValid);
	}
}
