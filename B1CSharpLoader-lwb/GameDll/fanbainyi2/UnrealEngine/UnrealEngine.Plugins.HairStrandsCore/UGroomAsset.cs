using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.GroomAsset", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public class UGroomAsset : UObject, IInterface_AssetUserData, IInterface
{
	private static bool HairGroupsRendering_IsValid;

	private static FFieldAddress HairGroupsRendering_PropertyAddress;

	private static int HairGroupsRendering_Offset;

	private TArrayReadWriteMarshaler<FHairGroupsRendering> HairGroupsRendering_MarshalerCached;

	private static bool HairGroupsPhysics_IsValid;

	private static FFieldAddress HairGroupsPhysics_PropertyAddress;

	private static int HairGroupsPhysics_Offset;

	private TArrayReadWriteMarshaler<FHairGroupsPhysics> HairGroupsPhysics_MarshalerCached;

	private static bool HairGroupsInterpolation_IsValid;

	private static FFieldAddress HairGroupsInterpolation_PropertyAddress;

	private static int HairGroupsInterpolation_Offset;

	private TArrayReadWriteMarshaler<FHairGroupsInterpolation> HairGroupsInterpolation_MarshalerCached;

	private static bool HairGroupsLOD_IsValid;

	private static FFieldAddress HairGroupsLOD_PropertyAddress;

	private static int HairGroupsLOD_Offset;

	private TArrayReadWriteMarshaler<FHairGroupsLOD> HairGroupsLOD_MarshalerCached;

	private static bool HairGroupsCards_IsValid;

	private static FFieldAddress HairGroupsCards_PropertyAddress;

	private static int HairGroupsCards_Offset;

	private TArrayReadWriteMarshaler<FHairGroupsCardsSourceDescription> HairGroupsCards_MarshalerCached;

	private static bool HairGroupsMeshes_IsValid;

	private static FFieldAddress HairGroupsMeshes_PropertyAddress;

	private static int HairGroupsMeshes_Offset;

	private TArrayReadWriteMarshaler<FHairGroupsMeshesSourceDescription> HairGroupsMeshes_MarshalerCached;

	private static bool HairGroupsMaterials_IsValid;

	private static FFieldAddress HairGroupsMaterials_PropertyAddress;

	private static int HairGroupsMaterials_Offset;

	private TArrayReadWriteMarshaler<FHairGroupsMaterial> HairGroupsMaterials_MarshalerCached;

	private static bool EnableGlobalInterpolation_IsValid;

	private static FFieldAddress EnableGlobalInterpolation_PropertyAddress;

	private static int EnableGlobalInterpolation_Offset;

	private static bool HairInterpolationType_IsValid;

	private static FFieldAddress HairInterpolationType_PropertyAddress;

	private static int HairInterpolationType_Offset;

	[UProperty(Flags = (PropFlags)4503599627371077uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomAsset:HairGroupsRendering")]
	public TArrayReadWrite<FHairGroupsRendering> HairGroupsRendering
	{
		get
		{
			CheckDestroyed();
			if (!HairGroupsRendering_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomAsset:HairGroupsRendering");
				return null;
			}
			if (HairGroupsRendering_MarshalerCached == null)
			{
				HairGroupsRendering_MarshalerCached = new TArrayReadWriteMarshaler<FHairGroupsRendering>(1, HairGroupsRendering_PropertyAddress, CachedMarshalingDelegates<FHairGroupsRendering, FHairGroupsRendering>.FromNative, CachedMarshalingDelegates<FHairGroupsRendering, FHairGroupsRendering>.ToNative);
			}
			return HairGroupsRendering_MarshalerCached.FromNative(IntPtr.Add(base.Address, HairGroupsRendering_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371077uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomAsset:HairGroupsPhysics")]
	public TArrayReadWrite<FHairGroupsPhysics> HairGroupsPhysics
	{
		get
		{
			CheckDestroyed();
			if (!HairGroupsPhysics_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomAsset:HairGroupsPhysics");
				return null;
			}
			if (HairGroupsPhysics_MarshalerCached == null)
			{
				HairGroupsPhysics_MarshalerCached = new TArrayReadWriteMarshaler<FHairGroupsPhysics>(1, HairGroupsPhysics_PropertyAddress, CachedMarshalingDelegates<FHairGroupsPhysics, FHairGroupsPhysics>.FromNative, CachedMarshalingDelegates<FHairGroupsPhysics, FHairGroupsPhysics>.ToNative);
			}
			return HairGroupsPhysics_MarshalerCached.FromNative(IntPtr.Add(base.Address, HairGroupsPhysics_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371077uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomAsset:HairGroupsInterpolation")]
	public TArrayReadWrite<FHairGroupsInterpolation> HairGroupsInterpolation
	{
		get
		{
			CheckDestroyed();
			if (!HairGroupsInterpolation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomAsset:HairGroupsInterpolation");
				return null;
			}
			if (HairGroupsInterpolation_MarshalerCached == null)
			{
				HairGroupsInterpolation_MarshalerCached = new TArrayReadWriteMarshaler<FHairGroupsInterpolation>(1, HairGroupsInterpolation_PropertyAddress, CachedMarshalingDelegates<FHairGroupsInterpolation, FHairGroupsInterpolation>.FromNative, CachedMarshalingDelegates<FHairGroupsInterpolation, FHairGroupsInterpolation>.ToNative);
			}
			return HairGroupsInterpolation_MarshalerCached.FromNative(IntPtr.Add(base.Address, HairGroupsInterpolation_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371077uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomAsset:HairGroupsLOD")]
	public TArrayReadWrite<FHairGroupsLOD> HairGroupsLOD
	{
		get
		{
			CheckDestroyed();
			if (!HairGroupsLOD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomAsset:HairGroupsLOD");
				return null;
			}
			if (HairGroupsLOD_MarshalerCached == null)
			{
				HairGroupsLOD_MarshalerCached = new TArrayReadWriteMarshaler<FHairGroupsLOD>(1, HairGroupsLOD_PropertyAddress, CachedMarshalingDelegates<FHairGroupsLOD, FHairGroupsLOD>.FromNative, CachedMarshalingDelegates<FHairGroupsLOD, FHairGroupsLOD>.ToNative);
			}
			return HairGroupsLOD_MarshalerCached.FromNative(IntPtr.Add(base.Address, HairGroupsLOD_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomAsset:HairGroupsCards")]
	public TArrayReadWrite<FHairGroupsCardsSourceDescription> HairGroupsCards
	{
		get
		{
			CheckDestroyed();
			if (!HairGroupsCards_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomAsset:HairGroupsCards");
				return null;
			}
			if (HairGroupsCards_MarshalerCached == null)
			{
				HairGroupsCards_MarshalerCached = new TArrayReadWriteMarshaler<FHairGroupsCardsSourceDescription>(1, HairGroupsCards_PropertyAddress, CachedMarshalingDelegates<FHairGroupsCardsSourceDescription, FHairGroupsCardsSourceDescription>.FromNative, CachedMarshalingDelegates<FHairGroupsCardsSourceDescription, FHairGroupsCardsSourceDescription>.ToNative);
			}
			return HairGroupsCards_MarshalerCached.FromNative(IntPtr.Add(base.Address, HairGroupsCards_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomAsset:HairGroupsMeshes")]
	public TArrayReadWrite<FHairGroupsMeshesSourceDescription> HairGroupsMeshes
	{
		get
		{
			CheckDestroyed();
			if (!HairGroupsMeshes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomAsset:HairGroupsMeshes");
				return null;
			}
			if (HairGroupsMeshes_MarshalerCached == null)
			{
				HairGroupsMeshes_MarshalerCached = new TArrayReadWriteMarshaler<FHairGroupsMeshesSourceDescription>(1, HairGroupsMeshes_PropertyAddress, CachedMarshalingDelegates<FHairGroupsMeshesSourceDescription, FHairGroupsMeshesSourceDescription>.FromNative, CachedMarshalingDelegates<FHairGroupsMeshesSourceDescription, FHairGroupsMeshesSourceDescription>.ToNative);
			}
			return HairGroupsMeshes_MarshalerCached.FromNative(IntPtr.Add(base.Address, HairGroupsMeshes_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomAsset:HairGroupsMaterials")]
	public TArrayReadWrite<FHairGroupsMaterial> HairGroupsMaterials
	{
		get
		{
			CheckDestroyed();
			if (!HairGroupsMaterials_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomAsset:HairGroupsMaterials");
				return null;
			}
			if (HairGroupsMaterials_MarshalerCached == null)
			{
				HairGroupsMaterials_MarshalerCached = new TArrayReadWriteMarshaler<FHairGroupsMaterial>(1, HairGroupsMaterials_PropertyAddress, CachedMarshalingDelegates<FHairGroupsMaterial, FHairGroupsMaterial>.FromNative, CachedMarshalingDelegates<FHairGroupsMaterial, FHairGroupsMaterial>.ToNative);
			}
			return HairGroupsMaterials_MarshalerCached.FromNative(IntPtr.Add(base.Address, HairGroupsMaterials_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274885uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomAsset:EnableGlobalInterpolation")]
	public bool EnableGlobalInterpolation
	{
		get
		{
			CheckDestroyed();
			if (!EnableGlobalInterpolation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomAsset:EnableGlobalInterpolation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableGlobalInterpolation_Offset), 0, EnableGlobalInterpolation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableGlobalInterpolation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomAsset:EnableGlobalInterpolation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableGlobalInterpolation_Offset), 0, EnableGlobalInterpolation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274885uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomAsset:HairInterpolationType")]
	public EGroomInterpolationType HairInterpolationType
	{
		get
		{
			CheckDestroyed();
			if (!HairInterpolationType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomAsset:HairInterpolationType");
				return EGroomInterpolationType.None;
			}
			return EnumMarshaler<EGroomInterpolationType>.FromNative(IntPtr.Add(base.Address, HairInterpolationType_Offset), 0, HairInterpolationType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HairInterpolationType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomAsset:HairInterpolationType");
			}
			else
			{
				EnumMarshaler<EGroomInterpolationType>.ToNative(IntPtr.Add(base.Address, HairInterpolationType_Offset), 0, HairInterpolationType_PropertyAddress.Address, value);
			}
		}
	}

	static UGroomAsset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGroomAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGroomAsset));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/HairStrandsCore.GroomAsset");
		NativeReflectionCached.GetPropertyRef(ref HairGroupsRendering_PropertyAddress, unrealStruct, "HairGroupsRendering");
		HairGroupsRendering_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "HairGroupsRendering");
		HairGroupsRendering_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "HairGroupsRendering", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref HairGroupsPhysics_PropertyAddress, unrealStruct, "HairGroupsPhysics");
		HairGroupsPhysics_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "HairGroupsPhysics");
		HairGroupsPhysics_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "HairGroupsPhysics", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref HairGroupsInterpolation_PropertyAddress, unrealStruct, "HairGroupsInterpolation");
		HairGroupsInterpolation_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "HairGroupsInterpolation");
		HairGroupsInterpolation_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "HairGroupsInterpolation", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref HairGroupsLOD_PropertyAddress, unrealStruct, "HairGroupsLOD");
		HairGroupsLOD_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "HairGroupsLOD");
		HairGroupsLOD_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "HairGroupsLOD", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref HairGroupsCards_PropertyAddress, unrealStruct, "HairGroupsCards");
		HairGroupsCards_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "HairGroupsCards");
		HairGroupsCards_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "HairGroupsCards", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref HairGroupsMeshes_PropertyAddress, unrealStruct, "HairGroupsMeshes");
		HairGroupsMeshes_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "HairGroupsMeshes");
		HairGroupsMeshes_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "HairGroupsMeshes", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref HairGroupsMaterials_PropertyAddress, unrealStruct, "HairGroupsMaterials");
		HairGroupsMaterials_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "HairGroupsMaterials");
		HairGroupsMaterials_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "HairGroupsMaterials", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableGlobalInterpolation_PropertyAddress, unrealStruct, "EnableGlobalInterpolation");
		EnableGlobalInterpolation_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "EnableGlobalInterpolation");
		EnableGlobalInterpolation_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "EnableGlobalInterpolation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref HairInterpolationType_PropertyAddress, unrealStruct, "HairInterpolationType");
		HairInterpolationType_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "HairInterpolationType");
		HairInterpolationType_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "HairInterpolationType", Classes.FEnumProperty);
	}
}
