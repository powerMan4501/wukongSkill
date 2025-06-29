using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_StaticMeshActorSetting")]
public class BGWDataAsset_StaticMeshActorSetting : UBGWDataAsset
{
	private static bool Mesh_IsValid;

	private static int Mesh_Offset;

	private static bool Materials_IsValid;

	private static int Materials_Offset;

	private static FFieldAddress Materials_PropertyAddress;

	private TArrayReadWriteMarshaler<UMaterialInterface> Materials_Marshaler;

	private static bool MaterialParameters_IsValid;

	private static int MaterialParameters_Offset;

	private static FFieldAddress MaterialParameters_PropertyAddress;

	private TArrayReadWriteMarshaler<FMatParam> MaterialParameters_Marshaler;

	private static bool DurationTime_IsValid;

	private static int DurationTime_Offset;

	[Tooltip("XY Scale 为动画所属角色胶囊体高度")]
	[Category("Mesh")]
	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_StaticMeshActorSetting:Mesh")]
	public UStaticMesh Mesh
	{
		get
		{
			CheckDestroyed();
			if (!Mesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StaticMeshActorSetting:Mesh");
				return null;
			}
			return UObjectMarshaler<UStaticMesh>.FromNative(IntPtr.Add(base.Address, Mesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Mesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StaticMeshActorSetting:Mesh");
			}
			else
			{
				UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(base.Address, Mesh_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Mesh")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_StaticMeshActorSetting:Materials")]
	public TArrayReadWrite<UMaterialInterface> Materials
	{
		get
		{
			CheckDestroyed();
			if (!Materials_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StaticMeshActorSetting:Materials");
				return null;
			}
			if (Materials_Marshaler == null)
			{
				Materials_Marshaler = new TArrayReadWriteMarshaler<UMaterialInterface>(1, Materials_PropertyAddress, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.FromNative, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.ToNative);
			}
			return Materials_Marshaler.FromNative(IntPtr.Add(base.Address, Materials_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("Mesh")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_StaticMeshActorSetting:MaterialParameters")]
	public TArrayReadWrite<FMatParam> MaterialParameters
	{
		get
		{
			CheckDestroyed();
			if (!MaterialParameters_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StaticMeshActorSetting:MaterialParameters");
				return null;
			}
			if (MaterialParameters_Marshaler == null)
			{
				MaterialParameters_Marshaler = new TArrayReadWriteMarshaler<FMatParam>(1, MaterialParameters_PropertyAddress, CachedMarshalingDelegates<FMatParam, FMatParam>.FromNative, CachedMarshalingDelegates<FMatParam, FMatParam>.ToNative);
			}
			return MaterialParameters_Marshaler.FromNative(IntPtr.Add(base.Address, MaterialParameters_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("Mesh")]
	[Tooltip("-1: 不主动销毁 0:根据材质参数曲线调整")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_StaticMeshActorSetting:DurationTime")]
	public int DurationTime
	{
		get
		{
			CheckDestroyed();
			if (!DurationTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StaticMeshActorSetting:DurationTime");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, DurationTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DurationTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StaticMeshActorSetting:DurationTime");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, DurationTime_Offset), value);
			}
		}
	}

	public float ExistedTime { get; set; }

	public float TotalExistTime { get; set; }

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_StaticMeshActorSetting");
		Mesh_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Mesh");
		Mesh_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Mesh", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref Materials_PropertyAddress, unrealStruct, "Materials");
		Materials_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Materials");
		Materials_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Materials", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref MaterialParameters_PropertyAddress, unrealStruct, "MaterialParameters");
		MaterialParameters_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MaterialParameters");
		MaterialParameters_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MaterialParameters", Classes.FArrayProperty);
		DurationTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DurationTime");
		DurationTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DurationTime", Classes.FIntProperty);
	}

	static BGWDataAsset_StaticMeshActorSetting()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_StaticMeshActorSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_StaticMeshActorSetting));
	}
}
