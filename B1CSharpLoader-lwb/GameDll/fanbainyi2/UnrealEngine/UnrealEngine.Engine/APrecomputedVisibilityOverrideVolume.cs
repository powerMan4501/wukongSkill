using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818413732uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.PrecomputedVisibilityOverrideVolume", "Engine", UnrealModuleType.Engine)]
public class APrecomputedVisibilityOverrideVolume : AVolume
{
	private static bool OverrideVisibleActors_IsValid;

	private static FFieldAddress OverrideVisibleActors_PropertyAddress;

	private static int OverrideVisibleActors_Offset;

	private TArrayReadWriteMarshaler<AActor> OverrideVisibleActors_MarshalerCached;

	private static bool OverrideInvisibleActors_IsValid;

	private static FFieldAddress OverrideInvisibleActors_PropertyAddress;

	private static int OverrideInvisibleActors_Offset;

	private TArrayReadWriteMarshaler<AActor> OverrideInvisibleActors_MarshalerCached;

	private static bool OverrideInvisibleLevels_IsValid;

	private static FFieldAddress OverrideInvisibleLevels_PropertyAddress;

	private static int OverrideInvisibleLevels_Offset;

	private TArrayReadWriteMarshaler<FName> OverrideInvisibleLevels_MarshalerCached;

	[UProperty(Flags = (PropFlags)5629499534213637uL)]
	[UMetaPath("/Script/Engine.PrecomputedVisibilityOverrideVolume:OverrideVisibleActors")]
	public TArrayReadWrite<AActor> OverrideVisibleActors
	{
		get
		{
			CheckDestroyed();
			if (!OverrideVisibleActors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrecomputedVisibilityOverrideVolume:OverrideVisibleActors");
				return null;
			}
			if (OverrideVisibleActors_MarshalerCached == null)
			{
				OverrideVisibleActors_MarshalerCached = new TArrayReadWriteMarshaler<AActor>(1, OverrideVisibleActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative);
			}
			return OverrideVisibleActors_MarshalerCached.FromNative(IntPtr.Add(base.Address, OverrideVisibleActors_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)5629499534213637uL)]
	[UMetaPath("/Script/Engine.PrecomputedVisibilityOverrideVolume:OverrideInvisibleActors")]
	public TArrayReadWrite<AActor> OverrideInvisibleActors
	{
		get
		{
			CheckDestroyed();
			if (!OverrideInvisibleActors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrecomputedVisibilityOverrideVolume:OverrideInvisibleActors");
				return null;
			}
			if (OverrideInvisibleActors_MarshalerCached == null)
			{
				OverrideInvisibleActors_MarshalerCached = new TArrayReadWriteMarshaler<AActor>(1, OverrideInvisibleActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative);
			}
			return OverrideInvisibleActors_MarshalerCached.FromNative(IntPtr.Add(base.Address, OverrideInvisibleActors_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Engine.PrecomputedVisibilityOverrideVolume:OverrideInvisibleLevels")]
	public TArrayReadWrite<FName> OverrideInvisibleLevels
	{
		get
		{
			CheckDestroyed();
			if (!OverrideInvisibleLevels_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrecomputedVisibilityOverrideVolume:OverrideInvisibleLevels");
				return null;
			}
			if (OverrideInvisibleLevels_MarshalerCached == null)
			{
				OverrideInvisibleLevels_MarshalerCached = new TArrayReadWriteMarshaler<FName>(1, OverrideInvisibleLevels_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return OverrideInvisibleLevels_MarshalerCached.FromNative(IntPtr.Add(base.Address, OverrideInvisibleLevels_Offset));
		}
	}

	static APrecomputedVisibilityOverrideVolume()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(APrecomputedVisibilityOverrideVolume)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(APrecomputedVisibilityOverrideVolume));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.PrecomputedVisibilityOverrideVolume");
		NativeReflectionCached.GetPropertyRef(ref OverrideVisibleActors_PropertyAddress, unrealStruct, "OverrideVisibleActors");
		OverrideVisibleActors_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OverrideVisibleActors");
		OverrideVisibleActors_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OverrideVisibleActors", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideInvisibleActors_PropertyAddress, unrealStruct, "OverrideInvisibleActors");
		OverrideInvisibleActors_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OverrideInvisibleActors");
		OverrideInvisibleActors_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OverrideInvisibleActors", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideInvisibleLevels_PropertyAddress, unrealStruct, "OverrideInvisibleLevels");
		OverrideInvisibleLevels_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OverrideInvisibleLevels");
		OverrideInvisibleLevels_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OverrideInvisibleLevels", Classes.FArrayProperty);
	}
}
