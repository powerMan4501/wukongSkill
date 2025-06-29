using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.ToolMenus;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ToolMenus.ToolMenuOwner", "ToolMenus", UnrealModuleType.Engine)]
public struct FToolMenuOwner
{
	private static bool FToolMenuOwner_IsValid;

	private static int FToolMenuOwner_StructSize;

	public FToolMenuOwner Copy()
	{
		return this;
	}

	public static FToolMenuOwner FromNative(IntPtr nativeBuffer)
	{
		return new FToolMenuOwner(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FToolMenuOwner value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FToolMenuOwner FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FToolMenuOwner(nativeBuffer + arrayIndex * FToolMenuOwner_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FToolMenuOwner value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FToolMenuOwner_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FToolMenuOwner_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ToolMenus.ToolMenuOwner");
		}
	}

	public FToolMenuOwner(IntPtr nativeStruct)
	{
		if (!FToolMenuOwner_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ToolMenus.ToolMenuOwner");
		}
	}

	static FToolMenuOwner()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FToolMenuOwner)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FToolMenuOwner));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ToolMenus.ToolMenuOwner");
		FToolMenuOwner_StructSize = NativeReflection.GetStructSize(intPtr);
		FToolMenuOwner_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ToolMenus.ToolMenuOwner", FToolMenuOwner_IsValid);
	}
}
