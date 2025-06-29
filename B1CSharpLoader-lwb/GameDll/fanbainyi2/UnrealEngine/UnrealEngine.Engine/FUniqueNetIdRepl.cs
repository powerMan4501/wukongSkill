using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4398083)]
[BlueprintType]
[UMetaPath("/Script/Engine.UniqueNetIdRepl", "Engine", UnrealModuleType.Engine)]
public struct FUniqueNetIdRepl
{
	private static bool FUniqueNetIdRepl_IsValid;

	private static int FUniqueNetIdRepl_StructSize;

	public FUniqueNetIdRepl Copy()
	{
		return this;
	}

	public static FUniqueNetIdRepl FromNative(IntPtr nativeBuffer)
	{
		return new FUniqueNetIdRepl(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FUniqueNetIdRepl value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FUniqueNetIdRepl FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FUniqueNetIdRepl(nativeBuffer + arrayIndex * FUniqueNetIdRepl_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FUniqueNetIdRepl value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FUniqueNetIdRepl_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FUniqueNetIdRepl_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.UniqueNetIdRepl");
		}
	}

	public FUniqueNetIdRepl(IntPtr nativeStruct)
	{
		if (!FUniqueNetIdRepl_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.UniqueNetIdRepl");
		}
	}

	static FUniqueNetIdRepl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FUniqueNetIdRepl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FUniqueNetIdRepl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.UniqueNetIdRepl");
		FUniqueNetIdRepl_StructSize = NativeReflection.GetStructSize(intPtr);
		FUniqueNetIdRepl_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.UniqueNetIdRepl", FUniqueNetIdRepl_IsValid);
	}
}
