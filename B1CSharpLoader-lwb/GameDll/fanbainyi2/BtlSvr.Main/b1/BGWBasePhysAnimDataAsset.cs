using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWBasePhysAnimDataAsset")]
public class BGWBasePhysAnimDataAsset : UBGWDataAsset
{
	private static bool ConstraintProfile_IsValid;

	private static int ConstraintProfile_Offset;

	private static bool PhysAnimProfile_IsValid;

	private static int PhysAnimProfile_Offset;

	private static bool KinematicBones_IsValid;

	private static int KinematicBones_Offset;

	private static FFieldAddress KinematicBones_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> KinematicBones_Marshaler;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWBasePhysAnimDataAsset:ConstraintProfile")]
	public FName ConstraintProfile
	{
		get
		{
			CheckDestroyed();
			if (!ConstraintProfile_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWBasePhysAnimDataAsset:ConstraintProfile");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, ConstraintProfile_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ConstraintProfile_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWBasePhysAnimDataAsset:ConstraintProfile");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, ConstraintProfile_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWBasePhysAnimDataAsset:PhysAnimProfile")]
	public FName PhysAnimProfile
	{
		get
		{
			CheckDestroyed();
			if (!PhysAnimProfile_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWBasePhysAnimDataAsset:PhysAnimProfile");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, PhysAnimProfile_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PhysAnimProfile_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWBasePhysAnimDataAsset:PhysAnimProfile");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, PhysAnimProfile_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWBasePhysAnimDataAsset:KinematicBones")]
	public TArrayReadWrite<FName> KinematicBones
	{
		get
		{
			CheckDestroyed();
			if (!KinematicBones_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWBasePhysAnimDataAsset:KinematicBones");
				return null;
			}
			if (KinematicBones_Marshaler == null)
			{
				KinematicBones_Marshaler = new TArrayReadWriteMarshaler<FName>(1, KinematicBones_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return KinematicBones_Marshaler.FromNative(IntPtr.Add(base.Address, KinematicBones_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWBasePhysAnimDataAsset");
		ConstraintProfile_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ConstraintProfile");
		ConstraintProfile_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ConstraintProfile", Classes.FNameProperty);
		PhysAnimProfile_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PhysAnimProfile");
		PhysAnimProfile_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PhysAnimProfile", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref KinematicBones_PropertyAddress, unrealStruct, "KinematicBones");
		KinematicBones_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "KinematicBones");
		KinematicBones_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "KinematicBones", Classes.FArrayProperty);
	}

	static BGWBasePhysAnimDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWBasePhysAnimDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWBasePhysAnimDataAsset));
	}
}
