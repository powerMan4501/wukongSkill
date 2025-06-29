using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneTools;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/MovieSceneTools.ControlFindReplaceString", "MovieSceneTools", UnrealModuleType.Engine)]
public struct FControlFindReplaceString
{
	private static bool FControlFindReplaceString_IsValid;

	private static int FControlFindReplaceString_StructSize;

	public FControlFindReplaceString Copy()
	{
		return this;
	}

	public static FControlFindReplaceString FromNative(IntPtr nativeBuffer)
	{
		return new FControlFindReplaceString(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FControlFindReplaceString value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FControlFindReplaceString FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FControlFindReplaceString(nativeBuffer + arrayIndex * FControlFindReplaceString_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FControlFindReplaceString value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FControlFindReplaceString_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FControlFindReplaceString_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieSceneTools.ControlFindReplaceString");
		}
	}

	public FControlFindReplaceString(IntPtr nativeStruct)
	{
		if (!FControlFindReplaceString_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieSceneTools.ControlFindReplaceString");
		}
	}

	static FControlFindReplaceString()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FControlFindReplaceString)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FControlFindReplaceString));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MovieSceneTools.ControlFindReplaceString");
		FControlFindReplaceString_StructSize = NativeReflection.GetStructSize(intPtr);
		FControlFindReplaceString_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/MovieSceneTools.ControlFindReplaceString", FControlFindReplaceString_IsValid);
	}
}
