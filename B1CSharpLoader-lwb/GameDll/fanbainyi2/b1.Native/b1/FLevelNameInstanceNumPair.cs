using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/FuncLibEditor.LevelNameInstanceNumPair", "FuncLibEditor", UnrealModuleType.Game)]
public struct FLevelNameInstanceNumPair
{
	private static bool FLevelNameInstanceNumPair_IsValid;

	private static int FLevelNameInstanceNumPair_StructSize;

	public FLevelNameInstanceNumPair Copy()
	{
		return this;
	}

	public static FLevelNameInstanceNumPair FromNative(IntPtr nativeBuffer)
	{
		return new FLevelNameInstanceNumPair(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLevelNameInstanceNumPair value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLevelNameInstanceNumPair FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLevelNameInstanceNumPair(nativeBuffer + arrayIndex * FLevelNameInstanceNumPair_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLevelNameInstanceNumPair value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLevelNameInstanceNumPair_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLevelNameInstanceNumPair_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.LevelNameInstanceNumPair");
		}
	}

	public FLevelNameInstanceNumPair(IntPtr nativeStruct)
	{
		if (!FLevelNameInstanceNumPair_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.LevelNameInstanceNumPair");
		}
	}

	static FLevelNameInstanceNumPair()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLevelNameInstanceNumPair)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLevelNameInstanceNumPair));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FuncLibEditor.LevelNameInstanceNumPair");
		FLevelNameInstanceNumPair_StructSize = NativeReflection.GetStructSize(intPtr);
		FLevelNameInstanceNumPair_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/FuncLibEditor.LevelNameInstanceNumPair", FLevelNameInstanceNumPair_IsValid);
	}
}
