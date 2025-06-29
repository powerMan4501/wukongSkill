using System;
using System.Runtime.InteropServices;

namespace UnrealEngine.Runtime;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4779067)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.Plane4f", "CoreUObject", UnrealModuleType.Engine)]
public struct FPlane4f
{
	private static bool FPlane4f_IsValid;

	private static int FPlane4f_StructSize;

	public FPlane4f Copy()
	{
		return this;
	}

	public static FPlane4f FromNative(IntPtr nativeBuffer)
	{
		return new FPlane4f(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPlane4f value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPlane4f FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPlane4f(nativeBuffer + arrayIndex * FPlane4f_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPlane4f value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPlane4f_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPlane4f_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.Plane4f");
		}
	}

	public FPlane4f(IntPtr nativeStruct)
	{
		if (!FPlane4f_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.Plane4f");
		}
	}

	static FPlane4f()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPlane4f)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPlane4f));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CoreUObject.Plane4f");
		FPlane4f_StructSize = NativeReflection.GetStructSize(intPtr);
		FPlane4f_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/CoreUObject.Plane4f", FPlane4f_IsValid);
	}
}
