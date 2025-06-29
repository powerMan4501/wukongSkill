using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UClass(Flags = (ClassFlags)1883771044uL, Config = "EditorPerProjectUserSettings")]
[BlueprintType]
[UMetaPath("/Script/UnrealEd.FbxStaticMeshImportData", "UnrealEd", UnrealModuleType.Engine)]
public class UFbxStaticMeshImportData : UFbxMeshImportData
{
	private static bool StaticMeshLODGroup_IsValid;

	private static int StaticMeshLODGroup_Offset;

	private static bool VertexColorImportOption_IsValid;

	private static FFieldAddress VertexColorImportOption_PropertyAddress;

	private static int VertexColorImportOption_Offset;

	private static bool VertexOverrideColor_IsValid;

	private static int VertexOverrideColor_Offset;

	private static bool RemoveDegenerates_IsValid;

	private static FFieldAddress RemoveDegenerates_PropertyAddress;

	private static int RemoveDegenerates_Offset;

	private static bool BuildReversedIndexBuffer_IsValid;

	private static FFieldAddress BuildReversedIndexBuffer_PropertyAddress;

	private static int BuildReversedIndexBuffer_Offset;

	private static bool BuildNanite_IsValid;

	private static FFieldAddress BuildNanite_PropertyAddress;

	private static int BuildNanite_Offset;

	private static bool GenerateLightmapUVs_IsValid;

	private static FFieldAddress GenerateLightmapUVs_PropertyAddress;

	private static int GenerateLightmapUVs_Offset;

	private static bool OneConvexHullPerUCX_IsValid;

	private static FFieldAddress OneConvexHullPerUCX_PropertyAddress;

	private static int OneConvexHullPerUCX_Offset;

	private static bool AutoGenerateCollision_IsValid;

	private static FFieldAddress AutoGenerateCollision_PropertyAddress;

	private static int AutoGenerateCollision_Offset;

	private static bool CombineMeshes_IsValid;

	private static FFieldAddress CombineMeshes_PropertyAddress;

	private static int CombineMeshes_Offset;

	private static bool DistanceFieldResolutionScale_IsValid;

	private static int DistanceFieldResolutionScale_Offset;

	[UProperty(Flags = (PropFlags)6759867280802309uL)]
	[UMetaPath("/Script/UnrealEd.FbxStaticMeshImportData:StaticMeshLODGroup")]
	public FName StaticMeshLODGroup
	{
		get
		{
			CheckDestroyed();
			if (!StaticMeshLODGroup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxStaticMeshImportData:StaticMeshLODGroup");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, StaticMeshLODGroup_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StaticMeshLODGroup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxStaticMeshImportData:StaticMeshLODGroup");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, StaticMeshLODGroup_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280802309uL)]
	[UMetaPath("/Script/UnrealEd.FbxStaticMeshImportData:VertexColorImportOption")]
	public EVertexColorImportOption VertexColorImportOption
	{
		get
		{
			CheckDestroyed();
			if (!VertexColorImportOption_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxStaticMeshImportData:VertexColorImportOption");
				return EVertexColorImportOption.Replace;
			}
			return EnumMarshaler<EVertexColorImportOption>.FromNative(IntPtr.Add(base.Address, VertexColorImportOption_Offset), 0, VertexColorImportOption_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!VertexColorImportOption_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxStaticMeshImportData:VertexColorImportOption");
			}
			else
			{
				EnumMarshaler<EVertexColorImportOption>.ToNative(IntPtr.Add(base.Address, VertexColorImportOption_Offset), 0, VertexColorImportOption_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280802309uL)]
	[UMetaPath("/Script/UnrealEd.FbxStaticMeshImportData:VertexOverrideColor")]
	public FColor VertexOverrideColor
	{
		get
		{
			CheckDestroyed();
			if (!VertexOverrideColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxStaticMeshImportData:VertexOverrideColor");
				return default(FColor);
			}
			return BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(base.Address, VertexOverrideColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VertexOverrideColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxStaticMeshImportData:VertexOverrideColor");
			}
			else
			{
				BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(base.Address, VertexOverrideColor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207059973uL)]
	[UMetaPath("/Script/UnrealEd.FbxStaticMeshImportData:bRemoveDegenerates")]
	public bool RemoveDegenerates
	{
		get
		{
			CheckDestroyed();
			if (!RemoveDegenerates_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxStaticMeshImportData:bRemoveDegenerates");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RemoveDegenerates_Offset), 0, RemoveDegenerates_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RemoveDegenerates_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxStaticMeshImportData:bRemoveDegenerates");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RemoveDegenerates_Offset), 0, RemoveDegenerates_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207059973uL)]
	[UMetaPath("/Script/UnrealEd.FbxStaticMeshImportData:bBuildReversedIndexBuffer")]
	public bool BuildReversedIndexBuffer
	{
		get
		{
			CheckDestroyed();
			if (!BuildReversedIndexBuffer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxStaticMeshImportData:bBuildReversedIndexBuffer");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, BuildReversedIndexBuffer_Offset), 0, BuildReversedIndexBuffer_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BuildReversedIndexBuffer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxStaticMeshImportData:bBuildReversedIndexBuffer");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, BuildReversedIndexBuffer_Offset), 0, BuildReversedIndexBuffer_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160548869uL)]
	[UMetaPath("/Script/UnrealEd.FbxStaticMeshImportData:bBuildNanite")]
	public bool BuildNanite
	{
		get
		{
			CheckDestroyed();
			if (!BuildNanite_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxStaticMeshImportData:bBuildNanite");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, BuildNanite_Offset), 0, BuildNanite_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BuildNanite_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxStaticMeshImportData:bBuildNanite");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, BuildNanite_Offset), 0, BuildNanite_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207059973uL)]
	[UMetaPath("/Script/UnrealEd.FbxStaticMeshImportData:bGenerateLightmapUVs")]
	public bool GenerateLightmapUVs
	{
		get
		{
			CheckDestroyed();
			if (!GenerateLightmapUVs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxStaticMeshImportData:bGenerateLightmapUVs");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, GenerateLightmapUVs_Offset), 0, GenerateLightmapUVs_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GenerateLightmapUVs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxStaticMeshImportData:bGenerateLightmapUVs");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, GenerateLightmapUVs_Offset), 0, GenerateLightmapUVs_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207059973uL)]
	[UMetaPath("/Script/UnrealEd.FbxStaticMeshImportData:bOneConvexHullPerUCX")]
	public bool OneConvexHullPerUCX
	{
		get
		{
			CheckDestroyed();
			if (!OneConvexHullPerUCX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxStaticMeshImportData:bOneConvexHullPerUCX");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OneConvexHullPerUCX_Offset), 0, OneConvexHullPerUCX_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OneConvexHullPerUCX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxStaticMeshImportData:bOneConvexHullPerUCX");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OneConvexHullPerUCX_Offset), 0, OneConvexHullPerUCX_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160548869uL)]
	[UMetaPath("/Script/UnrealEd.FbxStaticMeshImportData:bAutoGenerateCollision")]
	public bool AutoGenerateCollision
	{
		get
		{
			CheckDestroyed();
			if (!AutoGenerateCollision_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxStaticMeshImportData:bAutoGenerateCollision");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoGenerateCollision_Offset), 0, AutoGenerateCollision_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoGenerateCollision_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxStaticMeshImportData:bAutoGenerateCollision");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoGenerateCollision_Offset), 0, AutoGenerateCollision_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207059973uL)]
	[UMetaPath("/Script/UnrealEd.FbxStaticMeshImportData:bCombineMeshes")]
	public bool CombineMeshes
	{
		get
		{
			CheckDestroyed();
			if (!CombineMeshes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxStaticMeshImportData:bCombineMeshes");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CombineMeshes_Offset), 0, CombineMeshes_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CombineMeshes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxStaticMeshImportData:bCombineMeshes");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CombineMeshes_Offset), 0, CombineMeshes_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280802309uL)]
	[UMetaPath("/Script/UnrealEd.FbxStaticMeshImportData:DistanceFieldResolutionScale")]
	public float DistanceFieldResolutionScale
	{
		get
		{
			CheckDestroyed();
			if (!DistanceFieldResolutionScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxStaticMeshImportData:DistanceFieldResolutionScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DistanceFieldResolutionScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DistanceFieldResolutionScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxStaticMeshImportData:DistanceFieldResolutionScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DistanceFieldResolutionScale_Offset), value);
			}
		}
	}

	static UFbxStaticMeshImportData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UFbxStaticMeshImportData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UFbxStaticMeshImportData));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/UnrealEd.FbxStaticMeshImportData");
		StaticMeshLODGroup_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "StaticMeshLODGroup");
		StaticMeshLODGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "StaticMeshLODGroup", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref VertexColorImportOption_PropertyAddress, unrealStruct, "VertexColorImportOption");
		VertexColorImportOption_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "VertexColorImportOption");
		VertexColorImportOption_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "VertexColorImportOption", Classes.FByteProperty);
		VertexOverrideColor_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "VertexOverrideColor");
		VertexOverrideColor_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "VertexOverrideColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveDegenerates_PropertyAddress, unrealStruct, "bRemoveDegenerates");
		RemoveDegenerates_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bRemoveDegenerates");
		RemoveDegenerates_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bRemoveDegenerates", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildReversedIndexBuffer_PropertyAddress, unrealStruct, "bBuildReversedIndexBuffer");
		BuildReversedIndexBuffer_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bBuildReversedIndexBuffer");
		BuildReversedIndexBuffer_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bBuildReversedIndexBuffer", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildNanite_PropertyAddress, unrealStruct, "bBuildNanite");
		BuildNanite_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bBuildNanite");
		BuildNanite_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bBuildNanite", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateLightmapUVs_PropertyAddress, unrealStruct, "bGenerateLightmapUVs");
		GenerateLightmapUVs_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bGenerateLightmapUVs");
		GenerateLightmapUVs_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bGenerateLightmapUVs", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OneConvexHullPerUCX_PropertyAddress, unrealStruct, "bOneConvexHullPerUCX");
		OneConvexHullPerUCX_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bOneConvexHullPerUCX");
		OneConvexHullPerUCX_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bOneConvexHullPerUCX", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoGenerateCollision_PropertyAddress, unrealStruct, "bAutoGenerateCollision");
		AutoGenerateCollision_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bAutoGenerateCollision");
		AutoGenerateCollision_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bAutoGenerateCollision", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CombineMeshes_PropertyAddress, unrealStruct, "bCombineMeshes");
		CombineMeshes_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bCombineMeshes");
		CombineMeshes_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bCombineMeshes", Classes.FBoolProperty);
		DistanceFieldResolutionScale_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DistanceFieldResolutionScale");
		DistanceFieldResolutionScale_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DistanceFieldResolutionScale", Classes.FFloatProperty);
	}
}
