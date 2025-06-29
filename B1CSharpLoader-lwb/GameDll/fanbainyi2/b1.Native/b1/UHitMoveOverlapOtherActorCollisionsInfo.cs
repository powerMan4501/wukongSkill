using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[UMetaPath("/Script/b1.HitMoveOverlapOtherActorCollisionsInfo", "b1", UnrealModuleType.Game)]
public class UHitMoveOverlapOtherActorCollisionsInfo : UObject
{
	private static bool OtherActor_IsValid;

	private static int OtherActor_Offset;

	private static bool OtherActorWeight_IsValid;

	private static int OtherActorWeight_Offset;

	private static bool OtherCollisions_IsValid;

	private static FFieldAddress OtherCollisions_PropertyAddress;

	private static int OtherCollisions_Offset;

	private TArrayReadWriteMarshaler<UShapeComponent> OtherCollisions_MarshalerCached;

	private static bool OtherCollisionDirections_IsValid;

	private static FFieldAddress OtherCollisionDirections_PropertyAddress;

	private static int OtherCollisionDirections_Offset;

	private TArrayReadWriteMarshaler<int> OtherCollisionDirections_MarshalerCached;

	private static bool SelfCollisions_IsValid;

	private static FFieldAddress SelfCollisions_PropertyAddress;

	private static int SelfCollisions_Offset;

	private TArrayReadWriteMarshaler<UShapeComponent> SelfCollisions_MarshalerCached;

	private static bool SelfCollisionDirections_IsValid;

	private static FFieldAddress SelfCollisionDirections_PropertyAddress;

	private static int SelfCollisionDirections_Offset;

	private TArrayReadWriteMarshaler<int> SelfCollisionDirections_MarshalerCached;

	private static bool OtherCollisionsLastTickCounts_IsValid;

	private static FFieldAddress OtherCollisionsLastTickCounts_PropertyAddress;

	private static int OtherCollisionsLastTickCounts_Offset;

	private TArrayReadWriteMarshaler<int> OtherCollisionsLastTickCounts_MarshalerCached;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.HitMoveOverlapOtherActorCollisionsInfo:OtherActor")]
	public AActor OtherActor
	{
		get
		{
			CheckDestroyed();
			if (!OtherActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.HitMoveOverlapOtherActorCollisionsInfo:OtherActor");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, OtherActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OtherActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.HitMoveOverlapOtherActorCollisionsInfo:OtherActor");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, OtherActor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.HitMoveOverlapOtherActorCollisionsInfo:OtherActorWeight")]
	public float OtherActorWeight
	{
		get
		{
			CheckDestroyed();
			if (!OtherActorWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.HitMoveOverlapOtherActorCollisionsInfo:OtherActorWeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OtherActorWeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OtherActorWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.HitMoveOverlapOtherActorCollisionsInfo:OtherActorWeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OtherActorWeight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4504149383184908uL)]
	[UMetaPath("/Script/b1.HitMoveOverlapOtherActorCollisionsInfo:OtherCollisions")]
	public TArrayReadWrite<UShapeComponent> OtherCollisions
	{
		get
		{
			CheckDestroyed();
			if (!OtherCollisions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.HitMoveOverlapOtherActorCollisionsInfo:OtherCollisions");
				return null;
			}
			if (OtherCollisions_MarshalerCached == null)
			{
				OtherCollisions_MarshalerCached = new TArrayReadWriteMarshaler<UShapeComponent>(1, OtherCollisions_PropertyAddress, CachedMarshalingDelegates<UShapeComponent, UObjectMarshaler<UShapeComponent>>.FromNative, CachedMarshalingDelegates<UShapeComponent, UObjectMarshaler<UShapeComponent>>.ToNative);
			}
			return OtherCollisions_MarshalerCached.FromNative(IntPtr.Add(base.Address, OtherCollisions_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/b1.HitMoveOverlapOtherActorCollisionsInfo:OtherCollisionDirections")]
	public TArrayReadWrite<int> OtherCollisionDirections
	{
		get
		{
			CheckDestroyed();
			if (!OtherCollisionDirections_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.HitMoveOverlapOtherActorCollisionsInfo:OtherCollisionDirections");
				return null;
			}
			if (OtherCollisionDirections_MarshalerCached == null)
			{
				OtherCollisionDirections_MarshalerCached = new TArrayReadWriteMarshaler<int>(1, OtherCollisionDirections_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return OtherCollisionDirections_MarshalerCached.FromNative(IntPtr.Add(base.Address, OtherCollisionDirections_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4504149383184908uL)]
	[UMetaPath("/Script/b1.HitMoveOverlapOtherActorCollisionsInfo:SelfCollisions")]
	public TArrayReadWrite<UShapeComponent> SelfCollisions
	{
		get
		{
			CheckDestroyed();
			if (!SelfCollisions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.HitMoveOverlapOtherActorCollisionsInfo:SelfCollisions");
				return null;
			}
			if (SelfCollisions_MarshalerCached == null)
			{
				SelfCollisions_MarshalerCached = new TArrayReadWriteMarshaler<UShapeComponent>(1, SelfCollisions_PropertyAddress, CachedMarshalingDelegates<UShapeComponent, UObjectMarshaler<UShapeComponent>>.FromNative, CachedMarshalingDelegates<UShapeComponent, UObjectMarshaler<UShapeComponent>>.ToNative);
			}
			return SelfCollisions_MarshalerCached.FromNative(IntPtr.Add(base.Address, SelfCollisions_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/b1.HitMoveOverlapOtherActorCollisionsInfo:SelfCollisionDirections")]
	public TArrayReadWrite<int> SelfCollisionDirections
	{
		get
		{
			CheckDestroyed();
			if (!SelfCollisionDirections_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.HitMoveOverlapOtherActorCollisionsInfo:SelfCollisionDirections");
				return null;
			}
			if (SelfCollisionDirections_MarshalerCached == null)
			{
				SelfCollisionDirections_MarshalerCached = new TArrayReadWriteMarshaler<int>(1, SelfCollisionDirections_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return SelfCollisionDirections_MarshalerCached.FromNative(IntPtr.Add(base.Address, SelfCollisionDirections_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/b1.HitMoveOverlapOtherActorCollisionsInfo:OtherCollisionsLastTickCounts")]
	public TArrayReadWrite<int> OtherCollisionsLastTickCounts
	{
		get
		{
			CheckDestroyed();
			if (!OtherCollisionsLastTickCounts_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.HitMoveOverlapOtherActorCollisionsInfo:OtherCollisionsLastTickCounts");
				return null;
			}
			if (OtherCollisionsLastTickCounts_MarshalerCached == null)
			{
				OtherCollisionsLastTickCounts_MarshalerCached = new TArrayReadWriteMarshaler<int>(1, OtherCollisionsLastTickCounts_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return OtherCollisionsLastTickCounts_MarshalerCached.FromNative(IntPtr.Add(base.Address, OtherCollisionsLastTickCounts_Offset));
		}
	}

	static UHitMoveOverlapOtherActorCollisionsInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UHitMoveOverlapOtherActorCollisionsInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UHitMoveOverlapOtherActorCollisionsInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1.HitMoveOverlapOtherActorCollisionsInfo");
		OtherActor_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OtherActor");
		OtherActor_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OtherActor", Classes.FObjectProperty);
		OtherActorWeight_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OtherActorWeight");
		OtherActorWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OtherActorWeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref OtherCollisions_PropertyAddress, unrealStruct, "OtherCollisions");
		OtherCollisions_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OtherCollisions");
		OtherCollisions_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OtherCollisions", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref OtherCollisionDirections_PropertyAddress, unrealStruct, "OtherCollisionDirections");
		OtherCollisionDirections_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OtherCollisionDirections");
		OtherCollisionDirections_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OtherCollisionDirections", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SelfCollisions_PropertyAddress, unrealStruct, "SelfCollisions");
		SelfCollisions_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SelfCollisions");
		SelfCollisions_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SelfCollisions", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SelfCollisionDirections_PropertyAddress, unrealStruct, "SelfCollisionDirections");
		SelfCollisionDirections_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SelfCollisionDirections");
		SelfCollisionDirections_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SelfCollisionDirections", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref OtherCollisionsLastTickCounts_PropertyAddress, unrealStruct, "OtherCollisionsLastTickCounts");
		OtherCollisionsLastTickCounts_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OtherCollisionsLastTickCounts");
		OtherCollisionsLastTickCounts_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OtherCollisionsLastTickCounts", Classes.FArrayProperty);
	}
}
