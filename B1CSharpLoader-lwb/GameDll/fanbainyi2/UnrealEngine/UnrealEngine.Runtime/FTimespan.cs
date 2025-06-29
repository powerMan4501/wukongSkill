using System;
using System.Runtime.InteropServices;

namespace UnrealEngine.Runtime;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4430907)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.Timespan", "CoreUObject", UnrealModuleType.Engine)]
public struct FTimespan
{
	private static bool FTimespan_IsValid;

	private static int FTimespan_StructSize;

	public FTimespan Copy()
	{
		return this;
	}

	public static FTimespan FromNative(IntPtr nativeBuffer)
	{
		return new FTimespan(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTimespan value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTimespan FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTimespan(nativeBuffer + arrayIndex * FTimespan_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTimespan value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTimespan_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTimespan_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.Timespan");
		}
	}

	public FTimespan(IntPtr nativeStruct)
	{
		if (!FTimespan_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.Timespan");
		}
	}

	static FTimespan()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTimespan)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTimespan));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CoreUObject.Timespan");
		FTimespan_StructSize = NativeReflection.GetStructSize(intPtr);
		FTimespan_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/CoreUObject.Timespan", FTimespan_IsValid);
	}
}
