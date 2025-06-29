using System;
using UnrealEngine.Engine;
using UnrealEngine.PhysicsCore;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/b1.HitResultSimple", "b1", UnrealModuleType.Game)]
public class FHitResultSimple : StructAsClass
{
	private static bool SurfaceType_IsValid;

	private static FFieldAddress SurfaceType_PropertyAddress;

	private static int SurfaceType_Offset;

	private static bool HitLocation_IsValid;

	private static int HitLocation_Offset;

	private static bool HitImpactNormal_IsValid;

	private static int HitImpactNormal_Offset;

	private static bool HitActor_IsValid;

	private static int HitActor_Offset;

	private static bool IsBlockingHit_IsValid;

	private static FFieldAddress IsBlockingHit_PropertyAddress;

	private static int IsBlockingHit_Offset;

	private static bool FHitResultSimple_IsValid;

	private static IntPtr FHitResultSimple_StructAddress;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.HitResultSimple:SurfaceType")]
	public EPhysicalSurface SurfaceType
	{
		get
		{
			CheckDestroyed();
			if (!SurfaceType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.HitResultSimple:SurfaceType");
				return EPhysicalSurface.SurfaceType_Default;
			}
			return EnumMarshaler<EPhysicalSurface>.FromNative(IntPtr.Add(base.Address, SurfaceType_Offset), 0, SurfaceType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SurfaceType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.HitResultSimple:SurfaceType");
			}
			else
			{
				EnumMarshaler<EPhysicalSurface>.ToNative(IntPtr.Add(base.Address, SurfaceType_Offset), 0, SurfaceType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.HitResultSimple:HitLocation")]
	public FVector HitLocation
	{
		get
		{
			CheckDestroyed();
			if (!HitLocation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.HitResultSimple:HitLocation");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, HitLocation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HitLocation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.HitResultSimple:HitLocation");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, HitLocation_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.HitResultSimple:HitImpactNormal")]
	public FVector HitImpactNormal
	{
		get
		{
			CheckDestroyed();
			if (!HitImpactNormal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.HitResultSimple:HitImpactNormal");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, HitImpactNormal_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HitImpactNormal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.HitResultSimple:HitImpactNormal");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, HitImpactNormal_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.HitResultSimple:HitActor")]
	public AActor HitActor
	{
		get
		{
			CheckDestroyed();
			if (!HitActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.HitResultSimple:HitActor");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, HitActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HitActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.HitResultSimple:HitActor");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, HitActor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.HitResultSimple:bIsBlockingHit")]
	public bool IsBlockingHit
	{
		get
		{
			CheckDestroyed();
			if (!IsBlockingHit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.HitResultSimple:bIsBlockingHit");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsBlockingHit_Offset), 0, IsBlockingHit_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsBlockingHit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.HitResultSimple:bIsBlockingHit");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsBlockingHit_Offset), 0, IsBlockingHit_PropertyAddress.Address, value);
			}
		}
	}

	protected override IntPtr GetStructAddress()
	{
		return FHitResultSimple_StructAddress;
	}

	static FHitResultSimple()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FHitResultSimple)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHitResultSimple));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = (FHitResultSimple_StructAddress = NativeReflection.GetStruct("/Script/b1.HitResultSimple"));
		NativeReflectionCached.GetPropertyRef(ref SurfaceType_PropertyAddress, intPtr, "SurfaceType");
		SurfaceType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SurfaceType");
		SurfaceType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SurfaceType", Classes.FByteProperty);
		HitLocation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HitLocation");
		HitLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HitLocation", Classes.FStructProperty);
		HitImpactNormal_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HitImpactNormal");
		HitImpactNormal_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HitImpactNormal", Classes.FStructProperty);
		HitActor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HitActor");
		HitActor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HitActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsBlockingHit_PropertyAddress, intPtr, "bIsBlockingHit");
		IsBlockingHit_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsBlockingHit");
		IsBlockingHit_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsBlockingHit", Classes.FBoolProperty);
		FHitResultSimple_IsValid = intPtr != IntPtr.Zero && SurfaceType_IsValid && HitLocation_IsValid && HitImpactNormal_IsValid && HitActor_IsValid && IsBlockingHit_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.HitResultSimple", FHitResultSimple_IsValid);
	}
}
