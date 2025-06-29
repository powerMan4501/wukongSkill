using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)809578656uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.AnimNotifyState_GSDevLineHit", "b1", UnrealModuleType.Game)]
public class UAnimNotifyState_GSDevLineHit : UAnimNotifyState_GSBase
{
	private static bool HitFromActorLocation_IsValid;

	private static FFieldAddress HitFromActorLocation_PropertyAddress;

	private static int HitFromActorLocation_Offset;

	private static bool HitCheckRadius_IsValid;

	private static int HitCheckRadius_Offset;

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/b1.AnimNotifyState_GSDevLineHit:bHitFromActorLocation")]
	public bool HitFromActorLocation
	{
		get
		{
			CheckDestroyed();
			if (!HitFromActorLocation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotifyState_GSDevLineHit:bHitFromActorLocation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, HitFromActorLocation_Offset), 0, HitFromActorLocation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HitFromActorLocation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotifyState_GSDevLineHit:bHitFromActorLocation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, HitFromActorLocation_Offset), 0, HitFromActorLocation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/b1.AnimNotifyState_GSDevLineHit:HitCheckRadius")]
	public float HitCheckRadius
	{
		get
		{
			CheckDestroyed();
			if (!HitCheckRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotifyState_GSDevLineHit:HitCheckRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HitCheckRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HitCheckRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotifyState_GSDevLineHit:HitCheckRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HitCheckRadius_Offset), value);
			}
		}
	}

	static UAnimNotifyState_GSDevLineHit()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimNotifyState_GSDevLineHit)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimNotifyState_GSDevLineHit));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1.AnimNotifyState_GSDevLineHit");
		NativeReflectionCached.GetPropertyRef(ref HitFromActorLocation_PropertyAddress, unrealStruct, "bHitFromActorLocation");
		HitFromActorLocation_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bHitFromActorLocation");
		HitFromActorLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bHitFromActorLocation", Classes.FBoolProperty);
		HitCheckRadius_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "HitCheckRadius");
		HitCheckRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "HitCheckRadius", Classes.FFloatProperty);
	}
}
