using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.DelaySpawnInfo")]
public struct DelaySpawnInfo
{
	public FVector SpawnLoc;

	public FRotator SpawnRot;

	public UClass SpawnClass;

	public float Timer;

	public int WaveIndex;

	public bool HasPlayedSpawnEffect;

	private static int DelaySpawnInfo_StructSize;

	private static int DelaySpawnInfo_IsValid;

	public DelaySpawnInfo Copy()
	{
		return this;
	}

	public static DelaySpawnInfo FromNative(IntPtr nativeBuffer)
	{
		return new DelaySpawnInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, DelaySpawnInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static DelaySpawnInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new DelaySpawnInfo(IntPtr.Add(nativeBuffer, arrayIndex * DelaySpawnInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, DelaySpawnInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * DelaySpawnInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (DelaySpawnInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DelaySpawnInfo");
		}
	}

	public DelaySpawnInfo(IntPtr nativeStruct)
	{
		if (DelaySpawnInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DelaySpawnInfo");
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.DelaySpawnInfo");
		DelaySpawnInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		DelaySpawnInfo_IsValid = ((intPtr != IntPtr.Zero) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.DelaySpawnInfo", (byte)DelaySpawnInfo_IsValid != 0);
	}

	static DelaySpawnInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(DelaySpawnInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(DelaySpawnInfo));
	}
}
