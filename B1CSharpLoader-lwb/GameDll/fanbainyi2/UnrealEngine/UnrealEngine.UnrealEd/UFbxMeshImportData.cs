using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[Abstract]
[UClass(Flags = (ClassFlags)1883246757uL, Config = "EditorPerProjectUserSettings")]
[BlueprintType]
[UMetaPath("/Script/UnrealEd.FbxMeshImportData", "UnrealEd", UnrealModuleType.Engine)]
public class UFbxMeshImportData : UFbxAssetImportData
{
	private static bool TransformVertexToAbsolute_IsValid;

	private static FFieldAddress TransformVertexToAbsolute_PropertyAddress;

	private static int TransformVertexToAbsolute_Offset;

	private static bool BakePivotInVertex_IsValid;

	private static FFieldAddress BakePivotInVertex_PropertyAddress;

	private static int BakePivotInVertex_Offset;

	private static bool ImportMeshLODs_IsValid;

	private static FFieldAddress ImportMeshLODs_PropertyAddress;

	private static int ImportMeshLODs_Offset;

	private static bool NormalImportMethod_IsValid;

	private static FFieldAddress NormalImportMethod_PropertyAddress;

	private static int NormalImportMethod_Offset;

	private static bool NormalGenerationMethod_IsValid;

	private static FFieldAddress NormalGenerationMethod_PropertyAddress;

	private static int NormalGenerationMethod_Offset;

	private static bool ComputeWeightedNormals_IsValid;

	private static FFieldAddress ComputeWeightedNormals_PropertyAddress;

	private static int ComputeWeightedNormals_Offset;

	private static bool ReorderMaterialToFbxOrder_IsValid;

	private static FFieldAddress ReorderMaterialToFbxOrder_PropertyAddress;

	private static int ReorderMaterialToFbxOrder_Offset;

	[UProperty(Flags = (PropFlags)6759867280802309uL)]
	[UMetaPath("/Script/UnrealEd.FbxMeshImportData:bTransformVertexToAbsolute")]
	public bool TransformVertexToAbsolute
	{
		get
		{
			CheckDestroyed();
			if (!TransformVertexToAbsolute_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxMeshImportData:bTransformVertexToAbsolute");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, TransformVertexToAbsolute_Offset), 0, TransformVertexToAbsolute_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TransformVertexToAbsolute_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxMeshImportData:bTransformVertexToAbsolute");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, TransformVertexToAbsolute_Offset), 0, TransformVertexToAbsolute_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280802309uL)]
	[UMetaPath("/Script/UnrealEd.FbxMeshImportData:bBakePivotInVertex")]
	public bool BakePivotInVertex
	{
		get
		{
			CheckDestroyed();
			if (!BakePivotInVertex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxMeshImportData:bBakePivotInVertex");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, BakePivotInVertex_Offset), 0, BakePivotInVertex_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BakePivotInVertex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxMeshImportData:bBakePivotInVertex");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, BakePivotInVertex_Offset), 0, BakePivotInVertex_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207059973uL)]
	[UMetaPath("/Script/UnrealEd.FbxMeshImportData:bImportMeshLODs")]
	public bool ImportMeshLODs
	{
		get
		{
			CheckDestroyed();
			if (!ImportMeshLODs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxMeshImportData:bImportMeshLODs");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ImportMeshLODs_Offset), 0, ImportMeshLODs_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ImportMeshLODs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxMeshImportData:bImportMeshLODs");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ImportMeshLODs_Offset), 0, ImportMeshLODs_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280802309uL)]
	[UMetaPath("/Script/UnrealEd.FbxMeshImportData:NormalImportMethod")]
	public EFBXNormalImportMethod NormalImportMethod
	{
		get
		{
			CheckDestroyed();
			if (!NormalImportMethod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxMeshImportData:NormalImportMethod");
				return EFBXNormalImportMethod.FBXNIM_ComputeNormals;
			}
			return EnumMarshaler<EFBXNormalImportMethod>.FromNative(IntPtr.Add(base.Address, NormalImportMethod_Offset), 0, NormalImportMethod_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NormalImportMethod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxMeshImportData:NormalImportMethod");
			}
			else
			{
				EnumMarshaler<EFBXNormalImportMethod>.ToNative(IntPtr.Add(base.Address, NormalImportMethod_Offset), 0, NormalImportMethod_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280802309uL)]
	[UMetaPath("/Script/UnrealEd.FbxMeshImportData:NormalGenerationMethod")]
	public EFBXNormalGenerationMethod NormalGenerationMethod
	{
		get
		{
			CheckDestroyed();
			if (!NormalGenerationMethod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxMeshImportData:NormalGenerationMethod");
				return EFBXNormalGenerationMethod.BuiltIn;
			}
			return EnumMarshaler<EFBXNormalGenerationMethod>.FromNative(IntPtr.Add(base.Address, NormalGenerationMethod_Offset), 0, NormalGenerationMethod_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NormalGenerationMethod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxMeshImportData:NormalGenerationMethod");
			}
			else
			{
				EnumMarshaler<EFBXNormalGenerationMethod>.ToNative(IntPtr.Add(base.Address, NormalGenerationMethod_Offset), 0, NormalGenerationMethod_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207059973uL)]
	[UMetaPath("/Script/UnrealEd.FbxMeshImportData:bComputeWeightedNormals")]
	public bool ComputeWeightedNormals
	{
		get
		{
			CheckDestroyed();
			if (!ComputeWeightedNormals_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxMeshImportData:bComputeWeightedNormals");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ComputeWeightedNormals_Offset), 0, ComputeWeightedNormals_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ComputeWeightedNormals_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxMeshImportData:bComputeWeightedNormals");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ComputeWeightedNormals_Offset), 0, ComputeWeightedNormals_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280802309uL)]
	[UMetaPath("/Script/UnrealEd.FbxMeshImportData:bReorderMaterialToFbxOrder")]
	public bool ReorderMaterialToFbxOrder
	{
		get
		{
			CheckDestroyed();
			if (!ReorderMaterialToFbxOrder_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxMeshImportData:bReorderMaterialToFbxOrder");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ReorderMaterialToFbxOrder_Offset), 0, ReorderMaterialToFbxOrder_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ReorderMaterialToFbxOrder_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxMeshImportData:bReorderMaterialToFbxOrder");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ReorderMaterialToFbxOrder_Offset), 0, ReorderMaterialToFbxOrder_PropertyAddress.Address, value);
			}
		}
	}

	static UFbxMeshImportData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UFbxMeshImportData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UFbxMeshImportData));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/UnrealEd.FbxMeshImportData");
		NativeReflectionCached.GetPropertyRef(ref TransformVertexToAbsolute_PropertyAddress, unrealStruct, "bTransformVertexToAbsolute");
		TransformVertexToAbsolute_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bTransformVertexToAbsolute");
		TransformVertexToAbsolute_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bTransformVertexToAbsolute", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BakePivotInVertex_PropertyAddress, unrealStruct, "bBakePivotInVertex");
		BakePivotInVertex_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bBakePivotInVertex");
		BakePivotInVertex_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bBakePivotInVertex", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportMeshLODs_PropertyAddress, unrealStruct, "bImportMeshLODs");
		ImportMeshLODs_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bImportMeshLODs");
		ImportMeshLODs_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bImportMeshLODs", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref NormalImportMethod_PropertyAddress, unrealStruct, "NormalImportMethod");
		NormalImportMethod_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "NormalImportMethod");
		NormalImportMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "NormalImportMethod", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref NormalGenerationMethod_PropertyAddress, unrealStruct, "NormalGenerationMethod");
		NormalGenerationMethod_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "NormalGenerationMethod");
		NormalGenerationMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "NormalGenerationMethod", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref ComputeWeightedNormals_PropertyAddress, unrealStruct, "bComputeWeightedNormals");
		ComputeWeightedNormals_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bComputeWeightedNormals");
		ComputeWeightedNormals_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bComputeWeightedNormals", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ReorderMaterialToFbxOrder_PropertyAddress, unrealStruct, "bReorderMaterialToFbxOrder");
		ReorderMaterialToFbxOrder_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bReorderMaterialToFbxOrder");
		ReorderMaterialToFbxOrder_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bReorderMaterialToFbxOrder", Classes.FBoolProperty);
	}
}
