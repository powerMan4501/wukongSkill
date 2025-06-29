using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UClass(Flags = (ClassFlags)818413732uL, Config = "EditorPerProjectUserSettings")]
[BlueprintType]
[UMetaPath("/Script/UnrealEd.FbxImportUI", "UnrealEd", UnrealModuleType.Engine)]
public class UFbxImportUI : UObject
{
	private static bool IsObjImport_IsValid;

	private static FFieldAddress IsObjImport_PropertyAddress;

	private static int IsObjImport_Offset;

	private static bool OriginalImportType_IsValid;

	private static FFieldAddress OriginalImportType_PropertyAddress;

	private static int OriginalImportType_Offset;

	private static bool MeshTypeToImport_IsValid;

	private static FFieldAddress MeshTypeToImport_PropertyAddress;

	private static int MeshTypeToImport_Offset;

	private static bool OverrideFullName_IsValid;

	private static FFieldAddress OverrideFullName_PropertyAddress;

	private static int OverrideFullName_Offset;

	private static bool ImportAsSkeletal_IsValid;

	private static FFieldAddress ImportAsSkeletal_PropertyAddress;

	private static int ImportAsSkeletal_Offset;

	private static bool ImportMesh_IsValid;

	private static FFieldAddress ImportMesh_PropertyAddress;

	private static int ImportMesh_Offset;

	private static bool Skeleton_IsValid;

	private static int Skeleton_Offset;

	private static bool CreatePhysicsAsset_IsValid;

	private static FFieldAddress CreatePhysicsAsset_PropertyAddress;

	private static int CreatePhysicsAsset_Offset;

	private static bool PhysicsAsset_IsValid;

	private static int PhysicsAsset_Offset;

	private static bool AutoComputeLodDistances_IsValid;

	private static FFieldAddress AutoComputeLodDistances_PropertyAddress;

	private static int AutoComputeLodDistances_Offset;

	private static bool LodDistance0_IsValid;

	private static int LodDistance0_Offset;

	private static bool LodDistance1_IsValid;

	private static int LodDistance1_Offset;

	private static bool LodDistance2_IsValid;

	private static int LodDistance2_Offset;

	private static bool LodDistance3_IsValid;

	private static int LodDistance3_Offset;

	private static bool LodDistance4_IsValid;

	private static int LodDistance4_Offset;

	private static bool LodDistance5_IsValid;

	private static int LodDistance5_Offset;

	private static bool LodDistance6_IsValid;

	private static int LodDistance6_Offset;

	private static bool LodDistance7_IsValid;

	private static int LodDistance7_Offset;

	private static bool MinimumLodNumber_IsValid;

	private static int MinimumLodNumber_Offset;

	private static bool LodNumber_IsValid;

	private static int LodNumber_Offset;

	private static bool ImportAnimations_IsValid;

	private static FFieldAddress ImportAnimations_PropertyAddress;

	private static int ImportAnimations_Offset;

	private static bool OverrideAnimationName_IsValid;

	private static int OverrideAnimationName_Offset;

	private static bool ImportRigidMesh_IsValid;

	private static FFieldAddress ImportRigidMesh_PropertyAddress;

	private static int ImportRigidMesh_Offset;

	private static bool ImportMaterials_IsValid;

	private static FFieldAddress ImportMaterials_PropertyAddress;

	private static int ImportMaterials_Offset;

	private static bool ImportTextures_IsValid;

	private static FFieldAddress ImportTextures_PropertyAddress;

	private static int ImportTextures_Offset;

	private static bool ResetToFbxOnMaterialConflict_IsValid;

	private static FFieldAddress ResetToFbxOnMaterialConflict_PropertyAddress;

	private static int ResetToFbxOnMaterialConflict_Offset;

	private static bool StaticMeshImportData_IsValid;

	private static int StaticMeshImportData_Offset;

	private static bool SkeletalMeshImportData_IsValid;

	private static int SkeletalMeshImportData_Offset;

	private static bool AnimSequenceImportData_IsValid;

	private static int AnimSequenceImportData_Offset;

	private static bool TextureImportData_IsValid;

	private static int TextureImportData_Offset;

	private static bool AutomatedImportShouldDetectType_IsValid;

	private static FFieldAddress AutomatedImportShouldDetectType_PropertyAddress;

	private static int AutomatedImportShouldDetectType_Offset;

	private static bool ResetToDefault_IsValid;

	private static IntPtr ResetToDefault_FunctionAddress;

	private static int ResetToDefault_ParamsSize;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealEd.FbxImportUI:bIsObjImport")]
	public bool IsObjImport
	{
		get
		{
			CheckDestroyed();
			if (!IsObjImport_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:bIsObjImport");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsObjImport_Offset), 0, IsObjImport_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsObjImport_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:bIsObjImport");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsObjImport_Offset), 0, IsObjImport_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealEd.FbxImportUI:OriginalImportType")]
	public EFBXImportType OriginalImportType
	{
		get
		{
			CheckDestroyed();
			if (!OriginalImportType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:OriginalImportType");
				return EFBXImportType.FBXIT_StaticMesh;
			}
			return EnumMarshaler<EFBXImportType>.FromNative(IntPtr.Add(base.Address, OriginalImportType_Offset), 0, OriginalImportType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OriginalImportType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:OriginalImportType");
			}
			else
			{
				EnumMarshaler<EFBXImportType>.ToNative(IntPtr.Add(base.Address, OriginalImportType_Offset), 0, OriginalImportType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealEd.FbxImportUI:MeshTypeToImport")]
	public EFBXImportType MeshTypeToImport
	{
		get
		{
			CheckDestroyed();
			if (!MeshTypeToImport_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:MeshTypeToImport");
				return EFBXImportType.FBXIT_StaticMesh;
			}
			return EnumMarshaler<EFBXImportType>.FromNative(IntPtr.Add(base.Address, MeshTypeToImport_Offset), 0, MeshTypeToImport_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MeshTypeToImport_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:MeshTypeToImport");
			}
			else
			{
				EnumMarshaler<EFBXImportType>.ToNative(IntPtr.Add(base.Address, MeshTypeToImport_Offset), 0, MeshTypeToImport_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207059973uL)]
	[UMetaPath("/Script/UnrealEd.FbxImportUI:bOverrideFullName")]
	public bool OverrideFullName
	{
		get
		{
			CheckDestroyed();
			if (!OverrideFullName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:bOverrideFullName");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OverrideFullName_Offset), 0, OverrideFullName_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OverrideFullName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:bOverrideFullName");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OverrideFullName_Offset), 0, OverrideFullName_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealEd.FbxImportUI:bImportAsSkeletal")]
	public bool ImportAsSkeletal
	{
		get
		{
			CheckDestroyed();
			if (!ImportAsSkeletal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:bImportAsSkeletal");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ImportAsSkeletal_Offset), 0, ImportAsSkeletal_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ImportAsSkeletal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:bImportAsSkeletal");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ImportAsSkeletal_Offset), 0, ImportAsSkeletal_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealEd.FbxImportUI:bImportMesh")]
	public bool ImportMesh
	{
		get
		{
			CheckDestroyed();
			if (!ImportMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:bImportMesh");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ImportMesh_Offset), 0, ImportMesh_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ImportMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:bImportMesh");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ImportMesh_Offset), 0, ImportMesh_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/UnrealEd.FbxImportUI:Skeleton")]
	public USkeleton Skeleton
	{
		get
		{
			CheckDestroyed();
			if (!Skeleton_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:Skeleton");
				return null;
			}
			return UObjectMarshaler<USkeleton>.FromNative(IntPtr.Add(base.Address, Skeleton_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Skeleton_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:Skeleton");
			}
			else
			{
				UObjectMarshaler<USkeleton>.ToNative(IntPtr.Add(base.Address, Skeleton_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207059973uL)]
	[UMetaPath("/Script/UnrealEd.FbxImportUI:bCreatePhysicsAsset")]
	public bool CreatePhysicsAsset
	{
		get
		{
			CheckDestroyed();
			if (!CreatePhysicsAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:bCreatePhysicsAsset");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CreatePhysicsAsset_Offset), 0, CreatePhysicsAsset_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CreatePhysicsAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:bCreatePhysicsAsset");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CreatePhysicsAsset_Offset), 0, CreatePhysicsAsset_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7885767187628549uL)]
	[UMetaPath("/Script/UnrealEd.FbxImportUI:PhysicsAsset")]
	public UPhysicsAsset PhysicsAsset
	{
		get
		{
			CheckDestroyed();
			if (!PhysicsAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:PhysicsAsset");
				return null;
			}
			return UObjectMarshaler<UPhysicsAsset>.FromNative(IntPtr.Add(base.Address, PhysicsAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PhysicsAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:PhysicsAsset");
			}
			else
			{
				UObjectMarshaler<UPhysicsAsset>.ToNative(IntPtr.Add(base.Address, PhysicsAsset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160548869uL)]
	[UMetaPath("/Script/UnrealEd.FbxImportUI:bAutoComputeLodDistances")]
	public bool AutoComputeLodDistances
	{
		get
		{
			CheckDestroyed();
			if (!AutoComputeLodDistances_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:bAutoComputeLodDistances");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoComputeLodDistances_Offset), 0, AutoComputeLodDistances_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoComputeLodDistances_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:bAutoComputeLodDistances");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoComputeLodDistances_Offset), 0, AutoComputeLodDistances_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/UnrealEd.FbxImportUI:LodDistance0")]
	public float LodDistance0
	{
		get
		{
			CheckDestroyed();
			if (!LodDistance0_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:LodDistance0");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LodDistance0_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LodDistance0_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:LodDistance0");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LodDistance0_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/UnrealEd.FbxImportUI:LodDistance1")]
	public float LodDistance1
	{
		get
		{
			CheckDestroyed();
			if (!LodDistance1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:LodDistance1");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LodDistance1_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LodDistance1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:LodDistance1");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LodDistance1_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/UnrealEd.FbxImportUI:LodDistance2")]
	public float LodDistance2
	{
		get
		{
			CheckDestroyed();
			if (!LodDistance2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:LodDistance2");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LodDistance2_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LodDistance2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:LodDistance2");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LodDistance2_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/UnrealEd.FbxImportUI:LodDistance3")]
	public float LodDistance3
	{
		get
		{
			CheckDestroyed();
			if (!LodDistance3_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:LodDistance3");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LodDistance3_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LodDistance3_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:LodDistance3");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LodDistance3_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/UnrealEd.FbxImportUI:LodDistance4")]
	public float LodDistance4
	{
		get
		{
			CheckDestroyed();
			if (!LodDistance4_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:LodDistance4");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LodDistance4_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LodDistance4_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:LodDistance4");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LodDistance4_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/UnrealEd.FbxImportUI:LodDistance5")]
	public float LodDistance5
	{
		get
		{
			CheckDestroyed();
			if (!LodDistance5_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:LodDistance5");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LodDistance5_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LodDistance5_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:LodDistance5");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LodDistance5_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/UnrealEd.FbxImportUI:LodDistance6")]
	public float LodDistance6
	{
		get
		{
			CheckDestroyed();
			if (!LodDistance6_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:LodDistance6");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LodDistance6_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LodDistance6_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:LodDistance6");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LodDistance6_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/UnrealEd.FbxImportUI:LodDistance7")]
	public float LodDistance7
	{
		get
		{
			CheckDestroyed();
			if (!LodDistance7_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:LodDistance7");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LodDistance7_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LodDistance7_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:LodDistance7");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LodDistance7_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280802309uL)]
	[UMetaPath("/Script/UnrealEd.FbxImportUI:MinimumLodNumber")]
	public int MinimumLodNumber
	{
		get
		{
			CheckDestroyed();
			if (!MinimumLodNumber_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:MinimumLodNumber");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MinimumLodNumber_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinimumLodNumber_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:MinimumLodNumber");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MinimumLodNumber_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280802309uL)]
	[UMetaPath("/Script/UnrealEd.FbxImportUI:LodNumber")]
	public int LodNumber
	{
		get
		{
			CheckDestroyed();
			if (!LodNumber_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:LodNumber");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, LodNumber_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LodNumber_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:LodNumber");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, LodNumber_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160548869uL)]
	[UMetaPath("/Script/UnrealEd.FbxImportUI:bImportAnimations")]
	public bool ImportAnimations
	{
		get
		{
			CheckDestroyed();
			if (!ImportAnimations_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:bImportAnimations");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ImportAnimations_Offset), 0, ImportAnimations_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ImportAnimations_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:bImportAnimations");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ImportAnimations_Offset), 0, ImportAnimations_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759797487567365uL)]
	[UMetaPath("/Script/UnrealEd.FbxImportUI:OverrideAnimationName")]
	public string OverrideAnimationName
	{
		get
		{
			CheckDestroyed();
			if (!OverrideAnimationName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:OverrideAnimationName");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, OverrideAnimationName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OverrideAnimationName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:OverrideAnimationName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, OverrideAnimationName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532484uL)]
	[UMetaPath("/Script/UnrealEd.FbxImportUI:bImportRigidMesh")]
	public bool ImportRigidMesh
	{
		get
		{
			CheckDestroyed();
			if (!ImportRigidMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:bImportRigidMesh");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ImportRigidMesh_Offset), 0, ImportRigidMesh_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ImportRigidMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:bImportRigidMesh");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ImportRigidMesh_Offset), 0, ImportRigidMesh_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160548869uL)]
	[UMetaPath("/Script/UnrealEd.FbxImportUI:bImportMaterials")]
	public bool ImportMaterials
	{
		get
		{
			CheckDestroyed();
			if (!ImportMaterials_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:bImportMaterials");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ImportMaterials_Offset), 0, ImportMaterials_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ImportMaterials_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:bImportMaterials");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ImportMaterials_Offset), 0, ImportMaterials_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160548869uL)]
	[UMetaPath("/Script/UnrealEd.FbxImportUI:bImportTextures")]
	public bool ImportTextures
	{
		get
		{
			CheckDestroyed();
			if (!ImportTextures_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:bImportTextures");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ImportTextures_Offset), 0, ImportTextures_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ImportTextures_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:bImportTextures");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ImportTextures_Offset), 0, ImportTextures_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160540676uL)]
	[UMetaPath("/Script/UnrealEd.FbxImportUI:bResetToFbxOnMaterialConflict")]
	public bool ResetToFbxOnMaterialConflict
	{
		get
		{
			CheckDestroyed();
			if (!ResetToFbxOnMaterialConflict_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:bResetToFbxOnMaterialConflict");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ResetToFbxOnMaterialConflict_Offset), 0, ResetToFbxOnMaterialConflict_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ResetToFbxOnMaterialConflict_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:bResetToFbxOnMaterialConflict");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ResetToFbxOnMaterialConflict_Offset), 0, ResetToFbxOnMaterialConflict_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)8444319095071245uL)]
	[UMetaPath("/Script/UnrealEd.FbxImportUI:StaticMeshImportData")]
	public UFbxStaticMeshImportData StaticMeshImportData
	{
		get
		{
			CheckDestroyed();
			if (!StaticMeshImportData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:StaticMeshImportData");
				return null;
			}
			return UObjectMarshaler<UFbxStaticMeshImportData>.FromNative(IntPtr.Add(base.Address, StaticMeshImportData_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StaticMeshImportData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:StaticMeshImportData");
			}
			else
			{
				UObjectMarshaler<UFbxStaticMeshImportData>.ToNative(IntPtr.Add(base.Address, StaticMeshImportData_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)8444319095071245uL)]
	[UMetaPath("/Script/UnrealEd.FbxImportUI:SkeletalMeshImportData")]
	public UFbxSkeletalMeshImportData SkeletalMeshImportData
	{
		get
		{
			CheckDestroyed();
			if (!SkeletalMeshImportData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:SkeletalMeshImportData");
				return null;
			}
			return UObjectMarshaler<UFbxSkeletalMeshImportData>.FromNative(IntPtr.Add(base.Address, SkeletalMeshImportData_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SkeletalMeshImportData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:SkeletalMeshImportData");
			}
			else
			{
				UObjectMarshaler<UFbxSkeletalMeshImportData>.ToNative(IntPtr.Add(base.Address, SkeletalMeshImportData_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)8444319095071245uL)]
	[UMetaPath("/Script/UnrealEd.FbxImportUI:AnimSequenceImportData")]
	public UFbxAnimSequenceImportData AnimSequenceImportData
	{
		get
		{
			CheckDestroyed();
			if (!AnimSequenceImportData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:AnimSequenceImportData");
				return null;
			}
			return UObjectMarshaler<UFbxAnimSequenceImportData>.FromNative(IntPtr.Add(base.Address, AnimSequenceImportData_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimSequenceImportData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:AnimSequenceImportData");
			}
			else
			{
				UObjectMarshaler<UFbxAnimSequenceImportData>.ToNative(IntPtr.Add(base.Address, AnimSequenceImportData_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)8444319095071245uL)]
	[UMetaPath("/Script/UnrealEd.FbxImportUI:TextureImportData")]
	public UFbxTextureImportData TextureImportData
	{
		get
		{
			CheckDestroyed();
			if (!TextureImportData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:TextureImportData");
				return null;
			}
			return UObjectMarshaler<UFbxTextureImportData>.FromNative(IntPtr.Add(base.Address, TextureImportData_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TextureImportData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:TextureImportData");
			}
			else
			{
				UObjectMarshaler<UFbxTextureImportData>.ToNative(IntPtr.Add(base.Address, TextureImportData_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealEd.FbxImportUI:bAutomatedImportShouldDetectType")]
	public bool AutomatedImportShouldDetectType
	{
		get
		{
			CheckDestroyed();
			if (!AutomatedImportShouldDetectType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:bAutomatedImportShouldDetectType");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutomatedImportShouldDetectType_Offset), 0, AutomatedImportShouldDetectType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutomatedImportShouldDetectType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxImportUI:bAutomatedImportShouldDetectType");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutomatedImportShouldDetectType_Offset), 0, AutomatedImportShouldDetectType_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealEd.FbxImportUI:ResetToDefault")]
	public unsafe void ResetToDefault()
	{
		CheckDestroyed();
		if (!ResetToDefault_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.FbxImportUI:ResetToDefault");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetToDefault_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetToDefault_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResetToDefault_FunctionAddress, argsSize: ResetToDefault_ParamsSize);
	}

	static UFbxImportUI()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UFbxImportUI)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UFbxImportUI));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UnrealEd.FbxImportUI");
		NativeReflectionCached.GetPropertyRef(ref IsObjImport_PropertyAddress, intPtr, "bIsObjImport");
		IsObjImport_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsObjImport");
		IsObjImport_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsObjImport", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OriginalImportType_PropertyAddress, intPtr, "OriginalImportType");
		OriginalImportType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OriginalImportType");
		OriginalImportType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OriginalImportType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref MeshTypeToImport_PropertyAddress, intPtr, "MeshTypeToImport");
		MeshTypeToImport_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MeshTypeToImport");
		MeshTypeToImport_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MeshTypeToImport", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideFullName_PropertyAddress, intPtr, "bOverrideFullName");
		OverrideFullName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverrideFullName");
		OverrideFullName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverrideFullName", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportAsSkeletal_PropertyAddress, intPtr, "bImportAsSkeletal");
		ImportAsSkeletal_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bImportAsSkeletal");
		ImportAsSkeletal_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bImportAsSkeletal", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportMesh_PropertyAddress, intPtr, "bImportMesh");
		ImportMesh_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bImportMesh");
		ImportMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bImportMesh", Classes.FBoolProperty);
		Skeleton_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Skeleton");
		Skeleton_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Skeleton", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreatePhysicsAsset_PropertyAddress, intPtr, "bCreatePhysicsAsset");
		CreatePhysicsAsset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCreatePhysicsAsset");
		CreatePhysicsAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCreatePhysicsAsset", Classes.FBoolProperty);
		PhysicsAsset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PhysicsAsset");
		PhysicsAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PhysicsAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoComputeLodDistances_PropertyAddress, intPtr, "bAutoComputeLodDistances");
		AutoComputeLodDistances_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAutoComputeLodDistances");
		AutoComputeLodDistances_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAutoComputeLodDistances", Classes.FBoolProperty);
		LodDistance0_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LodDistance0");
		LodDistance0_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LodDistance0", Classes.FFloatProperty);
		LodDistance1_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LodDistance1");
		LodDistance1_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LodDistance1", Classes.FFloatProperty);
		LodDistance2_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LodDistance2");
		LodDistance2_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LodDistance2", Classes.FFloatProperty);
		LodDistance3_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LodDistance3");
		LodDistance3_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LodDistance3", Classes.FFloatProperty);
		LodDistance4_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LodDistance4");
		LodDistance4_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LodDistance4", Classes.FFloatProperty);
		LodDistance5_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LodDistance5");
		LodDistance5_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LodDistance5", Classes.FFloatProperty);
		LodDistance6_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LodDistance6");
		LodDistance6_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LodDistance6", Classes.FFloatProperty);
		LodDistance7_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LodDistance7");
		LodDistance7_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LodDistance7", Classes.FFloatProperty);
		MinimumLodNumber_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinimumLodNumber");
		MinimumLodNumber_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinimumLodNumber", Classes.FIntProperty);
		LodNumber_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LodNumber");
		LodNumber_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LodNumber", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportAnimations_PropertyAddress, intPtr, "bImportAnimations");
		ImportAnimations_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bImportAnimations");
		ImportAnimations_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bImportAnimations", Classes.FBoolProperty);
		OverrideAnimationName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OverrideAnimationName");
		OverrideAnimationName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OverrideAnimationName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportRigidMesh_PropertyAddress, intPtr, "bImportRigidMesh");
		ImportRigidMesh_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bImportRigidMesh");
		ImportRigidMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bImportRigidMesh", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportMaterials_PropertyAddress, intPtr, "bImportMaterials");
		ImportMaterials_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bImportMaterials");
		ImportMaterials_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bImportMaterials", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportTextures_PropertyAddress, intPtr, "bImportTextures");
		ImportTextures_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bImportTextures");
		ImportTextures_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bImportTextures", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ResetToFbxOnMaterialConflict_PropertyAddress, intPtr, "bResetToFbxOnMaterialConflict");
		ResetToFbxOnMaterialConflict_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bResetToFbxOnMaterialConflict");
		ResetToFbxOnMaterialConflict_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bResetToFbxOnMaterialConflict", Classes.FBoolProperty);
		StaticMeshImportData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StaticMeshImportData");
		StaticMeshImportData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StaticMeshImportData", Classes.FObjectProperty);
		SkeletalMeshImportData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SkeletalMeshImportData");
		SkeletalMeshImportData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SkeletalMeshImportData", Classes.FObjectProperty);
		AnimSequenceImportData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AnimSequenceImportData");
		AnimSequenceImportData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AnimSequenceImportData", Classes.FObjectProperty);
		TextureImportData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TextureImportData");
		TextureImportData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TextureImportData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AutomatedImportShouldDetectType_PropertyAddress, intPtr, "bAutomatedImportShouldDetectType");
		AutomatedImportShouldDetectType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAutomatedImportShouldDetectType");
		AutomatedImportShouldDetectType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAutomatedImportShouldDetectType", Classes.FBoolProperty);
		ResetToDefault_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResetToDefault");
		ResetToDefault_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetToDefault_FunctionAddress);
		ResetToDefault_IsValid = ResetToDefault_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealEd.FbxImportUI:ResetToDefault", ResetToDefault_IsValid);
	}
}
