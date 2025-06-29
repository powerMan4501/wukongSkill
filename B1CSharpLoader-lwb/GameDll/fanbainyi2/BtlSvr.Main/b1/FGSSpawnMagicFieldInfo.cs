using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.FGSSpawnMagicFieldInfo")]
public struct FGSSpawnMagicFieldInfo
{
	public int MagicFieldID;

	public FVector LocOffset;

	public FVector DirOffset;

	private static int FGSSpawnMagicFieldInfo_StructSize;

	private static int FGSSpawnMagicFieldInfo_IsValid;

	public FGSSpawnMagicFieldInfo Copy()
	{
		return this;
	}

	public static FGSSpawnMagicFieldInfo FromNative(IntPtr nativeBuffer)
	{
		return new FGSSpawnMagicFieldInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSSpawnMagicFieldInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSSpawnMagicFieldInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSSpawnMagicFieldInfo(IntPtr.Add(nativeBuffer, arrayIndex * FGSSpawnMagicFieldInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSSpawnMagicFieldInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FGSSpawnMagicFieldInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FGSSpawnMagicFieldInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSSpawnMagicFieldInfo");
		}
	}

	public FGSSpawnMagicFieldInfo(IntPtr nativeStruct)
	{
		if (FGSSpawnMagicFieldInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSSpawnMagicFieldInfo");
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FGSSpawnMagicFieldInfo");
		FGSSpawnMagicFieldInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		FGSSpawnMagicFieldInfo_IsValid = ((intPtr != IntPtr.Zero) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FGSSpawnMagicFieldInfo", (byte)FGSSpawnMagicFieldInfo_IsValid != 0);
	}

	static FGSSpawnMagicFieldInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSSpawnMagicFieldInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSSpawnMagicFieldInfo));
	}
}
