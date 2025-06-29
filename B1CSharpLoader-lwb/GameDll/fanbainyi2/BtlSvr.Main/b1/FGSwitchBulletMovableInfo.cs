using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.FGSwitchBulletMovableInfo")]
public struct FGSwitchBulletMovableInfo
{
	public int BulletSwitchID;

	public FVector TargetPos;

	public AActor TargetActor;

	public FName NestName;

	public FGSTargetOffsetInfo TargetOffsetInfo;

	private static int FGSwitchBulletMovableInfo_StructSize;

	private static int FGSwitchBulletMovableInfo_IsValid;

	public FGSwitchBulletMovableInfo Copy()
	{
		return this;
	}

	public static FGSwitchBulletMovableInfo FromNative(IntPtr nativeBuffer)
	{
		return new FGSwitchBulletMovableInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSwitchBulletMovableInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSwitchBulletMovableInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSwitchBulletMovableInfo(IntPtr.Add(nativeBuffer, arrayIndex * FGSwitchBulletMovableInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSwitchBulletMovableInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FGSwitchBulletMovableInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FGSwitchBulletMovableInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSwitchBulletMovableInfo");
		}
	}

	public FGSwitchBulletMovableInfo(IntPtr nativeStruct)
	{
		if (FGSwitchBulletMovableInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSwitchBulletMovableInfo");
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FGSwitchBulletMovableInfo");
		FGSwitchBulletMovableInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		FGSwitchBulletMovableInfo_IsValid = ((intPtr != IntPtr.Zero) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FGSwitchBulletMovableInfo", (byte)FGSwitchBulletMovableInfo_IsValid != 0);
	}

	static FGSwitchBulletMovableInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSwitchBulletMovableInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSwitchBulletMovableInfo));
	}
}
