using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkGeometryComponent", "AkAudio", UnrealModuleType.GamePlugin)]
public class UAkGeometryComponent : UAkAcousticTextureSetComponent
{
	private static bool MeshType_IsValid;

	private static FFieldAddress MeshType_PropertyAddress;

	private static int MeshType_Offset;

	private static bool LOD_IsValid;

	private static int LOD_Offset;

	private static bool WeldingThreshold_IsValid;

	private static int WeldingThreshold_Offset;

	private static bool StaticMeshSurfaceOverride_IsValid;

	private static FFieldAddress StaticMeshSurfaceOverride_PropertyAddress;

	private static int StaticMeshSurfaceOverride_Offset;

	private TMapReadWriteMarshaler<UMaterialInterface, FAkGeometrySurfaceOverride> StaticMeshSurfaceOverride_MarshalerCached;

	private static bool CollisionMeshSurfaceOverride_IsValid;

	private static int CollisionMeshSurfaceOverride_Offset;

	private static bool EnableDiffraction_IsValid;

	private static FFieldAddress EnableDiffraction_PropertyAddress;

	private static int EnableDiffraction_Offset;

	private static bool EnableDiffractionOnBoundaryEdges_IsValid;

	private static FFieldAddress EnableDiffractionOnBoundaryEdges_PropertyAddress;

	private static int EnableDiffractionOnBoundaryEdges_Offset;

	private static bool AssociatedRoom_IsValid;

	private static int AssociatedRoom_Offset;

	private static bool UpdateGeometry_IsValid;

	private static IntPtr UpdateGeometry_FunctionAddress;

	private static int UpdateGeometry_ParamsSize;

	private static bool SendGeometry_IsValid;

	private static IntPtr SendGeometry_FunctionAddress;

	private static int SendGeometry_ParamsSize;

	private static bool RemoveGeometry_IsValid;

	private static IntPtr RemoveGeometry_FunctionAddress;

	private static int RemoveGeometry_ParamsSize;

	private static bool ConvertMesh_IsValid;

	private static IntPtr ConvertMesh_FunctionAddress;

	private static int ConvertMesh_ParamsSize;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkGeometryComponent:MeshType")]
	public EAkMeshType MeshType
	{
		get
		{
			CheckDestroyed();
			if (!MeshType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkGeometryComponent:MeshType");
				return EAkMeshType.StaticMesh;
			}
			return EnumMarshaler<EAkMeshType>.FromNative(IntPtr.Add(base.Address, MeshType_Offset), 0, MeshType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MeshType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkGeometryComponent:MeshType");
			}
			else
			{
				EnumMarshaler<EAkMeshType>.ToNative(IntPtr.Add(base.Address, MeshType_Offset), 0, MeshType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkGeometryComponent:LOD")]
	public int LOD
	{
		get
		{
			CheckDestroyed();
			if (!LOD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkGeometryComponent:LOD");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, LOD_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LOD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkGeometryComponent:LOD");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, LOD_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkGeometryComponent:WeldingThreshold")]
	public float WeldingThreshold
	{
		get
		{
			CheckDestroyed();
			if (!WeldingThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkGeometryComponent:WeldingThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, WeldingThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WeldingThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkGeometryComponent:WeldingThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, WeldingThreshold_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/AkAudio.AkGeometryComponent:StaticMeshSurfaceOverride")]
	public TMapReadWrite<UMaterialInterface, FAkGeometrySurfaceOverride> StaticMeshSurfaceOverride
	{
		get
		{
			CheckDestroyed();
			if (!StaticMeshSurfaceOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkGeometryComponent:StaticMeshSurfaceOverride");
				return null;
			}
			if (StaticMeshSurfaceOverride_MarshalerCached == null)
			{
				StaticMeshSurfaceOverride_MarshalerCached = new TMapReadWriteMarshaler<UMaterialInterface, FAkGeometrySurfaceOverride>(1, StaticMeshSurfaceOverride_PropertyAddress, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.FromNative, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.ToNative, CachedMarshalingDelegates<FAkGeometrySurfaceOverride, FAkGeometrySurfaceOverride>.FromNative, CachedMarshalingDelegates<FAkGeometrySurfaceOverride, FAkGeometrySurfaceOverride>.ToNative);
			}
			return StaticMeshSurfaceOverride_MarshalerCached.FromNative(IntPtr.Add(base.Address, StaticMeshSurfaceOverride_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AkAudio.AkGeometryComponent:CollisionMeshSurfaceOverride")]
	public FAkGeometrySurfaceOverride CollisionMeshSurfaceOverride
	{
		get
		{
			CheckDestroyed();
			if (!CollisionMeshSurfaceOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkGeometryComponent:CollisionMeshSurfaceOverride");
				return default(FAkGeometrySurfaceOverride);
			}
			return FAkGeometrySurfaceOverride.FromNative(IntPtr.Add(base.Address, CollisionMeshSurfaceOverride_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CollisionMeshSurfaceOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkGeometryComponent:CollisionMeshSurfaceOverride");
			}
			else
			{
				FAkGeometrySurfaceOverride.ToNative(IntPtr.Add(base.Address, CollisionMeshSurfaceOverride_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkGeometryComponent:bEnableDiffraction")]
	public bool EnableDiffraction
	{
		get
		{
			CheckDestroyed();
			if (!EnableDiffraction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkGeometryComponent:bEnableDiffraction");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableDiffraction_Offset), 0, EnableDiffraction_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableDiffraction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkGeometryComponent:bEnableDiffraction");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableDiffraction_Offset), 0, EnableDiffraction_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkGeometryComponent:bEnableDiffractionOnBoundaryEdges")]
	public bool EnableDiffractionOnBoundaryEdges
	{
		get
		{
			CheckDestroyed();
			if (!EnableDiffractionOnBoundaryEdges_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkGeometryComponent:bEnableDiffractionOnBoundaryEdges");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableDiffractionOnBoundaryEdges_Offset), 0, EnableDiffractionOnBoundaryEdges_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableDiffractionOnBoundaryEdges_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkGeometryComponent:bEnableDiffractionOnBoundaryEdges");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableDiffractionOnBoundaryEdges_Offset), 0, EnableDiffractionOnBoundaryEdges_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkGeometryComponent:AssociatedRoom")]
	public AActor AssociatedRoom
	{
		get
		{
			CheckDestroyed();
			if (!AssociatedRoom_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkGeometryComponent:AssociatedRoom");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, AssociatedRoom_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AssociatedRoom_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkGeometryComponent:AssociatedRoom");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, AssociatedRoom_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AkAudio.AkGeometryComponent:UpdateGeometry")]
	public unsafe void UpdateGeometry()
	{
		CheckDestroyed();
		if (!UpdateGeometry_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGeometryComponent:UpdateGeometry");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateGeometry_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateGeometry_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: UpdateGeometry_FunctionAddress, argsSize: UpdateGeometry_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AkAudio.AkGeometryComponent:SendGeometry")]
	public unsafe void SendGeometry()
	{
		CheckDestroyed();
		if (!SendGeometry_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGeometryComponent:SendGeometry");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SendGeometry_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SendGeometry_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: SendGeometry_FunctionAddress, argsSize: SendGeometry_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AkAudio.AkGeometryComponent:RemoveGeometry")]
	public unsafe void RemoveGeometry()
	{
		CheckDestroyed();
		if (!RemoveGeometry_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGeometryComponent:RemoveGeometry");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveGeometry_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveGeometry_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RemoveGeometry_FunctionAddress, argsSize: RemoveGeometry_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AkAudio.AkGeometryComponent:ConvertMesh")]
	public unsafe void ConvertMesh()
	{
		CheckDestroyed();
		if (!ConvertMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGeometryComponent:ConvertMesh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertMesh_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ConvertMesh_FunctionAddress, argsSize: ConvertMesh_ParamsSize);
	}

	static UAkGeometryComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAkGeometryComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAkGeometryComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AkAudio.AkGeometryComponent");
		NativeReflectionCached.GetPropertyRef(ref MeshType_PropertyAddress, intPtr, "MeshType");
		MeshType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MeshType");
		MeshType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MeshType", Classes.FEnumProperty);
		LOD_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LOD");
		LOD_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LOD", Classes.FIntProperty);
		WeldingThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WeldingThreshold");
		WeldingThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WeldingThreshold", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref StaticMeshSurfaceOverride_PropertyAddress, intPtr, "StaticMeshSurfaceOverride");
		StaticMeshSurfaceOverride_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StaticMeshSurfaceOverride");
		StaticMeshSurfaceOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StaticMeshSurfaceOverride", Classes.FMapProperty);
		CollisionMeshSurfaceOverride_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CollisionMeshSurfaceOverride");
		CollisionMeshSurfaceOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CollisionMeshSurfaceOverride", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableDiffraction_PropertyAddress, intPtr, "bEnableDiffraction");
		EnableDiffraction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableDiffraction");
		EnableDiffraction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableDiffraction", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableDiffractionOnBoundaryEdges_PropertyAddress, intPtr, "bEnableDiffractionOnBoundaryEdges");
		EnableDiffractionOnBoundaryEdges_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableDiffractionOnBoundaryEdges");
		EnableDiffractionOnBoundaryEdges_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableDiffractionOnBoundaryEdges", Classes.FBoolProperty);
		AssociatedRoom_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AssociatedRoom");
		AssociatedRoom_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AssociatedRoom", Classes.FObjectProperty);
		UpdateGeometry_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateGeometry");
		UpdateGeometry_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateGeometry_FunctionAddress);
		UpdateGeometry_IsValid = UpdateGeometry_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGeometryComponent:UpdateGeometry", UpdateGeometry_IsValid);
		SendGeometry_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SendGeometry");
		SendGeometry_ParamsSize = NativeReflection.GetFunctionParamsSize(SendGeometry_FunctionAddress);
		SendGeometry_IsValid = SendGeometry_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGeometryComponent:SendGeometry", SendGeometry_IsValid);
		RemoveGeometry_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveGeometry");
		RemoveGeometry_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveGeometry_FunctionAddress);
		RemoveGeometry_IsValid = RemoveGeometry_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGeometryComponent:RemoveGeometry", RemoveGeometry_IsValid);
		ConvertMesh_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ConvertMesh");
		ConvertMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertMesh_FunctionAddress);
		ConvertMesh_IsValid = ConvertMesh_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGeometryComponent:ConvertMesh", ConvertMesh_IsValid);
	}
}
