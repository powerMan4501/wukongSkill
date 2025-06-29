using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.ToolMenus;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ToolMenus.ToolMenuContext", "ToolMenus", UnrealModuleType.Engine)]
public struct FToolMenuContext
{
	private static bool FToolMenuContext_IsValid;

	private static int FToolMenuContext_StructSize;

	public FToolMenuContext Copy()
	{
		return this;
	}

	public static FToolMenuContext FromNative(IntPtr nativeBuffer)
	{
		return new FToolMenuContext(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FToolMenuContext value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FToolMenuContext FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FToolMenuContext(nativeBuffer + arrayIndex * FToolMenuContext_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FToolMenuContext value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FToolMenuContext_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FToolMenuContext_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ToolMenus.ToolMenuContext");
		}
	}

	public FToolMenuContext(IntPtr nativeStruct)
	{
		if (!FToolMenuContext_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ToolMenus.ToolMenuContext");
		}
	}

	static FToolMenuContext()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FToolMenuContext)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FToolMenuContext));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ToolMenus.ToolMenuContext");
		FToolMenuContext_StructSize = NativeReflection.GetStructSize(intPtr);
		FToolMenuContext_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ToolMenus.ToolMenuContext", FToolMenuContext_IsValid);
	}
}
