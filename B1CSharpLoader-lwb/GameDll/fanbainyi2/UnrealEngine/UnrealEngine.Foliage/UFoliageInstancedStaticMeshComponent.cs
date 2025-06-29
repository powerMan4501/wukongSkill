using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Foliage;

[UClass(Flags = (ClassFlags)821039268uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Foliage.FoliageInstancedStaticMeshComponent", "Foliage", UnrealModuleType.Engine)]
public class UFoliageInstancedStaticMeshComponent : UHierarchicalInstancedStaticMeshComponent
{
	private static bool OnInstanceTakePointDamage_IsValid;

	private static int OnInstanceTakePointDamage_Offset;

	private FInstancePointDamageSignature OnInstanceTakePointDamage_DelegateCached;

	private static bool OnInstanceTakeRadialDamage_IsValid;

	private static int OnInstanceTakeRadialDamage_Offset;

	private FInstanceRadialDamageSignature OnInstanceTakeRadialDamage_DelegateCached;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Foliage.FoliageInstancedStaticMeshComponent:OnInstanceTakePointDamage")]
	public FInstancePointDamageSignature OnInstanceTakePointDamage
	{
		get
		{
			CheckDestroyed();
			if (!OnInstanceTakePointDamage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageInstancedStaticMeshComponent:OnInstanceTakePointDamage");
				return new FInstancePointDamageSignature();
			}
			if (OnInstanceTakePointDamage_DelegateCached == null)
			{
				OnInstanceTakePointDamage_DelegateCached = new FInstancePointDamageSignature();
				OnInstanceTakePointDamage_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnInstanceTakePointDamage_Offset));
			}
			return OnInstanceTakePointDamage_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Foliage.FoliageInstancedStaticMeshComponent:OnInstanceTakeRadialDamage")]
	public FInstanceRadialDamageSignature OnInstanceTakeRadialDamage
	{
		get
		{
			CheckDestroyed();
			if (!OnInstanceTakeRadialDamage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageInstancedStaticMeshComponent:OnInstanceTakeRadialDamage");
				return new FInstanceRadialDamageSignature();
			}
			if (OnInstanceTakeRadialDamage_DelegateCached == null)
			{
				OnInstanceTakeRadialDamage_DelegateCached = new FInstanceRadialDamageSignature();
				OnInstanceTakeRadialDamage_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnInstanceTakeRadialDamage_Offset));
			}
			return OnInstanceTakeRadialDamage_DelegateCached;
		}
	}

	static UFoliageInstancedStaticMeshComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UFoliageInstancedStaticMeshComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UFoliageInstancedStaticMeshComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Foliage.FoliageInstancedStaticMeshComponent");
		OnInstanceTakePointDamage_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnInstanceTakePointDamage");
		OnInstanceTakePointDamage_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnInstanceTakePointDamage", Classes.FMulticastDelegateProperty);
		OnInstanceTakeRadialDamage_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnInstanceTakeRadialDamage");
		OnInstanceTakeRadialDamage_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnInstanceTakeRadialDamage", Classes.FMulticastDelegateProperty);
	}
}
