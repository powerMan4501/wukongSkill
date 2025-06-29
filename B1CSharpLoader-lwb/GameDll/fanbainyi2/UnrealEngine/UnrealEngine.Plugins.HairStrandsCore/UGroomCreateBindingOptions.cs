using System;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.GeometryCache;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "EditorPerProjectUserSettings")]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.GroomCreateBindingOptions", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public class UGroomCreateBindingOptions : UObject
{
	private static bool GroomBindingType_IsValid;

	private static FFieldAddress GroomBindingType_PropertyAddress;

	private static int GroomBindingType_Offset;

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

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomCreateBindingOptions:GroomBindingType")]
	public EGroomBindingMeshType GroomBindingType
	{
		get
		{
			CheckDestroyed();
			if (!GroomBindingType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCreateBindingOptions:GroomBindingType");
				return EGroomBindingMeshType.SkeletalMesh;
			}
			return EnumMarshaler<EGroomBindingMeshType>.FromNative(IntPtr.Add(base.Address, GroomBindingType_Offset), 0, GroomBindingType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GroomBindingType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCreateBindingOptions:GroomBindingType");
			}
			else
			{
				EnumMarshaler<EGroomBindingMeshType>.ToNative(IntPtr.Add(base.Address, GroomBindingType_Offset), 0, GroomBindingType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7885767187628549uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomCreateBindingOptions:SourceSkeletalMesh")]
	public USkeletalMesh SourceSkeletalMesh
	{
		get
		{
			CheckDestroyed();
			if (!SourceSkeletalMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCreateBindingOptions:SourceSkeletalMesh");
				return null;
			}
			return UObjectMarshaler<USkeletalMesh>.FromNative(IntPtr.Add(base.Address, SourceSkeletalMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SourceSkeletalMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCreateBindingOptions:SourceSkeletalMesh");
			}
			else
			{
				UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(base.Address, SourceSkeletalMesh_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomCreateBindingOptions:TargetSkeletalMesh")]
	public USkeletalMesh TargetSkeletalMesh
	{
		get
		{
			CheckDestroyed();
			if (!TargetSkeletalMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCreateBindingOptions:TargetSkeletalMesh");
				return null;
			}
			return UObjectMarshaler<USkeletalMesh>.FromNative(IntPtr.Add(base.Address, TargetSkeletalMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetSkeletalMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCreateBindingOptions:TargetSkeletalMesh");
			}
			else
			{
				UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(base.Address, TargetSkeletalMesh_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7885767187628549uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomCreateBindingOptions:SourceGeometryCache")]
	public UGeometryCache SourceGeometryCache
	{
		get
		{
			CheckDestroyed();
			if (!SourceGeometryCache_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCreateBindingOptions:SourceGeometryCache");
				return null;
			}
			return UObjectMarshaler<UGeometryCache>.FromNative(IntPtr.Add(base.Address, SourceGeometryCache_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SourceGeometryCache_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCreateBindingOptions:SourceGeometryCache");
			}
			else
			{
				UObjectMarshaler<UGeometryCache>.ToNative(IntPtr.Add(base.Address, SourceGeometryCache_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomCreateBindingOptions:TargetGeometryCache")]
	public UGeometryCache TargetGeometryCache
	{
		get
		{
			CheckDestroyed();
			if (!TargetGeometryCache_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCreateBindingOptions:TargetGeometryCache");
				return null;
			}
			return UObjectMarshaler<UGeometryCache>.FromNative(IntPtr.Add(base.Address, TargetGeometryCache_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetGeometryCache_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCreateBindingOptions:TargetGeometryCache");
			}
			else
			{
				UObjectMarshaler<UGeometryCache>.ToNative(IntPtr.Add(base.Address, TargetGeometryCache_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomCreateBindingOptions:NumInterpolationPoints")]
	public int NumInterpolationPoints
	{
		get
		{
			CheckDestroyed();
			if (!NumInterpolationPoints_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCreateBindingOptions:NumInterpolationPoints");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, NumInterpolationPoints_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NumInterpolationPoints_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCreateBindingOptions:NumInterpolationPoints");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, NumInterpolationPoints_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomCreateBindingOptions:MatchingSection")]
	public int MatchingSection
	{
		get
		{
			CheckDestroyed();
			if (!MatchingSection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCreateBindingOptions:MatchingSection");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MatchingSection_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MatchingSection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCreateBindingOptions:MatchingSection");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MatchingSection_Offset), value);
			}
		}
	}

	static UGroomCreateBindingOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGroomCreateBindingOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGroomCreateBindingOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/HairStrandsCore.GroomCreateBindingOptions");
		NativeReflectionCached.GetPropertyRef(ref GroomBindingType_PropertyAddress, unrealStruct, "GroomBindingType");
		GroomBindingType_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "GroomBindingType");
		GroomBindingType_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "GroomBindingType", Classes.FEnumProperty);
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
	}
}
