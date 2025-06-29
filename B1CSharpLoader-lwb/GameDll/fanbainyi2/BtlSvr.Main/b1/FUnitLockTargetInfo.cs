using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.UnitLockTargetInfo")]
public struct FUnitLockTargetInfo
{
	[UProperty]
	[USharpPath("/Script/b1-Managed.UnitLockTargetInfo:LockTargetEntity")]
	public uint LockTargetEntity;

	[UProperty]
	[USharpPath("/Script/b1-Managed.UnitLockTargetInfo:LockTargetWayType")]
	public ELockTargetWayType LockTargetWayType;

	[UProperty]
	[USharpPath("/Script/b1-Managed.UnitLockTargetInfo:LockTargetType")]
	public ELockTargetType LockTargetType;

	[UProperty]
	[USharpPath("/Script/b1-Managed.UnitLockTargetInfo:LockTargetSceneCompName")]
	public string LockTargetSceneCompName;

	[UProperty]
	[USharpPath("/Script/b1-Managed.UnitLockTargetInfo:LockTargetSkeletonSocketName")]
	public string LockTargetSkeletonSocketName;

	[UProperty]
	[USharpPath("/Script/b1-Managed.UnitLockTargetInfo:LockPointLocation")]
	public FVector LockPointLocation;

	[UProperty]
	[USharpPath("/Script/b1-Managed.UnitLockTargetInfo:SourceType")]
	public ETargetSourceType SourceType;

	private static int UnitLockTargetInfo_StructSize;

	private static int UnitLockTargetInfo_IsValid;

	private static bool LockTargetEntity_IsValid;

	private static int LockTargetEntity_Offset;

	private static bool LockTargetWayType_IsValid;

	private static int LockTargetWayType_Offset;

	private static FFieldAddress LockTargetWayType_PropertyAddress;

	private static bool LockTargetType_IsValid;

	private static int LockTargetType_Offset;

	private static FFieldAddress LockTargetType_PropertyAddress;

	private static bool LockTargetSceneCompName_IsValid;

	private static int LockTargetSceneCompName_Offset;

	private static bool LockTargetSkeletonSocketName_IsValid;

	private static int LockTargetSkeletonSocketName_Offset;

	private static bool LockPointLocation_IsValid;

	private static int LockPointLocation_Offset;

	private static bool SourceType_IsValid;

	private static int SourceType_Offset;

	private static FFieldAddress SourceType_PropertyAddress;

	public FUnitLockTargetInfo Copy()
	{
		return this;
	}

	public static FUnitLockTargetInfo FromNative(IntPtr nativeBuffer)
	{
		return new FUnitLockTargetInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FUnitLockTargetInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FUnitLockTargetInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FUnitLockTargetInfo(IntPtr.Add(nativeBuffer, arrayIndex * UnitLockTargetInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FUnitLockTargetInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * UnitLockTargetInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (UnitLockTargetInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.UnitLockTargetInfo");
			return;
		}
		BlittableTypeMarshaler<uint>.ToNative(IntPtr.Add(nativeStruct, LockTargetEntity_Offset), LockTargetEntity);
		EnumMarshaler<ELockTargetWayType>.ToNative(IntPtr.Add(nativeStruct, LockTargetWayType_Offset), 0, LockTargetWayType_PropertyAddress.Address, LockTargetWayType);
		EnumMarshaler<ELockTargetType>.ToNative(IntPtr.Add(nativeStruct, LockTargetType_Offset), 0, LockTargetType_PropertyAddress.Address, LockTargetType);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, LockTargetSceneCompName_Offset), LockTargetSceneCompName);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, LockTargetSkeletonSocketName_Offset), LockTargetSkeletonSocketName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, LockPointLocation_Offset), LockPointLocation);
		EnumMarshaler<ETargetSourceType>.ToNative(IntPtr.Add(nativeStruct, SourceType_Offset), 0, SourceType_PropertyAddress.Address, SourceType);
	}

	public FUnitLockTargetInfo(IntPtr nativeStruct)
	{
		if (UnitLockTargetInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.UnitLockTargetInfo");
			LockTargetEntity = 0u;
			LockTargetWayType = ELockTargetWayType.Auto;
			LockTargetType = ELockTargetType.Actor;
			LockTargetSceneCompName = null;
			LockTargetSkeletonSocketName = null;
			LockPointLocation = default(FVector);
			SourceType = ETargetSourceType.None;
		}
		else
		{
			LockTargetEntity = BlittableTypeMarshaler<uint>.FromNative(IntPtr.Add(nativeStruct, LockTargetEntity_Offset));
			LockTargetWayType = EnumMarshaler<ELockTargetWayType>.FromNative(IntPtr.Add(nativeStruct, LockTargetWayType_Offset), 0, LockTargetWayType_PropertyAddress.Address);
			LockTargetType = EnumMarshaler<ELockTargetType>.FromNative(IntPtr.Add(nativeStruct, LockTargetType_Offset), 0, LockTargetType_PropertyAddress.Address);
			LockTargetSceneCompName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, LockTargetSceneCompName_Offset));
			LockTargetSkeletonSocketName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, LockTargetSkeletonSocketName_Offset));
			LockPointLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, LockPointLocation_Offset));
			SourceType = EnumMarshaler<ETargetSourceType>.FromNative(IntPtr.Add(nativeStruct, SourceType_Offset), 0, SourceType_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.UnitLockTargetInfo");
		UnitLockTargetInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		LockTargetEntity_Offset = NativeReflection.GetPropertyOffset(intPtr, "LockTargetEntity");
		LockTargetEntity_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LockTargetEntity", Classes.FUInt32Property);
		NativeReflection.GetPropertyRef(ref LockTargetWayType_PropertyAddress, intPtr, "LockTargetWayType");
		LockTargetWayType_Offset = NativeReflection.GetPropertyOffset(intPtr, "LockTargetWayType");
		LockTargetWayType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LockTargetWayType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref LockTargetType_PropertyAddress, intPtr, "LockTargetType");
		LockTargetType_Offset = NativeReflection.GetPropertyOffset(intPtr, "LockTargetType");
		LockTargetType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LockTargetType", Classes.FEnumProperty);
		LockTargetSceneCompName_Offset = NativeReflection.GetPropertyOffset(intPtr, "LockTargetSceneCompName");
		LockTargetSceneCompName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LockTargetSceneCompName", Classes.FStrProperty);
		LockTargetSkeletonSocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "LockTargetSkeletonSocketName");
		LockTargetSkeletonSocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LockTargetSkeletonSocketName", Classes.FStrProperty);
		LockPointLocation_Offset = NativeReflection.GetPropertyOffset(intPtr, "LockPointLocation");
		LockPointLocation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LockPointLocation", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref SourceType_PropertyAddress, intPtr, "SourceType");
		SourceType_Offset = NativeReflection.GetPropertyOffset(intPtr, "SourceType");
		SourceType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SourceType", Classes.FEnumProperty);
		UnitLockTargetInfo_IsValid = ((intPtr != IntPtr.Zero && LockTargetEntity_IsValid && LockTargetWayType_IsValid && LockTargetType_IsValid && LockTargetSceneCompName_IsValid && LockTargetSkeletonSocketName_IsValid && LockPointLocation_IsValid && SourceType_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.UnitLockTargetInfo", (byte)UnitLockTargetInfo_IsValid != 0);
	}

	static FUnitLockTargetInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FUnitLockTargetInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FUnitLockTargetInfo));
	}
}
