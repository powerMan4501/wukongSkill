using System;
using BtlShare;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.UnitDeadPhysicsConfig")]
public struct UnitDeadPhysicsConfig
{
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.UnitDeadPhysicsConfig:DistanceToWall")]
	public int DistanceToWall;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.UnitDeadPhysicsConfig:StiffLevel")]
	public int StiffLevel;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.UnitDeadPhysicsConfig:HitActionDir")]
	public EHitActionDir HitActionDir;

	private static int UnitDeadPhysicsConfig_StructSize;

	private static int UnitDeadPhysicsConfig_IsValid;

	private static bool DistanceToWall_IsValid;

	private static int DistanceToWall_Offset;

	private static bool StiffLevel_IsValid;

	private static int StiffLevel_Offset;

	private static bool HitActionDir_IsValid;

	private static int HitActionDir_Offset;

	private static FFieldAddress HitActionDir_PropertyAddress;

	public UnitDeadPhysicsConfig Copy()
	{
		return this;
	}

	public static UnitDeadPhysicsConfig FromNative(IntPtr nativeBuffer)
	{
		return new UnitDeadPhysicsConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, UnitDeadPhysicsConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static UnitDeadPhysicsConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new UnitDeadPhysicsConfig(IntPtr.Add(nativeBuffer, arrayIndex * UnitDeadPhysicsConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, UnitDeadPhysicsConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * UnitDeadPhysicsConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (UnitDeadPhysicsConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.UnitDeadPhysicsConfig");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, DistanceToWall_Offset), DistanceToWall);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, StiffLevel_Offset), StiffLevel);
		EnumMarshaler<EHitActionDir>.ToNative(IntPtr.Add(nativeStruct, HitActionDir_Offset), 0, HitActionDir_PropertyAddress.Address, HitActionDir);
	}

	public UnitDeadPhysicsConfig(IntPtr nativeStruct)
	{
		if (UnitDeadPhysicsConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.UnitDeadPhysicsConfig");
			DistanceToWall = 0;
			StiffLevel = 0;
			HitActionDir = EHitActionDir.Default;
		}
		else
		{
			DistanceToWall = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, DistanceToWall_Offset));
			StiffLevel = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, StiffLevel_Offset));
			HitActionDir = EnumMarshaler<EHitActionDir>.FromNative(IntPtr.Add(nativeStruct, HitActionDir_Offset), 0, HitActionDir_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.UnitDeadPhysicsConfig");
		UnitDeadPhysicsConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		DistanceToWall_Offset = NativeReflection.GetPropertyOffset(intPtr, "DistanceToWall");
		DistanceToWall_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DistanceToWall", Classes.FIntProperty);
		StiffLevel_Offset = NativeReflection.GetPropertyOffset(intPtr, "StiffLevel");
		StiffLevel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StiffLevel", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref HitActionDir_PropertyAddress, intPtr, "HitActionDir");
		HitActionDir_Offset = NativeReflection.GetPropertyOffset(intPtr, "HitActionDir");
		HitActionDir_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HitActionDir", Classes.FEnumProperty);
		UnitDeadPhysicsConfig_IsValid = ((intPtr != IntPtr.Zero && DistanceToWall_IsValid && StiffLevel_IsValid && HitActionDir_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.UnitDeadPhysicsConfig", (byte)UnitDeadPhysicsConfig_IsValid != 0);
	}

	static UnitDeadPhysicsConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UnitDeadPhysicsConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UnitDeadPhysicsConfig));
	}
}
