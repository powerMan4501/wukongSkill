using System;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.GSObjActorMoveInfo")]
public struct GSObjActorMoveInfo
{
	public int ProjectileCommID;

	public EProjectileObjSpdType SpeedType;

	public FSpawnBulletSpeed ProjectileFlySpd;

	public FSpawnBulletSpeed ProjectileRotSpd;

	public float ProjectileFlySpdCurveTimer;

	public float ProjectileRotSpdCurveTimer;

	public FGSTargetOffsetInfo TargetOffsetInfo;

	public AActor TargetActor;

	public bool bUseSocket_Target;

	public string TargetActorSocketNameFromNotify;

	public float FlyTime;

	public int TotalNumInAWave;

	public int SelfIndexInAWave;

	public FVector TargetPosAtSpawn;

	public FVector StartLocation;

	public FVector TargetPos;

	public float ProjectileSurRadius;

	public EBGUBulletTraceType TraceType;

	public float TraceTime;

	public bool UseSocketAsNest;

	public FName NestName;

	public bool CloseZTrace;

	private static int GSObjActorMoveInfo_StructSize;

	private static int GSObjActorMoveInfo_IsValid;

	public GSObjActorMoveInfo Copy()
	{
		return this;
	}

	public static GSObjActorMoveInfo FromNative(IntPtr nativeBuffer)
	{
		return new GSObjActorMoveInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, GSObjActorMoveInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static GSObjActorMoveInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new GSObjActorMoveInfo(IntPtr.Add(nativeBuffer, arrayIndex * GSObjActorMoveInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, GSObjActorMoveInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * GSObjActorMoveInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (GSObjActorMoveInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.GSObjActorMoveInfo");
		}
	}

	public GSObjActorMoveInfo(IntPtr nativeStruct)
	{
		if (GSObjActorMoveInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.GSObjActorMoveInfo");
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.GSObjActorMoveInfo");
		GSObjActorMoveInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		GSObjActorMoveInfo_IsValid = ((intPtr != IntPtr.Zero) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.GSObjActorMoveInfo", (byte)GSObjActorMoveInfo_IsValid != 0);
	}

	static GSObjActorMoveInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSObjActorMoveInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSObjActorMoveInfo));
	}
}
