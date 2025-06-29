using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ApexDestruction;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/ApexDestruction.DestructibleActor", "ApexDestruction", UnrealModuleType.EnginePlugin)]
public class ADestructibleActor : AActor
{
	private static bool DestructibleComponent_IsValid;

	private static int DestructibleComponent_Offset;

	private static bool OnActorFracture_IsValid;

	private static int OnActorFracture_Offset;

	private FActorFractureSignature OnActorFracture_DelegateCached;

	private static bool AffectNavigation_IsValid;

	private static FFieldAddress AffectNavigation_PropertyAddress;

	private static int AffectNavigation_Offset;

	[UProperty(Flags = (PropFlags)20266268117041693uL)]
	[UMetaPath("/Script/ApexDestruction.DestructibleActor:DestructibleComponent")]
	public UDestructibleComponent DestructibleComponent
	{
		get
		{
			CheckDestroyed();
			if (!DestructibleComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ApexDestruction.DestructibleActor:DestructibleComponent");
				return null;
			}
			return UObjectMarshaler<UDestructibleComponent>.FromNative(IntPtr.Add(base.Address, DestructibleComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DestructibleComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ApexDestruction.DestructibleActor:DestructibleComponent");
			}
			else
			{
				UObjectMarshaler<UDestructibleComponent>.ToNative(IntPtr.Add(base.Address, DestructibleComponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/ApexDestruction.DestructibleActor:OnActorFracture")]
	public FActorFractureSignature OnActorFracture
	{
		get
		{
			CheckDestroyed();
			if (!OnActorFracture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ApexDestruction.DestructibleActor:OnActorFracture");
				return new FActorFractureSignature();
			}
			if (OnActorFracture_DelegateCached == null)
			{
				OnActorFracture_DelegateCached = new FActorFractureSignature();
				OnActorFracture_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnActorFracture_Offset));
			}
			return OnActorFracture_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)6755502520287236uL)]
	[UMetaPath("/Script/ApexDestruction.DestructibleActor:bAffectNavigation")]
	public bool AffectNavigation
	{
		get
		{
			CheckDestroyed();
			if (!AffectNavigation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ApexDestruction.DestructibleActor:bAffectNavigation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AffectNavigation_Offset), 0, AffectNavigation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AffectNavigation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ApexDestruction.DestructibleActor:bAffectNavigation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AffectNavigation_Offset), 0, AffectNavigation_PropertyAddress.Address, value);
			}
		}
	}

	static ADestructibleActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ADestructibleActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ADestructibleActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/ApexDestruction.DestructibleActor");
		DestructibleComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DestructibleComponent");
		DestructibleComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DestructibleComponent", Classes.FObjectProperty);
		OnActorFracture_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnActorFracture");
		OnActorFracture_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnActorFracture", Classes.FMulticastDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref AffectNavigation_PropertyAddress, unrealStruct, "bAffectNavigation");
		AffectNavigation_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bAffectNavigation");
		AffectNavigation_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bAffectNavigation", Classes.FBoolProperty);
	}
}
