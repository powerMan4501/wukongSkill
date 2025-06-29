using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "EditorPerProjectUserSettings")]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.GroomCreateStrandsTexturesOptions", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public class UGroomCreateStrandsTexturesOptions : UObject
{
	private static bool Resolution_IsValid;

	private static int Resolution_Offset;

	private static bool TraceType_IsValid;

	private static FFieldAddress TraceType_PropertyAddress;

	private static int TraceType_Offset;

	private static bool TraceDistance_IsValid;

	private static int TraceDistance_Offset;

	private static bool MeshType_IsValid;

	private static FFieldAddress MeshType_PropertyAddress;

	private static int MeshType_Offset;

	private static bool StaticMesh_IsValid;

	private static int StaticMesh_Offset;

	private static bool SkeletalMesh_IsValid;

	private static int SkeletalMesh_Offset;

	private static bool LODIndex_IsValid;

	private static int LODIndex_Offset;

	private static bool SectionIndex_IsValid;

	private static int SectionIndex_Offset;

	private static bool UVChannelIndex_IsValid;

	private static int UVChannelIndex_Offset;

	private static bool GroupIndex_IsValid;

	private static FFieldAddress GroupIndex_PropertyAddress;

	private static int GroupIndex_Offset;

	private TArrayReadWriteMarshaler<int> GroupIndex_MarshalerCached;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomCreateStrandsTexturesOptions:Resolution")]
	public int Resolution
	{
		get
		{
			CheckDestroyed();
			if (!Resolution_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCreateStrandsTexturesOptions:Resolution");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Resolution_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Resolution_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCreateStrandsTexturesOptions:Resolution");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Resolution_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomCreateStrandsTexturesOptions:TraceType")]
	public EStrandsTexturesTraceType TraceType
	{
		get
		{
			CheckDestroyed();
			if (!TraceType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCreateStrandsTexturesOptions:TraceType");
				return EStrandsTexturesTraceType.TraceInside;
			}
			return EnumMarshaler<EStrandsTexturesTraceType>.FromNative(IntPtr.Add(base.Address, TraceType_Offset), 0, TraceType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TraceType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCreateStrandsTexturesOptions:TraceType");
			}
			else
			{
				EnumMarshaler<EStrandsTexturesTraceType>.ToNative(IntPtr.Add(base.Address, TraceType_Offset), 0, TraceType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomCreateStrandsTexturesOptions:TraceDistance")]
	public float TraceDistance
	{
		get
		{
			CheckDestroyed();
			if (!TraceDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCreateStrandsTexturesOptions:TraceDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TraceDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TraceDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCreateStrandsTexturesOptions:TraceDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TraceDistance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomCreateStrandsTexturesOptions:MeshType")]
	public EStrandsTexturesMeshType MeshType
	{
		get
		{
			CheckDestroyed();
			if (!MeshType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCreateStrandsTexturesOptions:MeshType");
				return EStrandsTexturesMeshType.Static;
			}
			return EnumMarshaler<EStrandsTexturesMeshType>.FromNative(IntPtr.Add(base.Address, MeshType_Offset), 0, MeshType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MeshType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCreateStrandsTexturesOptions:MeshType");
			}
			else
			{
				EnumMarshaler<EStrandsTexturesMeshType>.ToNative(IntPtr.Add(base.Address, MeshType_Offset), 0, MeshType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomCreateStrandsTexturesOptions:StaticMesh")]
	public UStaticMesh StaticMesh
	{
		get
		{
			CheckDestroyed();
			if (!StaticMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCreateStrandsTexturesOptions:StaticMesh");
				return null;
			}
			return UObjectMarshaler<UStaticMesh>.FromNative(IntPtr.Add(base.Address, StaticMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StaticMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCreateStrandsTexturesOptions:StaticMesh");
			}
			else
			{
				UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(base.Address, StaticMesh_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomCreateStrandsTexturesOptions:SkeletalMesh")]
	public USkeletalMesh SkeletalMesh
	{
		get
		{
			CheckDestroyed();
			if (!SkeletalMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCreateStrandsTexturesOptions:SkeletalMesh");
				return null;
			}
			return UObjectMarshaler<USkeletalMesh>.FromNative(IntPtr.Add(base.Address, SkeletalMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SkeletalMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCreateStrandsTexturesOptions:SkeletalMesh");
			}
			else
			{
				UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(base.Address, SkeletalMesh_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomCreateStrandsTexturesOptions:LODIndex")]
	public int LODIndex
	{
		get
		{
			CheckDestroyed();
			if (!LODIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCreateStrandsTexturesOptions:LODIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, LODIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LODIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCreateStrandsTexturesOptions:LODIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, LODIndex_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomCreateStrandsTexturesOptions:SectionIndex")]
	public int SectionIndex
	{
		get
		{
			CheckDestroyed();
			if (!SectionIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCreateStrandsTexturesOptions:SectionIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SectionIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SectionIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCreateStrandsTexturesOptions:SectionIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SectionIndex_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomCreateStrandsTexturesOptions:UVChannelIndex")]
	public int UVChannelIndex
	{
		get
		{
			CheckDestroyed();
			if (!UVChannelIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCreateStrandsTexturesOptions:UVChannelIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, UVChannelIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UVChannelIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCreateStrandsTexturesOptions:UVChannelIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, UVChannelIndex_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomCreateStrandsTexturesOptions:GroupIndex")]
	public TArrayReadWrite<int> GroupIndex
	{
		get
		{
			CheckDestroyed();
			if (!GroupIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCreateStrandsTexturesOptions:GroupIndex");
				return null;
			}
			if (GroupIndex_MarshalerCached == null)
			{
				GroupIndex_MarshalerCached = new TArrayReadWriteMarshaler<int>(1, GroupIndex_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return GroupIndex_MarshalerCached.FromNative(IntPtr.Add(base.Address, GroupIndex_Offset));
		}
	}

	static UGroomCreateStrandsTexturesOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGroomCreateStrandsTexturesOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGroomCreateStrandsTexturesOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/HairStrandsCore.GroomCreateStrandsTexturesOptions");
		Resolution_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Resolution");
		Resolution_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Resolution", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref TraceType_PropertyAddress, unrealStruct, "TraceType");
		TraceType_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TraceType");
		TraceType_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TraceType", Classes.FEnumProperty);
		TraceDistance_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TraceDistance");
		TraceDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TraceDistance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MeshType_PropertyAddress, unrealStruct, "MeshType");
		MeshType_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MeshType");
		MeshType_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MeshType", Classes.FEnumProperty);
		StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "StaticMesh");
		StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "StaticMesh", Classes.FObjectProperty);
		SkeletalMesh_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SkeletalMesh");
		SkeletalMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SkeletalMesh", Classes.FObjectProperty);
		LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LODIndex");
		LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LODIndex", Classes.FIntProperty);
		SectionIndex_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SectionIndex");
		SectionIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SectionIndex", Classes.FIntProperty);
		UVChannelIndex_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "UVChannelIndex");
		UVChannelIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "UVChannelIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GroupIndex_PropertyAddress, unrealStruct, "GroupIndex");
		GroupIndex_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "GroupIndex");
		GroupIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "GroupIndex", Classes.FArrayProperty);
	}
}
