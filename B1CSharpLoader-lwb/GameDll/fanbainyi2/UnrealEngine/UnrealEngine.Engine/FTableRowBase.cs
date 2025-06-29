using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.TableRowBase", "Engine", UnrealModuleType.Engine)]
public struct FTableRowBase
{
	private static bool FTableRowBase_IsValid;

	private static int FTableRowBase_StructSize;

	public FTableRowBase Copy()
	{
		return this;
	}

	public static FTableRowBase FromNative(IntPtr nativeBuffer)
	{
		return new FTableRowBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTableRowBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTableRowBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTableRowBase(nativeBuffer + arrayIndex * FTableRowBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTableRowBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTableRowBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTableRowBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.TableRowBase");
		}
	}

	public FTableRowBase(IntPtr nativeStruct)
	{
		if (!FTableRowBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.TableRowBase");
		}
	}

	static FTableRowBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTableRowBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTableRowBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.TableRowBase");
		FTableRowBase_StructSize = NativeReflection.GetStructSize(intPtr);
		FTableRowBase_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.TableRowBase", FTableRowBase_IsValid);
	}
}
