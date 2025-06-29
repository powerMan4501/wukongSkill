using System;
using System.Runtime.InteropServices;

namespace UnrealEngine.Runtime;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4779067)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.Vector3f", "CoreUObject", UnrealModuleType.Engine)]
public struct FVector3f
{
	private static bool FVector3f_IsValid;

	private static int FVector3f_StructSize;

	public FVector3f Copy()
	{
		return this;
	}

	public static FVector3f FromNative(IntPtr nativeBuffer)
	{
		return new FVector3f(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FVector3f value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FVector3f FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FVector3f(nativeBuffer + arrayIndex * FVector3f_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FVector3f value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FVector3f_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FVector3f_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.Vector3f");
		}
	}

	public FVector3f(IntPtr nativeStruct)
	{
		if (!FVector3f_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.Vector3f");
		}
	}

	static FVector3f()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FVector3f)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FVector3f));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CoreUObject.Vector3f");
		FVector3f_StructSize = NativeReflection.GetStructSize(intPtr);
		FVector3f_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/CoreUObject.Vector3f", FVector3f_IsValid);
	}
}
