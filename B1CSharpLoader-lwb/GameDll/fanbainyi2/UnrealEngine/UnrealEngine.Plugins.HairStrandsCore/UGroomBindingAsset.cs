using System;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.GeometryCache;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.GroomBindingAsset", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public class UGroomBindingAsset : UObject
{
	private static bool GroomBindingType_IsValid;

	private static FFieldAddress GroomBindingType_PropertyAddress;

	private static int GroomBindingType_Offset;

	private static bool Groom_IsValid;

	private static int Groom_Offset;

	private static bool SourceSkeletalMesh_IsValid;

	private static int SourceSkeletalMesh_Offset;

	private static bool TargetSkeletalMesh_IsValid;

	private static int TargetSkeletalMesh_Offset;

	private static bool SourceGeometryCache_IsValid;

	private static int SourceGeometryCache_Offset;

	private static bool TargetGeometryCache_IsValid;

	private static int TargetGeometryCache_Offset;

	private static bool NumInterpolationPoints_IsValid;

	private static int NumInterpolationPoints_Offset;

	private static bool MatchingSection_IsValid;

	private static int MatchingSection_Offset;

	private static bool GroupInfos_IsValid;

	private static FFieldAddress GroupInfos_PropertyAddress;

	private static int GroupInfos_Offset;

	private TArrayReadWriteMarshaler<FGoomBindingGroupInfo> GroupInfos_MarshalerCached;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomBindingAsset:GroomBindingType")]
	public EGroomBindingMeshType GroomBindingType
	{
		get
		{
			CheckDestroyed();
			if (!GroomBindingType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomBindingAsset:GroomBindingType");
				return EGroomBindingMeshType.SkeletalMesh;
			}
			return EnumMarshaler<EGroomBindingMeshType>.FromNative(IntPtr.Add(base.Address, GroomBindingType_Offset), 0, GroomBindingType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GroomBindingType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomBindingAsset:GroomBindingType");
			}
			else
			{
				EnumMarshaler<EGroomBindingMeshType>.ToNative(IntPtr.Add(base.Address, GroomBindingType_Offset), 0, GroomBindingType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomBindingAsset:Groom")]
	public UGroomAsset Groom
	{
		get
		{
			CheckDestroyed();
			if (!Groom_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomBindingAsset:Groom");
				return null;
			}
			return UObjectMarshaler<UGroomAsset>.FromNative(IntPtr.Add(base.Address, Groom_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Groom_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomBindingAsset:Groom");
			}
			else
			{
				UObjectMarshaler<UGroomAsset>.ToNative(IntPtr.Add(base.Address, Groom_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomBindingAsset:SourceSkeletalMesh")]
	public USkeletalMesh SourceSkeletalMesh
	{
		get
		{
			CheckDestroyed();
			if (!SourceSkeletalMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomBindingAsset:SourceSkeletalMesh");
				return null;
			}
			return UObjectMarshaler<USkeletalMesh>.FromNative(IntPtr.Add(base.Address, SourceSkeletalMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SourceSkeletalMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomBindingAsset:SourceSkeletalMesh");
			}
			else
			{
				UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(base.Address, SourceSkeletalMesh_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomBindingAsset:TargetSkeletalMesh")]
	public USkeletalMesh TargetSkeletalMesh
	{
		get
		{
			CheckDestroyed();
			if (!TargetSkeletalMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomBindingAsset:TargetSkeletalMesh");
				return null;
			}
			return UObjectMarshaler<USkeletalMesh>.FromNative(IntPtr.Add(base.Address, TargetSkeletalMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetSkeletalMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomBindingAsset:TargetSkeletalMesh");
			}
			else
			{
				UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(base.Address, TargetSkeletalMesh_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141248517uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomBindingAsset:SourceGeometryCache")]
	public UGeometryCache SourceGeometryCache
	{
		get
		{
			CheckDestroyed();
			if (!SourceGeometryCache_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomBindingAsset:SourceGeometryCache");
				return null;
			}
			return UObjectMarshaler<UGeometryCache>.FromNative(IntPtr.Add(base.Address, SourceGeometryCache_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SourceGeometryCache_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomBindingAsset:SourceGeometryCache");
			}
			else
			{
				UObjectMarshaler<UGeometryCache>.ToNative(IntPtr.Add(base.Address, SourceGeometryCache_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141248517uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomBindingAsset:TargetGeometryCache")]
	public UGeometryCache TargetGeometryCache
	{
		get
		{
			CheckDestroyed();
			if (!TargetGeometryCache_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomBindingAsset:TargetGeometryCache");
				return null;
			}
			return UObjectMarshaler<UGeometryCache>.FromNative(IntPtr.Add(base.Address, TargetGeometryCache_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetGeometryCache_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomBindingAsset:TargetGeometryCache");
			}
			else
			{
				UObjectMarshaler<UGeometryCache>.ToNative(IntPtr.Add(base.Address, TargetGeometryCache_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomBindingAsset:NumInterpolationPoints")]
	public int NumInterpolationPoints
	{
		get
		{
			CheckDestroyed();
			if (!NumInterpolationPoints_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomBindingAsset:NumInterpolationPoints");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, NumInterpolationPoints_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NumInterpolationPoints_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomBindingAsset:NumInterpolationPoints");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, NumInterpolationPoints_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomBindingAsset:MatchingSection")]
	public int MatchingSection
	{
		get
		{
			CheckDestroyed();
			if (!MatchingSection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomBindingAsset:MatchingSection");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MatchingSection_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MatchingSection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomBindingAsset:MatchingSection");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MatchingSection_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371077uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomBindingAsset:GroupInfos")]
	public TArrayReadWrite<FGoomBindingGroupInfo> GroupInfos
	{
		get
		{
			CheckDestroyed();
			if (!GroupInfos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomBindingAsset:GroupInfos");
				return null;
			}
			if (GroupInfos_MarshalerCached == null)
			{
				GroupInfos_MarshalerCached = new TArrayReadWriteMarshaler<FGoomBindingGroupInfo>(1, GroupInfos_PropertyAddress, CachedMarshalingDelegates<FGoomBindingGroupInfo, FGoomBindingGroupInfo>.FromNative, CachedMarshalingDelegates<FGoomBindingGroupInfo, FGoomBindingGroupInfo>.ToNative);
			}
			return GroupInfos_MarshalerCached.FromNative(IntPtr.Add(base.Address, GroupInfos_Offset));
		}
	}

	static UGroomBindingAsset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGroomBindingAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGroomBindingAsset));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/HairStrandsCore.GroomBindingAsset");
		NativeReflectionCached.GetPropertyRef(ref GroomBindingType_PropertyAddress, unrealStruct, "GroomBindingType");
		GroomBindingType_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "GroomBindingType");
		GroomBindingType_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "GroomBindingType", Classes.FEnumProperty);
		Groom_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Groom");
		Groom_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Groom", Classes.FObjectProperty);
		SourceSkeletalMesh_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SourceSkeletalMesh");
		SourceSkeletalMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SourceSkeletalMesh", Classes.FObjectProperty);
		TargetSkeletalMesh_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TargetSkeletalMesh");
		TargetSkeletalMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TargetSkeletalMesh", Classes.FObjectProperty);
		SourceGeometryCache_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SourceGeometryCache");
		SourceGeometryCache_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SourceGeometryCache", Classes.FObjectProperty);
		TargetGeometryCache_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TargetGeometryCache");
		TargetGeometryCache_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TargetGeometryCache", Classes.FObjectProperty);
		NumInterpolationPoints_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "NumInterpolationPoints");
		NumInterpolationPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "NumInterpolationPoints", Classes.FIntProperty);
		MatchingSection_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MatchingSection");
		MatchingSection_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MatchingSection", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GroupInfos_PropertyAddress, unrealStruct, "GroupInfos");
		GroupInfos_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "GroupInfos");
		GroupInfos_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "GroupInfos", Classes.FArrayProperty);
	}
}
