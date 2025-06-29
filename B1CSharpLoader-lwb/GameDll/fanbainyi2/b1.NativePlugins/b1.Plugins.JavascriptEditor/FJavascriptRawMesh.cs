using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/JavascriptEditor.JavascriptRawMesh", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptRawMesh
{
	private static bool FJavascriptRawMesh_IsValid;

	private static int FJavascriptRawMesh_StructSize;

	public FJavascriptRawMesh Copy()
	{
		return this;
	}

	public static FJavascriptRawMesh FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptRawMesh(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptRawMesh value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptRawMesh FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptRawMesh(nativeBuffer + arrayIndex * FJavascriptRawMesh_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptRawMesh value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptRawMesh_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptRawMesh_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptRawMesh");
		}
	}

	public FJavascriptRawMesh(IntPtr nativeStruct)
	{
		if (!FJavascriptRawMesh_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptRawMesh");
		}
	}

	static FJavascriptRawMesh()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptRawMesh)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptRawMesh));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptEditor.JavascriptRawMesh");
		FJavascriptRawMesh_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptRawMesh_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/JavascriptEditor.JavascriptRawMesh", FJavascriptRawMesh_IsValid);
	}
}
